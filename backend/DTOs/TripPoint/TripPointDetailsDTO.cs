using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.DTOs.TripPointReview;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.DTOs.TripPoint;

[NotMapped]
public class TripPointDetailsDTO
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Comment { get; set; }

    [Required]
    public Guid TripDayId { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(PredictedCost)} must be a positive number.")]
    public decimal PredictedCost { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(PredictedCostPerPerson)} must be a positive number.")]
    public decimal? PredictedCostPerPerson { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = $"{nameof(CurrencyCode)} must be a valid 3-letter ISO 4217 code.")]
    public string? CurrencyCode { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; }

    public TimeOnly OpeningTime { get; set; }

    public TimeOnly ClosingTime { get; set; }

    public TripPointStatus Status { get; set; }

    [Required]
    public Guid PlaceId { get; set; }
    public PlaceOverviewDTO? Place { get; set; }

    public TripPointReviewDetailsDTO? Review { get; set; }

    public PlaceCategoryDTO? Category { get; set; }

}
