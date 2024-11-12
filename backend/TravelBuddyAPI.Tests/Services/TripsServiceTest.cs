using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.Trip;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.Services;

namespace TravelBuddyAPI.Tests.Services;

public class TripsServiceTest
{
    private readonly Mock<INBPService> _mockNBPService;
    private readonly TravelBuddyDbContext _dbContext;
    private readonly Mock<IPlacesService> _mockPlacesService;
    private readonly Mock<ICategoryProfilesService> _mockCategoryProfilesService;
    private readonly Mock<IConditionProfilesService> _mockConditionProfilesService;
    private readonly Mock<ITripPointsService> _mockTripPointsService;
    private readonly TripsService _tripsService;

    public TripsServiceTest()
    {
        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .ConfigureWarnings(warnings => warnings.Ignore(InMemoryEventId.TransactionIgnoredWarning))
            .Options;

        _dbContext = new TravelBuddyDbContext(options);
        _mockNBPService = new Mock<INBPService>();
        _mockPlacesService = new Mock<IPlacesService>();
        _mockCategoryProfilesService = new Mock<ICategoryProfilesService>();
        _mockConditionProfilesService = new Mock<IConditionProfilesService>();
        _mockTripPointsService = new Mock<ITripPointsService>();
        _tripsService = new TripsService(_dbContext, _mockNBPService.Object, _mockPlacesService.Object, _mockCategoryProfilesService.Object, _mockConditionProfilesService.Object, _mockTripPointsService.Object);
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

        _mockNBPService.Setup(x => x.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>())).ReturnsAsync(4.5m);
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

        _mockNBPService.Setup(x => x.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>())).ReturnsAsync((decimal?)null);

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

    [Fact]
    public async Task DeleteTripAsync_ReturnsTrue_WhenTripPointIsDeleted()
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        var trip = new Trip
        {
            Id = tripId,
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay>
            {
            new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now) },
            new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)) }
            }
        };

        _mockTripPointsService.Setup(x => x.DeleteTripPointDuringTransactionAsync(It.IsAny<string>(), It.IsAny<Guid>())).ReturnsAsync(true);


        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _tripsService.DeleteTripAsync(userId, tripId);

        // Assert
        Assert.True(result);
        Assert.Null(await _dbContext.TripPoints.FindAsync(tripId));
    }

    [Fact]
    public async Task DeleteTripAsync_ThrowsInvalidOperationException_WhenTripPointNotFound()
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.DeleteTripAsync(userId, tripId));
        Assert.Equal($"{TripsService.ErrorMessage.DeleteTrip} {TripsService.ErrorMessage.TripNotFound}", exception.Message);
    }
}