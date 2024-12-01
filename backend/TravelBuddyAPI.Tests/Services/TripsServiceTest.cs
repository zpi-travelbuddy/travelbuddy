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
        var destinationProviderId = Guid.NewGuid().ToString();

        _mockNBPService.Setup(x => x.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>())).ReturnsAsync(4.5m);
        _mockPlacesService.Setup(x => x.AddPlaceAsync(It.IsAny<PlaceRequestDTO>())).ReturnsAsync(new PlaceDetailsDTO() { Id = Guid.NewGuid(), ProviderId = destinationProviderId });
        _mockPlacesService.Setup(x => x.GetProviderPlaceAsync(It.IsAny<string>())).ReturnsAsync(new ProviderPlace() { ProviderId = destinationProviderId });

        var tripRequest = new TripRequestDTO
        {
            Name = "Test Trip",
            DestinationProviderId = destinationProviderId,
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

        Assert.Equal($"{ITripsService.ErrorMessage.CreateTrip} {ITripsService.ErrorMessage.StartDateAfterEndDate}", exception.Message);
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

        Assert.Equal($"{ITripsService.ErrorMessage.CreateTrip} {ITripsService.ErrorMessage.StartDateInPast}", exception.Message);
    }

    [Fact]
    public async Task CreateTripAsync_InvalidCurrencyCode_ShouldThrowInvalidOperationException()
    {
        var destinationProviderId = Guid.NewGuid().ToString();

        _mockNBPService.Setup(x => x.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>())).ReturnsAsync((decimal?)null);

        var tripRequest = new TripRequestDTO
        {
            Name = "Test Trip",
            DestinationProviderId = destinationProviderId,
            CurrencyCode = "INVALID",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 2,
        };

        string userId = Guid.NewGuid().ToString();

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.CreateTripAsync(userId, tripRequest));

        Assert.Equal($"{ITripsService.ErrorMessage.CreateTrip} {ITripsService.ErrorMessage.RetriveExchangeRate}", exception.Message);
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
        Assert.Equal($"{ITripsService.ErrorMessage.DeleteTrip} {ITripsService.ErrorMessage.TripNotFound}", exception.Message);
    }

    [Fact]
    public async Task EditTripAsync_ValidRequest_ShouldEditTrip()
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        var trip = new Trip
        {
            Id = tripId,
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Original Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)),
            NumberOfTravelers = 2,
            ExchangeRate = 4.5m,
            Budget = 1000m,
            TripDays = new List<TripDay>
            {
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now) },
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)) }
            }
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        var tripRequest = new TripRequestDTO
        {
            Name = "Edited Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 3,
            CurrencyCode = "USD",
            Budget = 2000m,
            DestinationProviderId = Guid.NewGuid().ToString(),
        };

        _mockNBPService.Setup(x => x.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>())).ReturnsAsync(4.5m);
        _mockPlacesService.Setup(x => x.AddPlaceAsync(It.IsAny<PlaceRequestDTO>())).ReturnsAsync(new PlaceDetailsDTO() { Id = Guid.NewGuid(), ProviderId = tripRequest.DestinationProviderId });
        _mockPlacesService.Setup(x => x.GetProviderPlaceAsync(It.IsAny<string>())).ReturnsAsync(new ProviderPlace() { ProviderId = tripRequest.DestinationProviderId });

        // Act
        var result = await _tripsService.EditTripAsync(userId, tripId, tripRequest);

        // Assert
        Assert.True(result);
        var editedTrip = await _dbContext.Trips.FindAsync(tripId);
        Assert.NotNull(editedTrip);
        Assert.Equal(tripRequest.Name, editedTrip.Name);
        Assert.Equal(tripRequest.NumberOfTravelers, editedTrip.NumberOfTravelers);
        Assert.Equal(tripRequest.Budget * editedTrip.ExchangeRate, editedTrip.Budget);
        Assert.Equal(tripRequest.StartDate, editedTrip.StartDate);
        Assert.Equal(tripRequest.EndDate, editedTrip.EndDate);
        Assert.NotNull(editedTrip.TripDays);
        Assert.Equal(8, editedTrip.TripDays.Count);
    }

    [Theory]
    [InlineData(0, 1, 0, 10)]
    [InlineData(10, 20, -5, -1)]
    [InlineData(0, 1, 10, 12)]
    [InlineData(10, 12, -5, 0)]
    [InlineData(-2, 5, 1, 0)]
    [InlineData(-2, 5, 0, 10)]
    public async Task EditTripAsync_TripDatesChanged_ShouldManageTripDays(int startOffset, int endOffset, int newStartOffset, int newEndOffset)
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        var trip = new Trip
        {
            Id = tripId,
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Original Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(startOffset)),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(endOffset)),
            NumberOfTravelers = 2,
            ExchangeRate = 4.5m,
            Budget = 1000m,
            TripDays = []
        };

        for (var date = trip.StartDate; date <= trip.EndDate; date = date.AddDays(1))
        {
            trip.TripDays.Add(new TripDay { Id = Guid.NewGuid(), Date = date });
        }

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        var tripRequest = new TripRequestDTO
        {
            Name = "Edited Trip",
            StartDate = trip.StartDate.AddDays(newStartOffset),
            EndDate = trip.EndDate.AddDays(newEndOffset),
            NumberOfTravelers = 3,
            CurrencyCode = "USD",
            Budget = 2000m,
            DestinationProviderId = Guid.NewGuid().ToString(),
        };

        _mockNBPService.Setup(x => x.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>())).ReturnsAsync(4.5m);
        _mockPlacesService.Setup(x => x.AddPlaceAsync(It.IsAny<PlaceRequestDTO>())).ReturnsAsync(new PlaceDetailsDTO() { Id = Guid.NewGuid(), ProviderId = tripRequest.DestinationProviderId });
        _mockPlacesService.Setup(x => x.GetProviderPlaceAsync(It.IsAny<string>())).ReturnsAsync(new ProviderPlace() { ProviderId = tripRequest.DestinationProviderId });

        // Act
        var result = await _tripsService.EditTripAsync(userId, tripId, tripRequest);

        // Assert
        Assert.True(result);
        var editedTrip = await _dbContext.Trips.FindAsync(tripId);
        Assert.NotNull(editedTrip);
        Assert.Equal(tripRequest.Name, editedTrip.Name);
        Assert.Equal(tripRequest.NumberOfTravelers, editedTrip.NumberOfTravelers);
        Assert.Equal(tripRequest.Budget * editedTrip.ExchangeRate, editedTrip.Budget);
        Assert.Equal(tripRequest.StartDate, editedTrip.StartDate);
        Assert.Equal(tripRequest.EndDate, editedTrip.EndDate);
        Assert.NotNull(editedTrip.TripDays);
        Assert.Equal(editedTrip.EndDate.DayNumber - editedTrip.StartDate.DayNumber + 1, editedTrip.TripDays.Count);
    }

    [Fact]
    public async Task EditTripAsync_TripNotFound_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        var tripRequest = new TripRequestDTO
        {
            Name = "Edited Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 3,
            CurrencyCode = "USD",
            Budget = 2000m,
            DestinationProviderId = Guid.NewGuid().ToString(),
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.EditTripAsync(userId, tripId, tripRequest));
        Assert.Equal($"{ITripsService.ErrorMessage.EditTrip} {ITripsService.ErrorMessage.TripNotFound}", exception.Message);
    }

    [Fact]
    public async Task EditTripAsync_CurrencyChange_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        var trip = new Trip
        {
            Id = tripId,
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Original Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)),
            NumberOfTravelers = 2,
            ExchangeRate = 4.5m,
            Budget = 1000m,
            TripDays = new List<TripDay>
            {
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now) },
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)) }
            }
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        var tripRequest = new TripRequestDTO
        {
            Name = "Edited Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 3,
            CurrencyCode = "PLN",
            Budget = 2000m,
            DestinationProviderId = Guid.NewGuid().ToString(),
        };

        _mockNBPService.Setup(x => x.GetRateAsync(It.IsAny<string>(), It.IsAny<DateOnly?>())).ReturnsAsync((decimal?)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.EditTripAsync(userId, tripId, tripRequest));
        Assert.Equal($"{ITripsService.ErrorMessage.EditTrip} {ITripsService.ErrorMessage.CurrencyChangeNotAllowed}", exception.Message);
    }

    [Fact]
    public async Task EditTripAsync_StartDateAfterEndDate_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        var trip = new Trip
        {
            Id = tripId,
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Original Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 2,
            ExchangeRate = 4.5m,
            Budget = 1000m,
            TripDays = new List<TripDay>
            {
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now) },
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)) }
            }
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        var tripRequest = new TripRequestDTO
        {
            Name = "Edited Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            EndDate = DateOnly.FromDateTime(DateTime.Now),
            NumberOfTravelers = 3,
            CurrencyCode = "USD",
            Budget = 2000m,
            DestinationProviderId = Guid.NewGuid().ToString(),
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.EditTripAsync(userId, tripId, tripRequest));
        Assert.Equal($"{ITripsService.ErrorMessage.EditTrip} {ITripsService.ErrorMessage.StartDateAfterEndDate}", exception.Message);
    }

    [Fact]
    public async Task EditTripAsync_StartDateInPast_ShouldThrowInvalidOperationException()
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        var trip = new Trip
        {
            Id = tripId,
            UserId = userId,
            CurrencyCode = "USD",
            Name = "Original Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)),
            NumberOfTravelers = 2,
            ExchangeRate = 4.5m,
            Budget = 1000m,
            TripDays = new List<TripDay>
            {
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now) },
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)) }
            }
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        var tripRequest = new TripRequestDTO
        {
            Name = "Edited Trip",
            StartDate = DateOnly.FromDateTime(DateTime.Now - TimeSpan.FromDays(1)),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(7)),
            NumberOfTravelers = 3,
            CurrencyCode = "USD",
            Budget = 2000m,
            DestinationProviderId = Guid.NewGuid().ToString(),
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _tripsService.EditTripAsync(userId, tripId, tripRequest));
        Assert.Equal($"{ITripsService.ErrorMessage.EditTrip} {ITripsService.ErrorMessage.AddTripDaysInPast}", exception.Message);
    }

    [Fact]
    public async Task GetTripDetailsAsync_ValidTripId_ShouldReturnTripDetails()
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
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)),
            NumberOfTravelers = 2,
            ExchangeRate = 4.5m,
            Budget = 1000m,
            TripDays = new List<TripDay>
            {
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now) },
                new TripDay { Id = Guid.NewGuid(), Date = DateOnly.FromDateTime(DateTime.Now + TimeSpan.FromDays(1)) }
            },
        };

        await _dbContext.Trips.AddAsync(trip);
        await _dbContext.SaveChangesAsync();

        foreach (var tripDay in trip.TripDays)
        {
            var tripPoint1 = new TripPoint
            {
                Id = Guid.NewGuid(),
                TripDayId = tripDay.Id,
                Name = "Point 1",
                PredictedCost = 100.0m * trip.ExchangeRate,
                ExchangeRate = trip.ExchangeRate,
            };

            var tripPoint2 = new TripPoint
            {
                Id = Guid.NewGuid(),
                TripDayId = tripDay.Id,
                Name = "Point 2",
                PredictedCost = 25.0m * trip.ExchangeRate,
                ExchangeRate = trip.ExchangeRate,
            };

            await _dbContext.TripPoints.AddRangeAsync(tripPoint1, tripPoint2);
        }

        await _dbContext.SaveChangesAsync();

        foreach (var tripDay in trip.TripDays)
        {
            var tripPoints = await _dbContext.TripPoints.Where(tp => tp.TripDayId == tripDay.Id).ToListAsync();
            foreach (var tripPoint in tripPoints)
            {
                var review = new TripPointReview
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    TripPointId = tripPoint.Id,
                    Rating = 5,
                    ActualCostPerPerson = 50.0m * trip.ExchangeRate,
                    ExchangeRate = trip.ExchangeRate,
                };

                await _dbContext.TripPointReviews.AddAsync(review);
            }
        }
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _tripsService.GetTripDetailsAsync(userId, tripId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(trip.Name, result.Name);
        Assert.Equal(trip.NumberOfTravelers, result.NumberOfTravelers);
        Assert.Equal(trip.StartDate, result.StartDate);
        Assert.Equal(trip.EndDate, result.EndDate);
        Assert.Equal(trip.DestinationId, result.DestinationId);
        Assert.Equal(Math.Round(trip.Budget / trip.ExchangeRate, 2), result.Budget);
        Assert.Equal(trip.CurrencyCode, result.CurrencyCode);
        Assert.Equal(trip.CategoryProfileId, result.CategoryProfileId);
        Assert.Equal(trip.ConditionProfileId, result.ConditionProfileId);
        Assert.Equal(250, result.PredictedCost);
        Assert.Equal(2 * 2 * 50 * trip.NumberOfTravelers, result.ActualCost);
        Assert.NotNull(result.TripDays);
        Assert.Equal(trip.TripDays.Count, result.TripDays.Count);
    }

    [Fact]
    public async Task GetTripDetailsAsync_InvalidTripId_ShouldThrowArgumentException()
    {
        // Arrange
        var userId = "user1";
        var tripId = Guid.NewGuid();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<ArgumentException>(() => _tripsService.GetTripDetailsAsync(userId, tripId));
        Assert.Equal($"{ITripsService.ErrorMessage.TripNotFound}", exception.Message);
    }
}