using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.Trip;

[NotMapped]
public class TripStatisticsDTO
{
    [Required]
    public int NumberOfTrips { get; set; }

    [Required]
    public int NumberOfVisitedPlaces { get; set; }

    [Required]
    public decimal TotalSpendings { get; set; }

    [Required]
    public string? CurrencyCode { get; set; }
}
