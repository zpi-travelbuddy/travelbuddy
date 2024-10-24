using TravelBuddyAPI.Interfaces;
using RestSharp;
using Newtonsoft.Json;
using TravelBuddyAPI.Models;
using Microsoft.CSharp.RuntimeBinder;
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

    public async Task<List<ProviderPlace>?> GetAddressAutocompleteAsync(string text, string? type = null, string? lang = null, string? filter = null, string? bias = null, string format = "json")
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
        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving autocomplete results: {response.ErrorMessage}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            var places = ((IEnumerable<dynamic>?)jsonResponse?.results)?
                .Select(p => new ProviderPlace
                {
                    ProviderId = p.place_id,
                    Name = p.name,
                    Country = p.country,
                    City = p.city,
                    Street = p.street,
                    HouseNumber = p.housenumber,
                    Latitude = p.lat,
                    Longitude = p.lon
                }).ToList();

            return places;
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
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
        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving isoline: {response.ErrorMessage}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            return jsonResponse?.properties?.id;
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<List<ProviderPlace>?> GetNearbyPlacesAsync(double latitude, double longitude, double radius, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null)
    {
        return await GetNearbyPlacesAsync((latitude, longitude), radius, categories, conditions, limit, offset);
    }

    public async Task<List<ProviderPlace>?> GetNearbyPlacesAsync((double latitude, double longitude) location, double radius, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null)
    {
        var request = new RestRequest("v2/places", Method.Get);
        request.AddParameter("filter", $"circle:{location.longitude},{location.latitude},{radius}");
        if (categories != null) request.AddParameter("categories", string.Join(",", categories));
        if (conditions != null) request.AddParameter("conditions", string.Join(",", conditions));
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving autocomplete results: {response.ErrorMessage}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            return ParseFeatureCollection(jsonResponse);
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<List<ProviderPlace>?> GetNearbyPlacesAsync((double latitude, double longitude) start, (double latitude, double longitude) end, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null)
    {
        var request = new RestRequest("v2/places", Method.Get);
        request.AddParameter("filter", $"rect:{start.longitude},{start.latitude},{end.longitude},{end.latitude}");
        if (categories != null) request.AddParameter("categories", string.Join(",", categories));
        if (conditions != null) request.AddParameter("conditions", string.Join(",", conditions));
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving nearby places: {response.ErrorMessage}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            return ParseFeatureCollection(jsonResponse);
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<List<ProviderPlace>?> GetNearbyPlacesAsync(string geometryId, IEnumerable<string>? categories = null, IEnumerable<string>? conditions = null, int? limit = null, int? offset = null)
    {
        var request = new RestRequest($"v2/places", Method.Get);
        request.AddParameter("filter", $"geometry:{geometryId}");
        if (categories != null) request.AddParameter("categories", string.Join(",", categories));
        if (conditions != null) request.AddParameter("conditions", string.Join(",", conditions));
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving nearby places: {response.ErrorMessage}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            return ParseFeatureCollection(jsonResponse);
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<ProviderPlace?> GetPlaceDetailsAsync(string placeId)
    {
        var request = new RestRequest($"v2/place-details", Method.Get);
        request.AddParameter("id", placeId);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving route time: {response.ErrorMessage}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            return ParseFeatureCollection(jsonResponse)?[0];
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<TimeSpan?> GetRouteTimeAsync((double latitude, double longitude) start, (double latitude, double longitude) end, string mode, string traffic = "approximated", string units = "metric")
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

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving route time: {response.ErrorMessage}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            var seconds = jsonResponse?.sources_to_targets?[0]?[0]?.time;
            double result = 0;

            if (seconds is not null && double.TryParse(seconds.ToString(), out result))
            {
                return TimeSpan.FromSeconds(result);
            }
            return null;
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    private static List<ProviderPlace>? ParseFeatureCollection(dynamic jsonResponse)
    {
        return ((IEnumerable<dynamic>?)jsonResponse?.features)?
            .Select(f => f.properties)
            .Select(p => new ProviderPlace
            {
                ProviderId = p.place_id,
                Name = p.name,
                Country = p.country,
                City = p.city,
                Street = p.street,
                HouseNumber = p.housenumber,
                Latitude = p.lat,
                Longitude = p.lon
            }).ToList(); // TODO add categories and conditions, handle oppening hours
    }
}