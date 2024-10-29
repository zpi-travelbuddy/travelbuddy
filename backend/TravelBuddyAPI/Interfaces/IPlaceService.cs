using TravelBuddyAPI.DTOs.Place;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for place-related services.
/// </summary>
public interface IPlaceService
{
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
    /// Retrieves the details of a place based on the provided identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the place.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="PlaceDetailsDTO"/>.</returns>
    Task<PlaceDetailsDTO> GetPlaceDetailsAsync(Guid id);

    /// <summary>
    /// Adds a new place based on the provided place request data.
    /// </summary>
    /// <param name="place">The data transfer object containing the place information.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the place was successfully added.</returns>
    Task<bool> AddPlaceAsync(PlaceRequestDTO place);

    /// <summary>
    /// Deletes a place based on the provided identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the place to be deleted.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the place was successfully deleted.</returns>
    Task<bool> DeletePlaceAsync(Guid id);
}