using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.ViewModels.ConditionProfile;

[NotMapped]
public class ConditionProfileModificationViewModel
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string? Name { get; set; }

    [Required]
    public List<Guid>? ConditionIds { get; set; }
}