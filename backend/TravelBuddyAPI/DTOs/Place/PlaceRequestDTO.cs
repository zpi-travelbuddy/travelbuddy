using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.Place;

[NotMapped]
public class PlaceRequestDTO
{
    public string? ProviderId { get; set; }

    public Guid? CategoryId { get; set; }
    
    [Required]
    public string? Name { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? HouseNumber { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }
}