using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.DTOs.TripPoint;

[NotMapped]
public class TripPointOverviewDTO
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string? Name { get; set; }

    [Required]
    public Guid TripDayId { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public TripPointStatus Status { get; set; }
}
