using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.DTOs.TransferPoint;

[NotMapped]
public class TransferPointOverviewDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public Guid TripDayId { get; set; }

    public int? Seconds { get; set; }

    public TransferMode? Mode { get; set; }

    [Required]
    public Guid? FromTripPointId { get; set; }

    [Required]
    public Guid? ToTripPointId { get; set; }
}
