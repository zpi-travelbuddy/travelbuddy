using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Provides methods for managing places, including retrieving, adding, and deleting places.
/// </summary>
public interface IPlacesService
{
    public static class ErrorMessages
    {
        public const string IncorrectProviderPlaceId = "Could not find place with the given provider id.";
    }

    /// <summary>
    /// Retrieves a list of destination overviews based on the provided query for autocomplete purposes.
    /// </summary>
    /// <param name="query">The search query for destinations.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="PlaceOverviewDTO"/>.</returns>
    Task<List<PlaceOverviewDTO>> GetAutocompleteDestinationsAsync(string query);

    /// <summary>
    /// Retrieves a list of place overviews based on the provided query and optional coordinates for autocomplete purposes.
    /// </summary>
    /// <param name="query">The search query for places.</param>
    /// <param name="latitude">The optional latitude coordinate for filtering places.</param>
    /// <param name="longitude">The optional longitude coordinate for filtering places.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="PlaceOverviewDTO"/>.</returns>
    Task<List<PlaceOverviewDTO>> GetAutocompletePlacesAsync(string query, decimal? latitude, decimal? longitude);

    /// <summary>
    /// Retrieves a list of place recommendations based on the provided location and radius.
    /// </summary>
    /// <param name="location">The location (latitude and longitude) to search around.</param>
    /// <param name="radius">The radius within which to search for place recommendations.</param>
    /// <param name="limit">The optional limit on the number of recommendations to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="PlaceOverviewDTO"/>.</returns>
    Task<List<PlaceOverviewDTO>> GetPlaceRecommendationsAsync((decimal latitude, decimal longitude) location, double radius, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null);

    /// <summary>
    /// Retrieves the details of a place based on the identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the place.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="PlaceDetailsDTO"/>.</returns>
    Task<PlaceDetailsDTO> GetPlaceDetailsAsync(Guid id);

    /// <summary>
    /// Retrieves the details of a provider place based on the provider identifier.
    /// </summary>
    /// <param name="providerId">The unique provider identifier of the provider place.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="PlaceDetailsDTO"/>.</returns>
    Task<PlaceDetailsDTO> GetPlaceDetailsAsync(string providerId);

    /// <summary>
    /// Adds a new place based on the provided place request data.
    /// </summary>
    /// <param name="place">The data transfer object containing the place information.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the added <see cref="PlaceDetailsDTO"/>.</returns>
    Task<PlaceDetailsDTO> AddPlaceAsync(PlaceRequestDTO place);

    /// <summary>
    /// Deletes a place based on the provided identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the place to be deleted.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the place was successfully deleted.</returns>
    Task<bool> DeletePlaceAsync(Guid id);
}