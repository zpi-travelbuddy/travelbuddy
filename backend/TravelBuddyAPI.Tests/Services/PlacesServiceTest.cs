using Microsoft.EntityFrameworkCore;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.Services;
using Xunit;

namespace TravelBuddyAPI.Tests.Services;

public class PlacesServiceTest
{
    private readonly TravelBuddyDbContext _dbContext;
    private readonly Mock<IGeoapifyService> _mockGeoapifyService;
    private readonly Mock<ITravelBuddyDbCache> _mockDbCache;
    private readonly PlacesService _placesService;

    public PlacesServiceTest()
    {
        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _dbContext = new TravelBuddyDbContext(options);
        _mockGeoapifyService = new Mock<IGeoapifyService>();
        _mockDbCache = new Mock<ITravelBuddyDbCache>();
        _placesService = new PlacesService(_dbContext, _mockGeoapifyService.Object, _mockDbCache.Object);
    }

    [Fact]
    public async Task GetAutocompleteDestinationsAsync_ReturnsPlaceOverviewDTOs()
    {
        // Arrange
        var query = "New York";
        var providerPlaces = new List<ProviderPlace>
        {
            new ProviderPlace { ProviderId = "1", Name = "New York", Country = "USA", City = "New York" }
        };
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.city, null, null, null, "json"))
            .ReturnsAsync(providerPlaces);

        // Act
        var result = await _placesService.GetAutocompleteDestinationsAsync(query);

        // Assert
        Assert.Single(result);
        Assert.Equal("New York", result[0].Name);
        Assert.Equal("USA", result[0].Country);
        Assert.Equal("New York", result[0].City);
    }

    [Fact]
    public async Task GetAutocompleteDestinationsAsync_ReturnsEmptyListOnHttpRequestException()
    {
        // Arrange
        var query = "New York";
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.city, null, null, null, "json"))
            .ThrowsAsync(new HttpRequestException());

        // Act
        var result = await _placesService.GetAutocompleteDestinationsAsync(query);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public async Task GetAutocompletePlacesAsync_ReturnsPlaceOverviewDTOs()
    {
        // Arrange
        var query = "Central Park";
        var latitude = 40.785091m;
        var longitude = -73.968285m;
        var bias = $"proximity:{longitude},{latitude}";
        var providerPlaces = new List<ProviderPlace>
        {
            new ProviderPlace { ProviderId = "1", Name = "Central Park", Country = "USA", City = "New York" }
        };
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.amenity, null, null, bias, "json"))
            .ReturnsAsync(providerPlaces);

        // Act
        var result = await _placesService.GetAutocompletePlacesAsync(query, latitude, longitude);

        // Assert
        Assert.Single(result);
        Assert.Equal("Central Park", result[0].Name);
        Assert.Equal("USA", result[0].Country);
        Assert.Equal("New York", result[0].City);
    }

    [Fact]
    public async Task GetAutocompletePlacesAsync_ReturnsEmptyListOnHttpRequestException()
    {
        // Arrange
        var query = "Central Park";
        var latitude = 40.785091m;
        var longitude = -73.968285m;
        var bias = $"proximity:{longitude},{latitude}";
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.amenity, null, null, bias, "json"))
            .ThrowsAsync(new HttpRequestException());

        // Act
        var result = await _placesService.GetAutocompletePlacesAsync(query, latitude, longitude);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public async Task AddPlaceAsync_ShouldAddProviderPlace()
    {
        // Arrange
        var placeRequest = new PlaceRequestDTO
        {
            ProviderId = Guid.NewGuid().ToString(),
            Name = "Test Place",
            Country = "Test Country",
            City = "Test City",
            Street = "Test Street",
            HouseNumber = "123",
            Latitude = 50.0m,
            Longitude = 20.0m,
        };

        _mockDbCache.Setup(x => x.GetCategoriesAsync()).ReturnsAsync(new List<PlaceCategory>());

        // Act
        var result = await _placesService.AddPlaceAsync(placeRequest);


        // Assert
        var addedPlace = await _dbContext.Places.FirstOrDefaultAsync();
        Assert.NotNull(addedPlace);
        Assert.Equal(placeRequest.Name, addedPlace.Name);
        Assert.Equal(placeRequest.Country, addedPlace.Country);
        Assert.Equal(placeRequest.City, addedPlace.City);
        Assert.Equal(placeRequest.Street, addedPlace.Street);
        Assert.Equal(placeRequest.HouseNumber, addedPlace.HouseNumber);
        Assert.Equal(placeRequest.Latitude, addedPlace.Latitude);
        Assert.Equal(placeRequest.Longitude, addedPlace.Longitude);
    }

    [Fact]
    public async Task AddPlaceAsync_ShouldAddCustomPlace()
    {
        // Arrange
        var placeRequest = new PlaceRequestDTO
        {
            Name = "Test Place",
            Country = "Test Country",
            City = "Test City",
            // Street = "Test Street",
            // HouseNumber = "123",
            Latitude = 50.0m,
            Longitude = 20.0m,
            CategoryId = Guid.NewGuid()
        };

        var categories = new List<PlaceCategory>
    {
        new PlaceCategory { Id = placeRequest.CategoryId.Value, Name = "Test Category" }
    };

        _mockDbCache.Setup(x => x.GetCategoriesAsync()).ReturnsAsync(categories);

        // Act
        var result = await _placesService.AddPlaceAsync(placeRequest);

        // Assert
        var addedPlace = await _dbContext.Places.FirstOrDefaultAsync();
        Assert.NotNull(addedPlace);
        Assert.Equal(placeRequest.Name, addedPlace.Name);
        Assert.Equal(placeRequest.Country, addedPlace.Country);
        Assert.Equal(placeRequest.City, addedPlace.City);
        Assert.Equal(placeRequest.Street, addedPlace.Street);
        Assert.Equal(placeRequest.HouseNumber, addedPlace.HouseNumber);
        Assert.Equal(placeRequest.Latitude, addedPlace.Latitude);
        Assert.Equal(placeRequest.Longitude, addedPlace.Longitude);

        // Check the added category
        Assert.NotNull(result.SuperCategory);
        Assert.Equal(placeRequest.CategoryId, result.SuperCategory.Id);
    }
}