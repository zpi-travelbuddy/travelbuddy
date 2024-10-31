using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.TransferPoint;
using TravelBuddyAPI.DTOs.Trip;
using TravelBuddyAPI.DTOs.TripDay;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Services;

public class TripsService(TravelBuddyDbContext dbContext, INBPService nbpService) : ITripsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly INBPService _nbpService = nbpService;

    public static class ErrorMessage
    {
        public const string EmptyRequest = "Request cannot be empty.";
        public const string StartDateAfterEndDate = "Start date cannot be after end date.";
        public const string StartDateInPast = "Start date cannot be in the past.";
        public const string CreateTrip = "An error occurred while creating a trip:";
        public const string RetriveExchangeRate = "An error occurred while retrieving exchange rate.";
        public const string TripNotFound = "Trip with the specified ID does not exist.";
        public const string TripWithoutDays = "Trip does not have any days.";
    }

    public Task<TripDetailsDTO> CreateTripAsync(string userId, TripRequestDTO trip)
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

    public async Task<TripDetailsDTO> GetTripDetailsAsync(string userId, Guid tripId)
    {
        var trip = await _dbContext.Trips
            .Where(p => p.Id == tripId && p.UserId == userId)
            .Include(p => p.TripDays!)
            .FirstOrDefaultAsync();

        if (trip == null)
        {
            throw new ArgumentException(ErrorMessage.TripNotFound);
        }

        TripDetailsDTO tripDetails = new()
        {
            Id = trip.Id,
            Name = trip.Name,
            NumberOfTravelers = trip.NumberOfTravelers,
            StartDate = trip.StartDate,
            EndDate = trip.EndDate,
            DestinationId = trip.DestinationId,
            Budget = trip.Budget,
            CurrencyCode = trip.CurrencyCode,
            CategoryProfileId = trip.CategoryProfileId,
            ConditionProfileId = trip.ConditionProfileId,
        };

        tripDetails.TripDays = trip.TripDays?.Select(td => new TripDayOverviewDTO
        {
            Id = td.Id,
            TripId = td.TripId,
            Date = td.Date,
        }).ToList() ?? throw new ArgumentException(ErrorMessage.TripWithoutDays);

        return tripDetails;
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