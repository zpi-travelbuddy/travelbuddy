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
        if (category.SuperCategoryId == null)
        {
            return category.Name;
        }

        if (category.SuperCategory == null)
        {
            return null;
        }

        var superCategoryFullName = GetFullName(category.SuperCategory);
        return superCategoryFullName is null ? null : $"{superCategoryFullName}.{category.Name}";
    }

}