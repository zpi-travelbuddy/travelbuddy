using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

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

    public string? State { get; set; }

    [Required]
    public string? City { get; set; }

    public string? Street { get; set; }

    public string? HouseNumber { get; set; }

    [Required]
    [Precision(18, 8)]
    public decimal Latitude { get; set; }

    [Required]
    [Precision(18, 8)]
    public decimal Longitude { get; set; }

    public List<TripPointReview>? Reviews { get; set; }
}