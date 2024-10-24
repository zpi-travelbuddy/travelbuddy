using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.ConditionProfile;

[NotMapped]
public class ConditionProfileOverviewDTO
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
}