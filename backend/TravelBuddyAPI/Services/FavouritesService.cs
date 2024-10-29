using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.FavouriteProfiles;
using TravelBuddyAPI.Interfaces;

namespace TravelBuddyAPI.Services;

public class FavouritesService(TravelBuddyDbContext dbContext, ITravelBuddyDbCache dbCache) : IFavouritesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly ITravelBuddyDbCache _dbCache = dbCache;


    public Task<FavouriteProfilesDTO> AddCategoryProfileToFavouritesAsync(string userId, Guid profileId)
    {
        throw new NotImplementedException();
    }

    public Task<FavouriteProfilesDTO> AddConditionProfileToFavouritesAsync(string userId, Guid profileId)
    {
        throw new NotImplementedException();
    }

    public Task<FavouriteProfilesDTO> GetFavouriteProfilesAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveCategoryProfileFromFavouritesAsync(string userId, Guid profileId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveConditionProfileFromFavouritesAsync(string userId, Guid profileId)
    {
        throw new NotImplementedException();
    }
}