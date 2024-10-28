using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for accessing cached data related to TravelBuddy.
/// </summary>
public interface ITravelBuddyDbCache
{
    /// <summary>
    /// Asynchronously retrieves a list of place categories with a hierarchy of supercategories from the cache.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="PlaceCategory"/> objects, or null if the data is not available.</returns>
    Task<List<PlaceCategory>?> GetCategoriesAsync();

    /// <summary>
    /// Asynchronously retrieves a list of place conditions with a hierarchy of superconditions from the cache.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="PlaceCondition"/> objects, or null if the data is not available.</returns>
    Task<List<PlaceCondition>?> GetConditionsAsync();
}