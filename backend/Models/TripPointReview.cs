using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Models;

public class TripPointReview
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? UserId { get; set; }

    [Required]
    public Guid TripPointId { get; set; }
    public TripPoint? TripPoint { get; set; }

    [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = $"{nameof(CurrencyCode)} must be a valid 3-letter ISO 4217 code.")]
    public string? CurrencyCode { get; set; }

    public Trip? Trip => TripPoint?.Trip;

    [Required]
    public Guid PlaceId { get; set; }
    public Place? Place { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(ActualCost)} must be a positive number.")]
    public decimal? ActualCost { get; set; }

    [NotMapped]
    public decimal? ActualCostPerPerson => ActualCost.HasValue && Trip is not null ? Math.Round(ActualCost.Value / Trip.NumberOfTravelers, 2) : null;

    public TimeSpan? ActualTimeSpent { get; set; }

    [Range(0, 5)]
    [RegularExpression(@"^\d+(\.0|\.5)?$", ErrorMessage = $"{nameof(Rating)} must have at most one digit after the decimal point, which can only be 0 or 5.")]
    public decimal? Rating { get; set; }
}