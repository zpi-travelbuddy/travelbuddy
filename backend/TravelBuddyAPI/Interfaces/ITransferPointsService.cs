using TravelBuddyAPI.DTOs.TransferPoint;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for managing transfer points.
/// </summary>
public interface ITransferPointsService
{
    public static class ErrorMessage
    {
        public const string EmptyRequest = "The request cannot be empty.";
        public const string SameTripPoints = "The 'From' and 'To' trip points cannot be the same.";
        public const string TransferPointNotFound = "Transfer point not found.";
        public const string TripDayNotFound = "Trip day not found.";
        public const string TripPointNotFoundInTripDay = "Trip points not found in the trip day.";
        public const string TripPointNotFoundInRequestBody = "Trip points not found in the request body.";
        public const string InvalidTransferPointTime = "Transfer point time is invalid.";
        public const string CreateTransferPoint = "An error occurred while creating a transfer point.";
        public const string DeleteTransferPoint = "An error occurred while deleting a transfer point.";
        public const string EditTransferPoint = "An error occurred while editing a transfer point.";
        public const string NullLatitudeOrLongitude = "Latitude or Longitude cannot be null when mode is present.";
        public const string InvalidTransferPointTimeConflict = "Cannot provide seconds when mode is present.";
        public const string TripPointAlreadyConnected = "The trip point is already connected to a transfer point.";
        public const string TransferPointTimeOutOfRange = "Transfer point time must be between 0 (exclusive) and 86400 (exclusive) seconds.";
        public const string FromTripPointMustBeBeforeToTripPoint = "The 'From' trip point must end before the 'To' trip point starts.";
        public const string ToTripPointInThePastCreate = "Cannot create transfer point when the 'To' trip point is in the past.";
        public const string ToTripPointInThePastEdit = "Cannot edit transfer point when the 'To' trip point is in the past.";
        public const string ToTripPointInThePastDelete = "Cannot remove transfer point when the 'To' trip point is in the past.";
    }

    /// <summary>
    /// Creates a new transfer point.
    /// </summary>
    /// <param name="userId">The ID of the user creating the transfer point.</param>
    /// <param name="transferPoint">The transfer point data to be created.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the created transfer point.</returns>
    Task<TransferPointOverviewDTO> CreateTransferPointAsync(string userId, TransferPointRequestDTO transferPoint);

    /// <summary>
    /// Edits an existing transfer point.
    /// </summary>
    /// <param name="userId">The ID of the user editing the transfer point.</param>
    /// <param name="transferPointId">The ID of the transfer point to be edited.</param>
    /// <param name="transferPoint">The transfer point data to be edited.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the edit was successful.</returns>
    Task<bool> EditTransferPointAsync(string userId, Guid transferPointId, TransferPointRequestDTO transferPoint);

    /// <summary>
    /// Deletes a transfer point.
    /// </summary>
    /// <param name="userId">The ID of the user deleting the transfer point.</param>
    /// <param name="transferPointId">The ID of the transfer point to be deleted.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the deletion was successful.</returns>
    Task<bool> DeleteTransferPointAsync(string userId, Guid transferPointId);
}