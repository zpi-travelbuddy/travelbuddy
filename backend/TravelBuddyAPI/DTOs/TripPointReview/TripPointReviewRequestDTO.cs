using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.TripPointReview;

[NotMapped]
public class TripPointReviewRequestDTO
{
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(ActualCostPerPerson)} must be a positive number.")]
    public decimal? ActualCostPerPerson { get; set; }

    public TimeSpan? ActualTimeSpent { get; set; }

    [Range(0, 5)]
    [RegularExpression(@"^\d+(\.0|\.5)?$", ErrorMessage = $"{nameof(Rating)} must have at most one digit after the decimal point, which can only be 0 or 5.")]
    public decimal? Rating { get; set; }
}