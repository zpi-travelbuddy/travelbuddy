using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.ConditionProfile;
using TravelBuddyAPI.Interfaces;

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

    public Task<ConditionProfileDetailsDTO> GetConditionProfileDetailsAsync(string userId, Guid profileId)
    {
        throw new NotImplementedException();
    }

    public Task<List<ConditionProfileOverviewDTO>> GetUserConditionProfilesAsync(string userId)
    {
        throw new NotImplementedException();
    }
}