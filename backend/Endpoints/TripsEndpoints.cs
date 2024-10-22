using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.Trip;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.TripDay;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.Currency;

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

    private static async Task<Results<Ok<List<CurrencyDTO>>, NotFound<string>>> GetAvailableCurrenciesAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<IResult> GetTripStatisticsAsync(int year, int? month) // TODO
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<IResult> GetTripSummaryAsync(Guid id) // TODO
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<IResult> GetPastTripsWithStatisticsAsync() // TODO
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<Results<Ok<List<PlaceOverviewDTO>>, NotFound<string>>> GetAutocompleteDestinationsAsync(string query)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<NoContent, NotFound<string>>> DeleteTripAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<TripDetailsDTO>, NotFound<string>>> GetTripDetailsAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<List<TripOverviewDTO>>, NotFound<string>>> GetCurrentTripsAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<List<TripOverviewDTO>>, NotFound<string>>> GetPastTripsAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Accepted<string>, NotFound<string>>> EditTripAsync(Guid id, TripRequestDTO trip)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<TripRequestDTO>, BadRequest<string>>> CreateTripAsync(TripRequestDTO trip)
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<Results<Ok<TripDayDetailsDTO>, NotFound<string>>> GetTripDayDetailsAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<List<PlaceOverviewDTO>>, NotFound<string>>> GetRecomendationsAsync(Guid tripDayId)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }
}