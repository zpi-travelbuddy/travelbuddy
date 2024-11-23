using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.ConditionProfile;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.DTOs.PlaceCondition;
using static TravelBuddyAPI.Interfaces.IConditionProfilesService;
using System.ComponentModel.DataAnnotations;

namespace TravelBuddyAPI.Services;

public class ConditionProfilesService(TravelBuddyDbContext dbContext) : IConditionProfilesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;

    public async Task<ConditionProfileDetailsDTO> CreateConditionProfileAsync(string userId, ConditionProfileRequestDTO conditionProfile)
    {
        var existingProfiles = await GetUserConditionProfilesAsync(userId);

        var conditions = await _dbContext.PlaceConditions
            .Where(c => conditionProfile.ConditionIds != null && conditionProfile.ConditionIds.Contains(c.Id))
            .ToListAsync();

        ConditionProfile newConditionProfile = new()
        {
            Id = Guid.NewGuid(),
            Name = conditionProfile.Name,
            UserId = userId,
            Conditions = conditions
        };

        try
        {
            if (await _dbContext.ConditionProfiles.AnyAsync(cp => cp.Name == conditionProfile.Name))
            {
                throw new InvalidOperationException(ErrorMessage.ConditionProfileNameAlreadyExists);
            }

            var validationContext = new ValidationContext(conditionProfile);
            Validator.ValidateObject(conditionProfile, validationContext);
        }
        catch (Exception e) when (e is ValidationException || e is InvalidOperationException)
        {
            throw new InvalidOperationException($"{ErrorMessage.CreatingConditionProfile} {e.Message}");
        }

        _dbContext.ConditionProfiles.Add(newConditionProfile);
        await _dbContext.SaveChangesAsync();


        return await GetConditionProfileDetailsAsync(userId, newConditionProfile.Id);
    }

    public async Task<bool> DeleteConditionProfileAsync(string userId, Guid profileId)
    {
        try
        {
            var conditionProfile = await _dbContext.ConditionProfiles
                        .FirstOrDefaultAsync(cp => cp.Id == profileId && cp.UserId == userId) ?? throw new InvalidOperationException(ErrorMessage.ConditionProfileNotFound);

            var trips = await _dbContext.Trips
                .Where(t => t.ConditionProfileId == profileId)
                .ToListAsync();

            var favouriteProfiles = await _dbContext.Favourites
                .Where(fcp => fcp.UserId == userId)
                .FirstOrDefaultAsync();

            if (trips.Count != 0)
            {
                throw new InvalidOperationException(ErrorMessage.TripUsesConditionProfile);
            }

            if (favouriteProfiles != null && favouriteProfiles.ConditionProfileId == profileId)
            {
                favouriteProfiles.ConditionProfileId = null;
                _dbContext.Favourites.Update(favouriteProfiles);
            }

            _dbContext.ConditionProfiles.Remove(conditionProfile);
            await _dbContext.SaveChangesAsync();

            return true;
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException($"{ErrorMessage.DeletingConditionProfile} {e.Message}");
        }
    }

    public async Task<bool> EditConditionProfileAsync(string userId, Guid profileId, ConditionProfileRequestDTO conditionProfile)
    {
        try
        {
            ConditionProfile existingConditionProfile = await _dbContext.ConditionProfiles
                .Include(cp => cp.Conditions)
                .FirstOrDefaultAsync(cp => cp.Id == profileId && cp.UserId == userId) ?? throw new InvalidOperationException(ErrorMessage.ConditionProfileNotFound);

            var conditions = await _dbContext.PlaceConditions
                .Where(c => conditionProfile.ConditionIds != null && conditionProfile.ConditionIds.Contains(c.Id))
                .ToListAsync();

            existingConditionProfile.Name = conditionProfile.Name;
            existingConditionProfile.Conditions = conditions;

            var validationContext = new ValidationContext(existingConditionProfile);
            Validator.ValidateObject(existingConditionProfile, validationContext);

            _dbContext.ConditionProfiles.Update(existingConditionProfile);
            await _dbContext.SaveChangesAsync();

            return true;
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException($"{ErrorMessage.EditingConditionProfile} {e.Message}");
        }
    }

    public async Task<ConditionProfileDetailsDTO> GetConditionProfileDetailsAsync(string userId, Guid profileId)
    {
        ConditionProfile conditionProfile = await _dbContext.ConditionProfiles
            .Include(cp => cp.Conditions)
            .FirstOrDefaultAsync(cp => cp.Id == profileId && cp.UserId == userId) ?? throw new InvalidOperationException(ErrorMessage.ConditionProfileNotFound);

        return new ConditionProfileDetailsDTO()
        {
            Id = conditionProfile.Id,
            Name = conditionProfile.Name,
            Conditions = conditionProfile?.Conditions?
                .Select(c => new PlaceConditionDTO()
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList()
        };
    }

    public async Task<List<ConditionProfileOverviewDTO>> GetUserConditionProfilesAsync(string userId)
    {
        var conditionProfiles = await _dbContext.ConditionProfiles
            .Where(cp => cp.UserId == userId)
            .Select(cp => new ConditionProfileOverviewDTO()
            {
                Id = cp.Id,
                Name = cp.Name,
            })
            .ToListAsync();

        return conditionProfiles;
    }
}