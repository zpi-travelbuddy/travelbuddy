using Microsoft.EntityFrameworkCore;
using TravelBuddyAPI.Models;
namespace TravelBuddyAPI.Data;

public class TravelBuddyDbContext(DbContextOptions<TravelBuddyDbContext> options) : DbContext(options){
    
    public DbSet<CategoryProfile> CategoryProfiles { get; set; }
    public DbSet<ConditionProfile> ConditionProfiles { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<ProviderPlace> ProviderPlaces { get; set; }
    public DbSet<CustomPlace> CustomPlaces { get; set; }
    public DbSet<FavouriteProfiles> Favourites { get; set; }
    public DbSet<PlaceCategory> PlaceCategories { get; set; }
    public DbSet<PlaceCondition> PlaceConditions { get; set; }
    public DbSet<TransferPoint> TransferPoints { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<TripDay> TripDays { get; set; }
    public DbSet<TripPoint> TripPoints { get; set; }
    public DbSet<TripPointReview> TripPointReviews { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Place>()
            .HasDiscriminator<string>("PlaceType")
            .HasValue<ProviderPlace>("ProviderPlace")
            .HasValue<CustomPlace>("CustomPlace");

    }
}