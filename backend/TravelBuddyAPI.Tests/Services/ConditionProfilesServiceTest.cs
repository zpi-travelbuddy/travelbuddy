using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.ConditionProfile;
using TravelBuddyAPI.DTOs.PlaceCondition;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.Services;
using Xunit;

namespace TravelBuddyAPI.Tests.Services
{
    public class ConditionProfilesServiceTest : IDisposable
    {
        private readonly TravelBuddyDbContext _dbContext;
        private readonly ConditionProfilesService _conditionProfilesService;

        public ConditionProfilesServiceTest()
        {
            var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _dbContext = new TravelBuddyDbContext(options);
            _conditionProfilesService = new ConditionProfilesService(_dbContext);
        }

        [Fact]
        public async Task CreateConditionProfileAsync_ReturnsConditionProfileDetailsDTO()
        {
            // Arrange
            var userId = "user1";
            var conditionProfileRequest = new ConditionProfileRequestDTO
            {
                Name = "Test Profile",
                ConditionIds = new List<Guid>()
            };

            // Act
            var result = await _conditionProfilesService.CreateConditionProfileAsync(userId, conditionProfileRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(conditionProfileRequest.Name, result.Name);
        }

        [Fact]
        public async Task CreateConditionProfileAsync_ReturnsConditionProfileDetailsDTO_WithConditions()
        {
            // Arrange
            var userId = "user1";
            var condition1 = new PlaceCondition { Id = Guid.NewGuid(), Name = "Condition 1" };
            var condition2 = new PlaceCondition { Id = Guid.NewGuid(), Name = "Condition 2" };

            await _dbContext.PlaceConditions.AddRangeAsync(condition1, condition2);
            await _dbContext.SaveChangesAsync();

            var conditionProfileRequest = new ConditionProfileRequestDTO
            {
                Name = "Test Profile with Conditions",
                ConditionIds = new List<Guid> { condition1.Id, condition2.Id }
            };

            // Act
            var result = await _conditionProfilesService.CreateConditionProfileAsync(userId, conditionProfileRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(conditionProfileRequest.Name, result.Name);
            Assert.NotNull(result.Conditions);
            Assert.Equal(2, result.Conditions.Count);
            Assert.Contains(result.Conditions, c => c.Id == condition1.Id);
            Assert.Contains(result.Conditions, c => c.Id == condition2.Id);
        }

        [Fact]
        public async Task CreateConditionProfileAsync_ThrowsInvalidOperationException_WhenNameAlreadyExists()
        {
            // Arrange
            var userId = "user1";
            var existingProfile = new ConditionProfile
            {
                Id = Guid.NewGuid(),
                Name = "Test Profile",
                UserId = userId
            };

            await _dbContext.ConditionProfiles.AddAsync(existingProfile);
            await _dbContext.SaveChangesAsync();

            var conditionProfileRequest = new ConditionProfileRequestDTO
            {
                Name = "Test Profile",
                ConditionIds = new List<Guid>()
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _conditionProfilesService.CreateConditionProfileAsync(userId, conditionProfileRequest));
            Assert.Equal($"{IConditionProfilesService.ErrorMessage.CreatingConditionProfile} {IConditionProfilesService.ErrorMessage.ConditionProfileNameAlreadyExists}", exception.Message);
        }

        [Fact]
        public async Task DeleteConditionProfileAsync_ReturnsTrue_WhenConditionProfileIsDeleted()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var conditionProfile = new ConditionProfile
            {
                Id = profileId,
                Name = "Test Profile",
                UserId = userId
            };

            await _dbContext.ConditionProfiles.AddAsync(conditionProfile);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _conditionProfilesService.DeleteConditionProfileAsync(userId, profileId);

            // Assert
            Assert.True(result);
            Assert.Null(await _dbContext.ConditionProfiles.FindAsync(profileId));
        }

        [Fact]
        public async Task DeleteConditionProfileAsync_ThrowsInvalidOperationException_WhenConditionProfileNotFound()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _conditionProfilesService.DeleteConditionProfileAsync(userId, profileId));
            Assert.Equal($"{IConditionProfilesService.ErrorMessage.DeletingConditionProfile} {IConditionProfilesService.ErrorMessage.ConditionProfileNotFound}", exception.Message);
        }

        [Fact]
        public async Task DeleteConditionProfileAsync_ThrowsInvalidOperationException_WhenConditionProfileIsUsedInTrip()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var conditionProfile = new ConditionProfile
            {
                Id = profileId,
                Name = "Test Profile",
                UserId = userId
            };

            var trip = new Trip
            {
                Id = Guid.NewGuid(),
                Name = "Test Trip",
                UserId = userId,
                CurrencyCode = "USD",
                ConditionProfileId = profileId
            };

            await _dbContext.ConditionProfiles.AddAsync(conditionProfile);
            await _dbContext.Trips.AddAsync(trip);
            await _dbContext.SaveChangesAsync();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _conditionProfilesService.DeleteConditionProfileAsync(userId, profileId));
            Assert.Equal($"{IConditionProfilesService.ErrorMessage.DeletingConditionProfile} {IConditionProfilesService.ErrorMessage.TripUsesConditionProfile}", exception.Message);
        }

        [Fact]
        public async Task EditConditionProfileAsync_ReturnsTrue_WhenConditionProfileIsEdited()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var conditionProfile = new ConditionProfile
            {
                Id = profileId,
                Name = "Test Profile",
                UserId = userId
            };

            await _dbContext.ConditionProfiles.AddAsync(conditionProfile);
            await _dbContext.SaveChangesAsync();

            var conditionProfileRequest = new ConditionProfileRequestDTO
            {
                Name = "Updated Profile",
                ConditionIds = new List<Guid>()
            };

            // Act
            var result = await _conditionProfilesService.EditConditionProfileAsync(userId, profileId, conditionProfileRequest);

            // Assert
            Assert.True(result);
            var updatedProfile = await _dbContext.ConditionProfiles.FindAsync(profileId);
            Assert.NotNull(updatedProfile);
            Assert.Equal(conditionProfileRequest.Name, updatedProfile.Name);
        }

        [Fact]
        public async Task EditConditionProfileAsync_ReturnsTrue_WhenConditionsAreEdited()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var condition1 = new PlaceCondition { Id = Guid.NewGuid(), Name = "Condition 1" };
            var condition2 = new PlaceCondition { Id = Guid.NewGuid(), Name = "Condition 2" };
            var condition3 = new PlaceCondition { Id = Guid.NewGuid(), Name = "Condition 3" };

            await _dbContext.PlaceConditions.AddRangeAsync(condition1, condition2, condition3);
            await _dbContext.SaveChangesAsync();

            var conditionProfile = new ConditionProfile
            {
            Id = profileId,
            Name = "Test Profile",
            UserId = userId,
            Conditions = new List<PlaceCondition> { condition1, condition2 }
            };

            await _dbContext.ConditionProfiles.AddAsync(conditionProfile);
            await _dbContext.SaveChangesAsync();

            var conditionProfileRequest = new ConditionProfileRequestDTO
            {
            Name = "Test Profile",
            ConditionIds = new List<Guid> { condition2.Id, condition3.Id }
            };

            // Act
            var result = await _conditionProfilesService.EditConditionProfileAsync(userId, profileId, conditionProfileRequest);

            // Assert
            Assert.True(result);
            var updatedProfile = await _dbContext.ConditionProfiles
            .Include(cp => cp.Conditions)
            .FirstOrDefaultAsync(cp => cp.Id == profileId);
            Assert.NotNull(updatedProfile);
            Assert.Equal(conditionProfileRequest.Name, updatedProfile.Name);
            Assert.NotNull(updatedProfile.Conditions);
            Assert.Equal(2, updatedProfile.Conditions.Count);
            Assert.Contains(updatedProfile.Conditions, c => c.Id == condition2.Id);
            Assert.Contains(updatedProfile.Conditions, c => c.Id == condition3.Id);
        }

        [Fact]
        public async Task EditConditionProfileAsync_ThrowsInvalidOperationException_WhenConditionProfileNotFound()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var conditionProfileRequest = new ConditionProfileRequestDTO
            {
                Name = "Updated Profile",
                ConditionIds = new List<Guid>()
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _conditionProfilesService.EditConditionProfileAsync(userId, profileId, conditionProfileRequest));
            Assert.Equal($"{IConditionProfilesService.ErrorMessage.EditingConditionProfile} {IConditionProfilesService.ErrorMessage.ConditionProfileNotFound}", exception.Message);
        }

        [Fact]
        public async Task GetConditionProfileDetailsAsync_ReturnsConditionProfileDetailsDTO()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var conditionProfile = new ConditionProfile
            {
                Id = profileId,
                Name = "Test Profile",
                UserId = userId
            };

            await _dbContext.ConditionProfiles.AddAsync(conditionProfile);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _conditionProfilesService.GetConditionProfileDetailsAsync(userId, profileId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(conditionProfile.Name, result.Name);
        }

        [Fact]
        public async Task GetConditionProfileDetailsAsync_ThrowsInvalidOperationException_WhenConditionProfileNotFound()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _conditionProfilesService.GetConditionProfileDetailsAsync(userId, profileId));
            Assert.Equal($"{IConditionProfilesService.ErrorMessage.ConditionProfileNotFound}", exception.Message);
        }

        [Fact]
        public async Task GetUserConditionProfilesAsync_ReturnsListOfConditionProfileOverviewDTO()
        {
            // Arrange
            var userId = "user1";

            var conditionProfiles = new List<ConditionProfile>
            {
                new ConditionProfile { Id = Guid.NewGuid(), Name = "Profile 1", UserId = userId },
                new ConditionProfile { Id = Guid.NewGuid(), Name = "Profile 2", UserId = userId }
            };

            await _dbContext.ConditionProfiles.AddRangeAsync(conditionProfiles);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _conditionProfilesService.GetUserConditionProfilesAsync(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, cp => cp.Name == "Profile 1");
            Assert.Contains(result, cp => cp.Name == "Profile 2");
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}