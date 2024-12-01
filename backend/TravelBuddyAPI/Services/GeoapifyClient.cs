using TravelBuddyAPI.Interfaces;
using RestSharp;
using Newtonsoft.Json;
using TravelBuddyAPI.Models;
using Microsoft.CSharp.RuntimeBinder;
using System.Diagnostics;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Services;

public class GeoapifyClient : IGeoapifyService
{
    private readonly IRestClient _client;
    private readonly ITravelBuddyDbCache _dataCache;
    private readonly string _apiKey;

    public GeoapifyClient(IConfiguration configuration, ITravelBuddyDbCache dataCache, IRestClient client)
    {
        _client = client;
        _dataCache = dataCache;
        _apiKey = configuration["Geoapify:Key"] ?? throw new ArgumentNullException($"{nameof(_apiKey)} is not set in the configuration");
    }

    public async Task<List<ProviderPlace>?> GetAddressAutocompleteAsync(string text, AddressLevel? type = null, string? lang = null, string? filter = null, string? bias = null, string format = "json")
    {
        var request = new RestRequest("v1/geocode/autocomplete", Method.Get);
        request.AddParameter("text", text);
        request.AddParameter("apiKey", _apiKey);
        if (type != null) request.AddParameter("type", type.ToString());
        if (lang != null) request.AddParameter("lang", lang);
        if (filter != null) request.AddParameter("filter", filter);
        if (bias != null) request.AddParameter("bias", bias);
        request.AddParameter("format", format);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving autocomplete results: {response.Content}");
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
                    State = p.state,
                    City = p.city,
                    Street = p.street,
                    HouseNumber = p.housenumber,
                    Latitude = p.lat,
                    Longitude = p.lon,
                }).ToList();

            return places;
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<string?> GetIsolineAsync((decimal latitude, decimal longitude) start, int range, TransferMode mode, TrafficType traffic = TrafficType.approximated, Units units = Units.metric, IsolineType type = IsolineType.distance, TransferType routeType = TransferType.balanced)
    {
        var request = new RestRequest("v1/isoline", Method.Get);
        request.AddParameter("lat", start.latitude);
        request.AddParameter("lon", start.longitude);
        request.AddParameter("range", range);
        request.AddParameter("mode", mode.ToString());
        request.AddParameter("traffic", traffic.ToString());
        request.AddParameter("units", units.ToString());
        request.AddParameter("type", type.ToString());
        request.AddParameter("route_type", routeType.ToString());
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving isoline: {response.Content}");
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

    public async Task<List<ProviderPlace>?> GetNearbyPlacesAsync(decimal latitude, decimal longitude, double radius, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null)
    {
        return await GetNearbyPlacesAsync((latitude, longitude), radius, categories, conditions, limit, offset);
    }

    public async Task<List<ProviderPlace>?> GetNearbyPlacesAsync((decimal latitude, decimal longitude) location, double radius, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null)
    {
        (string? categoriesString, string? conditionsString) = await GetPreferencesStringsAsync(categories, conditions);

        var request = new RestRequest("v2/places", Method.Get);
        request.AddParameter("filter", $"circle:{location.longitude},{location.latitude},{radius}");
        if (categoriesString != null) request.AddParameter("categories", categoriesString);
        if (conditionsString != null && conditionsString.Length > 0) request.AddParameter("conditions", conditionsString);
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving nearby places: {response.Content}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            return ParseFeatureCollection(jsonResponse, categories?.ToList(), conditions?.ToList());
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<List<ProviderPlace>?> GetNearbyPlacesAsync((decimal latitude, decimal longitude) start, (decimal latitude, decimal longitude) end, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null)
    {
        (string? categoriesString, string? conditionsString) = await GetPreferencesStringsAsync(categories, conditions);

        var request = new RestRequest("v2/places", Method.Get);
        request.AddParameter("filter", $"rect:{start.longitude},{start.latitude},{end.longitude},{end.latitude}");
        if (categoriesString != null) request.AddParameter("categories", categoriesString);
        if (conditionsString != null && conditionsString.Length > 0) request.AddParameter("conditions", conditionsString);
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving nearby places: {response.Content}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            return ParseFeatureCollection(jsonResponse, categories?.ToList(), conditions?.ToList());
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<List<ProviderPlace>?> GetNearbyPlacesAsync(string geometryId, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null, int? offset = null)
    {
        (string? categoriesString, string? conditionsString) = await GetPreferencesStringsAsync(categories, conditions);

        var request = new RestRequest($"v2/places", Method.Get);
        request.AddParameter("filter", $"geometry:{geometryId}");
        if (categoriesString != null) request.AddParameter("categories", categoriesString);
        if (conditionsString != null && conditionsString.Length > 0) request.AddParameter("conditions", conditionsString);
        if (limit.HasValue) request.AddParameter("limit", limit.Value);
        if (offset.HasValue) request.AddParameter("offset", offset.Value);
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving nearby places: {response.Content}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            return ParseFeatureCollection(jsonResponse, categories?.ToList(), conditions?.ToList());
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
            throw new HttpRequestException($"Error retrieving provider place details: {response.Content}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            var categories = await _dataCache.GetCategoriesAsync();
            var conditions = await _dataCache.GetConditionsAsync();

            return ParseFeatureCollection(jsonResponse, categories, conditions)?[0];
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<TimeSpan?> GetRouteTimeAsync((decimal latitude, decimal longitude) start, (decimal latitude, decimal longitude) end, TransferMode mode, TrafficType traffic = TrafficType.approximated, Units units = Units.metric)
    {
        var request = new RestRequest("v1/routing", Method.Get);
        request.AddHeader("Content-Type", "application/json");
        request.AddParameter("waypoints", $"{start.latitude},{start.longitude}|{end.latitude},{end.longitude}");
        request.AddParameter("mode", mode.ToString());
        request.AddParameter("traffic", traffic.ToString());
        request.AddParameter("units", units.ToString());
        request.AddParameter("apiKey", _apiKey);

        var response = await _client.ExecuteAsync(request);

        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving route time: {response.Content}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {
            var seconds = jsonResponse?.features?[0]?.properties?.time;
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

    public static List<ProviderPlace>? ParseFeatureCollection(dynamic jsonResponse, List<PlaceCategory>? categories = null, List<PlaceCondition>? conditions = null)
    {
        return ((IEnumerable<dynamic>?)jsonResponse?.features)?
            .Select(f => f.properties)
            .Select(p => new ProviderPlace
            {
                ProviderId = p.place_id,
                Name = p.name,
                Country = p.country,
                State = p.state,
                City = p.city,
                Street = p.street,
                HouseNumber = p.housenumber,
                Latitude = p.lat,
                Longitude = p.lon,
                OpeningHours = p.opening_hours,
                Categories = categories?
                    .Where(cat => ((IEnumerable<dynamic>?)p.categories)?
                        .Any(c => c.ToString() == cat.FullName) ?? false)
                    .ToList(),
                Conditions = conditions?
                    .Where(con => ((IEnumerable<dynamic>?)p.categories)? // Yes, p.categories is correct, API returns conditions as categories.
                        .Any(c => c.ToString() == con.FullName) ?? false)
                    .ToList(),
            }).ToList();
    }

    private async Task<(string? categories, string? conditions)> GetPreferencesStringsAsync(IEnumerable<PlaceCategory>? categories, IEnumerable<PlaceCondition>? conditions)
    {
        var categoriesList = await _dataCache.GetCategoriesAsync();
        var conditionsList = await _dataCache.GetConditionsAsync();

        var categoriesNames = categoriesList?
            .Where(cat => categories != null && categories.Any(c => c.Id == cat.Id))
            .Select(cat => cat.FullName);

        var conditionsNames = conditionsList?
            .Where(con => conditions != null && conditions.Any(c => c.Id == con.Id))
            .Select(con => con.FullName);

        return (categoriesNames != null ? string.Join(",", categoriesNames) : null, conditionsNames != null ? string.Join(",", conditionsNames) : null);
    }
}