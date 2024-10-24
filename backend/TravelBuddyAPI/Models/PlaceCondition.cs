using System.ComponentModel.DataAnnotations;

namespace TravelBuddyAPI.Models;

public class PlaceCondition
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }

    public Guid? SuperConditionId { get; set; }
    public PlaceCondition? SuperCondition { get; set; }

    public List<PlaceCondition>? SubConditions { get; set; }
    public List<ConditionProfile>? ConditionProfiles { get; internal set; }
    public List<ProviderPlace>? ProviderPlaces { get; internal set; }
}