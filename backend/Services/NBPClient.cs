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

    public async Task<decimal?> GetRateAsync(string currencyCode, DateOnly? date = null)
    {
        var endpoint = date.HasValue 
            ? $"rates/a/{currencyCode}/{date.Value:yyyy-MM-dd}" 
            : $"rates/a/{currencyCode}";
        var request = new RestRequest(endpoint, Method.Get);

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            throw new HttpRequestException($"Error retrieving rate: {response.Content}");
        }

        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content!);
        if (jsonResponse == null || jsonResponse!.rates == null || jsonResponse!.rates.Count == 0)
        {
            return null;
        }

        return (decimal?)jsonResponse!.rates[0].mid;
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