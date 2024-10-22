using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.Trip;

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
    
    private static async Task<IResult> GetAvailableCurrenciesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetTripStatisticsAsync(int year, int? month)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetTripSummaryAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetPastTripsWithStatisticsAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetAutocompleteDestinationsAsync(string query)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> DeleteTripAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetTripDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetCurrentTripsAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetPastTripsAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> EditTripAsync(Guid id, TripDTO trip)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> CreateTripAsync(TripDTO trip)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetTripDayDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetRecomendationsAsync(Guid tripDayId)
    {
        throw new NotImplementedException();
    }
}