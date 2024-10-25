using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.DTOs.TripDay;

[NotMapped]
public class TripDayOverviewDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public Guid TripId { get; set; }

    [Required]
    public DateOnly Date { get; set; }
}