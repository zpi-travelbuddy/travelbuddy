using System.ComponentModel.DataAnnotations;

namespace TravelBuddyAPI.Models;

public class FavouriteProfiles
{
    [Required]
    [Key]
    public string? UserId { get; set; }

    public Guid? CategoryProfileId { get; set; }
    public CategoryProfile? CategoryProfile { get; set; }

    public Guid? ConditionProfileId { get; set; }
    public ConditionProfile? ConditionProfile { get; set; }
    
}