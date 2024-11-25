using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Models;

public class TripPointReview
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? UserId { get; set; }

    public Guid? TripPointId { get; set; }
    public TripPoint? TripPoint { get; set; }

    [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = $"{nameof(CurrencyCode)} must be a valid 3-letter ISO 4217 code.")]
    public string? CurrencyCode { get; set; }

    [NotMapped]
    public Trip? Trip => TripPoint?.Trip;

    [Required]
    public Guid PlaceId { get; set; }
    public Place? Place { get; set; }

    [Precision(18, 4)]
    public decimal? ExchangeRate { get; set; }

    [Precision(18, 6)]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(ActualCostPerPerson)} must be a positive number.")]
    public decimal? ActualCostPerPerson { get; set; }

    public TimeSpan? ActualTimeSpent { get; set; }

    [Range(0, 5)]
    [Precision(2, 1)]
    [RegularExpression(@"^\d+(\.0|\.5)?$", ErrorMessage = $"{nameof(Rating)} must have at most one digit after the decimal point, which can only be 0 or 5.")]
    public decimal? Rating { get; set; }
}