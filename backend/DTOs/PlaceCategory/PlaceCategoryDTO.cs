using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.PlaceCategory;

[NotMapped]
public class PlaceCategoryDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }
}
