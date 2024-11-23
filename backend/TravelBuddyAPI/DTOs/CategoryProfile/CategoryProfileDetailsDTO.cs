using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.DTOs.CategoryProfile;

[NotMapped]
public class CategoryProfileDetailsDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public List<PlaceCategoryDTO>? Categories { get; set; }
}