using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = $"{nameof(PredictedCost)} can have a maximum of 2 decimal places.")]
    public decimal PredictedCost { get; set; }

    [NotMapped]
    public decimal? PredictedCostPerPerson => PredictedCost / Trip?.NumberOfTravelers;

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; } // TODO add validation

    public TimeOnly OpeningTime { get; set; }

    public TimeOnly ClosingTime { get; set; }

    [NotMapped]
    public bool IsFinished { get; set; }

    [Required]
    public Place? Place { get; set; }

    public TripPointReview? Review { get; set; }

    public TransferPoint? TransferTo { get; set; }

    public TransferPoint? TransferFrom { get; set; }
}