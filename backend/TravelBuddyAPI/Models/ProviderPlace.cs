using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.Models;

public class ProviderPlace : Place
{
    [Required]
    public string? ProviderId { get; set; }

    public List<PlaceCondition>? Conditions { get; set; }

    public List<PlaceCategory>? Categories { get; set; }

    public string? OpeningHours { get; set; }

    [NotMapped]
    public decimal? AverageCostPerPerson
    {
        get
        {
            return Reviews?.Average(r => r.ActualCostPerPerson);
        }
    }

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
    public decimal? AverageRating
    {
        get
        {
            decimal? average = Reviews?.Average(r => r.Rating);
            return average.HasValue ? Math.Round(average.Value, 1) : null;
        }
    }

    public (TimeOnly opensAt, TimeOnly closesAt)? GetOpenningHours(DateOnly date)
    {
        return Utilities.OpeningHoursParser.ParseOpeningHours(OpeningHours, date);
    }
}
