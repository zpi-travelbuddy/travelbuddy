using Microsoft.AspNetCore.Mvc.Razor;

namespace TravelBuddyAPI.Interfaces;

public interface INBPService
{
    public Task<string?> GetRateAsync(string currencyCode, DateOnly? date = null);
    public Task<string?> GetCurrencyAsync();
}