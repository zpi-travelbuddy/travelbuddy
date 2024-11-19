using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRequiredFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("03e31e0b-ffdb-45e7-8c21-39747dd0b6e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0458fb2e-c48a-48bc-86ca-1d8f9115aea8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("04dcb3d7-1b15-4ca3-b0af-15dc022af4ed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("052ec867-3254-40a9-a899-d6ad2249fc30"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05dbbd40-ff6e-4b75-b577-6e2a99e03df4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0834bd73-6510-4c17-9f5b-59511a29ff48"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("09b830da-4132-435a-a1f5-a650215b1fd0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b8239ed-d9f2-435d-81d1-b66e8a5c56b8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b8e8aad-eea3-4c96-b600-e52f2525fa78"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("10f88d4e-e618-4030-8275-cd3710efe562"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("114e69ed-526d-4bf1-aab4-f9a1bfdd2bab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1287b467-7909-4687-a140-748b0e5f6512"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12a73074-4e0d-43b6-bedc-cd2007ff7599"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12d8c96b-af71-4ce4-aa11-31e01fd12c70"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17e98354-f6b6-4857-a4e5-c8bd01bce39f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18c964cf-28ca-4b4e-ad53-5b4ebca06bb6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("199fee46-cbfa-4abc-9ad0-3edefdc3ffd0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("19a47bf1-2c88-4396-9911-a7ebb78f18c7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1ab2e758-98a4-4814-be15-afba51656135"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d750782-23c2-4862-9418-600ea6500b7a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1e482ad5-ea03-411b-b556-b3fe557b2b0e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f08516a-df75-44fa-b05b-dac61a2fd884"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f129cfe-b903-4f94-a3dc-782c3f5ad968"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f131cb7-1a7b-4c61-96e9-e7d6e80b50ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("211f4054-7536-4acb-b1ab-f3eb2b538ef6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("22492506-e889-4332-8ba5-155643ecf4c8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("22a2444a-28a9-45ef-a868-45f1cdad8544"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2916462f-7763-4e8d-8cb9-5977cba01847"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ad9afec-cfc6-4b0e-b6e0-806ad81e8072"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e03cfc2-d3fb-4a0c-9436-d0b8698e069b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2efe5d2a-66a4-4ca5-80eb-6106e367341c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2f310161-8d23-4a92-a32e-5e2713821962"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("307aa4d5-5b5d-4bd0-83bd-8d0b89633b2c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("341f12de-8850-4106-b986-d78f994f638c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("34473868-3e60-42f7-9fea-6a26acdf2d7c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("350b2aa7-c24a-4a0b-98ec-33bb2addd3e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("357043e1-986a-4c1c-bcc4-058fda927d58"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("35e92f23-8972-46c1-a7e1-ae2b3699c576"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("39e4fb5f-bfa9-449c-af53-7daf7a0529f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fc84717-3c4a-4a91-b112-3a044ec067c0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("411335bb-358b-491b-bab0-ea8797638388"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41222fe7-0157-45b9-b869-f95e98841d02"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("429e296f-6dc6-4e4e-9b56-89e9ad1ae083"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("43596b43-e051-4370-999b-a267416b625d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("43f92418-203a-463b-9789-7830f949b60c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("458b9253-960e-44ba-a6cb-1ce7d7bdd4a5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45f0c4e5-f065-4e49-8c77-2604db8494f4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("46a721a6-5ac6-43a8-ad00-5a514537a601"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("47225852-e75e-4039-9b79-8f104cbc35ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("472b543d-1481-48fd-9e24-80bce0fe338c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("491ef2d0-3ce0-4511-b6aa-91ca2671cb49"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4933c5d0-ee41-4183-81e9-e1bdd27038d6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4af3aef4-bb14-4b5e-9342-05b918c8ee6d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4ebe7a27-5cc4-4ff1-bd7e-5d380bc8d972"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("502ff6c1-a8cd-4fea-870c-72ff9fd5c3d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("50c1e528-0589-4f40-a03b-ccdbdeca0dd7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51dcc686-0f32-44e1-ac05-577a930410a5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("523c5e38-a44c-4400-bdbf-fdae919c93be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("525765bf-7a06-4679-8ce1-f3adee9ff131"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("55bfac84-3cc1-4ad3-a59f-d419c4e92343"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5894d0d3-6935-4234-bfa1-3d140e3a3b21"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58b8332a-9070-4dd5-b1a5-809bf8cbbb75"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b2c37ae-e1bc-43e2-8252-7313683d2ff8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d168d79-f5d1-4f90-a7e3-5f6edbf1dfca"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e817807-b373-4836-9675-75f6b9c09096"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5f052a63-34b3-4c52-a452-ef69a4b10b33"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6136d038-5e04-462c-8dd6-39ac191283d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("614c062f-dbc6-4b8d-9553-da622bc8fa8a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("61571cfa-89e3-4fea-b327-18d1c4c14b80"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("63a17f7a-06b4-4a71-a56b-983c9e7d46a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("63ffafd2-728d-4810-9385-455bcd7c41da"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("64d67116-ff0a-4d7f-8336-c1748cc016b1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("655a207f-8a90-413a-bda5-306763e4f1ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("66509610-52b6-41c3-b8e6-1fc1836b7cc7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("673d1a32-40fc-488f-a6bf-f034efc49d15"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("68000558-4c2f-47a7-914a-0e0a4a0a173c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c385ab1-6689-4e9b-9d82-b87ded0a8bb0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d7743df-876a-432f-a17d-b5b7413460f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6dd93d16-4a09-4a9b-a385-820e4a71a7da"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e4e721c-0d1f-40d8-b92d-7bf004c82b17"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ed0840c-aa96-40e7-8e1d-6e12832e1603"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ee5f320-4623-4884-86b0-e077a9fc2359"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fd94e70-87f8-4efe-8e33-642f68d7b8b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7502a9ec-acf2-41ca-a11f-488bbba03103"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("751971f3-d3e4-4cf7-9577-ec235c52e7ff"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("778f73cf-4a1c-4561-bf5b-65f7abbbd430"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("78903729-9c17-4ae2-8d3b-397dbcc524d9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("78b7840a-a661-44f2-8d73-6b451d50aed7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bb0e10b-4b6a-418d-beb1-d691766a387b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bee7563-36f2-4682-8e94-d3818b068ef0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e1bcffd-98ff-4e14-9f4a-45c7979f4a79"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ec66cc3-ed91-4e35-a95f-142359fa608b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("836e6c3d-c57a-43fc-a7d6-c8083d1beec4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("857eb968-f17b-4791-afd2-c49445099023"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("882e821f-4cdc-4d9b-9ac0-9a395ef4dfaf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("88bdc1d0-dae8-4abd-ae64-5ab56a492ec4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("89d3d649-5f16-4595-88b8-9ee58126e421"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d3ec67b-341e-4fe8-9c5c-b05b3555fedd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e07a448-492d-4cbb-a698-e6d6caa7920e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("91ef4ee2-458a-4de1-a6c7-541651793ea5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("926f01ca-53c5-4041-ba9e-d22d331f18c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9505320b-be30-4498-abc3-abbbe54fbee3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("955e772e-a418-479b-867c-f75d14d41622"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("968a0669-e32e-4f2f-9876-6123519587c9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("975fbb15-c5ab-4937-9591-86ab07a51b18"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("991888dc-6f05-49cf-814d-3ef6619e99dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9bc1af6e-51da-45c1-91f6-1e341385809a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c034120-c70e-4aa5-b235-68c30081a4dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d7eedc1-6dad-4a69-8bb2-01f8f4ccda23"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ebb29a4-140f-4e3a-bc1e-bf5f721c2718"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9fd0629a-0f25-4cde-b4ad-300c72cb2120"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a01e8a5b-7acc-42ed-8580-ba22e788a896"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a04b8aa3-e32b-4364-a18b-18473bf521cb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3ed765a-a8d3-47f6-9316-ac53614697f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a4011f17-aa4f-45fa-8adc-afaf9428618c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a5714602-be6c-424b-b92c-bea54ed87bdf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a6b5a031-768b-4486-86a7-d0c1bcb00b06"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8f75d74-2145-41c0-adbc-4806214438f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9d03c32-ac4d-4a31-9887-542a48145f26"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab55640c-8f68-4f53-beb6-5955cd7540ef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac18f3bb-4b45-4814-adc0-5d503bc2024f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad97fd2c-59e1-476d-967a-68e7ca048edb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("af754faa-a532-4398-b20a-ef52d89d4102"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b086dcbf-8e70-4b15-8990-144b74ce113b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b13cfa90-81fb-46e6-9241-f7dbb8a2c5ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b4028241-10c6-49f8-9fa5-f3bb1f942d19"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b74a66d5-69e7-4d5f-8156-ee9127f45171"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b9a72ce3-07c1-40f8-abe1-feda9c627ba2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba7c5a14-6531-456c-b59b-35e24b33a3f1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba937fe8-8e23-416c-9b11-fbc4352a8297"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb53a044-eda0-4523-aa09-c1ff6dc4274b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bbd3954b-1746-49d8-95c2-3aee638b6c4e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bce9d937-8338-49ec-947e-2b78846edcc5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd33e96a-0cb4-46a6-9b25-f4e64b71e446"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bdd343f8-cbf3-4d26-a7f9-5a678156057b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be76ec05-da94-4d6f-adea-46e7a7336d08"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be7a2aa2-e3e6-48f6-adb0-ebf21769ad5e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c4f37729-41fc-461c-aca1-8473a2570804"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c548b7a8-6c78-47f8-915b-6ac2d729c7e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c54cb763-c4ab-4260-9355-7eaeecb1da72"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c78045d3-4fa3-427d-80b5-1f5bce2d4438"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c97f7937-b362-4e1b-b27c-8ab0d740d0db"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca84c07f-c83f-4018-9a06-edabd896f1bd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("caef0594-2337-4c23-95d8-fe1f0b2e2919"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cb271b7e-3519-468a-a2b4-f4324d444683"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cfa85278-4858-4800-8a78-4c15c6411445"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2285b70-809e-4ef1-ac58-0e8b3a458165"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2ef6eb6-940f-4459-a976-fc78c60217ec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d307b234-cf09-4e23-b740-ab8943e18490"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d472f1cf-7860-4b60-a9c0-9a031fdf805b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d50243f3-a98e-4588-b135-7bab8925f407"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8de6fd6-52dd-481f-a26b-b24694e2cec6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc54bd72-ebde-4b8b-a53c-cc475fc77e8c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dd3add1a-772c-4cac-a71b-68732d86c3ba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("de1a2f15-83d9-415a-a888-72b3b1f78a4b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e063c713-0c74-4a62-ba14-176777f2ba35"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e23b39cb-5e78-4ebc-88c0-f808d6cadb60"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e25df910-97d7-4b2b-a5c4-b4ce14dab0cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4871bb4-7963-4010-93d9-879861121af3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e69ae47e-24f5-424f-856b-d84cfd82ebe0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e72471ea-7b9f-49d4-80af-dbf3635d6f6d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e8808d91-a6c4-496c-9767-b90f089656d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e95ac08a-a532-4123-bf0b-815a7997fd93"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9deed57-f916-4294-9053-330efddbad7a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9f50e3a-3cea-4dcf-a986-da777dcff506"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9f8b7c3-1d04-416e-8185-2b4175e85ceb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea3ba415-6d57-4a94-b4d6-42efe77af0b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec1399fc-c188-4080-ad72-bc57b8f9b68e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee1a6ed3-849e-49c9-be8f-c9529225d3fe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1d291c4-5651-4941-85d3-a3748bcc6c48"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f27ab3f6-9fde-4f51-a38b-f4e45264457b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5339b88-822b-469b-b61d-8d1528a40a8b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5e6154a-1eda-4360-8076-b1c01c6c6cf2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6a271e0-bed3-4fac-b1a7-70298d2e86c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6b13072-e6e8-4155-8035-c70a7611ff2a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f833c7f5-25af-49bc-a5f6-bbb090722aaf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8b64bd2-b4a0-4557-82e5-0f8351976c84"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f958b20a-e2b6-43f9-9f45-14d5d4de1f06"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9c06365-4252-4f24-854b-3b1356deefb4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa267ec5-5adf-41b6-8ed5-daf8f47e0b25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fba83f70-9105-44ea-9d97-ee58c3d158aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fced948a-03df-4bec-83b7-ddba04974d3c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fdd47872-db4a-41e7-adb2-a39195081d4f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("0921909e-50fd-481b-86e5-43c9413903f7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("155392d0-a1e7-4cf4-aa19-849f6791e477"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2323ca23-e2ab-447a-9139-b7fbbd3e9c61"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2501d957-82b1-4eac-a6e1-530a1c88532b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("299074ac-f43e-4689-895e-fecf59c15020"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2db78452-9ce4-4cf8-ba95-7f6ec1c80ec1"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("39e31b42-4764-4059-9bb0-96a9cfdb8658"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4cb9a661-a596-4409-99b8-aa549f15e20a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("622ed97a-e5de-4493-b8d2-eebd423f5e11"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("64087e58-6828-4a01-8724-a64b432714c4"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("649efd4d-d6c6-4373-b431-7d523fc41cbe"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("761eaf28-cf40-4e4d-bf6b-f005e5482bff"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("82e4baf4-766e-4e0b-bbbe-526c5638011c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8a21656c-dec3-4070-9526-5b2c7cd27fb5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9854a677-6bce-43bf-9f4e-dea84f85be8a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9bacbdfd-4c87-4581-99c6-679c4c761021"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a2b7089f-6912-4b76-bfdf-1d4ec95c1ab9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b134c2a9-c14e-4ee4-973e-6f50f33a418b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b244fe53-59b9-4d4f-8fa6-f6e5e214223e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c14971ed-cb32-43a8-b774-aa7416e115e0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dbe64c17-fe2f-4d2c-a2d5-9bd84dd0630a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fcfdba2a-6bb1-4f0f-aa23-ef2a92f277a0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("feb561fa-7a9e-45fe-a977-8d6924d64a0a"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1794fa91-0f91-4798-b668-1f86eea20a42"), new Guid("f11cb634-0ec2-4093-8b89-db9a02946774") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), new Guid("07329306-ee33-4503-ad60-631641248da4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("07329306-ee33-4503-ad60-631641248da4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("f11cb634-0ec2-4093-8b89-db9a02946774") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("07329306-ee33-4503-ad60-631641248da4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("f11cb634-0ec2-4093-8b89-db9a02946774") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("d9ac2d7d-ee8e-4ca0-997f-a73c62d3fea8"), new Guid("f11cb634-0ec2-4093-8b89-db9a02946774") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7"), new Guid("151ac055-1d1e-4076-b232-bdce26a05230") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6"), new Guid("151ac055-1d1e-4076-b232-bdce26a05230") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("1cccd723-e77f-4e56-8842-abd6fe0c852a"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("a914becc-6d71-42ab-b168-66ec85e1b186"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("a9cf702a-424f-4a2d-87c1-2aaec5ba3a81"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("c518bd7d-da5b-430a-b183-a170799baff2"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("ccd15f3d-b8fb-4e2f-a2cf-d7ccda672e84"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("ec6d5cea-b254-420b-846e-2e6e71a30777"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0be79d01-986e-409a-9cf8-5aff7d9d3f35"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1794fa91-0f91-4798-b668-1f86eea20a42"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("32f817f2-7272-49cc-9f93-8fe3d9fad1ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37a6dc87-a783-45db-b144-d1759b465ef3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("684c4d39-1729-4cb6-b4bb-3752815ba886"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("80e85eb2-daea-4f00-b0dd-c717b385e4cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c153ecf8-c901-4946-8239-b4c9997df8c4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d4e22aa8-4984-49a9-a5fc-e33f052745a4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9ac2d7d-ee8e-4ca0-997f-a73c62d3fea8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("edc7849b-3a1e-4c80-8eb7-8051a5c74f17"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("01663309-885a-481d-ac4f-88bcab0e95c9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("0bfade11-a9a6-4c14-92e4-a1b4160eaa83"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("13c4fbc9-3a9d-43ea-9573-34e97ce73b7e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("72ce4718-331c-4f5c-9088-6bf7938e8865"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("78c2e086-a11e-4b0a-9740-f4a9fc85d3f1"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("84839285-b012-42a9-8ea3-94e166409823"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("930bf3d6-25a7-4f13-a733-9470802569a5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9dfaf84e-0c65-4642-a449-524545520031"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("cea86681-7ad8-47b9-9f24-c0c0a0aed640"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dbe5a9d6-144a-430a-a5f4-069010a83ccb"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e9eda27a-d158-4b3f-872f-26c8db1f2485"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("176cc878-a8de-4f73-be44-7bddfceae62c"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("62e1b231-2174-4fea-994c-dea5132880d3"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("6597f931-3195-44e4-82b8-66fe73e957d9"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("6c07d4b5-030b-47bd-9359-dfed8e55ad58"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("7d1ffbc4-e64f-4f46-a66b-519d7042c656"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("9c650e18-76db-495c-a9bf-07b622a850c0"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("9fbb0c66-be16-404e-86aa-3ce654e373b2"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("f812e00d-e1f5-472a-9fe6-2303f1cced56"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("fcbba43f-b000-4a56-bfab-2a90cece5ffc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08f56c25-e139-4872-a00a-3c5160f849ac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5f4a7bb9-aefa-44c5-8d6d-f67b530bd397"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8113f978-06dc-4ed8-87b8-dc4ef82d3445"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a76c0ea8-6b08-4ebd-8cd6-e9a668985737"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("07329306-ee33-4503-ad60-631641248da4"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("151ac055-1d1e-4076-b232-bdce26a05230"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("324904e3-2401-4ca1-acc5-34686182f20a"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("37a596d9-e1dd-402e-884b-d14ce6971802"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("642d88a2-8c74-4fe3-a74d-7005f9f8fbcd"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("f11cb634-0ec2-4093-8b89-db9a02946774"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("2ee65b73-51e7-442c-b364-a6160643be8a"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("d2f1570b-fca7-4c57-a337-5de6742de5f8"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("68b8ee11-353b-47a7-942a-6d2e7914b81a"));

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "TransferPoints");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "TransferPoints");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Places",
                type: "decimal(18,8)",
                precision: 18,
                scale: 8,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,8)",
                oldPrecision: 18,
                oldScale: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Places",
                type: "decimal(18,8)",
                precision: 18,
                scale: 8,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,8)",
                oldPrecision: 18,
                oldScale: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8"), null, "catering", null },
                    { new Guid("054e025f-b7ca-4ba4-be5a-6df9a6a2a4f8"), null, "activity", null },
                    { new Guid("168c1ce5-f7b7-4089-a5c7-04ccc06e476b"), null, "sport", null },
                    { new Guid("20613332-2223-41d8-be43-0051f8e80a8a"), null, "national park", null },
                    { new Guid("8340dfb1-b14f-45a2-9137-2e61e7e26871"), null, "heritage", null },
                    { new Guid("b680b490-657e-45c2-b2bc-d43aa768de29"), null, "leisure", null },
                    { new Guid("b7f1731c-f91f-46fb-ba88-60ee01381f77"), null, "entertainment", null },
                    { new Guid("b82b1f67-a4c6-404e-90d3-a2567930b1b9"), null, "commercial", null },
                    { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), null, "tourism", null },
                    { new Guid("bc897e3e-fe79-4730-b261-228473ea66a5"), null, "religion", null },
                    { new Guid("c9e65a8c-8852-4697-ba91-84ac4c4cf4a2"), null, "natural", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("1bb99664-d50a-4b39-a0fb-69a979ac48d2"), null, "no-dogs", null },
                    { new Guid("2d59d33d-d3d9-48dd-bc68-8ede4a1126f7"), null, "internet_access", null },
                    { new Guid("3a97f26a-850e-4701-90c8-6c83c7f0bef3"), null, "access_limited", null },
                    { new Guid("4e44882d-e478-4ffa-baa7-dd22ff84ee24"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("7045ea38-5399-458d-b595-00484351df60"), null, "fee", null },
                    { new Guid("74bd5a25-0655-400e-b7ec-ec7cf55e64ac"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("76e2ccc1-034a-422c-9f8b-b12d4e506118"), null, "wheelchair", null },
                    { new Guid("9f03dfdc-7353-4eaf-b3a3-4d49695f882e"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("a450a032-d14f-4f50-9582-689516559d97"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("a4c5650d-b9e0-4dea-9423-d1af3b8edbbf"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("a647202e-80e0-45ef-b265-f27e8c4e0e3e"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("b2126673-e2da-4627-ac18-4bd7a075c48e"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("b78fc36c-8a13-407a-a3cc-c417cfb7291d"), null, "dogs", null },
                    { new Guid("bef9070a-83ac-4542-b324-2394840c9d72"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("c148165d-9263-4566-9b5a-29f7121eb393"), null, "access", null },
                    { new Guid("d2540b76-89c4-43a6-8dd3-cc537e89243b"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("dbaac515-209d-462d-bca7-c5f8e4d30e67"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("f6ac3cd7-b80d-4828-beaa-0f83fdbbca0f"), "Name property defined for the place", "named", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceCategoryId", "PlaceType", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("05213ff1-1e1a-40ed-9725-daefa6ed076e"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", null, "CustomPlace", null, null },
                    { new Guid("1c9bee55-62e0-405c-9f5a-80746f579f59"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", null, "CustomPlace", null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("33f84785-cdac-4720-b0ee-0add62802d90"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" },
                    { new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" },
                    { new Guid("5346236b-eeb9-44d8-95b0-c67d139804ac"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null },
                    { new Guid("71c4487f-be90-4834-8484-f0d51bc937a5"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceCategoryId", "PlaceType", "State", "Street" },
                values: new object[] { new Guid("90cac2de-de21-4ee9-90dd-b7cf0896ae92"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", null, "CustomPlace", null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("a0459324-4c75-498f-9557-a8bdd7e81419"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null },
                    { new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d"), null, null, null, null, null, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", null, null }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("17ca2bcc-6695-4a02-bda2-a25efd5e2d04"), null, "biergarten", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("26b18ac6-bc03-478a-834d-1443a5079986"), null, "pub", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("3b64cd9f-b6c9-472c-966e-c48559cd486b"), null, "museum", new Guid("b7f1731c-f91f-46fb-ba88-60ee01381f77") },
                    { new Guid("3d92af8f-9f11-4968-86a8-2bbdf73ff2e5"), null, "art", new Guid("b82b1f67-a4c6-404e-90d3-a2567930b1b9") },
                    { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), null, "sights", new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de") },
                    { new Guid("42c80c5e-c427-4c19-b9c2-f5e897eaa737"), null, "ice_cream", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("5201b2a8-dcd2-4f19-a888-a44208d49c00"), null, "park", new Guid("b680b490-657e-45c2-b2bc-d43aa768de29") },
                    { new Guid("5cbd612d-60ad-4846-92b8-35a7482c7c2e"), null, "water", new Guid("c9e65a8c-8852-4697-ba91-84ac4c4cf4a2") },
                    { new Guid("62e44ffe-c56a-4eb8-8198-d5690daa37fe"), null, "sand", new Guid("c9e65a8c-8852-4697-ba91-84ac4c4cf4a2") },
                    { new Guid("63fb3665-40c3-4527-99a6-3dce1ec61f1a"), null, "food_court", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("739926dc-9daf-4257-a0ca-bf2dcf3e7103"), null, "planetarium", new Guid("b7f1731c-f91f-46fb-ba88-60ee01381f77") },
                    { new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d"), null, "restaurant", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("76d25ce9-6a92-4ec6-a295-a78164e20748"), null, "aquarium", new Guid("b7f1731c-f91f-46fb-ba88-60ee01381f77") },
                    { new Guid("82c47188-7c08-4faa-84af-15bacef9d606"), null, "gift_and_souvenir", new Guid("b82b1f67-a4c6-404e-90d3-a2567930b1b9") },
                    { new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f"), null, "fast_food", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("984c0140-80ce-4b4e-905d-8aa1307bf126"), null, "mountain", new Guid("c9e65a8c-8852-4697-ba91-84ac4c4cf4a2") },
                    { new Guid("b257bf85-8fec-4ad5-b9f1-5884ca832e57"), null, "unesco", new Guid("8340dfb1-b14f-45a2-9137-2e61e7e26871") },
                    { new Guid("b33b040f-90f9-4397-9de4-b8cb48b2201e"), null, "stadium", new Guid("168c1ce5-f7b7-4089-a5c7-04ccc06e476b") },
                    { new Guid("bf76dace-5b7f-4d99-bb1d-7153722912d5"), null, "culture", new Guid("b7f1731c-f91f-46fb-ba88-60ee01381f77") },
                    { new Guid("d54ac254-adab-4492-8154-c08eee817d2f"), null, "cafe", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b"), null, "place_of_worship", new Guid("bc897e3e-fe79-4730-b261-228473ea66a5") },
                    { new Guid("e97cdbeb-6077-4bc1-acc8-44363afb446a"), null, "attraction", new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de") },
                    { new Guid("ebf515e9-c111-423e-a6c0-2a6ce5eb2c90"), null, "bar", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("f5d1c2e3-d017-4dc8-b547-9ad5a797f0a3"), null, "zoo", new Guid("b7f1731c-f91f-46fb-ba88-60ee01381f77") },
                    { new Guid("f8adf366-d896-4f99-8b59-15ab66464f90"), null, "taproom", new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8") },
                    { new Guid("ff4018d5-1b84-42c1-ac20-eeb5201789ee"), null, "forest", new Guid("c9e65a8c-8852-4697-ba91-84ac4c4cf4a2") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("002c7607-bdd2-454a-a16d-a55f87ecb4b7"), null, "yes", new Guid("76e2ccc1-034a-422c-9f8b-b12d4e506118") },
                    { new Guid("07a5da13-30ab-4198-b9e4-90859258354c"), null, "free", new Guid("2d59d33d-d3d9-48dd-bc68-8ede4a1126f7") },
                    { new Guid("15f96d22-a2eb-499c-a847-472308ab44d0"), null, "yes", new Guid("b78fc36c-8a13-407a-a3cc-c417cfb7291d") },
                    { new Guid("35d2225b-377a-4b3d-aaa8-52ec5f879257"), null, "leashed", new Guid("b78fc36c-8a13-407a-a3cc-c417cfb7291d") },
                    { new Guid("47352c45-51a6-4d82-a2bc-6ce660406ba5"), null, "limited", new Guid("76e2ccc1-034a-422c-9f8b-b12d4e506118") },
                    { new Guid("4c8e00f2-7ffa-4f56-a197-07b36c0bb2ca"), null, "not_specified", new Guid("c148165d-9263-4566-9b5a-29f7121eb393") },
                    { new Guid("7371f042-f567-4caa-8f2d-d044fed09f11"), null, "only", new Guid("d2540b76-89c4-43a6-8dd3-cc537e89243b") },
                    { new Guid("741e339c-30ff-45df-92c9-173b4738d7eb"), null, "only", new Guid("b2126673-e2da-4627-ac18-4bd7a075c48e") },
                    { new Guid("95124566-e43c-4404-b278-c9efeed8e32b"), null, "no", new Guid("a647202e-80e0-45ef-b265-f27e8c4e0e3e") },
                    { new Guid("a3563a3c-ab98-4cc5-a084-dd36bfe6e393"), null, "not_specified", new Guid("a647202e-80e0-45ef-b265-f27e8c4e0e3e") },
                    { new Guid("b54397ec-c1c4-4e72-aba7-eccba7be9882"), null, "only", new Guid("a450a032-d14f-4f50-9582-689516559d97") },
                    { new Guid("b64399e2-9719-4691-bdb9-773284b7e1eb"), "Places that are available for public", "yes", new Guid("c148165d-9263-4566-9b5a-29f7121eb393") },
                    { new Guid("c08babe5-7c6c-4cfa-a2ef-eec89e6818ec"), null, "customers", new Guid("3a97f26a-850e-4701-90c8-6c83c7f0bef3") },
                    { new Guid("d3a20d85-7a32-476e-babe-6c6881693cdf"), null, "only", new Guid("4e44882d-e478-4ffa-baa7-dd22ff84ee24") },
                    { new Guid("d3e23f5c-544b-43ff-a4d6-910a5e71b6b8"), null, "only", new Guid("bef9070a-83ac-4542-b324-2394840c9d72") },
                    { new Guid("ffd2c436-ce6c-4964-b18a-5f5104f8df46"), null, "for_customers", new Guid("2d59d33d-d3d9-48dd-bc68-8ede4a1126f7") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8"), new Guid("71c4487f-be90-4834-8484-f0d51bc937a5") },
                    { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("33f84785-cdac-4720-b0ee-0add62802d90") },
                    { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f") },
                    { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("a0459324-4c75-498f-9557-a8bdd7e81419") },
                    { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493") },
                    { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d") }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[] { new Guid("18504468-dea4-45f1-87cb-46045bb91357"), 100m, null, null, "PLN", new Guid("5346236b-eeb9-44d8-95b0-c67d139804ac"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0471772e-e159-40db-9b42-721221464219"), null, "regional", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("076b9ecc-0cd7-4b3b-afce-90a641a8c4aa"), null, "city_gate", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("09b3eec9-0033-4480-8b04-15de0567cdd8"), null, "hot_spring", new Guid("5cbd612d-60ad-4846-92b8-35a7482c7c2e") },
                    { new Guid("0a674296-e3cb-4e91-a2c0-2c41fcba0430"), null, "caribbean", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("0a980402-cbcd-42c8-9cd2-54d3b6d08ecc"), null, "noodle", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("137767a8-ad71-4604-98d7-22465cce3cab"), null, "dessert", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("14777fcc-cc88-4b04-93eb-45bbb1865482"), null, "sandwich", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("16e5fd80-0d05-4369-a77f-e7b143f1b365"), null, "pita", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("171f61e8-6976-4bb7-ae64-fd00d3b02ffd"), null, "castle", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("17d8ee58-34a7-43dd-8451-122014aeb1bf"), null, "gallery", new Guid("bf76dace-5b7f-4d99-bb1d-7153722912d5") },
                    { new Guid("18235900-440e-42e1-9405-1214e5a38410"), null, "french", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("18e8e9d2-ec1a-4f43-aa76-6fbea28f9608"), null, "sea", new Guid("5cbd612d-60ad-4846-92b8-35a7482c7c2e") },
                    { new Guid("1a335b97-7d91-4b7e-8c47-2238ac489457"), null, "islam", new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b") },
                    { new Guid("1c2c6432-5c15-427c-bfe0-be1635ec311d"), null, "bridge", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("1dbeb36a-3e98-4174-8cca-e602a687afc4"), null, "european", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("1dc5345d-f9da-4ed4-b46e-85784a85d11e"), null, "malaysian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("20270c4d-dd8b-4a5d-8380-3adfa02fea07"), null, "pizza", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("23c376e6-1c08-404e-874f-be8d6ea3e5a9"), null, "indonesian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("2402d8be-78a2-4dd9-986f-e4133dd5cc41"), null, "jamaican", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("243da07f-d33d-4212-8638-efd9becf2f25"), null, "sandwich", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("252955be-1dca-4d2c-9e62-350b764ed409"), null, "city_hall", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("2629898f-bab9-4f72-87ed-49552db04f61"), null, "hungarian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("27b761df-e322-4ac3-9626-fa38f8f9afa4"), null, "seafood", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("29285f6f-d917-4ca4-bebd-cc00d25d4c58"), null, "ethiopian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("29d0f9ba-9d09-4d4b-854d-e7daf45be1d9"), null, "windmill", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("2ac7205c-2207-4ae2-8367-ffb757ef792f"), null, "curry", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("2acea7a0-d716-4996-bf52-349ec856edd2"), null, "spanish", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("2afd74b8-bec6-42bc-8720-2ca9d97963ba"), null, "christianity", new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b") },
                    { new Guid("2d2386da-2cbb-4f08-8c58-0725872d3f57"), null, "noodle", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), null, "memorial", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("2f48744d-6893-4830-9457-98bb904a95bb"), null, "bavarian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("31ada4b0-b1b9-4d7b-a4b4-dbf9bf4216c9"), null, "friture", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("3490453f-800b-4a42-881b-3afcbf41665c"), null, "kebab", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("358693b8-87db-4782-bb01-e8c8bfeed913"), null, "austrian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("359497e1-2be8-4fec-a56b-3fdb94558c38"), null, "malay", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("36b90439-b211-43a8-88d8-2a320704be72"), null, "cuban", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("37f30af6-d450-4b83-8c94-068768519cb4"), null, "japanese", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("3857b056-bce6-4b00-a61d-9ee69cbeb955"), null, "rock", new Guid("984c0140-80ce-4b4e-905d-8aa1307bf126") },
                    { new Guid("3a48c2a9-82de-4abf-a7f6-7b933fad1d5c"), null, "donut", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("3d4274b7-8441-4a85-ae3d-d9a65781ad42"), null, "wings", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("3f093499-4331-4ae3-ba69-97634ab41c54"), null, "swedish", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("3ff05229-e2e7-414d-8145-29998a3da74f"), null, "georgian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("4060baa8-bd4f-460d-a506-fdea05c0ed33"), null, "frozen_yogurt", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("4212614c-5b9a-4844-b214-0a66a2e43ffc"), null, "battlefield", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("42abbc5a-dd22-48a5-82dc-d8b49aec3a6a"), null, "nature_reserve", new Guid("5201b2a8-dcd2-4f19-a888-a44208d49c00") },
                    { new Guid("45802a88-0330-45f2-8713-f7c434faa7f8"), null, "spring", new Guid("5cbd612d-60ad-4846-92b8-35a7482c7c2e") },
                    { new Guid("45973364-dda2-4325-8224-9aebdde633a1"), null, "salad", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("4722f209-b63a-4314-8277-0059f7d9d88a"), null, "ramen", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("484686cc-9384-434f-b2a5-f0e69a05591f"), null, "tacos", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("4869ab10-4d9f-4f64-821d-b427e9f4ef7f"), null, "thai", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("4bcdc541-90b2-4703-b045-6dc0d76b96f0"), null, "international", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("5005b1bb-7aad-42b5-b6e1-59cc3dcfe2b5"), null, "burger", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("519a19ac-c749-4d4e-8320-c7596e52696f"), null, "arts_centre", new Guid("bf76dace-5b7f-4d99-bb1d-7153722912d5") },
                    { new Guid("51a682e2-e415-4f4e-82f7-eef6bc2167a3"), null, "tower", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("51e88dbf-720e-47fc-b06a-0dfb13a80562"), null, "tex-mex", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("55797337-80d0-4ceb-a540-b33578df7437"), null, "sushi", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("558d5b90-0036-44dc-a31f-8c921e38f1b5"), null, "persian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("5868e1c2-65a6-453f-bcb1-43b9e739095f"), null, "crepe", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("59166b55-b7d7-4ca9-8809-35ab657b1e70"), null, "kebab", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("598c58b7-b4fb-4813-a872-99d8c2bfc3b9"), null, "argentinian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("5b587f0f-83d3-48fa-8059-fa35c73eef7e"), null, "nepalese", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("5d30a10a-fe1e-49eb-a300-56a4a1fc77bb"), null, "ice_cream", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("5dba8cde-c33e-4037-9bed-da5a49a891fb"), null, "fish", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("6078d6bc-bcbb-48b2-bdc6-404f79a1a2f6"), null, "american", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("60c1f3fb-2b8a-404a-8b6c-eaf0848d492e"), null, "fountain", new Guid("e97cdbeb-6077-4bc1-acc8-44363afb446a") },
                    { new Guid("64b464ee-424a-4f4d-ad59-385bb939d811"), null, "uzbek", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("64cb186d-77bc-44d5-9ce0-831bde161264"), null, "syrian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("677b6a74-0f39-4521-8ed2-10d562c7ea88"), null, "clock", new Guid("e97cdbeb-6077-4bc1-acc8-44363afb446a") },
                    { new Guid("677daed2-e06e-4197-a49d-e7cf15bd56a8"), null, "tapas", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("68d6c929-c953-4f6d-ab45-946db079c319"), null, "theatre", new Guid("bf76dace-5b7f-4d99-bb1d-7153722912d5") },
                    { new Guid("6a61c4a3-b8a5-4a5d-b2e6-b4d0861d2146"), null, "croatian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("6aac5187-b1f4-4be2-b754-86987051812b"), null, "artwork", new Guid("e97cdbeb-6077-4bc1-acc8-44363afb446a") },
                    { new Guid("6bfe648c-a660-4ad4-80c1-ca51cb99a4c9"), null, "glacier", new Guid("984c0140-80ce-4b4e-905d-8aa1307bf126") },
                    { new Guid("6f03b74d-66e6-4a30-8474-6b0f201d322d"), null, "garden", new Guid("5201b2a8-dcd2-4f19-a888-a44208d49c00") },
                    { new Guid("70cb5f2c-6f33-41cd-961e-f30c44b2b269"), null, "fort", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("71a82d89-163b-4a04-826b-5fd09cbf3bb6"), null, "german", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("73e849b6-314c-4b2a-bba0-fb9d41f7c513"), null, "sikhism", new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b") },
                    { new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe"), null, "place_of_worship", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("7a336e2d-6a01-4f6d-83f1-5a2eb5689191"), null, "indian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("7ab2818b-96a2-45ac-b33b-8ebdd02dc106"), null, "pizza", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("7ab5c8db-f98a-4dd9-a504-245cf9c796c5"), null, "mediterranean", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("7cf686d7-cf9c-40ad-b013-afdc176e65b4"), null, "ramen", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("7cfda43b-1b67-4803-8ff4-7d3e926f2855"), null, "coffee_shop", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("7de5fb5c-af65-4a55-9cfe-9948dae4993f"), null, "beef_bowl", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("7e10fb92-96c0-45e3-a9f1-a6d2b4fc7b2d"), null, "balkan", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("80966716-8b57-40ac-a850-3454876f8ab8"), null, "waffle", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("844a256b-d8c3-4ca1-8fd5-ac8ea77d4b14"), null, "czech", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("850a635d-5b15-4096-8aa0-506fa84c8884"), null, "pakistani", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("863d69da-aa6e-4aad-8128-440c9dac25fe"), null, "shinto", new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b") },
                    { new Guid("874726ab-7b42-43bb-9a38-3e5100e1a83f"), null, "oriental", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("881bd70a-196e-4abc-bef1-1aae604f50f2"), null, "filipino", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("8ce046ce-5675-47da-b381-a217b37feeab"), null, "bubble_tea", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("8e08e52d-49d0-47cd-9acd-63e9dab2c845"), null, "tapas", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("8ef684da-629a-484b-8851-fe605d430f57"), null, "monastery", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("92b742fe-16b6-47fa-bfbe-eea6b9916fd5"), null, "fish_and_chips", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("967e7270-f51f-4fea-bc54-2fdfddd6d448"), null, "reef", new Guid("5cbd612d-60ad-4846-92b8-35a7482c7c2e") },
                    { new Guid("9683678f-6f9c-471f-8084-0332d47eb2a1"), null, "italian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("96d34649-bcdd-43a0-bfa8-6b8e7ea46b8e"), null, "viewpoint", new Guid("e97cdbeb-6077-4bc1-acc8-44363afb446a") },
                    { new Guid("97553338-6fcd-49f2-b5cb-05f3876c3c87"), null, "ukrainian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("9784b08b-6293-4614-9eb4-c798685ec89a"), null, "peak", new Guid("984c0140-80ce-4b4e-905d-8aa1307bf126") },
                    { new Guid("99b305f0-2e3c-4e71-826b-35751f7ef8cb"), null, "afghan", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("9f1d28be-d028-4d0e-bd84-e7629d693639"), null, "latin_american", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("a0056391-fd99-4811-9222-833e70f7362a"), null, "buddhism", new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b") },
                    { new Guid("a52d3f93-dd9c-4ee9-a8e9-a69d71d7dc4b"), null, "greek", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("a6e1deae-99b7-4143-b646-54c66b3eaa7e"), null, "peruvian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("adeeff96-3a6e-4faf-a3a5-03710549421f"), null, "portuguese", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("ae50fdba-9471-4b3c-8052-ebfe7d4901d6"), null, "chinese", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("ae56392e-0cc9-48cf-89b3-4cb4d36c5c12"), null, "irish", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("b2c9f5af-7816-4703-80f8-e20e6f389d6b"), null, "chicken", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("b30f0518-a154-44c4-ae0b-7e623fea6010"), null, "mexican", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("b3c568d0-e2a9-425d-84dc-f8cee8a554d7"), null, "dune", new Guid("62e44ffe-c56a-4eb8-8198-d5690daa37fe") },
                    { new Guid("b8df470e-c036-44fe-b576-640b2ccad24a"), null, "multifaith", new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b") },
                    { new Guid("b8e15d10-1cf8-4e38-a5b8-4f88babbb370"), null, "coffee", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("ba73732d-9431-4837-bb64-08b747c7810c"), null, "dumpling", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("bbb135d3-7d8d-4ec9-9d4b-b783335e0df7"), null, "brazilian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("bd3de7da-332b-4706-844c-f3156e3e1274"), null, "judaism", new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b") },
                    { new Guid("c0b42b00-4bf2-436d-addd-e454eb148a80"), null, "korean", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("c150a718-e901-485d-a054-5e2fa40f395d"), null, "lebanese", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("c2480bd9-68e2-49cf-96f0-6831ae73a0f2"), null, "bolivian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("c39f784f-2851-4686-8264-7ef28c5f41b0"), null, "fish_and_chips", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("c3ab9117-8a32-4e6a-b445-c47b8d50de65"), null, "steak_house", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("c3ee8773-2c4f-4832-8189-02414dc70649"), null, "lighthouse", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("c437d4cd-f8ea-4c2f-b4f3-45cb7f93a9a3"), null, "tacos", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("c4586b09-5a35-42fa-b32a-bcd084a8215d"), null, "arab", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("c9e64800-106f-4a6f-9c47-e00f4031833c"), null, "moroccan", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("ce7875e7-8661-48b9-ac49-7a19ec8f0b1a"), null, "vietnamese", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("ceab5e81-ecc1-41aa-a7aa-5b9af56fa765"), null, "danish", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("d1162d68-be6d-4110-96a2-670331f4c691"), null, "hot_dog", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("d20f41bc-e68a-454e-b2c6-b806652f93d6"), null, "turkish", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("d713b802-6295-4bea-ab92-07857633e3dc"), null, "soup", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("d75bfe2f-57c2-42cf-9d7c-c89802bb3f22"), null, "burger", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("d76637fe-ec3c-4e3c-a58b-df1e6f220abe"), null, "chili", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("d8615b80-525a-4d06-a972-b01c2f39c14a"), null, "belgian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("d9d82d05-a64f-46ee-9ea7-da4d3e7a272b"), null, "barbecue", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("dd57afad-06f2-43fc-a5cb-3f5d5862be0c"), null, "archaeological_site", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("e0014a38-ddc4-45ef-91c3-043b4d5de535"), null, "hawaiian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("e0cc825d-b803-4aca-8820-114615c3273e"), null, "taiwanese", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("e29a6441-6565-400b-8869-122d68b2b354"), null, "cave_entrance", new Guid("984c0140-80ce-4b4e-905d-8aa1307bf126") },
                    { new Guid("e3024e21-a785-4bab-87d2-62c1a1b1d975"), null, "hinduism", new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b") },
                    { new Guid("e83c50e7-281b-4603-94f5-76871958ef11"), null, "ruines", new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb") },
                    { new Guid("e9fe7c7d-65f9-40c9-b440-705c076f0875"), null, "cake", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("ec0e12bb-a032-4627-a5ed-e7fc3c558e84"), null, "wings", new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f") },
                    { new Guid("ec923b79-28ec-4694-9778-a16389a2c310"), null, "cliff", new Guid("984c0140-80ce-4b4e-905d-8aa1307bf126") },
                    { new Guid("ed70efc5-617c-475c-909c-287e2c976d86"), null, "russian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("ee5260f0-864d-4e0f-b206-df46e22097b8"), null, "tea", new Guid("d54ac254-adab-4492-8154-c08eee817d2f") },
                    { new Guid("ee6b669f-9094-400b-a467-ffe8a269815b"), null, "asian", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("f99b218b-1042-4c48-b86b-fed7b1d8114a"), null, "pita", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("fa28f204-abcd-4cbf-9fe0-5b7e1176c4df"), null, "western", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("fa72155c-c69a-4837-b65d-4cc29168af51"), null, "african", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") },
                    { new Guid("fb1fef27-00a2-4d11-adb9-6cadce6fb57f"), null, "geyser", new Guid("5cbd612d-60ad-4846-92b8-35a7482c7c2e") },
                    { new Guid("fe4b1f15-a0f6-4421-ab72-7e52c12e995d"), null, "soup", new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("33f84785-cdac-4720-b0ee-0add62802d90") },
                    { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f") },
                    { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("a0459324-4c75-498f-9557-a8bdd7e81419") },
                    { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493") },
                    { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d") },
                    { new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d"), new Guid("71c4487f-be90-4834-8484-f0d51bc937a5") },
                    { new Guid("e97cdbeb-6077-4bc1-acc8-44363afb446a"), new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783"), new DateOnly(2024, 12, 21), new Guid("18504468-dea4-45f1-87cb-46045bb91357") },
                    { new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd"), new DateOnly(2024, 12, 20), new Guid("18504468-dea4-45f1-87cb-46045bb91357") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("142e45e3-2eea-494c-adcc-9ee4be92000a"), null, "shrine", new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe") },
                    { new Guid("1b38f3c4-781d-4b56-ae49-ca53178a04a6"), null, "temple", new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe") },
                    { new Guid("256f3637-742e-4c4f-82d9-912e713d3243"), null, "mosque", new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe") },
                    { new Guid("26de39f5-e86f-4acc-9b7d-7674fe61ca5a"), null, "locomotive", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("654da7a0-4b05-405c-85cc-84c150702bb0"), null, "church", new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe") },
                    { new Guid("6bddebb1-229c-421f-a460-bc82fca6dee2"), null, "tomb", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("70db89b1-c7ad-4b75-acb5-ff42892fd733"), null, "aircraft", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("785b441c-bfd0-452b-9e68-ecfd6c492cef"), null, "railway_car", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("8c7b674b-b1b8-4046-aa50-14b46c71b4ca"), null, "monument", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("99859785-308c-4586-abe5-ae3f820da595"), null, "chapel", new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe") },
                    { new Guid("bf9f338b-e5a3-4eb9-974a-5fc28ae9c5d5"), null, "pillory", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("ce9f5843-e64c-4c9c-9dd5-d20a782c85e9"), null, "cathedral", new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe") },
                    { new Guid("d60f5206-0601-4332-87b4-61167d62d25b"), null, "wayside_cross", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("d9babff3-1e6a-4e3e-ac1a-33b86770ae73"), null, "ship", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("dcc0201f-375f-4950-9738-13b1f6e116cc"), null, "tank", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("e625321d-70ad-422f-93b0-27668a332d25"), null, "milestone", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("f4494ee7-55db-421b-b76d-2379aa6c8f2b"), null, "boundary_stone", new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879") },
                    { new Guid("fb923bf0-3772-4278-aefa-6fb99d75b7d4"), null, "synagogue", new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), new Guid("33f84785-cdac-4720-b0ee-0add62802d90") },
                    { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f") },
                    { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), new Guid("a0459324-4c75-498f-9557-a8bdd7e81419") },
                    { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493") },
                    { new Guid("e83c50e7-281b-4603-94f5-76871958ef11"), new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("0e7eb636-5f16-41be-a6d9-22ce45e2c299"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("71c4487f-be90-4834-8484-f0d51bc937a5"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783") },
                    { new Guid("0eaa760d-4e22-4e04-b904-e78c87245c0b"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd") },
                    { new Guid("137bac8d-ba4e-4d59-884a-6d4696fb0ed0"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("1c9bee55-62e0-405c-9f5a-80746f579f59"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783") },
                    { new Guid("8a7a0deb-9a6e-4e5e-a538-181e770ee457"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("05213ff1-1e1a-40ed-9725-daefa6ed076e"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd") },
                    { new Guid("8df5f83c-5c9c-44ff-900c-c08e5e4b49e8"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("a0459324-4c75-498f-9557-a8bdd7e81419"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd") },
                    { new Guid("a73a7f44-e440-47b6-bd2a-b99a3b151a53"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783") },
                    { new Guid("f2cf56dc-99c4-491e-aecb-e01397041d62"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783") },
                    { new Guid("f9446a3f-bc19-44a1-8181-1a7df076e009"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("33f84785-cdac-4720-b0ee-0add62802d90"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd") },
                    { new Guid("fe53aaa6-0c9e-4a72-9a3d-36aec9a5c4d4"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("90cac2de-de21-4ee9-90dd-b7cf0896ae92"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd") }
                });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "ToTripPointId", "TransferTime", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("12a76ba3-e649-47b4-b1ea-8f7261497b02"), new Guid("fe53aaa6-0c9e-4a72-9a3d-36aec9a5c4d4"), null, new Guid("8a7a0deb-9a6e-4e5e-a538-181e770ee457"), new TimeSpan(0, 0, 20, 0, 0), new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd") },
                    { new Guid("359cf857-095a-4ad0-b08d-4f5be5532055"), new Guid("8df5f83c-5c9c-44ff-900c-c08e5e4b49e8"), 0, new Guid("f9446a3f-bc19-44a1-8181-1a7df076e009"), new TimeSpan(0, 0, 4, 21, 0), new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd") },
                    { new Guid("396ce916-e5bd-407d-b7ac-09f759a881d1"), new Guid("a73a7f44-e440-47b6-bd2a-b99a3b151a53"), 3, new Guid("0e7eb636-5f16-41be-a6d9-22ce45e2c299"), new TimeSpan(0, 0, 8, 18, 0), new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783") },
                    { new Guid("970175a9-f949-41ae-9652-dd54f101c52e"), new Guid("f2cf56dc-99c4-491e-aecb-e01397041d62"), 2, new Guid("a73a7f44-e440-47b6-bd2a-b99a3b151a53"), new TimeSpan(0, 0, 3, 13, 0), new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783") },
                    { new Guid("cada6d36-e7dc-4499-8883-68f9933094df"), new Guid("f9446a3f-bc19-44a1-8181-1a7df076e009"), 1, new Guid("fe53aaa6-0c9e-4a72-9a3d-36aec9a5c4d4"), new TimeSpan(0, 0, 0, 55, 0), new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd") },
                    { new Guid("f5b2c46e-379c-44a5-872d-46cf891ad3f2"), new Guid("0e7eb636-5f16-41be-a6d9-22ce45e2c299"), 4, new Guid("137bac8d-ba4e-4d59-884a-6d4696fb0ed0"), new TimeSpan(0, 0, 13, 30, 0), new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0471772e-e159-40db-9b42-721221464219"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("054e025f-b7ca-4ba4-be5a-6df9a6a2a4f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("076b9ecc-0cd7-4b3b-afce-90a641a8c4aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("09b3eec9-0033-4480-8b04-15de0567cdd8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a674296-e3cb-4e91-a2c0-2c41fcba0430"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a980402-cbcd-42c8-9cd2-54d3b6d08ecc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("137767a8-ad71-4604-98d7-22465cce3cab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("142e45e3-2eea-494c-adcc-9ee4be92000a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("14777fcc-cc88-4b04-93eb-45bbb1865482"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("16e5fd80-0d05-4369-a77f-e7b143f1b365"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("171f61e8-6976-4bb7-ae64-fd00d3b02ffd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17ca2bcc-6695-4a02-bda2-a25efd5e2d04"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17d8ee58-34a7-43dd-8451-122014aeb1bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18235900-440e-42e1-9405-1214e5a38410"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18e8e9d2-ec1a-4f43-aa76-6fbea28f9608"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a335b97-7d91-4b7e-8c47-2238ac489457"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b38f3c4-781d-4b56-ae49-ca53178a04a6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c2c6432-5c15-427c-bfe0-be1635ec311d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1dbeb36a-3e98-4174-8cca-e602a687afc4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1dc5345d-f9da-4ed4-b46e-85784a85d11e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20270c4d-dd8b-4a5d-8380-3adfa02fea07"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20613332-2223-41d8-be43-0051f8e80a8a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23c376e6-1c08-404e-874f-be8d6ea3e5a9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2402d8be-78a2-4dd9-986f-e4133dd5cc41"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("243da07f-d33d-4212-8638-efd9becf2f25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("252955be-1dca-4d2c-9e62-350b764ed409"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("256f3637-742e-4c4f-82d9-912e713d3243"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2629898f-bab9-4f72-87ed-49552db04f61"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("26b18ac6-bc03-478a-834d-1443a5079986"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("26de39f5-e86f-4acc-9b7d-7674fe61ca5a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("27b761df-e322-4ac3-9626-fa38f8f9afa4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("29285f6f-d917-4ca4-bebd-cc00d25d4c58"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("29d0f9ba-9d09-4d4b-854d-e7daf45be1d9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ac7205c-2207-4ae2-8367-ffb757ef792f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2acea7a0-d716-4996-bf52-349ec856edd2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2afd74b8-bec6-42bc-8720-2ca9d97963ba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d2386da-2cbb-4f08-8c58-0725872d3f57"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2f48744d-6893-4830-9457-98bb904a95bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31ada4b0-b1b9-4d7b-a4b4-dbf9bf4216c9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3490453f-800b-4a42-881b-3afcbf41665c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("358693b8-87db-4782-bb01-e8c8bfeed913"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("359497e1-2be8-4fec-a56b-3fdb94558c38"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("36b90439-b211-43a8-88d8-2a320704be72"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37f30af6-d450-4b83-8c94-068768519cb4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3857b056-bce6-4b00-a61d-9ee69cbeb955"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3a48c2a9-82de-4abf-a7f6-7b933fad1d5c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b64cd9f-b6c9-472c-966e-c48559cd486b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d4274b7-8441-4a85-ae3d-d9a65781ad42"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d92af8f-9f11-4968-86a8-2bbdf73ff2e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f093499-4331-4ae3-ba69-97634ab41c54"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ff05229-e2e7-414d-8145-29998a3da74f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4060baa8-bd4f-460d-a506-fdea05c0ed33"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4212614c-5b9a-4844-b214-0a66a2e43ffc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("42abbc5a-dd22-48a5-82dc-d8b49aec3a6a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("42c80c5e-c427-4c19-b9c2-f5e897eaa737"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45802a88-0330-45f2-8713-f7c434faa7f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45973364-dda2-4325-8224-9aebdde633a1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4722f209-b63a-4314-8277-0059f7d9d88a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("484686cc-9384-434f-b2a5-f0e69a05591f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4869ab10-4d9f-4f64-821d-b427e9f4ef7f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4bcdc541-90b2-4703-b045-6dc0d76b96f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5005b1bb-7aad-42b5-b6e1-59cc3dcfe2b5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("519a19ac-c749-4d4e-8320-c7596e52696f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51a682e2-e415-4f4e-82f7-eef6bc2167a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51e88dbf-720e-47fc-b06a-0dfb13a80562"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("55797337-80d0-4ceb-a540-b33578df7437"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("558d5b90-0036-44dc-a31f-8c921e38f1b5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5868e1c2-65a6-453f-bcb1-43b9e739095f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("59166b55-b7d7-4ca9-8809-35ab657b1e70"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("598c58b7-b4fb-4813-a872-99d8c2bfc3b9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b587f0f-83d3-48fa-8059-fa35c73eef7e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d30a10a-fe1e-49eb-a300-56a4a1fc77bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5dba8cde-c33e-4037-9bed-da5a49a891fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6078d6bc-bcbb-48b2-bdc6-404f79a1a2f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("60c1f3fb-2b8a-404a-8b6c-eaf0848d492e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("63fb3665-40c3-4527-99a6-3dce1ec61f1a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("64b464ee-424a-4f4d-ad59-385bb939d811"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("64cb186d-77bc-44d5-9ce0-831bde161264"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("654da7a0-4b05-405c-85cc-84c150702bb0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("677b6a74-0f39-4521-8ed2-10d562c7ea88"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("677daed2-e06e-4197-a49d-e7cf15bd56a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("68d6c929-c953-4f6d-ab45-946db079c319"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a61c4a3-b8a5-4a5d-b2e6-b4d0861d2146"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6aac5187-b1f4-4be2-b754-86987051812b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6bddebb1-229c-421f-a460-bc82fca6dee2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6bfe648c-a660-4ad4-80c1-ca51cb99a4c9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f03b74d-66e6-4a30-8474-6b0f201d322d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("70cb5f2c-6f33-41cd-961e-f30c44b2b269"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("70db89b1-c7ad-4b75-acb5-ff42892fd733"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("71a82d89-163b-4a04-826b-5fd09cbf3bb6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("739926dc-9daf-4257-a0ca-bf2dcf3e7103"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73e849b6-314c-4b2a-bba0-fb9d41f7c513"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("76d25ce9-6a92-4ec6-a295-a78164e20748"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("785b441c-bfd0-452b-9e68-ecfd6c492cef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a336e2d-6a01-4f6d-83f1-5a2eb5689191"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ab2818b-96a2-45ac-b33b-8ebdd02dc106"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ab5c8db-f98a-4dd9-a504-245cf9c796c5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7cf686d7-cf9c-40ad-b013-afdc176e65b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7cfda43b-1b67-4803-8ff4-7d3e926f2855"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7de5fb5c-af65-4a55-9cfe-9948dae4993f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e10fb92-96c0-45e3-a9f1-a6d2b4fc7b2d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("80966716-8b57-40ac-a850-3454876f8ab8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82c47188-7c08-4faa-84af-15bacef9d606"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("844a256b-d8c3-4ca1-8fd5-ac8ea77d4b14"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("850a635d-5b15-4096-8aa0-506fa84c8884"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("863d69da-aa6e-4aad-8128-440c9dac25fe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("874726ab-7b42-43bb-9a38-3e5100e1a83f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("881bd70a-196e-4abc-bef1-1aae604f50f2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c7b674b-b1b8-4046-aa50-14b46c71b4ca"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ce046ce-5675-47da-b381-a217b37feeab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e08e52d-49d0-47cd-9acd-63e9dab2c845"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ef684da-629a-484b-8851-fe605d430f57"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("92b742fe-16b6-47fa-bfbe-eea6b9916fd5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("967e7270-f51f-4fea-bc54-2fdfddd6d448"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9683678f-6f9c-471f-8084-0332d47eb2a1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("96d34649-bcdd-43a0-bfa8-6b8e7ea46b8e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("97553338-6fcd-49f2-b5cb-05f3876c3c87"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9784b08b-6293-4614-9eb4-c798685ec89a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("99859785-308c-4586-abe5-ae3f820da595"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("99b305f0-2e3c-4e71-826b-35751f7ef8cb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9f1d28be-d028-4d0e-bd84-e7629d693639"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0056391-fd99-4811-9222-833e70f7362a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a52d3f93-dd9c-4ee9-a8e9-a69d71d7dc4b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a6e1deae-99b7-4143-b646-54c66b3eaa7e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("adeeff96-3a6e-4faf-a3a5-03710549421f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae50fdba-9471-4b3c-8052-ebfe7d4901d6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae56392e-0cc9-48cf-89b3-4cb4d36c5c12"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b257bf85-8fec-4ad5-b9f1-5884ca832e57"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2c9f5af-7816-4703-80f8-e20e6f389d6b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b30f0518-a154-44c4-ae0b-7e623fea6010"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b33b040f-90f9-4397-9de4-b8cb48b2201e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3c568d0-e2a9-425d-84dc-f8cee8a554d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8df470e-c036-44fe-b576-640b2ccad24a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8e15d10-1cf8-4e38-a5b8-4f88babbb370"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba73732d-9431-4837-bb64-08b747c7810c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bbb135d3-7d8d-4ec9-9d4b-b783335e0df7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd3de7da-332b-4706-844c-f3156e3e1274"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf9f338b-e5a3-4eb9-974a-5fc28ae9c5d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0b42b00-4bf2-436d-addd-e454eb148a80"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c150a718-e901-485d-a054-5e2fa40f395d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c2480bd9-68e2-49cf-96f0-6831ae73a0f2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c39f784f-2851-4686-8264-7ef28c5f41b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3ab9117-8a32-4e6a-b445-c47b8d50de65"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3ee8773-2c4f-4832-8189-02414dc70649"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c437d4cd-f8ea-4c2f-b4f3-45cb7f93a9a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c4586b09-5a35-42fa-b32a-bcd084a8215d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9e64800-106f-4a6f-9c47-e00f4031833c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce7875e7-8661-48b9-ac49-7a19ec8f0b1a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce9f5843-e64c-4c9c-9dd5-d20a782c85e9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ceab5e81-ecc1-41aa-a7aa-5b9af56fa765"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1162d68-be6d-4110-96a2-670331f4c691"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d20f41bc-e68a-454e-b2c6-b806652f93d6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d60f5206-0601-4332-87b4-61167d62d25b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d713b802-6295-4bea-ab92-07857633e3dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d75bfe2f-57c2-42cf-9d7c-c89802bb3f22"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d76637fe-ec3c-4e3c-a58b-df1e6f220abe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8615b80-525a-4d06-a972-b01c2f39c14a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9babff3-1e6a-4e3e-ac1a-33b86770ae73"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9d82d05-a64f-46ee-9ea7-da4d3e7a272b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dcc0201f-375f-4950-9738-13b1f6e116cc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dd57afad-06f2-43fc-a5cb-3f5d5862be0c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0014a38-ddc4-45ef-91c3-043b4d5de535"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0cc825d-b803-4aca-8820-114615c3273e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e29a6441-6565-400b-8869-122d68b2b354"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3024e21-a785-4bab-87d2-62c1a1b1d975"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e625321d-70ad-422f-93b0-27668a332d25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9fe7c7d-65f9-40c9-b440-705c076f0875"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ebf515e9-c111-423e-a6c0-2a6ce5eb2c90"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec0e12bb-a032-4627-a5ed-e7fc3c558e84"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec923b79-28ec-4694-9778-a16389a2c310"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed70efc5-617c-475c-909c-287e2c976d86"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee5260f0-864d-4e0f-b206-df46e22097b8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee6b669f-9094-400b-a467-ffe8a269815b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4494ee7-55db-421b-b76d-2379aa6c8f2b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5d1c2e3-d017-4dc8-b547-9ad5a797f0a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8adf366-d896-4f99-8b59-15ab66464f90"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f99b218b-1042-4c48-b86b-fed7b1d8114a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa28f204-abcd-4cbf-9fe0-5b7e1176c4df"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa72155c-c69a-4837-b65d-4cc29168af51"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb1fef27-00a2-4d11-adb9-6cadce6fb57f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb923bf0-3772-4278-aefa-6fb99d75b7d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe4b1f15-a0f6-4421-ab72-7e52c12e995d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff4018d5-1b84-42c1-ac20-eeb5201789ee"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("002c7607-bdd2-454a-a16d-a55f87ecb4b7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("07a5da13-30ab-4198-b9e4-90859258354c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("15f96d22-a2eb-499c-a847-472308ab44d0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1bb99664-d50a-4b39-a0fb-69a979ac48d2"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("35d2225b-377a-4b3d-aaa8-52ec5f879257"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("47352c45-51a6-4d82-a2bc-6ce660406ba5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4c8e00f2-7ffa-4f56-a197-07b36c0bb2ca"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7045ea38-5399-458d-b595-00484351df60"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7371f042-f567-4caa-8f2d-d044fed09f11"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("741e339c-30ff-45df-92c9-173b4738d7eb"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("74bd5a25-0655-400e-b7ec-ec7cf55e64ac"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("95124566-e43c-4404-b278-c9efeed8e32b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9f03dfdc-7353-4eaf-b3a3-4d49695f882e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a3563a3c-ab98-4cc5-a084-dd36bfe6e393"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a4c5650d-b9e0-4dea-9423-d1af3b8edbbf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b54397ec-c1c4-4e72-aba7-eccba7be9882"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b64399e2-9719-4691-bdb9-773284b7e1eb"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c08babe5-7c6c-4cfa-a2ef-eec89e6818ec"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d3a20d85-7a32-476e-babe-6c6881693cdf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d3e23f5c-544b-43ff-a4d6-910a5e71b6b8"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dbaac515-209d-462d-bca7-c5f8e4d30e67"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f6ac3cd7-b80d-4828-beaa-0f83fdbbca0f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ffd2c436-ce6c-4964-b18a-5f5104f8df46"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8"), new Guid("71c4487f-be90-4834-8484-f0d51bc937a5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), new Guid("33f84785-cdac-4720-b0ee-0add62802d90") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), new Guid("a0459324-4c75-498f-9557-a8bdd7e81419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"), new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("33f84785-cdac-4720-b0ee-0add62802d90") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("a0459324-4c75-498f-9557-a8bdd7e81419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"), new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d"), new Guid("71c4487f-be90-4834-8484-f0d51bc937a5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("33f84785-cdac-4720-b0ee-0add62802d90") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("a0459324-4c75-498f-9557-a8bdd7e81419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"), new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e83c50e7-281b-4603-94f5-76871958ef11"), new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e97cdbeb-6077-4bc1-acc8-44363afb446a"), new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("12a76ba3-e649-47b4-b1ea-8f7261497b02"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("359cf857-095a-4ad0-b08d-4f5be5532055"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("396ce916-e5bd-407d-b7ac-09f759a881d1"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("970175a9-f949-41ae-9652-dd54f101c52e"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("cada6d36-e7dc-4499-8883-68f9933094df"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("f5b2c46e-379c-44a5-872d-46cf891ad3f2"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("0eaa760d-4e22-4e04-b904-e78c87245c0b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("168c1ce5-f7b7-4089-a5c7-04ccc06e476b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ef57001-ab14-4a01-aa1b-674ef264c879"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5201b2a8-dcd2-4f19-a888-a44208d49c00"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5cbd612d-60ad-4846-92b8-35a7482c7c2e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62e44ffe-c56a-4eb8-8198-d5690daa37fe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("752a8c24-1319-4b96-a420-cf91f242cb8d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7772b748-e166-46f7-9a4b-d52b83bfe1fe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8340dfb1-b14f-45a2-9137-2e61e7e26871"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("876e67ab-c623-42ce-8ab1-06c49ec29a2f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("984c0140-80ce-4b4e-905d-8aa1307bf126"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b82b1f67-a4c6-404e-90d3-a2567930b1b9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf76dace-5b7f-4d99-bb1d-7153722912d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d54ac254-adab-4492-8154-c08eee817d2f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("db0b0415-2ac5-4c6f-a6c8-9f694537941b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e83c50e7-281b-4603-94f5-76871958ef11"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e97cdbeb-6077-4bc1-acc8-44363afb446a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2d59d33d-d3d9-48dd-bc68-8ede4a1126f7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3a97f26a-850e-4701-90c8-6c83c7f0bef3"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4e44882d-e478-4ffa-baa7-dd22ff84ee24"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("76e2ccc1-034a-422c-9f8b-b12d4e506118"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a450a032-d14f-4f50-9582-689516559d97"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a647202e-80e0-45ef-b265-f27e8c4e0e3e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b2126673-e2da-4627-ac18-4bd7a075c48e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b78fc36c-8a13-407a-a3cc-c417cfb7291d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("bef9070a-83ac-4542-b324-2394840c9d72"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c148165d-9263-4566-9b5a-29f7121eb393"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d2540b76-89c4-43a6-8dd3-cc537e89243b"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c4224f9e-725e-44d2-ba7e-2af7177c103d"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("0e7eb636-5f16-41be-a6d9-22ce45e2c299"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("137bac8d-ba4e-4d59-884a-6d4696fb0ed0"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("8a7a0deb-9a6e-4e5e-a538-181e770ee457"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("8df5f83c-5c9c-44ff-900c-c08e5e4b49e8"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("a73a7f44-e440-47b6-bd2a-b99a3b151a53"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("f2cf56dc-99c4-491e-aecb-e01397041d62"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("f9446a3f-bc19-44a1-8181-1a7df076e009"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("fe53aaa6-0c9e-4a72-9a3d-36aec9a5c4d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("024f8cd9-29e2-4a99-9e49-5e5fd787a3a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4077c323-7fa5-4348-8db1-aafbb855b5eb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b680b490-657e-45c2-b2bc-d43aa768de29"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b7f1731c-f91f-46fb-ba88-60ee01381f77"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc897e3e-fe79-4730-b261-228473ea66a5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9e65a8c-8852-4697-ba91-84ac4c4cf4a2"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("05213ff1-1e1a-40ed-9725-daefa6ed076e"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("1c9bee55-62e0-405c-9f5a-80746f579f59"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("33f84785-cdac-4720-b0ee-0add62802d90"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("3f1e3334-ebb2-4c24-821d-aef793aa771f"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("71c4487f-be90-4834-8484-f0d51bc937a5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("90cac2de-de21-4ee9-90dd-b7cf0896ae92"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("a0459324-4c75-498f-9557-a8bdd7e81419"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("b0145a76-5c1e-4755-8dce-5c20dbd46493"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("0ab0657a-143d-478c-b030-9e2c9a0e4783"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("1014fd2d-99dd-492f-b548-5e0e8786afbd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b948cdb1-3603-4d87-84bb-2e13648d20de"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("18504468-dea4-45f1-87cb-46045bb91357"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5346236b-eeb9-44d8-95b0-c67d139804ac"));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "StartTime",
                table: "TransferPoints",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "TransferPoints",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Places",
                type: "decimal(18,8)",
                precision: 18,
                scale: 8,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,8)",
                oldPrecision: 18,
                oldScale: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Places",
                type: "decimal(18,8)",
                precision: 18,
                scale: 8,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,8)",
                oldPrecision: 18,
                oldScale: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("08f56c25-e139-4872-a00a-3c5160f849ac"), null, "leisure", null },
                    { new Guid("5f4a7bb9-aefa-44c5-8d6d-f67b530bd397"), null, "entertainment", null },
                    { new Guid("684c4d39-1729-4cb6-b4bb-3752815ba886"), null, "sport", null },
                    { new Guid("80e85eb2-daea-4f00-b0dd-c717b385e4cd"), null, "heritage", null },
                    { new Guid("8113f978-06dc-4ed8-87b8-dc4ef82d3445"), null, "religion", null },
                    { new Guid("a76c0ea8-6b08-4ebd-8cd6-e9a668985737"), null, "natural", null },
                    { new Guid("b4028241-10c6-49f8-9fa5-f3bb1f942d19"), null, "activity", null },
                    { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), null, "tourism", null },
                    { new Guid("e9f50e3a-3cea-4dcf-a986-da777dcff506"), null, "national park", null },
                    { new Guid("edc7849b-3a1e-4c80-8eb7-8051a5c74f17"), null, "commercial", null },
                    { new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6"), null, "catering", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("01663309-885a-481d-ac4f-88bcab0e95c9"), null, "dogs", null },
                    { new Guid("0bfade11-a9a6-4c14-92e4-a1b4160eaa83"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("13c4fbc9-3a9d-43ea-9573-34e97ce73b7e"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("2323ca23-e2ab-447a-9139-b7fbbd3e9c61"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("39e31b42-4764-4059-9bb0-96a9cfdb8658"), null, "no-dogs", null },
                    { new Guid("72ce4718-331c-4f5c-9088-6bf7938e8865"), null, "wheelchair", null },
                    { new Guid("761eaf28-cf40-4e4d-bf6b-f005e5482bff"), null, "fee", null },
                    { new Guid("78c2e086-a11e-4b0a-9740-f4a9fc85d3f1"), null, "internet_access", null },
                    { new Guid("84839285-b012-42a9-8ea3-94e166409823"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("930bf3d6-25a7-4f13-a733-9470802569a5"), null, "access_limited", null },
                    { new Guid("9854a677-6bce-43bf-9f4e-dea84f85be8a"), "Name property defined for the place", "named", null },
                    { new Guid("9dfaf84e-0c65-4642-a449-524545520031"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("a2b7089f-6912-4b76-bfdf-1d4ec95c1ab9"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("cea86681-7ad8-47b9-9f24-c0c0a0aed640"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("dbe5a9d6-144a-430a-a5f4-069010a83ccb"), null, "access", null },
                    { new Guid("e9eda27a-d158-4b3f-872f-26c8db1f2485"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("fcfdba2a-6bb1-4f0f-aa23-ef2a92f277a0"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("feb561fa-7a9e-45fe-a977-8d6924d64a0a"), "Places where you can buy or eat soy free food", "soy_free", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("07329306-ee33-4503-ad60-631641248da4"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("151ac055-1d1e-4076-b232-bdce26a05230"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceCategoryId", "PlaceType", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("324904e3-2401-4ca1-acc5-34686182f20a"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", null, "CustomPlace", null, null },
                    { new Guid("37a596d9-e1dd-402e-884b-d14ce6971802"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", null, "CustomPlace", null, null },
                    { new Guid("642d88a2-8c74-4fe3-a74d-7005f9f8fbcd"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", null, "CustomPlace", null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("68b8ee11-353b-47a7-942a-6d2e7914b81a"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null },
                    { new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" },
                    { new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null },
                    { new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" },
                    { new Guid("f11cb634-0ec2-4093-8b89-db9a02946774"), "Raszkówek", "Poland", null, 51.73393750m, 17.74069633m, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", "Greater Poland Voivodeship", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974"), null, "place_of_worship", new Guid("8113f978-06dc-4ed8-87b8-dc4ef82d3445") },
                    { new Guid("0b8e8aad-eea3-4c96-b600-e52f2525fa78"), null, "stadium", new Guid("684c4d39-1729-4cb6-b4bb-3752815ba886") },
                    { new Guid("0be79d01-986e-409a-9cf8-5aff7d9d3f35"), null, "park", new Guid("08f56c25-e139-4872-a00a-3c5160f849ac") },
                    { new Guid("12d8c96b-af71-4ce4-aa11-31e01fd12c70"), null, "art", new Guid("edc7849b-3a1e-4c80-8eb7-8051a5c74f17") },
                    { new Guid("1794fa91-0f91-4798-b668-1f86eea20a42"), null, "attraction", new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d") },
                    { new Guid("1f08516a-df75-44fa-b05b-dac61a2fd884"), null, "zoo", new Guid("5f4a7bb9-aefa-44c5-8d6d-f67b530bd397") },
                    { new Guid("32f817f2-7272-49cc-9f93-8fe3d9fad1ee"), null, "culture", new Guid("5f4a7bb9-aefa-44c5-8d6d-f67b530bd397") },
                    { new Guid("34473868-3e60-42f7-9fea-6a26acdf2d7c"), null, "planetarium", new Guid("5f4a7bb9-aefa-44c5-8d6d-f67b530bd397") },
                    { new Guid("35e92f23-8972-46c1-a7e1-ae2b3699c576"), null, "biergarten", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") },
                    { new Guid("37a6dc87-a783-45db-b144-d1759b465ef3"), null, "sand", new Guid("a76c0ea8-6b08-4ebd-8cd6-e9a668985737") },
                    { new Guid("68000558-4c2f-47a7-914a-0e0a4a0a173c"), null, "ice_cream", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") },
                    { new Guid("6e4e721c-0d1f-40d8-b92d-7bf004c82b17"), null, "bar", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") },
                    { new Guid("751971f3-d3e4-4cf7-9577-ec235c52e7ff"), null, "forest", new Guid("a76c0ea8-6b08-4ebd-8cd6-e9a668985737") },
                    { new Guid("836e6c3d-c57a-43fc-a7d6-c8083d1beec4"), null, "unesco", new Guid("80e85eb2-daea-4f00-b0dd-c717b385e4cd") },
                    { new Guid("882e821f-4cdc-4d9b-9ac0-9a395ef4dfaf"), null, "gift_and_souvenir", new Guid("edc7849b-3a1e-4c80-8eb7-8051a5c74f17") },
                    { new Guid("8e07a448-492d-4cbb-a698-e6d6caa7920e"), null, "taproom", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") },
                    { new Guid("975fbb15-c5ab-4937-9591-86ab07a51b18"), null, "pub", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") },
                    { new Guid("c153ecf8-c901-4946-8239-b4c9997df8c4"), null, "mountain", new Guid("a76c0ea8-6b08-4ebd-8cd6-e9a668985737") },
                    { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), null, "sights", new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d") },
                    { new Guid("c4f37729-41fc-461c-aca1-8473a2570804"), null, "food_court", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") },
                    { new Guid("d4e22aa8-4984-49a9-a5fc-e33f052745a4"), null, "water", new Guid("a76c0ea8-6b08-4ebd-8cd6-e9a668985737") },
                    { new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062"), null, "cafe", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") },
                    { new Guid("e9deed57-f916-4294-9053-330efddbad7a"), null, "museum", new Guid("5f4a7bb9-aefa-44c5-8d6d-f67b530bd397") },
                    { new Guid("ee1a6ed3-849e-49c9-be8f-c9529225d3fe"), null, "aquarium", new Guid("5f4a7bb9-aefa-44c5-8d6d-f67b530bd397") },
                    { new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7"), null, "restaurant", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") },
                    { new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346"), null, "fast_food", new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("0921909e-50fd-481b-86e5-43c9413903f7"), "Places that are available for public", "yes", new Guid("dbe5a9d6-144a-430a-a5f4-069010a83ccb") },
                    { new Guid("155392d0-a1e7-4cf4-aa19-849f6791e477"), null, "yes", new Guid("01663309-885a-481d-ac4f-88bcab0e95c9") },
                    { new Guid("2501d957-82b1-4eac-a6e1-530a1c88532b"), null, "free", new Guid("78c2e086-a11e-4b0a-9740-f4a9fc85d3f1") },
                    { new Guid("299074ac-f43e-4689-895e-fecf59c15020"), null, "yes", new Guid("72ce4718-331c-4f5c-9088-6bf7938e8865") },
                    { new Guid("2db78452-9ce4-4cf8-ba95-7f6ec1c80ec1"), null, "leashed", new Guid("01663309-885a-481d-ac4f-88bcab0e95c9") },
                    { new Guid("4cb9a661-a596-4409-99b8-aa549f15e20a"), null, "only", new Guid("84839285-b012-42a9-8ea3-94e166409823") },
                    { new Guid("622ed97a-e5de-4493-b8d2-eebd423f5e11"), null, "only", new Guid("13c4fbc9-3a9d-43ea-9573-34e97ce73b7e") },
                    { new Guid("64087e58-6828-4a01-8724-a64b432714c4"), null, "customers", new Guid("930bf3d6-25a7-4f13-a733-9470802569a5") },
                    { new Guid("649efd4d-d6c6-4373-b431-7d523fc41cbe"), null, "not_specified", new Guid("dbe5a9d6-144a-430a-a5f4-069010a83ccb") },
                    { new Guid("82e4baf4-766e-4e0b-bbbe-526c5638011c"), null, "for_customers", new Guid("78c2e086-a11e-4b0a-9740-f4a9fc85d3f1") },
                    { new Guid("8a21656c-dec3-4070-9526-5b2c7cd27fb5"), null, "only", new Guid("e9eda27a-d158-4b3f-872f-26c8db1f2485") },
                    { new Guid("9bacbdfd-4c87-4581-99c6-679c4c761021"), null, "no", new Guid("cea86681-7ad8-47b9-9f24-c0c0a0aed640") },
                    { new Guid("b134c2a9-c14e-4ee4-973e-6f50f33a418b"), null, "only", new Guid("9dfaf84e-0c65-4642-a449-524545520031") },
                    { new Guid("b244fe53-59b9-4d4f-8fa6-f6e5e214223e"), null, "only", new Guid("0bfade11-a9a6-4c14-92e4-a1b4160eaa83") },
                    { new Guid("c14971ed-cb32-43a8-b774-aa7416e115e0"), null, "not_specified", new Guid("cea86681-7ad8-47b9-9f24-c0c0a0aed640") },
                    { new Guid("dbe64c17-fe2f-4d2c-a2d5-9bd84dd0630a"), null, "limited", new Guid("72ce4718-331c-4f5c-9088-6bf7938e8865") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("07329306-ee33-4503-ad60-631641248da4") },
                    { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c") },
                    { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565") },
                    { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d") },
                    { new Guid("b95b551c-f0e7-4914-9ccb-2a7dbf24ef7d"), new Guid("f11cb634-0ec2-4093-8b89-db9a02946774") },
                    { new Guid("f4c21296-2a6a-490c-80bb-120304dea1c6"), new Guid("151ac055-1d1e-4076-b232-bdce26a05230") }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[] { new Guid("d2f1570b-fca7-4c57-a337-5de6742de5f8"), 100m, null, null, "PLN", new Guid("68b8ee11-353b-47a7-942a-6d2e7914b81a"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("03e31e0b-ffdb-45e7-8c21-39747dd0b6e8"), null, "chili", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("0458fb2e-c48a-48bc-86ca-1d8f9115aea8"), null, "clock", new Guid("1794fa91-0f91-4798-b668-1f86eea20a42") },
                    { new Guid("04dcb3d7-1b15-4ca3-b0af-15dc022af4ed"), null, "battlefield", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("052ec867-3254-40a9-a899-d6ad2249fc30"), null, "malaysian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("05dbbd40-ff6e-4b75-b577-6e2a99e03df4"), null, "tacos", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("0834bd73-6510-4c17-9f5b-59511a29ff48"), null, "indian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("09b830da-4132-435a-a1f5-a650215b1fd0"), null, "hot_spring", new Guid("d4e22aa8-4984-49a9-a5fc-e33f052745a4") },
                    { new Guid("0b8239ed-d9f2-435d-81d1-b66e8a5c56b8"), null, "archaeological_site", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("10f88d4e-e618-4030-8275-cd3710efe562"), null, "pizza", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("114e69ed-526d-4bf1-aab4-f9a1bfdd2bab"), null, "bavarian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("1287b467-7909-4687-a140-748b0e5f6512"), null, "western", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("12a73074-4e0d-43b6-bedc-cd2007ff7599"), null, "dessert", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("17e98354-f6b6-4857-a4e5-c8bd01bce39f"), null, "lighthouse", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("18c964cf-28ca-4b4e-ad53-5b4ebca06bb6"), null, "sandwich", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("199fee46-cbfa-4abc-9ad0-3edefdc3ffd0"), null, "windmill", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("19a47bf1-2c88-4396-9911-a7ebb78f18c7"), null, "donut", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("1ab2e758-98a4-4814-be15-afba51656135"), null, "salad", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("1d750782-23c2-4862-9418-600ea6500b7a"), null, "wings", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("1f129cfe-b903-4f94-a3dc-782c3f5ad968"), null, "soup", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("1f131cb7-1a7b-4c61-96e9-e7d6e80b50ad"), null, "monastery", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("211f4054-7536-4acb-b1ab-f3eb2b538ef6"), null, "ukrainian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("22492506-e889-4332-8ba5-155643ecf4c8"), null, "filipino", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("22a2444a-28a9-45ef-a868-45f1cdad8544"), null, "tapas", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("2916462f-7763-4e8d-8cb9-5977cba01847"), null, "christianity", new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974") },
                    { new Guid("2ad9afec-cfc6-4b0e-b6e0-806ad81e8072"), null, "american", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), null, "memorial", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("2e03cfc2-d3fb-4a0c-9436-d0b8698e069b"), null, "fountain", new Guid("1794fa91-0f91-4798-b668-1f86eea20a42") },
                    { new Guid("2efe5d2a-66a4-4ca5-80eb-6106e367341c"), null, "taiwanese", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("2f310161-8d23-4a92-a32e-5e2713821962"), null, "friture", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("307aa4d5-5b5d-4bd0-83bd-8d0b89633b2c"), null, "kebab", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("341f12de-8850-4106-b986-d78f994f638c"), null, "arts_centre", new Guid("32f817f2-7272-49cc-9f93-8fe3d9fad1ee") },
                    { new Guid("350b2aa7-c24a-4a0b-98ec-33bb2addd3e8"), null, "pita", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("357043e1-986a-4c1c-bcc4-058fda927d58"), null, "sushi", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("39e4fb5f-bfa9-449c-af53-7daf7a0529f7"), null, "sandwich", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("3fc84717-3c4a-4a91-b112-3a044ec067c0"), null, "ethiopian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("411335bb-358b-491b-bab0-ea8797638388"), null, "moroccan", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("41222fe7-0157-45b9-b869-f95e98841d02"), null, "spanish", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("429e296f-6dc6-4e4e-9b56-89e9ad1ae083"), null, "rock", new Guid("c153ecf8-c901-4946-8239-b4c9997df8c4") },
                    { new Guid("43f92418-203a-463b-9789-7830f949b60c"), null, "bubble_tea", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("458b9253-960e-44ba-a6cb-1ce7d7bdd4a5"), null, "steak_house", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("45f0c4e5-f065-4e49-8c77-2604db8494f4"), null, "curry", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("46a721a6-5ac6-43a8-ad00-5a514537a601"), null, "tacos", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("472b543d-1481-48fd-9e24-80bce0fe338c"), null, "afghan", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("491ef2d0-3ce0-4511-b6aa-91ca2671cb49"), null, "reef", new Guid("d4e22aa8-4984-49a9-a5fc-e33f052745a4") },
                    { new Guid("4933c5d0-ee41-4183-81e9-e1bdd27038d6"), null, "thai", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("4af3aef4-bb14-4b5e-9342-05b918c8ee6d"), null, "regional", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("4ebe7a27-5cc4-4ff1-bd7e-5d380bc8d972"), null, "bolivian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("50c1e528-0589-4f40-a03b-ccdbdeca0dd7"), null, "hungarian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("51dcc686-0f32-44e1-ac05-577a930410a5"), null, "noodle", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("523c5e38-a44c-4400-bdbf-fdae919c93be"), null, "chicken", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("525765bf-7a06-4679-8ce1-f3adee9ff131"), null, "german", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("55bfac84-3cc1-4ad3-a59f-d419c4e92343"), null, "european", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("5894d0d3-6935-4234-bfa1-3d140e3a3b21"), null, "tea", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("58b8332a-9070-4dd5-b1a5-809bf8cbbb75"), null, "sea", new Guid("d4e22aa8-4984-49a9-a5fc-e33f052745a4") },
                    { new Guid("5b2c37ae-e1bc-43e2-8252-7313683d2ff8"), null, "chinese", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("5d168d79-f5d1-4f90-a7e3-5f6edbf1dfca"), null, "nepalese", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("5e817807-b373-4836-9675-75f6b9c09096"), null, "wings", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("5f052a63-34b3-4c52-a452-ef69a4b10b33"), null, "glacier", new Guid("c153ecf8-c901-4946-8239-b4c9997df8c4") },
                    { new Guid("6136d038-5e04-462c-8dd6-39ac191283d5"), null, "ramen", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("614c062f-dbc6-4b8d-9553-da622bc8fa8a"), null, "malay", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("61571cfa-89e3-4fea-b327-18d1c4c14b80"), null, "indonesian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("63a17f7a-06b4-4a71-a56b-983c9e7d46a0"), null, "coffee_shop", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("63ffafd2-728d-4810-9385-455bcd7c41da"), null, "sikhism", new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974") },
                    { new Guid("64d67116-ff0a-4d7f-8336-c1748cc016b1"), null, "dune", new Guid("37a6dc87-a783-45db-b144-d1759b465ef3") },
                    { new Guid("655a207f-8a90-413a-bda5-306763e4f1ee"), null, "czech", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("66509610-52b6-41c3-b8e6-1fc1836b7cc7"), null, "castle", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("6c385ab1-6689-4e9b-9d82-b87ded0a8bb0"), null, "islam", new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974") },
                    { new Guid("6dd93d16-4a09-4a9b-a385-820e4a71a7da"), null, "peak", new Guid("c153ecf8-c901-4946-8239-b4c9997df8c4") },
                    { new Guid("6ed0840c-aa96-40e7-8e1d-6e12832e1603"), null, "burger", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("6fd94e70-87f8-4efe-8e33-642f68d7b8b3"), null, "georgian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("7502a9ec-acf2-41ca-a11f-488bbba03103"), null, "belgian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("78903729-9c17-4ae2-8d3b-397dbcc524d9"), null, "pizza", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("7bb0e10b-4b6a-418d-beb1-d691766a387b"), null, "frozen_yogurt", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("7ec66cc3-ed91-4e35-a95f-142359fa608b"), null, "mexican", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("857eb968-f17b-4791-afd2-c49445099023"), null, "jamaican", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("89d3d649-5f16-4595-88b8-9ee58126e421"), null, "french", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("8d3ec67b-341e-4fe8-9c5c-b05b3555fedd"), null, "cliff", new Guid("c153ecf8-c901-4946-8239-b4c9997df8c4") },
                    { new Guid("91ef4ee2-458a-4de1-a6c7-541651793ea5"), null, "multifaith", new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974") },
                    { new Guid("926f01ca-53c5-4041-ba9e-d22d331f18c3"), null, "noodle", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("9505320b-be30-4498-abc3-abbbe54fbee3"), null, "caribbean", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("955e772e-a418-479b-867c-f75d14d41622"), null, "african", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("968a0669-e32e-4f2f-9876-6123519587c9"), null, "tex-mex", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("991888dc-6f05-49cf-814d-3ef6619e99dc"), null, "beef_bowl", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("9bc1af6e-51da-45c1-91f6-1e341385809a"), null, "fish_and_chips", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("9c034120-c70e-4aa5-b235-68c30081a4dd"), null, "dumpling", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("9d7eedc1-6dad-4a69-8bb2-01f8f4ccda23"), null, "fort", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("9ebb29a4-140f-4e3a-bc1e-bf5f721c2718"), null, "lebanese", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("9fd0629a-0f25-4cde-b4ad-300c72cb2120"), null, "tower", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("a01e8a5b-7acc-42ed-8580-ba22e788a896"), null, "cave_entrance", new Guid("c153ecf8-c901-4946-8239-b4c9997df8c4") },
                    { new Guid("a04b8aa3-e32b-4364-a18b-18473bf521cb"), null, "oriental", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("a3ed765a-a8d3-47f6-9316-ac53614697f7"), null, "persian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("a4011f17-aa4f-45fa-8adc-afaf9428618c"), null, "shinto", new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974") },
                    { new Guid("a5714602-be6c-424b-b92c-bea54ed87bdf"), null, "barbecue", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("a6b5a031-768b-4486-86a7-d0c1bcb00b06"), null, "croatian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("a8f75d74-2145-41c0-adbc-4806214438f7"), null, "city_hall", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("a9d03c32-ac4d-4a31-9887-542a48145f26"), null, "italian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("ab55640c-8f68-4f53-beb6-5955cd7540ef"), null, "garden", new Guid("0be79d01-986e-409a-9cf8-5aff7d9d3f35") },
                    { new Guid("ac18f3bb-4b45-4814-adc0-5d503bc2024f"), null, "syrian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("ad97fd2c-59e1-476d-967a-68e7ca048edb"), null, "artwork", new Guid("1794fa91-0f91-4798-b668-1f86eea20a42") },
                    { new Guid("af754faa-a532-4398-b20a-ef52d89d4102"), null, "cake", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("b086dcbf-8e70-4b15-8990-144b74ce113b"), null, "kebab", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("b74a66d5-69e7-4d5f-8156-ee9127f45171"), null, "tapas", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("b9a72ce3-07c1-40f8-abe1-feda9c627ba2"), null, "ice_cream", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("ba7c5a14-6531-456c-b59b-35e24b33a3f1"), null, "viewpoint", new Guid("1794fa91-0f91-4798-b668-1f86eea20a42") },
                    { new Guid("ba937fe8-8e23-416c-9b11-fbc4352a8297"), null, "cuban", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("bb53a044-eda0-4523-aa09-c1ff6dc4274b"), null, "waffle", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("bbd3954b-1746-49d8-95c2-3aee638b6c4e"), null, "brazilian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("bce9d937-8338-49ec-947e-2b78846edcc5"), null, "ramen", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("bd33e96a-0cb4-46a6-9b25-f4e64b71e446"), null, "buddhism", new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974") },
                    { new Guid("bdd343f8-cbf3-4d26-a7f9-5a678156057b"), null, "hawaiian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("be76ec05-da94-4d6f-adea-46e7a7336d08"), null, "turkish", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("be7a2aa2-e3e6-48f6-adb0-ebf21769ad5e"), null, "vietnamese", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("c54cb763-c4ab-4260-9355-7eaeecb1da72"), null, "judaism", new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974") },
                    { new Guid("c78045d3-4fa3-427d-80b5-1f5bce2d4438"), null, "coffee", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("c97f7937-b362-4e1b-b27c-8ab0d740d0db"), null, "pakistani", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("ca84c07f-c83f-4018-9a06-edabd896f1bd"), null, "pita", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("caef0594-2337-4c23-95d8-fe1f0b2e2919"), null, "argentinian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("cb271b7e-3519-468a-a2b4-f4324d444683"), null, "danish", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("cfa85278-4858-4800-8a78-4c15c6411445"), null, "latin_american", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("d2285b70-809e-4ef1-ac58-0e8b3a458165"), null, "soup", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("d2ef6eb6-940f-4459-a976-fc78c60217ec"), null, "austrian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("d307b234-cf09-4e23-b740-ab8943e18490"), null, "russian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("d472f1cf-7860-4b60-a9c0-9a031fdf805b"), null, "peruvian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("d50243f3-a98e-4588-b135-7bab8925f407"), null, "balkan", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c"), null, "place_of_worship", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("d9ac2d7d-ee8e-4ca0-997f-a73c62d3fea8"), null, "ruines", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("dd3add1a-772c-4cac-a71b-68732d86c3ba"), null, "geyser", new Guid("d4e22aa8-4984-49a9-a5fc-e33f052745a4") },
                    { new Guid("de1a2f15-83d9-415a-a888-72b3b1f78a4b"), null, "portuguese", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("e063c713-0c74-4a62-ba14-176777f2ba35"), null, "international", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("e25df910-97d7-4b2b-a5c4-b4ce14dab0cd"), null, "uzbek", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("e4871bb4-7963-4010-93d9-879861121af3"), null, "theatre", new Guid("32f817f2-7272-49cc-9f93-8fe3d9fad1ee") },
                    { new Guid("e69ae47e-24f5-424f-856b-d84cfd82ebe0"), null, "nature_reserve", new Guid("0be79d01-986e-409a-9cf8-5aff7d9d3f35") },
                    { new Guid("e72471ea-7b9f-49d4-80af-dbf3635d6f6d"), null, "hot_dog", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("e8808d91-a6c4-496c-9767-b90f089656d7"), null, "city_gate", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("e95ac08a-a532-4123-bf0b-815a7997fd93"), null, "seafood", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("e9f8b7c3-1d04-416e-8185-2b4175e85ceb"), null, "bridge", new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b") },
                    { new Guid("ea3ba415-6d57-4a94-b4d6-42efe77af0b4"), null, "korean", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("ec1399fc-c188-4080-ad72-bc57b8f9b68e"), null, "mediterranean", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("f1d291c4-5651-4941-85d3-a3748bcc6c48"), null, "fish", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("f5339b88-822b-469b-b61d-8d1528a40a8b"), null, "arab", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("f5e6154a-1eda-4360-8076-b1c01c6c6cf2"), null, "hinduism", new Guid("02a18789-47d0-4e4a-b4fa-0c0037983974") },
                    { new Guid("f6a271e0-bed3-4fac-b1a7-70298d2e86c6"), null, "japanese", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("f6b13072-e6e8-4155-8035-c70a7611ff2a"), null, "swedish", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("f833c7f5-25af-49bc-a5f6-bbb090722aaf"), null, "spring", new Guid("d4e22aa8-4984-49a9-a5fc-e33f052745a4") },
                    { new Guid("f8b64bd2-b4a0-4557-82e5-0f8351976c84"), null, "irish", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("f958b20a-e2b6-43f9-9f45-14d5d4de1f06"), null, "fish_and_chips", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") },
                    { new Guid("f9c06365-4252-4f24-854b-3b1356deefb4"), null, "gallery", new Guid("32f817f2-7272-49cc-9f93-8fe3d9fad1ee") },
                    { new Guid("fa267ec5-5adf-41b6-8ed5-daf8f47e0b25"), null, "greek", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("fba83f70-9105-44ea-9d97-ee58c3d158aa"), null, "crepe", new Guid("d5c9f5dc-e1d2-4026-b25f-79a7681ff062") },
                    { new Guid("fced948a-03df-4bec-83b7-ddba04974d3c"), null, "asian", new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7") },
                    { new Guid("fdd47872-db4a-41e7-adb2-a39195081d4f"), null, "burger", new Guid("f986caae-ebcc-4673-9a8a-3a87e6deb346") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("1794fa91-0f91-4798-b668-1f86eea20a42"), new Guid("f11cb634-0ec2-4093-8b89-db9a02946774") },
                    { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("07329306-ee33-4503-ad60-631641248da4") },
                    { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c") },
                    { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565") },
                    { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d") },
                    { new Guid("c25eda38-cdc5-44ff-aa54-6b1f7ce6576b"), new Guid("f11cb634-0ec2-4093-8b89-db9a02946774") },
                    { new Guid("f0f5771f-cee3-4e15-bd17-76e0f10a30a7"), new Guid("151ac055-1d1e-4076-b232-bdce26a05230") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("2ee65b73-51e7-442c-b364-a6160643be8a"), new DateOnly(2024, 12, 20), new Guid("d2f1570b-fca7-4c57-a337-5de6742de5f8") },
                    { new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a"), new DateOnly(2024, 12, 21), new Guid("d2f1570b-fca7-4c57-a337-5de6742de5f8") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("1e482ad5-ea03-411b-b556-b3fe557b2b0e"), null, "locomotive", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("43596b43-e051-4370-999b-a267416b625d"), null, "tomb", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("47225852-e75e-4039-9b79-8f104cbc35ee"), null, "railway_car", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("502ff6c1-a8cd-4fea-870c-72ff9fd5c3d7"), null, "wayside_cross", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("673d1a32-40fc-488f-a6bf-f034efc49d15"), null, "tank", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("6d7743df-876a-432f-a17d-b5b7413460f0"), null, "aircraft", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("6ee5f320-4623-4884-86b0-e077a9fc2359"), null, "mosque", new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c") },
                    { new Guid("778f73cf-4a1c-4561-bf5b-65f7abbbd430"), null, "temple", new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c") },
                    { new Guid("78b7840a-a661-44f2-8d73-6b451d50aed7"), null, "ship", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("7bee7563-36f2-4682-8e94-d3818b068ef0"), null, "boundary_stone", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("7e1bcffd-98ff-4e14-9f4a-45c7979f4a79"), null, "shrine", new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c") },
                    { new Guid("88bdc1d0-dae8-4abd-ae64-5ab56a492ec4"), null, "cathedral", new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c") },
                    { new Guid("b13cfa90-81fb-46e6-9241-f7dbb8a2c5ea"), null, "chapel", new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c") },
                    { new Guid("c548b7a8-6c78-47f8-915b-6ac2d729c7e8"), null, "milestone", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("d8de6fd6-52dd-481f-a26b-b24694e2cec6"), null, "monument", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("dc54bd72-ebde-4b8b-a53c-cc475fc77e8c"), null, "pillory", new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325") },
                    { new Guid("e23b39cb-5e78-4ebc-88c0-f808d6cadb60"), null, "synagogue", new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c") },
                    { new Guid("f27ab3f6-9fde-4f51-a38b-f4e45264457b"), null, "church", new Guid("d56f7cf8-5a76-432a-a0dc-253561126e0c") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), new Guid("07329306-ee33-4503-ad60-631641248da4") },
                    { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c") },
                    { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565") },
                    { new Guid("2dd55a4e-48ee-43c5-bf41-2dd12d086325"), new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d") },
                    { new Guid("d9ac2d7d-ee8e-4ca0-997f-a73c62d3fea8"), new Guid("f11cb634-0ec2-4093-8b89-db9a02946774") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("176cc878-a8de-4f73-be44-7bddfceae62c"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("f11cb634-0ec2-4093-8b89-db9a02946774"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("2ee65b73-51e7-442c-b364-a6160643be8a") },
                    { new Guid("62e1b231-2174-4fea-994c-dea5132880d3"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("ae559f8f-cb5c-4087-a3dc-119a280e495d"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("2ee65b73-51e7-442c-b364-a6160643be8a") },
                    { new Guid("6597f931-3195-44e4-82b8-66fe73e957d9"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("642d88a2-8c74-4fe3-a74d-7005f9f8fbcd"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a") },
                    { new Guid("6c07d4b5-030b-47bd-9359-dfed8e55ad58"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("37a596d9-e1dd-402e-884b-d14ce6971802"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("2ee65b73-51e7-442c-b364-a6160643be8a") },
                    { new Guid("7d1ffbc4-e64f-4f46-a66b-519d7042c656"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("151ac055-1d1e-4076-b232-bdce26a05230"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a") },
                    { new Guid("9c650e18-76db-495c-a9bf-07b622a850c0"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("91d6f73a-53e1-4de3-b64d-b8ec59a57565"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a") },
                    { new Guid("9fbb0c66-be16-404e-86aa-3ce654e373b2"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("324904e3-2401-4ca1-acc5-34686182f20a"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("2ee65b73-51e7-442c-b364-a6160643be8a") },
                    { new Guid("f812e00d-e1f5-472a-9fe6-2303f1cced56"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("6e5a189b-490d-4c3a-9e1a-428a469b6f9c"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a") },
                    { new Guid("fcbba43f-b000-4a56-bfab-2a90cece5ffc"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("07329306-ee33-4503-ad60-631641248da4"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("2ee65b73-51e7-442c-b364-a6160643be8a") }
                });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "StartTime", "ToTripPointId", "TransferTime", "TripDayId", "Type" },
                values: new object[,]
                {
                    { new Guid("1cccd723-e77f-4e56-8842-abd6fe0c852a"), new Guid("f812e00d-e1f5-472a-9fe6-2303f1cced56"), 2, new TimeOnly(12, 40, 0), new Guid("9c650e18-76db-495c-a9bf-07b622a850c0"), new TimeSpan(0, 0, 3, 13, 0), new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a"), null },
                    { new Guid("a914becc-6d71-42ab-b168-66ec85e1b186"), new Guid("6c07d4b5-030b-47bd-9359-dfed8e55ad58"), null, new TimeOnly(13, 0, 0), new Guid("9fbb0c66-be16-404e-86aa-3ce654e373b2"), new TimeSpan(0, 0, 20, 0, 0), new Guid("2ee65b73-51e7-442c-b364-a6160643be8a"), null },
                    { new Guid("a9cf702a-424f-4a2d-87c1-2aaec5ba3a81"), new Guid("9c650e18-76db-495c-a9bf-07b622a850c0"), 3, new TimeOnly(13, 10, 0), new Guid("7d1ffbc4-e64f-4f46-a66b-519d7042c656"), new TimeSpan(0, 0, 8, 18, 0), new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a"), null },
                    { new Guid("c518bd7d-da5b-430a-b183-a170799baff2"), new Guid("7d1ffbc4-e64f-4f46-a66b-519d7042c656"), 4, new TimeOnly(15, 30, 0), new Guid("6597f931-3195-44e4-82b8-66fe73e957d9"), new TimeSpan(0, 0, 13, 30, 0), new Guid("c16ee35f-c3b6-421e-ab26-1f5ee061061a"), null },
                    { new Guid("ccd15f3d-b8fb-4e2f-a2cf-d7ccda672e84"), new Guid("62e1b231-2174-4fea-994c-dea5132880d3"), 1, new TimeOnly(12, 0, 0), new Guid("6c07d4b5-030b-47bd-9359-dfed8e55ad58"), new TimeSpan(0, 0, 0, 55, 0), new Guid("2ee65b73-51e7-442c-b364-a6160643be8a"), null },
                    { new Guid("ec6d5cea-b254-420b-846e-2e6e71a30777"), new Guid("176cc878-a8de-4f73-be44-7bddfceae62c"), 0, new TimeOnly(10, 20, 0), new Guid("fcbba43f-b000-4a56-bfab-2a90cece5ffc"), new TimeSpan(0, 0, 14, 21, 0), new Guid("2ee65b73-51e7-442c-b364-a6160643be8a"), null }
                });
        }
    }
}
