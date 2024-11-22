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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
