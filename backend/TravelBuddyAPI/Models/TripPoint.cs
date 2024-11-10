using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Models;

public class TripPoint{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Comment { get; set; }

    [Required]
    [Precision(18, 4)]
    public decimal ExchangeRate { get; set; }

    [Required]
    public Guid TripDayId { get; set; }
    public TripDay? TripDay { get; set; }

    [NotMapped]
    public Trip? Trip => TripDay?.Trip; 

    [Required]
    [Precision(18, 6)]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(PredictedCost)} must be a positive number.")]
    public decimal PredictedCost { get; set; }

    [NotMapped]
    public decimal? PredictedCostPerPerson => Trip is null ? null : Math.Round(PredictedCost / Trip.NumberOfTravelers, 2);

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; }

    public TimeOnly? OpeningTime { get; set; }

    public TimeOnly? ClosingTime { get; set; }

    [Required]
    public TripPointStatus Status { get; set; }

    [Required]
    public Guid PlaceId { get; set; }
    public Place? Place { get; set; }

    public TripPointReview? Review { get; set; }
}