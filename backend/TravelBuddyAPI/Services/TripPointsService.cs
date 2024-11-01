using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace TravelBuddyAPI.Services;

public class TripPointsService(TravelBuddyDbContext dbContext, INBPService nbpService, IPlacesService placesService) : ITripPointsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly INBPService _nbpService = nbpService;
    private readonly IPlacesService _placesService = placesService;

    private static class ErrorMessage
    {
        public const string TripDayNotFound = "Could not find trip day of given id.";

        public const string StartTimeAfterEndTime = "Start time cannot be after end time.";
        public const string RetriveExchangeRate = "Could not retrive exchange rate.";
        public const string EmptyPlace = "Place cannot be empty.";
        public const string CreateTripPoint = "An error occurred while creating a trip point.";
    }

    public async Task<TripPointDetailsDTO> CreateTripPointAsync(string userId, TripPointRequestDTO tripPoint)
    {
        try
        {
            Trip trip = await _dbContext.Trips
                .Include(t => t.TripDays)
                .Where(t => t.UserId == userId && t.TripDays != null && t.TripDays.Any(td => td.Id == tripPoint.TripDayId))
                .FirstOrDefaultAsync()
                ?? throw new ArgumentException(ErrorMessage.TripDayNotFound);

            if (tripPoint.StartTime > tripPoint.EndTime) throw new ArgumentException(ErrorMessage.StartTimeAfterEndTime);

           decimal exchangeRate = await _nbpService.GetClosestRateAsync(trip?.CurrencyCode ?? string.Empty, DateOnly.FromDateTime(DateTime.Now)) ?? throw new InvalidOperationException(ErrorMessage.RetriveExchangeRate);

            _ = tripPoint.Place ?? throw new InvalidOperationException(ErrorMessage.EmptyPlace);
            Guid placeId = await GetPlaceIdAsync(tripPoint.Place.ProviderId) ?? (await _placesService.AddPlaceAsync(tripPoint.Place)).Id;

            TripPoint newTripPoint = new()
            {
                Id = Guid.NewGuid(),
                TripDayId = tripPoint.TripDayId,
                Name = tripPoint.Name,
                Comment = tripPoint.Comment,
                PredictedCost = tripPoint.PredictedCost * exchangeRate,
                ExchangeRate = exchangeRate,
                StartTime = tripPoint.StartTime,
                EndTime = tripPoint.EndTime,
                Status = TripPointStatus.planned,
                // TODO add opening and closing time
            };

            var validationContext = new ValidationContext(newTripPoint);
            Validator.ValidateObject(newTripPoint, validationContext, validateAllProperties: true);

            await _dbContext.TripPoints.AddAsync(newTripPoint);
            await _dbContext.SaveChangesAsync();

            return await GetTripPointDetailsAsync(userId, newTripPoint.Id);
        }
        catch (Exception e) when (e is ArgumentNullException || e is InvalidOperationException || e is ArgumentException || e is HttpRequestException || e is ValidationException)
        {
            throw new InvalidOperationException($"{ErrorMessage.CreateTripPoint} {e.Message}");
        }
    }

    private async Task<Guid?> GetPlaceIdAsync(string? providerId)
    {
        return await _dbContext.Places
            .OfType<ProviderPlace>()
            .Where(p => p.ProviderId == providerId)
            .Select(p => p.Id)
            .FirstOrDefaultAsync();
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