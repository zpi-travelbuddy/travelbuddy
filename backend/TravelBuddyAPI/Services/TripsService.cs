using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Trip;
using TravelBuddyAPI.DTOs.TripDay;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Services;

public class TripsService(TravelBuddyDbContext dbContext, INBPService nbpService) : ITripsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly INBPService _nbpService = nbpService;

    public Task<Trip> CreateTripAsync(string userId, TripRequestDTO trip)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTripAsync(string userId, Guid tripId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditTripAsync(string userId, Guid tripId, TripRequestDTO trip)
    {
        throw new NotImplementedException();
    }

    public Task<List<TripOverviewDTO>> GetCurrentTripsAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<List<TripOverviewDTO>> GetPastTripsAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<List<TripOverviewWithStatisticsDTO>> GetPastTripsWithStatisticsAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<TripDayDetailsDTO> GetTripDayDetailsAsync(string userId, Guid tripDayId)
    {
        throw new NotImplementedException();
    }

    public Task<TripDetailsDTO> GetTripDetailsAsync(string userId, Guid tripId)
    {
        throw new NotImplementedException();
    }

    public Task<TripStatisticsDTO> GetTripStatisticsAsync(string userId, int year, int? month, string currencyCode)
    {
        throw new NotImplementedException();
    }

    public Task<TripSummaryDTO> GetTripSummaryAsync(string userId, Guid tripId)
    {
        throw new NotImplementedException();
    }
}