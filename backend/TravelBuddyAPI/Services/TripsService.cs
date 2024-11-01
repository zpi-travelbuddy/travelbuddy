using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Trip;
using TravelBuddyAPI.DTOs.TripDay;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelBuddyAPI.Services;

public class  TripsService(TravelBuddyDbContext dbContext, INBPService nbpService, IPlacesService placesService, ICategoryProfilesService categoryProfilesService, IConditionProfilesService conditionProfilesService) : ITripsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly INBPService _nbpService = nbpService;
    private readonly IPlacesService _placesService = placesService;
    private readonly ICategoryProfilesService _categoryProfileService = categoryProfilesService;
    private readonly IConditionProfilesService _conditionProfileService = conditionProfilesService;


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

    public async Task<List<TripOverviewDTO>> GetCurrentTripsAsync(string userId)
    {
        return await _dbContext.Trips
            .Where(t => t.UserId == userId && t.EndDate >= DateOnly.FromDateTime(DateTime.Now))
            .Select(t => new TripOverviewDTO
            {
                Id = t.Id,
                Name = t.Name,
                StartDate = t.StartDate,
                EndDate = t.EndDate
            })
            .ToListAsync();
    }

    public async Task<List<TripOverviewDTO>> GetPastTripsAsync(string userId)
    {
        return await _dbContext.Trips
            .Where(t => t.UserId == userId && t.EndDate < DateOnly.FromDateTime(DateTime.Now))
            .Select(t => new TripOverviewDTO
            {
                Id = t.Id,
                Name = t.Name,
                StartDate = t.StartDate,
                EndDate = t.EndDate
            })
            .ToListAsync();
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