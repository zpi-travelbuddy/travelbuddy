using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.Trip;

[NotMapped]
public class TripSummaryDTO
{
    [Required]
    public string? CurrencyCode { get; set; }

    [Required]
    public List<TripDayStatistics>? TripDays { get; set; }
}

public record TripPointStatistics(string? Name, decimal PredictedCost, decimal ActualCost);

public record TripDayStatistics(DateOnly Date, List<TripPointStatistics> TripPoints);