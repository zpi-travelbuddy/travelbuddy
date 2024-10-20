using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Models;

public class TripPoint{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid TripDayId { get; set; }
    public TripDay? TripDay { get; set; }

    public Trip? Trip => TripDay?.Trip; 

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(PredictedCost)} must be a positive number.")]
    public decimal PredictedCost { get; set; }

    [NotMapped]
    public decimal? PredictedCostPerPerson => Trip is null ? null : Math.Round(PredictedCost / Trip.NumberOfTravelers);

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; } // TODO add validation

    public TimeOnly OpeningTime { get; set; }

    public TimeOnly ClosingTime { get; set; }

    public TripPointStatus Status { get; set; }

    [Required]
    public Place? Place { get; set; }

    public TripPointReview? Review { get; set; }

    public TransferPoint? TransferIn { get; set; }

    public TransferPoint? TransferOut { get; set; }
}