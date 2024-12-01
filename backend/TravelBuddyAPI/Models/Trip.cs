using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Models;

public class Trip
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? UserId { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Number of travelers must be 1 or more.")]
    public int NumberOfTravelers { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }

    [Required]
    public Guid DestinationId { get; set; }
    public Place? Destination { get; set; }

    [Required]
    [Precision(18, 6)]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(Budget)} must be a positive number.")]
    public decimal Budget { get; set; }

    [NotMapped]
    public decimal BudgetPerPerson
    {
        get => Math.Round(Budget / NumberOfTravelers, 2);
    }

    [Required]
    [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = $"{nameof(CurrencyCode)} must be a valid 3-letter ISO 4217 code.")]
    public string? CurrencyCode { get; set; }

    [Required]
    [Precision(18, 4)]
    public decimal ExchangeRate { get; set; }

    public Guid? CategoryProfileId { get; set; }
    public CategoryProfile? CategoryProfile { get; set; }

    public Guid? ConditionProfileId { get; set; }
    public ConditionProfile? ConditionProfile { get; set; }

    [NotMapped]
    public bool? IsFinished { get => TripDays?.All(td => td?.IsFinished ?? true); }

    [NotMapped]
    public decimal? PredictedCost
    {
        get
        {
            decimal? predictedCost = TripDays?.Sum(td => td.PredictedCost);
            return predictedCost.HasValue ? Math.Round(predictedCost.Value, 2) : null;
        }
    }

    [NotMapped]
    public decimal? PredictedCostPerPerson
    {
        get
        {
            decimal? predictedCostPerPerson = PredictedCost / NumberOfTravelers;
            return predictedCostPerPerson.HasValue ? Math.Round(predictedCostPerPerson.Value, 2) : null;
        }
    }

    [NotMapped]
    public decimal? ActualCost
    {
        get => ActualCostPerPerson.HasValue ? Math.Round(ActualCostPerPerson.Value * NumberOfTravelers, 2) : null;
    }

    [NotMapped]
    public decimal? ActualCostPerPerson
    {
        get
        {
            decimal? actualCostPerPerson = TripDays?.Sum(td => td?.ActualCostPerPerson);
            return actualCostPerPerson.HasValue ? Math.Round(actualCostPerPerson.Value, 2) : null;
        }
    }

    [NotMapped]
    public TimeSpan? TimeSpentOnTripPoints
    {
        get => TripDays?.Aggregate(TimeSpan.Zero, (sum, td) => sum + (td?.TimeSpentOnTripPoints ?? TimeSpan.Zero));
    }

    public List<TripDay>? TripDays { get; set; }

}