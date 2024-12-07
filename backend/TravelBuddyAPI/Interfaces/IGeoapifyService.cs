using TravelBuddyAPI.Models;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for Geoapify service to interact with geographical data and services.
/// </summary>
public interface IGeoapifyService
{
    /// <summary>
    /// Retrieves a list of nearby places based on a location and radius.
    /// </summary>
    /// <param name="location">The latitude and longitude of the location.</param>
    /// <param name="radius">The radius to search within.</param>
    /// <param name="categories">Categories to filter the places.</param>
    /// <param name="conditions">Optional conditions to filter the places.</param>
    /// <param name="limit">Optional limit on the number of places to return.</param>
    /// <param name="offset">Optional offset for pagination.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of nearby places.</returns>
    public Task<List<ProviderPlace>?> GetNearbyPlacesAsync((decimal latitude, decimal longitude) location, double radius, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null);

    /// <summary>
    /// Retrieves a list of nearby places based on a start and end location.
    /// </summary>
    /// <param name="start">The latitude and longitude of the bounding box start corner.</param>
    /// <param name="end">The latitude and longitude of the bounding box end corner.</param>
    /// <param name="categories">Categories to filter the places.</param>
    /// <param name="conditions">Optional conditions to filter the places.</param>
    /// <param name="limit">Optional limit on the number of places to return.</param>
    /// <param name="offset">Optional offset for pagination.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of nearby places.</returns>
    public Task<List<ProviderPlace>?> GetNearbyPlacesAsync((decimal latitude, decimal longitude) start, (decimal latitude, decimal longitude) end, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null);

    /// <summary>
    /// Retrieves a list of nearby places based on a geometry ID.
    /// </summary>
    /// <param name="geometryId">The geometry ID to search within.</param>
    /// <param name="categories">Categories to filter the places.</param>
    /// <param name="conditions">Optional conditions to filter the places.</param>
    /// <param name="limit">Optional limit on the number of places to return.</param>
    /// <param name="offset">Optional offset for pagination.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of nearby places.</returns>
    public Task<List<ProviderPlace>?> GetNearbyPlacesAsync(string geometryId, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null);

    /// <summary>
    /// Retrieves an isoline based on a start location, range, and mode.
    /// </summary>
    /// <param name="start">The latitude and longitude of the start location.</param>
    /// <param name="range">The range for the isoline.</param>
    /// <param name="mode">The mode of transportation.</param>
    /// <param name="traffic">Optional traffic condition. Default is "approximated".</param>
    /// <param name="units">Optional units for the range. Default is "metric".</param>
    /// <param name="type">Optional type of isoline. Default is "distance".</param>
    /// <param name="routeType">Optional route type. Default is "balanced".</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the geometryId of the isoline.</returns>
    public Task<string?> GetIsolineAsync((decimal latitude, decimal longitude) start, int range, TransferMode mode, TrafficType traffic = TrafficType.approximated, Units units = Units.metric, IsolineType type = IsolineType.distance, TransferType routeType = TransferType.balanced);

    /// <summary>
    /// Retrieves the details of a place based on its ID.
    /// </summary>
    /// <param name="placeId">The ID of the place.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the details of the place.</returns>
    public Task<ProviderPlace?> GetPlaceDetailsAsync(string placeId);

    /// <summary>
    /// Retrieves a list of places based on an address autocomplete query.
    /// </summary>
    /// <param name="text">The text to autocomplete.</param>
    /// <param name="type">Optional type of place to filter the results.</param>
    /// <param name="lang">Optional language for the results.</param>
    /// <param name="filter">Optional filter for the results.</param>
    /// <param name="bias">Optional bias for the results.</param>
    /// <param name="format">Optional format of the results. Default is "json".</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of places.</returns>
    public Task<List<ProviderPlace>?> GetAddressAutocompleteAsync(string text, AddressLevel? type = null, string? lang = null, string? filter = null, string? bias = null, string format = "json");

    /// <summary>
    /// Retrieves the estimated route time between two locations.
    /// </summary>
    /// <param name="start">The latitude and longitude of the start location.</param>
    /// <param name="end">The latitude and longitude of the end location.</param>
    /// <param name="mode">The mode of transportation.</param>
    /// <param name="traffic">Optional traffic condition. Default is "approximated".</param>
    /// <param name="units">Optional units for the time. Default is "metric".</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the estimated route time.</returns>
    public Task<TimeSpan?> GetRouteTimeAsync((decimal latitude, decimal longitude) start, (decimal latitude, decimal longitude) end, TransferMode mode, TrafficType traffic = TrafficType.approximated, Units units = Units.metric);
}