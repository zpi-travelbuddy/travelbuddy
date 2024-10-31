using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Services;

public class PlacesService(TravelBuddyDbContext dbContext, IGeoapifyService geoapifyService, ITravelBuddyDbCache dbCache) : IPlacesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly IGeoapifyService _geoapifyService = geoapifyService;
    private readonly ITravelBuddyDbCache _dbCache = dbCache;

    public Task<bool> AddPlaceAsync(PlaceRequestDTO place)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletePlaceAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PlaceOverviewDTO>> GetAutocompleteDestinationsAsync(string query)
    {
        try
        {
            var places = await _geoapifyService.GetAddressAutocompleteAsync(query, Enums.AddressLevel.city) ?? [];
            var results = await PlacesToOverviewDTOsAsync(places);
            return results.Where(p => p.City != null).ToList();
        }
        catch (HttpRequestException)
        {
            return [];
        }
    }

    public async Task<List<PlaceOverviewDTO>> GetAutocompletePlacesAsync(string query, decimal? latitude, decimal? longitude)
    {
        string? bias = null;

        if (latitude.HasValue && longitude.HasValue)
        {
            bias = $"proximity:{longitude},{latitude}";
        }

        try
        {
            var places = await _geoapifyService.GetAddressAutocompleteAsync(query, Enums.AddressLevel.amenity, bias: bias) ?? [];
            return await PlacesToOverviewDTOsAsync(places);
        }
        catch (HttpRequestException)
        {
            return [];
        }
    }

    private async Task<List<PlaceOverviewDTO>> PlacesToOverviewDTOsAsync(List<ProviderPlace> places)
    {
        var existingPlaces = await _dbContext.Places
            .OfType<ProviderPlace>()
            .Where(p => places.Select(pl => pl.ProviderId).Contains(p.ProviderId))
            .ToListAsync();

        return places?.Select(p =>
            {
                var existingPlace = existingPlaces.FirstOrDefault(ep => ep.ProviderId == p.ProviderId);
                return new PlaceOverviewDTO
                {
                    Id = existingPlace?.Id,
                    ProviderId = p.ProviderId,
                    Name = p.Name,
                    Country = p.Country,
                    City = p.City,
                };
            }).ToList() ?? [];
    }

    public Task<PlaceDetailsDTO> GetPlaceDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}