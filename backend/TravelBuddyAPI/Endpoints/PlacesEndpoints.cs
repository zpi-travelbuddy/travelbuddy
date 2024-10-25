using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.Place;

namespace TravelBuddyAPI.Endpoints;

public static class PlacesEndpoints
{
    public static WebApplication MapPlacesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/places").RequireAuthorization();

        group.MapGet("/{id}", GetPlaceDetailsAsync)
            .WithName("GetPlaceDetails");

        group.MapGet("/autocomplete", GetAutocompletePlacesAsync)
            .WithName("GetAutocompletePlaces");

        return app;
    }

    private static async Task<Results<Ok<List<PlaceOverviewDTO>>, NotFound<string>>> GetAutocompletePlacesAsync(string query, decimal? latitude, decimal? longitude)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<PlaceDetailsDTO>, NotFound<string>>> GetPlaceDetailsAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }
}
