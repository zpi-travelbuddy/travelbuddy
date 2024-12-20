using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.Models;

public class PlaceCondition
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [NotMapped]
    public string? FullName => GetFullName(this);

    public string? Description { get; set; }

    public Guid? SuperConditionId { get; set; }
    public PlaceCondition? SuperCondition { get; set; }

    public List<PlaceCondition>? SubConditions { get; set; }
    public List<ConditionProfile>? ConditionProfiles { get; internal set; }
    public List<ProviderPlace>? ProviderPlaces { get; internal set; }

    private static string? GetFullName(PlaceCondition condition)
    {
        if (condition.SuperConditionId == null)
        {
            return condition.Name;
        }

        if (condition.SuperCondition == null)
        {
            return null;
        }

        var superConditionFullName = GetFullName(condition.SuperCondition);
        return superConditionFullName is null ? null : $"{superConditionFullName}.{condition.Name}";
    }
}