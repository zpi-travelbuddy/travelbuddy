using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.Models;

public class TransferPoint
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid TripDayId { get; set; }
    public TripDay? TripDay { get; set; }

    [NotMapped]
    public Trip? Trip => TripDay?.Trip;

    [Required]
    public TimeSpan TransferTime { get; set; }

    [Required]
    public Guid? FromTripPointId { get; set; }
    public TripPoint? FromTripPoint { get; set; }

    [Required]
    public Guid? ToTripPointId { get; set; }
    public TripPoint? ToTripPoint { get; set; }

    public TransferMode? Mode { get; set; }

}
