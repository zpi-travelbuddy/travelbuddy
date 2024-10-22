using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.DTOs.TransferPoint;

[NotMapped]
public class TransferPointDTO
{
    [Required]
    public Guid TripDayId { get; set; }

    public TimeSpan? TransferTime { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    public TransferMode? Mode { get; set; }

    public TransferType? Type { get; set; }
}
