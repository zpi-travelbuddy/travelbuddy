using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceCategories_PlaceCategories_SuperCategoryId",
                        column: x => x.SuperCategoryId,
                        principalTable: "PlaceCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlaceConditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperConditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceConditions_PlaceConditions_SuperConditionId",
                        column: x => x.SuperConditionId,
                        principalTable: "PlaceConditions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConditionProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Favourites_CategoryProfiles_CategoryProfileId",
                        column: x => x.CategoryProfileId,
                        principalTable: "CategoryProfiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Favourites_ConditionProfiles_ConditionProfileId",
                        column: x => x.ConditionProfileId,
                        principalTable: "ConditionProfiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryProfilePlaceCategory",
                columns: table => new
                {
                    PlaceCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProfilePlaceCategory", x => new { x.PlaceCategoryId, x.CategoryProfileId });
                    table.ForeignKey(
                        name: "FK_CategoryProfilePlaceCategory_CategoryProfileId",
                        column: x => x.CategoryProfileId,
                        principalTable: "CategoryProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProfilePlaceCategory_PlaceCategoryId",
                        column: x => x.PlaceCategoryId,
                        principalTable: "PlaceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlaceType = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    PlaceCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProviderId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_PlaceCategories_PlaceCategoryId",
                        column: x => x.PlaceCategoryId,
                        principalTable: "PlaceCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConditionProfilePlaceCondition",
                columns: table => new
                {
                    PlaceConditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConditionProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionProfilePlaceCondition", x => new { x.PlaceConditionId, x.ConditionProfileId });
                    table.ForeignKey(
                        name: "FK_ConditionProfilePlaceCondition_ConditionProfileId",
                        column: x => x.ConditionProfileId,
                        principalTable: "ConditionProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConditionProfilePlaceCondition_PlaceConditionId",
                        column: x => x.PlaceConditionId,
                        principalTable: "PlaceConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderPlacePlaceCategory",
                columns: table => new
                {
                    PlaceCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderPlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderPlacePlaceCategory", x => new { x.PlaceCategoryId, x.ProviderPlaceId });
                    table.ForeignKey(
                        name: "FK_ProviderPlacePlaceCategory_PlaceCategoryId",
                        column: x => x.PlaceCategoryId,
                        principalTable: "PlaceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderPlacePlaceCategory_ProviderPlaceId",
                        column: x => x.ProviderPlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderPlacePlaceCondition",
                columns: table => new
                {
                    PlaceConditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderPlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderPlacePlaceCondition", x => new { x.PlaceConditionId, x.ProviderPlaceId });
                    table.ForeignKey(
                        name: "FK_ProviderPlacePlaceCondition_PlaceConditionId",
                        column: x => x.PlaceConditionId,
                        principalTable: "PlaceConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderPlacePlaceCondition_ProviderPlaceId",
                        column: x => x.ProviderPlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTravelers = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConditionProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_CategoryProfiles_CategoryProfileId",
                        column: x => x.CategoryProfileId,
                        principalTable: "CategoryProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trips_ConditionProfiles_ConditionProfileId",
                        column: x => x.ConditionProfileId,
                        principalTable: "ConditionProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trips_Places_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TripDays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TripId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripDays_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TripPoints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripDayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PredictedCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    OpeningTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    ClosingTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripPoints_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripPoints_TripDays_TripDayId",
                        column: x => x.TripDayId,
                        principalTable: "TripDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TransferPoints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TripDayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    FromTripPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToTripPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mode = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferPoints_TripDays_TripDayId",
                        column: x => x.TripDayId,
                        principalTable: "TripDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferPoints_TripPoints_FromTripPointId",
                        column: x => x.FromTripPointId,
                        principalTable: "TripPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TransferPoints_TripPoints_ToTripPointId",
                        column: x => x.ToTripPointId,
                        principalTable: "TripPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TripPointReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TripPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActualCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ActualTimeSpent = table.Column<TimeSpan>(type: "time", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripPointReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripPointReviews_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripPointReviews_TripPoints_TripPointId",
                        column: x => x.TripPointId,
                        principalTable: "TripPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProfilePlaceCategory_CategoryProfileId",
                table: "CategoryProfilePlaceCategory",
                column: "CategoryProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionProfilePlaceCondition_ConditionProfileId",
                table: "ConditionProfilePlaceCondition",
                column: "ConditionProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_CategoryProfileId",
                table: "Favourites",
                column: "CategoryProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_ConditionProfileId",
                table: "Favourites",
                column: "ConditionProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceCategories_SuperCategoryId",
                table: "PlaceCategories",
                column: "SuperCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceConditions_SuperConditionId",
                table: "PlaceConditions",
                column: "SuperConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_PlaceCategoryId",
                table: "Places",
                column: "PlaceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderPlacePlaceCategory_ProviderPlaceId",
                table: "ProviderPlacePlaceCategory",
                column: "ProviderPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderPlacePlaceCondition_ProviderPlaceId",
                table: "ProviderPlacePlaceCondition",
                column: "ProviderPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferPoints_FromTripPointId",
                table: "TransferPoints",
                column: "FromTripPointId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferPoints_ToTripPointId",
                table: "TransferPoints",
                column: "ToTripPointId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferPoints_TripDayId",
                table: "TransferPoints",
                column: "TripDayId");

            migrationBuilder.CreateIndex(
                name: "IX_TripDays_TripId",
                table: "TripDays",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_TripPointReviews_PlaceId",
                table: "TripPointReviews",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_TripPointReviews_TripPointId",
                table: "TripPointReviews",
                column: "TripPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TripPoints_PlaceId",
                table: "TripPoints",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_TripPoints_TripDayId",
                table: "TripPoints",
                column: "TripDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_CategoryProfileId",
                table: "Trips",
                column: "CategoryProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_ConditionProfileId",
                table: "Trips",
                column: "ConditionProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DestinationId",
                table: "Trips",
                column: "DestinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProfilePlaceCategory");

            migrationBuilder.DropTable(
                name: "ConditionProfilePlaceCondition");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "ProviderPlacePlaceCategory");

            migrationBuilder.DropTable(
                name: "ProviderPlacePlaceCondition");

            migrationBuilder.DropTable(
                name: "TransferPoints");

            migrationBuilder.DropTable(
                name: "TripPointReviews");

            migrationBuilder.DropTable(
                name: "PlaceConditions");

            migrationBuilder.DropTable(
                name: "TripPoints");

            migrationBuilder.DropTable(
                name: "TripDays");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "CategoryProfiles");

            migrationBuilder.DropTable(
                name: "ConditionProfiles");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "PlaceCategories");
        }
    }
}
