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
            var existingPlace = await GetExistingProviderPlaceAsync(placeDetails);
            if (existingPlace is not null)
            {
                return await GetPlaceDetailsAsync(existingPlace.Id);
            }

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
            customPlace.SuperCategoryId = place.SuperCategoryId;
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

            var results = places
                .Where(p => p.City != null)
                .GroupBy(p => p.ProviderId)
                .Select(g => g.OrderBy(p => p.ProviderId).First())
                .GroupBy(p => new { p.Name, p.Country, p.State, p.City, p.Street, p.HouseNumber })
                .Select(g => g.OrderBy(p => p.ProviderId).First())
                .ToList();

            return await PlacesToOverviewDTOsAsync(results);
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
            var places = await _geoapifyService
                .GetAddressAutocompleteAsync(query, Enums.AddressLevel.amenity, bias: bias) ?? [];
            var results = FilterAmmenities(places);

            return await PlacesToOverviewDTOsAsync(results);
        }
        catch (HttpRequestException)
        {
            return [];
        }
    }

    private async Task<List<PlaceOverviewDTO>> PlacesToOverviewDTOsAsync(List<ProviderPlace> places)
    {
        var existingPlaces = await GetExistingProviderPlacesListAsync(places); // TODO refactor

        return places?.Select(p =>
            {
                var existingPlace = existingPlaces.FirstOrDefault(ep => 
                    ep.ProviderId == p.ProviderId
                    || (ep.Name == p.Name &&
                        ep.Country == p.Country &&
                        ep.State == p.State &&
                        ep.City == p.City &&
                        ep.Street == p.Street &&
                        ep.HouseNumber == p.HouseNumber));
                return new PlaceOverviewDTO
                {
                    Id = existingPlace?.Id,
                    ProviderId = p.ProviderId,
                    Name = p.Name,
                    Country = p.Country,
                    State = p.State,
                    City = p.City,
                    Street = p.Street,
                    HouseNumber = p.HouseNumber,
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

        if (place is ProviderPlace providerPlace)
        {
            providerPlace = await GetExistingProviderPlaceAsync(providerPlace) ?? providerPlace;

            placeDetails.ProviderId = providerPlace.ProviderId;
            placeDetails.Categories = providerPlace.Categories?
                .Select(c => new PlaceCategoryDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();
            placeDetails.Conditions = providerPlace.Conditions?
                .Select(c => new PlaceConditionDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();

            placeDetails.AverageCostPerPerson = providerPlace.AverageCostPerPerson.HasValue ? Math.Round(providerPlace.AverageCostPerPerson.Value, 2) : null; // TODO add currency conversion in future
            placeDetails.AverageTimeSpent = providerPlace.AverageTimeSpent;
            placeDetails.AverageRating = providerPlace.AverageRating;
        }
        else if (place is CustomPlace customPlace && customPlace.SuperCategoryId is not null)
        {
            PlaceCategory superCategory = await _dbContext.PlaceCategories
                .Where(c => c.Id == customPlace.SuperCategoryId)
                .FirstAsync();

            placeDetails.SuperCategory = new PlaceCategoryDTO
            {
                Id = superCategory.Id,
                Name = superCategory.Name,
            };
        }

        return placeDetails;
    }

    public async Task<PlaceDetailsDTO> GetPlaceDetailsAsync(string providerId)
    {
        ProviderPlace fetchedPlace;

        try
        {
            fetchedPlace = await _geoapifyService.GetPlaceDetailsAsync(providerId) ?? throw new ArgumentException(ErrorMessages.IncorrectProviderPlaceId);
        }
        catch (HttpRequestException)
        {
            throw new ArgumentException(ErrorMessages.IncorrectProviderPlaceId);
        }

        ProviderPlace? existingPlace = await GetExistingProviderPlaceAsync(fetchedPlace);

        if (existingPlace is null)
        {
            return new PlaceDetailsDTO()
            {
                ProviderId = fetchedPlace?.ProviderId,
                Name = fetchedPlace?.Name,
                Country = fetchedPlace?.Country,
                State = fetchedPlace?.State,
                City = fetchedPlace?.City,
                Street = fetchedPlace?.Street,
                HouseNumber = fetchedPlace?.HouseNumber,
                Latitude = fetchedPlace?.Latitude,
                Longitude = fetchedPlace?.Longitude,
                Categories = fetchedPlace?.Categories?
                .Select(c => new PlaceCategoryDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList(),
                Conditions = fetchedPlace?.Conditions?
                .Select(c => new PlaceConditionDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList(),
            };
        }
        else
        {
            return await GetPlaceDetailsAsync(existingPlace.Id);
        }
    }

    public async Task<List<PlaceOverviewDTO>> GetPlaceRecommendationsAsync((decimal latitude, decimal longitude) location, double radius, IEnumerable<PlaceCategory> categories, IEnumerable<PlaceCondition>? conditions = null, int? limit = null)
    {
        List<ProviderPlace> places = await _geoapifyService.GetNearbyPlacesAsync(location, radius, categories, conditions, limit) ?? [];

        places = FilterAmmenities(places);

        var existingPlaces = await GetExistingProviderPlacesListAsync(places);

        var recommendations = places.Select(p =>
            {
                var existingPlace = existingPlaces.FirstOrDefault(ep => 
                    ep.ProviderId == p.ProviderId
                    || (ep.Name == p.Name &&
                        ep.Country == p.Country &&
                        ep.State == p.State &&
                        ep.City == p.City &&
                        ep.Street == p.Street &&
                        ep.HouseNumber == p.HouseNumber));
                return existingPlace ?? p;
            })
            .OrderByDescending(p => p.AverageRating)
            .ToList();

        return await PlacesToOverviewDTOsAsync(recommendations);
    }

    private static List<ProviderPlace> FilterAmmenities(List<ProviderPlace> places)
    {
        return places
            .Where(p => p.Name != null)
            .GroupBy(p => p.ProviderId)
            .Select(g => g.OrderBy(p => p.ProviderId).First())
            .GroupBy(p => new { p.Name, p.Country, p.State, p.City, p.Street, p.HouseNumber })
            .Select(g => g.OrderBy(p => p.ProviderId).First())
            .ToList();
    }

    private async Task<ProviderPlace?> GetExistingProviderPlaceAsync(ProviderPlace place)
    {
        return await _dbContext.Places
            .OfType<ProviderPlace>()
            .Where(p =>
                place.ProviderId == p.ProviderId
                 || (place.Name == p.Name &&
                    place.Country == p.Country &&
                    place.State == p.State &&
                    place.City == p.City &&
                    place.Street == p.Street &&
                    place.HouseNumber == p.HouseNumber))
            .Include(p => p.Categories)
            .Include(p => p.Conditions)
            .Include(p => p.Reviews)
            .FirstOrDefaultAsync();
    }

    private async Task<List<ProviderPlace>> GetExistingProviderPlacesListAsync(List<ProviderPlace> places)
    {
        var providerIds = places.Select(p => p.ProviderId).ToList();
        var placeDetails = places.Select(p => new { p.Name, p.Country, p.State, p.City, p.Street, p.HouseNumber }).ToList();

        var existingPlaces = await _dbContext.Places
            .OfType<ProviderPlace>()
            .Include(p => p.Categories)
            .Include(p => p.Conditions)
            .Include(p => p.Reviews)
            .ToListAsync();

        existingPlaces = existingPlaces
            .Where(p => providerIds.Contains(p.ProviderId) ||
                placeDetails.Any(pd => pd.Name == p.Name &&
                               pd.Country == p.Country &&
                               pd.State == p.State &&
                               pd.City == p.City &&
                               pd.Street == p.Street &&
                               pd.HouseNumber == p.HouseNumber))
            .ToList();

        return existingPlaces;
    }
}