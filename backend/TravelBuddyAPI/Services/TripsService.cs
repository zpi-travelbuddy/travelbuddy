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
using static TravelBuddyAPI.Interfaces.ITripsService;

namespace TravelBuddyAPI.Services;

public class TripsService(TravelBuddyDbContext dbContext, INBPService nbpService, IPlacesService placesService, ICategoryProfilesService categoryProfilesService, IConditionProfilesService conditionProfilesService, ITripPointsService tripPointsService) : ITripsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly INBPService _nbpService = nbpService;
    private readonly IPlacesService _placesService = placesService;
    private readonly ICategoryProfilesService _categoryProfileService = categoryProfilesService;
    private readonly IConditionProfilesService _conditionProfileService = conditionProfilesService;
    private readonly ITripPointsService _tripPointsService = tripPointsService;

    public async Task<TripDetailsDTO> CreateTripAsync(string userId, TripRequestDTO trip)
    {
        try
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();
           
            await ValidateTripRequest(userId, trip);

            if (trip.StartDate < DateOnly.FromDateTime(DateTime.Now)) throw new ArgumentException(ErrorMessage.StartDateInPast);
            if (trip.Budget * 100 % 1 != 0) throw new ArgumentException(ErrorMessage.TooManyDecimalPlaces);

            decimal exchangeRate = await _nbpService.GetRateAsync(trip?.CurrencyCode ?? string.Empty) ?? throw new InvalidOperationException(ErrorMessage.RetriveExchangeRate);

            _ = trip?.DestinationProviderId ?? throw new InvalidOperationException(ErrorMessage.DestinationProviderIdIsNull);
            Guid destinationId = await GetDestinationId(trip.DestinationProviderId) ?? await AddDestinationAsync(trip.DestinationProviderId);

            Trip newTrip = new()
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                Name = trip!.Name, // It cannot be null here
                NumberOfTravelers = trip.NumberOfTravelers,
                StartDate = trip.StartDate,
                EndDate = trip.EndDate,
                CurrencyCode = trip.CurrencyCode,
                DestinationId = destinationId,
                CategoryProfileId = trip.CategoryProfileId,
                ConditionProfileId = trip.ConditionProfileId,
                ExchangeRate = exchangeRate,
                Budget = trip.Budget * exchangeRate
            };

            var validationContext = new ValidationContext(newTrip);
            Validator.ValidateObject(newTrip, validationContext, validateAllProperties: true);

            await _dbContext.Trips.AddAsync(newTrip);
            await _dbContext.SaveChangesAsync();
            await AddTripDaysAsync(newTrip.Id, newTrip.StartDate, newTrip.EndDate);
            await transaction.CommitAsync();

            return await GetTripDetailsAsync(userId, newTrip.Id);
        }
        catch (Exception e) when (e is ArgumentNullException || e is InvalidOperationException || e is ArgumentException || e is HttpRequestException || e is ValidationException)
        {
            if (_dbContext.Database.CurrentTransaction != null) await _dbContext.Database.RollbackTransactionAsync();
            throw new InvalidOperationException($"{ErrorMessage.CreateTrip} {e.Message}");
        }
    }

    private async Task<Guid?> GetDestinationId(string providerId)
    {
        var fetchedPlace = await _placesService.GetProviderPlaceAsync(providerId) ?? throw new InvalidOperationException(ErrorMessage.ProviderPlaceNotFound);

        Guid? id = await _dbContext.Places
            .OfType<ProviderPlace>()
            .Where(p => fetchedPlace.ProviderId == p.ProviderId)
            .Select(p => (Guid?)p.Id)
            .FirstOrDefaultAsync();

        return id;
    }

    private async Task<Guid> AddDestinationAsync(string providerId)
    {
        PlaceRequestDTO placeRequest = new(){ ProviderId = providerId};
        var newDestination = await _placesService.AddPlaceAsync(placeRequest);
        return newDestination.Id;
    }

    private async Task<bool> AddTripDaysAsync(Guid tripId, DateOnly from, DateOnly to)
    {
        var tripDays = Enumerable.Range(0, to.DayNumber - from.DayNumber + 1)
                                 .Select(offset => new TripDay
                                 {
                                     Id = Guid.NewGuid(),
                                     TripId = tripId,
                                     Date = from.AddDays(offset)
                                 });

        await _dbContext.TripDays.AddRangeAsync(tripDays);
        return await _dbContext.SaveChangesAsync() == tripDays.Count();
    }

    private async Task ValidateTripRequest(string userId, TripRequestDTO trip)
    {
        _ = trip ?? throw new ArgumentNullException(nameof(trip), ErrorMessage.EmptyRequest);

        if (trip.StartDate > trip.EndDate) throw new ArgumentException(ErrorMessage.StartDateAfterEndDate);

        if (trip.CategoryProfileId is not null) await _categoryProfileService.GetCategoryProfileDetailsAsync(userId, trip.CategoryProfileId.Value);
        if (trip.ConditionProfileId is not null) await _conditionProfileService.GetConditionProfileDetailsAsync(userId, trip.ConditionProfileId.Value);
    }

    public async Task<bool> DeleteTripAsync(string userId, Guid tripId)
    {
        try
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            await DeleteTripDuringTransactionAsync(userId, tripId);

            await transaction.CommitAsync();

            return true;
        }
        catch (Exception e) when (e is InvalidOperationException)
        {
            if (_dbContext.Database.CurrentTransaction != null)
            {
                await _dbContext.Database.RollbackTransactionAsync();
            }
            throw new InvalidOperationException($"{ErrorMessage.DeleteTrip} {e.Message}");
        }
    }

    private async Task<bool> DeleteTripDuringTransactionAsync(string userId, Guid tripId)
    {
        Trip trip = await _dbContext.Trips
            .Include(tp => tp.TripDays)
            .Where(tp => tp.Id == tripId
                && tp.UserId == userId)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(ErrorMessage.TripNotFound);

        if (trip.TripDays != null)
        {
            foreach (var tripDay in trip.TripDays.ToList())
            {
                await DeleteTripDayDuringTransactionAsync(userId, tripDay.Id);
            }
        }

        _dbContext.Trips.Remove(trip);

        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> EditTripAsync(string userId, Guid tripId, TripRequestDTO trip)
    {
        try
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            Trip existingTrip = await _dbContext.Trips
                .Where(t => t.Id == tripId && t.UserId == userId)
                .Include(t => t.TripDays)
                .FirstOrDefaultAsync() ?? throw new InvalidOperationException(ErrorMessage.TripNotFound);

            await ValidateTripRequest(userId, trip);
            if (existingTrip.EndDate < DateOnly.FromDateTime(DateTime.Today)) throw new ArgumentException(ErrorMessage.TripFinished);
            if (trip.StartDate < existingTrip.StartDate && trip.StartDate < DateOnly.FromDateTime(DateTime.Today)) throw new ArgumentException(ErrorMessage.AddTripDaysInPast);

            if (existingTrip.CurrencyCode != trip.CurrencyCode) throw new InvalidOperationException(ErrorMessage.CurrencyChangeNotAllowed);

            if (existingTrip.Budget != trip.Budget * existingTrip.ExchangeRate)
            {
                decimal exchangeRate = await _nbpService.GetRateAsync(trip?.CurrencyCode ?? string.Empty) ?? throw new InvalidOperationException(ErrorMessage.RetriveExchangeRate);
                existingTrip.ExchangeRate = exchangeRate;
                existingTrip.Budget = trip!.Budget * exchangeRate;
            }

            if (existingTrip.StartDate != trip.StartDate || existingTrip.EndDate != trip.EndDate)
            {
                var tripDaysToRemove = existingTrip.TripDays?
                    .Where(td => td.Date < trip.StartDate || td.Date > trip.EndDate).ToList();

                foreach (var tripDay in tripDaysToRemove ?? [])
                {
                    await DeleteTripDayDuringTransactionAsync(userId, tripDay.Id);
                }

                if (trip.StartDate > existingTrip.EndDate || trip.EndDate < existingTrip.StartDate)
                {
                    await AddTripDaysAsync(existingTrip.Id, trip.StartDate, trip.EndDate);
                }
                else
                {
                    if (trip.StartDate < existingTrip.StartDate)
                    {
                        await AddTripDaysAsync(existingTrip.Id, trip.StartDate, existingTrip.StartDate.AddDays(-1));
                    }

                    if (trip.EndDate > existingTrip.EndDate)
                    {
                        await AddTripDaysAsync(existingTrip.Id, existingTrip.EndDate.AddDays(1), trip.EndDate);
                    }
                }

                existingTrip.StartDate = trip.StartDate;
                existingTrip.EndDate = trip.EndDate;
            }

            _ = trip?.DestinationProviderId ?? throw new InvalidOperationException(ErrorMessage.DestinationProviderIdIsNull);
            Guid destinationId = await GetDestinationId(trip.DestinationProviderId) ?? await AddDestinationAsync(trip.DestinationProviderId);

            existingTrip.Name = trip!.Name;
            existingTrip.NumberOfTravelers = trip.NumberOfTravelers;
            existingTrip.DestinationId = destinationId;
            existingTrip.CategoryProfileId = trip.CategoryProfileId;
            existingTrip.ConditionProfileId = trip.ConditionProfileId;

            var validationContext = new ValidationContext(existingTrip);
            Validator.ValidateObject(existingTrip, validationContext, validateAllProperties: true);

            _dbContext.Trips.Update(existingTrip);
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch (Exception e) when (e is ArgumentNullException || e is InvalidOperationException || e is ArgumentException || e is HttpRequestException || e is ValidationException)
        {
            if (_dbContext.Database.CurrentTransaction != null) await _dbContext.Database.RollbackTransactionAsync();
            throw new InvalidOperationException($"{ErrorMessage.EditTrip} {e.Message}");
        }

        return true;
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

    public async Task<TripDayDetailsDTO> GetTripDayDetailsAsync(string userId, Guid tripDayId)
    {
        var day = await _dbContext.TripDays
            .Where(p => p.Id == tripDayId && p.Trip!.UserId == userId)
            .Include(p => p.Trip)
            .Include(p => p.TripPoints!)
                .ThenInclude(tp => tp.Place)
            .Include(p => p.TransferPoints)
            .FirstOrDefaultAsync();

        if (day == null || day.Trip == null)
        {
            throw new ArgumentException(ErrorMessage.TripDayNotFound);
        }

        TripDayDetailsDTO dayDetails = new()
        {
            Id = day.Id,
            TripId = day.TripId,
            Date = day.Date,
        };


        dayDetails.TripPoints = day.TripPoints!.Select(tp => new TripPointOverviewDTO
        {
            Id = tp.Id,
            Name = tp.Name,
            TripDayId = tp.TripDayId,
            StartTime = tp.StartTime,
            EndTime = tp.EndTime,
            Latitude = tp.Place?.Latitude,
            Longitude = tp.Place?.Longitude
        }).ToList();

        dayDetails.TransferPoints = day.TransferPoints!.Select(tp => new TransferPointOverviewDTO
        {
            Id = tp.Id,
            TripDayId = tp.TripDayId,
            Seconds = (int?)tp.TransferTime.TotalSeconds,
            Mode = tp.Mode,
            FromTripPointId = tp.FromTripPointId,
            ToTripPointId = tp.ToTripPointId
        }).ToList();

        return dayDetails;

    }

    public async Task<TripDetailsDTO> GetTripDetailsAsync(string userId, Guid tripId)
    {
        var trip = await _dbContext.Trips
            .Where(p => p.Id == tripId && p.UserId == userId)
            .Include(p => p.TripDays!)
                .ThenInclude(td => td.TripPoints!)
                .ThenInclude(tp => tp != null ? tp.Place : null)
                .ThenInclude(p => p != null ? p.Reviews : null)
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
            Budget = Math.Round(trip.Budget / trip.ExchangeRate, 2),
            CurrencyCode = trip.CurrencyCode,
            CategoryProfileId = trip.CategoryProfileId,
            ConditionProfileId = trip.ConditionProfileId,
            PredictedCost = trip.PredictedCost,
            ActualCost = trip.ActualCost
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

    private async Task<bool> DeleteTripDayDuringTransactionAsync(string userId, Guid tripDayId)
    {
        TripDay tripDay = await _dbContext.TripDays
            .Include(tp => tp.Trip)
            .Include(tp => tp.TripPoints)
            .Where(tp => tp.Id == tripDayId
                && tp.Trip != null
                && tp.Trip.UserId == userId)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException(ErrorMessage.TripDayNotFound);

        if (tripDay.TripPoints != null)
        {
            foreach (var tripPoint in tripDay.TripPoints.ToList())
            {
                await _tripPointsService.DeleteTripPointDuringTransactionAsync(userId, tripPoint.Id);
            }
        }

        _dbContext.TripDays.Remove(tripDay);

        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<List<PlaceOverviewDTO>> GetPlaceRecommendationsAsync(string userId, Guid tripId, double radius, int? limit = null)
    {
        Trip trip = await _dbContext.Trips
            .Where(t => t.Id == tripId && t.UserId == userId)
            .Include(t => t.Destination)
            .Include(t => t.CategoryProfile)
                .ThenInclude(cp => cp!.Categories)
            .Include(t => t.ConditionProfile)
                .ThenInclude(cp => cp!.Conditions)
            .FirstOrDefaultAsync() ?? throw new ArgumentException(ErrorMessage.TripNotFound);

        if (trip.Destination == null || !trip.Destination.Latitude.HasValue || !trip.Destination.Longitude.HasValue)
        {
            throw new ArgumentException(ErrorMessage.NoCoordinatesInDestination);
        }

        if (trip.CategoryProfile == null || trip.CategoryProfile.Categories == null || trip.CategoryProfile.Categories.Count == 0)
        {
            throw new ArgumentException(ICategoryProfilesService.ErrorMessage.CategoryProfileNotFound);
        }

        return await _placesService.GetPlaceRecommendationsAsync((trip.Destination.Latitude.Value, trip.Destination.Longitude.Value), radius, trip.CategoryProfile.Categories, trip.ConditionProfile?.Conditions, limit);
    }
}