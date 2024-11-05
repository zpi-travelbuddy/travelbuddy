using System.Text.Json;
using TravelBuddyAPI.DTOs.Currency;
using TravelBuddyAPI.Interfaces;

namespace TravelBuddyAPI.Endpoints;

public static class NBPEndpoints
{
    public static WebApplication MapNBPEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/nbp");

        group.MapGet("/rate", Rate);
        group.MapGet("/currency", Currency);
        group.MapGet("/closestrate", GetClosestRate);

        return app;
    }

    private static async Task<IResult> Rate(INBPService client, string currencyCode, DateOnly? date = null)
    {
        try
        {
            var response = await client.GetRateAsync(currencyCode, date);
            return Results.Content(response?.ToString(), "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

        private static async Task<IResult> GetClosestRate(INBPService client, string currencyCode, DateOnly date, int maxRetries = 2)
    {
        try
        {
            var response = await client.GetClosestRateAsync(currencyCode, date, maxRetries);
            return Results.Content(response?.ToString(), "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> Currency(INBPService client)
    {
        try
        {
            var response = await client.GetCurrenciesAsync();

            if (response is null)
            {
                return Results.BadRequest("Response is null");
            }

            return Results.Ok(response);

        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }


}