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
    public async Task CreateTripAsync()
    {
        var destination = new PlaceRequestDTO()
        {
            ProviderId = Guid.NewGuid().ToString(),
            Name = "Test Place",
            Country = "Test Country",
            City = "Test City",
            // Street = "Test Street",
            // HouseNumber = "123",
            Latitude = 50.0m,
            Longitude = 20.0m,
        };

        _mockNBPService.Setup(x => x.GetClosestRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>(), It.IsAny<int>())).ReturnsAsync(4.5m);
        _mockPlacesService.Setup(x => x.AddPlaceAsync(It.IsAny<PlaceRequestDTO>())).ReturnsAsync(new PlaceDetailsDTO(){Id = Guid.NewGuid()});

        var tripRequest = new TripRequestDTO
        {
            Name = "Test Trip",
            DestinationPlace = destination,
            CurrencyCode = "USD",
            StartDate = DateOnly.Parse("2024-10-30"),
            EndDate = DateOnly.Parse("2024-11-04"),
            NumberOfTravelers = 2,
        };

        string userId = Guid.NewGuid().ToString();

        await _tripsService.CreateTripAsync(userId, tripRequest);
    }
}