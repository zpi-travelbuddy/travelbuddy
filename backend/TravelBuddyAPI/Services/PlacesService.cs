using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.Interfaces;

namespace TravelBuddyAPI.Services;

public class PlacesService(TravelBuddyDbContext dbContext, IGeoapifyService geoapifyService) : IPlacesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly IGeoapifyService _geoapifyService = geoapifyService;

    public Task<bool> AddPlaceAsync(PlaceRequestDTO place)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletePlaceAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<PlaceOverviewDTO>> GetAutocompleteDestinationsAsync(string query)
    {
        throw new NotImplementedException();
    }

    public Task<List<PlaceOverviewDTO>> GetAutocompletePlacesAsync(string query, decimal? latitude, decimal? longitude)
    {
        throw new NotImplementedException();
    }

    public Task<PlaceDetailsDTO> GetPlaceDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}