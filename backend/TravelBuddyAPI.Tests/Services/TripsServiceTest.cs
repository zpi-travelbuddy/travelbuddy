using Microsoft.EntityFrameworkCore;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.Trip;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Services;

namespace TravelBuddyAPI.Tests.Services;

public class TripsServiceTest
{
    private readonly Mock<INBPService> _mockNBPService;
    private readonly TravelBuddyDbContext _dbContext;
    private readonly Mock<IPlacesService> _mockPlacesService;
    private readonly Mock<ICategoryProfilesService> _mockCategoryProfilesService;
    private readonly Mock<IConditionProfilesService> _mockConditionProfilesService;
    private readonly TripsService _tripsService;

    public TripsServiceTest()
    {
        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _dbContext = new TravelBuddyDbContext(options);
        _mockNBPService = new Mock<INBPService>();
        _mockPlacesService = new Mock<IPlacesService>();
        _mockCategoryProfilesService = new Mock<ICategoryProfilesService>();
        _mockConditionProfilesService = new Mock<IConditionProfilesService>();
        _tripsService = new TripsService(_dbContext, _mockNBPService.Object, _mockPlacesService.Object, _mockCategoryProfilesService.Object, _mockConditionProfilesService.Object);

    }

    [Fact]
    public async Task CreateTripAsync_ValidRequest_ShouldCreateTrip()
    {
        var destination = new PlaceRequestDTO()
        {
            ProviderId = Guid.NewGuid().ToString(),
            Name = "Test Place",
            Country = "Test Country",
            City = "Test City",
            Latitude = 50.0m,
            Longitude = 20.0m,
        };

        _mockNBPService.Setup(x => x.GetClosestRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>(), It.IsAny<int>())).ReturnsAsync(4.5m);
        _mockPlacesService.Setup(x => x.AddPlaceAsync(It.IsAny<PlaceRequestDTO>())).ReturnsAsync(new PlaceDetailsDTO() { Id = Guid.NewGuid() });

        var tripRequest = new TripRequestDTO
        {
            Name = "Test Trip",
            DestinationPlace = destination,
            CurrencyCode = "USD",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 2,
        };

        string userId = Guid.NewGuid().ToString();

        var result = await _tripsService.CreateTripAsync(userId, tripRequest);

        Assert.NotNull(result);
        Assert.Equal(tripRequest.Name, result.Name);
    }

    [Fact]
    public async Task CreateTripAsync_EmptyRequest_ShouldThrowArgumentNullException()
    {
        string userId = Guid.NewGuid().ToString();
        TripRequestDTO tripRequest = null!;

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.CreateTripAsync(userId, tripRequest));
    }

    [Fact]
    public async Task CreateTripAsync_StartDateAfterEndDate_ShouldThrowArgumentException()
    {
        var tripRequest = new TripRequestDTO
        {
            Name = "Test Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            EndDate = DateOnly.FromDateTime(DateTime.Now),
            NumberOfTravelers = 2,
        };

        string userId = Guid.NewGuid().ToString();

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.CreateTripAsync(userId, tripRequest));

        Assert.Equal($"{TripsService.ErrorMessage.CreateTrip} {TripsService.ErrorMessage.StartDateAfterEndDate}", exception.Message);
    }

    [Fact]
    public async Task CreateTripAsync_StartDateInPast_ShouldThrowArgumentException()
    {
        var tripRequest = new TripRequestDTO
        {
            Name = "Test Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now - TimeSpan.FromDays(1)),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 2,
        };

        string userId = Guid.NewGuid().ToString();

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.CreateTripAsync(userId, tripRequest));

        Assert.Equal($"{TripsService.ErrorMessage.CreateTrip} {TripsService.ErrorMessage.StartDateInPast}", exception.Message);
    }

    [Fact]
    public async Task CreateTripAsync_InvalidCurrencyCode_ShouldThrowInvalidOperationException()
    {
        var destination = new PlaceRequestDTO()
        {
            ProviderId = Guid.NewGuid().ToString(),
            Name = "Test Place",
            Country = "Test Country",
            City = "Test City",
            Latitude = 50.0m,
            Longitude = 20.0m,
        };

        _mockNBPService.Setup(x => x.GetClosestRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>(), It.IsAny<int>())).ReturnsAsync((decimal?)null);

        var tripRequest = new TripRequestDTO
        {
            Name = "Test Trip",
            DestinationPlace = destination,
            CurrencyCode = "INVALID",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 2,
        };

        string userId = Guid.NewGuid().ToString();

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.CreateTripAsync(userId, tripRequest));

        Assert.Equal($"{TripsService.ErrorMessage.CreateTrip} {TripsService.ErrorMessage.RetriveExchangeRate}", exception.Message);
    }
}