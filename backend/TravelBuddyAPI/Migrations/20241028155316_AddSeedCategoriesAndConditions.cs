using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedCategoriesAndConditions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("19894eb7-39d1-47e3-8454-0c4d68527a5b"), null, "sport", null },
                    { new Guid("23bf6eb3-ce6d-4347-b5c2-3ec4013fc651"), null, "heritage", null },
                    { new Guid("2cccac70-772e-4bbb-be9e-c13f238b5a43"), null, "entertainment", null },
                    { new Guid("70cf0a05-7551-4db8-85c6-e34739e858c1"), null, "activity", null },
                    { new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4"), null, "catering", null },
                    { new Guid("ba101896-5756-4d3f-a41d-cd9e9af87337"), null, "commercial", null },
                    { new Guid("c30d8cc9-d9d5-4e2a-bf47-3388012c1dac"), null, "natural", null },
                    { new Guid("cff33750-d418-4195-9a90-75bb7217f84a"), null, "religion", null },
                    { new Guid("d2ee336b-f36a-46cf-8cb6-895d975e8e1e"), null, "leisure", null },
                    { new Guid("e48cad10-4d1b-4cc6-add4-885feef50159"), null, "national park", null },
                    { new Guid("e7b88b3f-9fb8-4d63-a532-481015ca3650"), null, "tourism", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("01a6fe1e-cb4a-446a-9ec3-d4d6837c0586"), null, "access", null },
                    { new Guid("1004f21a-3b58-432e-a1fc-59985a9c62ba"), null, "access_limited", null },
                    { new Guid("19a8f25d-f8ff-4c79-a33d-8c3d111bb176"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("21b64080-c3bd-4b4d-95b5-8674b0b8d9cf"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("5a74f465-9782-4c21-a83f-3e2a68e3c342"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("61127822-5617-4d1c-9c31-0b7f4796a8f9"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("6ebeb7d5-cc6d-4f54-80be-d97cab2f4ded"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("70f095c3-7e25-481f-af3b-8e155fc2bff0"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("8871d628-3998-4a54-b0ef-73447a083791"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("8ba56bb8-73c3-4fb3-8f24-930194488412"), null, "fee", null },
                    { new Guid("8d4b5068-3606-4ff4-97a7-cd492f22ec44"), null, "wheelchair", null },
                    { new Guid("9884911b-2b07-4f32-b011-08814a6ffbc4"), null, "no-dogs", null },
                    { new Guid("a45e4586-0377-417f-9dcf-b4b7210cebcc"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("cc583591-783e-45dc-b6c4-09ad83eb7ec7"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("d75b8d60-d903-4d9b-8332-1e7cd9a1f75f"), null, "dogs", null },
                    { new Guid("d7af5444-92ba-487d-abdd-c3b369daa724"), "Name property defined for the place", "named", null },
                    { new Guid("d9d76027-4d00-4d84-8a4b-acd90d64e678"), null, "internet_access", null },
                    { new Guid("ea12ed58-5ea6-4b17-bac5-384d5522a1d5"), "Places where you can buy or eat vegetarian food", "vegetarian", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0c4cf218-a479-4146-ba19-7fe2e733015c"), null, "park", new Guid("d2ee336b-f36a-46cf-8cb6-895d975e8e1e") },
                    { new Guid("13af932b-325e-4b4f-838c-8703a32e2c13"), null, "stadium", new Guid("19894eb7-39d1-47e3-8454-0c4d68527a5b") },
                    { new Guid("1fce512a-6bb3-429f-bbe6-15c57d0cb089"), null, "culture", new Guid("2cccac70-772e-4bbb-be9e-c13f238b5a43") },
                    { new Guid("263d3b27-4698-416c-8511-0c427a3a089e"), null, "mountain", new Guid("c30d8cc9-d9d5-4e2a-bf47-3388012c1dac") },
                    { new Guid("2b4b017b-1c69-4537-9532-2badf1f5ddab"), null, "unesco", new Guid("23bf6eb3-ce6d-4347-b5c2-3ec4013fc651") },
                    { new Guid("2b9ab4a7-0cf5-41d8-8fca-fa70b9039397"), null, "bar", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("3d9816a9-9766-4541-b51e-7d2fd08bdee8"), null, "taproom", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("4219abf1-e5d4-47ba-9119-40cc60e3e589"), null, "aquarium", new Guid("2cccac70-772e-4bbb-be9e-c13f238b5a43") },
                    { new Guid("46f3cd85-ef35-423c-a1dc-0adabdac1d3f"), null, "forest", new Guid("c30d8cc9-d9d5-4e2a-bf47-3388012c1dac") },
                    { new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2"), null, "restaurant", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("844267c5-09d8-47c3-b5c5-d9bdbf901452"), null, "pub", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("867660a2-4412-43f5-96d3-786c58afdd2c"), null, "gift_and_souvenir", new Guid("ba101896-5756-4d3f-a41d-cd9e9af87337") },
                    { new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd"), null, "sights", new Guid("e7b88b3f-9fb8-4d63-a532-481015ca3650") },
                    { new Guid("90c079f7-e693-4132-8aa3-b09b535280fd"), null, "cafe", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("911848ba-669e-4f16-bd13-73d530a2a423"), null, "museum", new Guid("2cccac70-772e-4bbb-be9e-c13f238b5a43") },
                    { new Guid("aa9f130d-ee43-404c-b322-ac7a3f03a4e7"), null, "food_court", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63"), null, "fast_food", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("c0ad70a5-81d5-4bb2-9267-d0d69d561df8"), null, "planetarium", new Guid("2cccac70-772e-4bbb-be9e-c13f238b5a43") },
                    { new Guid("d08fa497-6b2d-40a3-87ed-bb38ee0fea0a"), null, "biergarten", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("da77a095-cbbd-4c98-a902-0f84055f4584"), null, "zoo", new Guid("2cccac70-772e-4bbb-be9e-c13f238b5a43") },
                    { new Guid("e3af44b4-3deb-44e7-b440-3f749830e369"), null, "water", new Guid("c30d8cc9-d9d5-4e2a-bf47-3388012c1dac") },
                    { new Guid("e6f1f837-27b6-4d0a-88ec-e66131967d58"), null, "attraction", new Guid("e7b88b3f-9fb8-4d63-a532-481015ca3650") },
                    { new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0"), null, "place_of_worship", new Guid("cff33750-d418-4195-9a90-75bb7217f84a") },
                    { new Guid("ece5390d-4b3c-400f-8bf4-1605c9f55cfe"), null, "art", new Guid("ba101896-5756-4d3f-a41d-cd9e9af87337") },
                    { new Guid("f4fc246f-7134-498c-96c1-5a98c099e70d"), null, "ice_cream", new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4") },
                    { new Guid("f8377a70-cad7-4a02-b85c-c95a33e6d4ed"), null, "sand", new Guid("c30d8cc9-d9d5-4e2a-bf47-3388012c1dac") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("00c14653-bf53-4f7f-8ba2-37669349acdf"), null, "limited", new Guid("8d4b5068-3606-4ff4-97a7-cd492f22ec44") },
                    { new Guid("0b34be59-0e52-44c5-913a-4d19e93d892d"), null, "yes", new Guid("d75b8d60-d903-4d9b-8332-1e7cd9a1f75f") },
                    { new Guid("138fcc37-b542-4003-aff2-4494a3016b2a"), null, "no", new Guid("8871d628-3998-4a54-b0ef-73447a083791") },
                    { new Guid("1bebe484-1eb6-4b3b-bbbf-c81fb17bea09"), "Places that are available for public", "yes", new Guid("01a6fe1e-cb4a-446a-9ec3-d4d6837c0586") },
                    { new Guid("2eac092e-50d1-4b36-91d9-010467a17851"), null, "free", new Guid("d9d76027-4d00-4d84-8a4b-acd90d64e678") },
                    { new Guid("3a43d93c-7cce-4d70-be89-919cf498a089"), null, "only", new Guid("70f095c3-7e25-481f-af3b-8e155fc2bff0") },
                    { new Guid("4eae57f5-9412-4265-96a2-d506a6a7ee83"), null, "only", new Guid("6ebeb7d5-cc6d-4f54-80be-d97cab2f4ded") },
                    { new Guid("5ef2acf6-3025-434e-8b18-c81bdfade9be"), null, "customers", new Guid("1004f21a-3b58-432e-a1fc-59985a9c62ba") },
                    { new Guid("7969af05-ac3e-4799-adbe-7503930c5a04"), null, "not_specified", new Guid("8871d628-3998-4a54-b0ef-73447a083791") },
                    { new Guid("900576b0-a1fd-4d09-a44d-dd26a588f3a7"), null, "for_customers", new Guid("d9d76027-4d00-4d84-8a4b-acd90d64e678") },
                    { new Guid("9c9b18c1-95f6-4843-852f-a6fc8c7fd609"), null, "only", new Guid("ea12ed58-5ea6-4b17-bac5-384d5522a1d5") },
                    { new Guid("db2a8f4c-0983-4f60-a70b-286ee830f114"), null, "leashed", new Guid("d75b8d60-d903-4d9b-8332-1e7cd9a1f75f") },
                    { new Guid("db42388f-6ca1-4f12-8696-da521608565a"), null, "only", new Guid("61127822-5617-4d1c-9c31-0b7f4796a8f9") },
                    { new Guid("dfe55c11-9a8a-4340-8c62-aabb6c8e5cd5"), null, "not_specified", new Guid("01a6fe1e-cb4a-446a-9ec3-d4d6837c0586") },
                    { new Guid("e6725786-59d5-4b30-98f1-ab4a3cf698f0"), null, "yes", new Guid("8d4b5068-3606-4ff4-97a7-cd492f22ec44") },
                    { new Guid("ed7f9e38-ed50-4565-a198-5a3623d144bf"), null, "only", new Guid("19a8f25d-f8ff-4c79-a33d-8c3d111bb176") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("018311e7-13a7-4180-89f5-56faea449584"), null, "cuban", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("0242a9a4-f6a4-460b-8b9f-7381630a488a"), null, "fountain", new Guid("e6f1f837-27b6-4d0a-88ec-e66131967d58") },
                    { new Guid("042f5d80-aaa2-4e2a-914c-e0cf77aa13d7"), null, "tapas", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("05311622-0b49-4909-abab-53782cee7020"), null, "moroccan", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("08c0e83b-a687-40d1-bcd1-da6add618ee7"), null, "donut", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("0a043370-1930-45df-b8a9-ba55aff75e15"), null, "steak_house", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("0a49a365-8128-40f6-b386-556e2d3f0821"), null, "bridge", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("0c77ea70-f680-4377-84af-289549c7694d"), null, "archaeological_site", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("0c97c2fd-7943-4cb2-a25f-e87f67db5245"), null, "austrian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("0cb8d358-5058-412c-8f85-45ffcaf884b4"), null, "sikhism", new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0") },
                    { new Guid("0e6e9a12-e017-470f-b047-d24d4ef7787f"), null, "danish", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("0fe81f4b-7fe2-4f02-bf39-807fc2bb2083"), null, "noodle", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("11295290-a0fc-422a-849a-9144d83efe1d"), null, "brazilian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("128899c4-6a65-45d0-80fa-cd7f8833c64d"), null, "hawaiian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("14aeba22-87f3-4078-bcb6-ee3edfb39504"), null, "coffee_shop", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("14f62702-e753-43a9-a1f0-26d0515d5216"), null, "monastery", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("1512b76b-80d0-423c-9957-513d3a8c19bc"), null, "glacier", new Guid("263d3b27-4698-416c-8511-0c427a3a089e") },
                    { new Guid("166e0c42-40b9-4110-b4c1-b0291e9722ac"), null, "dune", new Guid("f8377a70-cad7-4a02-b85c-c95a33e6d4ed") },
                    { new Guid("183e070a-3f14-4efe-b2c9-a5e72cf7d921"), null, "pita", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("1876868c-0f72-4429-bde6-47de749bf084"), null, "uzbek", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("19569a3a-186c-429f-b89d-69a5590bec01"), null, "reef", new Guid("e3af44b4-3deb-44e7-b440-3f749830e369") },
                    { new Guid("1a857a02-f360-4076-871d-9b123bb7c076"), null, "czech", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("1cb730f7-bb45-4b0e-bfed-d1817b92330a"), null, "waffle", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("1cc956fc-dc46-408f-afe4-d09ce730dfd6"), null, "salad", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("1d14f5a5-052e-492f-865c-49360b9d39c0"), null, "european", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("1e248786-a560-425e-8bed-429432e8b1c2"), null, "portuguese", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("1e718cc9-3214-45d7-bf32-a1b3c6dcb653"), null, "ukrainian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("22cf2ed0-607b-43b4-9e65-d582b3a738f7"), null, "curry", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("237e36ee-2383-428c-af84-1aa1d4a4b4ba"), null, "seafood", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70"), null, "place_of_worship", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("2524a761-a2f1-4864-b637-5604b8fc82c2"), null, "ruines", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("25c27c48-3508-4970-ac72-40df53d4f107"), null, "persian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("26757f01-6ef5-43b3-94c9-4f4cd62be2af"), null, "ethiopian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("275c01fd-b622-4c78-ab09-992743334bc9"), null, "viewpoint", new Guid("e6f1f837-27b6-4d0a-88ec-e66131967d58") },
                    { new Guid("28116905-1807-480a-8b4a-99d47683d92c"), null, "sandwich", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("28f6cc58-d932-4e2f-9811-20113e82a706"), null, "wings", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("295647f6-c87d-4991-b74b-84cdc16f00b1"), null, "chicken", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("297702de-f16f-4c73-b90f-d4bcf5937c75"), null, "syrian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("2a1b4eca-ffc8-49aa-b535-aa8c7ccc1651"), null, "tacos", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("2bdd3fe2-3c09-4ebe-bb04-905bd4632f48"), null, "latin_american", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("2d4533f6-4619-4614-9cac-bc3b59d20b41"), null, "fish_and_chips", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("3053aa66-f7bd-4133-8688-a729550cdfbb"), null, "dessert", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("32de0c74-f5a8-406b-b486-744c93ba47ad"), null, "frozen_yogurt", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("33f8ebd2-ae7c-4609-aa69-51ca6d8b8a7b"), null, "russian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("342b21d9-e602-4642-8195-e2d1e561b060"), null, "theatre", new Guid("1fce512a-6bb3-429f-bbe6-15c57d0cb089") },
                    { new Guid("34457d77-0d7d-4880-88c3-8ff3560d58f5"), null, "ice_cream", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("3514d0b1-3562-43af-8e4a-7933055c0814"), null, "arab", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("36dabfa7-bbad-4be5-8052-a53ac86c45e3"), null, "balkan", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("38ffa513-bd22-421c-bc2e-1662e33f061f"), null, "peruvian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("3ca0c6c6-1ed9-498d-b46a-93c832c508c7"), null, "city_hall", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("3caefd09-7c97-4b24-a1f1-ce28cb579e24"), null, "judaism", new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0") },
                    { new Guid("400b820f-e9be-4a1f-902c-db3cd90cb5ad"), null, "pakistani", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("41843917-ac17-4e2e-ab99-094df9bea8d1"), null, "multifaith", new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0") },
                    { new Guid("420a8b0a-7205-460c-b51c-ff35a6adfe81"), null, "sandwich", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("43faa45f-8ed1-4e0c-9935-2c48bb73f544"), null, "indonesian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("44d97e4a-36c5-4c3e-a2e8-bfe8aaeb1084"), null, "oriental", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("48720064-31f4-40af-b933-1f299abff3a0"), null, "german", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("489ee6c7-a1e3-45ac-8b7b-f12b6fc03381"), null, "korean", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("49c4f75e-2d3d-427f-a6a0-9b018b86d690"), null, "irish", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("4f6048b6-9f57-4bc3-aaf4-61cfeec0596d"), null, "italian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("4f921a2d-b60a-43e5-b169-6a777b19cf25"), null, "spring", new Guid("e3af44b4-3deb-44e7-b440-3f749830e369") },
                    { new Guid("5013b198-e2a6-4e6f-8f3b-c256fab6015e"), null, "belgian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("519f8c83-427b-439b-b013-dcdefec6184d"), null, "african", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("5475fdb7-04cf-494f-9b1e-e63724a358a1"), null, "asian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("56d68ab3-72cb-4274-ab57-fefd70bbe906"), null, "beef_bowl", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("586ca75c-b80f-4367-9a41-d5d63696e237"), null, "shinto", new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0") },
                    { new Guid("58ceb6b4-0bcc-4d7f-912e-b1e079913376"), null, "fish_and_chips", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("59e232aa-ddc7-426a-8cb5-d926bc60b4dc"), null, "argentinian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("5c5d6f73-8615-4081-9e8d-68e41313175d"), null, "chinese", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("5d240ddc-5da9-4d5a-88be-ae8b4b86d2b5"), null, "mediterranean", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("5e9936f2-c677-4e22-b170-3363b45e33f3"), null, "cave_entrance", new Guid("263d3b27-4698-416c-8511-0c427a3a089e") },
                    { new Guid("609844df-4cf9-468c-b33d-4114de4a7e1a"), null, "dumpling", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("64589e75-3f31-4677-861e-fe911493126e"), null, "ramen", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("695c54cd-422b-475a-916e-885816a39123"), null, "croatian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("6fc2c003-fa3b-48f2-a2ba-07bc99469ec2"), null, "bavarian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("70c92d6d-f15d-479d-b7d8-893bb29abef3"), null, "barbecue", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("72c5edaf-2b93-4305-b4ce-c0ea15b6b96a"), null, "burger", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("7382dbe1-e579-488a-bb24-99b3f61565a7"), null, "mexican", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("74b59c6f-6402-4f16-adde-564f9de9edac"), null, "memorial", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("74f37c5e-9d36-47c3-9577-75b92117a510"), null, "sushi", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("78bb5b49-51f2-41be-ae60-2936a104f754"), null, "windmill", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("7d880617-b3bf-4aa2-8f00-8094f58ce915"), null, "clock", new Guid("e6f1f837-27b6-4d0a-88ec-e66131967d58") },
                    { new Guid("80c96aac-a430-43f3-a9f6-b83b80e50e0d"), null, "coffee", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("80fdd2d8-c8e5-428a-9285-1f2d186e1235"), null, "regional", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("8253c22a-a79e-493c-b703-7ee50b9df94c"), null, "malay", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("826e60b5-eb23-453e-b4a9-91d9fd3dd802"), null, "garden", new Guid("0c4cf218-a479-4146-ba19-7fe2e733015c") },
                    { new Guid("86cc0a1c-c3e1-4c63-8749-684f2b82b79e"), null, "lighthouse", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("86f5c081-7d34-4b46-818b-6b6a3c59ac98"), null, "caribbean", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("8840e541-eae9-477c-a486-737d81935fd5"), null, "tacos", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("8c23360f-3f79-49e9-9d5a-53592a82e603"), null, "japanese", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("8d5f8d4d-3f5e-42cd-b74d-9f7ff3f4f0a2"), null, "battlefield", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("90587334-2f49-46d7-ad1f-a17b08b9e8fc"), null, "vietnamese", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("928ef710-3c21-495c-ab21-7f6f1b8f05c0"), null, "wings", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("93b89419-4c6f-4369-9c98-539f59db19a3"), null, "taiwanese", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("9a43ce83-86f0-4a1d-8cae-939787e73143"), null, "pita", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("9a73f761-720f-4a90-8d1c-8394eb4c2500"), null, "filipino", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("9ae1a758-252d-4207-895c-296228c40321"), null, "crepe", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("9b6544d2-2657-4a63-8bd5-af3c006a9ecb"), null, "kebab", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("a000ab54-1e77-47a7-ae64-2e92719995bb"), null, "malaysian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("a080d558-938d-4433-a88d-bd264c17d9bb"), null, "hinduism", new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0") },
                    { new Guid("a2885e35-a86d-4261-be97-97898656e826"), null, "bolivian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("a2b2d8d8-13de-40bc-815b-ae2db2300560"), null, "nepalese", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("a4098b34-2dac-49cf-967a-508bbc9ad8be"), null, "western", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("a915cec4-ecab-46e8-8859-22a7aa9ca79c"), null, "ramen", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("aa3e610f-7e2d-4da2-82bc-08cd71bbe453"), null, "jamaican", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("ab41ee21-1027-4004-a750-d3da1c60e4ce"), null, "chili", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("ab880187-71fb-47a5-a688-8c5c02ffe4b3"), null, "spanish", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("ace796ce-b625-4dbd-bfca-d265cd5c1dca"), null, "kebab", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("ae4e6e5b-8762-459b-83a9-94ede3f84490"), null, "tex-mex", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("b479bb2e-f4eb-4afd-ae9e-0d315eb6fc6b"), null, "afghan", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("b5ebbb17-90d3-4382-a522-6ccd750fc2c8"), null, "international", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("ba392485-9e63-4965-a9c1-fae8e79dd239"), null, "buddhism", new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0") },
                    { new Guid("bc1672d9-8509-450e-9db4-a0e0288602ac"), null, "noodle", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("bc33fddd-b588-447b-94b7-2398e7d77464"), null, "turkish", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("c12cfd12-8a1b-49ce-8adb-eaaa16a1a020"), null, "castle", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("c43e5c4a-ed3b-4782-a254-ca8d5b72036f"), null, "friture", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("c535144a-9275-40ec-84bc-470eccac336e"), null, "soup", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("c666059a-b6cb-477a-b34d-b59b8f6841f0"), null, "cake", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("c80b0c61-b325-49ba-80da-79804e9268c3"), null, "thai", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("c8961b28-6a7f-473e-b23b-c26c6fa7c965"), null, "city_gate", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("c94cd57f-bbae-46a5-a9c0-0a9303e2bff1"), null, "hot_spring", new Guid("e3af44b4-3deb-44e7-b440-3f749830e369") },
                    { new Guid("d2204bb3-328d-4111-b96d-1007af48ee07"), null, "gallery", new Guid("1fce512a-6bb3-429f-bbe6-15c57d0cb089") },
                    { new Guid("d2c95f89-46b7-4a84-8791-c7d5209bc07e"), null, "pizza", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("d42fc76a-c266-497b-8903-c0790ca51719"), null, "burger", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("d8f87762-098b-44fb-8026-55d16dbca4c5"), null, "american", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("d90f69f4-a046-46cd-ad00-8823e53e98e1"), null, "tower", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("d97914c9-3cc0-4eb4-9ee5-6531191d3dc7"), null, "hungarian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("dc881fda-1d75-438a-90d5-1a3cef2bc3b6"), null, "hot_dog", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("dd668b12-e192-4a00-b411-03cdacffd487"), null, "lebanese", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("de666230-48fd-4f70-96d9-dd4216b0ca08"), null, "indian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("deb51665-dc23-4d69-bcf3-4c0c7c49f356"), null, "tapas", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("e1ee5856-62a9-42df-9881-f15829ce3b13"), null, "cliff", new Guid("263d3b27-4698-416c-8511-0c427a3a089e") },
                    { new Guid("e24b99b0-3c07-4840-856e-15af5ad284bb"), null, "greek", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("e3021d9a-477d-417c-95e2-07629932ab34"), null, "nature_reserve", new Guid("0c4cf218-a479-4146-ba19-7fe2e733015c") },
                    { new Guid("e3d79396-834f-4606-82ea-4c9ae9c4a5ce"), null, "swedish", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("eb9aef30-7fd8-4b17-bc8c-82e4ec5c33fa"), null, "arts_centre", new Guid("1fce512a-6bb3-429f-bbe6-15c57d0cb089") },
                    { new Guid("ece27c65-a936-4524-ad12-5fef5344b0fa"), null, "tea", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("ef96a6cb-8e60-4c10-8ab3-4094be941864"), null, "soup", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("f09a1436-7b88-4ae2-a1ae-325db8c2175f"), null, "peak", new Guid("263d3b27-4698-416c-8511-0c427a3a089e") },
                    { new Guid("f0db1f9c-5bef-4508-84da-5679df64a28e"), null, "georgian", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("f22efdf9-9578-4f2b-a2e5-ff2ee53bcc77"), null, "bubble_tea", new Guid("90c079f7-e693-4132-8aa3-b09b535280fd") },
                    { new Guid("f293998b-cc9a-41f4-a344-9a715ed2496a"), null, "artwork", new Guid("e6f1f837-27b6-4d0a-88ec-e66131967d58") },
                    { new Guid("f35d974b-a4b4-4662-8afc-9407b4bfec6d"), null, "christianity", new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0") },
                    { new Guid("f8380d95-a91d-48b6-83b6-3ba44263ec74"), null, "geyser", new Guid("e3af44b4-3deb-44e7-b440-3f749830e369") },
                    { new Guid("f870fcda-59c6-42d0-9f5c-564ba8f37089"), null, "french", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("fa8fcb5c-2afa-4679-9e25-bd69fc92b458"), null, "rock", new Guid("263d3b27-4698-416c-8511-0c427a3a089e") },
                    { new Guid("fb2f8254-2e4a-4a86-adca-775bb0177e32"), null, "fort", new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd") },
                    { new Guid("fc297e49-af1b-4e27-a373-3bb7e30944c5"), null, "fish", new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2") },
                    { new Guid("fc382fa5-9707-448e-b3c7-202d0d5f7344"), null, "islam", new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0") },
                    { new Guid("fc41381a-c233-4dae-b6d6-953705f68056"), null, "sea", new Guid("e3af44b4-3deb-44e7-b440-3f749830e369") },
                    { new Guid("fd6786b5-22d2-4949-ba8d-3894e3a7f622"), null, "pizza", new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63") },
                    { new Guid("0b68a417-7786-4d21-8942-16b20ab4e7ec"), null, "shrine", new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70") },
                    { new Guid("2a4d5a70-913f-46d1-9cbd-7eefb4e75a11"), null, "tank", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("36a04e95-cde1-40ab-b8d6-0d9d942810ce"), null, "wayside_cross", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("386f317e-1a52-45ec-9a4a-0f472b08141a"), null, "chapel", new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70") },
                    { new Guid("540a2e9b-e07b-40e0-9987-fc45ad6a18ba"), null, "cathedral", new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70") },
                    { new Guid("5c31d925-a0ba-443c-b5f5-2739bd9ca793"), null, "mosque", new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70") },
                    { new Guid("5df0fe5b-f245-4b44-86e4-437ba42a9cb7"), null, "pillory", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("73387b38-0fed-4685-a301-8cc88127bcd8"), null, "monument", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("7cd7677c-9513-47e8-b4e3-7d9ced79a963"), null, "temple", new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70") },
                    { new Guid("8c61029b-ed79-419c-a2a3-9c9a2a9fa4e4"), null, "tomb", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("990d786e-349f-4a1f-99c7-8693f2dfcb67"), null, "boundary_stone", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("b4604a21-6ecd-42c4-9785-e12fc1b13621"), null, "synagogue", new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70") },
                    { new Guid("be3bf689-94fd-4c0a-bb47-d1de87d89a07"), null, "church", new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70") },
                    { new Guid("d0b04279-b835-419f-ab62-3a7e4e663d9e"), null, "railway_car", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("d9982a6d-263c-4125-977a-90a76a4cd010"), null, "aircraft", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("e4e8b46f-f267-4c9b-9e9e-1ebbad64eaf6"), null, "ship", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("fb35dde5-6a43-4d13-8444-e6259e4113f6"), null, "milestone", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") },
                    { new Guid("fd9b00d3-1a00-4123-9a37-8b0e8989c559"), null, "locomotive", new Guid("74b59c6f-6402-4f16-adde-564f9de9edac") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("018311e7-13a7-4180-89f5-56faea449584"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0242a9a4-f6a4-460b-8b9f-7381630a488a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("042f5d80-aaa2-4e2a-914c-e0cf77aa13d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05311622-0b49-4909-abab-53782cee7020"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08c0e83b-a687-40d1-bcd1-da6add618ee7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a043370-1930-45df-b8a9-ba55aff75e15"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a49a365-8128-40f6-b386-556e2d3f0821"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b68a417-7786-4d21-8942-16b20ab4e7ec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c77ea70-f680-4377-84af-289549c7694d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c97c2fd-7943-4cb2-a25f-e87f67db5245"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cb8d358-5058-412c-8f85-45ffcaf884b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e6e9a12-e017-470f-b047-d24d4ef7787f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0fe81f4b-7fe2-4f02-bf39-807fc2bb2083"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("11295290-a0fc-422a-849a-9144d83efe1d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("128899c4-6a65-45d0-80fa-cd7f8833c64d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13af932b-325e-4b4f-838c-8703a32e2c13"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("14aeba22-87f3-4078-bcb6-ee3edfb39504"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("14f62702-e753-43a9-a1f0-26d0515d5216"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1512b76b-80d0-423c-9957-513d3a8c19bc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("166e0c42-40b9-4110-b4c1-b0291e9722ac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("183e070a-3f14-4efe-b2c9-a5e72cf7d921"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1876868c-0f72-4429-bde6-47de749bf084"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("19569a3a-186c-429f-b89d-69a5590bec01"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a857a02-f360-4076-871d-9b123bb7c076"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1cb730f7-bb45-4b0e-bfed-d1817b92330a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1cc956fc-dc46-408f-afe4-d09ce730dfd6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d14f5a5-052e-492f-865c-49360b9d39c0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1e248786-a560-425e-8bed-429432e8b1c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1e718cc9-3214-45d7-bf32-a1b3c6dcb653"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("22cf2ed0-607b-43b4-9e65-d582b3a738f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("237e36ee-2383-428c-af84-1aa1d4a4b4ba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2524a761-a2f1-4864-b637-5604b8fc82c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("25c27c48-3508-4970-ac72-40df53d4f107"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("26757f01-6ef5-43b3-94c9-4f4cd62be2af"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("275c01fd-b622-4c78-ab09-992743334bc9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28116905-1807-480a-8b4a-99d47683d92c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28f6cc58-d932-4e2f-9811-20113e82a706"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("295647f6-c87d-4991-b74b-84cdc16f00b1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("297702de-f16f-4c73-b90f-d4bcf5937c75"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a1b4eca-ffc8-49aa-b535-aa8c7ccc1651"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a4d5a70-913f-46d1-9cbd-7eefb4e75a11"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b4b017b-1c69-4537-9532-2badf1f5ddab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b9ab4a7-0cf5-41d8-8fca-fa70b9039397"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2bdd3fe2-3c09-4ebe-bb04-905bd4632f48"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d4533f6-4619-4614-9cac-bc3b59d20b41"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3053aa66-f7bd-4133-8688-a729550cdfbb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("32de0c74-f5a8-406b-b486-744c93ba47ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("33f8ebd2-ae7c-4609-aa69-51ca6d8b8a7b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("342b21d9-e602-4642-8195-e2d1e561b060"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("34457d77-0d7d-4880-88c3-8ff3560d58f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3514d0b1-3562-43af-8e4a-7933055c0814"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("36a04e95-cde1-40ab-b8d6-0d9d942810ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("36dabfa7-bbad-4be5-8052-a53ac86c45e3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("386f317e-1a52-45ec-9a4a-0f472b08141a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38ffa513-bd22-421c-bc2e-1662e33f061f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ca0c6c6-1ed9-498d-b46a-93c832c508c7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3caefd09-7c97-4b24-a1f1-ce28cb579e24"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d9816a9-9766-4541-b51e-7d2fd08bdee8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("400b820f-e9be-4a1f-902c-db3cd90cb5ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41843917-ac17-4e2e-ab99-094df9bea8d1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("420a8b0a-7205-460c-b51c-ff35a6adfe81"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4219abf1-e5d4-47ba-9119-40cc60e3e589"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("43faa45f-8ed1-4e0c-9935-2c48bb73f544"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("44d97e4a-36c5-4c3e-a2e8-bfe8aaeb1084"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("46f3cd85-ef35-423c-a1dc-0adabdac1d3f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("48720064-31f4-40af-b933-1f299abff3a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("489ee6c7-a1e3-45ac-8b7b-f12b6fc03381"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("49c4f75e-2d3d-427f-a6a0-9b018b86d690"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f6048b6-9f57-4bc3-aaf4-61cfeec0596d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f921a2d-b60a-43e5-b169-6a777b19cf25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5013b198-e2a6-4e6f-8f3b-c256fab6015e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("519f8c83-427b-439b-b013-dcdefec6184d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("540a2e9b-e07b-40e0-9987-fc45ad6a18ba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5475fdb7-04cf-494f-9b1e-e63724a358a1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("56d68ab3-72cb-4274-ab57-fefd70bbe906"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("586ca75c-b80f-4367-9a41-d5d63696e237"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58ceb6b4-0bcc-4d7f-912e-b1e079913376"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("59e232aa-ddc7-426a-8cb5-d926bc60b4dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c31d925-a0ba-443c-b5f5-2739bd9ca793"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c5d6f73-8615-4081-9e8d-68e41313175d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d240ddc-5da9-4d5a-88be-ae8b4b86d2b5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5df0fe5b-f245-4b44-86e4-437ba42a9cb7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e9936f2-c677-4e22-b170-3363b45e33f3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("609844df-4cf9-468c-b33d-4114de4a7e1a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("64589e75-3f31-4677-861e-fe911493126e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("695c54cd-422b-475a-916e-885816a39123"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fc2c003-fa3b-48f2-a2ba-07bc99469ec2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("70c92d6d-f15d-479d-b7d8-893bb29abef3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("70cf0a05-7551-4db8-85c6-e34739e858c1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("72c5edaf-2b93-4305-b4ce-c0ea15b6b96a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73387b38-0fed-4685-a301-8cc88127bcd8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7382dbe1-e579-488a-bb24-99b3f61565a7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("74f37c5e-9d36-47c3-9577-75b92117a510"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("78bb5b49-51f2-41be-ae60-2936a104f754"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7cd7677c-9513-47e8-b4e3-7d9ced79a963"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d880617-b3bf-4aa2-8f00-8094f58ce915"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("80c96aac-a430-43f3-a9f6-b83b80e50e0d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("80fdd2d8-c8e5-428a-9285-1f2d186e1235"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8253c22a-a79e-493c-b703-7ee50b9df94c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("826e60b5-eb23-453e-b4a9-91d9fd3dd802"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("844267c5-09d8-47c3-b5c5-d9bdbf901452"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("867660a2-4412-43f5-96d3-786c58afdd2c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("86cc0a1c-c3e1-4c63-8749-684f2b82b79e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("86f5c081-7d34-4b46-818b-6b6a3c59ac98"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8840e541-eae9-477c-a486-737d81935fd5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c23360f-3f79-49e9-9d5a-53592a82e603"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c61029b-ed79-419c-a2a3-9c9a2a9fa4e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d5f8d4d-3f5e-42cd-b74d-9f7ff3f4f0a2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("90587334-2f49-46d7-ad1f-a17b08b9e8fc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("911848ba-669e-4f16-bd13-73d530a2a423"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("928ef710-3c21-495c-ab21-7f6f1b8f05c0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("93b89419-4c6f-4369-9c98-539f59db19a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("990d786e-349f-4a1f-99c7-8693f2dfcb67"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a43ce83-86f0-4a1d-8cae-939787e73143"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a73f761-720f-4a90-8d1c-8394eb4c2500"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ae1a758-252d-4207-895c-296228c40321"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b6544d2-2657-4a63-8bd5-af3c006a9ecb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a000ab54-1e77-47a7-ae64-2e92719995bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a080d558-938d-4433-a88d-bd264c17d9bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2885e35-a86d-4261-be97-97898656e826"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2b2d8d8-13de-40bc-815b-ae2db2300560"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a4098b34-2dac-49cf-967a-508bbc9ad8be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a915cec4-ecab-46e8-8859-22a7aa9ca79c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa3e610f-7e2d-4da2-82bc-08cd71bbe453"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa9f130d-ee43-404c-b322-ac7a3f03a4e7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab41ee21-1027-4004-a750-d3da1c60e4ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab880187-71fb-47a5-a688-8c5c02ffe4b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ace796ce-b625-4dbd-bfca-d265cd5c1dca"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae4e6e5b-8762-459b-83a9-94ede3f84490"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b4604a21-6ecd-42c4-9785-e12fc1b13621"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b479bb2e-f4eb-4afd-ae9e-0d315eb6fc6b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b5ebbb17-90d3-4382-a522-6ccd750fc2c8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba392485-9e63-4965-a9c1-fae8e79dd239"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc1672d9-8509-450e-9db4-a0e0288602ac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc33fddd-b588-447b-94b7-2398e7d77464"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be3bf689-94fd-4c0a-bb47-d1de87d89a07"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0ad70a5-81d5-4bb2-9267-d0d69d561df8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c12cfd12-8a1b-49ce-8adb-eaaa16a1a020"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c43e5c4a-ed3b-4782-a254-ca8d5b72036f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c535144a-9275-40ec-84bc-470eccac336e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c666059a-b6cb-477a-b34d-b59b8f6841f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c80b0c61-b325-49ba-80da-79804e9268c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c8961b28-6a7f-473e-b23b-c26c6fa7c965"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c94cd57f-bbae-46a5-a9c0-0a9303e2bff1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d08fa497-6b2d-40a3-87ed-bb38ee0fea0a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0b04279-b835-419f-ab62-3a7e4e663d9e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2204bb3-328d-4111-b96d-1007af48ee07"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2c95f89-46b7-4a84-8791-c7d5209bc07e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d42fc76a-c266-497b-8903-c0790ca51719"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8f87762-098b-44fb-8026-55d16dbca4c5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d90f69f4-a046-46cd-ad00-8823e53e98e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d97914c9-3cc0-4eb4-9ee5-6531191d3dc7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9982a6d-263c-4125-977a-90a76a4cd010"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("da77a095-cbbd-4c98-a902-0f84055f4584"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc881fda-1d75-438a-90d5-1a3cef2bc3b6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dd668b12-e192-4a00-b411-03cdacffd487"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("de666230-48fd-4f70-96d9-dd4216b0ca08"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("deb51665-dc23-4d69-bcf3-4c0c7c49f356"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1ee5856-62a9-42df-9881-f15829ce3b13"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e24b99b0-3c07-4840-856e-15af5ad284bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3021d9a-477d-417c-95e2-07629932ab34"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3d79396-834f-4606-82ea-4c9ae9c4a5ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e48cad10-4d1b-4cc6-add4-885feef50159"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4e8b46f-f267-4c9b-9e9e-1ebbad64eaf6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb9aef30-7fd8-4b17-bc8c-82e4ec5c33fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ece27c65-a936-4524-ad12-5fef5344b0fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ece5390d-4b3c-400f-8bf4-1605c9f55cfe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef96a6cb-8e60-4c10-8ab3-4094be941864"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f09a1436-7b88-4ae2-a1ae-325db8c2175f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0db1f9c-5bef-4508-84da-5679df64a28e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f22efdf9-9578-4f2b-a2e5-ff2ee53bcc77"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f293998b-cc9a-41f4-a344-9a715ed2496a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f35d974b-a4b4-4662-8afc-9407b4bfec6d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4fc246f-7134-498c-96c1-5a98c099e70d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8380d95-a91d-48b6-83b6-3ba44263ec74"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f870fcda-59c6-42d0-9f5c-564ba8f37089"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa8fcb5c-2afa-4679-9e25-bd69fc92b458"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb2f8254-2e4a-4a86-adca-775bb0177e32"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb35dde5-6a43-4d13-8444-e6259e4113f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc297e49-af1b-4e27-a373-3bb7e30944c5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc382fa5-9707-448e-b3c7-202d0d5f7344"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc41381a-c233-4dae-b6d6-953705f68056"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd6786b5-22d2-4949-ba8d-3894e3a7f622"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd9b00d3-1a00-4123-9a37-8b0e8989c559"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("00c14653-bf53-4f7f-8ba2-37669349acdf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("0b34be59-0e52-44c5-913a-4d19e93d892d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("138fcc37-b542-4003-aff2-4494a3016b2a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1bebe484-1eb6-4b3b-bbbf-c81fb17bea09"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("21b64080-c3bd-4b4d-95b5-8674b0b8d9cf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2eac092e-50d1-4b36-91d9-010467a17851"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3a43d93c-7cce-4d70-be89-919cf498a089"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4eae57f5-9412-4265-96a2-d506a6a7ee83"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5a74f465-9782-4c21-a83f-3e2a68e3c342"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5ef2acf6-3025-434e-8b18-c81bdfade9be"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7969af05-ac3e-4799-adbe-7503930c5a04"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8ba56bb8-73c3-4fb3-8f24-930194488412"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("900576b0-a1fd-4d09-a44d-dd26a588f3a7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9884911b-2b07-4f32-b011-08814a6ffbc4"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9c9b18c1-95f6-4843-852f-a6fc8c7fd609"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a45e4586-0377-417f-9dcf-b4b7210cebcc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("cc583591-783e-45dc-b6c4-09ad83eb7ec7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d7af5444-92ba-487d-abdd-c3b369daa724"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("db2a8f4c-0983-4f60-a70b-286ee830f114"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("db42388f-6ca1-4f12-8696-da521608565a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dfe55c11-9a8a-4340-8c62-aabb6c8e5cd5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e6725786-59d5-4b30-98f1-ab4a3cf698f0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ed7f9e38-ed50-4565-a198-5a3623d144bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c4cf218-a479-4146-ba19-7fe2e733015c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("19894eb7-39d1-47e3-8454-0c4d68527a5b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fce512a-6bb3-429f-bbe6-15c57d0cb089"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23bf6eb3-ce6d-4347-b5c2-3ec4013fc651"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23c97439-cc36-4f6b-895c-d5f12a103d70"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("263d3b27-4698-416c-8511-0c427a3a089e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6aff0066-ba17-452b-ad00-cf462e5bb1f2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("74b59c6f-6402-4f16-adde-564f9de9edac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("90c079f7-e693-4132-8aa3-b09b535280fd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba101896-5756-4d3f-a41d-cd9e9af87337"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bad5faf9-9b94-4e1e-b283-f8bf9653bc63"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3af44b4-3deb-44e7-b440-3f749830e369"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6f1f837-27b6-4d0a-88ec-e66131967d58"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6f3bdee-a671-4222-bce8-d21214dec7b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8377a70-cad7-4a02-b85c-c95a33e6d4ed"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("01a6fe1e-cb4a-446a-9ec3-d4d6837c0586"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1004f21a-3b58-432e-a1fc-59985a9c62ba"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("19a8f25d-f8ff-4c79-a33d-8c3d111bb176"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("61127822-5617-4d1c-9c31-0b7f4796a8f9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6ebeb7d5-cc6d-4f54-80be-d97cab2f4ded"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("70f095c3-7e25-481f-af3b-8e155fc2bff0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8871d628-3998-4a54-b0ef-73447a083791"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8d4b5068-3606-4ff4-97a7-cd492f22ec44"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d75b8d60-d903-4d9b-8332-1e7cd9a1f75f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d9d76027-4d00-4d84-8a4b-acd90d64e678"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ea12ed58-5ea6-4b17-bac5-384d5522a1d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2cccac70-772e-4bbb-be9e-c13f238b5a43"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c7e3e33-04f0-4b60-8d61-f00f31b940b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("86856aaf-a1df-47c2-9b6e-cd37147519dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c30d8cc9-d9d5-4e2a-bf47-3388012c1dac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cff33750-d418-4195-9a90-75bb7217f84a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2ee336b-f36a-46cf-8cb6-895d975e8e1e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7b88b3f-9fb8-4d63-a532-481015ca3650"));
        }
    }
}
