using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.CategoryProfile;
using TravelBuddyAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.PlaceCategory;
using static TravelBuddyAPI.Interfaces.ICategoryProfilesService;

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

    public async Task<CategoryProfileDetailsDTO> GetCategoryProfileDetailsAsync(string userId, Guid profileId)
    {
        CategoryProfile categoryProfile = await _dbContext.CategoryProfiles
            .Include(cp => cp.Categories)
            .FirstOrDefaultAsync(cp => cp.Id == profileId && cp.UserId == userId) ?? throw new InvalidOperationException(ErrorMessage.CategoryProfileNotFound);

        return new CategoryProfileDetailsDTO()
        {
            Name = categoryProfile.Name,
            Categories = categoryProfile?.Categories?
                .Select(c => new PlaceCategoryDTO()
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList()
        };
    }

    public Task<List<CategoryProfileOverviewDTO>> GetUserCategoryProfilesAsync(string userId)
    {
        throw new NotImplementedException();
    }
}