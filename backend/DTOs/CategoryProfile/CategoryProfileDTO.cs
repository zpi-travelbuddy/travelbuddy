using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.CategoryProfile;

[NotMapped]
public class CategoryProfileDTO
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public List<Guid>? CategoryIds { get; set; }
}