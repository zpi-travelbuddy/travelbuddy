using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    public Guid DestinationId { get; set; }
    public Place? Destination { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(Budget)} must be a positive number.")]
    [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = $"{nameof(Budget)} can have a maximum of 2 decimal places.")]
    public decimal Budget { get; set; }

    [NotMapped]
    public decimal BudgetPerPerson
    {
        get => Budget / NumberOfTravelers;
    }

    [Required]
    public Currency Currency { get; set; }

    [Required]
    public Guid CategoryProfileId { get; set; }
    public CategoryProfile? CategoryProfile { get; set; }

    [Required]
    public Guid ConditionProfileId { get; set; }
    public ConditionProfile? ConditionProfile { get; set; }

    [NotMapped]
    public bool? IsFinished { get => TripDays?.All(td => td?.IsFinished ?? true); }

    [NotMapped]
    public decimal? ActualCost
    {
        get => TripDays?.Sum(td => td?.ActualCost);
    }

    [NotMapped]
    public decimal? ActualCostPerPerson
    {
        get => ActualCost / NumberOfTravelers;
    }

    [NotMapped]
    public TimeSpan? TimeSpentOnTripPoints
    {
        get => TripDays?.Aggregate(TimeSpan.Zero, (sum, td) => sum + (td?.ActualTimeSpentOnTripPoints ?? TimeSpan.Zero));
    }

    public List<TripDay>? TripDays { get; set; }

}