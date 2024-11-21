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
    private readonly Mock<ITransferPointsService> _mockTransferPointService;
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
        _mockTransferPointService = new Mock<ITransferPointsService>();
        _tripPointsService = new TripPointsService(_dbContext, _mockNBPService.Object, _mockPlacesService.Object, _mockTransferPointService.Object);
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
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
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

        _mockNBPService.Setup(s => s.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>()))
            .ReturnsAsync(2.0m);

        _mockGeoapifyService.Setup(s => s.GetPlaceDetailsAsync(It.IsAny<string>()))
            .ReturnsAsync(place);

        _mockPlacesService.Setup(s => s.AddPlaceAsync(It.IsAny<PlaceRequestDTO>()))
            .ReturnsAsync(new PlaceDetailsDTO { Id = place.Id, Name = place.Name, City = place.City, Country = place.Country });

        _mockPlacesService.Setup(s => s.GetProviderPlaceAsync(It.IsAny<string>()))
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
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
            Place = new PlaceRequestDTO { ProviderId = "1", Name = "Test Place" }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPoint} {ITripPointsService.ErrorMessage.TripDayNotFound}", exception.Message);
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
            StartTime = TimeOnly.Parse("12:00"),
            EndTime = TimeOnly.Parse("10:00"),
            Place = new PlaceRequestDTO { ProviderId = "1", Name = "Test Place" }
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripPointRequest.TripDayId } }
        };

        _mockNBPService.Setup(s => s.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>()))
            .ReturnsAsync(2.0m);

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPoint} {ITripPointsService.ErrorMessage.StartTimeAfterEndTime}", exception.Message);
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
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
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

        _mockNBPService.Setup(s => s.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>()))
            .ReturnsAsync((decimal?)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPoint} {ITripPointsService.ErrorMessage.RetriveExchangeRate}", exception.Message);
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
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
            Place = null
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripPointRequest.TripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        _mockNBPService.Setup(s => s.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>()))
            .ReturnsAsync(2.0m);

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPoint} {ITripPointsService.ErrorMessage.EmptyPlace}", exception.Message);
    }

    [Fact]
    public async Task DeleteTripPointAsync_ReturnsTrue_WhenTripPointIsDeleted()
    {
        // Arrange
        var userId = "user1";
        var tripPointId = Guid.NewGuid();

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        var tripPoint = new TripPoint
        {
            Id = tripPointId,
            TripDayId = trip.TripDays.First().Id,
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
            Place = new CustomPlace { Id = Guid.NewGuid(), Name = "Test Place", City = "Test City", Country = "Test Country" }
        };

        trip.TripDays.First().TripPoints = new List<TripPoint> { tripPoint };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.TripPoints.AddAsync(tripPoint);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _tripPointsService.DeleteTripPointAsync(userId, tripPointId);

        // Assert
        Assert.True(result);
        Assert.Null(await _dbContext.TripPoints.FindAsync(tripPointId));
    }

    [Fact]
    public async Task DeleteTripPointAsync_ThrowsInvalidOperationException_WhenTripPointNotFound()
    {
        // Arrange
        var userId = "user1";
        var tripPointId = Guid.NewGuid();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.DeleteTripPointAsync(userId, tripPointId));
        Assert.Equal($"{ITripPointsService.ErrorMessage.DeleteTripPoint} {ITripPointsService.ErrorMessage.TripPointNotFound}", exception.Message);
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
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00")
        };

        await _dbContext.TripPoints.AddAsync(existingTripPoint);
        await _dbContext.SaveChangesAsync();

        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = tripDayId,
            Name = "New Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.Parse("10:30"),
            EndTime = TimeOnly.Parse("13:00"),
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

        _mockNBPService.Setup(s => s.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly>()))
            .ReturnsAsync(2.0m);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPoint} {ITripPointsService.ErrorMessage.TripPointOverlap}", exception.Message);
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
