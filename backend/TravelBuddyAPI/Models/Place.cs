using System.ComponentModel.DataAnnotations;

namespace TravelBuddyAPI.Models;

public abstract class Place
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Country { get; set; }

    [Required]
    public string? City { get; set; }

    public string? Street { get; set; }

    public string? HouseNumber { get; set; }

    [Required]
    public decimal Latitude { get; set; }

    [Required]
    public decimal Longitude { get; set; }

    public List<TripPointReview>? Reviews { get; set; }
}