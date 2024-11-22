using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.PlaceCategory;

[NotMapped]
public class PlaceCategoryNodeDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public List<PlaceCategoryNodeDTO>? SubCategories { get; set; }
}