using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.Trip;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.TripDay;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.Currency;
using TravelBuddyAPI.Interfaces;
using System.Security.Claims;

namespace TravelBuddyAPI.Endpoints;

public static class TripsEndpoints
{
    public static WebApplication MapTripsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/trips").RequireAuthorization();

        group.MapPost("", CreateTripAsync)
            .WithName("CreateTrip");

        group.MapPut("/{id}", EditTripAsync)
            .WithName("EditTrip");

        group.MapDelete("/{id}", DeleteTripAsync)
            .WithName("DeleteTrip");

        group.MapGet("/{id}", GetTripDetailsAsync)
            .WithName("GetTripDetails");

        group.MapGet("/summary/{id}", GetTripSummaryAsync)
            .WithName("GetTripSummary");

        group.MapGet("/current", GetCurrentTripsAsync)
            .WithName("GetCurrentTrips");

        group.MapGet("/past", GetPastTripsAsync)
            .WithName("GetPastTrips");

        group.MapGet("/pastWithStatistics", GetPastTripsWithStatisticsAsync)
            .WithName("GetPastTripsWithStatistics");

        group.MapGet("/autocompleteDestination", GetAutocompleteDestinationsAsync)
            .WithName("GetAutocompleteDestinations");

        group.MapGet("/tripDay/{id}", GetTripDayDetailsAsync)
            .WithName("GetTripDayDetails");

        group.MapGet("/recomendations/{tripDayId}", GetRecomendationsAsync)
            .WithName("GetRecomendations");

        group.MapGet("/statistics", GetTripStatisticsAsync)
            .WithName("GetTripStatistics");

        group.MapGet("/availableCurrencies", GetAvailableCurrenciesAsync)
            .WithName("GetAvailableCurrencies");

        return app;
    }

    private static async Task<Results<Ok<List<CurrencyDTO>>, NotFound<string>>> GetAvailableCurrenciesAsync() //TODO
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<TripStatisticsDTO>, NotFound<string>>> GetTripStatisticsAsync(int year, int? month, string currencyCode)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<TripSummaryDTO>, NotFound<string>>> GetTripSummaryAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<List<TripOverviewWithStatisticsDTO>>, NotFound<string>>> GetPastTripsWithStatisticsAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<List<PlaceOverviewDTO>>, NotFound<string>>> GetAutocompleteDestinationsAsync(string query, IPlacesService placesService)
    {
        var places = await placesService.GetAutocompleteDestinationsAsync(query);
        
        if (places.Count != 0)
        {
            return TypedResults.Ok(places);
        }
        else {
            return TypedResults.NotFound("No places found");
        }
    }

    private static async Task<Results<NoContent, NotFound<string>>> DeleteTripAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<TripDetailsDTO>, NotFound<string>>> GetTripDetailsAsync(Guid id, ITripsService tripsService, HttpContext httpContext)
   {
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var tripDetails = await tripsService.GetTripDetailsAsync(userId, id);
            return TypedResults.Ok(tripDetails);
        } catch (ArgumentException ex) {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<Ok<List<TripOverviewDTO>>, NotFound<string>>> GetCurrentTripsAsync(ITripsService tripsService, HttpContext httpContext)
    {
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var trips = await tripsService.GetCurrentTripsAsync(userId);
            return trips.Count > 0 ? TypedResults.Ok(trips) : TypedResults.NotFound("No current trips found.");
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<Ok<List<TripOverviewDTO>>, NotFound<string>>> GetPastTripsAsync(ITripsService tripsService, HttpContext httpContext)
    {
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var trips = await tripsService.GetPastTripsAsync(userId);
            return trips.Count > 0 ? TypedResults.Ok(trips) : TypedResults.NotFound("No past trips found.");
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<Accepted<string>, NotFound<string>>> EditTripAsync(Guid id, TripRequestDTO trip)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<TripDetailsDTO>, BadRequest<string>>> CreateTripAsync(TripRequestDTO trip, ITripsService tripsService, HttpContext httpContext)
    {
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var tripDetails = await tripsService.CreateTripAsync(userId, trip);
            return TypedResults.Created($"/trips/{tripDetails.Id}", tripDetails);
        } catch (InvalidOperationException ex) {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<Ok<TripDayDetailsDTO>, NotFound<string>>> GetTripDayDetailsAsync(Guid id, ITripsService tripsService, HttpContext httpContext)
    {
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var dayDetails = await tripsService.GetTripDayDetailsAsync(userId, id);
            return TypedResults.Ok(dayDetails);
        } catch (ArgumentException ex) {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<Ok<List<PlaceOverviewDTO>>, NotFound<string>>> GetRecomendationsAsync(Guid tripDayId)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }
}