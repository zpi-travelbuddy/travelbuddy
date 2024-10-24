namespace TravelBuddyAPI.Interfaces;

public interface INBPService
{
    public Task<Decimal?> GetRateAsync(string currencyCode, DateOnly? date = null);
    public Task<string?> GetCurrencyAsync();
}