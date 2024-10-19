using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TravelBuddyAPI.Models;

public class ConditionProfile
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? UserId { get; set; }

    [Required]
    public string? Name { get; set; }

    public List<PlaceCondition>? Conditions { get; set; }
}
