namespace TravelBuddyAPI.Models;
public class CustomPlace : Place
{
    public Guid? SuperCategoryId { get; set; }
    public PlaceCategory? SuperCategory { get; set; }
}
