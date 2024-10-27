using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Interfaces;

public interface ITravelBuddyDbCache
{
    Task<List<PlaceCategory>?> GetCategoriesAsync();

    Task<List<PlaceCondition>?> GetConditionsAsync();
}