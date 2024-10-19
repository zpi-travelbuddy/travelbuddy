using System.ComponentModel.DataAnnotations;

namespace TravelBuddyAPI.Models;

public class CategoryProfile
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? UserId { get; set; }

    [Required]
    public string? Name { get; set; }

    public List<PlaceCategory>? Categories { get; set; }
}