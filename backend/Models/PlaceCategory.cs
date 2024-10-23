using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TravelBuddyAPI.Models;

public class PlaceCategory
{

    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }

    public Guid? SuperCategoryId { get; set; }
    public PlaceCategory? SuperCategory { get; set; }

    public List<PlaceCategory>? SubCategories { get; set; }
    public List<CategoryProfile>? CategoryProfiles { get; set; }
    public List<ProviderPlace>? ProviderPlaces { get; internal set; }
}