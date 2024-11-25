using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;
using TravelBuddyAPI.Enums;
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

    [Theory]

    [InlineData("12:00", "13:00", "12:30", "13:30")]
    [InlineData("12:30", "13:30", "12:00", "13:00")]

    [InlineData("12:00", "13:00", "11:30", "12:30")]
    [InlineData("11:30", "12:30", "12:00", "13:00")]

    [InlineData("12:00", "13:00", "12:00", "13:00")]

    [InlineData("12:00", "12:00", "12:00", "12:00")]

    [InlineData("12:00", "13:00", "11:30", "13:30")]
    [InlineData("11:30", "13:30", "12:00", "13:00")]

    [InlineData("12:00", "13:00", "12:30", "12:30")]
    [InlineData("12:30", "12:30", "12:00", "13:00")]

    [InlineData("12:00", "13:00", "12:25", "12:35")]
    [InlineData("12:25", "12:35", "12:00", "13:00")]

    [InlineData("12:00", "13:00", "12:00", "12:35")]
    [InlineData("12:00", "12:35", "12:00", "13:00")]

    [InlineData("12:00", "13:00", "11:30", "13:00")]
    [InlineData("11:30", "13:00", "12:00", "13:00")]

    [InlineData("12:00", "13:00", "12:30", "13:00")]
    [InlineData("12:30", "13:00", "12:00", "13:00")]
    public async Task CreateTripPointAsync_ThrowsArgumentException_WhenTripPointOverlaps(string existingStartTime, string existingEndTime, string newStartTime, string newEndTime)
    {
        // Arrange
        var userId = "user1";
        var tripDayId = Guid.NewGuid();
        var existingTripPoint = new TripPoint
        {
            Id = Guid.NewGuid(),
            TripDayId = tripDayId,
            Name = "Existing Trip Point",
            StartTime = TimeOnly.Parse(existingStartTime),
            EndTime = TimeOnly.Parse(existingEndTime)
        };

        await _dbContext.TripPoints.AddAsync(existingTripPoint);
        await _dbContext.SaveChangesAsync();

        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = tripDayId,
            Name = "New Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.Parse(newStartTime),
            EndTime = TimeOnly.Parse(newEndTime),
            Place = new PlaceRequestDTO { ProviderId = "1", Name = "Test Place" }
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
            TripDays = new List<TripDay> { new TripDay { Id = tripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.CreateTripPointAsync(userId, tripPointRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPoint} {ITripPointsService.ErrorMessage.TripPointOverlap}", exception.Message);
    }

    [Theory]

    [InlineData("12:00", "12:00", "12:00", "13:00")]
    [InlineData("12:00", "13:00", "12:00", "12:00")]

    [InlineData("12:00", "12:00", "11:00", "12:00")]
    [InlineData("11:00", "12:00", "12:00", "12:00")]

    [InlineData("12:00", "13:00", "13:00", "14:00")]
    [InlineData("13:00", "14:00", "12:00", "13:00")]
    public async Task CreateTripPointAsync_CreatesTripPoint_WhenTripPointStartsWhenOtherEnds(string existingStartTime, string existingEndTime, string newStartTime, string newEndTime)
    {
        // Arrange
        var userId = "user1";
        var tripDayId = Guid.NewGuid();
        var existingTripPoint = new TripPoint
        {
            Id = Guid.NewGuid(),
            TripDayId = tripDayId,
            Name = "Existing Trip Point",
            StartTime = TimeOnly.Parse(existingStartTime),
            EndTime = TimeOnly.Parse(existingEndTime)
        };

        await _dbContext.TripPoints.AddAsync(existingTripPoint);
        await _dbContext.SaveChangesAsync();

        var tripPointRequest = new TripPointRequestDTO
        {
            TripDayId = tripDayId,
            Name = "New Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.Parse(newStartTime),
            EndTime = TimeOnly.Parse(newEndTime),
            Place = new PlaceRequestDTO { ProviderId = "1", Name = "Test Place" }
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
            TripDays = new List<TripDay> { new TripDay { Id = tripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
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

    public void Dispose()
    {
        _dbContext.Dispose();
    }

    [Fact]
    public async Task ReviewTripPointAsync_ReturnsReviewDetails_WhenReviewIsCreated()
    {
        // Arrange
        var userId = "user1";
        var tripPointId = Guid.NewGuid();
        var tripDayId = Guid.NewGuid();
        var tripPointReviewRequest = new TripPointReviewRequestDTO
        {
            ActualCostPerPerson = 100,
            ActualTimeSpent = TimeSpan.FromHours(2),
            Rating = 5
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "PLN",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        var tripPoint = new TripPoint
        {
            Id = tripPointId,
            TripDayId = tripDayId,
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
            Place = new CustomPlace { Id = Guid.NewGuid(), Name = "Test Place", City = "Test City", Country = "Test Country" },
            Status = TripPointStatus.reviewPending
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.TripPoints.AddAsync(tripPoint);
        await _dbContext.SaveChangesAsync();

        _mockNBPService.Setup(s => s.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>()))
            .ReturnsAsync(2.0m);

        // Act
        var result = await _tripPointsService.ReviewTripPointAsync(userId, tripPointId, tripPointReviewRequest);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(tripPointReviewRequest.Rating, result.Rating);
        Assert.Equal(tripPointReviewRequest.ActualCostPerPerson * 1m, result.ActualCostPerPerson);
    }

    [Fact]
    public async Task ReviewTripPointAsync_ThrowsInvalidOperationException_WhenTripPointNotFound()
    {
        // Arrange
        var userId = "user1";
        var tripPointId = Guid.NewGuid();
        var tripPointReviewRequest = new TripPointReviewRequestDTO
        {
            ActualCostPerPerson = 100,
            ActualTimeSpent = TimeSpan.FromHours(2),
            Rating = 5
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.ReviewTripPointAsync(userId, tripPointId, tripPointReviewRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPointReview} {ITripPointsService.ErrorMessage.TripPointNotFound}", exception.Message);
    }

    [Fact]
    public async Task ReviewTripPointAsync_ThrowsInvalidOperationException_WhenReviewAlreadyExists()
    {
        // Arrange
        var userId = "user1";
        var tripPointId = Guid.NewGuid();
        var tripDayId = Guid.NewGuid();
        var tripPointReviewRequest = new TripPointReviewRequestDTO
        {
            ActualCostPerPerson = 100,
            ActualTimeSpent = TimeSpan.FromHours(2),
            Rating = 5
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        var tripPoint = new TripPoint
        {
            Id = tripPointId,
            TripDayId = tripDayId,
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
            Place = new CustomPlace { Id = Guid.NewGuid(), Name = "Test Place", City = "Test City", Country = "Test Country" },
            Status = TripPointStatus.reviewPending,
            Review = new TripPointReview { Id = Guid.NewGuid(), UserId = userId, TripPointId = tripPointId, Rating = 4 }
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.TripPoints.AddAsync(tripPoint);
        await _dbContext.SaveChangesAsync();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.ReviewTripPointAsync(userId, tripPointId, tripPointReviewRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPointReview} {ITripPointsService.ErrorMessage.TripPointReviewExists}", exception.Message);
    }

    [Fact]
    public async Task ReviewTripPointAsync_ThrowsInvalidOperationException_WhenTripPointStatusIsNotReviewPending()
    {
        // Arrange
        var userId = "user1";
        var tripPointId = Guid.NewGuid();
        var tripDayId = Guid.NewGuid();
        var tripPointReviewRequest = new TripPointReviewRequestDTO
        {
            ActualCostPerPerson = 100,
            ActualTimeSpent = TimeSpan.FromHours(2),
            Rating = 5
        };

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        var tripPoint = new TripPoint
        {
            Id = tripPointId,
            TripDayId = tripDayId,
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
            Place = new CustomPlace { Id = Guid.NewGuid(), Name = "Test Place", City = "Test City", Country = "Test Country" },
            Status = TripPointStatus.planned
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.TripPoints.AddAsync(tripPoint);
        await _dbContext.SaveChangesAsync();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.ReviewTripPointAsync(userId, tripPointId, tripPointReviewRequest));
        Assert.Equal($"{ITripPointsService.ErrorMessage.CreateTripPointReview} {ITripPointsService.ErrorMessage.TripPointWrongStatus} {TripPointStatus.planned}", exception.Message);
    }

    [Fact]
    public async Task GetTripPointReviewDetailsAsync_ReturnsReviewDetails_WhenReviewExists()
    {
        // Arrange
        var userId = "user1";
        var tripPointReviewId = Guid.NewGuid();
        var tripPointId = Guid.NewGuid();
        var tripDayId = Guid.NewGuid();

        var trip = new Trip
        {
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Test Trip",
            TripDays = new List<TripDay> { new TripDay { Id = tripDayId, Date = DateOnly.FromDateTime(DateTime.Now) } }
        };

        var tripPoint = new TripPoint
        {
            Id = tripPointId,
            TripDayId = tripDayId,
            Name = "Test Trip Point",
            Comment = "Test Comment",
            PredictedCost = 100,
            StartTime = TimeOnly.Parse("10:00"),
            EndTime = TimeOnly.Parse("12:00"),
            Place = new CustomPlace { Id = Guid.NewGuid(), Name = "Test Place", City = "Test City", Country = "Test Country" },
            Status = TripPointStatus.reviewPending
        };

        var tripPointReview = new TripPointReview
        {
            Id = tripPointReviewId,
            UserId = userId,
            TripPointId = tripPointId,
            PlaceId = tripPoint.Place.Id,
            CurrencyCode = trip.CurrencyCode,
            ActualCostPerPerson = 100,
            ExchangeRate = 2.0m,
            ActualTimeSpent = TimeSpan.FromHours(2),
            Rating = 5
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.TripPoints.AddAsync(tripPoint);
        await _dbContext.TripPointReviews.AddAsync(tripPointReview);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _tripPointsService.GetTripPointReviewDetailsAsync(userId, tripPointReviewId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(tripPointReviewId, result.Id);
        Assert.Equal(tripPointId, result.TripPointId);
        Assert.Equal(tripPointReview.PlaceId, result.PlaceId);
        Assert.Equal(tripPointReview.CurrencyCode, result.CurrencyCode);
        Assert.Equal(tripPointReview.ActualCostPerPerson / tripPointReview.ExchangeRate, result.ActualCostPerPerson);
        Assert.Equal(tripPointReview.ActualTimeSpent, result.ActualTimeSpent);
        Assert.Equal(tripPointReview.Rating, result.Rating);
    }

    [Fact]
    public async Task GetTripPointReviewDetailsAsync_ThrowsInvalidOperationException_WhenReviewNotFound()
    {
        // Arrange
        var userId = "user1";
        var tripPointReviewId = Guid.NewGuid();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripPointsService.GetTripPointReviewDetailsAsync(userId, tripPointReviewId));
        Assert.Equal($"{ITripPointsService.ErrorMessage.TripPointReviewNotFound}", exception.Message);
    }
    [Fact]
    public async Task GetTripPointsReviewsAsync_ReturnsListOfTripPointReviewOverviewDTO_WhenReviewsExist()
    {
        // Arrange
        var userId = "user1";
        var tripPointReviewId1 = Guid.NewGuid();
        var tripPointReviewId2 = Guid.NewGuid();
        var tripPointId1 = Guid.NewGuid();
        var tripPointId2 = Guid.NewGuid();
        var placeId1 = Guid.NewGuid();
        var placeId2 = Guid.NewGuid();

        var tripPointReview1 = new TripPointReview
        {
            Id = tripPointReviewId1,
            UserId = userId,
            TripPointId = tripPointId1,
            PlaceId = placeId1,
            Rating = 4
        };

        var tripPointReview2 = new TripPointReview
        {
            Id = tripPointReviewId2,
            UserId = userId,
            TripPointId = tripPointId2,
            PlaceId = placeId2,
            Rating = 5
        };

        var place1 = new CustomPlace
        {
            Id = placeId1,
            Name = "Place 1",
            City = "City 1",
            Country = "Country 1"
        };

        var place2 = new CustomPlace
        {
            Id = placeId2,
            Name = "Place 2",
            City = "City 2",
            Country = "Country 2"
        };

        await _dbContext.TripPointReviews.AddRangeAsync(tripPointReview1, tripPointReview2);
        await _dbContext.Places.AddRangeAsync(place1, place2);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _tripPointsService.GetTripPointsReviewsAsync(userId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);
        Assert.Contains(result, r => r.Id == tripPointReviewId1 && r.PlaceName == "Place 1" && r.Rating == 4);
        Assert.Contains(result, r => r.Id == tripPointReviewId2 && r.PlaceName == "Place 2" && r.Rating == 5);
    }

    [Fact]
    public async Task GetTripPointsReviewsAsync_ReturnsEmptyList_WhenNoReviewsExist()
    {
        // Arrange
        var userId = "user1";

        // Act
        var result = await _tripPointsService.GetTripPointsReviewsAsync(userId);

        // Assert
        Assert.NotNull(result);
        Assert.Empty(result);
    }
}