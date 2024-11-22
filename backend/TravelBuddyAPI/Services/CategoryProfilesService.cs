using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.CategoryProfile;
using TravelBuddyAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.PlaceCategory;
using static TravelBuddyAPI.Interfaces.ICategoryProfilesService;
using System.ComponentModel.DataAnnotations;

namespace TravelBuddyAPI.Services;

public class CategoryProfilesService(TravelBuddyDbContext dbContext) : ICategoryProfilesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;

    private async Task ValidateCategoryProfileAsync(CategoryProfile categoryProfile)
    {
        if (await _dbContext.CategoryProfiles.AnyAsync(cp => cp.Name == categoryProfile.Name))
        {
            throw new InvalidOperationException(ErrorMessage.CategoryProfileNameAlreadyExists);
        }

        var validationContext = new ValidationContext(categoryProfile);
        Validator.ValidateObject(categoryProfile, validationContext);
    }

    public async Task<CategoryProfileDetailsDTO> CreateCategoryProfileAsync(string userId, CategoryProfileRequestDTO categoryProfile)
    {
        var categories = await _dbContext.PlaceCategories
            .Where(c => categoryProfile.CategoryIds != null && categoryProfile.CategoryIds.Contains(c.Id))
            .ToListAsync();

        CategoryProfile newCategoryProfile = new()
        {
            Id = Guid.NewGuid(),
            Name = categoryProfile.Name,
            UserId = userId,
            Categories = categories
        };

        try
        {
            await ValidateCategoryProfileAsync(newCategoryProfile);
        }
        catch (Exception e) when (e is ValidationException || e is InvalidOperationException)
        {
            throw new InvalidOperationException($"{ErrorMessage.CreatingCategoryProfile} {e.Message}");
        }

        _dbContext.CategoryProfiles.Add(newCategoryProfile);
        await _dbContext.SaveChangesAsync();

        return await GetCategoryProfileDetailsAsync(userId, newCategoryProfile.Id);
    }

    public async Task<bool> DeleteCategoryProfileAsync(string userId, Guid profileId)
    {
        try
        {
            var categoryProfile = await _dbContext.CategoryProfiles
                        .FirstOrDefaultAsync(cp => cp.Id == profileId && cp.UserId == userId) ?? throw new InvalidOperationException(ErrorMessage.CategoryProfileNotFound);

            var trips = await _dbContext.Trips
                .Where(t => t.CategoryProfileId == profileId)
                .ToListAsync();

            var favouriteProfiles = await _dbContext.Favourites
                .Where(fcp => fcp.UserId == userId)
                .FirstOrDefaultAsync();

            if (trips.Count != 0)
            {
                throw new InvalidOperationException(ErrorMessage.TripUsesCategoryProfile);
            }

            if (favouriteProfiles != null && favouriteProfiles.CategoryProfileId == profileId)
            {
                favouriteProfiles.CategoryProfileId = null;
                _dbContext.Favourites.Update(favouriteProfiles);
            }

            _dbContext.CategoryProfiles.Remove(categoryProfile);
            await _dbContext.SaveChangesAsync();

            return true;
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException($"{ErrorMessage.DeletingCategoryProfile} {e.Message}");
        }
    }

    public async Task<CategoryProfileDetailsDTO> EditCategoryProfileAsync(string userId, Guid profileId, CategoryProfileRequestDTO categoryProfile)
    {
        try
        {
            CategoryProfile existingCategoryProfile = await _dbContext.CategoryProfiles
                .Include(cp => cp.Categories)
                .FirstOrDefaultAsync(cp => cp.Id == profileId && cp.UserId == userId) ?? throw new InvalidOperationException(ErrorMessage.CategoryProfileNotFound);

            var categories = await _dbContext.PlaceCategories
                .Where(c => categoryProfile.CategoryIds != null && categoryProfile.CategoryIds.Contains(c.Id))
                .ToListAsync();

            existingCategoryProfile.Name = categoryProfile.Name;
            existingCategoryProfile.Categories = categories;

            await ValidateCategoryProfileAsync(existingCategoryProfile);
            _dbContext.CategoryProfiles.Update(existingCategoryProfile);
            await _dbContext.SaveChangesAsync();

            return await GetCategoryProfileDetailsAsync(userId, profileId);
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException($"{ErrorMessage.EditingCategoryProfile} {e.Message}");
        }
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

    public async Task<List<CategoryProfileOverviewDTO>> GetUserCategoryProfilesAsync(string userId)
    {
        var categoryProfiles = await _dbContext.CategoryProfiles
            .Where(cp => cp.UserId == userId)
            .Select(cp => new CategoryProfileOverviewDTO()
            {
                Id = cp.Id,
                Name = cp.Name,
            })
            .ToListAsync();

        return categoryProfiles;
    }
}