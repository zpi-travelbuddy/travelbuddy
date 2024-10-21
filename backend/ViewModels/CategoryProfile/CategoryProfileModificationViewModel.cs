using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.ViewModels.CategoryProfile;

[NotMapped]
public class CategoryProfileModificationViewModel
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string? Name { get; set; }

    [Required]
    public List<Guid>? CategoryIds { get; set; }
}