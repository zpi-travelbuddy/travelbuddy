using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.TripPointReview;

[NotMapped]
public class TripPointReviewDetailsDTO
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid TripPointId { get; set; }

    [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = $"{nameof(CurrencyCode)} must be a valid 3-letter ISO 4217 code.")]
    public string? CurrencyCode { get; set; }

    [Required]
    public Guid PlaceId { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(ActualCost)} must be a positive number.")]
    public decimal? ActualCost { get; set; }

    public decimal? ActualCostPerPerson { get; set; }
    public TimeSpan? ActualTimeSpent { get; set; }

    [Range(0, 5)]
    [RegularExpression(@"^\d+(\.0|\.5)?$", ErrorMessage = $"{nameof(Rating)} must have at most one digit after the decimal point, which can only be 0 or 5.")]
    public decimal? Rating { get; set; }
}