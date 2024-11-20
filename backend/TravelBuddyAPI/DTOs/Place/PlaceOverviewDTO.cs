using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.Place;

[NotMapped]
public class PlaceOverviewDTO
{
    public Guid? Id { get; set; }

    public string? ProviderId { get; set; }
    
    [Required]
    public string? Name { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }
}