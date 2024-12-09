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

    public static bool operator ==(ProviderPlace? left, ProviderPlace? right)
    {
        if (left is null)
            return right is null;

        return left.Equals(right);
    }

    public static bool operator !=(ProviderPlace? left, ProviderPlace? right)
    {
        return !(left == right);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not ProviderPlace place)
            return false;

        return ProviderId == place.ProviderId ||
               (Name == place.Name &&
                Country == place.Country &&
                State == place.State &&
                City == place.City &&
                Street == place.Street &&
                HouseNumber == place.HouseNumber);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ProviderId, Name, Country, State, City, Street, HouseNumber);
    }
}
