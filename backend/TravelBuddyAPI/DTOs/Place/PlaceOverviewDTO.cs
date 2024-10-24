using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.Place;

[NotMapped]
public class PlaceOverviewDTO
{
    [Required]
    public Guid Id { get; set; }

    public string? ProviderId { get; set; }
    
    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Country { get; set; }

    [Required]
    public string? City { get; set; }
}