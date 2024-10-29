using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.CategoryProfile;
using TravelBuddyAPI.Interfaces;

namespace TravelBuddyAPI.Services;

public class CategoryProfilesService(TravelBuddyDbContext dbContext) : ICategoryProfilesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;

    public Task<CategoryProfileDetailsDTO> CreateCategoryProfileAsync(string userId, CategoryProfileRequestDTO categoryProfile)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCategoryProfileAsync(string userId, Guid profileId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditCategoryProfileAsync(string userId, Guid profileId, CategoryProfileRequestDTO categoryProfile)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryProfileDetailsDTO> GetCategoryProfileDetailsAsync(string userId, Guid profileId)
    {
        throw new NotImplementedException();
    }

    public Task<List<CategoryProfileOverviewDTO>> GetUserCategoryProfilesAsync(string userId)
    {
        throw new NotImplementedException();
    }
}