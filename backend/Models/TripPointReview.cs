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

    public Currency? Currency { get; set; }

    public Trip? Trip => TripPoint?.Trip;

    [Required]
    public Guid PlaceId { get; set; }
    public Place? Place { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(ActualCost)} must be a positive number.")]
    [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = $"{nameof(ActualCost)} can have a maximum of 2 decimal places.")]
    public decimal? ActualCost { get; set; }

    [NotMapped]
    public decimal? ActualCostPerPerson => ActualCost / Trip?.NumberOfTravelers;

    public TimeSpan? ActualTimeSpent { get; set; }

    [Range(0, 5)]
    [RegularExpression(@"^\d+(\.0|\.5)?$", ErrorMessage = $"{nameof(Rating)} must have at most one digit after the decimal point, which can only be 0 or 5.")]
    public decimal? Rating { get; set; }
}