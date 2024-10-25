using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.CategoryProfile;

[NotMapped]
public class CategoryProfileRequestDTO
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public List<Guid>? CategoryIds { get; set; }
}