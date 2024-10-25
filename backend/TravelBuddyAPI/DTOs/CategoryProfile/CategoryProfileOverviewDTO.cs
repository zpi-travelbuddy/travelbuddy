using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.CategoryProfile;

[NotMapped]
public class CategoryProfileOverviewDTO
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
}