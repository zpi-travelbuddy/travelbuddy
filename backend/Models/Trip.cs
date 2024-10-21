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
    public DateOnly StartDate { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }

    [Required]
    public Guid DestinationId { get; set; }
    public Place? Destination { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(Budget)} must be a positive number.")]
    public decimal Budget { get; set; }

    [NotMapped]
    public decimal BudgetPerPerson
    {
        get => Math.Round(Budget / NumberOfTravelers, 2);
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
    public decimal? Cost
    {
        get => TripDays?.Sum(td => td?.Cost);
    }

    [NotMapped]
    public decimal? CostPerPerson
    {
        get => Cost.HasValue ? Math.Round(Cost.Value / NumberOfTravelers, 2) : null;
    }

    [NotMapped]
    public TimeSpan? TimeSpentOnTripPoints
    {
        get => TripDays?.Aggregate(TimeSpan.Zero, (sum, td) => sum + (td?.TimeSpentOnTripPoints ?? TimeSpan.Zero));
    }

    public List<TripDay>? TripDays { get; set; }

}