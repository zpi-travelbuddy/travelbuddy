using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.DTOs.Place;

namespace TravelBuddyAPI.DTOs.TripPoint;

[NotMapped]
public class TripPointOverviewDTO
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public Guid TripDayId { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; }
}
