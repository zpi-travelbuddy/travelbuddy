using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.CategoryProfile;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.Services;
using Xunit;

namespace TravelBuddyAPI.Tests.Services
{
    public class CategoryProfilesServiceTest : IDisposable
    {
        private readonly TravelBuddyDbContext _dbContext;
        private readonly CategoryProfilesService _categoryProfilesService;

        public CategoryProfilesServiceTest()
        {
            var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _dbContext = new TravelBuddyDbContext(options);
            _categoryProfilesService = new CategoryProfilesService(_dbContext);
        }

        [Fact]
        public async Task CreateCategoryProfileAsync_ReturnsCategoryProfileDetailsDTO()
        {
            // Arrange
            var userId = "user1";
            var categoryProfileRequest = new CategoryProfileRequestDTO
            {
                Name = "Test Profile",
                CategoryIds = new List<Guid>()
            };

            // Act
            var result = await _categoryProfilesService.CreateCategoryProfileAsync(userId, categoryProfileRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(categoryProfileRequest.Name, result.Name);
        }

        [Fact]
        public async Task CreateCategoryProfileAsync_ReturnsCategoryProfileDetailsDTO_WithCategories()
        {
            // Arrange
            var userId = "user1";
            var category1 = new PlaceCategory { Id = Guid.NewGuid(), Name = "Category 1" };
            var category2 = new PlaceCategory { Id = Guid.NewGuid(), Name = "Category 2" };

            await _dbContext.PlaceCategories.AddRangeAsync(category1, category2);
            await _dbContext.SaveChangesAsync();

            var categoryProfileRequest = new CategoryProfileRequestDTO
            {
                Name = "Test Profile with Categories",
                CategoryIds = new List<Guid> { category1.Id, category2.Id }
            };

            // Act
            var result = await _categoryProfilesService.CreateCategoryProfileAsync(userId, categoryProfileRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(categoryProfileRequest.Name, result.Name);
            Assert.NotNull(result.Categories);
            Assert.Equal(2, result.Categories.Count);
            Assert.Contains(result.Categories, c => c.Id == category1.Id);
            Assert.Contains(result.Categories, c => c.Id == category2.Id);
        }

        [Fact]
        public async Task CreateCategoryProfileAsync_ThrowsInvalidOperationException_WhenNameAlreadyExists()
        {
            // Arrange
            var userId = "user1";
            var existingProfile = new CategoryProfile
            {
                Id = Guid.NewGuid(),
                Name = "Test Profile",
                UserId = userId
            };

            await _dbContext.CategoryProfiles.AddAsync(existingProfile);
            await _dbContext.SaveChangesAsync();

            var categoryProfileRequest = new CategoryProfileRequestDTO
            {
                Name = "Test Profile",
                CategoryIds = new List<Guid>()
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _categoryProfilesService.CreateCategoryProfileAsync(userId, categoryProfileRequest));
            Assert.Equal($"{ICategoryProfilesService.ErrorMessage.CreatingCategoryProfile} {ICategoryProfilesService.ErrorMessage.CategoryProfileNameAlreadyExists}", exception.Message);
        }

        [Fact]
        public async Task DeleteCategoryProfileAsync_ReturnsTrue_WhenCategoryProfileIsDeleted()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var categoryProfile = new CategoryProfile
            {
                Id = profileId,
                Name = "Test Profile",
                UserId = userId
            };

            await _dbContext.CategoryProfiles.AddAsync(categoryProfile);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _categoryProfilesService.DeleteCategoryProfileAsync(userId, profileId);

            // Assert
            Assert.True(result);
            Assert.Null(await _dbContext.CategoryProfiles.FindAsync(profileId));
        }

        [Fact]
        public async Task DeleteCategoryProfileAsync_ThrowsInvalidOperationException_WhenCategoryProfileNotFound()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _categoryProfilesService.DeleteCategoryProfileAsync(userId, profileId));
            Assert.Equal($"{ICategoryProfilesService.ErrorMessage.DeletingCategoryProfile} {ICategoryProfilesService.ErrorMessage.CategoryProfileNotFound}", exception.Message);
        }

        [Fact]
        public async Task DeleteCategoryProfileAsync_ThrowsInvalidOperationException_WhenCategoryProfileIsUsedInTrip()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var categoryProfile = new CategoryProfile
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
                CategoryProfileId = profileId
            };

            await _dbContext.CategoryProfiles.AddAsync(categoryProfile);
            await _dbContext.Trips.AddAsync(trip);
            await _dbContext.SaveChangesAsync();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _categoryProfilesService.DeleteCategoryProfileAsync(userId, profileId));
            Assert.Equal($"{ICategoryProfilesService.ErrorMessage.DeletingCategoryProfile} {ICategoryProfilesService.ErrorMessage.TripUsesCategoryProfile}", exception.Message);
        }

        [Fact]
        public async Task EditCategoryProfileAsync_ReturnsTrue_WhenCategoryProfileIsEdited()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var categoryProfile = new CategoryProfile
            {
                Id = profileId,
                Name = "Test Profile",
                UserId = userId
            };

            await _dbContext.CategoryProfiles.AddAsync(categoryProfile);
            await _dbContext.SaveChangesAsync();

            var categoryProfileRequest = new CategoryProfileRequestDTO
            {
                Name = "Updated Profile",
                CategoryIds = new List<Guid>()
            };

            // Act
            var result = await _categoryProfilesService.EditCategoryProfileAsync(userId, profileId, categoryProfileRequest);

            // Assert
            Assert.True(result);
            var updatedProfile = await _dbContext.CategoryProfiles.FindAsync(profileId);
            Assert.NotNull(updatedProfile);
            Assert.Equal(categoryProfileRequest.Name, updatedProfile.Name);
        }

        [Fact]
        public async Task EditCategoryProfileAsync_ReturnsTrue_WhenCategoriesAreEdited()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var category1 = new PlaceCategory { Id = Guid.NewGuid(), Name = "Category 1" };
            var category2 = new PlaceCategory { Id = Guid.NewGuid(), Name = "Category 2" };
            var category3 = new PlaceCategory { Id = Guid.NewGuid(), Name = "Category 3" };

            await _dbContext.PlaceCategories.AddRangeAsync(category1, category2, category3);
            await _dbContext.SaveChangesAsync();

            var categoryProfile = new CategoryProfile
            {
            Id = profileId,
            Name = "Test Profile",
            UserId = userId,
            Categories = new List<PlaceCategory> { category1, category2 }
            };

            await _dbContext.CategoryProfiles.AddAsync(categoryProfile);
            await _dbContext.SaveChangesAsync();

            var categoryProfileRequest = new CategoryProfileRequestDTO
            {
            Name = "Test Profile",
            CategoryIds = new List<Guid> { category2.Id, category3.Id }
            };

            // Act
            var result = await _categoryProfilesService.EditCategoryProfileAsync(userId, profileId, categoryProfileRequest);

            // Assert
            Assert.True(result);
            var updatedProfile = await _dbContext.CategoryProfiles
            .Include(cp => cp.Categories)
            .FirstOrDefaultAsync(cp => cp.Id == profileId);
            Assert.NotNull(updatedProfile);
            Assert.Equal(categoryProfileRequest.Name, updatedProfile.Name);
            Assert.NotNull(updatedProfile.Categories);
            Assert.Equal(2, updatedProfile.Categories.Count);
            Assert.Contains(updatedProfile.Categories, c => c.Id == category2.Id);
            Assert.Contains(updatedProfile.Categories, c => c.Id == category3.Id);
        }

        [Fact]
        public async Task EditCategoryProfileAsync_ThrowsInvalidOperationException_WhenCategoryProfileNotFound()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var categoryProfileRequest = new CategoryProfileRequestDTO
            {
                Name = "Updated Profile",
                CategoryIds = new List<Guid>()
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _categoryProfilesService.EditCategoryProfileAsync(userId, profileId, categoryProfileRequest));
            Assert.Equal($"{ICategoryProfilesService.ErrorMessage.EditingCategoryProfile} {ICategoryProfilesService.ErrorMessage.CategoryProfileNotFound}", exception.Message);
        }

        [Fact]
        public async Task GetCategoryProfileDetailsAsync_ReturnsCategoryProfileDetailsDTO()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            var categoryProfile = new CategoryProfile
            {
                Id = profileId,
                Name = "Test Profile",
                UserId = userId
            };

            await _dbContext.CategoryProfiles.AddAsync(categoryProfile);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _categoryProfilesService.GetCategoryProfileDetailsAsync(userId, profileId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(categoryProfile.Name, result.Name);
        }

        [Fact]
        public async Task GetCategoryProfileDetailsAsync_ThrowsInvalidOperationException_WhenCategoryProfileNotFound()
        {
            // Arrange
            var userId = "user1";
            var profileId = Guid.NewGuid();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _categoryProfilesService.GetCategoryProfileDetailsAsync(userId, profileId));
            Assert.Equal($"{ICategoryProfilesService.ErrorMessage.CategoryProfileNotFound}", exception.Message);
        }

        [Fact]
        public async Task GetUserCategoryProfilesAsync_ReturnsListOfCategoryProfileOverviewDTO()
        {
            // Arrange
            var userId = "user1";

            var categoryProfiles = new List<CategoryProfile>
            {
                new CategoryProfile { Id = Guid.NewGuid(), Name = "Profile 1", UserId = userId },
                new CategoryProfile { Id = Guid.NewGuid(), Name = "Profile 2", UserId = userId }
            };

            await _dbContext.CategoryProfiles.AddRangeAsync(categoryProfiles);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _categoryProfilesService.GetUserCategoryProfilesAsync(userId);

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