using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.PlaceCondition;

[NotMapped]
public class PlaceConditionDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }
}