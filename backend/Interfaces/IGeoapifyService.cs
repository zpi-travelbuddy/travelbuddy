using Microsoft.AspNetCore.Mvc.Razor;

namespace TravelBuddyAPI.Interfaces;

public interface IGeoapifyService
{
    public Task<string?> GetNearbyPlacesAsync((double latitude, double longitude) location, double radius, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null);
    public Task<string?> GetNearbyPlacesAsync((double latitude, double longitude) start, (double latitude, double longitude) end, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null);
    public Task<string?> GetNearbyPlacesAsync(string geometryId, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null);
    public Task<string?> GetIsolineAsync((double latitude, double longitude) start, int range, string mode, string traffic = "approximated", string units = "metric", string type = "distance", string routeType = "balanced");
    public Task<string?> GetPlaceDetailsAsync(string placeId);
    public Task<string?> GetAddressAutocompleteAsync(string text, string? type = null, string? lang = null, string? filter = null, string? bias = null, string format = "json");
    public Task<string?> GetRouteTimeAsync((double latitude, double longitude) start, (double latitude, double longitude) end, string mode, string traffic = "approximated", string units = "metric");
}