using Microsoft.Extensions.Caching.Memory;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelBuddyAPI.Services;

public class TravelBuddyDbCache : ITravelBuddyDbCache
{
    private readonly IMemoryCache _cache;
    private readonly TravelBuddyDbContext _context;
    private readonly TimeSpan _cacheDuration = TimeSpan.FromHours(1);

    public TravelBuddyDbCache(IMemoryCache cache, TravelBuddyDbContext context)
    {
        _cache = cache;
        _context = context;
    }

    public async Task<List<PlaceCategory>?> GetCategoriesAsync()
    {
        string cacheKey = "categories";

        if (!_cache.TryGetValue(cacheKey, out List<PlaceCategory>? categories))
        {
            categories = await GetCategoriesWithSuperCategoryAsync();

            _cache.Set(cacheKey, categories, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = _cacheDuration
            });
        }

        return categories;
    }

    public async Task<List<PlaceCondition>?> GetConditionsAsync()
    {
        string cacheKey = "conditions";

        if (!_cache.TryGetValue(cacheKey, out List<PlaceCondition>? conditions))
        {
            conditions = await GetConditionsWithSuperConditionAsync();

            _cache.Set(cacheKey, conditions, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = _cacheDuration
            });
        }

        return conditions;
    }

    private async Task<List<PlaceCategory>> GetCategoriesWithSuperCategoryAsync()
    {
        var categories = await _context.PlaceCategories
            .AsNoTracking()
            .Include(c => c.SuperCategory)
            .ToListAsync();

        foreach (var category in categories)
        {
            await LoadSuperCategoriesRecursively(category);
        }

        return categories;
    }

    private async Task LoadSuperCategoriesRecursively(PlaceCategory category)
    {
        if (category.SuperCategoryId != null)
        {
            category.SuperCategory = await _context.PlaceCategories
                .AsNoTracking()
                .Include(c => c.SuperCategory)
                .FirstOrDefaultAsync(c => c.Id == category.SuperCategoryId);

            if (category.SuperCategory != null)
            {
                await LoadSuperCategoriesRecursively(category.SuperCategory);
            }
        }
    }

    private async Task<List<PlaceCondition>> GetConditionsWithSuperConditionAsync()
    {
        var conditions = await _context.PlaceConditions
            .AsNoTracking()
            .Include(c => c.SuperCondition)
            .ToListAsync();

        foreach (var condition in conditions)
        {
            await LoadSuperConditionsRecursively(condition);
        }

        return conditions;
    }

    private async Task LoadSuperConditionsRecursively(PlaceCondition condition)
    {
        if (condition.SuperConditionId != null)
        {
            condition.SuperCondition = await _context.PlaceConditions
                .AsNoTracking()
                .Include(c => c.SuperCondition)
                .FirstOrDefaultAsync(c => c.Id == condition.SuperConditionId);

            if (condition.SuperCondition != null)
            {
                await LoadSuperConditionsRecursively(condition.SuperCondition);
            }
        }
    }


}