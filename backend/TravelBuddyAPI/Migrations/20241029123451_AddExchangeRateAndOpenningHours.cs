using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddExchangeRateAndOpenningHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "Trips",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "TripPoints",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "TripPointReviews",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpenningHours",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("1a07bac2-dfc0-4593-9067-b57a798978b5"), null, "commercial", null },
                    { new Guid("1e59325e-fe66-4564-9cdf-abaee170251e"), null, "natural", null },
                    { new Guid("39f6371a-0499-4068-bc89-0b2cd966dfcc"), null, "national park", null },
                    { new Guid("4f8a160f-0810-47a4-ae96-5fe86a8d45d5"), null, "heritage", null },
                    { new Guid("5d866186-94e9-4ca8-b9b2-3d27d7d0afa0"), null, "religion", null },
                    { new Guid("6523405c-43b3-41f0-b2ae-40f8460f12bf"), null, "tourism", null },
                    { new Guid("700378ee-daf4-4717-a677-01a4b41626e6"), null, "leisure", null },
                    { new Guid("94bebc4e-90c5-473f-bb6a-069b6adda8f1"), null, "entertainment", null },
                    { new Guid("a4d5b73e-ef11-4c35-9311-430cf5668469"), null, "activity", null },
                    { new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7"), null, "catering", null },
                    { new Guid("dea0b229-93a4-4bd7-95e2-171997480b99"), null, "sport", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("086d43ab-7b86-4a52-972c-4cc907dfcca7"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("1c6fccbe-58ac-4b3c-86c0-cc363cf9c40a"), null, "wheelchair", null },
                    { new Guid("1ffd0bd7-10a9-4d60-8a3a-a014e04b4778"), null, "fee", null },
                    { new Guid("302aadc6-a941-4369-897c-00d2cfb9b1e2"), null, "access", null },
                    { new Guid("3997e4ba-ebc0-4a23-81c5-87534df7007c"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("42a49c09-ee25-4da6-9b26-1a83d2bf3ada"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("4dc45197-72a3-44d8-93ee-29a1d9b8b910"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("69a4acb9-74db-4d71-a284-46402b01dfa4"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("732530ea-2d44-43bc-9d69-777f97434727"), "Name property defined for the place", "named", null },
                    { new Guid("7b836cf0-a6b9-44b5-a635-7f8f77d0509a"), null, "no-dogs", null },
                    { new Guid("89bd7bed-19e6-4efe-a27f-d0ef027412cc"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("8eb2f7b3-eeff-4efd-be28-87bf3b780942"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("9c8c602c-0644-4218-97b3-76c9ed4feef0"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("a9ef5392-6f8f-44f8-8fbb-4da3f17f01c9"), null, "internet_access", null },
                    { new Guid("b9cea2a9-4d40-412f-813b-32eca31a1f3e"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("d36dc7f9-e13a-4f41-8524-4fa0253f0f2c"), null, "access_limited", null },
                    { new Guid("d4341c00-702c-4175-b4c3-78d1a6ceb52f"), null, "dogs", null },
                    { new Guid("e49942e1-f9bf-4611-a179-5a1ded01eb5c"), "Places where you can buy or eat organic food", "organic", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("1d27851c-91c1-47fe-bf02-4c4d6ad6a8bf"), null, "gift_and_souvenir", new Guid("1a07bac2-dfc0-4593-9067-b57a798978b5") },
                    { new Guid("3c0bcf74-228a-4e2c-af9d-360396fc41f1"), null, "zoo", new Guid("94bebc4e-90c5-473f-bb6a-069b6adda8f1") },
                    { new Guid("3d8ebd19-7bc6-4bcd-88de-7f91533fbe09"), null, "unesco", new Guid("4f8a160f-0810-47a4-ae96-5fe86a8d45d5") },
                    { new Guid("4123a70f-c635-4d9a-86db-87fb55378b47"), null, "planetarium", new Guid("94bebc4e-90c5-473f-bb6a-069b6adda8f1") },
                    { new Guid("48a06fc7-2400-4543-b14e-1876696c142c"), null, "art", new Guid("1a07bac2-dfc0-4593-9067-b57a798978b5") },
                    { new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791"), null, "cafe", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("5b7f7497-4128-4e76-bcd1-caf0706b5a06"), null, "stadium", new Guid("dea0b229-93a4-4bd7-95e2-171997480b99") },
                    { new Guid("706bc6a7-f596-4303-a4b1-c376d7a77aaf"), null, "sand", new Guid("1e59325e-fe66-4564-9cdf-abaee170251e") },
                    { new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e"), null, "fast_food", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7"), null, "restaurant", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666"), null, "sights", new Guid("6523405c-43b3-41f0-b2ae-40f8460f12bf") },
                    { new Guid("832c8721-90f0-4bb5-a75e-dec6e695cc7b"), null, "biergarten", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("8d2ca363-c5eb-469f-85dc-96a5e5ea9f91"), null, "food_court", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("913ccef7-0d12-45c7-a58f-ffb8b3fc3e24"), null, "forest", new Guid("1e59325e-fe66-4564-9cdf-abaee170251e") },
                    { new Guid("99f2a70f-3456-4cac-b42b-33d71ffbf00f"), null, "water", new Guid("1e59325e-fe66-4564-9cdf-abaee170251e") },
                    { new Guid("9c8e7225-0747-4b61-b6de-cf7922ed3398"), null, "museum", new Guid("94bebc4e-90c5-473f-bb6a-069b6adda8f1") },
                    { new Guid("a31fb443-a283-475e-afca-cef92f910379"), null, "ice_cream", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("bcaf5a82-96c6-4c00-93d2-28f4ec9349df"), null, "culture", new Guid("94bebc4e-90c5-473f-bb6a-069b6adda8f1") },
                    { new Guid("bd30d249-f573-49e5-bed8-1ced12ff7fec"), null, "bar", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62"), null, "place_of_worship", new Guid("5d866186-94e9-4ca8-b9b2-3d27d7d0afa0") },
                    { new Guid("ccc33ef4-ed24-4a4e-abb0-5216a8501dfb"), null, "pub", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("cdab002c-0662-474f-9dc4-88da2f6d85aa"), null, "attraction", new Guid("6523405c-43b3-41f0-b2ae-40f8460f12bf") },
                    { new Guid("ceec0664-4b85-4108-b1fc-b29385386188"), null, "mountain", new Guid("1e59325e-fe66-4564-9cdf-abaee170251e") },
                    { new Guid("dc1f1ff9-b7bb-4b38-860f-cce3b5c4173e"), null, "taproom", new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7") },
                    { new Guid("e571ff7c-9751-4826-a79b-b2ea4ea29f43"), null, "aquarium", new Guid("94bebc4e-90c5-473f-bb6a-069b6adda8f1") },
                    { new Guid("f743f3ce-7ff2-4516-9a95-7d5526b73fc7"), null, "park", new Guid("700378ee-daf4-4717-a677-01a4b41626e6") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("240eea33-ff6f-47b9-9f33-9ffbc61302f6"), "Places that are available for public", "yes", new Guid("302aadc6-a941-4369-897c-00d2cfb9b1e2") },
                    { new Guid("6446c1c2-4262-4ca4-90d5-68ba427832a6"), null, "free", new Guid("a9ef5392-6f8f-44f8-8fbb-4da3f17f01c9") },
                    { new Guid("71fbbf9d-4f9d-4bfa-a82a-a9182d4d4968"), null, "only", new Guid("3997e4ba-ebc0-4a23-81c5-87534df7007c") },
                    { new Guid("7f1b4cda-fafc-40cc-95fd-940ca8abe50d"), null, "limited", new Guid("1c6fccbe-58ac-4b3c-86c0-cc363cf9c40a") },
                    { new Guid("86a1f0b1-85e0-44f2-8e1c-2ab19b4ecf5a"), null, "not_specified", new Guid("302aadc6-a941-4369-897c-00d2cfb9b1e2") },
                    { new Guid("8981efa4-c8b0-40ca-8060-761f101f3019"), null, "leashed", new Guid("d4341c00-702c-4175-b4c3-78d1a6ceb52f") },
                    { new Guid("96836d53-ba9a-4984-ac0c-da26990a1f35"), null, "only", new Guid("89bd7bed-19e6-4efe-a27f-d0ef027412cc") },
                    { new Guid("9d2c7722-3103-429b-b13e-466612ce8f75"), null, "for_customers", new Guid("a9ef5392-6f8f-44f8-8fbb-4da3f17f01c9") },
                    { new Guid("a0cd62c4-bfce-4fa3-bf11-c9a7160c2ecf"), null, "only", new Guid("4dc45197-72a3-44d8-93ee-29a1d9b8b910") },
                    { new Guid("aef8c6fa-622a-45d3-bf0a-7b226f7ef272"), null, "not_specified", new Guid("8eb2f7b3-eeff-4efd-be28-87bf3b780942") },
                    { new Guid("c214ef2c-04e4-4426-b408-44a44c9968ae"), null, "only", new Guid("e49942e1-f9bf-4611-a179-5a1ded01eb5c") },
                    { new Guid("cdffdc43-bb78-41c9-9ec3-f9e0258b244e"), null, "customers", new Guid("d36dc7f9-e13a-4f41-8524-4fa0253f0f2c") },
                    { new Guid("d111d07b-f9b9-4f24-8563-9920e8ebe448"), null, "yes", new Guid("d4341c00-702c-4175-b4c3-78d1a6ceb52f") },
                    { new Guid("d5e44992-5875-4d24-a5e2-34aaf9ec28a6"), null, "no", new Guid("8eb2f7b3-eeff-4efd-be28-87bf3b780942") },
                    { new Guid("e33deea8-eefc-4c3f-8052-13a64dfe938d"), null, "only", new Guid("086d43ab-7b86-4a52-972c-4cc907dfcca7") },
                    { new Guid("e958746c-cd58-4a32-a0ae-dde91324c2de"), null, "yes", new Guid("1c6fccbe-58ac-4b3c-86c0-cc363cf9c40a") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("000a7da4-018e-469b-bc3e-bfd5fae1ae65"), null, "western", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("008cb668-b382-4539-bdb5-212b8d39d4ca"), null, "multifaith", new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62") },
                    { new Guid("00d4d1c4-e6a1-4f83-ab3d-d97d52283083"), null, "barbecue", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("0397e689-0c5e-406e-85d0-e6eedd1496df"), null, "coffee_shop", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("03a4cf6c-930e-4b4c-b15c-b5b1e09bfec4"), null, "castle", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("05b3e79a-d83a-4480-801b-d2247a91300d"), null, "hawaiian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("07cb7bf4-ed0d-41d3-a8e4-185969ac733d"), null, "battlefield", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("0b2fffc8-183d-4725-8f47-f9be63700c5a"), null, "asian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("0d08b544-f2ce-46ea-b2f9-8fc364c3a7fa"), null, "city_gate", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("0dc2173d-89dd-4243-87fa-153496aa68a2"), null, "greek", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("0de3eca0-f8b7-49d6-bb3e-792bd44f9cd7"), null, "fountain", new Guid("cdab002c-0662-474f-9dc4-88da2f6d85aa") },
                    { new Guid("0fcd3d89-7939-4921-bd92-6afd6e89b586"), null, "chicken", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("19107b41-5fe7-4459-be48-a068de87ebb1"), null, "ramen", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("19a3c251-c6f4-4bf3-ad6a-8b0cbefb6e01"), null, "artwork", new Guid("cdab002c-0662-474f-9dc4-88da2f6d85aa") },
                    { new Guid("1a8d5c82-f1b8-47c1-b378-b5f76ffcee00"), null, "bubble_tea", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("1b3e8986-bde4-4ea9-8c97-5d653b3ab4f7"), null, "tapas", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("1c5788bc-406e-472e-b7eb-dbef62e9f2d1"), null, "japanese", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("1fac5caa-fafe-4de5-9434-e8458a39beec"), null, "burger", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("1fec6c21-00c3-473e-81ff-bd2135bf9324"), null, "tex-mex", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("21f5955d-f2be-447c-ab1a-c9f2cdd6aceb"), null, "nature_reserve", new Guid("f743f3ce-7ff2-4516-9a95-7d5526b73fc7") },
                    { new Guid("27ef47fe-83dc-4187-91c5-8c1ae19a51f4"), null, "lighthouse", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("2947caec-6bf3-48d4-8b9b-ea30d9670d00"), null, "shinto", new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62") },
                    { new Guid("2c79fab7-76c9-496b-aa85-10c4282b082e"), null, "nepalese", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("2d071585-f86c-4052-83a6-9fa26027c46a"), null, "kebab", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("2e097e02-d685-48d5-9e96-3fe6a000ed83"), null, "indonesian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("31fdeeb8-a24e-46ab-9433-61dd54a6f05d"), null, "czech", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("356c09d7-23f8-4d19-9055-ce478fd9fd4f"), null, "pakistani", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("360d046c-94b3-4368-92d0-1664ccba2bac"), null, "persian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("380260c0-3459-46ad-87fe-5fa8918aa536"), null, "pizza", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("3a659dc0-f56d-4df8-8155-2d758ae03f08"), null, "hungarian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("3abd7e29-f745-4223-996e-ff4f1b03fc7e"), null, "jamaican", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("3faf5400-5af6-4384-bd56-b35595a06264"), null, "german", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("435267d4-68dd-4363-b997-869a63d718d4"), null, "tacos", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("4356ebc6-381f-4d60-88fc-4e10271b9da5"), null, "archaeological_site", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("44316a54-3e10-4d5f-b50a-78457b945ca3"), null, "sikhism", new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62") },
                    { new Guid("45c1832e-4901-4c29-a56e-ba7b7073bf20"), null, "taiwanese", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("45ce98bd-ce01-4166-9dd7-3e2520861f75"), null, "cave_entrance", new Guid("ceec0664-4b85-4108-b1fc-b29385386188") },
                    { new Guid("508411fa-0727-4911-b4c5-042b82ac7748"), null, "spring", new Guid("99f2a70f-3456-4cac-b42b-33d71ffbf00f") },
                    { new Guid("51d1dfe0-eb3e-433d-8192-52f68f3aeb83"), null, "turkish", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("524b7d8a-b864-4d10-b9e3-41ea11b5c5c2"), null, "pita", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("52d4854a-0585-4a3a-be2a-9a87e87bd14e"), null, "arts_centre", new Guid("bcaf5a82-96c6-4c00-93d2-28f4ec9349df") },
                    { new Guid("542ae756-eb7d-4a25-9291-a9c40be292c5"), null, "noodle", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("56a8de2d-2f20-4704-93ae-caaa55f749d7"), null, "buddhism", new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62") },
                    { new Guid("581020c1-cb93-4d90-8ee1-21c831c87ed1"), null, "bolivian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("581d9524-6378-4780-9958-e43f4cd6f70b"), null, "noodle", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("587b0ee6-1ea1-46d6-a40d-acf605a12b36"), null, "tacos", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("58c49972-fc79-42a3-83dc-49010ec9a528"), null, "ruines", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("5976f288-f2c4-4c8f-b7c7-0309a841acb2"), null, "irish", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("5a1f61e2-6e46-4394-9c29-dbb7c75d4a49"), null, "hinduism", new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62") },
                    { new Guid("5b43285c-06ac-4fac-bcc6-78b8b6c113e9"), null, "wings", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f"), null, "memorial", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("5d8bf5ef-9101-4222-96b5-e60e5bae0f68"), null, "russian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("5e935ebf-8a8f-4ca3-9965-2ec5b0c4d2bf"), null, "latin_american", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("606900cd-56e8-423a-b8d8-077a291c019f"), null, "coffee", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("60874137-a9c6-49c7-80af-51733a8acb2e"), null, "pizza", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("613fafff-35bf-41bf-a0df-083d9df3af4a"), null, "danish", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("61781fcd-c97a-41e1-89d4-0a8551402ba3"), null, "ice_cream", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("62359fc6-42e7-4270-bb2a-1aa5a8d39fc0"), null, "donut", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("62d0edbb-257a-4de8-a9f3-cf5a115a3508"), null, "international", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("671eef66-8489-41a1-af66-37e377549d26"), null, "georgian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("6a045503-9ac2-434f-8399-1951096a6a97"), null, "argentinian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("6ac0f341-74b4-4b1d-88f2-20207dcff997"), null, "steak_house", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("6d22975a-c6d5-40f1-86eb-bfd9e5abe3ca"), null, "french", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("6d9b6280-5506-4d31-9e70-dd8c0a4ff011"), null, "moroccan", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("7027d670-f007-4259-9295-69afc952b350"), null, "dessert", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("7028cbaf-990b-49cf-a9cc-1187a9cab30e"), null, "european", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("73d1be83-29cb-49de-b2df-76ffffee3fe7"), null, "judaism", new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62") },
                    { new Guid("764cb290-bb0d-49e4-839c-d9f84b9d7c71"), null, "seafood", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("7bed9af3-f550-41c1-bb85-aca9ace2ea3f"), null, "tapas", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("7c271871-199e-4081-a9a0-8aabdead7df7"), null, "bridge", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("802e048b-dff9-4930-a242-d0658da8fd67"), null, "friture", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("816f8f07-b8e1-4895-9c17-619762e045f4"), null, "fish_and_chips", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("824a9a9c-6f14-497a-8278-950ec227e38a"), null, "afghan", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("82b53169-23a1-4afe-b0b0-2cb1436c797e"), null, "american", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("82c01d48-8531-44fb-9fd0-299fcf942fc1"), null, "croatian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("82d50ad1-4dd6-49f9-aa01-5960a61ab492"), null, "arab", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("83ef57d6-021a-4583-a135-7bd77c36841e"), null, "ramen", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("8644cde1-c44c-4bb0-bfbf-2d4ebe21572b"), null, "chinese", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("868cdb81-794b-45f9-bbfe-639cf8aae862"), null, "windmill", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("8a45cbd7-cf45-46e1-a200-be4eeb53443f"), null, "caribbean", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("8ac465b0-007f-4cb9-8b62-d025d01992c4"), null, "malaysian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("8c13a6dc-9c68-49e0-90a4-30a86f54832a"), null, "beef_bowl", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("8c681a46-3d56-48b8-82d1-69334f7a90aa"), null, "geyser", new Guid("99f2a70f-3456-4cac-b42b-33d71ffbf00f") },
                    { new Guid("8d268f61-bce9-4a93-8d01-0183e8e4b174"), null, "mediterranean", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("8d6f2ed4-33ce-4dad-9dbb-1802651bd7bb"), null, "gallery", new Guid("bcaf5a82-96c6-4c00-93d2-28f4ec9349df") },
                    { new Guid("8eaa9888-c407-4168-b637-7c494abd0eab"), null, "sushi", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("92f1c2dd-9a59-4cb0-af8d-eb88c133e92f"), null, "filipino", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("94df45e6-7b7b-4dc9-923f-3bccdd38c833"), null, "ethiopian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("982cc056-a060-433f-8a1b-1c1a2b23ee08"), null, "brazilian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("989ba55f-8c00-4275-8841-fb2079f7d9be"), null, "tower", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("9b081cc9-9af5-4ad1-8d68-30e2a65e3512"), null, "korean", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("9b102e2f-590c-45bd-afb1-2011bff8f146"), null, "vietnamese", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("9c45d908-f378-434e-b55c-82c9a36e4869"), null, "kebab", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("9c677019-baff-403d-bdff-29414c009e8a"), null, "viewpoint", new Guid("cdab002c-0662-474f-9dc4-88da2f6d85aa") },
                    { new Guid("9c9a60e3-f093-4a20-b1cb-43f6871b83e1"), null, "dumpling", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("9d6a483d-0200-4d00-97b5-9d01251cc5bc"), null, "mexican", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("9ec0bcbf-9c90-4168-ae6e-8064df5dae92"), null, "islam", new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62") },
                    { new Guid("a0b3cd3d-b146-4fb2-8712-394b242e59f5"), null, "dune", new Guid("706bc6a7-f596-4303-a4b1-c376d7a77aaf") },
                    { new Guid("a7ba4bef-624e-4f79-bbc0-635883794ed6"), null, "curry", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("a980578d-b7fc-4af7-b356-80c5687a3505"), null, "sandwich", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("aa008b5b-6b63-425a-ba4e-e1b481d26f4a"), null, "clock", new Guid("cdab002c-0662-474f-9dc4-88da2f6d85aa") },
                    { new Guid("ab55e7b7-457d-4ce9-a1b5-c2c6393cece0"), null, "rock", new Guid("ceec0664-4b85-4108-b1fc-b29385386188") },
                    { new Guid("ab5c1dee-ae0a-4736-97a2-7103c65d8052"), null, "belgian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("ab5dd236-1a9e-4fea-b933-8488c50ae354"), null, "hot_dog", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("ab6ee76d-125c-4e0c-b5e5-25632ed20ab1"), null, "bavarian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("acba883e-5751-47eb-b77c-160f5bbe6af4"), null, "lebanese", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("aed5f2fd-ce6d-4847-afc1-2b03bb77a117"), null, "italian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2"), null, "place_of_worship", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("b52e08d0-87c0-4c86-922b-924887ee1255"), null, "glacier", new Guid("ceec0664-4b85-4108-b1fc-b29385386188") },
                    { new Guid("b71511de-ed5f-4e11-a8e0-7eb5586ff721"), null, "wings", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("bbe46a60-79de-413b-b5f1-c6169f2475e3"), null, "oriental", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("bc3342e2-034d-48a9-b4cd-987372f0cc31"), null, "theatre", new Guid("bcaf5a82-96c6-4c00-93d2-28f4ec9349df") },
                    { new Guid("bcdd0166-6928-41e5-8fa6-6e51d82ee923"), null, "fish_and_chips", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("bf5bf8fe-57a8-46c0-9637-fd9e82280ef7"), null, "spanish", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("c3a4a137-8499-4759-b815-c3baf348b0ab"), null, "cake", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("c5b6d5cf-2ad1-467c-a904-cc5e7c61f507"), null, "thai", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("c6537ab6-bd41-4ea8-bc2f-b1278cd92626"), null, "reef", new Guid("99f2a70f-3456-4cac-b42b-33d71ffbf00f") },
                    { new Guid("c83d19c6-2522-4990-8c04-00b68ba1b060"), null, "portuguese", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("c83e844c-6ddf-425b-a558-6f8687d9388a"), null, "sea", new Guid("99f2a70f-3456-4cac-b42b-33d71ffbf00f") },
                    { new Guid("c87b76f1-4ce6-464e-b319-6c6f158181c5"), null, "christianity", new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62") },
                    { new Guid("c9969533-8f82-4bdf-9024-169ab004691a"), null, "waffle", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("cd2e09dc-0748-4ef4-b1c3-6e43e864bde3"), null, "hot_spring", new Guid("99f2a70f-3456-4cac-b42b-33d71ffbf00f") },
                    { new Guid("d3d0a4db-52ab-44cd-803b-c877c0a26b3e"), null, "fort", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("d621ba70-aceb-4381-b5af-8282de83234c"), null, "sandwich", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("d64b14db-7a95-41b8-b266-7c4086cc9606"), null, "chili", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("d79d6c57-0aef-47fb-8586-e59441c9c9c1"), null, "fish", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("d98dee07-7224-4b7a-b750-1574dbbcfa92"), null, "burger", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("da04af91-175c-435f-93d5-1cfbde31faff"), null, "pita", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("da750ea6-5327-4795-a521-e7dde380f722"), null, "ukrainian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("ddca919a-1fff-4936-b9dd-48ed7bfbdb40"), null, "frozen_yogurt", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("e1b4e94f-11b8-4a63-9891-85345bfe4d5c"), null, "crepe", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("e3fc4eb6-f2d2-42e8-9f23-9033d173b7f0"), null, "garden", new Guid("f743f3ce-7ff2-4516-9a95-7d5526b73fc7") },
                    { new Guid("e4a0c7e2-7b7e-4221-83ab-b7d3d9701b0e"), null, "soup", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("e4aaece8-937a-48b0-9404-0b5ceb535c72"), null, "swedish", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("e4df1fbe-50b3-4851-97f7-361d207f180d"), null, "peak", new Guid("ceec0664-4b85-4108-b1fc-b29385386188") },
                    { new Guid("e741b064-2d6f-47d5-8609-24a03b9a8091"), null, "cuban", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("e852876f-9cd1-4d3f-8540-20204a22b409"), null, "balkan", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("ea906f63-c92e-4bd2-92a4-832ce3ade742"), null, "salad", new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e") },
                    { new Guid("eabb28cb-87d8-4c88-896c-87dfb1fb3bec"), null, "austrian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("eb5e76c0-78e3-4858-94f7-28753dc5960b"), null, "uzbek", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("ec4959fd-39fd-4dde-b934-44217ec1727d"), null, "indian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("f04881b4-4a81-4896-8e9e-e1ac61d0c1f6"), null, "city_hall", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("f2b85077-45df-4408-a676-40e0a87293cd"), null, "syrian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("f770679f-6eae-4413-bd9d-a272912428c1"), null, "tea", new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791") },
                    { new Guid("f845afb6-76ad-46b9-b70f-487a2efbf278"), null, "regional", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("f94e9bba-7d97-4e36-b2bf-d4cba5073777"), null, "african", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("fc4d03db-15e8-42b3-b12e-c8497b2910ea"), null, "monastery", new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666") },
                    { new Guid("fd0321e3-a3a9-4370-bddd-6f420fb28287"), null, "cliff", new Guid("ceec0664-4b85-4108-b1fc-b29385386188") },
                    { new Guid("fed80e2f-a00c-4bc1-a727-c7a29eeb55e4"), null, "peruvian", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("feef391a-ce07-4b7c-81b2-e4e2f5737833"), null, "soup", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("ff9d94db-4ae4-4dd9-8a90-8a1dfe8d1f43"), null, "malay", new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7") },
                    { new Guid("32424a78-4a5e-4206-bddc-90956446fac4"), null, "tomb", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("4718369e-fabe-4546-9dd4-ea778e5a47c4"), null, "temple", new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2") },
                    { new Guid("53580aa4-3b35-4e3e-8474-20be7ae285d2"), null, "chapel", new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2") },
                    { new Guid("5dff5d59-d151-4763-82b8-73ffdf3ba0f6"), null, "mosque", new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2") },
                    { new Guid("6549fa9b-bf09-485d-b9d8-d9285c4260e0"), null, "wayside_cross", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("73560e40-6d12-4cef-bb58-2c8df2e58e71"), null, "tank", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("85bd5dda-2ec9-4fd5-9138-95bb051c9f65"), null, "pillory", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("8a04f8da-2699-4900-8922-c296db641071"), null, "synagogue", new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2") },
                    { new Guid("8a95df9d-a5da-44cb-b6d7-9965ffa547c3"), null, "railway_car", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("9a28428f-3499-419d-abb9-6f807d39702d"), null, "church", new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2") },
                    { new Guid("a13a0331-0bc0-4fc5-856c-9845bcbc9264"), null, "shrine", new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2") },
                    { new Guid("b0678e78-ec01-47a8-8af8-28bea17a6f2e"), null, "aircraft", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("b484410c-f7b8-482e-9d6d-4b02644923da"), null, "locomotive", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("cd760fa4-86fb-4231-a8b5-f730c6c3fb88"), null, "monument", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("cd99ca4f-1a53-492c-a8d1-1efe80c094ab"), null, "ship", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("d99f9ce8-0521-4b3f-a80c-77ff562d817a"), null, "cathedral", new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2") },
                    { new Guid("e59b6d29-b47b-4e83-b338-2d9012d58e8c"), null, "boundary_stone", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") },
                    { new Guid("ed9041f2-6278-4e7e-9395-62e9af4b69fd"), null, "milestone", new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("000a7da4-018e-469b-bc3e-bfd5fae1ae65"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("008cb668-b382-4539-bdb5-212b8d39d4ca"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("00d4d1c4-e6a1-4f83-ab3d-d97d52283083"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0397e689-0c5e-406e-85d0-e6eedd1496df"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("03a4cf6c-930e-4b4c-b15c-b5b1e09bfec4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05b3e79a-d83a-4480-801b-d2247a91300d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("07cb7bf4-ed0d-41d3-a8e4-185969ac733d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b2fffc8-183d-4725-8f47-f9be63700c5a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d08b544-f2ce-46ea-b2f9-8fc364c3a7fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0dc2173d-89dd-4243-87fa-153496aa68a2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0de3eca0-f8b7-49d6-bb3e-792bd44f9cd7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0fcd3d89-7939-4921-bd92-6afd6e89b586"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("19107b41-5fe7-4459-be48-a068de87ebb1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("19a3c251-c6f4-4bf3-ad6a-8b0cbefb6e01"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a8d5c82-f1b8-47c1-b378-b5f76ffcee00"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b3e8986-bde4-4ea9-8c97-5d653b3ab4f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c5788bc-406e-472e-b7eb-dbef62e9f2d1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d27851c-91c1-47fe-bf02-4c4d6ad6a8bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fac5caa-fafe-4de5-9434-e8458a39beec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fec6c21-00c3-473e-81ff-bd2135bf9324"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("21f5955d-f2be-447c-ab1a-c9f2cdd6aceb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("27ef47fe-83dc-4187-91c5-8c1ae19a51f4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2947caec-6bf3-48d4-8b9b-ea30d9670d00"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c79fab7-76c9-496b-aa85-10c4282b082e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d071585-f86c-4052-83a6-9fa26027c46a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e097e02-d685-48d5-9e96-3fe6a000ed83"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31fdeeb8-a24e-46ab-9433-61dd54a6f05d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("32424a78-4a5e-4206-bddc-90956446fac4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("356c09d7-23f8-4d19-9055-ce478fd9fd4f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("360d046c-94b3-4368-92d0-1664ccba2bac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("380260c0-3459-46ad-87fe-5fa8918aa536"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("39f6371a-0499-4068-bc89-0b2cd966dfcc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3a659dc0-f56d-4df8-8155-2d758ae03f08"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3abd7e29-f745-4223-996e-ff4f1b03fc7e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c0bcf74-228a-4e2c-af9d-360396fc41f1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d8ebd19-7bc6-4bcd-88de-7f91533fbe09"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3faf5400-5af6-4384-bd56-b35595a06264"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4123a70f-c635-4d9a-86db-87fb55378b47"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("435267d4-68dd-4363-b997-869a63d718d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4356ebc6-381f-4d60-88fc-4e10271b9da5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("44316a54-3e10-4d5f-b50a-78457b945ca3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45c1832e-4901-4c29-a56e-ba7b7073bf20"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45ce98bd-ce01-4166-9dd7-3e2520861f75"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4718369e-fabe-4546-9dd4-ea778e5a47c4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("48a06fc7-2400-4543-b14e-1876696c142c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("508411fa-0727-4911-b4c5-042b82ac7748"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51d1dfe0-eb3e-433d-8192-52f68f3aeb83"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("524b7d8a-b864-4d10-b9e3-41ea11b5c5c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("52d4854a-0585-4a3a-be2a-9a87e87bd14e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("53580aa4-3b35-4e3e-8474-20be7ae285d2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("542ae756-eb7d-4a25-9291-a9c40be292c5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("56a8de2d-2f20-4704-93ae-caaa55f749d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("581020c1-cb93-4d90-8ee1-21c831c87ed1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("581d9524-6378-4780-9958-e43f4cd6f70b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("587b0ee6-1ea1-46d6-a40d-acf605a12b36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58c49972-fc79-42a3-83dc-49010ec9a528"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5976f288-f2c4-4c8f-b7c7-0309a841acb2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a1f61e2-6e46-4394-9c29-dbb7c75d4a49"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b43285c-06ac-4fac-bcc6-78b8b6c113e9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b7f7497-4128-4e76-bcd1-caf0706b5a06"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d8bf5ef-9101-4222-96b5-e60e5bae0f68"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5dff5d59-d151-4763-82b8-73ffdf3ba0f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e935ebf-8a8f-4ca3-9965-2ec5b0c4d2bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("606900cd-56e8-423a-b8d8-077a291c019f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("60874137-a9c6-49c7-80af-51733a8acb2e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("613fafff-35bf-41bf-a0df-083d9df3af4a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("61781fcd-c97a-41e1-89d4-0a8551402ba3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62359fc6-42e7-4270-bb2a-1aa5a8d39fc0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62d0edbb-257a-4de8-a9f3-cf5a115a3508"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6549fa9b-bf09-485d-b9d8-d9285c4260e0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("671eef66-8489-41a1-af66-37e377549d26"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a045503-9ac2-434f-8399-1951096a6a97"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ac0f341-74b4-4b1d-88f2-20207dcff997"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d22975a-c6d5-40f1-86eb-bfd9e5abe3ca"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d9b6280-5506-4d31-9e70-dd8c0a4ff011"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7027d670-f007-4259-9295-69afc952b350"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7028cbaf-990b-49cf-a9cc-1187a9cab30e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73560e40-6d12-4cef-bb58-2c8df2e58e71"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73d1be83-29cb-49de-b2df-76ffffee3fe7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("764cb290-bb0d-49e4-839c-d9f84b9d7c71"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bed9af3-f550-41c1-bb85-aca9ace2ea3f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c271871-199e-4081-a9a0-8aabdead7df7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("802e048b-dff9-4930-a242-d0658da8fd67"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("816f8f07-b8e1-4895-9c17-619762e045f4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("824a9a9c-6f14-497a-8278-950ec227e38a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82b53169-23a1-4afe-b0b0-2cb1436c797e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82c01d48-8531-44fb-9fd0-299fcf942fc1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82d50ad1-4dd6-49f9-aa01-5960a61ab492"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("832c8721-90f0-4bb5-a75e-dec6e695cc7b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83ef57d6-021a-4583-a135-7bd77c36841e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("85bd5dda-2ec9-4fd5-9138-95bb051c9f65"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8644cde1-c44c-4bb0-bfbf-2d4ebe21572b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("868cdb81-794b-45f9-bbfe-639cf8aae862"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8a04f8da-2699-4900-8922-c296db641071"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8a45cbd7-cf45-46e1-a200-be4eeb53443f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8a95df9d-a5da-44cb-b6d7-9965ffa547c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ac465b0-007f-4cb9-8b62-d025d01992c4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c13a6dc-9c68-49e0-90a4-30a86f54832a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c681a46-3d56-48b8-82d1-69334f7a90aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d268f61-bce9-4a93-8d01-0183e8e4b174"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d2ca363-c5eb-469f-85dc-96a5e5ea9f91"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d6f2ed4-33ce-4dad-9dbb-1802651bd7bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8eaa9888-c407-4168-b637-7c494abd0eab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("913ccef7-0d12-45c7-a58f-ffb8b3fc3e24"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("92f1c2dd-9a59-4cb0-af8d-eb88c133e92f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("94df45e6-7b7b-4dc9-923f-3bccdd38c833"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("982cc056-a060-433f-8a1b-1c1a2b23ee08"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("989ba55f-8c00-4275-8841-fb2079f7d9be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a28428f-3499-419d-abb9-6f807d39702d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b081cc9-9af5-4ad1-8d68-30e2a65e3512"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b102e2f-590c-45bd-afb1-2011bff8f146"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c45d908-f378-434e-b55c-82c9a36e4869"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c677019-baff-403d-bdff-29414c009e8a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c8e7225-0747-4b61-b6de-cf7922ed3398"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c9a60e3-f093-4a20-b1cb-43f6871b83e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d6a483d-0200-4d00-97b5-9d01251cc5bc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ec0bcbf-9c90-4168-ae6e-8064df5dae92"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0b3cd3d-b146-4fb2-8712-394b242e59f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a13a0331-0bc0-4fc5-856c-9845bcbc9264"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a31fb443-a283-475e-afca-cef92f910379"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a4d5b73e-ef11-4c35-9311-430cf5668469"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7ba4bef-624e-4f79-bbc0-635883794ed6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a980578d-b7fc-4af7-b356-80c5687a3505"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa008b5b-6b63-425a-ba4e-e1b481d26f4a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab55e7b7-457d-4ce9-a1b5-c2c6393cece0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab5c1dee-ae0a-4736-97a2-7103c65d8052"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab5dd236-1a9e-4fea-b933-8488c50ae354"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab6ee76d-125c-4e0c-b5e5-25632ed20ab1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("acba883e-5751-47eb-b77c-160f5bbe6af4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aed5f2fd-ce6d-4847-afc1-2b03bb77a117"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0678e78-ec01-47a8-8af8-28bea17a6f2e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b484410c-f7b8-482e-9d6d-4b02644923da"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b52e08d0-87c0-4c86-922b-924887ee1255"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b71511de-ed5f-4e11-a8e0-7eb5586ff721"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bbe46a60-79de-413b-b5f1-c6169f2475e3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc3342e2-034d-48a9-b4cd-987372f0cc31"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bcdd0166-6928-41e5-8fa6-6e51d82ee923"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd30d249-f573-49e5-bed8-1ced12ff7fec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf5bf8fe-57a8-46c0-9637-fd9e82280ef7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a137-8499-4759-b815-c3baf348b0ab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c5b6d5cf-2ad1-467c-a904-cc5e7c61f507"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6537ab6-bd41-4ea8-bc2f-b1278cd92626"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c83d19c6-2522-4990-8c04-00b68ba1b060"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c83e844c-6ddf-425b-a558-6f8687d9388a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c87b76f1-4ce6-464e-b319-6c6f158181c5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9969533-8f82-4bdf-9024-169ab004691a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccc33ef4-ed24-4a4e-abb0-5216a8501dfb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd2e09dc-0748-4ef4-b1c3-6e43e864bde3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd760fa4-86fb-4231-a8b5-f730c6c3fb88"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd99ca4f-1a53-492c-a8d1-1efe80c094ab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d3d0a4db-52ab-44cd-803b-c877c0a26b3e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d621ba70-aceb-4381-b5af-8282de83234c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d64b14db-7a95-41b8-b266-7c4086cc9606"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d79d6c57-0aef-47fb-8586-e59441c9c9c1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d98dee07-7224-4b7a-b750-1574dbbcfa92"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d99f9ce8-0521-4b3f-a80c-77ff562d817a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("da04af91-175c-435f-93d5-1cfbde31faff"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("da750ea6-5327-4795-a521-e7dde380f722"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc1f1ff9-b7bb-4b38-860f-cce3b5c4173e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ddca919a-1fff-4936-b9dd-48ed7bfbdb40"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1b4e94f-11b8-4a63-9891-85345bfe4d5c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3fc4eb6-f2d2-42e8-9f23-9033d173b7f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4a0c7e2-7b7e-4221-83ab-b7d3d9701b0e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4aaece8-937a-48b0-9404-0b5ceb535c72"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4df1fbe-50b3-4851-97f7-361d207f180d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e571ff7c-9751-4826-a79b-b2ea4ea29f43"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e59b6d29-b47b-4e83-b338-2d9012d58e8c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e741b064-2d6f-47d5-8609-24a03b9a8091"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e852876f-9cd1-4d3f-8540-20204a22b409"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea906f63-c92e-4bd2-92a4-832ce3ade742"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eabb28cb-87d8-4c88-896c-87dfb1fb3bec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb5e76c0-78e3-4858-94f7-28753dc5960b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec4959fd-39fd-4dde-b934-44217ec1727d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed9041f2-6278-4e7e-9395-62e9af4b69fd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f04881b4-4a81-4896-8e9e-e1ac61d0c1f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f2b85077-45df-4408-a676-40e0a87293cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f770679f-6eae-4413-bd9d-a272912428c1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f845afb6-76ad-46b9-b70f-487a2efbf278"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f94e9bba-7d97-4e36-b2bf-d4cba5073777"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc4d03db-15e8-42b3-b12e-c8497b2910ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd0321e3-a3a9-4370-bddd-6f420fb28287"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fed80e2f-a00c-4bc1-a727-c7a29eeb55e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("feef391a-ce07-4b7c-81b2-e4e2f5737833"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff9d94db-4ae4-4dd9-8a90-8a1dfe8d1f43"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1ffd0bd7-10a9-4d60-8a3a-a014e04b4778"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("240eea33-ff6f-47b9-9f33-9ffbc61302f6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("42a49c09-ee25-4da6-9b26-1a83d2bf3ada"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6446c1c2-4262-4ca4-90d5-68ba427832a6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("69a4acb9-74db-4d71-a284-46402b01dfa4"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("71fbbf9d-4f9d-4bfa-a82a-a9182d4d4968"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("732530ea-2d44-43bc-9d69-777f97434727"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7b836cf0-a6b9-44b5-a635-7f8f77d0509a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7f1b4cda-fafc-40cc-95fd-940ca8abe50d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("86a1f0b1-85e0-44f2-8e1c-2ab19b4ecf5a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8981efa4-c8b0-40ca-8060-761f101f3019"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("96836d53-ba9a-4984-ac0c-da26990a1f35"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9c8c602c-0644-4218-97b3-76c9ed4feef0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9d2c7722-3103-429b-b13e-466612ce8f75"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a0cd62c4-bfce-4fa3-bf11-c9a7160c2ecf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("aef8c6fa-622a-45d3-bf0a-7b226f7ef272"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b9cea2a9-4d40-412f-813b-32eca31a1f3e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c214ef2c-04e4-4426-b408-44a44c9968ae"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("cdffdc43-bb78-41c9-9ec3-f9e0258b244e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d111d07b-f9b9-4f24-8563-9920e8ebe448"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d5e44992-5875-4d24-a5e2-34aaf9ec28a6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e33deea8-eefc-4c3f-8052-13a64dfe938d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e958746c-cd58-4a32-a0ae-dde91324c2de"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a07bac2-dfc0-4593-9067-b57a798978b5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f8a160f-0810-47a4-ae96-5fe86a8d45d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("567f9bc2-c378-4c5e-8b5b-c4a335b85791"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5ba3187e-e340-402d-a769-b5b8c51c892f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("706bc6a7-f596-4303-a4b1-c376d7a77aaf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73bfaa2a-fd65-48ca-a295-a9ab63f7422e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a319b08-f49f-4020-a6cc-9450f8de7ee7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("99f2a70f-3456-4cac-b42b-33d71ffbf00f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3fbb9ca-d373-4777-a710-0fc0590d7ac2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bcaf5a82-96c6-4c00-93d2-28f4ec9349df"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6c83feb-9ba4-492c-b435-0e8d4f45ce62"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cdab002c-0662-474f-9dc4-88da2f6d85aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ceec0664-4b85-4108-b1fc-b29385386188"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dea0b229-93a4-4bd7-95e2-171997480b99"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f743f3ce-7ff2-4516-9a95-7d5526b73fc7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("086d43ab-7b86-4a52-972c-4cc907dfcca7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1c6fccbe-58ac-4b3c-86c0-cc363cf9c40a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("302aadc6-a941-4369-897c-00d2cfb9b1e2"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3997e4ba-ebc0-4a23-81c5-87534df7007c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4dc45197-72a3-44d8-93ee-29a1d9b8b910"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("89bd7bed-19e6-4efe-a27f-d0ef027412cc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8eb2f7b3-eeff-4efd-be28-87bf3b780942"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a9ef5392-6f8f-44f8-8fbb-4da3f17f01c9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d36dc7f9-e13a-4f41-8524-4fa0253f0f2c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d4341c00-702c-4175-b4c3-78d1a6ceb52f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e49942e1-f9bf-4611-a179-5a1ded01eb5c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1e59325e-fe66-4564-9cdf-abaee170251e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d866186-94e9-4ca8-b9b2-3d27d7d0afa0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("700378ee-daf4-4717-a677-01a4b41626e6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ae4d719-3dd0-48f7-88a0-29e24e873666"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("94bebc4e-90c5-473f-bb6a-069b6adda8f1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8a1c66d-46fe-481e-901b-595e80ecd5b7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6523405c-43b3-41f0-b2ae-40f8460f12bf"));

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "TripPoints");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "TripPointReviews");

            migrationBuilder.DropColumn(
                name: "OpenningHours",
                table: "Places");

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
    }
}
