using System.Security.Claims;
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

        group.MapGet("/provider/{providerId}", GetProviderPlaceDetailsAsync)
            .WithName("GetProviderPlaceDetails");

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

    private static async Task<Results<Ok<PlaceDetailsDTO>, NotFound<string>>> GetPlaceDetailsAsync(Guid id, IPlacesService placesService)
    {
        try {
            var placeDetails = await placesService.GetPlaceDetailsAsync(id);
            return TypedResults.Ok(placeDetails);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<Ok<PlaceDetailsDTO>, NotFound<string>>> GetProviderPlaceDetailsAsync(string providerId, IPlacesService placesService)
    {
        try {
            var placeDetails = await placesService.GetPlaceDetailsAsync(providerId);
            return TypedResults.Ok(placeDetails);
        }
        catch (ArgumentException ex)
        {
            return TypedResults.NotFound(ex.Message);
        }
    }
}
