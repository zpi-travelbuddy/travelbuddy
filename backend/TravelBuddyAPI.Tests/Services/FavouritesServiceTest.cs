using Microsoft.EntityFrameworkCore;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.FavouriteProfiles;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.Services;
using Xunit;

namespace TravelBuddyAPI.Tests.Services;

public class FavouritesServiceTest
{
    private readonly TravelBuddyDbContext _dbContext;
    private readonly FavouritesService _favouritesService;

    public FavouritesServiceTest()
    {
        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _dbContext = new TravelBuddyDbContext(options);
        _favouritesService = new FavouritesService(_dbContext);
    }

    [Fact]
    public async Task AddCategoryProfileToFavouritesAsync_ValidRequest_ShouldAddCategoryProfile()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var profileId = Guid.NewGuid();
        var categoryProfile = new CategoryProfile { Id = profileId, UserId = userId, Name = "Test" };
        await _dbContext.CategoryProfiles.AddAsync(categoryProfile);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _favouritesService.AddCategoryProfileToFavouritesAsync(userId, profileId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(profileId, result.CategoryProfileId);
    }

    [Fact]
    public async Task AddCategoryProfileToFavouritesAsync_ProfileNotFound_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var profileId = Guid.NewGuid();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _favouritesService.AddCategoryProfileToFavouritesAsync(userId, profileId));
        Assert.Equal(IFavouritesService.ErrorMessage.CategoryProfileNotFound, exception.Message);
    }

    [Fact]
    public async Task AddConditionProfileToFavouritesAsync_ValidRequest_ShouldAddConditionProfile()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var profileId = Guid.NewGuid();
        var conditionProfile = new ConditionProfile { Id = profileId, UserId = userId , Name = "Test" };
        await _dbContext.ConditionProfiles.AddAsync(conditionProfile);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _favouritesService.AddConditionProfileToFavouritesAsync(userId, profileId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(profileId, result.ConditionProfileId);
    }

    [Fact]
    public async Task AddConditionProfileToFavouritesAsync_ProfileNotFound_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var profileId = Guid.NewGuid();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _favouritesService.AddConditionProfileToFavouritesAsync(userId, profileId));
        Assert.Equal(IFavouritesService.ErrorMessage.ConditionProfileNotFound, exception.Message);
    }

    [Fact]
    public async Task GetFavouriteProfilesAsync_ValidRequest_ShouldReturnFavouriteProfiles()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var favouriteProfiles = new FavouriteProfiles { UserId = userId };
        await _dbContext.Favourites.AddAsync(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _favouritesService.GetFavouriteProfilesAsync(userId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(favouriteProfiles.CategoryProfileId, result.CategoryProfileId);
        Assert.Equal(favouriteProfiles.ConditionProfileId, result.ConditionProfileId);
    }

    [Fact]
    public async Task GetFavouriteProfilesAsync_FavouritesNotFound_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _favouritesService.GetFavouriteProfilesAsync(userId));
        Assert.Equal(IFavouritesService.ErrorMessage.FavouritesProfilesNotFound, exception.Message);
    }

    [Fact]
    public async Task RemoveCategoryProfileFromFavouritesAsync_ValidRequest_ShouldRemoveCategoryProfile()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var profileId = Guid.NewGuid();
        var favouriteProfiles = new FavouriteProfiles { UserId = userId, CategoryProfileId = profileId };
        await _dbContext.Favourites.AddAsync(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _favouritesService.RemoveCategoryProfileFromFavouritesAsync(userId, profileId);

        // Assert
        Assert.True(result);
        Assert.Null(favouriteProfiles.CategoryProfileId);
    }

    [Fact]
    public async Task RemoveCategoryProfileFromFavouritesAsync_ProfileNotFound_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var profileId = Guid.NewGuid();
        var favouriteProfiles = new FavouriteProfiles { UserId = userId, CategoryProfileId = Guid.NewGuid() };
        await _dbContext.Favourites.AddAsync(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _favouritesService.RemoveCategoryProfileFromFavouritesAsync(userId, profileId));
        Assert.Equal(IFavouritesService.ErrorMessage.CategoryProfileNotFound, exception.Message);
    }

    [Fact]
    public async Task RemoveConditionProfileFromFavouritesAsync_ValidRequest_ShouldRemoveConditionProfile()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var profileId = Guid.NewGuid();
        var favouriteProfiles = new FavouriteProfiles { UserId = userId, ConditionProfileId = profileId };
        await _dbContext.Favourites.AddAsync(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _favouritesService.RemoveConditionProfileFromFavouritesAsync(userId, profileId);

        // Assert
        Assert.True(result);
        Assert.Null(favouriteProfiles.ConditionProfileId);
    }

    [Fact]
    public async Task RemoveConditionProfileFromFavouritesAsync_ProfileNotFound_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = Guid.NewGuid().ToString();
        var profileId = Guid.NewGuid();
        var favouriteProfiles = new FavouriteProfiles { UserId = userId, ConditionProfileId = Guid.NewGuid() };
        await _dbContext.Favourites.AddAsync(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _favouritesService.RemoveConditionProfileFromFavouritesAsync(userId, profileId));
        Assert.Equal(IFavouritesService.ErrorMessage.ConditionProfileNotFound, exception.Message);
    }
}