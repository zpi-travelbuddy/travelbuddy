using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelAndAddPastTrip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripPointReviews_TripPoints_TripPointId",
                table: "TripPointReviews");

            migrationBuilder.DropIndex(
                name: "IX_TripPointReviews_TripPointId",
                table: "TripPointReviews");

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("013a2825-9f01-4760-a7a7-fc4d14d3850b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("018f9dd1-edda-4cd8-bb46-bd00f87a8e96"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05f80f83-1168-43cd-8ee3-074375001efa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("06420f8e-2e7e-4b09-818c-a6a2921f3403"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("09eee82e-3c09-4c0a-905a-90cb9b01391b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a3a0e12-861a-4783-84e6-c70440eb6f8d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d0e2c46-9fa3-4e3a-b07f-7b6f25c7786f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d1995d5-4f5f-4fb5-b6d9-5eeca2194019"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0dee3ea1-3a21-4a0b-8501-9de4dfd001ec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12cab8c3-11ea-447a-b168-f0f0f9384584"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13a39a4e-2ea9-4546-995d-214eb9800186"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13aa4762-b2e8-4f54-846f-24985e7da0b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1415a474-b2e2-42ec-9635-ff735c6099aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("159b9b5e-250f-4096-857d-53b923c31afb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("16138026-f801-46ac-8931-eb0c35c39cf6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18ff8d74-5aed-4cdc-a7a4-ab429648288b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("19c1b727-d694-4249-9fc3-eb87fc5af093"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("19d69886-5a91-48a8-b5a8-f680f8681077"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c2fbdbf-f730-450c-b25c-9dc716b7a45b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c6cd8c3-b4e3-4440-b75f-286c7d6dc9dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("22594842-4184-4cac-984b-69968644456e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("22af9e75-db53-41ca-b2e4-99d576f2e7b8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("236102cd-77d6-41e5-80c9-1904a05b5a13"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23aab49f-6fba-4726-b28c-d418c5a47bfc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23bc663f-63ea-406b-88b1-86aefdd026b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2563b037-01d0-4edc-87ce-6a43d5d6a7e7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("25caa567-584b-4b47-ad95-7ff7d2237584"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("268f25d7-7473-434f-8899-3715b5891653"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("271937d3-0210-45ec-bc00-d5cc7facdf63"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2748485a-ff8f-446b-bfd0-735e6292ef56"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("274ce82f-f222-49c4-8aaf-d499b848eab9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a9bed78-ccc7-427c-893a-b55dae165090"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b9d6be0-bd9a-4225-a8ec-8ba52faea4b6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c2b651f-a3b0-493b-8643-7cc65f2eb999"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2fab3743-982d-4c4d-ab54-5aaa86733f64"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2feca23f-8e4e-4c52-bafd-cb521b650ba6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31313e82-a835-44cc-80f8-f23a46fbe436"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3154c8a3-d141-42f3-85f3-93adaafaaff5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("32ad21a5-a2f1-4522-94da-f5b14a29073d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("33869efb-3fc5-42bc-b342-549303dfb689"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("35048098-b9b7-4815-a5fb-15e3df220bf5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("363cbff6-68b4-4564-941a-ae52e5287368"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("384860fd-e710-41b8-82d8-af5200554dc5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("39915d82-104e-4a33-a130-62e9922e8127"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3bb754c2-141c-461d-9e33-6e5efbad0eb5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3bf5c4e1-6e0d-4ca5-aff2-6a8fc45f9b7f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c4cce2b-8cc5-4457-b875-8cb01627e22e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d052a8d-7e73-48af-9323-f4f096adfd1c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d93bc44-975f-4d26-8851-bf3f0502697b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e958eb4-ef0c-4fad-86dc-8a16a99d98f3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41e6630a-bc9e-46fa-9959-e0bc821638f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("446b0f3e-29ed-44fb-8195-3461326f3a96"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45b45f14-0799-4ce8-a137-2ba408108455"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("46624022-60be-498f-8bab-fc297ab42196"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("468d2c48-3389-4511-9b47-221cd1ec055c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4842ef3b-6614-416d-a6b5-be1b6c7d3f50"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c4af931-e9bc-4a1b-ba2e-69bb138d66ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4e6fdf4a-3d79-49df-8b02-c99194b88817"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("50b27744-7121-4e56-8eed-dceccfc1979a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("515f3aff-41b8-4162-96c7-6e3e4ddcaf73"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("517fef41-3524-4768-aa50-c19ca7765c2e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51b96b42-34ce-4c77-9b2e-05bd14afb9e0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51de9c3b-0741-49f6-99f9-aabf8f9d966e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("53b7a4cb-4f87-460d-b9f9-30721b3cb0df"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("568b77d6-721f-4560-a879-fd5fc7b0e346"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("57aba794-f801-4ab5-b4f6-9b95a746f8f3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58faa8ea-f88c-42d9-a458-00a0ae0c38a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("59e2cb30-0ef5-4354-a868-63d622bae041"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a143e7c-659f-4840-bfb2-e25913b3ecbe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5ad313b1-d0ea-4fa3-8ae3-eff538e39728"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c8d619d-5b79-4c57-9516-94c08cbb8438"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5cb566db-7045-46ac-9aaa-7e8aaff191a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5cc9ccbb-787b-471d-833d-a0ac23c14b8e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e174085-60a6-4178-9096-ccafaf01f964"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e563109-0dd1-4b60-832f-fd5bcbd7a002"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5ebec78e-2baa-40a4-8596-47c31b48f1ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5f7c22d5-e3d7-43eb-a302-79425e821b77"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("613deee1-1e52-48a9-91f0-5efc3e63decb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6194ae5f-71b0-4c9e-8e87-885139e47149"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6344d487-77d0-4ab4-a8d1-a6b764188c03"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("63db8c6f-9b8e-4a6e-bfa9-ea9313ba10a6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("645b50c9-0ae8-4bf7-8945-5a3be83987cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("66d193b7-298b-4ab2-a6b0-1660189a79ed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69b92d0a-ea7e-4742-a71c-5c73a34148aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a5ac8ab-ef60-477d-bc7a-93b026aac2d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6abee01d-749f-4d8b-8500-1729c250015b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b53f39a-dbb1-4691-a34f-d6f4c9c8387e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c14a33b-b50e-44ad-bad5-e81e8a6220c9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c68704a-ce97-48a1-b8a0-8e58daae7ff2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6cea8284-d1a3-41ad-b01e-9f954cac04e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d0980e6-4e55-4513-bb0e-64301cc3e489"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ded772e-0631-493b-8bec-1fdbc36bcfae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f19f9e6-9ba3-4cc4-ace8-76899d2a7b7b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f9b676f-47d8-4b9c-9908-04a08f2afb7a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("71f9ba76-b5d0-4423-9bcb-91467e79de69"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("722406a0-27be-44c0-ad73-bced422d2daa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("74856229-2665-4329-8ebc-5b9c66974815"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("75f15c3d-4ec2-45ef-b249-974800633ac6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("760728e0-dbb5-444c-b425-c57738220572"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a4ed036-c382-44a7-bd38-79ad59bf9995"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bfe4741-edce-4762-8985-b2e700eb1726"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e76c7de-7049-40d1-95cb-e6195cd78079"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ec8d765-84dc-462c-b796-3da21dd2ea85"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ed68025-5c5e-4e1e-a27d-4443773a18c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7f81d157-84fa-4e1d-bbe0-ac00ed3ce5c8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8103820e-0e91-493c-a0c6-be673c7e7fe8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("823b99e4-96f0-427b-8dfb-39fb228db8c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("828c02e3-eab1-4cfc-a65b-c9b13701caa6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83ad9f02-8b8b-410d-a78f-6d9dc91f67b6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("84786c4b-bb6a-4500-8c3d-806a737c3208"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("84e7a77e-1f0d-43d1-91c5-585aade68f56"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("86937121-8cf2-413d-9651-74793b9637e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("876f470a-0b07-4dd3-a746-b5d6d3a55777"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ae41d5f-c7ff-4c78-bdc6-d40d38018f22"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d87784d-0219-4054-9e56-85207fce1fde"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8dfe6a43-9640-44fe-a497-d195b6f908eb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e3dd8e9-dddd-401c-8964-95d230797bda"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("90009a3f-4c2f-4f90-99a6-fd97b4b50764"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("94f311b2-c722-4bb1-aeaa-a3c9093dd461"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("96348313-e435-4ae9-9dfb-a066308d016f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("963e1214-30b5-4fe0-b208-c8cffdb60631"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("969a4f41-39a6-414f-bf4a-e4fdbe46851e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("986edc7d-e2dc-4d07-a262-1ed3dd93da0d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("98b5ab11-70f1-4268-b3d7-22d19dddb18d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c7c7a67-ae6d-4ba7-ba70-5725eeca07d3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ef8cd56-41ff-4394-973b-8ebd5a3b5969"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0e1f6ec-5f0d-4324-bb3c-72b57d522876"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2f1d4b4-63c6-429e-b1a2-8b9994399565"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a304c5bd-439b-40bb-9bef-20b9edced420"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a6698a84-1f02-4c42-8e4d-e8ab533fafe0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a71392e2-d172-4733-b2b9-0941f43445a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a75a7dcb-f8c6-40b3-80ce-c6355ff45b5a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7c60674-82db-48ee-8781-0aaa4067c540"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8edc9dc-b352-4479-872e-8ae6f15f2dbc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9a276fa-28d9-4cc2-80fc-c84345702fd1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9d829c5-2627-4c77-a468-935a8eb2315a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab03490c-0e99-46dd-9ecc-be661f80c9bc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac7cd707-fe33-4b82-a540-56d7db988ad5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad522001-3091-449c-be67-b5c36a585c80"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b188811b-fc11-4f35-817e-410224966b12"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b23a5bab-8c23-46cb-89a8-fffbcf95def4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b23aced2-1d32-4e10-b18e-0f6249f96708"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b58d7963-dbef-48d6-977b-78bb917ed05e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6123e06-c37f-4da9-87e7-3cd09a6f5e7c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6b552cf-9587-46b1-a57c-2e842bfa9f2e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b873c487-8827-4857-abb5-9eb680b5f0ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b928ba1b-d802-4f9e-8163-1d3d70c9bab3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd208401-681f-4a47-b394-a781eaf91e87"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf334930-638f-4988-8590-9aba44533ea2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c192e66f-7ff7-443b-a14b-9439b3d854a7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c32ca54a-0919-4d26-af6b-8c19724d9402"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cba641d1-0907-40cc-b65c-06bd0576d88c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cda3a7ac-d48a-45ae-93aa-cdd394082418"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cdbde128-b2e3-45fe-8282-479660f0ffad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf14b5b6-17c5-466e-94ad-5331fdca0db9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d274a67d-336c-45b1-b4e0-73da0803d227"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d465dd37-b50f-4294-bddc-c37536fcfa36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d4746dfb-ba14-4e83-b80e-3ffa403c7578"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d6466a96-9b0c-4eb8-8280-e69268a5e032"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7d984bc-2960-4c73-9c3d-e14c1e1c49bc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d95ebe55-6407-49e4-81e5-0b02270a4c80"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9b9723d-06d5-4b3a-b85c-155e8592bfeb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("db541c56-f4b2-43cc-8e1e-0e1f8980fa1e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc76428b-2a2b-4970-a29f-dad6956460b9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dd642cd8-47b6-48ae-b452-6c8ca8e9b4a5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dfb735b7-b09d-4d02-8d21-811e3460db44"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0abb266-8330-46b1-bf99-5cf50b2b00a6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e5b08dd8-25c6-4b4d-8f69-4265ff8a2241"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e5f5df25-c64d-4d11-b06f-bfed37235754"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6117c3f-4b47-43f9-951b-41623a2b064c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6a814e3-7a00-4607-a877-4e0da36cd4bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7aa451e-fac6-4d68-8698-2ca6094b1cb3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e8af69c8-b38a-4567-b242-2d720a54e20e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e90b7771-3b1e-4f64-af11-0faac275debe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eccb7d1b-c510-4ba9-9993-936734a4b65b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("edebeef4-d0b0-439d-b04c-df9224903c5d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee633848-6cd8-4295-ac5d-3649f240c954"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef0e8f16-58b7-429b-95af-07733f2386e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f002f885-8838-4d7c-8ea5-03c554421fa5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6a81e7c-d360-4a3a-80b6-9f46c129ab14"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8611f7e-b37d-4006-acb1-f72d9374f15f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fabcaf57-d87c-4a70-b85a-33b3bd3d5c7a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fea3d392-7441-4041-addf-65ed5a69048d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("21503305-83bb-4552-b4ca-e0029f8ddd76"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("21e6b4ff-1be2-45e1-9873-f40a8a91db2b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2530de8b-86ed-4181-a800-c0fe44b4117c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("260ee7cc-e3e5-47e0-a777-2663e3f9bb2e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("38c0e921-8163-4d71-aae5-236031cac899"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("450a21e1-be40-40d8-a155-9bb050beb2ca"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("48b1bb7b-1e66-40a3-a202-446e2dee10ca"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("648beda9-9f4e-40f9-9c7f-61bf32ed9a82"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6e6dbb45-9e71-4253-a578-b3a96d061316"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6ff8b746-a9e6-4ada-b940-94706f5f1b57"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("73542cea-3730-4282-98b8-60be344bcda0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("845712ba-a88a-4989-a40b-301fae512ab6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a2bf258e-0b72-4ce8-8192-209d9c1b9944"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a861d30f-d4d2-4ad3-b902-7557864302f9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("aa60e7a5-ed28-4b75-8fc2-97a8996fd81b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b39bfb4b-1d39-427a-a43c-05a04a4e7163"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b9805432-53d7-4725-9095-0996ea7d8c59"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("db9be5f2-f3e5-4438-aceb-1b1eaa02f94d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dbc945ad-950d-4e49-8384-eac52e9f9022"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e12dff0f-c2f3-4d7f-87f6-f76f96b9771d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ee4b6987-8721-4300-b2c4-40c11f1493f9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f134e68a-dc4b-4415-9354-21c1c4990d2b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ffaaa913-cbce-4898-87f3-50d6b1faa382"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce"), new Guid("4e13a368-da09-4c09-a15d-d04b1d3c7187") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("60181110-8590-47ca-93de-87cfb0e7d9cf"), new Guid("ca730bb3-ed49-4089-9173-89e888ee142e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("82683e34-046a-4820-a729-94496bbf0db5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("ca730bb3-ed49-4089-9173-89e888ee142e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("82683e34-046a-4820-a729-94496bbf0db5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("ca730bb3-ed49-4089-9173-89e888ee142e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("acd429d1-2735-45bc-9242-49a09ba19ad3"), new Guid("ca730bb3-ed49-4089-9173-89e888ee142e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67"), new Guid("4e13a368-da09-4c09-a15d-d04b1d3c7187") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), new Guid("82683e34-046a-4820-a729-94496bbf0db5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("2ddfeec2-e0a8-4bab-8002-81989d75893a"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("38a7f3d4-90f9-4c56-8ecf-595228fb40fe"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("54f55648-cf3d-430c-8f5b-882d2903d1f7"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("6979489f-20c1-4507-958e-5e09518cec8e"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("8d06c9f1-0dfa-4cc2-a0d1-2ed1478b456d"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("deaeeef0-3763-49df-973e-19c483191140"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("b039d988-27d3-4f6a-a116-275f18789f2e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28d5b991-73ad-447a-8826-7378832e5236"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("552ce0d7-b2e7-45ed-8703-3f7b04f6f70e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("60181110-8590-47ca-93de-87cfb0e7d9cf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ad84070-41a1-4897-b7d6-fa9e4f60f3de"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("acd429d1-2735-45bc-9242-49a09ba19ad3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b4b22662-74a7-4b20-b0eb-365129ada511"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b580a409-9c40-4ab4-9a4d-0f39e091a39d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccc222d8-07a7-4e3d-a20c-f61846dfc6bd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce69dd1c-5750-41c8-b924-357ec4398ada"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("daa3ceff-177a-47cc-8af1-4b103eac66c9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc4c37b7-2c8c-4837-b39c-4a8d70e802c2"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("08fbdb8a-f6b1-4323-82c7-af1c982928ad"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("17ed99dd-c1ea-4527-86c5-42c0512e3c80"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("69641d1f-b6e9-432a-b8bd-a09778261991"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9efcb48e-2462-4455-8623-78127faff7b4"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("afb0fc07-286b-4878-9516-41edf7d90b1b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ba2b4316-94c8-4c34-9cc7-c024e6a70cc4"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("da7cbc5d-678c-476d-a4f6-c88cdb4749c6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dd37ea3f-02fd-42e9-b124-8a635ab87528"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("eaff08bc-8878-44f7-9f0b-3a6a9a088239"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f3e21044-0c33-4dc3-9ee1-69072416b2f1"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fc588292-bf79-4cf7-87f3-a37b25470f61"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("ca730bb3-ed49-4089-9173-89e888ee142e"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("0217a31a-8a85-4bf4-b760-4064a0a726f5"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("2bb551ef-4529-407a-94b6-5d85c1e1311d"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("3fdc2ecd-af6b-417c-b2c1-6caecaba728d"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("4a9e7960-6819-4455-b809-33b26760c7bc"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("5d73540b-1ead-424f-b2e0-b81f463a1b7e"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("d012dffc-b063-472e-9f3b-c97b52a214ae"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("dd651955-e2ac-4b3b-a783-a6af764c3a31"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("e95390c4-27e4-4874-a868-0cdf210f0a13"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0789f9b3-9128-4993-9344-92854163c40e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d2a6b57-48a9-4aed-af20-ae17faa0013b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a187c81c-52a6-4946-b777-815f03eda525"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e20fa339-f829-4a3a-a0c6-b93c31eeeac7"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("4e13a368-da09-4c09-a15d-d04b1d3c7187"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("6ecdc831-a2ad-416f-af44-f1ac7016961a"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("7d50733b-dcbb-4eda-a286-5764d1902831"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("82683e34-046a-4820-a729-94496bbf0db5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("d6f89f49-a10c-42ab-af9a-b75b66b39752"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("4ed76fd2-cbcc-4e6b-857d-e0d98c14c4f5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("18d5d777-9ffe-4453-ba97-1f8fd4566055"));

            migrationBuilder.RenameColumn(
                name: "ActualCost",
                table: "TripPointReviews",
                newName: "ActualCostPerPerson");

            migrationBuilder.AlterColumn<Guid>(
                name: "TripPointId",
                table: "TripPointReviews",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("077b8a92-baf0-4a35-894e-ea3942cb5412"), null, "leisure", null },
                    { new Guid("3a1a34f2-c8b6-4950-96ad-0c513a972ee9"), null, "sport", null },
                    { new Guid("4b94397a-d6d8-4811-9c00-5b1392618373"), null, "natural", null },
                    { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), null, "tourism", null },
                    { new Guid("6a5b1b6d-a6f7-41fb-8277-00756aba33bb"), null, "activity", null },
                    { new Guid("7c938f9f-4edb-427c-9820-d35cf87d029d"), null, "commercial", null },
                    { new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967"), null, "catering", null },
                    { new Guid("b313ba91-7573-434e-9b17-3afb7f14d2ac"), null, "entertainment", null },
                    { new Guid("d0ee8558-9c05-4bf8-a0a3-ad304a3762d3"), null, "national park", null },
                    { new Guid("e1198615-570f-4b90-b9fc-5dbf87925416"), null, "heritage", null },
                    { new Guid("ee552c9a-2a04-4618-9480-9da2e0652f23"), null, "religion", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("001c0229-da10-4d73-8771-85a0e0576cd5"), null, "dogs", null },
                    { new Guid("15c7e04a-722f-4cf3-bbd9-4ca75668d4cf"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("17b35de2-6c0e-4b2c-b10e-79d88ae6a3cd"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("187d1349-7600-46cf-9649-a7777f0d2774"), null, "no-dogs", null },
                    { new Guid("24c5555a-4e95-45e9-bf34-dc48c7ab9939"), null, "access_limited", null },
                    { new Guid("307b93ee-fe43-4036-ac59-81def692efd6"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("3b92f090-098c-4538-9ddd-204bffc5e44e"), null, "internet_access", null },
                    { new Guid("496dd4fe-1d75-4ef6-bcdf-a388cbc97762"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("5f6ecfa1-5e4f-45ce-88a0-bee75f0c0cd6"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("5fe767cd-379a-4749-9fae-660ac179d0a8"), null, "access", null },
                    { new Guid("67efb514-c4f9-4da0-8d47-bdee37851157"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("7706dfd1-e9ce-4214-99b3-2fee4fc51003"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("81399a72-93a9-49ba-bbb5-c58a6caf298a"), null, "fee", null },
                    { new Guid("9385a302-4fbd-4b26-99d8-3abeaa503177"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("967944e4-83e6-441e-86d4-dd1a46872488"), "Name property defined for the place", "named", null },
                    { new Guid("a280fb78-a6e9-426f-a38c-b10f2d4111ca"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("e1befcf0-6e2b-4caf-9876-45a8b2c26c1d"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("ff87a791-7b77-4e82-8fef-f07b22389963"), null, "wheelchair", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceCategoryId", "PlaceType", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("0b982120-735b-4e9b-9207-609ead4d5d85"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", null, "CustomPlace", null, null },
                    { new Guid("1676d649-c588-4c58-9ba8-c4d2de9cac94"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", null, "CustomPlace", null, null },
                    { new Guid("246557ac-83d5-4de5-b07b-eedbadaec443"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", null, "CustomPlace", null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceCategoryId", "PlaceType", "State", "Street" },
                values: new object[] { new Guid("4c8edabc-a963-421c-89f3-48100e9ef2d5"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", null, "CustomPlace", null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceCategoryId", "PlaceType", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("7b844144-9588-4f3c-af8d-543e2eee08b2"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", null, "CustomPlace", null, null },
                    { new Guid("7ca764b2-8522-49da-be1b-31e403f03634"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", null, "CustomPlace", null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("8a5473ad-60ef-470b-a49d-e02c1c51b812"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null },
                    { new Guid("ad31748c-a335-42a9-a446-e7803879681b"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null },
                    { new Guid("b6537ae8-16a8-4d6e-84f9-77a717e7e0ef"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" },
                    { new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea"), null, null, null, null, null, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", null, null }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("050470e6-150d-41bd-b76a-f238f1af066d"), null, "taproom", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("058d69cc-01f6-4485-889f-bbda37f6a5c8"), null, "sand", new Guid("4b94397a-d6d8-4811-9c00-5b1392618373") },
                    { new Guid("06a105f0-6a39-459a-a489-21454af03e9d"), null, "planetarium", new Guid("b313ba91-7573-434e-9b17-3afb7f14d2ac") },
                    { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), null, "sights", new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9") },
                    { new Guid("1b1dab12-2701-4a1d-b908-1b281dd864c6"), null, "attraction", new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9") },
                    { new Guid("269268a5-538e-493e-ae05-4f0d3009cd86"), null, "zoo", new Guid("b313ba91-7573-434e-9b17-3afb7f14d2ac") },
                    { new Guid("397baa3a-13cf-4db8-95e8-99855d7e443f"), null, "biergarten", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e"), null, "fast_food", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("44b1643b-a834-4428-92df-8b5341ae4d2b"), null, "food_court", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("4c84ab0b-7e7b-4fce-9764-a855b1468391"), null, "unesco", new Guid("e1198615-570f-4b90-b9fc-5dbf87925416") },
                    { new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8"), null, "place_of_worship", new Guid("ee552c9a-2a04-4618-9480-9da2e0652f23") },
                    { new Guid("6685ae02-318c-45e2-9405-b42f75ffd166"), null, "forest", new Guid("4b94397a-d6d8-4811-9c00-5b1392618373") },
                    { new Guid("6fc4cce4-426d-4ded-8503-5eb183565e98"), null, "water", new Guid("4b94397a-d6d8-4811-9c00-5b1392618373") },
                    { new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737"), null, "cafe", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("812e3e6d-e5fb-4f37-9f80-f510599a02e2"), null, "mountain", new Guid("4b94397a-d6d8-4811-9c00-5b1392618373") },
                    { new Guid("ad6bd65a-2721-47ee-8d8a-fcaa7a663651"), null, "aquarium", new Guid("b313ba91-7573-434e-9b17-3afb7f14d2ac") },
                    { new Guid("b0d8e732-f9d6-4d69-a908-b464237eab75"), null, "art", new Guid("7c938f9f-4edb-427c-9820-d35cf87d029d") },
                    { new Guid("b589383f-afb7-497c-b09d-74017876afe9"), null, "ice_cream", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("b95923db-a55b-4eee-8ca7-ac35e7bfd56c"), null, "museum", new Guid("b313ba91-7573-434e-9b17-3afb7f14d2ac") },
                    { new Guid("c973a5c3-cc01-4488-a20b-c66af71c3368"), null, "park", new Guid("077b8a92-baf0-4a35-894e-ea3942cb5412") },
                    { new Guid("cadb043a-b9a0-42ba-b739-004b94a8b270"), null, "stadium", new Guid("3a1a34f2-c8b6-4950-96ad-0c513a972ee9") },
                    { new Guid("ccfb4668-f954-4714-9ba7-a6bfe9f3a877"), null, "bar", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("dcf1c33f-a7c6-4ce9-a90e-7b67e2fad50b"), null, "pub", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("dddadc5a-8136-4153-867f-8a3b96ea41bf"), null, "gift_and_souvenir", new Guid("7c938f9f-4edb-427c-9820-d35cf87d029d") },
                    { new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3"), null, "restaurant", new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967") },
                    { new Guid("f43b0d17-d630-4e37-93f5-d8eeb8109fb0"), null, "culture", new Guid("b313ba91-7573-434e-9b17-3afb7f14d2ac") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("01bf2966-d031-43b5-8639-444125d25647"), null, "only", new Guid("307b93ee-fe43-4036-ac59-81def692efd6") },
                    { new Guid("04986f04-d906-49d1-a053-f5d950252024"), null, "only", new Guid("15c7e04a-722f-4cf3-bbd9-4ca75668d4cf") },
                    { new Guid("0ceffc44-6721-4120-8f55-b3ff9092162a"), null, "limited", new Guid("ff87a791-7b77-4e82-8fef-f07b22389963") },
                    { new Guid("0f088123-2f09-4e6f-b58f-533d986fb354"), null, "free", new Guid("3b92f090-098c-4538-9ddd-204bffc5e44e") },
                    { new Guid("15fa879c-5f8c-4e4b-b66b-a403a8716b4a"), null, "only", new Guid("17b35de2-6c0e-4b2c-b10e-79d88ae6a3cd") },
                    { new Guid("32c4bd52-ba7e-41dc-a60b-0cd15681193a"), null, "leashed", new Guid("001c0229-da10-4d73-8771-85a0e0576cd5") },
                    { new Guid("47d6b8e8-0d97-49a0-871c-dfb03ad41f97"), null, "not_specified", new Guid("5f6ecfa1-5e4f-45ce-88a0-bee75f0c0cd6") },
                    { new Guid("5830bb86-e107-4610-a9e3-ff290e09a048"), null, "customers", new Guid("24c5555a-4e95-45e9-bf34-dc48c7ab9939") },
                    { new Guid("98225038-8a0c-4c14-b24d-f3713d584054"), null, "no", new Guid("5f6ecfa1-5e4f-45ce-88a0-bee75f0c0cd6") },
                    { new Guid("ac014d73-0a23-41cd-852d-756fbd2357db"), null, "yes", new Guid("ff87a791-7b77-4e82-8fef-f07b22389963") },
                    { new Guid("c05d0ca9-0c23-444c-afca-925b0bec97ff"), null, "only", new Guid("7706dfd1-e9ce-4214-99b3-2fee4fc51003") },
                    { new Guid("c804ad48-c431-473f-bdb1-fb4c31afe142"), null, "only", new Guid("a280fb78-a6e9-426f-a38c-b10f2d4111ca") },
                    { new Guid("c9cbed23-a7aa-469c-8ba3-ddd863e9080b"), null, "yes", new Guid("001c0229-da10-4d73-8771-85a0e0576cd5") },
                    { new Guid("dd325b52-0833-45b7-b1f4-770a15781e6f"), null, "for_customers", new Guid("3b92f090-098c-4538-9ddd-204bffc5e44e") },
                    { new Guid("e37b9fe9-eae0-4b0e-8cff-88a2e1b4a4bc"), "Places that are available for public", "yes", new Guid("5fe767cd-379a-4749-9fae-660ac179d0a8") },
                    { new Guid("f86bfac7-fade-4333-b631-c3bdbfae2497"), null, "not_specified", new Guid("5fe767cd-379a-4749-9fae-660ac179d0a8") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38") },
                    { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d") },
                    { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("ad31748c-a335-42a9-a446-e7803879681b") },
                    { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78") },
                    { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea") },
                    { new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967"), new Guid("b6537ae8-16a8-4d6e-84f9-77a717e7e0ef") }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("089ba557-2125-49c6-a743-407beeb96f18"), 100m, null, null, "PLN", new Guid("8a5473ad-60ef-470b-a49d-e02c1c51b812"), new DateOnly(2024, 11, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 11, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("be217011-a787-4eca-9d27-9931ffd1c4a9"), 100m, null, null, "PLN", new Guid("8a5473ad-60ef-470b-a49d-e02c1c51b812"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("015f2b6a-21e7-4a94-bd05-6f1d2cee9bf5"), null, "italian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("01ff3211-6428-40ea-ad88-86ecc91e5d1a"), null, "ice_cream", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("0292a985-92f5-494f-be66-933d4fe44d95"), null, "asian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("0302eab2-f73e-4216-be0a-7b5ba5964ce0"), null, "curry", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("0319d762-1fc2-461c-bfde-15dfccfd2006"), null, "fountain", new Guid("1b1dab12-2701-4a1d-b908-1b281dd864c6") },
                    { new Guid("0351816d-4949-4cb1-a536-43b7890b79e5"), null, "judaism", new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8") },
                    { new Guid("03de4a54-6f46-4e6c-b073-3e91e37da513"), null, "nature_reserve", new Guid("c973a5c3-cc01-4488-a20b-c66af71c3368") },
                    { new Guid("04f9bc88-fd39-4c04-94a2-3c775f18fd7f"), null, "ruines", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("05bbc59a-7314-4062-95b4-074217fd9a34"), null, "malay", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("062e16c0-db11-4700-a97f-3fd039e975dd"), null, "international", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("0826f730-2629-482a-93d5-2d50b9588707"), null, "beef_bowl", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("0834002b-3f6a-4e4f-be81-71ed7e783f26"), null, "fish_and_chips", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("0917dcf5-c4ec-4353-a1f8-f1870db8d8ee"), null, "cliff", new Guid("812e3e6d-e5fb-4f37-9f80-f510599a02e2") },
                    { new Guid("0b3ec659-37bd-408d-90a2-db8e61519b77"), null, "regional", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("0b8b80fc-bf81-449c-9d9b-5a0675fb4dbf"), null, "garden", new Guid("c973a5c3-cc01-4488-a20b-c66af71c3368") },
                    { new Guid("0bfdab64-e5fb-4f23-b0e1-028b17e21b1f"), null, "thai", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("0c31640b-76c8-4cb3-a3d3-d0fb80f34f85"), null, "croatian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("0e7237cf-ed2f-47ad-959e-adeea623adc8"), null, "bridge", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("0f0698ad-f64c-496e-97c3-117b0c959b68"), null, "ramen", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("12a99640-3f4b-46e3-8eac-78471e821e7b"), null, "tex-mex", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("147f7686-dca9-4598-9de1-adab250d226f"), null, "uzbek", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("1c148f7f-af0c-460d-a632-6e8801798055"), null, "arts_centre", new Guid("f43b0d17-d630-4e37-93f5-d8eeb8109fb0") },
                    { new Guid("1d6a978a-bdaf-45c1-b878-5e88f674ba66"), null, "dumpling", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("1d742572-38fe-4072-9adf-7e78a68a46da"), null, "belgian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("1e5b3fa2-799a-4b80-8b85-efa4b61df1d6"), null, "steak_house", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("1f91fc1a-6b5e-43c7-ad47-6e32a71c3aaa"), null, "tacos", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("228843d5-412d-4991-bd9f-c09c2e33f83d"), null, "dune", new Guid("058d69cc-01f6-4485-889f-bbda37f6a5c8") },
                    { new Guid("24f623a0-9980-4e15-9f63-c6a95969b62b"), null, "tea", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("26abf691-2d1a-434d-8c72-aaa4cba6b14f"), null, "ramen", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("29931f08-89cf-40c1-b2f1-96d34daa8871"), null, "rock", new Guid("812e3e6d-e5fb-4f37-9f80-f510599a02e2") },
                    { new Guid("29b6f505-198b-44a0-a734-89ffc329d909"), null, "wings", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("2ca1819a-a092-4f10-abeb-ec7f30898f7c"), null, "indonesian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("2e401790-68de-4a1b-a402-a1b74dd4b271"), null, "sikhism", new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8") },
                    { new Guid("2e641578-bf46-464c-97c3-45fded8b0470"), null, "ukrainian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("2fee7fa7-ce3a-4769-82b6-e4289f7e18bb"), null, "monastery", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("3150266a-15f5-4d1a-b59f-83f8a1f09265"), null, "afghan", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("3561ea5e-aa96-40c2-a095-8e3a9d408c12"), null, "chicken", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("36847e8e-09e5-4b17-918c-f5eb8f3c5817"), null, "sandwich", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("3ac9b1a8-68cc-48d3-9908-3f268da7872d"), null, "archaeological_site", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("3bec0375-3054-435a-933a-2e325180b3e0"), null, "filipino", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("3f63d2a8-da27-4671-93a6-267b82abe492"), null, "soup", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("3fc9fb8f-0909-4258-8d6c-97fbebb7500d"), null, "chili", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("4038f2d4-0b40-4b5a-a21e-087c601ef7d6"), null, "christianity", new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8") },
                    { new Guid("407cf5ee-b1d8-4c8f-8ae1-a8db94819dc0"), null, "fish_and_chips", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("415e4309-1a80-4556-b647-e44547a7a2d1"), null, "vietnamese", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("41c27dc4-ecdd-4cfc-9649-7b24b373ec59"), null, "viewpoint", new Guid("1b1dab12-2701-4a1d-b908-1b281dd864c6") },
                    { new Guid("425c7998-e585-41ec-9b98-7e416b80f180"), null, "japanese", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("435d3fef-aace-4776-92fa-f2d534593629"), null, "sea", new Guid("6fc4cce4-426d-4ded-8503-5eb183565e98") },
                    { new Guid("46e0536c-c43e-46d0-9804-27dccb5bc4dc"), null, "persian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("479a7b32-3f3c-4908-8bf1-7304dc4f523f"), null, "chinese", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("489f74c5-0f90-4cf2-ac47-7176c7d7a9be"), null, "pakistani", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("49b25567-d8a6-4bbd-b933-105a4917ac22"), null, "coffee_shop", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("4b64129b-68b3-43c3-96d8-d744215e0434"), null, "noodle", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("4d93429b-70d7-4a9b-8210-b447cd90a4ea"), null, "sushi", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("4ed02c7c-9d80-41bd-96c7-633c6875bff5"), null, "american", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("51b022ef-e764-4118-89a7-b7c60e3c7ada"), null, "russian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("54c19113-2a1d-4d8b-b9a8-e225c6a5a78e"), null, "reef", new Guid("6fc4cce4-426d-4ded-8503-5eb183565e98") },
                    { new Guid("5543705b-7246-4d3a-9251-e6636be6e010"), null, "ethiopian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("55a4fdfb-282c-4109-b040-c27ab5ac6896"), null, "brazilian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("5618a2ba-f30e-41ea-bb5b-692b0e9662a1"), null, "pita", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("574b785b-c752-4c44-867d-d35cb79a7b8f"), null, "hungarian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("5a4ebecd-7b30-44fa-8941-9c788d5613fb"), null, "donut", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("5f214649-c62c-4c37-9cad-4e0c8613f300"), null, "glacier", new Guid("812e3e6d-e5fb-4f37-9f80-f510599a02e2") },
                    { new Guid("616bae99-b866-48da-89c0-38173c425349"), null, "battlefield", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("64ae0f86-67ba-4be1-8abb-f9b34fb48b35"), null, "czech", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("65f11cca-c7ec-4688-9926-aed5f55a4579"), null, "malaysian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), null, "memorial", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("6ccfab6e-31f3-416d-b0c7-d182c6c06310"), null, "dessert", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("6dca44bb-7e8a-4dbd-9e19-6b3aa52bb4ce"), null, "peak", new Guid("812e3e6d-e5fb-4f37-9f80-f510599a02e2") },
                    { new Guid("6df407a2-a9fc-4890-bd04-a2f93dd24e15"), null, "nepalese", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("70328b30-05b0-4f03-81ef-b3dbf1affe5f"), null, "bavarian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("70f2adaf-28e0-44e0-811e-5b058ba27acf"), null, "french", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("72a6af19-d109-481c-a6b8-784e9b6c0fed"), null, "burger", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("733b3d7b-4183-409b-9fee-115886bb0127"), null, "portuguese", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("753bdb9a-7084-4f7e-b26d-e91eb6ec81b4"), null, "geyser", new Guid("6fc4cce4-426d-4ded-8503-5eb183565e98") },
                    { new Guid("78094564-aee1-46fa-ae92-ea7daa6700cd"), null, "salad", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("79f5ca49-8b7a-403c-b7fc-79043bd2d064"), null, "windmill", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("7b64f68f-6ca6-4ab1-9dd8-d46f65a49948"), null, "clock", new Guid("1b1dab12-2701-4a1d-b908-1b281dd864c6") },
                    { new Guid("7d4b2d40-d618-45cd-8269-9ea9c1e904ba"), null, "buddhism", new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8") },
                    { new Guid("7df18087-1de0-40b1-b227-0b20ecb9d345"), null, "barbecue", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("827d115c-2acb-4034-aed4-82f6227bb1b3"), null, "hinduism", new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8") },
                    { new Guid("8312a84c-1bd2-4748-b0c2-7a4caee87df2"), null, "greek", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("844e7a19-db5a-4863-911f-f1389a0c14de"), null, "cake", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("846d18ce-37fd-4363-a0cc-1d36298b3961"), null, "hot_dog", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49"), null, "place_of_worship", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("86c6284f-0ce2-436c-9844-65a7f4292d87"), null, "turkish", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("8885a292-2421-46e4-bc6d-5a56dd11692f"), null, "crepe", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("8b8b475b-aac5-45ae-bd7b-a095b77a6b73"), null, "lighthouse", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("8fe55d08-8557-48b6-a76f-3164a042f4b5"), null, "european", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("901a95d6-f278-40c8-8bda-1190d975b279"), null, "kebab", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("908db230-36d8-402b-b450-4a74478920ee"), null, "gallery", new Guid("f43b0d17-d630-4e37-93f5-d8eeb8109fb0") },
                    { new Guid("91cb87a6-ca1a-43a4-8b88-3e4d5a4dcea2"), null, "hot_spring", new Guid("6fc4cce4-426d-4ded-8503-5eb183565e98") },
                    { new Guid("9233c1f4-0f27-425c-a981-385136e822a8"), null, "swedish", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("924770ba-0825-4094-bb27-7b6fe5fc5fe0"), null, "oriental", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("94d1e232-1ce0-493c-8f99-6dc25dedd66d"), null, "korean", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("97bf3c5f-8f22-4afe-b3b3-454261e38e18"), null, "spring", new Guid("6fc4cce4-426d-4ded-8503-5eb183565e98") },
                    { new Guid("98957e2d-e402-44bd-8379-25d1ca8d8073"), null, "wings", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("9947bfe6-9f9a-451e-8b0b-8751d76c763f"), null, "coffee", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("9c44e322-487d-4ed9-92b6-f1c5a0c60af5"), null, "theatre", new Guid("f43b0d17-d630-4e37-93f5-d8eeb8109fb0") },
                    { new Guid("9d307342-29b4-4ca0-b1f7-025653bc6a4d"), null, "shinto", new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8") },
                    { new Guid("9dd02029-b743-46b6-90e9-e10a0a31a9a3"), null, "fish", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("9de9e0fe-ae7d-40b9-b3d7-7b2380ea054e"), null, "caribbean", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("a7cc3c10-98c9-40b4-aa80-8786c52074c6"), null, "hawaiian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("a87942bb-59ef-434d-adac-62adb8d730b7"), null, "spanish", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("aa57512c-c4f2-4e58-ae42-3e3aab84798e"), null, "artwork", new Guid("1b1dab12-2701-4a1d-b908-1b281dd864c6") },
                    { new Guid("aab50919-d2f7-4e11-aefb-5b731128750f"), null, "tacos", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("ab6e7aae-c135-47d5-95fa-864d2148bfbb"), null, "syrian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("ac377ffb-bf9f-44c5-b22b-790b754ee64f"), null, "moroccan", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("adb14ba0-e1cf-4478-ba10-d074a53fad47"), null, "bubble_tea", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("b114d2ee-d03e-464f-9e3b-9d0e2c457334"), null, "friture", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("b1e1d73f-790d-43d4-a6be-13d377e25b09"), null, "danish", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("b3d86ee1-1a2e-491b-9e91-29f201c9835f"), null, "tapas", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("b82b21bb-c23d-470f-996f-56a1e0a3d611"), null, "burger", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("b866f35c-5b4b-438c-aa84-92e3ffefa3ed"), null, "taiwanese", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("b8750037-5493-4894-9a19-3edc834d5bda"), null, "sandwich", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("b959456a-6c96-410a-a1fd-5b28718ceb43"), null, "western", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("bb0c21bd-c008-4881-acab-50618127850e"), null, "pizza", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("bdaebf3f-e443-4180-a4c7-b36d9d0202c1"), null, "indian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("be4ac1ea-6f53-436b-9b66-b589778840fd"), null, "latin_american", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("c0845031-7acd-4f0f-830b-0daf31879c25"), null, "austrian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("c25c4187-8f6f-4f1e-98cc-6532ab57476f"), null, "balkan", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("c294e492-cc0a-45fe-ac2d-b0c8b3cbbbde"), null, "georgian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("c2b47761-bc1e-492f-95a1-113aac111dd6"), null, "cuban", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("c57dbd66-7e83-4c5c-a8d3-683d4117d3f3"), null, "waffle", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("c7c97099-4b30-4f6e-bb23-f1cdddd5a0a6"), null, "tapas", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("cb0769d3-afab-422b-8162-c6f2a8198eac"), null, "frozen_yogurt", new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737") },
                    { new Guid("ccdd7444-e589-49de-a71e-72c89b4daf93"), null, "pizza", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("cd0c70fa-dae9-4d1f-b268-2ae91b39d7fd"), null, "fort", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("ce600192-3f50-4d65-9441-474aaab86f31"), null, "bolivian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("ce6f6729-24be-428a-8e75-9e13484af54f"), null, "argentinian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("ce952a21-f2f2-4564-9729-9faa95f4ff0e"), null, "castle", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("d0778d9d-bb25-4f0f-85d4-a3a9082812d6"), null, "irish", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("d197b151-bc15-4d59-881c-5481640ed40f"), null, "city_hall", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("d2b579f5-9246-41db-a351-42739a747b90"), null, "noodle", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("d5215bac-34ce-4158-a8ac-ed47ef3906e4"), null, "tower", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("d570f50d-ec2d-4755-b751-946c4de3cb1d"), null, "pita", new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e") },
                    { new Guid("d771e0d5-83be-43dd-ae66-8cf553a656eb"), null, "kebab", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("d901647a-aa6e-43ca-bff8-4daa26792fc0"), null, "peruvian", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("ddbd2ceb-bb44-4197-aaf4-e0fe329b7b96"), null, "mexican", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("de838353-d19b-44b1-a90c-ba79866ea6c2"), null, "city_gate", new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746") },
                    { new Guid("e2d6bc7a-4982-4032-be79-b716bb5b1db4"), null, "seafood", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("e50219cd-d54d-4bb8-9dfd-a218879a4510"), null, "jamaican", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("efb4af7d-d832-4abb-93d1-af07518e49a1"), null, "lebanese", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("f427a04d-e6ff-411b-9aee-689a39fb1f7e"), null, "soup", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("f755ad8e-4d92-4a9a-a8b4-6543b36be9eb"), null, "mediterranean", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("f81079a4-6bdd-461d-b43e-0dd9de3894ce"), null, "cave_entrance", new Guid("812e3e6d-e5fb-4f37-9f80-f510599a02e2") },
                    { new Guid("f9113a0f-a9ab-4d1d-967b-e5cf37122295"), null, "multifaith", new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8") },
                    { new Guid("fa84dba7-1c3b-442f-bdbf-f46d2679f96c"), null, "african", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("fb9f9c94-c1c6-4793-a7ea-bdf3c3d04d5e"), null, "german", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") },
                    { new Guid("fe94a101-5199-4f28-98d4-95dfd341b08c"), null, "islam", new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8") },
                    { new Guid("ffbea87d-84c8-4b0f-9b60-b6fcfe869593"), null, "arab", new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38") },
                    { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d") },
                    { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("ad31748c-a335-42a9-a446-e7803879681b") },
                    { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78") },
                    { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea") },
                    { new Guid("1b1dab12-2701-4a1d-b908-1b281dd864c6"), new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea") },
                    { new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3"), new Guid("b6537ae8-16a8-4d6e-84f9-77a717e7e0ef") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b"), new DateOnly(2024, 11, 21), new Guid("089ba557-2125-49c6-a743-407beeb96f18") },
                    { new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7"), new DateOnly(2024, 12, 20), new Guid("be217011-a787-4eca-9d27-9931ffd1c4a9") },
                    { new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f"), new DateOnly(2024, 11, 20), new Guid("089ba557-2125-49c6-a743-407beeb96f18") },
                    { new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a"), new DateOnly(2024, 12, 21), new Guid("be217011-a787-4eca-9d27-9931ffd1c4a9") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0228bb3b-83d8-4b2b-bd8c-8f32d60e7464"), null, "milestone", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("06803d5a-fe66-4076-ae97-fc7223caef99"), null, "chapel", new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49") },
                    { new Guid("0e453133-a1f1-4206-83f6-24c17b4dd461"), null, "synagogue", new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49") },
                    { new Guid("28ff3fe5-41f2-4eaf-b997-4be4569b3053"), null, "aircraft", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("3333747a-7931-42ab-91b5-705c3141d687"), null, "tomb", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("3e1b763a-2319-40dc-9687-14519cf4296b"), null, "mosque", new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49") },
                    { new Guid("4df176c9-d8c8-4d34-afc5-43335dfc5220"), null, "boundary_stone", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("827f03f5-42ce-45fe-bd4c-43b331857913"), null, "wayside_cross", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("9c6bfffa-6859-4702-9e37-63daa0becd37"), null, "shrine", new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49") },
                    { new Guid("a866a7f3-6635-419f-88e3-38f72dd8f466"), null, "ship", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("adaa747f-ab3f-4ce1-83c6-ff91de56ce8e"), null, "church", new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49") },
                    { new Guid("b5ef7dbf-894d-4bd4-8f01-06f7693d1a78"), null, "pillory", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("bb82b50c-5bf2-4ee8-b2ed-8a89b2b5a75a"), null, "tank", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("c32a41ed-a034-4e2b-952e-5aaf4b198b15"), null, "cathedral", new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49") },
                    { new Guid("ce5c402b-2c1d-4d45-9747-a210221285d2"), null, "monument", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("edf098da-92c2-45ca-b5fb-aa4894f4e1b2"), null, "temple", new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49") },
                    { new Guid("eeb5cfda-b58e-44a4-825f-68017ee42f44"), null, "locomotive", new Guid("6b903469-926a-4863-af68-618f28e1a94a") },
                    { new Guid("fc40aa45-3f8c-4c80-8303-0b0f7f9a0a1a"), null, "railway_car", new Guid("6b903469-926a-4863-af68-618f28e1a94a") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("04f9bc88-fd39-4c04-94a2-3c775f18fd7f"), new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea") },
                    { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38") },
                    { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d") },
                    { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), new Guid("ad31748c-a335-42a9-a446-e7803879681b") },
                    { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("09d30a9d-e978-433c-9cf0-13e899adfe29"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7") },
                    { new Guid("0a5183e3-d620-431d-916b-98f4a7ae5a4f"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("1676d649-c588-4c58-9ba8-c4d2de9cac94"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7") },
                    { new Guid("23a38512-9cff-47ad-9531-316ad4e8cd25"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("7b844144-9588-4f3c-af8d-543e2eee08b2"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f") },
                    { new Guid("2c76427f-3358-4736-9638-ca4a9114b1a4"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("ad31748c-a335-42a9-a446-e7803879681b"), 0m, new TimeOnly(13, 0, 0), 1, new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b") },
                    { new Guid("2fa9e3f7-9ca3-48a1-9fc5-e276d8f843a8"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("b6537ae8-16a8-4d6e-84f9-77a717e7e0ef"), 30m, new TimeOnly(14, 0, 0), 1, new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b") },
                    { new Guid("400b1f29-2507-495e-bc9a-143c20efe5f4"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38"), 0m, new TimeOnly(11, 0, 0), 1, new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f") },
                    { new Guid("4709129d-604f-492b-9872-16e39a767a16"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("ad31748c-a335-42a9-a446-e7803879681b"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a") },
                    { new Guid("52c19bd2-f2c0-4cf9-945b-54288a65b0b8"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("4c8edabc-a963-421c-89f3-48100e9ef2d5"), 0m, new TimeOnly(16, 30, 0), 1, new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b") },
                    { new Guid("5f4a8261-55cf-40de-8e52-12b6cbeb850a"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("7ca764b2-8522-49da-be1b-31e403f03634"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7") },
                    { new Guid("7b385e6e-2e10-4379-a541-03b68a110bb1"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7") },
                    { new Guid("8d5ed9b3-f90e-4334-9360-eb3a04c8925a"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("b6537ae8-16a8-4d6e-84f9-77a717e7e0ef"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a") },
                    { new Guid("a926a253-540d-4508-84b5-1e310ce4eeeb"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7") },
                    { new Guid("c193caca-5831-48e8-8cfb-c3f8002c04fc"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d"), 0m, new TimeOnly(11, 50, 0), 1, new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f") },
                    { new Guid("c2906e4b-9731-4d23-ab10-818e5b47f9ea"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("246557ac-83d5-4de5-b07b-eedbadaec443"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a") },
                    { new Guid("d0a3b77c-d151-4503-90a2-87f6a5bd1a6d"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a") },
                    { new Guid("e1027eed-4c49-494f-9aaa-bf761055ae1b"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea"), 0m, new TimeOnly(10, 0, 0), 1, new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f") },
                    { new Guid("ebad9018-637f-4d01-9941-e45ce2acafce"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("0b982120-735b-4e9b-9207-609ead4d5d85"), 0m, new TimeOnly(13, 30, 0), 4, new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f") },
                    { new Guid("ee12a43a-b4c1-4659-9bfd-249e7ca55af4"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b") }
                });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "ToTripPointId", "TransferTime", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("2f669266-0f6d-4bea-ba68-0b80f8c3c873"), new Guid("09d30a9d-e978-433c-9cf0-13e899adfe29"), 0, new Guid("7b385e6e-2e10-4379-a541-03b68a110bb1"), new TimeSpan(0, 0, 4, 21, 0), new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7") },
                    { new Guid("55197742-4c8c-4376-a88b-621ed8381eae"), new Guid("2fa9e3f7-9ca3-48a1-9fc5-e276d8f843a8"), 3, new Guid("52c19bd2-f2c0-4cf9-945b-54288a65b0b8"), new TimeSpan(0, 0, 13, 30, 0), new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b") },
                    { new Guid("5623e7a2-bfb6-46ba-af01-b6b7f86914fe"), new Guid("2c76427f-3358-4736-9638-ca4a9114b1a4"), 3, new Guid("2fa9e3f7-9ca3-48a1-9fc5-e276d8f843a8"), new TimeSpan(0, 0, 8, 18, 0), new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b") },
                    { new Guid("5a1d6597-8d2f-4419-b970-6f65b9f54ec6"), new Guid("5f4a8261-55cf-40de-8e52-12b6cbeb850a"), null, new Guid("0a5183e3-d620-431d-916b-98f4a7ae5a4f"), new TimeSpan(0, 0, 20, 0, 0), new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7") },
                    { new Guid("6011ee5b-649d-4e47-b643-407b3c2a43cd"), new Guid("4709129d-604f-492b-9872-16e39a767a16"), 3, new Guid("8d5ed9b3-f90e-4334-9360-eb3a04c8925a"), new TimeSpan(0, 0, 8, 18, 0), new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a") },
                    { new Guid("7610b5b1-7b61-4a3f-9c9b-c537ab774a39"), new Guid("ee12a43a-b4c1-4659-9bfd-249e7ca55af4"), 2, new Guid("2c76427f-3358-4736-9638-ca4a9114b1a4"), new TimeSpan(0, 0, 3, 13, 0), new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b") },
                    { new Guid("79fa17db-c1ea-442a-8239-f48cdadf6537"), new Guid("400b1f29-2507-495e-bc9a-143c20efe5f4"), 0, new Guid("c193caca-5831-48e8-8cfb-c3f8002c04fc"), new TimeSpan(0, 0, 4, 21, 0), new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f") },
                    { new Guid("94e113e2-f1ab-4a75-bbb6-f0e551e74c4c"), new Guid("7b385e6e-2e10-4379-a541-03b68a110bb1"), 1, new Guid("5f4a8261-55cf-40de-8e52-12b6cbeb850a"), new TimeSpan(0, 0, 0, 55, 0), new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7") },
                    { new Guid("a88905e3-a2a0-4139-9b95-5c1a4e288944"), new Guid("c193caca-5831-48e8-8cfb-c3f8002c04fc"), 1, new Guid("23a38512-9cff-47ad-9531-316ad4e8cd25"), new TimeSpan(0, 0, 0, 55, 0), new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f") },
                    { new Guid("aad78bd6-7a11-4d97-bc5f-c1785f795cdf"), new Guid("d0a3b77c-d151-4503-90a2-87f6a5bd1a6d"), 2, new Guid("4709129d-604f-492b-9872-16e39a767a16"), new TimeSpan(0, 0, 3, 13, 0), new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a") },
                    { new Guid("c732ce33-d99e-4b84-8144-d7234ce0fc6c"), new Guid("8d5ed9b3-f90e-4334-9360-eb3a04c8925a"), 3, new Guid("c2906e4b-9731-4d23-ab10-818e5b47f9ea"), new TimeSpan(0, 0, 13, 30, 0), new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a") },
                    { new Guid("ddbbc2c5-de7e-4768-98a8-5b9a35ba1f8b"), new Guid("23a38512-9cff-47ad-9531-316ad4e8cd25"), null, new Guid("ebad9018-637f-4d01-9941-e45ce2acafce"), new TimeSpan(0, 0, 20, 0, 0), new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripPointReviews_TripPointId",
                table: "TripPointReviews",
                column: "TripPointId",
                unique: true,
                filter: "[TripPointId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TripPointReviews_TripPoints_TripPointId",
                table: "TripPointReviews",
                column: "TripPointId",
                principalTable: "TripPoints",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripPointReviews_TripPoints_TripPointId",
                table: "TripPointReviews");

            migrationBuilder.DropIndex(
                name: "IX_TripPointReviews_TripPointId",
                table: "TripPointReviews");

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("015f2b6a-21e7-4a94-bd05-6f1d2cee9bf5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("01ff3211-6428-40ea-ad88-86ecc91e5d1a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0228bb3b-83d8-4b2b-bd8c-8f32d60e7464"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0292a985-92f5-494f-be66-933d4fe44d95"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0302eab2-f73e-4216-be0a-7b5ba5964ce0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0319d762-1fc2-461c-bfde-15dfccfd2006"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0351816d-4949-4cb1-a536-43b7890b79e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("03de4a54-6f46-4e6c-b073-3e91e37da513"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("050470e6-150d-41bd-b76a-f238f1af066d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05bbc59a-7314-4062-95b4-074217fd9a34"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("062e16c0-db11-4700-a97f-3fd039e975dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("06803d5a-fe66-4076-ae97-fc7223caef99"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("06a105f0-6a39-459a-a489-21454af03e9d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0826f730-2629-482a-93d5-2d50b9588707"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0834002b-3f6a-4e4f-be81-71ed7e783f26"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0917dcf5-c4ec-4353-a1f8-f1870db8d8ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b3ec659-37bd-408d-90a2-db8e61519b77"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b8b80fc-bf81-449c-9d9b-5a0675fb4dbf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0bfdab64-e5fb-4f23-b0e1-028b17e21b1f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c31640b-76c8-4cb3-a3d3-d0fb80f34f85"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e453133-a1f1-4206-83f6-24c17b4dd461"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e7237cf-ed2f-47ad-959e-adeea623adc8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f0698ad-f64c-496e-97c3-117b0c959b68"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12a99640-3f4b-46e3-8eac-78471e821e7b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("147f7686-dca9-4598-9de1-adab250d226f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c148f7f-af0c-460d-a632-6e8801798055"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d6a978a-bdaf-45c1-b878-5e88f674ba66"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d742572-38fe-4072-9adf-7e78a68a46da"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1e5b3fa2-799a-4b80-8b85-efa4b61df1d6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f91fc1a-6b5e-43c7-ad47-6e32a71c3aaa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("228843d5-412d-4991-bd9f-c09c2e33f83d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("24f623a0-9980-4e15-9f63-c6a95969b62b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("269268a5-538e-493e-ae05-4f0d3009cd86"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("26abf691-2d1a-434d-8c72-aaa4cba6b14f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28ff3fe5-41f2-4eaf-b997-4be4569b3053"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("29931f08-89cf-40c1-b2f1-96d34daa8871"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("29b6f505-198b-44a0-a734-89ffc329d909"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ca1819a-a092-4f10-abeb-ec7f30898f7c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e401790-68de-4a1b-a402-a1b74dd4b271"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e641578-bf46-464c-97c3-45fded8b0470"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2fee7fa7-ce3a-4769-82b6-e4289f7e18bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3150266a-15f5-4d1a-b59f-83f8a1f09265"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3333747a-7931-42ab-91b5-705c3141d687"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3561ea5e-aa96-40c2-a095-8e3a9d408c12"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("36847e8e-09e5-4b17-918c-f5eb8f3c5817"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("397baa3a-13cf-4db8-95e8-99855d7e443f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ac9b1a8-68cc-48d3-9908-3f268da7872d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3bec0375-3054-435a-933a-2e325180b3e0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e1b763a-2319-40dc-9687-14519cf4296b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f63d2a8-da27-4671-93a6-267b82abe492"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fc9fb8f-0909-4258-8d6c-97fbebb7500d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4038f2d4-0b40-4b5a-a21e-087c601ef7d6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("407cf5ee-b1d8-4c8f-8ae1-a8db94819dc0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("415e4309-1a80-4556-b647-e44547a7a2d1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41c27dc4-ecdd-4cfc-9649-7b24b373ec59"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("425c7998-e585-41ec-9b98-7e416b80f180"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("435d3fef-aace-4776-92fa-f2d534593629"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("44b1643b-a834-4428-92df-8b5341ae4d2b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("46e0536c-c43e-46d0-9804-27dccb5bc4dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("479a7b32-3f3c-4908-8bf1-7304dc4f523f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("489f74c5-0f90-4cf2-ac47-7176c7d7a9be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("49b25567-d8a6-4bbd-b933-105a4917ac22"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b64129b-68b3-43c3-96d8-d744215e0434"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c84ab0b-7e7b-4fce-9764-a855b1468391"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4d93429b-70d7-4a9b-8210-b447cd90a4ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4df176c9-d8c8-4d34-afc5-43335dfc5220"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4ed02c7c-9d80-41bd-96c7-633c6875bff5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51b022ef-e764-4118-89a7-b7c60e3c7ada"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("54c19113-2a1d-4d8b-b9a8-e225c6a5a78e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5543705b-7246-4d3a-9251-e6636be6e010"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("55a4fdfb-282c-4109-b040-c27ab5ac6896"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5618a2ba-f30e-41ea-bb5b-692b0e9662a1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("574b785b-c752-4c44-867d-d35cb79a7b8f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a4ebecd-7b30-44fa-8941-9c788d5613fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5f214649-c62c-4c37-9cad-4e0c8613f300"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("616bae99-b866-48da-89c0-38173c425349"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("64ae0f86-67ba-4be1-8abb-f9b34fb48b35"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("65f11cca-c7ec-4688-9926-aed5f55a4579"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6685ae02-318c-45e2-9405-b42f75ffd166"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a5b1b6d-a6f7-41fb-8277-00756aba33bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ccfab6e-31f3-416d-b0c7-d182c6c06310"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6dca44bb-7e8a-4dbd-9e19-6b3aa52bb4ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6df407a2-a9fc-4890-bd04-a2f93dd24e15"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("70328b30-05b0-4f03-81ef-b3dbf1affe5f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("70f2adaf-28e0-44e0-811e-5b058ba27acf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("72a6af19-d109-481c-a6b8-784e9b6c0fed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("733b3d7b-4183-409b-9fee-115886bb0127"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("753bdb9a-7084-4f7e-b26d-e91eb6ec81b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("78094564-aee1-46fa-ae92-ea7daa6700cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("79f5ca49-8b7a-403c-b7fc-79043bd2d064"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b64f68f-6ca6-4ab1-9dd8-d46f65a49948"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d4b2d40-d618-45cd-8269-9ea9c1e904ba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7df18087-1de0-40b1-b227-0b20ecb9d345"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("827d115c-2acb-4034-aed4-82f6227bb1b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("827f03f5-42ce-45fe-bd4c-43b331857913"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8312a84c-1bd2-4748-b0c2-7a4caee87df2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("844e7a19-db5a-4863-911f-f1389a0c14de"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("846d18ce-37fd-4363-a0cc-1d36298b3961"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("86c6284f-0ce2-436c-9844-65a7f4292d87"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8885a292-2421-46e4-bc6d-5a56dd11692f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b8b475b-aac5-45ae-bd7b-a095b77a6b73"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8fe55d08-8557-48b6-a76f-3164a042f4b5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("901a95d6-f278-40c8-8bda-1190d975b279"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("908db230-36d8-402b-b450-4a74478920ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("91cb87a6-ca1a-43a4-8b88-3e4d5a4dcea2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9233c1f4-0f27-425c-a981-385136e822a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("924770ba-0825-4094-bb27-7b6fe5fc5fe0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("94d1e232-1ce0-493c-8f99-6dc25dedd66d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("97bf3c5f-8f22-4afe-b3b3-454261e38e18"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("98957e2d-e402-44bd-8379-25d1ca8d8073"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9947bfe6-9f9a-451e-8b0b-8751d76c763f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c44e322-487d-4ed9-92b6-f1c5a0c60af5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c6bfffa-6859-4702-9e37-63daa0becd37"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d307342-29b4-4ca0-b1f7-025653bc6a4d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9dd02029-b743-46b6-90e9-e10a0a31a9a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9de9e0fe-ae7d-40b9-b3d7-7b2380ea054e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7cc3c10-98c9-40b4-aa80-8786c52074c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a866a7f3-6635-419f-88e3-38f72dd8f466"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a87942bb-59ef-434d-adac-62adb8d730b7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa57512c-c4f2-4e58-ae42-3e3aab84798e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aab50919-d2f7-4e11-aefb-5b731128750f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab6e7aae-c135-47d5-95fa-864d2148bfbb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac377ffb-bf9f-44c5-b22b-790b754ee64f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad6bd65a-2721-47ee-8d8a-fcaa7a663651"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("adaa747f-ab3f-4ce1-83c6-ff91de56ce8e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("adb14ba0-e1cf-4478-ba10-d074a53fad47"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0d8e732-f9d6-4d69-a908-b464237eab75"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b114d2ee-d03e-464f-9e3b-9d0e2c457334"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b1e1d73f-790d-43d4-a6be-13d377e25b09"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3d86ee1-1a2e-491b-9e91-29f201c9835f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b589383f-afb7-497c-b09d-74017876afe9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b5ef7dbf-894d-4bd4-8f01-06f7693d1a78"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b82b21bb-c23d-470f-996f-56a1e0a3d611"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b866f35c-5b4b-438c-aa84-92e3ffefa3ed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8750037-5493-4894-9a19-3edc834d5bda"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b95923db-a55b-4eee-8ca7-ac35e7bfd56c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b959456a-6c96-410a-a1fd-5b28718ceb43"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb0c21bd-c008-4881-acab-50618127850e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb82b50c-5bf2-4ee8-b2ed-8a89b2b5a75a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bdaebf3f-e443-4180-a4c7-b36d9d0202c1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be4ac1ea-6f53-436b-9b66-b589778840fd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0845031-7acd-4f0f-830b-0daf31879c25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c25c4187-8f6f-4f1e-98cc-6532ab57476f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c294e492-cc0a-45fe-ac2d-b0c8b3cbbbde"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c2b47761-bc1e-492f-95a1-113aac111dd6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c32a41ed-a034-4e2b-952e-5aaf4b198b15"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c57dbd66-7e83-4c5c-a8d3-683d4117d3f3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c7c97099-4b30-4f6e-bb23-f1cdddd5a0a6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cadb043a-b9a0-42ba-b739-004b94a8b270"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cb0769d3-afab-422b-8162-c6f2a8198eac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccdd7444-e589-49de-a71e-72c89b4daf93"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccfb4668-f954-4714-9ba7-a6bfe9f3a877"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd0c70fa-dae9-4d1f-b268-2ae91b39d7fd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce5c402b-2c1d-4d45-9747-a210221285d2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce600192-3f50-4d65-9441-474aaab86f31"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce6f6729-24be-428a-8e75-9e13484af54f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce952a21-f2f2-4564-9729-9faa95f4ff0e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0778d9d-bb25-4f0f-85d4-a3a9082812d6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0ee8558-9c05-4bf8-a0a3-ad304a3762d3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d197b151-bc15-4d59-881c-5481640ed40f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2b579f5-9246-41db-a351-42739a747b90"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d5215bac-34ce-4158-a8ac-ed47ef3906e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d570f50d-ec2d-4755-b751-946c4de3cb1d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d771e0d5-83be-43dd-ae66-8cf553a656eb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d901647a-aa6e-43ca-bff8-4daa26792fc0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dcf1c33f-a7c6-4ce9-a90e-7b67e2fad50b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ddbd2ceb-bb44-4197-aaf4-e0fe329b7b96"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dddadc5a-8136-4153-867f-8a3b96ea41bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("de838353-d19b-44b1-a90c-ba79866ea6c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2d6bc7a-4982-4032-be79-b716bb5b1db4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e50219cd-d54d-4bb8-9dfd-a218879a4510"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("edf098da-92c2-45ca-b5fb-aa4894f4e1b2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eeb5cfda-b58e-44a4-825f-68017ee42f44"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("efb4af7d-d832-4abb-93d1-af07518e49a1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f427a04d-e6ff-411b-9aee-689a39fb1f7e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f755ad8e-4d92-4a9a-a8b4-6543b36be9eb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f81079a4-6bdd-461d-b43e-0dd9de3894ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9113a0f-a9ab-4d1d-967b-e5cf37122295"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa84dba7-1c3b-442f-bdbf-f46d2679f96c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb9f9c94-c1c6-4793-a7ea-bdf3c3d04d5e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc40aa45-3f8c-4c80-8303-0b0f7f9a0a1a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe94a101-5199-4f28-98d4-95dfd341b08c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ffbea87d-84c8-4b0f-9b60-b6fcfe869593"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("01bf2966-d031-43b5-8639-444125d25647"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("04986f04-d906-49d1-a053-f5d950252024"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("0ceffc44-6721-4120-8f55-b3ff9092162a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("0f088123-2f09-4e6f-b58f-533d986fb354"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("15fa879c-5f8c-4e4b-b66b-a403a8716b4a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("187d1349-7600-46cf-9649-a7777f0d2774"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("32c4bd52-ba7e-41dc-a60b-0cd15681193a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("47d6b8e8-0d97-49a0-871c-dfb03ad41f97"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("496dd4fe-1d75-4ef6-bcdf-a388cbc97762"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5830bb86-e107-4610-a9e3-ff290e09a048"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("67efb514-c4f9-4da0-8d47-bdee37851157"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("81399a72-93a9-49ba-bbb5-c58a6caf298a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9385a302-4fbd-4b26-99d8-3abeaa503177"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("967944e4-83e6-441e-86d4-dd1a46872488"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("98225038-8a0c-4c14-b24d-f3713d584054"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ac014d73-0a23-41cd-852d-756fbd2357db"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c05d0ca9-0c23-444c-afca-925b0bec97ff"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c804ad48-c431-473f-bdb1-fb4c31afe142"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c9cbed23-a7aa-469c-8ba3-ddd863e9080b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dd325b52-0833-45b7-b1f4-770a15781e6f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e1befcf0-6e2b-4caf-9876-45a8b2c26c1d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e37b9fe9-eae0-4b0e-8cff-88a2e1b4a4bc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f86bfac7-fade-4333-b631-c3bdbfae2497"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("04f9bc88-fd39-4c04-94a2-3c775f18fd7f"), new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("ad31748c-a335-42a9-a446-e7803879681b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"), new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1b1dab12-2701-4a1d-b908-1b281dd864c6"), new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("ad31748c-a335-42a9-a446-e7803879681b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"), new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), new Guid("ad31748c-a335-42a9-a446-e7803879681b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b903469-926a-4863-af68-618f28e1a94a"), new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967"), new Guid("b6537ae8-16a8-4d6e-84f9-77a717e7e0ef") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3"), new Guid("b6537ae8-16a8-4d6e-84f9-77a717e7e0ef") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("2f669266-0f6d-4bea-ba68-0b80f8c3c873"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("55197742-4c8c-4376-a88b-621ed8381eae"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("5623e7a2-bfb6-46ba-af01-b6b7f86914fe"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("5a1d6597-8d2f-4419-b970-6f65b9f54ec6"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("6011ee5b-649d-4e47-b643-407b3c2a43cd"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("7610b5b1-7b61-4a3f-9c9b-c537ab774a39"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("79fa17db-c1ea-442a-8239-f48cdadf6537"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("94e113e2-f1ab-4a75-bbb6-f0e551e74c4c"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("a88905e3-a2a0-4139-9b95-5c1a4e288944"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("aad78bd6-7a11-4d97-bc5f-c1785f795cdf"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("c732ce33-d99e-4b84-8144-d7234ce0fc6c"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("ddbbc2c5-de7e-4768-98a8-5b9a35ba1f8b"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("a926a253-540d-4508-84b5-1e310ce4eeeb"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("e1027eed-4c49-494f-9aaa-bf761055ae1b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("04f9bc88-fd39-4c04-94a2-3c775f18fd7f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("058d69cc-01f6-4485-889f-bbda37f6a5c8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b1dab12-2701-4a1d-b908-1b281dd864c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3a1a34f2-c8b6-4950-96ad-0c513a972ee9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("40c17eb4-54b9-425f-aa45-c99359c7648e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e5c5b9e-e3fc-4a5d-93c5-dfda7c2b6ab8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b903469-926a-4863-af68-618f28e1a94a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fc4cce4-426d-4ded-8503-5eb183565e98"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ac23ae7-fe94-41ea-955e-e1991558e737"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c938f9f-4edb-427c-9820-d35cf87d029d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("812e3e6d-e5fb-4f37-9f80-f510599a02e2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("865ff1e2-fe1a-4b8f-81cd-0e9aba35ef49"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c973a5c3-cc01-4488-a20b-c66af71c3368"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ddfd0fdd-a74b-49c4-820d-4f2324fa12f3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1198615-570f-4b90-b9fc-5dbf87925416"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f43b0d17-d630-4e37-93f5-d8eeb8109fb0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("001c0229-da10-4d73-8771-85a0e0576cd5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("15c7e04a-722f-4cf3-bbd9-4ca75668d4cf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("17b35de2-6c0e-4b2c-b10e-79d88ae6a3cd"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("24c5555a-4e95-45e9-bf34-dc48c7ab9939"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("307b93ee-fe43-4036-ac59-81def692efd6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3b92f090-098c-4538-9ddd-204bffc5e44e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5f6ecfa1-5e4f-45ce-88a0-bee75f0c0cd6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5fe767cd-379a-4749-9fae-660ac179d0a8"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7706dfd1-e9ce-4214-99b3-2fee4fc51003"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a280fb78-a6e9-426f-a38c-b10f2d4111ca"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ff87a791-7b77-4e82-8fef-f07b22389963"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("eb29d00d-604f-4744-8fb4-fac3ef0db9ea"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("09d30a9d-e978-433c-9cf0-13e899adfe29"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("0a5183e3-d620-431d-916b-98f4a7ae5a4f"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("23a38512-9cff-47ad-9531-316ad4e8cd25"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("2c76427f-3358-4736-9638-ca4a9114b1a4"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("2fa9e3f7-9ca3-48a1-9fc5-e276d8f843a8"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("400b1f29-2507-495e-bc9a-143c20efe5f4"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("4709129d-604f-492b-9872-16e39a767a16"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("52c19bd2-f2c0-4cf9-945b-54288a65b0b8"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("5f4a8261-55cf-40de-8e52-12b6cbeb850a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("7b385e6e-2e10-4379-a541-03b68a110bb1"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("8d5ed9b3-f90e-4334-9360-eb3a04c8925a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("c193caca-5831-48e8-8cfb-c3f8002c04fc"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("c2906e4b-9731-4d23-ab10-818e5b47f9ea"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("d0a3b77c-d151-4503-90a2-87f6a5bd1a6d"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("ebad9018-637f-4d01-9941-e45ce2acafce"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("ee12a43a-b4c1-4659-9bfd-249e7ca55af4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("077b8a92-baf0-4a35-894e-ea3942cb5412"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f95d3f1-24fa-4e02-9dab-6a1ed73ee746"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b94397a-d6d8-4811-9c00-5b1392618373"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("912c5bf7-21e7-4b63-a599-58ed6e860967"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b313ba91-7573-434e-9b17-3afb7f14d2ac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee552c9a-2a04-4618-9480-9da2e0652f23"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("0b982120-735b-4e9b-9207-609ead4d5d85"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("1676d649-c588-4c58-9ba8-c4d2de9cac94"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("246557ac-83d5-4de5-b07b-eedbadaec443"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("41a794fc-dd4f-4a3b-ab66-2e623da3eb38"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("4c8edabc-a963-421c-89f3-48100e9ef2d5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("62951070-b660-4f38-b533-3aa18d5c8e2d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("7b844144-9588-4f3c-af8d-543e2eee08b2"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("7ca764b2-8522-49da-be1b-31e403f03634"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("ad31748c-a335-42a9-a446-e7803879681b"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("b6537ae8-16a8-4d6e-84f9-77a717e7e0ef"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("bf2a9d86-4f29-4ef3-adac-570b98301d78"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("14cedc24-6ed9-41d9-8333-700f9a9e806b"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("5d57d9a5-dea9-4077-a2d9-1b8398ca90c7"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("8838a598-c57c-4202-a6c0-ba23ed35eb4f"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("f98df395-fe31-4f6f-87ec-f9f7ae29ee7a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5021f3f6-7922-4bc2-85a9-a0df2b49d1a9"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("089ba557-2125-49c6-a743-407beeb96f18"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("be217011-a787-4eca-9d27-9931ffd1c4a9"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("8a5473ad-60ef-470b-a49d-e02c1c51b812"));

            migrationBuilder.RenameColumn(
                name: "ActualCostPerPerson",
                table: "TripPointReviews",
                newName: "ActualCost");

            migrationBuilder.AlterColumn<Guid>(
                name: "TripPointId",
                table: "TripPointReviews",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0789f9b3-9128-4993-9344-92854163c40e"), null, "natural", null },
                    { new Guid("5cc9ccbb-787b-471d-833d-a0ac23c14b8e"), null, "national park", null },
                    { new Guid("6d2a6b57-48a9-4aed-af20-ae17faa0013b"), null, "leisure", null },
                    { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), null, "tourism", null },
                    { new Guid("a187c81c-52a6-4946-b777-815f03eda525"), null, "entertainment", null },
                    { new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67"), null, "catering", null },
                    { new Guid("ccc222d8-07a7-4e3d-a20c-f61846dfc6bd"), null, "sport", null },
                    { new Guid("daa3ceff-177a-47cc-8af1-4b103eac66c9"), null, "commercial", null },
                    { new Guid("e20fa339-f829-4a3a-a0c6-b93c31eeeac7"), null, "religion", null },
                    { new Guid("f6a81e7c-d360-4a3a-80b6-9f46c129ab14"), null, "activity", null },
                    { new Guid("fc4c37b7-2c8c-4837-b39c-4a8d70e802c2"), null, "heritage", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("08fbdb8a-f6b1-4323-82c7-af1c982928ad"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("17ed99dd-c1ea-4527-86c5-42c0512e3c80"), null, "wheelchair", null },
                    { new Guid("48b1bb7b-1e66-40a3-a202-446e2dee10ca"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("69641d1f-b6e9-432a-b8bd-a09778261991"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("6ff8b746-a9e6-4ada-b940-94706f5f1b57"), "Name property defined for the place", "named", null },
                    { new Guid("9efcb48e-2462-4455-8623-78127faff7b4"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("afb0fc07-286b-4878-9516-41edf7d90b1b"), null, "access", null },
                    { new Guid("ba2b4316-94c8-4c34-9cc7-c024e6a70cc4"), null, "internet_access", null },
                    { new Guid("da7cbc5d-678c-476d-a4f6-c88cdb4749c6"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("db9be5f2-f3e5-4438-aceb-1b1eaa02f94d"), null, "fee", null },
                    { new Guid("dbc945ad-950d-4e49-8384-eac52e9f9022"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("dd37ea3f-02fd-42e9-b124-8a635ab87528"), null, "dogs", null },
                    { new Guid("e12dff0f-c2f3-4d7f-87f6-f76f96b9771d"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("eaff08bc-8878-44f7-9f0b-3a6a9a088239"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("ee4b6987-8721-4300-b2c4-40c11f1493f9"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("f134e68a-dc4b-4415-9354-21c1c4990d2b"), null, "no-dogs", null },
                    { new Guid("f3e21044-0c33-4dc3-9ee1-69072416b2f1"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("fc588292-bf79-4cf7-87f3-a37b25470f61"), null, "access_limited", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("18d5d777-9ffe-4453-ba97-1f8fd4566055"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null },
                    { new Guid("4e13a368-da09-4c09-a15d-d04b1d3c7187"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceCategoryId", "PlaceType", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("6ecdc831-a2ad-416f-af44-f1ac7016961a"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", null, "CustomPlace", null, null },
                    { new Guid("7d50733b-dcbb-4eda-a286-5764d1902831"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", null, "CustomPlace", null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("82683e34-046a-4820-a729-94496bbf0db5"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" },
                    { new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null },
                    { new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("ca730bb3-ed49-4089-9173-89e888ee142e"), null, null, null, null, null, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceCategoryId", "PlaceType", "State", "Street" },
                values: new object[] { new Guid("d6f89f49-a10c-42ab-af9a-b75b66b39752"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", null, "CustomPlace", null, null });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("06420f8e-2e7e-4b09-818c-a6a2921f3403"), null, "gift_and_souvenir", new Guid("daa3ceff-177a-47cc-8af1-4b103eac66c9") },
                    { new Guid("1c2fbdbf-f730-450c-b25c-9dc716b7a45b"), null, "food_court", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") },
                    { new Guid("28d5b991-73ad-447a-8826-7378832e5236"), null, "fast_food", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") },
                    { new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce"), null, "restaurant", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") },
                    { new Guid("363cbff6-68b4-4564-941a-ae52e5287368"), null, "planetarium", new Guid("a187c81c-52a6-4946-b777-815f03eda525") },
                    { new Guid("3d052a8d-7e73-48af-9323-f4f096adfd1c"), null, "bar", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") },
                    { new Guid("51b96b42-34ce-4c77-9b2e-05bd14afb9e0"), null, "art", new Guid("daa3ceff-177a-47cc-8af1-4b103eac66c9") },
                    { new Guid("552ce0d7-b2e7-45ed-8703-3f7b04f6f70e"), null, "water", new Guid("0789f9b3-9128-4993-9344-92854163c40e") },
                    { new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841"), null, "place_of_worship", new Guid("e20fa339-f829-4a3a-a0c6-b93c31eeeac7") },
                    { new Guid("63db8c6f-9b8e-4a6e-bfa9-ea9313ba10a6"), null, "ice_cream", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") },
                    { new Guid("71f9ba76-b5d0-4423-9bcb-91467e79de69"), null, "museum", new Guid("a187c81c-52a6-4946-b777-815f03eda525") },
                    { new Guid("74856229-2665-4329-8ebc-5b9c66974815"), null, "unesco", new Guid("fc4c37b7-2c8c-4837-b39c-4a8d70e802c2") },
                    { new Guid("7ad84070-41a1-4897-b7d6-fa9e4f60f3de"), null, "mountain", new Guid("0789f9b3-9128-4993-9344-92854163c40e") },
                    { new Guid("7ec8d765-84dc-462c-b796-3da21dd2ea85"), null, "forest", new Guid("0789f9b3-9128-4993-9344-92854163c40e") },
                    { new Guid("7f81d157-84fa-4e1d-bbe0-ac00ed3ce5c8"), null, "biergarten", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") },
                    { new Guid("8103820e-0e91-493c-a0c6-be673c7e7fe8"), null, "pub", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") },
                    { new Guid("8d87784d-0219-4054-9e56-85207fce1fde"), null, "taproom", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") },
                    { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), null, "sights", new Guid("959b3cce-93ce-45e0-90fb-85e041625b22") },
                    { new Guid("a75a7dcb-f8c6-40b3-80ce-c6355ff45b5a"), null, "stadium", new Guid("ccc222d8-07a7-4e3d-a20c-f61846dfc6bd") },
                    { new Guid("acd429d1-2735-45bc-9242-49a09ba19ad3"), null, "attraction", new Guid("959b3cce-93ce-45e0-90fb-85e041625b22") },
                    { new Guid("b4b22662-74a7-4b20-b0eb-365129ada511"), null, "sand", new Guid("0789f9b3-9128-4993-9344-92854163c40e") },
                    { new Guid("b580a409-9c40-4ab4-9a4d-0f39e091a39d"), null, "park", new Guid("6d2a6b57-48a9-4aed-af20-ae17faa0013b") },
                    { new Guid("cba641d1-0907-40cc-b65c-06bd0576d88c"), null, "zoo", new Guid("a187c81c-52a6-4946-b777-815f03eda525") },
                    { new Guid("ce69dd1c-5750-41c8-b924-357ec4398ada"), null, "culture", new Guid("a187c81c-52a6-4946-b777-815f03eda525") },
                    { new Guid("d4746dfb-ba14-4e83-b80e-3ffa403c7578"), null, "aquarium", new Guid("a187c81c-52a6-4946-b777-815f03eda525") },
                    { new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef"), null, "cafe", new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("21503305-83bb-4552-b4ca-e0029f8ddd76"), "Places that are available for public", "yes", new Guid("afb0fc07-286b-4878-9516-41edf7d90b1b") },
                    { new Guid("21e6b4ff-1be2-45e1-9873-f40a8a91db2b"), null, "yes", new Guid("dd37ea3f-02fd-42e9-b124-8a635ab87528") },
                    { new Guid("2530de8b-86ed-4181-a800-c0fe44b4117c"), null, "only", new Guid("f3e21044-0c33-4dc3-9ee1-69072416b2f1") },
                    { new Guid("260ee7cc-e3e5-47e0-a777-2663e3f9bb2e"), null, "not_specified", new Guid("eaff08bc-8878-44f7-9f0b-3a6a9a088239") },
                    { new Guid("38c0e921-8163-4d71-aae5-236031cac899"), null, "leashed", new Guid("dd37ea3f-02fd-42e9-b124-8a635ab87528") },
                    { new Guid("450a21e1-be40-40d8-a155-9bb050beb2ca"), null, "for_customers", new Guid("ba2b4316-94c8-4c34-9cc7-c024e6a70cc4") },
                    { new Guid("648beda9-9f4e-40f9-9c7f-61bf32ed9a82"), null, "yes", new Guid("17ed99dd-c1ea-4527-86c5-42c0512e3c80") },
                    { new Guid("6e6dbb45-9e71-4253-a578-b3a96d061316"), null, "limited", new Guid("17ed99dd-c1ea-4527-86c5-42c0512e3c80") },
                    { new Guid("73542cea-3730-4282-98b8-60be344bcda0"), null, "only", new Guid("9efcb48e-2462-4455-8623-78127faff7b4") },
                    { new Guid("845712ba-a88a-4989-a40b-301fae512ab6"), null, "not_specified", new Guid("afb0fc07-286b-4878-9516-41edf7d90b1b") },
                    { new Guid("a2bf258e-0b72-4ce8-8192-209d9c1b9944"), null, "only", new Guid("08fbdb8a-f6b1-4323-82c7-af1c982928ad") },
                    { new Guid("a861d30f-d4d2-4ad3-b902-7557864302f9"), null, "customers", new Guid("fc588292-bf79-4cf7-87f3-a37b25470f61") },
                    { new Guid("aa60e7a5-ed28-4b75-8fc2-97a8996fd81b"), null, "free", new Guid("ba2b4316-94c8-4c34-9cc7-c024e6a70cc4") },
                    { new Guid("b39bfb4b-1d39-427a-a43c-05a04a4e7163"), null, "only", new Guid("69641d1f-b6e9-432a-b8bd-a09778261991") },
                    { new Guid("b9805432-53d7-4725-9095-0996ea7d8c59"), null, "no", new Guid("eaff08bc-8878-44f7-9f0b-3a6a9a088239") },
                    { new Guid("ffaaa913-cbce-4898-87f3-50d6b1faa382"), null, "only", new Guid("da7cbc5d-678c-476d-a4f6-c88cdb4749c6") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a") },
                    { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("82683e34-046a-4820-a729-94496bbf0db5") },
                    { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f") },
                    { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f") },
                    { new Guid("959b3cce-93ce-45e0-90fb-85e041625b22"), new Guid("ca730bb3-ed49-4089-9173-89e888ee142e") },
                    { new Guid("c02d3369-7e80-477f-9f78-3ff938e90d67"), new Guid("4e13a368-da09-4c09-a15d-d04b1d3c7187") }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[] { new Guid("4ed76fd2-cbcc-4e6b-857d-e0d98c14c4f5"), 100m, null, null, "PLN", new Guid("18d5d777-9ffe-4453-ba97-1f8fd4566055"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("013a2825-9f01-4760-a7a7-fc4d14d3850b"), null, "international", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("018f9dd1-edda-4cd8-bb46-bd00f87a8e96"), null, "moroccan", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("05f80f83-1168-43cd-8ee3-074375001efa"), null, "ethiopian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("09eee82e-3c09-4c0a-905a-90cb9b01391b"), null, "glacier", new Guid("7ad84070-41a1-4897-b7d6-fa9e4f60f3de") },
                    { new Guid("0a3a0e12-861a-4783-84e6-c70440eb6f8d"), null, "chinese", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("0d0e2c46-9fa3-4e3a-b07f-7b6f25c7786f"), null, "tower", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("0d1995d5-4f5f-4fb5-b6d9-5eeca2194019"), null, "croatian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("0dee3ea1-3a21-4a0b-8501-9de4dfd001ec"), null, "soup", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("12cab8c3-11ea-447a-b168-f0f0f9384584"), null, "nature_reserve", new Guid("b580a409-9c40-4ab4-9a4d-0f39e091a39d") },
                    { new Guid("159b9b5e-250f-4096-857d-53b923c31afb"), null, "barbecue", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("16138026-f801-46ac-8931-eb0c35c39cf6"), null, "irish", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("18ff8d74-5aed-4cdc-a7a4-ab429648288b"), null, "fountain", new Guid("acd429d1-2735-45bc-9242-49a09ba19ad3") },
                    { new Guid("19c1b727-d694-4249-9fc3-eb87fc5af093"), null, "oriental", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("19d69886-5a91-48a8-b5a8-f680f8681077"), null, "german", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("1c6cd8c3-b4e3-4440-b75f-286c7d6dc9dd"), null, "japanese", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("22594842-4184-4cac-984b-69968644456e"), null, "pita", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("22af9e75-db53-41ca-b2e4-99d576f2e7b8"), null, "austrian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("236102cd-77d6-41e5-80c9-1904a05b5a13"), null, "tacos", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("23aab49f-6fba-4726-b28c-d418c5a47bfc"), null, "coffee", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("23bc663f-63ea-406b-88b1-86aefdd026b4"), null, "hot_spring", new Guid("552ce0d7-b2e7-45ed-8703-3f7b04f6f70e") },
                    { new Guid("2563b037-01d0-4edc-87ce-6a43d5d6a7e7"), null, "cliff", new Guid("7ad84070-41a1-4897-b7d6-fa9e4f60f3de") },
                    { new Guid("25caa567-584b-4b47-ad95-7ff7d2237584"), null, "hawaiian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("268f25d7-7473-434f-8899-3715b5891653"), null, "dumpling", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("271937d3-0210-45ec-bc00-d5cc7facdf63"), null, "mexican", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("2748485a-ff8f-446b-bfd0-735e6292ef56"), null, "chicken", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("274ce82f-f222-49c4-8aaf-d499b848eab9"), null, "lebanese", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("2a9bed78-ccc7-427c-893a-b55dae165090"), null, "cake", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("2b9d6be0-bd9a-4225-a8ec-8ba52faea4b6"), null, "islam", new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841") },
                    { new Guid("2c2b651f-a3b0-493b-8643-7cc65f2eb999"), null, "tapas", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("2fab3743-982d-4c4d-ab54-5aaa86733f64"), null, "malay", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("2feca23f-8e4e-4c52-bafd-cb521b650ba6"), null, "geyser", new Guid("552ce0d7-b2e7-45ed-8703-3f7b04f6f70e") },
                    { new Guid("31313e82-a835-44cc-80f8-f23a46fbe436"), null, "korean", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("3154c8a3-d141-42f3-85f3-93adaafaaff5"), null, "pizza", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("32ad21a5-a2f1-4522-94da-f5b14a29073d"), null, "latin_american", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("33869efb-3fc5-42bc-b342-549303dfb689"), null, "city_gate", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("384860fd-e710-41b8-82d8-af5200554dc5"), null, "swedish", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("39915d82-104e-4a33-a130-62e9922e8127"), null, "castle", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("3bb754c2-141c-461d-9e33-6e5efbad0eb5"), null, "turkish", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("3bf5c4e1-6e0d-4ca5-aff2-6a8fc45f9b7f"), null, "pita", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("3c4cce2b-8cc5-4457-b875-8cb01627e22e"), null, "mediterranean", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("3d93bc44-975f-4d26-8851-bf3f0502697b"), null, "christianity", new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841") },
                    { new Guid("3e958eb4-ef0c-4fad-86dc-8a16a99d98f3"), null, "hinduism", new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841") },
                    { new Guid("41e6630a-bc9e-46fa-9959-e0bc821638f8"), null, "bubble_tea", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("446b0f3e-29ed-44fb-8195-3461326f3a96"), null, "noodle", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("45b45f14-0799-4ce8-a137-2ba408108455"), null, "steak_house", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("46624022-60be-498f-8bab-fc297ab42196"), null, "european", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("468d2c48-3389-4511-9b47-221cd1ec055c"), null, "georgian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("4842ef3b-6614-416d-a6b5-be1b6c7d3f50"), null, "battlefield", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("4c4af931-e9bc-4a1b-ba2e-69bb138d66ce"), null, "cave_entrance", new Guid("7ad84070-41a1-4897-b7d6-fa9e4f60f3de") },
                    { new Guid("4e6fdf4a-3d79-49df-8b02-c99194b88817"), null, "asian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("50b27744-7121-4e56-8eed-dceccfc1979a"), null, "ramen", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("515f3aff-41b8-4162-96c7-6e3e4ddcaf73"), null, "fish_and_chips", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("517fef41-3524-4768-aa50-c19ca7765c2e"), null, "multifaith", new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841") },
                    { new Guid("51de9c3b-0741-49f6-99f9-aabf8f9d966e"), null, "coffee_shop", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("53b7a4cb-4f87-460d-b9f9-30721b3cb0df"), null, "kebab", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("568b77d6-721f-4560-a879-fd5fc7b0e346"), null, "indian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("58faa8ea-f88c-42d9-a458-00a0ae0c38a0"), null, "western", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("59e2cb30-0ef5-4354-a868-63d622bae041"), null, "pizza", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("5a143e7c-659f-4840-bfb2-e25913b3ecbe"), null, "wings", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("5ad313b1-d0ea-4fa3-8ae3-eff538e39728"), null, "tex-mex", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("5c8d619d-5b79-4c57-9516-94c08cbb8438"), null, "salad", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("5cb566db-7045-46ac-9aaa-7e8aaff191a0"), null, "african", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("5e174085-60a6-4178-9096-ccafaf01f964"), null, "shinto", new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841") },
                    { new Guid("5e563109-0dd1-4b60-832f-fd5bcbd7a002"), null, "czech", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("5ebec78e-2baa-40a4-8596-47c31b48f1ce"), null, "ukrainian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("5f7c22d5-e3d7-43eb-a302-79425e821b77"), null, "spanish", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("60181110-8590-47ca-93de-87cfb0e7d9cf"), null, "ruines", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("613deee1-1e52-48a9-91f0-5efc3e63decb"), null, "reef", new Guid("552ce0d7-b2e7-45ed-8703-3f7b04f6f70e") },
                    { new Guid("6194ae5f-71b0-4c9e-8e87-885139e47149"), null, "donut", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("6344d487-77d0-4ab4-a8d1-a6b764188c03"), null, "syrian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("645b50c9-0ae8-4bf7-8945-5a3be83987cd"), null, "regional", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("66d193b7-298b-4ab2-a6b0-1660189a79ed"), null, "tacos", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("69b92d0a-ea7e-4742-a71c-5c73a34148aa"), null, "persian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("6a5ac8ab-ef60-477d-bc7a-93b026aac2d5"), null, "sandwich", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("6abee01d-749f-4d8b-8500-1729c250015b"), null, "gallery", new Guid("ce69dd1c-5750-41c8-b924-357ec4398ada") },
                    { new Guid("6b53f39a-dbb1-4691-a34f-d6f4c9c8387e"), null, "bavarian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("6c14a33b-b50e-44ad-bad5-e81e8a6220c9"), null, "brazilian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("6c68704a-ce97-48a1-b8a0-8e58daae7ff2"), null, "waffle", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("6cea8284-d1a3-41ad-b01e-9f954cac04e5"), null, "cuban", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("6d0980e6-4e55-4513-bb0e-64301cc3e489"), null, "sandwich", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("6ded772e-0631-493b-8bec-1fdbc36bcfae"), null, "friture", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("6f19f9e6-9ba3-4cc4-ace8-76899d2a7b7b"), null, "judaism", new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841") },
                    { new Guid("6f9b676f-47d8-4b9c-9908-04a08f2afb7a"), null, "bridge", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("722406a0-27be-44c0-ad73-bced422d2daa"), null, "windmill", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("75f15c3d-4ec2-45ef-b249-974800633ac6"), null, "taiwanese", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("760728e0-dbb5-444c-b425-c57738220572"), null, "beef_bowl", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("7bfe4741-edce-4762-8985-b2e700eb1726"), null, "fish_and_chips", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("7e76c7de-7049-40d1-95cb-e6195cd78079"), null, "sea", new Guid("552ce0d7-b2e7-45ed-8703-3f7b04f6f70e") },
                    { new Guid("7ed68025-5c5e-4e1e-a27d-4443773a18c6"), null, "rock", new Guid("7ad84070-41a1-4897-b7d6-fa9e4f60f3de") },
                    { new Guid("828c02e3-eab1-4cfc-a65b-c9b13701caa6"), null, "bolivian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("84e7a77e-1f0d-43d1-91c5-585aade68f56"), null, "viewpoint", new Guid("acd429d1-2735-45bc-9242-49a09ba19ad3") },
                    { new Guid("86937121-8cf2-413d-9651-74793b9637e5"), null, "arab", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("876f470a-0b07-4dd3-a746-b5d6d3a55777"), null, "arts_centre", new Guid("ce69dd1c-5750-41c8-b924-357ec4398ada") },
                    { new Guid("8ae41d5f-c7ff-4c78-bdc6-d40d38018f22"), null, "artwork", new Guid("acd429d1-2735-45bc-9242-49a09ba19ad3") },
                    { new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942"), null, "place_of_worship", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("8e3dd8e9-dddd-401c-8964-95d230797bda"), null, "garden", new Guid("b580a409-9c40-4ab4-9a4d-0f39e091a39d") },
                    { new Guid("94f311b2-c722-4bb1-aeaa-a3c9093dd461"), null, "burger", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("96348313-e435-4ae9-9dfb-a066308d016f"), null, "fort", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("963e1214-30b5-4fe0-b208-c8cffdb60631"), null, "portuguese", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("969a4f41-39a6-414f-bf4a-e4fdbe46851e"), null, "kebab", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("986edc7d-e2dc-4d07-a262-1ed3dd93da0d"), null, "hungarian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("9c7c7a67-ae6d-4ba7-ba70-5725eeca07d3"), null, "thai", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("9ef8cd56-41ff-4394-973b-8ebd5a3b5969"), null, "american", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("a0e1f6ec-5f0d-4324-bb3c-72b57d522876"), null, "city_hall", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("a2f1d4b4-63c6-429e-b1a2-8b9994399565"), null, "danish", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("a6698a84-1f02-4c42-8e4d-e8ab533fafe0"), null, "vietnamese", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("a71392e2-d172-4733-b2b9-0941f43445a0"), null, "ice_cream", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("a7c60674-82db-48ee-8781-0aaa4067c540"), null, "clock", new Guid("acd429d1-2735-45bc-9242-49a09ba19ad3") },
                    { new Guid("a8edc9dc-b352-4479-872e-8ae6f15f2dbc"), null, "jamaican", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("a9a276fa-28d9-4cc2-80fc-c84345702fd1"), null, "dessert", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("a9d829c5-2627-4c77-a468-935a8eb2315a"), null, "fish", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("ac7cd707-fe33-4b82-a540-56d7db988ad5"), null, "tea", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("ad522001-3091-449c-be67-b5c36a585c80"), null, "soup", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("b188811b-fc11-4f35-817e-410224966b12"), null, "french", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("b23a5bab-8c23-46cb-89a8-fffbcf95def4"), null, "buddhism", new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841") },
                    { new Guid("b23aced2-1d32-4e10-b18e-0f6249f96708"), null, "ramen", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("b58d7963-dbef-48d6-977b-78bb917ed05e"), null, "caribbean", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("b6123e06-c37f-4da9-87e7-3cd09a6f5e7c"), null, "crepe", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("b6b552cf-9587-46b1-a57c-2e842bfa9f2e"), null, "greek", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("b873c487-8827-4857-abb5-9eb680b5f0ea"), null, "hot_dog", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("b928ba1b-d802-4f9e-8163-1d3d70c9bab3"), null, "sushi", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("bd208401-681f-4a47-b394-a781eaf91e87"), null, "monastery", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("bf334930-638f-4988-8590-9aba44533ea2"), null, "curry", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("c192e66f-7ff7-443b-a14b-9439b3d854a7"), null, "noodle", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("c32ca54a-0919-4d26-af6b-8c19724d9402"), null, "balkan", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), null, "memorial", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("cda3a7ac-d48a-45ae-93aa-cdd394082418"), null, "uzbek", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("cf14b5b6-17c5-466e-94ad-5331fdca0db9"), null, "wings", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("d274a67d-336c-45b1-b4e0-73da0803d227"), null, "seafood", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("d465dd37-b50f-4294-bddc-c37536fcfa36"), null, "indonesian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("d6466a96-9b0c-4eb8-8280-e69268a5e032"), null, "frozen_yogurt", new Guid("f19fb138-c3d3-4c13-a33a-a7d1bbdf22ef") },
                    { new Guid("d7d984bc-2960-4c73-9c3d-e14c1e1c49bc"), null, "peruvian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("d95ebe55-6407-49e4-81e5-0b02270a4c80"), null, "belgian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("d9b9723d-06d5-4b3a-b85c-155e8592bfeb"), null, "russian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("db541c56-f4b2-43cc-8e1e-0e1f8980fa1e"), null, "lighthouse", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("dc76428b-2a2b-4970-a29f-dad6956460b9"), null, "argentinian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("dfb735b7-b09d-4d02-8d21-811e3460db44"), null, "nepalese", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("e0abb266-8330-46b1-bf99-5cf50b2b00a6"), null, "spring", new Guid("552ce0d7-b2e7-45ed-8703-3f7b04f6f70e") },
                    { new Guid("e5b08dd8-25c6-4b4d-8f69-4265ff8a2241"), null, "archaeological_site", new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab") },
                    { new Guid("e5f5df25-c64d-4d11-b06f-bfed37235754"), null, "burger", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("e6117c3f-4b47-43f9-951b-41623a2b064c"), null, "theatre", new Guid("ce69dd1c-5750-41c8-b924-357ec4398ada") },
                    { new Guid("e6a814e3-7a00-4607-a877-4e0da36cd4bf"), null, "pakistani", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("e7aa451e-fac6-4d68-8698-2ca6094b1cb3"), null, "italian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("e8af69c8-b38a-4567-b242-2d720a54e20e"), null, "peak", new Guid("7ad84070-41a1-4897-b7d6-fa9e4f60f3de") },
                    { new Guid("e90b7771-3b1e-4f64-af11-0faac275debe"), null, "malaysian", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("eccb7d1b-c510-4ba9-9993-936734a4b65b"), null, "dune", new Guid("b4b22662-74a7-4b20-b0eb-365129ada511") },
                    { new Guid("ee633848-6cd8-4295-ac5d-3649f240c954"), null, "afghan", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("ef0e8f16-58b7-429b-95af-07733f2386e1"), null, "tapas", new Guid("28d5b991-73ad-447a-8826-7378832e5236") },
                    { new Guid("f002f885-8838-4d7c-8ea5-03c554421fa5"), null, "filipino", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("fabcaf57-d87c-4a70-b85a-33b3bd3d5c7a"), null, "chili", new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce") },
                    { new Guid("fea3d392-7441-4041-addf-65ed5a69048d"), null, "sikhism", new Guid("5776fb52-4cc0-4f22-8249-0e6bd3e0d841") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("2e82b9af-736a-404c-a48e-f50daa9c7dce"), new Guid("4e13a368-da09-4c09-a15d-d04b1d3c7187") },
                    { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a") },
                    { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("82683e34-046a-4820-a729-94496bbf0db5") },
                    { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f") },
                    { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f") },
                    { new Guid("a6a8acf2-281c-4d04-ab8f-6318545c70ab"), new Guid("ca730bb3-ed49-4089-9173-89e888ee142e") },
                    { new Guid("acd429d1-2735-45bc-9242-49a09ba19ad3"), new Guid("ca730bb3-ed49-4089-9173-89e888ee142e") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400"), new DateOnly(2024, 12, 20), new Guid("4ed76fd2-cbcc-4e6b-857d-e0d98c14c4f5") },
                    { new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409"), new DateOnly(2024, 12, 21), new Guid("4ed76fd2-cbcc-4e6b-857d-e0d98c14c4f5") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("13a39a4e-2ea9-4546-995d-214eb9800186"), null, "temple", new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942") },
                    { new Guid("13aa4762-b2e8-4f54-846f-24985e7da0b3"), null, "railway_car", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("1415a474-b2e2-42ec-9635-ff735c6099aa"), null, "monument", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("35048098-b9b7-4815-a5fb-15e3df220bf5"), null, "chapel", new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942") },
                    { new Guid("57aba794-f801-4ab5-b4f6-9b95a746f8f3"), null, "aircraft", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("7a4ed036-c382-44a7-bd38-79ad59bf9995"), null, "wayside_cross", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("823b99e4-96f0-427b-8dfb-39fb228db8c2"), null, "church", new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942") },
                    { new Guid("83ad9f02-8b8b-410d-a78f-6d9dc91f67b6"), null, "ship", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("84786c4b-bb6a-4500-8c3d-806a737c3208"), null, "synagogue", new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942") },
                    { new Guid("8dfe6a43-9640-44fe-a497-d195b6f908eb"), null, "pillory", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("90009a3f-4c2f-4f90-99a6-fd97b4b50764"), null, "mosque", new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942") },
                    { new Guid("98b5ab11-70f1-4268-b3d7-22d19dddb18d"), null, "milestone", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("a304c5bd-439b-40bb-9bef-20b9edced420"), null, "tomb", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("ab03490c-0e99-46dd-9ecc-be661f80c9bc"), null, "shrine", new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942") },
                    { new Guid("cdbde128-b2e3-45fe-8282-479660f0ffad"), null, "tank", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("dd642cd8-47b6-48ae-b452-6c8ca8e9b4a5"), null, "boundary_stone", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") },
                    { new Guid("edebeef4-d0b0-439d-b04c-df9224903c5d"), null, "cathedral", new Guid("8d9b95b5-d2a7-4e66-bca1-ea71d1139942") },
                    { new Guid("f8611f7e-b37d-4006-acb1-f72d9374f15f"), null, "locomotive", new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("60181110-8590-47ca-93de-87cfb0e7d9cf"), new Guid("ca730bb3-ed49-4089-9173-89e888ee142e") },
                    { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a") },
                    { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), new Guid("82683e34-046a-4820-a729-94496bbf0db5") },
                    { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f") },
                    { new Guid("ca5ff4c1-b802-46f9-938c-b5900781b51c"), new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("0217a31a-8a85-4bf4-b760-4064a0a726f5"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("84a7f948-c61c-44e8-8433-c261e2228b1f"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409") },
                    { new Guid("2bb551ef-4529-407a-94b6-5d85c1e1311d"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("d6f89f49-a10c-42ab-af9a-b75b66b39752"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409") },
                    { new Guid("3fdc2ecd-af6b-417c-b2c1-6caecaba728d"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("7d50733b-dcbb-4eda-a286-5764d1902831"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400") },
                    { new Guid("4a9e7960-6819-4455-b809-33b26760c7bc"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("4e13a368-da09-4c09-a15d-d04b1d3c7187"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409") },
                    { new Guid("5d73540b-1ead-424f-b2e0-b81f463a1b7e"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("82683e34-046a-4820-a729-94496bbf0db5"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409") },
                    { new Guid("b039d988-27d3-4f6a-a116-275f18789f2e"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("ca730bb3-ed49-4089-9173-89e888ee142e"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400") },
                    { new Guid("d012dffc-b063-472e-9f3b-c97b52a214ae"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("aa090cd8-6bac-4bfe-a363-7e4d5c760f3f"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400") },
                    { new Guid("dd651955-e2ac-4b3b-a783-a6af764c3a31"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("6ecdc831-a2ad-416f-af44-f1ac7016961a"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400") },
                    { new Guid("e95390c4-27e4-4874-a868-0cdf210f0a13"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("5cdadfcb-c0ad-484f-8691-9dfcd1b16f7a"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400") }
                });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "ToTripPointId", "TransferTime", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("2ddfeec2-e0a8-4bab-8002-81989d75893a"), new Guid("5d73540b-1ead-424f-b2e0-b81f463a1b7e"), 2, new Guid("0217a31a-8a85-4bf4-b760-4064a0a726f5"), new TimeSpan(0, 0, 3, 13, 0), new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409") },
                    { new Guid("38a7f3d4-90f9-4c56-8ecf-595228fb40fe"), new Guid("4a9e7960-6819-4455-b809-33b26760c7bc"), 3, new Guid("2bb551ef-4529-407a-94b6-5d85c1e1311d"), new TimeSpan(0, 0, 13, 30, 0), new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409") },
                    { new Guid("54f55648-cf3d-430c-8f5b-882d2903d1f7"), new Guid("e95390c4-27e4-4874-a868-0cdf210f0a13"), 1, new Guid("3fdc2ecd-af6b-417c-b2c1-6caecaba728d"), new TimeSpan(0, 0, 0, 55, 0), new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400") },
                    { new Guid("6979489f-20c1-4507-958e-5e09518cec8e"), new Guid("d012dffc-b063-472e-9f3b-c97b52a214ae"), 0, new Guid("e95390c4-27e4-4874-a868-0cdf210f0a13"), new TimeSpan(0, 0, 4, 21, 0), new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400") },
                    { new Guid("8d06c9f1-0dfa-4cc2-a0d1-2ed1478b456d"), new Guid("3fdc2ecd-af6b-417c-b2c1-6caecaba728d"), null, new Guid("dd651955-e2ac-4b3b-a783-a6af764c3a31"), new TimeSpan(0, 0, 20, 0, 0), new Guid("7f03960f-5aa8-4c53-b7e4-93e731376400") },
                    { new Guid("deaeeef0-3763-49df-973e-19c483191140"), new Guid("0217a31a-8a85-4bf4-b760-4064a0a726f5"), 3, new Guid("4a9e7960-6819-4455-b809-33b26760c7bc"), new TimeSpan(0, 0, 8, 18, 0), new Guid("f6c3dc8a-1019-4282-a70d-2b9478be4409") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripPointReviews_TripPointId",
                table: "TripPointReviews",
                column: "TripPointId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TripPointReviews_TripPoints_TripPointId",
                table: "TripPointReviews",
                column: "TripPointId",
                principalTable: "TripPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
