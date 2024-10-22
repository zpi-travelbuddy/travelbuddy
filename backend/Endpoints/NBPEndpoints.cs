using System.Text.Json;
using TravelBuddy.ViewModels.Currency;
using TravelBuddyAPI.Services;

namespace TravelBuddyAPI.Endpoints;

public static class NBPEndpoints
{
    public static WebApplication MapNBPEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/nbp");

        group.MapGet("/rate", Rate);
        group.MapGet("/currency", Currency);

        return app;
    }

    private static async Task<IResult> Rate(NBPClient client, string currencyCode, DateTime? date = null)
    {
        try
        {
            var dateOnly = date.HasValue ? DateOnly.FromDateTime(date.Value) : (DateOnly?)null;
            var response = await client.GetRateAsync(currencyCode, dateOnly);
            return Results.Content(response, "application/json");
        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }

    private static async Task<IResult> Currency(NBPClient client)
    {
        try
        {
            var response = await client.GetCurrencyAsync();

            if (response is null)
            {
                return Results.BadRequest("Response is null");
            }

            var jsonDocument = JsonDocument.Parse(response);
            var ratesElement = jsonDocument.RootElement[0].GetProperty("rates");

            var currencyList = ratesElement.EnumerateArray()
                                        .Select(rate => new CurrencyViewModel
                                        {
                                            Code = rate.GetProperty("code").GetString(),
                                            Name = rate.GetProperty("currency").GetString()
                                        })
                                        .ToList();

            return Results.Ok(currencyList);

        }
        catch (HttpRequestException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }


}