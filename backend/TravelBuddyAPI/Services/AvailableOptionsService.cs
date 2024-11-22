using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Currency;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.DTOs.PlaceCondition;
using TravelBuddyAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TravelBuddyAPI.Services;

public class AvailableOptionsService(ITravelBuddyDbCache dbCache, INBPService nbpService, TravelBuddyDbContext dbContext) : IAvailableOptionsService
{
    private readonly ITravelBuddyDbCache _dbCache = dbCache;
    private readonly INBPService _nbpService = nbpService;
    private readonly TravelBuddyDbContext _dbContext = dbContext;

    public async Task<List<PlaceCategoryNodeDTO>> GetAvailableCategoriesAsync()
    {
        return await _dbCache.GetCategoryTreeDTOAsync();
    }

    public async Task<List<PlaceConditionNodeDTO>> GetAvailableConditionsAsync()
    {
        return await _dbCache.GetConditionTreeDTOAsync();
    }

    public async Task<List<CurrencyDTO>> GetAvailableCurrenciesAsync()
    {
        return await _nbpService.GetCurrenciesAsync();
    }

    public async Task<List<PlaceCategoryDTO>> GetAvailableSupercategoriesAsync()
    {
        return await _dbContext.PlaceCategories
            .Where(c => c.SuperCategoryId == null)
            .Select(c => new PlaceCategoryDTO
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToListAsync();
    }
}