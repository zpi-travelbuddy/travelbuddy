using Microsoft.EntityFrameworkCore;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.TransferPoint;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Services;
using TravelBuddyAPI.Models; // Add this line
using Xunit;

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
    public async Task CreateTransferPointAsync_ValidRequest_ShouldCreateTransferPoint()
    {
        try
        {
        var fromTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "From Point" };
        var toTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "To Point" };
        var tripDay = new TripDay 
        { 
            Id = Guid.NewGuid(), 
            Trip = new Trip { UserId = "testUser", Name = "Test Trip", CurrencyCode = "USD" },
            TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint }
        };

        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();

        var transferPointDTO = new TransferPointDTO
        {
            TripDayId = tripDay.Id,
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
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
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }

    [Fact]
    public async Task CreateTransferPointAsync_EmptyRequest_ShouldThrowArgumentNullException()
    {
        string userId = "testUser";
        TransferPointDTO transferPoint = null!;

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync(userId, transferPoint));

        Assert.Equal($"{TransferPointsService.ErrorMessage.CreateTransferPoint} {TransferPointsService.ErrorMessage.EmptyRequest} (Parameter 'transferPoint')", exception.Message);
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

        var transferPointDTO = new TransferPointDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = tripPoint.Id,
            ToTripPointId = tripPoint.Id,
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            Seconds = 3600,
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO));

        Assert.Equal($"{TransferPointsService.ErrorMessage.CreateTransferPoint} {TransferPointsService.ErrorMessage.SameTripPoints}", exception.Message);
    }

    [Fact]
    public async Task CreateTransferPointAsync_TripDayNotFound_ShouldThrowInvalidOperationException()
    {
        var transferPointDTO = new TransferPointDTO
        {
            TripDayId = Guid.NewGuid(),
            FromTripPointId = Guid.NewGuid(),
            ToTripPointId = Guid.NewGuid(),
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            Seconds = 3600,
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO));

        Assert.Equal($"{TransferPointsService.ErrorMessage.CreateTransferPoint} {TransferPointsService.ErrorMessage.TripDayNotFound}", exception.Message);
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

        var transferPointDTO = new TransferPointDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = Guid.NewGuid(),
            ToTripPointId = Guid.NewGuid(),
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            Seconds = 3600,
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO));

        Assert.Equal($"{TransferPointsService.ErrorMessage.CreateTransferPoint} {TransferPointsService.ErrorMessage.TripPointNotFoundInTripDay}", exception.Message);
    }

    [Fact]
    public async Task CreateTransferPointAsync_InvalidTransferPointTime_ShouldThrowInvalidOperationException()
    {
        var tripDay = new TripDay { Id = Guid.NewGuid(), Trip = new Trip { UserId = "testUser", Name = "Test Trip", CurrencyCode = "USD" } };
        var fromTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "From Point" };
        var toTripPoint = new TripPoint { Id = Guid.NewGuid(), Name = "To Point" };

        tripDay.TripPoints = new List<TripPoint> { fromTripPoint, toTripPoint };
        await _dbContext.TripDays.AddAsync(tripDay);
        await _dbContext.SaveChangesAsync();

        var transferPointDTO = new TransferPointDTO
        {
            TripDayId = tripDay.Id,
            FromTripPointId = fromTripPoint.Id,
            ToTripPointId = toTripPoint.Id,
            StartTime = TimeOnly.FromDateTime(DateTime.Now),
            Seconds = null,
            Mode = null
        };

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _transferPointsService.CreateTransferPointAsync("testUser", transferPointDTO));

        Assert.Equal($"{TransferPointsService.ErrorMessage.CreateTransferPoint} {TransferPointsService.ErrorMessage.InvalidTransferPointTime}", exception.Message);
    }
}