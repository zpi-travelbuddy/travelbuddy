using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.DTOs.CategoryProfile;

[NotMapped]
public class CategoryProfileDetailsDTO
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public List<PlaceCategory>? Categories { get; set; } // TODO create DTO for PlaceCategory
}