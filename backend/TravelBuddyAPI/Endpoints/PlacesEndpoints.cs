using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.Interfaces;

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

    private static async Task<Results<Ok<List<PlaceOverviewDTO>>, NotFound<string>>> GetAutocompletePlacesAsync(string query, decimal? latitude, decimal? longitude, IPlacesService placesService)
    {
        var places = await placesService.GetAutocompletePlacesAsync(query, latitude, longitude);

        if (places.Count == 0)
        {
            return TypedResults.NotFound("No places found");
        }
        else
        {
            return TypedResults.Ok(places);
        }
    }

    private static async Task<Results<Ok<PlaceDetailsDTO>, NotFound<string>>> GetPlaceDetailsAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }
}
