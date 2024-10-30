using TravelBuddyAPI.DTOs.Trip;
using TravelBuddyAPI.DTOs.TripDay;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for managing trips.
/// </summary>
public interface ITripsService
{
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
    Task<Trip> CreateTripAsync(string userId, TripRequestDTO trip);

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
}