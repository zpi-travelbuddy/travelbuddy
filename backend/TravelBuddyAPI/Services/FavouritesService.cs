using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.FavouriteProfiles;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Services;

public class FavouritesService(TravelBuddyDbContext dbContext) : IFavouritesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;


    public async Task<FavouriteProfilesDTO> AddCategoryProfileToFavouritesAsync(string userId, Guid profileId)
    {
        CategoryProfile categoryProfile = await _dbContext.CategoryProfiles
            .Where(cp => cp.Id == profileId && cp.UserId == userId)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(IFavouritesService.ErrorMessage.CategoryProfileNotFound);

        FavouriteProfiles favouriteProfiles = await _dbContext.Favourites
            .Where(f => f.UserId == userId)
            .FirstOrDefaultAsync() ?? await CreateFavouriteProfilesAsync(userId);

        favouriteProfiles.CategoryProfileId = categoryProfile.Id;

        var validationContext = new ValidationContext(favouriteProfiles);
        Validator.ValidateObject(favouriteProfiles, validationContext, validateAllProperties: true);

        _dbContext.Favourites.Update(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        return new FavouriteProfilesDTO
        {
            CategoryProfileId = favouriteProfiles.CategoryProfileId,
            ConditionProfileId = favouriteProfiles.ConditionProfileId
        };
    }

    public async Task<FavouriteProfilesDTO> AddConditionProfileToFavouritesAsync(string userId, Guid profileId)
    {
        ConditionProfile conditionProfile = await _dbContext.ConditionProfiles
            .Where(cp => cp.Id == profileId && cp.UserId == userId)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(IFavouritesService.ErrorMessage.ConditionProfileNotFound);

        FavouriteProfiles favouriteProfiles = await _dbContext.Favourites
            .Where(f => f.UserId == userId)
            .FirstOrDefaultAsync() ?? await CreateFavouriteProfilesAsync(userId);

        favouriteProfiles.ConditionProfileId = conditionProfile.Id;

        var validationContext = new ValidationContext(favouriteProfiles);
        Validator.ValidateObject(favouriteProfiles, validationContext, validateAllProperties: true);

        _dbContext.Favourites.Update(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        return new FavouriteProfilesDTO
        {
            CategoryProfileId = favouriteProfiles.CategoryProfileId,
            ConditionProfileId = favouriteProfiles.ConditionProfileId
        };
    }

    public async Task<FavouriteProfilesDTO> GetFavouriteProfilesAsync(string userId)
    {
        FavouriteProfiles favouriteProfiles = await _dbContext.Favourites
            .Where(f => f.UserId == userId)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(IFavouritesService.ErrorMessage.FavouritesProfilesNotFound);

        return new FavouriteProfilesDTO{
            CategoryProfileId = favouriteProfiles.CategoryProfileId,
            ConditionProfileId = favouriteProfiles.ConditionProfileId
        };

    }

    public async Task<bool> RemoveCategoryProfileFromFavouritesAsync(string userId, Guid profileId)
    {
        FavouriteProfiles favouriteProfiles = await _dbContext.Favourites
            .Where(f => f.UserId == userId)
            .Include(f => f.CategoryProfile)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(IFavouritesService.ErrorMessage.FavouritesProfilesNotFound);

        if (favouriteProfiles.CategoryProfileId != profileId)
        {
            throw new InvalidOperationException(IFavouritesService.ErrorMessage.CategoryProfileNotFound);
        }

        if (favouriteProfiles.CategoryProfileId == null)
        {
            throw new InvalidOperationException(IFavouritesService.ErrorMessage.NoFavouriteConditionProfile);
        }

        favouriteProfiles.CategoryProfileId = null;
        
        var validationContext = new ValidationContext(favouriteProfiles);
        Validator.ValidateObject(favouriteProfiles, validationContext, validateAllProperties: true);

        _dbContext.Favourites.Update(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> RemoveConditionProfileFromFavouritesAsync(string userId, Guid profileId)
    {
        FavouriteProfiles favouriteProfiles = await _dbContext.Favourites
            .Where(f => f.UserId == userId)
            .Include(f => f.ConditionProfile)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(IFavouritesService.ErrorMessage.FavouritesProfilesNotFound);

        if (favouriteProfiles.ConditionProfileId != profileId)
        {
            throw new InvalidOperationException(IFavouritesService.ErrorMessage.ConditionProfileNotFound);
        }

        if (favouriteProfiles.ConditionProfileId == null)
        {
            throw new InvalidOperationException(IFavouritesService.ErrorMessage.NoFavouriteConditionProfile);
        }

        favouriteProfiles.ConditionProfileId = null;
        
        var validationContext = new ValidationContext(favouriteProfiles);
        Validator.ValidateObject(favouriteProfiles, validationContext, validateAllProperties: true);

        _dbContext.Favourites.Update(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        return true;
    }

    private async Task<FavouriteProfiles> CreateFavouriteProfilesAsync(string userId)
    {
        FavouriteProfiles favouriteProfiles = new FavouriteProfiles
        {
            UserId = userId,
            CategoryProfileId = null,
            ConditionProfileId = null
        };

        _dbContext.Favourites.Add(favouriteProfiles);
        await _dbContext.SaveChangesAsync();

        return favouriteProfiles;
    }
}