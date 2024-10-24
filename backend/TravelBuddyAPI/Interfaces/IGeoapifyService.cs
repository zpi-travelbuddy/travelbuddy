using Microsoft.AspNetCore.Mvc.Razor;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Interfaces;

public interface IGeoapifyService
{
    public Task<List<ProviderPlace>?> GetNearbyPlacesAsync((double latitude, double longitude) location, double radius, IEnumerable<PlaceCategory>? categories = null, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null);
    public Task<List<ProviderPlace>?> GetNearbyPlacesAsync((double latitude, double longitude) start, (double latitude, double longitude) end, IEnumerable<PlaceCategory>? categories = null, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null);
    public Task<List<ProviderPlace>?> GetNearbyPlacesAsync(string geometryId, IEnumerable<PlaceCategory>? categories = null, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null);
    public Task<string?> GetIsolineAsync((double latitude, double longitude) start, int range, string mode, string traffic = "approximated", string units = "metric", string type = "distance", string routeType = "balanced");
    public Task<ProviderPlace?> GetPlaceDetailsAsync(string placeId);
    public Task<List<ProviderPlace>?> GetAddressAutocompleteAsync(string text, string? type = null, string? lang = null, string? filter = null, string? bias = null, string format = "json");
    public Task<TimeSpan?> GetRouteTimeAsync((double latitude, double longitude) start, (double latitude, double longitude) end, string mode, string traffic = "approximated", string units = "metric");
}