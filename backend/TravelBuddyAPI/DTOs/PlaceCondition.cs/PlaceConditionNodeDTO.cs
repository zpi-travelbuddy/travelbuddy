using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.PlaceCondition;

[NotMapped]
public class PlaceConditionNodeDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public List<PlaceConditionNodeDTO>? SubConditions { get; set; }
}