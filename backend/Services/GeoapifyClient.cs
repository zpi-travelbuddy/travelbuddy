using TravelBuddyAPI.Interfaces;
using RestSharp;
using Newtonsoft.Json;
using System.Diagnostics;

namespace TravelBuddyAPI.Services;

public class GeoapifyClient : IGeoapifyService
{
    private readonly RestClient _client;
    private readonly string _apiKey;

    public GeoapifyClient(IConfiguration configuration)
    {
        _client = new RestClient("https://api.geoapify.com/");
        _apiKey = configuration["GEOAPIFY_KEY"] ?? throw new ArgumentNullException($"{nameof(_apiKey)} is not set in the configuration");
    }

    public async Task<string?> GetAddressAutocompleteAsync(string text, string? type = null, string? lang = null, string? filter = null, string? bias = null, string format = "json")
    {
        var request = new RestRequest("v1/geocode/autocomplete", Method.Get);
        request.AddParameter("text", text);
        request.AddParameter("apiKey", _apiKey);
        if (type != null) request.AddParameter("type", type);
        if (lang != null) request.AddParameter("lang", lang);
        if (filter != null) request.AddParameter("filter", filter);
        if (bias != null) request.AddParameter("bias", bias);
        request.AddParameter("format", format);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving autocomplete results: {response.Content}");
        }

        return response.Content;
    }

    public async Task<string?> GetIsolineAsync((double latitude, double longitude) start, int range, string mode, string traffic = "approximated", string units = "metric", string type = "distance", string routeType = "balanced")
    {
        var request = new RestRequest("v1/isoline", Method.Get);
        request.AddParameter("lat", start.latitude);
        request.AddParameter("lon", start.longitude);
        request.AddParameter("range", range);
        request.AddParameter("mode", mode);
        request.AddParameter("traffic", traffic);
        request.AddParameter("units", units);
        request.AddParameter("type", type);
        request.AddParameter("route_type", routeType);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving isoline: {response.Content}");
        }

        return response.Content;
    }

    public async Task<string?> GetNearbyPlacesAsync(double latitude, double longitude, double radius, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null)
    {
        return await GetNearbyPlacesAsync((latitude, longitude), radius, categories, conditions, limit, offset);
    }

    public async Task<string?> GetNearbyPlacesAsync((double latitude, double longitude) location, double radius, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null)
    {
        var request = new RestRequest("v2/places", Method.Get);
        request.AddParameter("filter", $"circle:{location.longitude},{location.latitude},{radius}");
        if (categories != null) request.AddParameter("categories", string.Join(",", categories));
        if (conditions != null) request.AddParameter("conditions", string.Join(",", conditions));
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving nearby places: {response.Content}");
        }

        return response.Content;
    }

    public async Task<string?> GetNearbyPlacesAsync((double latitude, double longitude) start, (double latitude, double longitude) end, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null)
    {
        var request = new RestRequest("v2/places", Method.Get);
        request.AddParameter("filter", $"rect:{start.longitude},{start.latitude},{end.longitude},{end.latitude}");
        if (categories != null) request.AddParameter("categories", string.Join(",", categories));
        if (conditions != null) request.AddParameter("conditions", string.Join(",", conditions));
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving nearby places: {response.Content}");
        }

        return response.Content;
    }

    public async Task<string?> GetNearbyPlacesAsync(string geometryId, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null)
    {
        var request = new RestRequest($"v2/places", Method.Get);
        request.AddParameter("filter", $"geometry:{geometryId}");
        if (categories != null) request.AddParameter("categories", string.Join(",", categories));
        if (conditions != null) request.AddParameter("conditions", string.Join(",", conditions));
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving nearby places: {response.Content}");
        }

        return response.Content;
    }

    public async Task<string?> GetPlaceDetailsAsync(string placeId)
    {
        var request = new RestRequest($"v2/place-details", Method.Get);
        request.AddParameter("id", placeId);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving place details: {response.Content}");
        }

        return response.Content;
    }

    public async Task<string?> GetRouteTimeAsync((double latitude, double longitude) start, (double latitude, double longitude) end, string mode, string traffic = "approximated", string units = "metric")
    {
        var request = new RestRequest("v1/routematrix", Method.Post);
        request.AddHeader("Content-Type", "application/json");
        var body = new
        {
            mode,
            sources = new[] { new { location = new double[] { start.longitude, start.latitude } } },
            targets = new[] { new { location = new double[] { end.longitude, end.latitude } } },
            traffic,
            units
        };
        request.AddJsonBody(body);
        request.AddQueryParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving route time: {response.Content}");
        }

        return response.Content;
    }
}