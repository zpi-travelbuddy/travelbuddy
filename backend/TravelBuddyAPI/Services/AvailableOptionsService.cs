using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Currency;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.DTOs.PlaceCondition;
using TravelBuddyAPI.Interfaces;

namespace TravelBuddyAPI.Services;

public class AvailableOptionsService(ITravelBuddyDbCache dbCache, INBPService nbpService) : IAvailableOptionsService
{
    private readonly ITravelBuddyDbCache _dbCache = dbCache;
    private readonly INBPService _nbpService = nbpService;

    public Task<List<PlaceCategoryDTO>> GetAvailableCategoriesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<PlaceConditionDTO>> GetAvailableConditionsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<CurrencyDTO>> GetAvailableCurrenciesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<PlaceCategoryDTO>> GetAvailableSupercategoriesAsync()
    {
        throw new NotImplementedException();
    }
}