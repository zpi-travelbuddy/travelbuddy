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

        modelBuilder.Entity<CategoryProfile>()
            .HasMany(p => p.Categories)
            .WithMany(t => t.CategoryProfiles)
            .UsingEntity<Dictionary<string, object>>(
                "CategoryProfilePlaceCategory",
                j => j.HasOne<PlaceCategory>()
                      .WithMany()
                      .HasForeignKey("PlaceCategoryId")
                      .HasConstraintName("FK_CategoryProfilePlaceCategory_PlaceCategoryId"),
                j => j.HasOne<CategoryProfile>()
                      .WithMany()
                      .HasForeignKey("CategoryProfileId")
                      .HasConstraintName("FK_CategoryProfilePlaceCategory_CategoryProfileId"),
                j =>
                {
                    j.HasKey("PlaceCategoryId", "CategoryProfileId");
                    j.ToTable("CategoryProfilePlaceCategory");
                }
            );

            modelBuilder.Entity<ConditionProfile>()
            .HasMany(p => p.Conditions)
            .WithMany(t => t.ConditionProfiles)
            .UsingEntity<Dictionary<string, object>>(
                "ConditionProfilePlaceCondition",
                j => j.HasOne<PlaceCondition>()
                      .WithMany()
                      .HasForeignKey("PlaceConditionId")
                      .HasConstraintName("FK_ConditionProfilePlaceCondition_PlaceConditionId"),
                j => j.HasOne<ConditionProfile>()
                      .WithMany()
                      .HasForeignKey("ConditionProfileId")
                      .HasConstraintName("FK_ConditionProfilePlaceCondition_ConditionProfileId"),
                j =>
                {
                    j.HasKey("PlaceConditionId", "ConditionProfileId");
                    j.ToTable("ConditionProfilePlaceCondition");
                }
            );

            modelBuilder.Entity<ProviderPlace>()
            .HasMany(p => p.Categories)
            .WithMany(t => t.ProviderPlaces)
            .UsingEntity<Dictionary<string, object>>(
                "ProviderPlacePlaceCategory",
                j => j.HasOne<PlaceCategory>()
                      .WithMany()
                      .HasForeignKey("PlaceCategoryId")
                      .HasConstraintName("FK_ProviderPlacePlaceCategory_PlaceCategoryId"),
                j => j.HasOne<ProviderPlace>()
                      .WithMany()
                      .HasForeignKey("ProviderPlaceId")
                      .HasConstraintName("FK_ProviderPlacePlaceCategory_ProviderPlaceId"),
                j =>
                {
                    j.HasKey("PlaceCategoryId", "ProviderPlaceId");
                    j.ToTable("ProviderPlacePlaceCategory");
                }
            );

            modelBuilder.Entity<ProviderPlace>()
            .HasMany(p => p.Conditions)
            .WithMany(t => t.ProviderPlaces)
            .UsingEntity<Dictionary<string, object>>(
                "ProviderPlacePlaceCondition",
                j => j.HasOne<PlaceCondition>()
                      .WithMany()
                      .HasForeignKey("PlaceConditionId")
                      .HasConstraintName("FK_ProviderPlacePlaceCondition_PlaceConditionId"),
                j => j.HasOne<ProviderPlace>()
                      .WithMany()
                      .HasForeignKey("ProviderPlaceId")
                      .HasConstraintName("FK_ProviderPlacePlaceCondition_ProviderPlaceId"),
                j =>
                {
                    j.HasKey("PlaceConditionId", "ProviderPlaceId");
                    j.ToTable("ProviderPlacePlaceCondition");
                }
            );

    }
}