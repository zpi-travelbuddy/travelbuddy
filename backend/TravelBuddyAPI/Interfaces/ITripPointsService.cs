using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for managing trip points.
/// </summary>
public interface ITripPointsService
{
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
        public const string TripPointReviewNotFound = "Could not find trip point review of given id.";
        public const string TripPointReviewExists = "Trip point review already exists.";
        public const string TripPointWrongStatus = "Trip point has an incorrect status: ";
        public const string CreateTripPointReview = "An error occurred while creating a trip point review.";
        public const string EditTripPoint = "An error occurred while editing a trip point.";
        public const string RejectTripPointReview = "An error occurred while rejecting a trip point review.";
    }

    /// <summary>
    /// Creates a new trip point.
    /// </summary>
    /// <param name="userId">The ID of the user creating the trip point.</param>
    /// <param name="tripPoint">The details of the trip point to create.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the created trip point details.</returns>
    Task<TripPointDetailsDTO> CreateTripPointAsync(string userId, TripPointRequestDTO tripPoint);

    /// <summary>
    /// Edits an existing trip point.
    /// </summary>
    /// <param name="userId">The ID of the user editing the trip point.</param>
    /// <param name="tripPointId">The ID of the trip point to edit.</param>
    /// <param name="tripPoint">The updated details of the trip point.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the edit was successful.</returns>
    Task<bool> EditTripPointAsync(string userId, Guid tripPointId, TripPointRequestDTO tripPoint);

    /// <summary>
    /// Deletes a trip point.
    /// </summary>
    /// <param name="userId">The ID of the user deleting the trip point.</param>
    /// <param name="tripPointId">The ID of the trip point to delete.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the deletion was successful.</returns>
    Task<bool> DeleteTripPointAsync(string userId, Guid tripPointId);

    /// <summary>
    /// Deletes a trip point during a transaction asynchronously.
    /// </summary>
    /// <param name="userId">The ID of the user deleting the trip point.</param>
    /// <param name="tripPointId">The ID of the trip point to delete.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the deletion was successful.</returns>
    Task<bool> DeleteTripPointDuringTransactionAsync(string userId, Guid tripPointId);


    /// <summary>
    /// Gets the details of a specific trip point.
    /// </summary>
    /// <param name="userId">The ID of the user requesting the trip point details.</param>
    /// <param name="tripPointId">The ID of the trip point to retrieve details for.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trip point details.</returns>
    Task<TripPointDetailsDTO> GetTripPointDetailsAsync(string userId, Guid tripPointId);

    /// <summary>
    /// Gets a list of trip points for a specific trip day.
    /// </summary>
    /// <param name="userId">The ID of the user requesting the trip points.</param>
    /// <param name="tripDayId">The ID of the trip day to retrieve trip points for.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of trip point overviews.</returns>
    Task<List<TripPointOverviewDTO>> GetTripPointsAsync(string userId, Guid tripDayId);

    /// <summary>
    /// Reviews a trip point.
    /// </summary>
    /// <param name="userId">The ID of the user reviewing the trip point.</param>
    /// <param name="tripPointId">The ID of the trip point to review.</param>
    /// <param name="tripPointReview">The details of the trip point review.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trip point review details.</returns>
    Task<TripPointReviewDetailsDTO> ReviewTripPointAsync(string userId, Guid tripPointId, TripPointReviewRequestDTO tripPointReview);

    /// <summary>
    /// Rejects a trip point review.
    /// </summary>
    /// <param name="userId">The ID of the user rejecting the trip point review.</param>
    /// <param name="tripPointId">The ID of the trip point to reject the review for.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task RejectTripPointReviewAsync(string userId, Guid tripPointId);

    /// <summary>
    /// Retrieves the details of a specific trip point review.
    /// </summary>
    /// <param name="userId">The ID of the user requesting the trip point review details.</param>
    /// <param name="tripPointReviewId">The ID of the trip point review to retrieve details for.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trip point review details.</returns>
    Task<TripPointReviewDetailsDTO> GetTripPointReviewDetailsAsync(string userId, Guid tripPointReviewId);

    /// <summary>
    /// Gets a list of reviews for trip points.
    /// </summary>
    /// <param name="userId">The ID of the user requesting the trip point reviews.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of trip point review overviews.</returns>
    Task<List<TripPointReviewOverviewDTO>> GetTripPointsReviewsAsync(string userId);

}