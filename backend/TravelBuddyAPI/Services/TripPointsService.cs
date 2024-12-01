using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Enums;
using System.ComponentModel.DataAnnotations;
using TravelBuddyAPI.DTOs.Place;
using static TravelBuddyAPI.Interfaces.ITripPointsService;
using TravelBuddyAPI.DTOs.PlaceCategory;

namespace TravelBuddyAPI.Services;

public class TripPointsService(TravelBuddyDbContext dbContext, INBPService nbpService, IPlacesService placesService, ITransferPointsService transferPointsService) : ITripPointsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly INBPService _nbpService = nbpService;
    private readonly IPlacesService _placesService = placesService;
    private readonly ITransferPointsService _transferPointService = transferPointsService;

    public async Task<TripPointDetailsDTO> CreateTripPointAsync(string userId, TripPointRequestDTO tripPoint)
    {
        try
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            Trip trip = await _dbContext.Trips
                .Include(t => t.TripDays!)
                    .ThenInclude(td => td.TripPoints)
                .Include(t => t.TripDays!)
                    .ThenInclude(td => td.TransferPoints)
                .Where(t => t.UserId == userId && t.TripDays != null && t.TripDays.Any(td => td.Id == tripPoint.TripDayId))
                .FirstOrDefaultAsync()
                ?? throw new ArgumentException(ErrorMessage.TripDayNotFound);
            if (tripPoint.StartTime > tripPoint.EndTime) throw new ArgumentException(ErrorMessage.StartTimeAfterEndTime);

            TripDay? tripDay = trip.TripDays?.FirstOrDefault(td => td.Id == tripPoint.TripDayId);
            if (tripDay?.Date < DateOnly.FromDateTime(DateTime.Now)) throw new ArgumentException(ErrorMessage.TripDayInPast);

            List<TripPoint> tripPoints = tripDay?.TripPoints?.ToList() ?? [];
            List<TransferPoint> transferPoints = tripDay?.TransferPoints?.ToList() ?? [];

            List<TripPoint> overlappingTripPoints = tripPoints
                .Where(tp => (tp.StartTime < tripPoint.EndTime && tp.EndTime > tripPoint.StartTime)
                            || (tp.StartTime == tripPoint.StartTime && tp.EndTime == tripPoint.EndTime))
                .ToList() ?? [];
            if (overlappingTripPoints.Count != 0) throw new ArgumentException(ErrorMessage.TripPointOverlap);

            TripPoint? previousTripPoint = tripPoints
                .Where(tp => tp.EndTime <= tripPoint.StartTime)
                .OrderByDescending(tp => tp.EndTime)
                .FirstOrDefault();

            TransferPoint? conflictingTransferPoint = transferPoints
                .Where(tp => tp.FromTripPointId == previousTripPoint?.Id)
                .FirstOrDefault();
            if (conflictingTransferPoint != null) _dbContext.TransferPoints.Remove(conflictingTransferPoint);

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
            await _transferPointService.DeleteTransferPointAsync(userId, transferPoint.Id);
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
            Place = tripPoint.Place != null ? new PlaceOverviewDTO
            {
                Id = tripPoint.Place.Id,
                ProviderId = tripPoint.Place is ProviderPlace providerPlace ? providerPlace.ProviderId : null,
                Name = tripPoint.Place.Name,
                Country = tripPoint.Place.Country,
                City = tripPoint.Place.City,
                Street = tripPoint.Place.Street,
                HouseNumber = tripPoint.Place.HouseNumber,
                SuperCategory = tripPoint.Place is CustomPlace customPlace && customPlace.SuperCategoryId != null ? await _dbContext.PlaceCategories
                    .Where(pc => pc.Id == customPlace.SuperCategoryId)
                    .Select(pc => new PlaceCategoryDTO
                    {
                        Id = pc.Id,
                        Name = pc.Name
                    })
                    .FirstOrDefaultAsync() : null
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

    public async Task<TripPointReviewDetailsDTO> GetTripPointReviewDetailsAsync(string userId, Guid tripPointReviewId)
    {
        TripPointReview reviewTripPoint = await _dbContext.TripPointReviews
            .Where(tpr => tpr.Id == tripPointReviewId
                && tpr.UserId == userId)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(ErrorMessage.TripPointReviewNotFound);

        return new TripPointReviewDetailsDTO
        {
            Id = reviewTripPoint.Id,
            TripPointId = reviewTripPoint.TripPointId,
            PlaceId = reviewTripPoint.PlaceId,
            CurrencyCode = reviewTripPoint.CurrencyCode,
            ActualCostPerPerson = reviewTripPoint.ActualCostPerPerson.HasValue && reviewTripPoint.ExchangeRate.HasValue ? Math.Round(reviewTripPoint.ActualCostPerPerson.Value / reviewTripPoint.ExchangeRate.Value, 2) : null,
            ActualTimeSpent = reviewTripPoint.ActualTimeSpent,
            Rating = reviewTripPoint.Rating
        };
    }

    public Task<List<TripPointOverviewDTO>> GetTripPointsAsync(string userId, Guid tripDayId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TripPointReviewOverviewDTO>> GetTripPointsReviewsAsync(string userId)
    {
        var reviewTripPoints = await _dbContext.TripPointReviews
            .Include(tpr => tpr.Place)
            .Where(tpr => tpr.UserId == userId)
            .ToListAsync() ?? new List<TripPointReview>();

        return reviewTripPoints.Select(reviewTripPoint => new TripPointReviewOverviewDTO
        {
            Id = reviewTripPoint.Id,
            TripPointId = reviewTripPoint.TripPointId,
            PlaceId = reviewTripPoint.PlaceId,
            PlaceName = reviewTripPoint.Place?.Name,
            Rating = reviewTripPoint.Rating
        }).ToList();
    }

    public async Task<TripPointReviewDetailsDTO> ReviewTripPointAsync(string userId, Guid tripPointId, TripPointReviewRequestDTO tripPointReview)
    {
        try
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

            if (tripPointReview.ActualCostPerPerson * 100 % 1 != 0) throw new ArgumentException(ErrorMessage.TooManyDecimalPlaces);
            if (tripPoint.Review != null) throw new InvalidOperationException(ErrorMessage.TripPointReviewExists);
            if (tripPoint.Status != TripPointStatus.reviewPending) throw new InvalidOperationException($"{ErrorMessage.TripPointWrongStatus} {tripPoint.Status.ToString()}");

            decimal? exchangeRate = tripPointReview.ActualCostPerPerson.HasValue ? (await _nbpService.GetRateAsync(tripPoint?.TripDay?.Trip?.CurrencyCode ?? string.Empty) ?? throw new InvalidOperationException(ErrorMessage.RetriveExchangeRate)) : null;


            TripPointReview newTripPointReview = new TripPointReview
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                TripPointId = tripPointId,
                CurrencyCode = tripPoint!.TripDay?.Trip?.CurrencyCode,
                PlaceId = tripPoint!.PlaceId,
                ActualCostPerPerson = tripPointReview.ActualCostPerPerson.HasValue ? tripPointReview.ActualCostPerPerson * exchangeRate : null,
                ExchangeRate = exchangeRate,
                ActualTimeSpent = tripPointReview.ActualTimeSpent,
                Rating = tripPointReview.Rating
            };

            tripPoint.Status = TripPointStatus.reviewCompleted;


            var validationContext = new ValidationContext(newTripPointReview);
            Validator.ValidateObject(newTripPointReview, validationContext, validateAllProperties: true);

            await _dbContext.TripPointReviews.AddAsync(newTripPointReview);
            _dbContext.TripPoints.Update(tripPoint);
            await _dbContext.SaveChangesAsync();

            return await GetTripPointReviewDetailsAsync(userId, newTripPointReview.Id);
        }
        catch (Exception e) when (e is ArgumentNullException || e is InvalidOperationException || e is ArgumentException || e is HttpRequestException || e is ValidationException)
        {
            throw new InvalidOperationException($"{ErrorMessage.CreateTripPointReview} {e.Message}");
        }
    }
}