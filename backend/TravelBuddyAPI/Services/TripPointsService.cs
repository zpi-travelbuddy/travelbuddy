using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Enums;
using System.ComponentModel.DataAnnotations;
using TravelBuddyAPI.DTOs.Place;

namespace TravelBuddyAPI.Services;

public class TripPointsService(TravelBuddyDbContext dbContext, INBPService nbpService, IPlacesService placesService, ITransferPointsService transferPointsService) : ITripPointsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly INBPService _nbpService = nbpService;
    private readonly IPlacesService _placesService = placesService;
    private readonly ITransferPointsService _transferPointService = transferPointsService;

    public static class ErrorMessage
    {
        public const string TripDayNotFound = "Could not find trip day of given id.";
        public const string TripDayInPast = "Cannot add trip point to past trip day.";
        public const string StartTimeAfterEndTime = "Start time cannot be after end time.";
        public const string RetriveExchangeRate = "Could not retrive exchange rate.";
        public const string EmptyPlace = "Place cannot be empty.";
        public const string CreateTripPoint = "An error occurred while creating a trip point.";
        public const string TripPointNotFound = "Trip point not found.";
        public const string DeleteTripPoint = "An error occurred while deleting a trip point.";
        public const string TripPointOverlap = "Trip point overlaps with another trip point.";
        public const string TooManyDecimalPlaces = "Predicted cost must have at most 2 decimal places.";
        public const string ProviderPlaceNotFound = "Provider place with the specified Id does not exist.";
    }

    public async Task<TripPointDetailsDTO> CreateTripPointAsync(string userId, TripPointRequestDTO tripPoint)
    {
        try
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            Trip trip = await _dbContext.Trips
                .Include(t => t.TripDays)
                .Where(t => t.UserId == userId && t.TripDays != null && t.TripDays.Any(td => td.Id == tripPoint.TripDayId))
                .FirstOrDefaultAsync()
                ?? throw new ArgumentException(ErrorMessage.TripDayNotFound);

            if (tripPoint.StartTime > tripPoint.EndTime) throw new ArgumentException(ErrorMessage.StartTimeAfterEndTime);

            TripDay? tripDay = trip.TripDays?.FirstOrDefault(td => td.Id == tripPoint.TripDayId);
            if (tripDay?.Date < DateOnly.FromDateTime(DateTime.Now)) throw new ArgumentException(ErrorMessage.TripDayInPast);

            List<TripPoint> overlappingTripPoints = await _dbContext.TripPoints
                .Where(tp => tp.TripDayId == tripPoint.TripDayId
                    && ((tp.StartTime <= tripPoint.StartTime && tp.EndTime >= tripPoint.StartTime)
                        || (tp.StartTime <= tripPoint.EndTime && tp.EndTime >= tripPoint.EndTime)))
                .ToListAsync();

            if (overlappingTripPoints.Count != 0) throw new ArgumentException(ErrorMessage.TripPointOverlap);

            decimal exchangeRate = await _nbpService.GetRateAsync(trip?.CurrencyCode ?? string.Empty) ?? throw new InvalidOperationException(ErrorMessage.RetriveExchangeRate);

            if (tripPoint.PredictedCost * 100 % 1 != 0) throw new ArgumentException(ErrorMessage.TooManyDecimalPlaces);

            _ = tripPoint.Place ?? throw new InvalidOperationException(ErrorMessage.EmptyPlace);

            Guid placeId = (tripPoint.Place.ProviderId is not null ? await GetPlaceIdAsync(tripPoint.Place.ProviderId) : null) ?? (await _placesService.AddPlaceAsync(tripPoint.Place)).Id;

            ProviderPlace? providerPlace = await _dbContext.Places.OfType<ProviderPlace>().FirstOrDefaultAsync(pp => pp.Id == placeId);
            var openingHours = providerPlace?.GetOpenningHours(tripDay!.Date);

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
                PlaceId = placeId,
                OpeningTime = openingHours?.opensAt,
                ClosingTime = openingHours?.closesAt
            };

            var validationContext = new ValidationContext(newTripPoint);
            Validator.ValidateObject(newTripPoint, validationContext, validateAllProperties: true);

            await _dbContext.TripPoints.AddAsync(newTripPoint);
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();

            return await GetTripPointDetailsAsync(userId, newTripPoint.Id);
        }
        catch (Exception e) when (e is ArgumentNullException || e is InvalidOperationException || e is ArgumentException || e is HttpRequestException || e is ValidationException)
        {
            if (_dbContext.Database.CurrentTransaction != null) await _dbContext.Database.RollbackTransactionAsync();
            throw new InvalidOperationException($"{ErrorMessage.CreateTripPoint} {e.Message}");
        }
    }

    private async Task<Guid?> GetPlaceIdAsync(string providerId)
    {
        var fetchedPlace = await _placesService.GetProviderPlaceAsync(providerId) ?? throw new InvalidOperationException(ErrorMessage.ProviderPlaceNotFound);

        return await _dbContext.Places
            .OfType<ProviderPlace>()
            .Where(p => p.ProviderId == fetchedPlace.ProviderId)
            .Select(p => (Guid?)p.Id)
            .FirstOrDefaultAsync();
    }

    public async Task<bool> DeleteTripPointAsync(string userId, Guid tripPointId)
    {
        try
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            await DeleteTripPointDuringTransactionAsync(userId, tripPointId);

            await transaction.CommitAsync();

            return true;
        }
        catch (Exception e) when (e is InvalidOperationException)
        {
            if (_dbContext.Database.CurrentTransaction != null)
            {
                await _dbContext.Database.RollbackTransactionAsync();
            }
            throw new InvalidOperationException($"{ErrorMessage.DeleteTripPoint} {e.Message}");
        }
    }

    public async Task<bool> DeleteTripPointDuringTransactionAsync(string userId, Guid tripPointId)
    {
        TripPoint tripPoint = await _dbContext.TripPoints
            .Include(tp => tp.TripDay)
                .ThenInclude(td => td != null ? td.Trip : null)
            .Include(tp => tp.TripDay != null ? tp.TripDay.TransferPoints : null)
            .Include(tp => tp.Place)
            .Include(tp => tp.Review)
            .Where(tp => tp.Id == tripPointId
                && tp.TripDay != null
                && tp.Place != null
                && tp.TripDay.Trip != null
                && tp.TripDay.Trip.UserId == userId)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(ErrorMessage.TripPointNotFound);

        var transferPoints = tripPoint.TripDay?.TransferPoints?
            .Where(tp => tp.FromTripPointId == tripPointId || tp.ToTripPointId == tripPointId)
            .ToList() ?? [];

        foreach (var transferPoint in transferPoints)
        {
            await _transferPointService.DeleteTransferPointAsync(userId,transferPoint.Id);
        }

        if (tripPoint.Place is CustomPlace customPlace)
        {
            if (tripPoint.Review != null)
            {
                _dbContext.TripPointReviews.Remove(tripPoint.Review);
            }
            _dbContext.Places.Remove(customPlace);
        }

        _dbContext.TripPoints.Remove(tripPoint);

        await _dbContext.SaveChangesAsync();

        return true;
    }

    public Task<bool> EditTripPointAsync(string userId, Guid tripPointId, TripPointRequestDTO tripPoint)
    {
        throw new NotImplementedException();
    }

    public async Task<TripPointDetailsDTO> GetTripPointDetailsAsync(string userId, Guid tripPointId)
    {
        TripPoint tripPoint = await _dbContext.TripPoints
            .Include(tp => tp.TripDay)
                .ThenInclude(td => td != null ? td.Trip : null)
            .Include(tp => tp.Place)
            .Include(tp => tp.Review)
            .Where(tp => tp.Id == tripPointId
                && tp.TripDay != null
                && tp.TripDay.Trip != null
                && tp.TripDay.Trip.UserId == userId)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(ErrorMessage.TripPointNotFound);

        return new TripPointDetailsDTO
        {
            Id = tripPoint.Id,
            Name = tripPoint.Name,
            Comment = tripPoint.Comment,
            TripDayId = tripPoint.TripDayId,
            PredictedCost = tripPoint.PredictedCost / tripPoint.ExchangeRate,
            CurrencyCode = tripPoint.TripDay?.Trip?.CurrencyCode,
            StartTime = tripPoint.StartTime,
            EndTime = tripPoint.EndTime,
            OpeningTime = tripPoint.OpeningTime,
            ClosingTime = tripPoint.ClosingTime,
            Status = tripPoint.Status,
            PlaceId = tripPoint.Place!.Id,
            Place = tripPoint.Place != null ? new PlaceOverviewDTO
            {
                Id = tripPoint.Place.Id,
                ProviderId = tripPoint.Place is ProviderPlace providerPlace ? providerPlace.ProviderId : null,
                Name = tripPoint.Place.Name,
                Country = tripPoint.Place.Country,
                City = tripPoint.Place.City
            } : null,
            Review = tripPoint.Review != null ? new TripPointReviewOverviewDTO
            {
                Id = tripPoint.Review.Id,
                TripPointId = tripPoint.Review.TripPointId,
                PlaceId = tripPoint.Review.PlaceId,
                PlaceName = tripPoint.Place?.Name,
                Rating = tripPoint.Review.Rating
            } : null
        };
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