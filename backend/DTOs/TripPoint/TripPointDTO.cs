using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.TripPoint;

[NotMapped]
public class TripPointDTO
{
    [Required]
    public string? Name { get; set; }

    public string? Comment { get; set; }

    [Required]
    public Guid TripDayId { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(PredictedCost)} must be a positive number.")]
    public decimal PredictedCost { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; }
}
