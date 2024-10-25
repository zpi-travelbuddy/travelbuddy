using TravelBuddyAPI.Interfaces;
using RestSharp;
using Newtonsoft.Json;
using System.Diagnostics;
using Microsoft.CSharp.RuntimeBinder;

namespace TravelBuddyAPI.Services;

public class NBPClient : INBPService
{
    private readonly RestClient _client;

    public NBPClient()
    {
        _client = new RestClient("https://api.nbp.pl/api/exchangerates");
    }

    public async Task<decimal?> GetRateAsync(string currencyCode, DateOnly? date = null)
    {
        var endpoint = date.HasValue 
            ? $"rates/a/{currencyCode}/{date.Value:yyyy-MM-dd}" 
            : $"rates/a/{currencyCode}";
        var request = new RestRequest(endpoint, Method.Get);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful || response.Content is null)
        {
            throw new HttpRequestException($"Error retrieving rate: {response.Content}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

        try
        {

            if (jsonResponse?.rates?.Count is null || jsonResponse?.rates?.Count == 0)
            {
                throw new HttpRequestException($"Error rate is null or 0: {response.Content}");
            }

            return (decimal?)jsonResponse?.rates[0].mid;
        }
        catch (RuntimeBinderException e)
        {
            Debug.WriteLine(e.Message);
            throw;
        }
    }
    

    public async Task<string?> GetCurrencyAsync(){
        var request = new RestRequest($"tables/a", Method.Get);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving currency: {response.Content}");
        }

        return response.Content;
    }
    public async Task<decimal?> GetClosestRateAsync(string currencyCode, DateOnly date, int maxRetries = 2)
    {
        try
        {
            decimal? rate = await GetRateAsync(currencyCode, date);
            return rate;
        }
        catch (HttpRequestException)
        {
            Debug.WriteLine($"Error retrieving rate for {currencyCode} on {date}");
        }

        for (int i = 1; i <= maxRetries; i++)
        {
            try
            {
                if (date.AddDays(i) > DateOnly.FromDateTime(DateTime.Now))
                {
                    decimal? rate = await GetRateAsync(currencyCode, date.AddDays(i));
                    return rate;
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine($"Error retrieving rate for {currencyCode} on {date}: {ex.Message}");
            }

            try
            {
                decimal? rate = await GetRateAsync(currencyCode, date.AddDays(-i));
                return rate;
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine($"Error retrieving rate for {currencyCode} on {date}: {ex.Message}");
            }
        }

        throw new HttpRequestException($"Error: Unable to retrieve rate for {currencyCode} on or around {date} after {maxRetries} retries.");
    }
}