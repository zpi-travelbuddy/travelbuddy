using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;
using TravelBuddyAPI.Interfaces;

namespace TravelBuddyAPI.Services;

public class TripPointsService(TravelBuddyDbContext dbContext, INBPService nbpService) : ITripPointsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly INBPService _nbpService = nbpService;

    public Task<TripPointDetailsDTO> CreateTripPointAsync(string userId, TripPointRequestDTO tripPoint)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTripPointAsync(string userId, Guid tripPointId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditTripPointAsync(string userId, Guid tripPointId, TripPointRequestDTO tripPoint)
    {
        throw new NotImplementedException();
    }

    public Task<TripPointDetailsDTO> GetTripPointDetailsAsync(string userId, Guid tripPointId)
    {
        throw new NotImplementedException();
    }

    public Task<TripPointReviewDetailsDTO> GetTripPointReviewDetailsAsync(string userId, Guid tripPointReviewId)
    {
        throw new NotImplementedException();
    }

    public Task<List<TripPointOverviewDTO>> GetTripPointsAsync(string userId, Guid tripDayId)
    {
        throw new NotImplementedException();
    }

    public Task<List<TripPointReviewOverviewDTO>> GetTripPointsReviewsAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<TripPointReviewDetailsDTO> ReviewTripPointAsync(string userId, Guid tripPointId, TripPointReviewRequestDTO tripPointReview)
    {
        throw new NotImplementedException();
    }
}