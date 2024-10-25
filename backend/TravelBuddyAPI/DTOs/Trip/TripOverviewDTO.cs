using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.DTOs.Trip;

[NotMapped]
public class TripOverviewDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }
}