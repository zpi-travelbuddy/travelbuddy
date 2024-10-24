using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyAPI.Models;

public class PlaceCategory
{

    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [NotMapped]
    public string? FullName => GetFullName(this);

    public string? Description { get; set; }

    public Guid? SuperCategoryId { get; set; }
    public PlaceCategory? SuperCategory { get; set; }

    public List<PlaceCategory>? SubCategories { get; set; }
    public List<CategoryProfile>? CategoryProfiles { get; set; }
    public List<ProviderPlace>? ProviderPlaces { get; internal set; }

    private static string? GetFullName(PlaceCategory category)
    {
        if (category.SuperCategoryId is null || category.SuperCategory is null)
        {
            return category.Name;
        }
        else
        {
            return GetFullName(category.SuperCategory) + "." + category.Name;
        }
    }
}