using System.ComponentModel.DataAnnotations;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.DTOs.PlaceCondition;
using TravelBuddyAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Models;
using static TravelBuddyAPI.Interfaces.IPlacesService;

namespace TravelBuddyAPI.Services;

public class PlacesService(TravelBuddyDbContext dbContext, IGeoapifyService geoapifyService, ITravelBuddyDbCache dbCache) : IPlacesService
{
    private readonly TravelBuddyDbContext _dbContext = dbContext;
    private readonly IGeoapifyService _geoapifyService = geoapifyService;
    private readonly ITravelBuddyDbCache _dbCache = dbCache;

    public async Task<PlaceDetailsDTO> AddPlaceAsync(PlaceRequestDTO place)
    {
        Place newPlace = place.ProviderId is not null
            ? new ProviderPlace()
            {
                ProviderId = place.ProviderId,
            }
            : new CustomPlace()
            {
                Id = Guid.NewGuid(),
                Name = place.Name,
                Country = place.Country,
                State = place.State,
                City = place.City,
                Street = place.Street,
                HouseNumber = place.HouseNumber,
                Latitude = place.Latitude,
                Longitude = place.Longitude,
            };

        if (newPlace is ProviderPlace providerPlace && providerPlace.ProviderId is not null)
        {
            var placeDetails = await _geoapifyService.GetPlaceDetailsAsync(providerPlace.ProviderId);
            _ = placeDetails ?? throw new ArgumentException(ErrorMessages.IncorrectProviderPlaceId);
            providerPlace.Id = Guid.NewGuid();

            var categories = placeDetails.Categories is not null
                ? await _dbContext.PlaceCategories
                    .Where(c => placeDetails.Categories.Select(pc => pc.Name).Contains(c.Name))
                    .ToListAsync()
                : [];

            var conditions = placeDetails.Conditions is not null
                ? await _dbContext.PlaceConditions
                    .Where(c => placeDetails.Conditions.Select(pc => pc.Name).Contains(c.Name))
                    .ToListAsync()
                : [];

            providerPlace = placeDetails;
            providerPlace.Categories = categories;
            providerPlace.Conditions = conditions;
            newPlace = providerPlace;
        }
        else if (newPlace is CustomPlace customPlace)
        {
            var categories = await _dbCache.GetCategoriesAsync();
            customPlace.PlaceCategory = categories?.FirstOrDefault(c => c.Id == place.CategoryId);
        }

        var validationContext = new ValidationContext(newPlace);
        Validator.ValidateObject(newPlace, validationContext, validateAllProperties: true);

        await _dbContext.Places.AddAsync(newPlace);
        await _dbContext.SaveChangesAsync();

        return await GetPlaceDetailsAsync(newPlace.Id);
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
                    State = p.State,
                    City = p.City,
                };
            }).ToList() ?? [];
    }

    public async Task<PlaceDetailsDTO> GetPlaceDetailsAsync(Guid id)
    {
        var place = await _dbContext.Places
            .Where(p => p.Id == id)
            .FirstAsync();

        PlaceDetailsDTO placeDetails = new()
        {
            Id = place.Id,
            Name = place.Name,
            Country = place.Country,
            State = place.State,
            City = place.City,
            Street = place.Street,
            HouseNumber = place.HouseNumber,
            Latitude = place.Latitude,
            Longitude = place.Longitude,
        };

        if (place is ProviderPlace) // TODO Add AverageCostPerPerson, AverageTimeSpent, AverageRating
        {
            ProviderPlace providerPlace = await _dbContext.Places
                .OfType<ProviderPlace>()
                .Include(p => p.Categories)
                .Include(p => p.Conditions)
                .Where(p => p.Id == place.Id)
                .FirstAsync();

            placeDetails.ProviderId = providerPlace.ProviderId;
            placeDetails.Categories = providerPlace?.Categories?
                .Select(c => new PlaceCategoryDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();
            placeDetails.Conditions = providerPlace?.Conditions?
                .Select(c => new PlaceConditionDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();
        }
        else if (place is CustomPlace customPlace && customPlace.PlaceCategory is not null)
        {
            placeDetails.SuperCategory = new PlaceCategoryDTO
            {
                Id = customPlace.PlaceCategory.Id,
                Name = customPlace.PlaceCategory.Name,
            };
        }

        return placeDetails;
    }

    public async Task<ProviderPlace?> GetProviderPlaceAsync(string providerId)
    {
        return await _geoapifyService.GetPlaceDetailsAsync(providerId);
    }
}