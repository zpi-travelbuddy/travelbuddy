using Newtonsoft.Json.Serialization;
using TravelBuddyAPI.Enums;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Endpoints;

public static class GeoapifyEndpoints
{
    public static WebApplication MapGeoapifyEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/geoapify");

        group.MapGet("/autocomplete", AddressAutocomplete);
        group.MapGet("/details", Details);
        group.MapGet("/isoline", Isoline);
        group.MapGet("/nearbyPlaces/circle", NearbyPlacesByCircle);
        group.MapGet("/nearbyPlaces/rectangle", NearbyPlacesByRectangle);
        group.MapGet("/nearbyPlaces/geometry", NearbyPlacesByGeometry);
        group.MapGet("/routeTime", RouteTime);

        return app;
    }

    private static async Task<IResult> AddressAutocomplete(IGeoapifyService client, string text, AddressLevel? type = null, string? lang = null, string? filter = null, string? bias = null, string format = "json")
    {
        try
        {
            var response = await client.GetAddressAutocompleteAsync(text, type, lang, filter, bias, format);
            return Results.Ok(response);
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> Details(string id, IGeoapifyService client)
    {
        try
        {
            var response = await client.GetPlaceDetailsAsync(id);
            return Results.Ok(response);
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> Isoline(IGeoapifyService client, decimal latitude, decimal longitude, int range, TransferMode mode, TrafficType traffic = TrafficType.approximated, Units units = Units.metric, IsolineType type = IsolineType.distance, TransferType routeType = TransferType.balanced)
    {
        try
        {
            var isoline_id = await client.GetIsolineAsync((latitude, longitude), range, mode, traffic, units, type, routeType);
            return Results.Ok(new { id = isoline_id });
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> NearbyPlacesByCircle(IGeoapifyService client, ITravelBuddyDbCache cache, decimal latitude, decimal longitude, double radius, string categories, string? conditions = null, int? limit = null, int? offset = null)
    {
        var (categoriesList, conditionsList) = await ParseCategoriesAndConditions(cache, categories, conditions);    

        if (categoriesList is null)
        {
            return Results.BadRequest("Categories not found"); 
        }

        try
        {
            var response = await client.GetNearbyPlacesAsync((latitude, longitude), radius, categoriesList, conditionsList, limit, offset);
            return Results.Ok(response);
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> NearbyPlacesByRectangle(IGeoapifyService client, ITravelBuddyDbCache cache, decimal startLatitude, decimal startLongitude, decimal endLatitude, decimal endLongitude, string categories, string? conditions = null, int? limit = null, int? offset = null)
    {
        var (categoriesList, conditionsList) = await ParseCategoriesAndConditions(cache, categories, conditions);

        if (categoriesList is null)
        {
            return Results.BadRequest("Categories not found"); 
        }

        try
        {
            var response = await client.GetNearbyPlacesAsync((startLatitude, startLongitude), (endLatitude, endLongitude), categoriesList, conditionsList, limit, offset);
            return Results.Ok(response);
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> NearbyPlacesByGeometry(IGeoapifyService client, ITravelBuddyDbCache cache, string geometryId, string categories, string? conditions = null, int? limit = null, int? offset = null)
    {
        var (categoriesList, conditionsList) = await ParseCategoriesAndConditions(cache, categories, conditions);

        if (categoriesList is null)
        {
            return Results.BadRequest("Categories not found"); 
        }

        try
        {
            var response = await client.GetNearbyPlacesAsync(geometryId, categoriesList, conditionsList, limit, offset);
            return Results.Ok(response);
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> RouteTime(IGeoapifyService client, decimal startLatitude, decimal startLongitude, decimal endLatitude, decimal endLongitude, TransferMode mode, TrafficType traffic = TrafficType.approximated, Units units = Units.metric)
    {
        try
        {
            var response = await client.GetRouteTimeAsync((startLatitude, startLongitude), (endLatitude, endLongitude), mode, traffic, units);
            return Results.Ok(new { time = response });
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<(List<PlaceCategory>?, List<PlaceCondition>?)> ParseCategoriesAndConditions(ITravelBuddyDbCache cache, string categories, string? conditions)
    {
        var parsedCategories = categories.Trim().Split(',').ToList();
        var parsedConditions = conditions?.Trim().Split(',').ToList();

        var cachedCategories = await cache.GetCategoriesAsync();
        var cachedConditions = await cache.GetConditionsAsync();

        var categoriesList = cachedCategories?.Where(c => parsedCategories.Contains(c.FullName ?? ""));
        var conditionsList = cachedConditions?.Where(c => parsedConditions?.Contains(c.FullName ?? "") ?? false);

        return (categoriesList?.ToList(), conditionsList?.ToList());
    }
}