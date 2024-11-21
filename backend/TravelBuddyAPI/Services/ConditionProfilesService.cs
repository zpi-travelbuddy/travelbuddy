using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.ConditionProfile;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.DTOs.PlaceCondition;
using static TravelBuddyAPI.Interfaces.IConditionProfilesService;

namespace TravelBuddyAPI.Services;

public class ConditionProfilesService(TravelBuddyDbContext dbContext) : IConditionProfilesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;

    public Task<ConditionProfileDetailsDTO> CreateConditionProfileAsync(string userId, ConditionProfileRequestDTO conditionProfile)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteConditionProfileAsync(string userId, Guid profileId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditConditionProfileAsync(string userId, Guid profileId, ConditionProfileRequestDTO conditionProfile)
    {
        throw new NotImplementedException();
    }

    public async Task<ConditionProfileDetailsDTO> GetConditionProfileDetailsAsync(string userId, Guid profileId)
    {
        ConditionProfile conditionProfile = await _dbContext.ConditionProfiles
            .Include(cp => cp.Conditions)
            .FirstOrDefaultAsync(cp => cp.Id == profileId && cp.UserId == userId) ?? throw new InvalidOperationException(ErrorMessage.ConditionProfileNotFound);

        return new ConditionProfileDetailsDTO()
        {
            Name = conditionProfile.Name,
            Conditions = conditionProfile?.Conditions?
                .Select(c => new PlaceConditionDTO()
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList()
        };
    }

    public Task<List<ConditionProfileOverviewDTO>> GetUserConditionProfilesAsync(string userId)
    {
        throw new NotImplementedException();
    }
}