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

    public Trip? Trip => TripDay?.Trip;

    [Required]
    public TimeSpan TransferTime { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    [NotMapped]
    public TimeOnly EndTime => StartTime.Add(TransferTime);

    [Required]
    public TripPoint? From { get; set; }

    [Required]
    public TripPoint? To { get; set; }

    public TransferMode? Mode { get; set; }

    public TransferType? Type { get; set; }
}
