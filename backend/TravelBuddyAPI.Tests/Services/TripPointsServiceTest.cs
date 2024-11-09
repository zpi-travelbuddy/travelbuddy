using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.Services;
using Xunit;

namespace TravelBuddyAPI.Tests.Services;

public class TripPointsServiceTest : IDisposable
{
    private readonly TravelBuddyDbContext _dbContext;
    private readonly Mock<INBPService> _mockNBPService;
    private readonly Mock<IPlacesService> _mockPlacesService;
    private readonly Mock<IGeoapifyService> _mockGeoapifyService;
    private readonly TripPointsService _tripPointsService;

    public TripPointsServiceTest()
    {
        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .ConfigureWarnings(warnings => warnings.Ignore(InMemoryEventId.TransactionIgnoredWarning))
            .Options;

        _dbContext = new TravelBuddyDbContext(options);
        _mockNBPService = new Mock<INBPService>();
        _mockGeoapifyService = new Mock<IGeoapifyService>();
        _mockPlacesService = new Mock<IPlacesService>();
        _tripPointsService = new TripPointsService(_dbContext, _mockNBPService.Object, _mockPlacesService.Object);
    }

    [Fact]
    public async Task CreateTripPointAsync_ReturnsTripPointDetailsDTO()
    {
        // Arrange
        var userId = "user1";
        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = Guid.NewGuid(),
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
            Place = new PlaceRequestDTO { Name = "Test Place", ProviderId = "1", City = "Test City", Country = "Test Country" }
        };

        var place = new ProviderPlace
        {
            Id = Guid.NewGuid(),
            Name = tripPointRequest.Place.Name,
            ProviderId = tripPointRequest.Place.ProviderId,
            City = tripPointRequest.Place.City,
            Country = tripPointRequest.Place.Country
        };

        await _dbContext.Places.AddAsync(place);
        await _dbContext.SaveChangesAsync();

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripPointRequest.TripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        _mockNBPService.Setup(s => s.GetClosestRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>(), It.IsAny<int>()))
            .ReturnsAsync(2.0m);

        _mockGeoapifyService.Setup(s => s.GetPlaceDetailsAsync(It.IsAny<string>()))
            .ReturnsAsync(place);


        // Act
        var result = await _tripPointsService.CreateTripPointAsync(userId, tripPointRequest);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(tripPointRequest.Name, result.Name);
        Assert.Equal(tripPointRequest.Comment, result.Comment);
    }

    [Fact]
    public async Task CreateTripPointAsync_ThrowsArgumentException_WhenTripDayNotFound()
    {
        // Arrange
        var userId = "user1";
        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = Guid.NewGuid(),
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
            Place = new PlaceRequestDTO { ProviderId = "1", Name = "Test Place" }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal("An error occurred while creating a trip point. Could not find trip day of given id.", exception.Message);
    }

    [Fact]
    public async Task CreateTripPointAsync_ThrowsArgumentException_WhenStartTimeAfterEndTime()
    {
        // Arrange
        var userId = "user1";
        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = Guid.NewGuid(),
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
            EndTime = TimeOnly.FromDateTime(DateTime.Now),
            Place = new PlaceRequestDTO { ProviderId = "1", Name = "Test Place" }
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripPointRequest.TripDayId } }
        };

        _mockNBPService.Setup(s => s.GetClosestRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>(), It.IsAny<int>()))
            .ReturnsAsync(2.0m);

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal("An error occurred while creating a trip point. Start time cannot be after end time.", exception.Message);
    }

    [Fact]
    public async Task CreateTripPointAsync_ThrowsInvalidOperationException_WhenExchangeRateNotFound()
    {
        // Arrange
        var userId = "user1";
        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = Guid.NewGuid(),
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
            Place = new PlaceRequestDTO { ProviderId = "1", Name = "Test Place" }
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripPointRequest.TripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        _mockNBPService.Setup(s => s.GetClosestRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>(), It.IsAny<int>()))
            .ReturnsAsync((decimal?)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal("An error occurred while creating a trip point. Could not retrive exchange rate.", exception.Message);
    }

    [Fact]
    public async Task CreateTripPointAsync_ThrowsInvalidOperationException_WhenPlaceIsEmpty()
    {
        // Arrange
        var userId = "user1";
        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = Guid.NewGuid(),
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
            Place = null
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripPointRequest.TripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        _mockNBPService.Setup(s => s.GetClosestRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>(), It.IsAny<int>()))
            .ReturnsAsync(2.0m);

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal("An error occurred while creating a trip point. Place cannot be empty.", exception.Message);
    }

    [Fact]
    public async Task CreateTripPointAsync_ThrowsArgumentException_WhenTripPointOverlaps()
    {
        // Arrange
        var userId = "user1";
        var tripDayId = Guid.NewGuid();
        var existingTripPoint = new TripPoint
        {
            Id = Guid.NewGuid(),
            TripDayId = tripDayId,
            Name = "Existing Trip Point",
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1))
        };

        await _dbContext.TripPoints.AddAsync(existingTripPoint);
        await _dbContext.SaveChangesAsync();

        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = tripDayId,
            Name = "New Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.FromDateTime(DateTime.Now.AddMinutes(30)),
            EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
            Place = new PlaceRequestDTO { ProviderId = "1", Name = "Test Place" }
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        _mockNBPService.Setup(s => s.GetClosestRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>(), It.IsAny<int>()))
            .ReturnsAsync(2.0m);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal("An error occurred while creating a trip point. Trip point overlaps with another trip point.", exception.Message);
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
