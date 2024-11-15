using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.DTOs.TransferPoint;
using TravelBuddyAPI.DTOs.TripPoint;

namespace TravelBuddyAPI.DTOs.TripDay;

[NotMapped]
public class TripDayDetailsDTO
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public Guid TripId { get; set; }

    [Required]
    public DateOnly Date { get; set; }

    [Required]
    public List<TransferPointOverviewDTO>? TransferPoints { get; set; }

    [Required]
    public List<TripPointOverviewDTO>? TripPoints { get; set; }
}