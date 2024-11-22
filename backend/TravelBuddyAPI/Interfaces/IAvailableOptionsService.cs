using TravelBuddyAPI.DTOs.Currency;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.DTOs.PlaceCondition;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Provides methods to retrieve available options for various entities.
/// </summary>
public interface IAvailableOptionsService
{
    /// <summary>
    /// Retrieves a list of available currencies.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="CurrencyDTO"/>.</returns>
    Task<List<CurrencyDTO>> GetAvailableCurrenciesAsync();

    /// <summary>
    /// Retrieves a list of available supercategories.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="PlaceCategoryDTO"/>.</returns>
    Task<List<PlaceCategoryDTO>> GetAvailableSupercategoriesAsync();

    /// <summary>
    /// Retrieves a list of available categories.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="PlaceCategoryDTO"/>.</returns>
    Task<List<PlaceCategoryNodeDTO>> GetAvailableCategoriesAsync();

    /// <summary>
    /// Retrieves a list of available conditions.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="PlaceConditionDTO"/>.</returns>
    Task<List<PlaceConditionNodeDTO>> GetAvailableConditionsAsync();
}