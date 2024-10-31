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
}