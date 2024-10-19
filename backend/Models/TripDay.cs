using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.Models;

public class TripDay
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid TripId { get; set; }
    public Trip? Trip { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [NotMapped]
    public decimal? ActualCost
    {
        get => TripPoints?.Sum(tp => tp?.Review?.ActualCost ?? tp?.PredictedCost);
    }

    [NotMapped]
    public TimeSpan? ActualTimeSpentOnTripPoints
    {
        get => TripPoints?.Aggregate(TimeSpan.Zero, (sum, tp) => sum + (tp?.Review?.ActualTimeSpent
                                ?? (tp?.StartTime != null && tp?.EndTime != null ? tp.EndTime - tp.StartTime : TimeSpan.Zero)));
    }

    [NotMapped]
    public bool IsFinished { get; set; }

    public List<TripPoint>? TripPoints { get; set; }
}