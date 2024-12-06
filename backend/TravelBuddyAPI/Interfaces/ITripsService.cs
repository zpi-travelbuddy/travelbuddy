using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.Trip;
using TravelBuddyAPI.DTOs.TripDay;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for managing trips.
/// </summary>
public interface ITripsService
{
    public static class ErrorMessage
    {
        public const string EmptyRequest = "Request cannot be empty.";
        public const string StartDateAfterEndDate = "Start date cannot be after end date.";
        public const string StartDateInPast = "Start date cannot be in the past.";
        public const string AddTripDaysInPast = "Cannot add trip days in the past.";
        public const string TripFinished = "Cannot edit finished trip.";
        public const string CreateTrip = "An error occurred while creating a trip.";
        public const string EditTrip = "An error occurred while editing a trip.";
        public const string RetriveExchangeRate = "An error occurred while retrieving exchange rate.";
        public const string TripNotFound = "Trip with the specified Id does not exist.";
        public const string TripWithoutDays = "Trip does not have any days.";
        public const string TripDayNotFound = "Trip day with the specified Id does not exist.";
        public const string TooManyDecimalPlaces = "Budget must have at most 2 decimal places.";
        public const string DeleteTrip = "An error occurred while deleting a trip.";
        public const string CurrencyChangeNotAllowed = "Currency code cannot be changed.";
        public const string ProviderPlaceNotFound = "Provider place with the specified Id does not exist.";
        public const string DestinationProviderIdIsNull = "Destination provider Id cannot be null.";
        public const string GetRecommendations = "An error occurred while retrieving place recommendations.";
        public const string NoCoordinatesInDestination = "The destination does not have coordinates.";
    }

    /// <summary>
    /// Retrieves the current trips for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A list of current trips.</returns>
    Task<List<TripOverviewDTO>> GetCurrentTripsAsync(string userId);

    /// <summary>
    /// Retrieves the past trips for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A list of past trips.</returns>
    Task<List<TripOverviewDTO>> GetPastTripsAsync(string userId);

    /// <summary>
    /// Retrieves the past trips with statistics for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A list of past trips with statistics.</returns>
    Task<List<TripOverviewWithStatisticsDTO>> GetPastTripsWithStatisticsAsync(string userId);

    /// <summary>
    /// Creates a new trip for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="trip">The trip details.</param>
    /// <returns>The created trip.</returns>
    Task<TripDetailsDTO> CreateTripAsync(string userId, TripRequestDTO trip);

    /// <summary>
    /// Retrieves the details of a specific trip.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="tripId">The ID of the trip.</param>
    /// <returns>The trip details.</returns>
    Task<TripDetailsDTO> GetTripDetailsAsync(string userId, Guid tripId);

    /// <summary>
    /// Edits an existing trip for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="tripId">The ID of the trip.</param>
    /// <param name="trip">The updated trip details.</param>
    /// <returns>True if the trip was successfully edited; otherwise, false.</returns>
    Task<bool> EditTripAsync(string userId, Guid tripId, TripRequestDTO trip);

    /// <summary>
    /// Deletes a specific trip for a user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="tripId">The ID of the trip.</param>
    /// <returns>True if the trip was successfully deleted; otherwise, false.</returns>
    Task<bool> DeleteTripAsync(string userId, Guid tripId);

    /// <summary>
    /// Retrieves the summary of a specific trip.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="tripId">The ID of the trip.</param>
    /// <returns>The trip summary.</returns>
    Task<TripSummaryDTO> GetTripSummaryAsync(string userId, Guid tripId);

    /// <summary>
    /// Retrieves the statistics of trips for a specific user in a given year and optionally a specific month.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="year">The year for which to retrieve statistics.</param>
    /// <param name="month">The optional month for which to retrieve statistics.</param>
    /// <param name="currencyCode">The currency code for the statistics.</param>
    /// <returns>The trip statistics.</returns>
    Task<TripStatisticsDTO> GetTripStatisticsAsync(string userId, int year, int? month, string currencyCode);

    /// <summary>
    /// Retrieves the details of a specific trip day.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="tripDayId">The ID of the trip day.</param>
    /// <returns>The trip day details.</returns>
    Task<TripDayDetailsDTO> GetTripDayDetailsAsync(string userId, Guid tripDayId);

    /// <summary>
    /// Retrieves place recommendations for a specific trip within a given radius.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="tripId">The ID of the trip.</param>
    /// <param name="radius">The radius within which to search for places.</param>
    /// <param name="limit">The optional limit on the number of places to retrieve.</param>
    /// <returns>A list of place recommendations.</returns>
    Task<List<PlaceOverviewDTO>> GetPlaceRecommendationsAsync(string userId, Guid tripId, double radius, int? limit = null);
}