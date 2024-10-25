using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.FavouriteProfiles;

[NotMapped]
public class FavouriteProfilesDTO
{
    public Guid? CategoryProfileId { get; set; }
    public Guid? ConditionProfileId { get; set; }
}
