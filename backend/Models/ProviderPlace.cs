using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.Models;

public class ProviderPlace : Place
{
    [Required]
    public string? ProviderId { get; set; }

    public List<PlaceCondition>? Conditions { get; set; }

    public List<PlaceCategory>? Categories { get; set; }

    [NotMapped]
    public decimal? AverageCostPerPerson { get => Reviews?.Average(r => r.ActualCostPerPerson); }

    [NotMapped]
    public TimeSpan? AverageTimeSpent
    {
        get
        {
            double? averageTicks = Reviews?.Average(r => r?.ActualTimeSpent?.Ticks);
            return averageTicks.HasValue ? TimeSpan.FromTicks((long)averageTicks) : null;
        }
    }

    [NotMapped]
    public decimal? AverageRating { get => Reviews?.Average(r => r.Rating); }
}
