using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.TransferPoint;
using TravelBuddyAPI.Interfaces;

namespace TravelBuddyAPI.Services;

public class TransferPointsService(TravelBuddyDbContext dbContext, IGeoapifyService geoapifyService) : ITransferPointsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly IGeoapifyService _geoapifyService = geoapifyService;

    public Task<TransferPointDTO> CreateTransferPointAsync(string userId, TransferPointDTO transferPoint)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTransferPointAsync(string userId, Guid transferPointId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditTransferPointAsync(string userId, Guid transferPointId, TransferPointDTO transferPoint)
    {
        throw new NotImplementedException();
    }
}