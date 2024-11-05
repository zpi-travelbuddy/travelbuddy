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
        public const string TripPointNotFound = "Trip point not found.";
        public const string TripPointNotFoundInTripDay = "Trip points not found in the trip day.";
        public const string InvalidTransferPointTime = "Transfer point time is invalid.";
        public const string CreateTransferPoint = "An error occurred while creating a transfer point:";

    }

    public async Task<TransferPointDTO> CreateTransferPointAsync(string userId, TransferPointDTO transferPoint)
    {
        try
        {
            _ = transferPoint ?? throw new ArgumentNullException(nameof(transferPoint), ErrorMessage.EmptyRequest);

            _ = transferPoint.FromTripPointId ?? throw new InvalidOperationException();
            _ = transferPoint.ToTripPointId ?? throw new InvalidOperationException();
            
            if(transferPoint.FromTripPointId == transferPoint.ToTripPointId)
            {
                throw new InvalidOperationException(ErrorMessage.SameTripPoints);
            }

            var tripPoint = await _dbContext.TripDays
                .Where(p => p.Id == transferPoint.TripDayId && p.Trip!.UserId == userId)
                .Include(p => p.Trip!)
                .Include(p => p.TripPoints)
                .FirstOrDefaultAsync();

            
            _ = tripPoint ?? throw new InvalidOperationException(ErrorMessage.TripPointNotFound);

            if (tripPoint.TripPoints == null || !tripPoint.TripPoints.Any(tp => tp.Id == transferPoint.FromTripPointId) || !tripPoint.TripPoints.Any(tp => tp.Id == transferPoint.ToTripPointId))
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
            };

            if(transferPoint.Seconds == null || transferPoint.Mode == null)
            {
                throw new InvalidOperationException(ErrorMessage.InvalidTransferPointTime);
            }
            else if(transferPoint.Seconds.HasValue)
            {
                newTranserPoint.TransferTime = TimeSpan.FromSeconds(transferPoint.Seconds.Value);
            }
            else
            {
               //TODO: Calculate transfer time
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
        var transferPoint = await _dbContext.TransferPoints
            .Include(tp => tp.TripDay)
            .ThenInclude(td => td.Trip)
            .FirstOrDefaultAsync(tp => tp.Id == transferPointId && tp.TripDay != null && tp.TripDay.Trip != null && tp.TripDay.Trip.UserId == userId);

        if (transferPoint == null)
        {
            throw new InvalidOperationException("Transfer point not found.");
        }

        _dbContext.TransferPoints.Remove(transferPoint);
        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> EditTransferPointAsync(string userId, Guid transferPointId, TransferPointDTO transferPoint)
    {
        var existingTransferPoint = await _dbContext.TransferPoints
            .Include(tp => tp.TripDay)
            .ThenInclude(td => td.Trip)
            .FirstOrDefaultAsync(tp => tp.Id == transferPointId && tp.TripDay.Trip.UserId == userId);

        if (existingTransferPoint == null)
        {
            throw new InvalidOperationException("Transfer point not found.");
        }

        existingTransferPoint.StartTime = transferPoint.StartTime;
        existingTransferPoint.FromTripPointId = transferPoint.FromTripPointId;
        existingTransferPoint.ToTripPointId = transferPoint.ToTripPointId;

        if (transferPoint.Seconds == null || transferPoint.Mode == null)
        {
            throw new InvalidOperationException(ErrorMessage.InvalidTransferPointTime);
        }
        else if (transferPoint.Seconds.HasValue)
        {
            existingTransferPoint.TransferTime = TimeSpan.FromSeconds(transferPoint.Seconds.Value);
        }
        else
        {
            //TODO: Calculate transfer time
        }

        var validationContext = new ValidationContext(existingTransferPoint);
        Validator.ValidateObject(existingTransferPoint, validationContext, validateAllProperties: true);

        _dbContext.TransferPoints.Update(existingTransferPoint);
        await _dbContext.SaveChangesAsync();

        return true;
    }
}