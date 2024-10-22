using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.DTOs.ConditionProfile;

[NotMapped]
public class ConditionProfileDetailsDTO
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public List<PlaceCondition>? Conditions { get; set; } // TODO create DTO for PlaceCondition
}