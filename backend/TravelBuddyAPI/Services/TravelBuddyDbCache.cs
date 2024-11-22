using Microsoft.Extensions.Caching.Memory;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.DTOs.PlaceCondition;

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

    public async Task<List<PlaceCategory>> GetCategoryTreeAsync()
    {
        string cacheKey = "category_tree";

        if (!_cache.TryGetValue(cacheKey, out List<PlaceCategory>? categories))
        {
            categories = await GetCategoriesWithSubCategoriesAsync();

            _cache.Set(cacheKey, categories, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = _cacheDuration
            });
        }

        return categories ?? [];
    }

    public async Task<List<PlaceCategoryNodeDTO>> GetCategoryTreeDTOAsync()
    {
        var categories = await GetCategoryTreeAsync();

        return TransformCategoryTreeToDTO(categories);
    }

    private static List<PlaceCategoryNodeDTO> TransformCategoryTreeToDTO(List<PlaceCategory>? categories)
    {
        return categories?.Select(category => new PlaceCategoryNodeDTO
        {
            Id = category.Id,
            Name = category.Name,
            SubCategories = TransformCategoryTreeToDTO(category.SubCategories)
        }).ToList() ?? [];
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

    public async Task<List<PlaceCondition>> GetConditionTreeAsync()
    {
        string cacheKey = "condition_tree";

        if (!_cache.TryGetValue(cacheKey, out List<PlaceCondition>? conditions))
        {
            conditions = await GetConditionsWithSubConditionsAsync();

            _cache.Set(cacheKey, conditions, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = _cacheDuration
            });
        }

        return conditions ?? [];
    }

    public async Task<List<PlaceConditionNodeDTO>> GetConditionTreeDTOAsync()
    {
        var conditions = await GetConditionTreeAsync();

        return TransformConditionTreeToDTO(conditions);
    }

    private static List<PlaceConditionNodeDTO> TransformConditionTreeToDTO(List<PlaceCondition>? conditions)
    {
        return conditions?.Select(condition => new PlaceConditionNodeDTO
        {
            Id = condition.Id,
            Name = condition.Name,
            SubConditions = TransformConditionTreeToDTO(condition.SubConditions)
        }).ToList() ?? [];
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

    private async Task<List<PlaceCategory>> GetCategoriesWithSubCategoriesAsync()
    {
        var categories = await _context.PlaceCategories
            .AsNoTracking()
            .Where(c => c.SuperCategoryId == null)
            .Include(c => c.SubCategories)
            .ToListAsync();

        foreach (var category in categories)
        {
            await LoadSubCategoriesRecursively(category);
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

    private async Task LoadSubCategoriesRecursively(PlaceCategory category)
    {
        category.SubCategories = await _context.PlaceCategories
            .AsNoTracking()
            .Where(c => c.SuperCategoryId == category.Id)
            .ToListAsync();

        foreach (var subCategory in category.SubCategories)
        {
            await LoadSubCategoriesRecursively(subCategory);
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

    private async Task<List<PlaceCondition>> GetConditionsWithSubConditionsAsync()
    {
        var conditions = await _context.PlaceConditions
            .AsNoTracking()
            .Where(c => c.SuperConditionId == null)
            .Include(c => c.SubConditions)
            .ToListAsync();

        foreach (var condition in conditions)
        {
            await LoadSubConditionsRecursively(condition);
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

    private async Task LoadSubConditionsRecursively(PlaceCondition condition)
    {
        condition.SubConditions = await _context.PlaceConditions
            .AsNoTracking()
            .Where(c => c.SuperConditionId == condition.Id)
            .ToListAsync();

        foreach (var subCondition in condition.SubConditions)
        {
            await LoadSubConditionsRecursively(subCondition);
        }
    }
}