using TravelBuddyAPI.Services;

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

    private static async Task<IResult> AddressAutocomplete(GeoapifyClient client, string text, string? type = null, string? lang = null, string? filter = null, string? bias = null, string format = "json")
    {
        try
        {
            var response = await client.GetAddressAutocompleteAsync(text, type, lang, filter, bias, format);
            return Results.Content(response, "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> Details(string id, GeoapifyClient client)
    {
        try
        {
            var response = await client.GetPlaceDetailsAsync(id);
            return Results.Content(response, "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> Isoline(GeoapifyClient client, double latitude, double longitude, int range, string mode, string traffic = "approximated", string units = "metric", string type = "distance", string routeType = "balanced")
    {
        try
        {
            var response = await client.GetIsolineAsync((latitude, longitude), range, mode, traffic, units, type, routeType);
            return Results.Content(response, "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> NearbyPlacesByCircle(GeoapifyClient client, double latitude, double longitude, double radius, string categories, string? conditions = null, int? limit = null, int? offset = null)
    {
        var categoriesList = categories.Trim().Split(',').ToList();
        var conditionsList = conditions?.Trim().Split(',').ToList();

        try
        {
            var response = await client.GetNearbyPlacesAsync((latitude, longitude), radius, categoriesList, conditionsList, limit, offset);
            return Results.Content(response, "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> NearbyPlacesByRectangle(GeoapifyClient client, double startLatitude, double startLongitude, double endLatitude, double endLongitude, string categories, string? conditions = null, int? limit = null, int? offset = null)
    {
        var categoriesList = categories.Trim().Split(',').ToList();
        var conditionsList = conditions?.Trim().Split(',').ToList();

        try
        {
            var response = await client.GetNearbyPlacesAsync((startLatitude, startLongitude), (endLatitude, endLongitude), categoriesList, conditionsList, limit, offset);
            return Results.Content(response, "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> NearbyPlacesByGeometry(GeoapifyClient client, string geometryId, string categories, string? conditions = null, int? limit = null, int? offset = null)
    {
        var categoriesList = categories.Trim().Split(',').ToList();
        var conditionsList = conditions?.Trim().Split(',').ToList();

        try
        {
            var response = await client.GetNearbyPlacesAsync(geometryId, categoriesList, conditionsList, limit, offset);
            return Results.Content(response, "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> RouteTime(GeoapifyClient client, double startLatitude, double startLongitude, double endLatitude, double endLongitude, string mode, string traffic = "approximated", string units = "metric")
    {
        try
        {
            var response = await client.GetRouteTimeAsync((startLatitude, startLongitude), (endLatitude, endLongitude), mode, traffic, units);
            return Results.Content(response, "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }
}