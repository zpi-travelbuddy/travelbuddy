using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.DTOs.Place;

[NotMapped]
public class PlaceDetailsDTO
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    public string? ProviderId { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Country { get; set; }

    [Required]
    public string? City { get; set; }

    [Required]
    public string? Street { get; set; }

    [Required]
    public string? HouseNumber { get; set; }

    [Required]
    public decimal Latitude { get; set; }

    [Required]
    public decimal Longitude { get; set; }

    public decimal? AverageCostPerPerson { get; set; }

    public TimeSpan? AverageTimeSpent { get; set; }

    public decimal? AverageRating { get; set; }

    public List<Guid>? Conditions { get; set; } // TODO Add PlaceConditionDTO

    public List<Guid>? Categories { get; set; } // TODO Add PlaceCategoryDTO

    public PlaceCategory? SuperCategory { get; set; } // TODO Add PlaceCategoryDTO
}