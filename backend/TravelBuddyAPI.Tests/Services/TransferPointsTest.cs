using Microsoft.EntityFrameworkCore;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.TransferPoint;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Services;
using TravelBuddyAPI.Models;
using Xunit;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Tests.Services;

public class TransferPointsServiceTest
{
    private readonly TravelBuddyDbContext _dbContext;
    private readonly Mock<IGeoapifyService> _mockGeoapifyService;
    private readonly TransferPointsService _transferPointsService;

    public TransferPointsServiceTest()
    {
        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _dbContext = new TravelBuddyDbContext(options);
        _mockGeoapifyService = new Mock<IGeoapifyService>();
        _transferPointsService = new TransferPointsService(_dbContext, _mockGeoapifyService.Object);
    }

    [Fact]
    public async Task CreateTransferPointAsync_ValidRequestWithTime_ShouldCreateTransferPoint()
    {
       var fromTripPointPlace = new ProviderPlace 
        { 
            Id = Guid.NewGuid(), 
            Name = "From Point", 
            City = "CityA", 
            Country = "CountryA", 
            ProviderId = "ProviderA", 
            Latitude = (decimal)40.7128, 
            Longitude = (decimal)-74.0060,
        };
        var toTripPointPlace = new ProviderPlace 
        { 
            Id = Guid.NewGuid(), 
            Name = "To Point", 
            City = "CityB", 
            Country = "CountryB", 
            ProviderId = "ProviderB", 
            Latitude = (decimal)40.7128, 
            Longitude = (decimal)-74.0060 
        };
        var fromTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "From Point", Place = fromTripPointPlace, EndTime = new TimeOnly(12,0,0) };
        var toTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "To Point", Place = toTripPointPlace, StartTime = new TimeOnly(13,0,0) };
        var tripDay = new TripDay 
        { 
            Id = Guid.NewGuid(), 
            Trip = new Trip { UserId = "testUser", Name = "Test Trip", CurrencyCode = "USD" },
            TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint }
        };

        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();

        var transferPointDTO = new TransferPointRequestDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = fromTripPoint.Id,
            ToTripPointId = toTripPoint.Id,
            Seconds = 3600,
        };

        var result = await _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO);

        Assert.NotNull(result);
        Assert.Equal(transferPointDTO.TripDayId, result.TripDayId);
        Assert.Equal(transferPointDTO.FromTripPointId, result.FromTripPointId);
        Assert.Equal(transferPointDTO.ToTripPointId, result.ToTripPointId);
    }

    [Fact]
    public async Task CreateTransferPointAsync_ValidRequestWithMode_ShouldCreateTransferPoint()
    {
        var fromTripPointPlace = new ProviderPlace 
        { 
            Id = Guid.NewGuid(), 
            Name = "From Point", 
            City = "CityA", 
            Country = "CountryA", 
            ProviderId = "ProviderA", 
            Latitude = (decimal)40.7128, 
            Longitude = (decimal)-74.0060 
        };
        var toTripPointPlace = new ProviderPlace 
        { 
            Id = Guid.NewGuid(), 
            Name = "To Point", 
            City = "CityB", 
            Country = "CountryB", 
            ProviderId = "ProviderB", 
            Latitude = (decimal)40.7128, 
            Longitude = (decimal)-74.0060 
        };
        var fromTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "From Point", Place = fromTripPointPlace, EndTime = new TimeOnly(12,0,0) };
        var toTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "To Point", Place = toTripPointPlace, StartTime = new TimeOnly(13,0,0) };
        var tripDay = new TripDay 
        { 
            Id = Guid.NewGuid(), 
            Trip = new Trip { UserId = "testUser", Name = "Test Trip", CurrencyCode = "USD" },
            TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint }
        };

        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();

        var transferPointDTO = new TransferPointRequestDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = fromTripPoint.Id,
            ToTripPointId = toTripPoint.Id,
            Mode = TransferMode.approximated_transit,
        };

        _mockGeoapifyService.Setup(service => service.GetRouteTimeAsync(
                It.IsAny<(decimal, decimal)>(), 
                It.IsAny<(decimal, decimal)>(), 
                It.IsAny<TransferMode>(),
                It.IsAny<TrafficType>(),
                It.IsAny<Units>()))
            .ReturnsAsync(TimeSpan.FromSeconds(7200));

        var result = await _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO);

        Assert.NotNull(result);
        Assert.Equal(transferPointDTO.TripDayId, result.TripDayId);
        Assert.Equal(transferPointDTO.FromTripPointId, result.FromTripPointId);
        Assert.Equal(transferPointDTO.ToTripPointId, result.ToTripPointId);
    }


    [Fact]
    public async Task CreateTransferPointAsync_EmptyRequest_ShouldThrowArgumentNullException()
    {
        string userId = "testUser";
        TransferPointRequestDTO transferPoint = null!;

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync(userId, transferPoint));

        Assert.Equal($"{ITransferPointsService.ErrorMessage.CreateTransferPoint} {ITransferPointsService.ErrorMessage.EmptyRequest} (Parameter 'transferPoint')", exception.Message);
    }
    [Fact]
    public async Task CreateTransferPointAsync_SameTripPoints_ShouldThrowInvalidOperationException()
    {
        var tripDay = new TripDay 
        { 
            Id = Guid.NewGuid(), 
            Trip = new Trip 
            { 
                UserId = "testUser", 
                Name = "Test Trip", 
                CurrencyCode = "USD" 
            } 
        };
        var tripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "Trip Point" };

        tripDay.TripPoints = new List<TripPoint> { tripPoint };
        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();

        var transferPointDTO = new TransferPointRequestDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = tripPoint.Id,
            ToTripPointId = tripPoint.Id,
            Seconds = 3600,
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO));

        Assert.Equal($"{ITransferPointsService.ErrorMessage.CreateTransferPoint} {ITransferPointsService.ErrorMessage.SameTripPoints}", exception.Message);
    }

    [Fact]
    public async Task CreateTransferPointAsync_TripDayNotFound_ShouldThrowInvalidOperationException()
    {
        var transferPointDTO = new TransferPointRequestDTO
        {
            TripDayId = Guid.NewGuid(),
            FromTripPointId = Guid.NewGuid(),
            ToTripPointId = Guid.NewGuid(),
            Seconds = 3600,
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO));

        Assert.Equal($"{ITransferPointsService.ErrorMessage.CreateTransferPoint} {ITransferPointsService.ErrorMessage.TripDayNotFound}", exception.Message);
    }

    [Fact]
    public async Task CreateTransferPointAsync_TripPointNotFoundInTripDay_ShouldThrowInvalidOperationException()
    {
        var tripDay = new TripDay 
        { 
            Id = Guid.NewGuid(), 
            Trip = new Trip 
            { 
                UserId = "testUser", 
                Name = "Test Trip", 
                CurrencyCode = "USD" 
            } 
        };

        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();

        var transferPointDTO = new TransferPointRequestDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = Guid.NewGuid(),
            ToTripPointId = Guid.NewGuid(),
            Seconds = 3600,
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO));

        Assert.Equal($"{ITransferPointsService.ErrorMessage.CreateTransferPoint} {ITransferPointsService.ErrorMessage.TripPointNotFoundInTripDay}", exception.Message);
    }


    [Fact]
    public async Task EditTransferPointAsync_ValidRequestWithTime_ShouldEditTransferPoint()
    {
        var fromTripPointPlace = new ProviderPlace { Id = Guid.NewGuid(), Name = "From Point", City = "CityA", Country = "CountryA", ProviderId = "ProviderA" };
        var toTripPointPlace = new ProviderPlace { Id = Guid.NewGuid(), Name = "To Point", City = "CityB", Country = "CountryB", ProviderId = "ProviderB" };
        var fromTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "From Point", Place = fromTripPointPlace };
        var toTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "To Point", Place = toTripPointPlace };
        var tripDay = new TripDay
        {
            Id = Guid.NewGuid(),
            Trip = new Trip { UserId = "testUser", Name = "Test Trip", CurrencyCode = "USD" },
            TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint }
        };
        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();

        var transferPoint = new TransferPoint
        {
            Id = Guid.NewGuid(),
            TripDayId = tripDay.Id,
            FromTripPointId = fromTripPoint.Id,
            ToTripPointId = toTripPoint.Id,
            TransferTime = TimeSpan.FromSeconds(3600)
        };

        await _dbContext.TransferPoints.AddAsync(transferPoint);
        await _dbContext.SaveChangesAsync();

        var transferPointDTO = new TransferPointRequestDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = fromTripPoint.Id,
            ToTripPointId = toTripPoint.Id,
            Seconds = 7200
        };

        var result = await _transferPointsService.EditTransferPointAsync("testUser", transferPoint.Id, transferPointDTO);

        Assert.True(result);
        var updatedTransferPoint = await _dbContext.TransferPoints.FindAsync(transferPoint.Id);
        Assert.NotNull(updatedTransferPoint);
        Assert.Equal(transferPointDTO.Seconds, (int)updatedTransferPoint.TransferTime.TotalSeconds);
    }

        [Fact]
        public async Task EditTransferPointAsync_ValidRequestWithMode_ShouldEditTransferPoint()
        {
            var fromTripPointPlace = new ProviderPlace 
            { 
                Id = Guid.NewGuid(), 
                Name = "From Point", 
                City = "CityA", 
                Country = "CountryA", 
                ProviderId = "ProviderA", 
                Latitude = (decimal)40.7128, 
                Longitude = (decimal)-74.0060 
            };
            var toTripPointPlace = new ProviderPlace 
            { 
                Id = Guid.NewGuid(), 
                Name = "To Point", 
                City = "CityB", 
                Country = "CountryB", 
                ProviderId = "ProviderB", 
                Latitude = (decimal)40.7128, 
                Longitude = (decimal)-74.0060 
            };
            var fromTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "From Point", Place = fromTripPointPlace };
            var toTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "To Point", Place = toTripPointPlace };
            var tripDay = new TripDay
            {
                Id = Guid.NewGuid(),
                Trip = new Trip { UserId = "testUser", Name = "Test Trip", CurrencyCode = "USD" },
                TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint }
            };
            await _dbContext.TripDays.AddAsync(tripDay);
            await _dbContext.SaveChangesAsync();

            var transferPoint = new TransferPoint
            {
                Id = Guid.NewGuid(),
                TripDayId = tripDay.Id,
                FromTripPointId = fromTripPoint.Id,
                ToTripPointId = toTripPoint.Id,
                TransferTime = TimeSpan.FromSeconds(3600)
            };

            await _dbContext.TransferPoints.AddAsync(transferPoint);
            await _dbContext.SaveChangesAsync();

            var transferPointDTO = new TransferPointRequestDTO
            {
                TripDayId = tripDay.Id,
                FromTripPointId = fromTripPoint.Id,
                ToTripPointId = toTripPoint.Id,
                Mode = TransferMode.approximated_transit
            };

            _mockGeoapifyService.Setup(service => service.GetRouteTimeAsync(
                    It.IsAny<(decimal, decimal)>(), 
                    It.IsAny<(decimal, decimal)>(), 
                    It.IsAny<TransferMode>(),
                    It.IsAny<TrafficType>(),
                    It.IsAny<Units>()))
                .ReturnsAsync(TimeSpan.FromSeconds(7200));

            var result = await _transferPointsService.EditTransferPointAsync("testUser", transferPoint.Id, transferPointDTO);

            Assert.True(result);
            var updatedTransferPoint = await _dbContext.TransferPoints.FindAsync(transferPoint.Id);
            Assert.NotNull(updatedTransferPoint);
            Assert.Equal(7200, (int)updatedTransferPoint.TransferTime.TotalSeconds);
        }

    [Fact]
    public async Task EditTransferPointAsync_TransferPointNotFound_ShouldThrowInvalidOperationException()
    {
        var transferPointDTO = new TransferPointRequestDTO
        {
            TripDayId = Guid.NewGuid(),
            FromTripPointId = Guid.NewGuid(),
            ToTripPointId = Guid.NewGuid(),
            Seconds = 3600
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.EditTransferPointAsync("testUser", Guid.NewGuid(), transferPointDTO));

        Assert.Equal($"{ITransferPointsService.ErrorMessage.EditTransferPoint} {ITransferPointsService.ErrorMessage.TransferPointNotFound}", exception.Message);
    }

    [Fact]
    public async Task EditTransferPointAsync_InvalidTransferPointTime_ShouldThrowInvalidOperationException()
    {
        var fromTripPointPlace = new ProviderPlace { Id = Guid.NewGuid(), Name = "From Point", City = "CityA", Country = "CountryA", ProviderId = "ProviderA" };
        var toTripPointPlace = new ProviderPlace { Id = Guid.NewGuid(), Name = "To Point", City = "CityB", Country = "CountryB", ProviderId = "ProviderB" };
        var fromTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "From Point", Place = fromTripPointPlace };
        var toTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "To Point", Place = toTripPointPlace };
        var tripDay = new TripDay
        {
            Id = Guid.NewGuid(),
            Trip = new Trip { UserId = "testUser", Name = "Test Trip", CurrencyCode = "USD" },
            TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint }
        };

        tripDay.TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint };
        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();

        var transferPoint = new TransferPoint
        {
            Id = Guid.NewGuid(),
            TripDayId = tripDay.Id,
            FromTripPointId = fromTripPoint.Id,
            ToTripPointId = toTripPoint.Id,
            TransferTime = TimeSpan.FromSeconds(3600)
        };

        await _dbContext.TransferPoints.AddAsync(transferPoint);
        await _dbContext.SaveChangesAsync();

        var transferPointDTO = new TransferPointRequestDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = fromTripPoint.Id,
            ToTripPointId = toTripPoint.Id,
            Seconds = null,
            Mode = null
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.EditTransferPointAsync("testUser", transferPoint.Id, transferPointDTO));

        Assert.Equal($"{ITransferPointsService.ErrorMessage.EditTransferPoint} {ITransferPointsService.ErrorMessage.InvalidTransferPointTime}", exception.Message);
    }

    [Fact]
    public async Task DeleteTransferPointAsync_ValidRequest_ShouldDeleteTransferPoint()
    {
        var tripDay = new TripDay
        {
            Id = Guid.NewGuid(),
            Trip = new Trip { UserId = "testUser", Name = "Test Trip", CurrencyCode = "USD" }
        };
        var fromTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "From Point" };
        var toTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "To Point" };

        tripDay.TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint };
        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();
        
        var transferPoint = new TransferPoint
        {
            Id = Guid.NewGuid(),
            TripDayId = tripDay.Id,
            FromTripPointId = fromTripPoint.Id,
            ToTripPointId = toTripPoint.Id,
            TransferTime = TimeSpan.FromSeconds(3600)
        };

        await _dbContext.TransferPoints.AddAsync(transferPoint);
        await _dbContext.SaveChangesAsync();

        // Act
        var result = await _transferPointsService.DeleteTransferPointAsync("testUser", transferPoint.Id);

        // Assert
        Assert.True(result);
        var deletedTransferPoint = await _dbContext.TransferPoints.FindAsync(transferPoint.Id);
        Assert.Null(deletedTransferPoint);
    }

    [Fact]
    public async Task DeleteTransferPointAsync_TransferPointNotFound_ShouldThrowException()
    {
        // Arrange
        var nonExistentTransferPointId = Guid.NewGuid();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            await _transferPointsService.DeleteTransferPointAsync("testUser", nonExistentTransferPointId)
        );

        Assert.Equal($"{ITransferPointsService.ErrorMessage.DeleteTransferPoint} {ITransferPointsService.ErrorMessage.TransferPointNotFound}", exception.Message);
    }
}