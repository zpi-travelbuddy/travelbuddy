﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelBuddyAPI.Data;

#nullable disable

namespace TravelBuddyAPI.Migrations
{
    [DbContext(typeof(TravelBuddyDbContext))]
    partial class TravelBuddyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProfilePlaceCategory", b =>
                {
                    b.Property<Guid>("PlaceCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlaceCategoryId", "CategoryProfileId");

                    b.HasIndex("CategoryProfileId");

                    b.ToTable("CategoryProfilePlaceCategory", (string)null);
                });

            modelBuilder.Entity("ConditionProfilePlaceCondition", b =>
                {
                    b.Property<Guid>("PlaceConditionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConditionProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlaceConditionId", "ConditionProfileId");

                    b.HasIndex("ConditionProfileId");

                    b.ToTable("ConditionProfilePlaceCondition", (string)null);
                });

            modelBuilder.Entity("ProviderPlacePlaceCategory", b =>
                {
                    b.Property<Guid>("PlaceCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProviderPlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlaceCategoryId", "ProviderPlaceId");

                    b.HasIndex("ProviderPlaceId");

                    b.ToTable("ProviderPlacePlaceCategory", (string)null);
                });

            modelBuilder.Entity("ProviderPlacePlaceCondition", b =>
                {
                    b.Property<Guid>("PlaceConditionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProviderPlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlaceConditionId", "ProviderPlaceId");

                    b.HasIndex("ProviderPlaceId");

                    b.ToTable("ProviderPlacePlaceCondition", (string)null);
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.CategoryProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoryProfiles");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.ConditionProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConditionProfiles");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.FavouriteProfiles", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("CategoryProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ConditionProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.HasIndex("CategoryProfileId");

                    b.HasIndex("ConditionProfileId");

                    b.ToTable("Favourites");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.Place", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceType")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Places");

                    b.HasDiscriminator<string>("PlaceType").HasValue("Place");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.PlaceCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SuperCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SuperCategoryId");

                    b.ToTable("PlaceCategories");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.PlaceCondition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SuperConditionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SuperConditionId");

                    b.ToTable("PlaceConditions");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TransferPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FromTripPointId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Mode")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.Property<Guid?>("ToTripPointId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("TransferTime")
                        .HasColumnType("time");

                    b.Property<Guid>("TripDayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromTripPointId");

                    b.HasIndex("ToTripPointId");

                    b.HasIndex("TripDayId");

                    b.ToTable("TransferPoints");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.Trip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("CategoryProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConditionProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DestinationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfTravelers")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryProfileId");

                    b.HasIndex("ConditionProfileId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TripDay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("TripId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("TripDays");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TripPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeOnly>("ClosingTime")
                        .HasColumnType("time");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("OpeningTime")
                        .HasColumnType("time");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PredictedCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("TripDayId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.HasIndex("TripDayId");

                    b.ToTable("TripPoints");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TripPointReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("ActualCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeSpan?>("ActualTimeSpent")
                        .HasColumnType("time");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("TripPointId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.HasIndex("TripPointId")
                        .IsUnique();

                    b.ToTable("TripPointReviews");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.CustomPlace", b =>
                {
                    b.HasBaseType("TravelBuddyAPI.Models.Place");

                    b.Property<Guid?>("PlaceCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("PlaceCategoryId");

                    b.HasDiscriminator().HasValue("CustomPlace");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.ProviderPlace", b =>
                {
                    b.HasBaseType("TravelBuddyAPI.Models.Place");

                    b.Property<string>("ProviderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ProviderPlace");
                });

            modelBuilder.Entity("CategoryProfilePlaceCategory", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.CategoryProfile", null)
                        .WithMany()
                        .HasForeignKey("CategoryProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CategoryProfilePlaceCategory_CategoryProfileId");

                    b.HasOne("TravelBuddyAPI.Models.PlaceCategory", null)
                        .WithMany()
                        .HasForeignKey("PlaceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CategoryProfilePlaceCategory_PlaceCategoryId");
                });

            modelBuilder.Entity("ConditionProfilePlaceCondition", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.ConditionProfile", null)
                        .WithMany()
                        .HasForeignKey("ConditionProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ConditionProfilePlaceCondition_ConditionProfileId");

                    b.HasOne("TravelBuddyAPI.Models.PlaceCondition", null)
                        .WithMany()
                        .HasForeignKey("PlaceConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ConditionProfilePlaceCondition_PlaceConditionId");
                });

            modelBuilder.Entity("ProviderPlacePlaceCategory", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.PlaceCategory", null)
                        .WithMany()
                        .HasForeignKey("PlaceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ProviderPlacePlaceCategory_PlaceCategoryId");

                    b.HasOne("TravelBuddyAPI.Models.ProviderPlace", null)
                        .WithMany()
                        .HasForeignKey("ProviderPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ProviderPlacePlaceCategory_ProviderPlaceId");
                });

            modelBuilder.Entity("ProviderPlacePlaceCondition", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.PlaceCondition", null)
                        .WithMany()
                        .HasForeignKey("PlaceConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ProviderPlacePlaceCondition_PlaceConditionId");

                    b.HasOne("TravelBuddyAPI.Models.ProviderPlace", null)
                        .WithMany()
                        .HasForeignKey("ProviderPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ProviderPlacePlaceCondition_ProviderPlaceId");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.FavouriteProfiles", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.CategoryProfile", "CategoryProfile")
                        .WithMany()
                        .HasForeignKey("CategoryProfileId");

                    b.HasOne("TravelBuddyAPI.Models.ConditionProfile", "ConditionProfile")
                        .WithMany()
                        .HasForeignKey("ConditionProfileId");

                    b.Navigation("CategoryProfile");

                    b.Navigation("ConditionProfile");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.PlaceCategory", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.PlaceCategory", "SuperCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("SuperCategoryId");

                    b.Navigation("SuperCategory");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.PlaceCondition", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.PlaceCondition", "SuperCondition")
                        .WithMany("SubConditions")
                        .HasForeignKey("SuperConditionId");

                    b.Navigation("SuperCondition");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TransferPoint", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.TripPoint", "FromTripPoint")
                        .WithMany()
                        .HasForeignKey("FromTripPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelBuddyAPI.Models.TripPoint", "ToTripPoint")
                        .WithMany()
                        .HasForeignKey("ToTripPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelBuddyAPI.Models.TripDay", "TripDay")
                        .WithMany("TransferPoints")
                        .HasForeignKey("TripDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FromTripPoint");

                    b.Navigation("ToTripPoint");

                    b.Navigation("TripDay");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.Trip", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.CategoryProfile", "CategoryProfile")
                        .WithMany()
                        .HasForeignKey("CategoryProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelBuddyAPI.Models.ConditionProfile", "ConditionProfile")
                        .WithMany()
                        .HasForeignKey("ConditionProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelBuddyAPI.Models.Place", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryProfile");

                    b.Navigation("ConditionProfile");

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TripDay", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.Trip", "Trip")
                        .WithMany("TripDays")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TripPoint", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelBuddyAPI.Models.TripDay", "TripDay")
                        .WithMany("TripPoints")
                        .HasForeignKey("TripDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("TripDay");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TripPointReview", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.Place", "Place")
                        .WithMany("Reviews")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelBuddyAPI.Models.TripPoint", "TripPoint")
                        .WithOne("Review")
                        .HasForeignKey("TravelBuddyAPI.Models.TripPointReview", "TripPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("TripPoint");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.CustomPlace", b =>
                {
                    b.HasOne("TravelBuddyAPI.Models.PlaceCategory", "PlaceCategory")
                        .WithMany()
                        .HasForeignKey("PlaceCategoryId");

                    b.Navigation("PlaceCategory");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.Place", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.PlaceCategory", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.PlaceCondition", b =>
                {
                    b.Navigation("SubConditions");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.Trip", b =>
                {
                    b.Navigation("TripDays");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TripDay", b =>
                {
                    b.Navigation("TransferPoints");

                    b.Navigation("TripPoints");
                });

            modelBuilder.Entity("TravelBuddyAPI.Models.TripPoint", b =>
                {
                    b.Navigation("Review");
                });
#pragma warning restore 612, 618
        }
    }
}
