using TravelBuddyAPI.DTOs.Currency;

namespace TravelBuddyAPI.Interfaces;

public interface INBPService
{
    public Task<decimal?> GetRateAsync(string currencyCode, DateOnly? date = null);
    public Task<decimal?> GetClosestRateAsync(string currencyCode, DateOnly date, int maxRetries = 2);
    public Task<List<CurrencyDTO>> GetCurrenciesAsync();
}