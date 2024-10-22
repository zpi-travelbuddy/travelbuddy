using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Enums;

namespace TravelBuddyAPI.ViewModels.Trip;

[NotMapped]
public class TripModificationViewModel{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string? Name { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Number of travelers must be 1 or more.")]
    public int NumberOfTravelers { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    public Guid DestinationId { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = $"{nameof(Budget)} must be a positive number.")]
    public decimal Budget { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = $"{nameof(CurrencyCode)} must be a valid 3-letter ISO 4217 code.")]
    public string? CurrencyCode { get; set; }

    [Required]
    public Guid CategoryProfileId { get; set; }

    [Required]
    public Guid ConditionProfileId { get; set; }

}