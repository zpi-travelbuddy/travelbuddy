using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.ConditionProfile;

[NotMapped]
public class ConditionProfileRequestDTO
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public List<Guid>? ConditionIds { get; set; }
}