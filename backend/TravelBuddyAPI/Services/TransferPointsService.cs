using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.TransferPoint;
using TravelBuddyAPI.DTOs.TripDay;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Services;

public class TransferPointsService(TravelBuddyDbContext dbContext, IGeoapifyService geoapifyService) : ITransferPointsService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly IGeoapifyService _geoapifyService = geoapifyService;

    public static class ErrorMessage
    {
        public const string EmptyRequest = "Request cannot be empty.";
        public const string SameTripPoints = "From and To trip points cannot be the same.";
        public const string TransferPointNotFound = "Transfer point not found.";
        public const string TripDayNotFound = "Trip day not found.";
        public const string TripPointNotFoundInTripDay = "Trip points not found in the trip day.";
        public const string InvalidTransferPointTime = "Transfer point time is invalid.";
        public const string CreateTransferPoint = "An error occurred while creating a transfer point:";
        public const string DeleteTransferPoint = "An error occurred while deleting a transfer point:";
        public const string EditTransferPoint = "An error occurred while editing a transfer point:";
    }

    public async Task<TransferPointDTO> CreateTransferPointAsync(string userId, TransferPointDTO transferPoint)
    {
        try
        {
            _ = transferPoint ?? throw new ArgumentNullException(nameof(transferPoint), ErrorMessage.EmptyRequest);

            _ = transferPoint.FromTripPointId ?? throw new InvalidOperationException(ErrorMessage.TransferPointNotFound);
            _ = transferPoint.ToTripPointId ?? throw new InvalidOperationException(ErrorMessage.TransferPointNotFound);
            
            if(transferPoint.FromTripPointId == transferPoint.ToTripPointId)
            {
                throw new InvalidOperationException(ErrorMessage.SameTripPoints);
            }

            var tripDay = await _dbContext.TripDays
                .Where(p => p.Id == transferPoint.TripDayId && p.Trip!.UserId == userId)
                .Include(p => p.Trip!)
                .Include(p => p.TripPoints!)
                    .ThenInclude(tp => tp!.Place)
                .FirstOrDefaultAsync();
            
            _ = tripDay ?? throw new InvalidOperationException(ErrorMessage.TripDayNotFound);

            var fromTripPoint = tripDay.TripPoints?.FirstOrDefault(tp => tp.Id == transferPoint.FromTripPointId);
            var toTripPoint = tripDay.TripPoints?.FirstOrDefault(tp => tp.Id == transferPoint.ToTripPointId);

            if (tripDay.TripPoints == null || fromTripPoint == null || toTripPoint == null || fromTripPoint.Place == null || toTripPoint.Place == null)
            {
                throw new InvalidOperationException(ErrorMessage.TripPointNotFoundInTripDay);
            }

            TransferPoint newTranserPoint = new()
            {
                Id = Guid.NewGuid(),
                TripDayId = transferPoint.TripDayId,
                StartTime = transferPoint.StartTime,
                FromTripPointId = transferPoint.FromTripPointId,
                ToTripPointId = transferPoint.ToTripPointId,
                Mode = transferPoint.Mode,
                Type = transferPoint.Type
            };

            if(!(transferPoint.Seconds == null) ^ (transferPoint.Mode == null))
            {
                throw new InvalidOperationException(ErrorMessage.InvalidTransferPointTime);
            }
            else if(transferPoint.Seconds.HasValue)
            {
                newTranserPoint.TransferTime = TimeSpan.FromSeconds(transferPoint.Seconds.Value);
            }
            else
            {
                newTranserPoint.TransferTime = await _geoapifyService.GetRouteTimeAsync((fromTripPoint.Place!.Latitude,fromTripPoint.Place.Longitude), (toTripPoint.Place!.Latitude, toTripPoint.Place.Longitude), transferPoint.Mode!.Value)
                    ?? throw new InvalidOperationException(ErrorMessage.InvalidTransferPointTime);
            }

            var validationContext = new ValidationContext(newTranserPoint);
            Validator.ValidateObject(newTranserPoint, validationContext, validateAllProperties: true);

            await _dbContext.TransferPoints.AddAsync(newTranserPoint);
            await _dbContext.SaveChangesAsync();

            return new TransferPointDTO
            {
                TripDayId = newTranserPoint.TripDayId,
                StartTime = newTranserPoint.StartTime,
                Seconds = (int)newTranserPoint.TransferTime.TotalSeconds,
                FromTripPointId = newTranserPoint.FromTripPointId,
                ToTripPointId = newTranserPoint.ToTripPointId,
                Mode = newTranserPoint.Mode,
                Type = newTranserPoint.Type
            };
        }
        catch (Exception e) when (e is ArgumentNullException || e is InvalidOperationException || e is ArgumentException || e is HttpRequestException || e is ValidationException)
        {
            throw new InvalidOperationException($"{ErrorMessage.CreateTransferPoint} {e.Message}");
        }
    }

    public async Task<bool> DeleteTransferPointAsync(string userId, Guid transferPointId)
    {
        try
        {
            var transferPoint = await _dbContext.TransferPoints
                .Where(tp => tp.Id == transferPointId && tp.TripDay != null && tp.TripDay.Trip != null && tp.TripDay.Trip.UserId == userId)
                .Include(tp => tp.TripDay)
                .ThenInclude(td => td!.Trip)
                .FirstOrDefaultAsync();

            if (transferPoint == null)
            {
                throw new InvalidOperationException(ErrorMessage.TransferPointNotFound);
            }

            _dbContext.TransferPoints.Remove(transferPoint);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e) when (e is InvalidOperationException || e is ArgumentException)
        {
            throw new InvalidOperationException($"{ErrorMessage.DeleteTransferPoint} {e.Message}");
        }

        return true;
    }

    public async Task<bool> EditTransferPointAsync(string userId, Guid transferPointId, TransferPointDTO transferPoint)
    {
        try{

            var existingTransferPoint = await _dbContext.TransferPoints
                    .Where(tp => tp.Id == transferPointId && tp.TripDay != null && tp.TripDay.Trip != null && tp.TripDay.Trip.UserId == userId && tp.FromTripPoint != null && tp.ToTripPoint != null && tp.FromTripPoint.Place != null && tp.ToTripPoint.Place != null)
                    .Include(tp => tp.TripDay)
                        .ThenInclude(td => td!.Trip)
                    .Include(tp => tp.FromTripPoint)
                        .ThenInclude(ft => ft!.Place)
                    .Include(tp => tp.ToTripPoint)
                        .ThenInclude(tt => tt!.Place)
                    .FirstOrDefaultAsync();

            if (existingTransferPoint == null)
            {
                throw new InvalidOperationException(ErrorMessage.TransferPointNotFound);
            }

            existingTransferPoint.StartTime = transferPoint.StartTime;
            existingTransferPoint.Mode = transferPoint.Mode;
            existingTransferPoint.Type = transferPoint.Type;

            if (!(transferPoint.Seconds == null) ^ (transferPoint.Mode == null))
            {
                throw new InvalidOperationException(ErrorMessage.InvalidTransferPointTime);
            }
            else if (transferPoint.Seconds.HasValue)
            {
                existingTransferPoint.TransferTime = TimeSpan.FromSeconds(transferPoint.Seconds.Value);
            }
            else
            {
                existingTransferPoint.TransferTime = await _geoapifyService.GetRouteTimeAsync((existingTransferPoint.FromTripPoint!.Place!.Latitude, existingTransferPoint.FromTripPoint.Place.Longitude), (existingTransferPoint.ToTripPoint!.Place!.Latitude, existingTransferPoint.ToTripPoint.Place.Longitude), transferPoint.Mode!.Value)
                    ?? throw new InvalidOperationException(ErrorMessage.InvalidTransferPointTime);
            }

            var validationContext = new ValidationContext(existingTransferPoint);
            Validator.ValidateObject(existingTransferPoint, validationContext, validateAllProperties: true);

            _dbContext.TransferPoints.Update(existingTransferPoint);
            await _dbContext.SaveChangesAsync();

            return true;

        }
        catch (Exception e) when (e is InvalidOperationException || e is ArgumentException)
        {
            throw new InvalidOperationException($"{ErrorMessage.EditTransferPoint} {e.Message}");
        }
    }
}