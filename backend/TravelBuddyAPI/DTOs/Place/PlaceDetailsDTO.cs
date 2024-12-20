using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.DTOs.PlaceCondition;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.DTOs.Place;

[NotMapped]
public class PlaceDetailsDTO
{
    [Key]
    public Guid? Id { get; set; }

    public string? ProviderId { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? HouseNumber { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public decimal? AverageCostPerPerson { get; set; }

    public TimeSpan? AverageTimeSpent { get; set; }

    public decimal? AverageRating { get; set; }

    public List<PlaceConditionDTO>? Conditions { get; set; }

    public List<PlaceCategoryDTO>? Categories { get; set; }

    public PlaceCategoryDTO? SuperCategory { get; set; }
}