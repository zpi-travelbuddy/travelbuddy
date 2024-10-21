using TravelBuddyAPI.Interfaces;
using RestSharp;
using Newtonsoft.Json;
using System.Diagnostics;

namespace TravelBuddyAPI.Services;

public class NBPClient : INBPService
{
    private readonly RestClient _client;

    public NBPClient()
    {
        _client = new RestClient("https://api.nbp.pl/api/exchangerates");
    }

    public async Task<string?> GetRateAsync(string currencyCode, DateOnly? date = null)
    {
        var request = date != null 
            ? new RestRequest($"rates/a/{currencyCode}/{date.Value.ToString("yyyy-MM-dd")}", Method.Get) 
            : new RestRequest($"rates/a/{currencyCode}", Method.Get);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving rate: {response.Content}");
        }

        return response.Content;
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
}