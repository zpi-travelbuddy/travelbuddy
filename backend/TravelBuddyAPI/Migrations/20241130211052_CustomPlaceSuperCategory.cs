using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class CustomPlaceSuperCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_PlaceCategories_PlaceCategoryId",
                table: "Places");

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
                name: "PlaceCategoryId",
                table: "Places",
                newName: "SuperCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Places_PlaceCategoryId",
                table: "Places",
                newName: "IX_Places_SuperCategoryId");

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("00b6228d-e67d-440b-848f-5dc3170e583d"), null, "heritage", null },
                    { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), null, "tourism", null },
                    { new Guid("22c3085d-b5be-4db9-8785-f1ab15e928fd"), null, "commercial", null },
                    { new Guid("26c97874-03ed-4844-9f67-75ec60c79ebb"), null, "national park", null },
                    { new Guid("291fcc5a-3153-48aa-9e01-abda5f73bd0a"), null, "natural", null },
                    { new Guid("55f5ff99-63e7-4fcc-8528-af8ad7ba1590"), null, "activity", null },
                    { new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee"), null, "catering", null },
                    { new Guid("b41ee60a-507c-4354-9e88-8b50470a05bb"), null, "religion", null },
                    { new Guid("ef95161f-c9b7-4ea5-a08b-b01459be9036"), null, "entertainment", null },
                    { new Guid("f0d9c445-701d-42ae-836b-58da2240a9ed"), null, "leisure", null },
                    { new Guid("fe66bc9d-d8f6-4574-ae7c-2ba362ecbaf6"), null, "sport", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("0de25ef6-f22d-4b65-a972-840ee1a28f74"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("31716622-5c3b-44a4-9278-962a01a8de8b"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("46a9c2db-f085-4761-a97f-6f4c7e0d0eea"), null, "internet_access", null },
                    { new Guid("55ec329c-b1f2-4191-a726-ef905f28754f"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("56119b40-7708-40cc-a06b-477b005d66b5"), null, "wheelchair", null },
                    { new Guid("8d714d69-5dbd-4114-8bb1-6f75d27cb25e"), null, "no-dogs", null },
                    { new Guid("97d98de1-90d3-474e-90ba-22dd9f6401c4"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("ab592b49-ce76-4a9e-8263-e8e2f93f09c6"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("aedca339-7b16-421d-b78e-36c04b808518"), "Name property defined for the place", "named", null },
                    { new Guid("be2dc24c-960f-4b01-977e-37f80bba6908"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("dc14c310-400f-46da-9d7d-df9552e7daaf"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("deae5af1-d8e7-47c8-90fb-9037abfe3f89"), null, "dogs", null },
                    { new Guid("e08c68aa-27e0-4e94-b308-373fb30bedf8"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("e956e6bd-e674-4255-9195-6f848c43c5b3"), null, "access_limited", null },
                    { new Guid("ef829a87-549d-44c7-b795-37b61d68762d"), null, "fee", null },
                    { new Guid("f67648c8-ae88-46bf-abfe-3ee534bd5611"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("fdc15b6d-11c9-431e-b201-023451b34750"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("ffff8b7b-4c57-4805-a95f-c5c057b7bdc9"), null, "access", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862"), null, null, null, null, null, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("48bed669-b6a2-46ca-9458-4eaf33133df9"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null },
                    { new Guid("50d6aad9-c787-47d0-ae6e-dc26b54ec0e0"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("58c722d1-e949-46da-b96d-53ad1471a267"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("5f1514e5-26cd-4cef-b646-52023b748d2d"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" },
                    { new Guid("68fc918d-615e-411b-8f59-4b2533b1c53b"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("93daf3b8-9969-4ea3-a55e-4d9a35bb67d1"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("98d6d51c-b267-4f7d-a17b-1207b9fa8be1"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("cc50dff7-2544-4153-9690-73cccf962283"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null },
                    { new Guid("f2d5d61f-c8bc-483c-9bda-2a6de1180f29"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0fc6790e-8d0d-42b9-a7e2-ea6e3f831d6a"), null, "food_court", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") },
                    { new Guid("13c6d752-c68d-4282-ae8c-b319765628cf"), null, "mountain", new Guid("291fcc5a-3153-48aa-9e01-abda5f73bd0a") },
                    { new Guid("14fcbd7a-b19d-44ac-a672-ec2d1130c227"), null, "art", new Guid("22c3085d-b5be-4db9-8785-f1ab15e928fd") },
                    { new Guid("164d2f2d-7ccd-4907-b81b-8b53604fdf9a"), null, "park", new Guid("f0d9c445-701d-42ae-836b-58da2240a9ed") },
                    { new Guid("18692bae-11d3-4265-a23f-73ce189d49c3"), null, "museum", new Guid("ef95161f-c9b7-4ea5-a08b-b01459be9036") },
                    { new Guid("28018c6f-9d72-4047-81bc-3c09e64db6e2"), null, "stadium", new Guid("fe66bc9d-d8f6-4574-ae7c-2ba362ecbaf6") },
                    { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), null, "sights", new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2") },
                    { new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32"), null, "place_of_worship", new Guid("b41ee60a-507c-4354-9e88-8b50470a05bb") },
                    { new Guid("67e09c91-0d1a-42c9-afa2-20aa4328f754"), null, "zoo", new Guid("ef95161f-c9b7-4ea5-a08b-b01459be9036") },
                    { new Guid("6ab97aef-9312-405d-a9af-b0d097bdf601"), null, "water", new Guid("291fcc5a-3153-48aa-9e01-abda5f73bd0a") },
                    { new Guid("6cbe51c8-b6ec-4cb9-bab5-c0c2ace614cc"), null, "attraction", new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2") },
                    { new Guid("8ea5b5e0-a5d7-4a22-9f76-ab544800c5ce"), null, "biergarten", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") },
                    { new Guid("91588fa3-1311-4be1-a89c-8ab4e85e70e8"), null, "unesco", new Guid("00b6228d-e67d-440b-848f-5dc3170e583d") },
                    { new Guid("a5cadef9-e1b4-4b1b-9499-edaf12f73c36"), null, "taproom", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") },
                    { new Guid("b75212a6-a059-4553-8403-a89e34daa4a6"), null, "culture", new Guid("ef95161f-c9b7-4ea5-a08b-b01459be9036") },
                    { new Guid("b8838c2a-d183-4243-957b-da6ef2ff8b36"), null, "sand", new Guid("291fcc5a-3153-48aa-9e01-abda5f73bd0a") },
                    { new Guid("c1fc2dd6-f667-4100-b749-9d625ac0cc7c"), null, "ice_cream", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") },
                    { new Guid("cf92afc5-6290-4569-aaaa-040f7113ea4c"), null, "forest", new Guid("291fcc5a-3153-48aa-9e01-abda5f73bd0a") },
                    { new Guid("d8c9cdf7-c0bb-4b7f-9b23-1772f38b3761"), null, "planetarium", new Guid("ef95161f-c9b7-4ea5-a08b-b01459be9036") },
                    { new Guid("e17b4a65-a917-4b62-8097-390f4a34b27f"), null, "bar", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") },
                    { new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf"), null, "cafe", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") },
                    { new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906"), null, "fast_food", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") },
                    { new Guid("f8bd61fd-497f-41f7-9ca3-70147aa1e688"), null, "aquarium", new Guid("ef95161f-c9b7-4ea5-a08b-b01459be9036") },
                    { new Guid("f8c167b7-c600-48bd-a43f-975fda164f0a"), null, "pub", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") },
                    { new Guid("faa84185-2488-4912-a291-1bebc8e90afd"), null, "gift_and_souvenir", new Guid("22c3085d-b5be-4db9-8785-f1ab15e928fd") },
                    { new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60"), null, "restaurant", new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("199c807e-d118-4647-a34a-3adbe13cc3d0"), null, "only", new Guid("55ec329c-b1f2-4191-a726-ef905f28754f") },
                    { new Guid("3a0a1078-ed2b-4dde-9d04-94edb69e59e5"), null, "not_specified", new Guid("e08c68aa-27e0-4e94-b308-373fb30bedf8") },
                    { new Guid("3a18b709-78a0-4c95-9a2f-248be7eef6b9"), null, "only", new Guid("be2dc24c-960f-4b01-977e-37f80bba6908") },
                    { new Guid("412d7b20-4216-4973-b1f1-2b61bd6c77cc"), null, "yes", new Guid("56119b40-7708-40cc-a06b-477b005d66b5") },
                    { new Guid("46c1eee6-7dac-48f0-91d1-94964b8cd509"), null, "leashed", new Guid("deae5af1-d8e7-47c8-90fb-9037abfe3f89") },
                    { new Guid("46ffa52a-8451-4da3-8028-9c2dc037d093"), null, "limited", new Guid("56119b40-7708-40cc-a06b-477b005d66b5") },
                    { new Guid("48064116-c8c0-4920-90cf-f0c7598e7368"), null, "not_specified", new Guid("ffff8b7b-4c57-4805-a95f-c5c057b7bdc9") },
                    { new Guid("65748b72-1473-4eef-b578-74364ac007dc"), null, "only", new Guid("31716622-5c3b-44a4-9278-962a01a8de8b") },
                    { new Guid("7b302472-f9a9-4d2c-aac6-0d39fb56bb19"), "Places that are available for public", "yes", new Guid("ffff8b7b-4c57-4805-a95f-c5c057b7bdc9") },
                    { new Guid("8e08d9bd-0372-468c-8020-15731b7cd475"), null, "no", new Guid("e08c68aa-27e0-4e94-b308-373fb30bedf8") },
                    { new Guid("907f6738-1152-4372-aac2-520351afd07e"), null, "only", new Guid("fdc15b6d-11c9-431e-b201-023451b34750") },
                    { new Guid("9527ea95-ffa4-4c40-a527-62f873ecc2ba"), null, "for_customers", new Guid("46a9c2db-f085-4761-a97f-6f4c7e0d0eea") },
                    { new Guid("a31d30e9-b017-4042-852c-a4274ca8a3a0"), null, "free", new Guid("46a9c2db-f085-4761-a97f-6f4c7e0d0eea") },
                    { new Guid("e74ce553-36c8-4a6d-82ab-b5dc254608e0"), null, "customers", new Guid("e956e6bd-e674-4255-9195-6f848c43c5b3") },
                    { new Guid("eb8d40ec-8cca-46fe-8481-bcaed307e420"), null, "only", new Guid("ab592b49-ce76-4a9e-8263-e8e2f93f09c6") },
                    { new Guid("ef8af46b-dd21-4324-a48e-3654abe431a0"), null, "yes", new Guid("deae5af1-d8e7-47c8-90fb-9037abfe3f89") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862") },
                    { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("58c722d1-e949-46da-b96d-53ad1471a267") },
                    { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c") },
                    { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5") },
                    { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d") },
                    { new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee"), new Guid("98d6d51c-b267-4f7d-a17b-1207b9fa8be1") }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("25a4cf25-731b-4f94-af4c-d448ab989db1"), 100m, null, null, "PLN", new Guid("68fc918d-615e-411b-8f59-4b2533b1c53b"), new DateOnly(2024, 11, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 11, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("426e0553-799c-43fe-a668-7600ebb7c9d0"), 100m, null, null, "PLN", new Guid("68fc918d-615e-411b-8f59-4b2533b1c53b"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("00d9bdf6-b7b9-4a8a-8a08-6d81ae85af53"), null, "austrian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("00e193d2-14c9-407e-b575-2134ad99efe7"), null, "dumpling", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("0131122d-e874-4df9-9f72-af8fb472283e"), null, "spring", new Guid("6ab97aef-9312-405d-a9af-b0d097bdf601") },
                    { new Guid("0631cc0b-27bd-47a7-aeab-6de40601fa7d"), null, "cave_entrance", new Guid("13c6d752-c68d-4282-ae8c-b319765628cf") },
                    { new Guid("085ef255-93de-4482-bbe4-72147703110f"), null, "vietnamese", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("09642cdb-932d-4d9c-b047-b33eb287175b"), null, "cake", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("0b783048-a5f5-4db3-b28c-9db8fd6e6444"), null, "balkan", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("0dd45102-0316-4fce-aa15-20aa4206da77"), null, "multifaith", new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32") },
                    { new Guid("106b19c8-2da4-4bc6-812c-705d8d0eac55"), null, "arab", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("1249a529-7aa4-464e-bd6c-a19b6a057481"), null, "lebanese", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("133190f4-8ea9-4489-b548-4e3dc8f93464"), null, "pita", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("15fdc42c-ddaf-406b-84bb-54f674f9e60d"), null, "garden", new Guid("164d2f2d-7ccd-4907-b81b-8b53604fdf9a") },
                    { new Guid("17785aba-f0e6-4a96-932f-e972674ebacd"), null, "malay", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("17d839a7-75ed-48ae-82a9-55c6fa03fb6e"), null, "tex-mex", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("183dc2db-019e-4756-94f8-63f0184f6316"), null, "spanish", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("187fa5c6-5cac-462e-bf6c-2176495f2871"), null, "sikhism", new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32") },
                    { new Guid("191343d4-32be-47e1-8525-2c35d602a42c"), null, "fountain", new Guid("6cbe51c8-b6ec-4cb9-bab5-c0c2ace614cc") },
                    { new Guid("19f31f48-e0d9-49c7-bd31-8c661016f423"), null, "sandwich", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("1aca4cec-edfb-4bd5-9333-9aa2609d059c"), null, "barbecue", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("1db41cf7-4402-4d78-a4aa-b95aafece9a4"), null, "soup", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("1ef54f42-2317-4362-b65b-cdabc62086be"), null, "arts_centre", new Guid("b75212a6-a059-4553-8403-a89e34daa4a6") },
                    { new Guid("208f762b-32d7-4287-aed9-f18ecda5cf67"), null, "bavarian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("2133ad9b-58e3-4efd-8a8f-5481d5ed03f0"), null, "fort", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("23a5aa9f-8d6b-48a9-bae7-4677b6dcac6f"), null, "peruvian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("25452696-50e4-4659-8ca7-afbc0c4819ae"), null, "artwork", new Guid("6cbe51c8-b6ec-4cb9-bab5-c0c2ace614cc") },
                    { new Guid("2763ef8b-78ec-46c0-a59d-52bfc18aa0f7"), null, "taiwanese", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("28f1f349-e2fc-4095-8e7e-50a6fa522dc7"), null, "nepalese", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("297fbc19-8cd2-4544-8b30-1e0377111180"), null, "belgian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("2a4bd5e8-e02f-4d69-bab3-735706cdbb0d"), null, "viewpoint", new Guid("6cbe51c8-b6ec-4cb9-bab5-c0c2ace614cc") },
                    { new Guid("2c1be0f3-2e87-4588-a9bf-221cfc9e6011"), null, "chicken", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("2e717989-d7a2-4726-852b-37ba01195fcb"), null, "gallery", new Guid("b75212a6-a059-4553-8403-a89e34daa4a6") },
                    { new Guid("30ee26b3-1088-4deb-83de-295b78ba29ed"), null, "international", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("3176ebbf-4cf9-4aea-b672-560d59c8482a"), null, "hungarian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("32de783e-fbe2-4e84-a037-390a2915e9c3"), null, "soup", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("3334992c-a9ff-4170-ad64-38d26880974d"), null, "georgian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("3366fb59-5df4-4530-a8fc-8190da2673b0"), null, "african", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("341ad91f-0ec9-4897-b19b-8985b41fe96f"), null, "western", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("3438d907-8f3f-48a4-b319-3d415d8a200e"), null, "pizza", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("34553340-3b25-4fd8-bdbb-114d8f822df6"), null, "bridge", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("3565da33-b56c-4264-843b-568e6436b4d8"), null, "ice_cream", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("37426ebe-4f3f-4d02-940e-8a88500453f7"), null, "glacier", new Guid("13c6d752-c68d-4282-ae8c-b319765628cf") },
                    { new Guid("37592fa1-615f-4704-b83d-cfda2770b86b"), null, "tapas", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("39129d2f-07ae-419c-8974-b7c2a42a7ab0"), null, "reef", new Guid("6ab97aef-9312-405d-a9af-b0d097bdf601") },
                    { new Guid("3933aa5b-3854-47c8-a9e5-88c4bc4dd4b9"), null, "latin_american", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("393daf5e-b6c0-4739-bc31-306ecc254042"), null, "italian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("3ab339fc-e605-4632-9841-d0dd7e551b5c"), null, "jamaican", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("3d7daae2-88c1-43da-9353-af0ad6321efd"), null, "crepe", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("3dd87d67-55d4-42ab-9048-30a3d255d221"), null, "indonesian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("3e638393-c7db-4d9c-a054-46cebbe91815"), null, "friture", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("3f45d199-0d2d-4467-881f-4ad4bb2c08c0"), null, "turkish", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("3fdf1331-2b52-46b7-b3d2-611c1b1ed9dc"), null, "lighthouse", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("42b3196e-adb2-4ec5-ba4d-23829bb1dd87"), null, "hinduism", new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32") },
                    { new Guid("432918c6-9d56-44de-98fb-b330444b9c74"), null, "donut", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("43450095-6bc2-4de0-bf13-2a2cd744dc18"), null, "city_gate", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("43bf63d3-df23-4571-8ce3-35de53333f36"), null, "ruines", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("4413face-c6ae-404b-940b-fccb8a1b6915"), null, "hot_dog", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("46bb7125-e5ca-4980-9da5-df7245e207f7"), null, "regional", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("4891ae67-46d6-426c-8e2f-14eb6af84bb3"), null, "sandwich", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("4c087b0e-75a3-40dd-bd7f-e58fb7216257"), null, "portuguese", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("4cb758f1-3042-4925-95fd-c8637d664279"), null, "pita", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("4fc8ab65-5138-4f8f-9bba-291ee9a6f550"), null, "persian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("514a5546-1e42-4a6f-a491-a87c6cd41843"), null, "american", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("535189c3-26b2-4290-90ab-b935d2c84290"), null, "ramen", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("539c2992-3d6a-4a08-9478-63fbe1ba8a69"), null, "geyser", new Guid("6ab97aef-9312-405d-a9af-b0d097bdf601") },
                    { new Guid("55f0a6b0-a135-48a3-8412-25c94ed9a14a"), null, "czech", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("5988c0ca-defe-47d9-8433-f132ee59d790"), null, "peak", new Guid("13c6d752-c68d-4282-ae8c-b319765628cf") },
                    { new Guid("5dfb0922-2455-482b-b217-fd262a079c3e"), null, "fish_and_chips", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("5e0403dc-e674-4889-b1df-42c9e00a9d6e"), null, "burger", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("5e0cb6e3-84ad-46ba-ac59-b67bd08b0308"), null, "uzbek", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("6293ccb0-1af5-4e30-b60c-45eb360ed9f9"), null, "bolivian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("64328d8d-8024-4724-bc13-257acf2cd000"), null, "ramen", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("6461ccde-fd2c-46f5-9d53-1f95cb2db490"), null, "burger", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("6734ad56-ac96-49f8-a090-ae7a1c8469d4"), null, "judaism", new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32") },
                    { new Guid("6854b66c-62fb-44a6-b68e-1190a38ebcc9"), null, "cliff", new Guid("13c6d752-c68d-4282-ae8c-b319765628cf") },
                    { new Guid("6b886de8-8de4-44f1-8186-20601b2b59b0"), null, "fish", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("6b988a93-d7d6-47aa-87ee-1dd3c4b8dfb3"), null, "clock", new Guid("6cbe51c8-b6ec-4cb9-bab5-c0c2ace614cc") },
                    { new Guid("7117fdac-5f40-44c7-84da-4d06e9c13eff"), null, "oriental", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("71e4aa08-3734-4b14-9865-b7a12d2005ad"), null, "mediterranean", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("75c488b3-2c29-42b3-a460-4f33e71d0f15"), null, "islam", new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32") },
                    { new Guid("7830decf-3752-45aa-b042-c994136a2f84"), null, "danish", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("7990c59b-4c66-40dc-b38d-615216c40110"), null, "tea", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("7ac763c7-e853-4122-a643-f5377cb4987c"), null, "korean", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("7ad8f8d7-c5ea-4e03-be9a-e129f3c896e8"), null, "wings", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("7af8a4c0-af3d-499a-bdef-fffa1a1c7576"), null, "croatian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("7b5fcba5-cde6-4555-ad78-e4e2ef3cdc64"), null, "ethiopian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("7b8f3ca4-d179-459b-8204-8fd8a0e3b1e3"), null, "curry", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("7bd633c4-51b9-49bc-828e-311f3eb9bf8e"), null, "chili", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("7c721bbf-202a-4b6a-8ba0-c2738cef8d66"), null, "dessert", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("7ec4c708-ca51-4609-88c3-81257c063b1a"), null, "noodle", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("80d4349c-e81c-4919-a19c-7bb856414518"), null, "hawaiian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("83041add-8fd1-4158-bf11-f37df3cca394"), null, "indian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("8313fd49-57eb-407f-9ac0-a9459e4384f1"), null, "seafood", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("83360ad5-b8b0-4d0b-b676-0d40e2904ef5"), null, "russian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("83bbc5f3-397e-45d8-99ac-10bb11f26fb5"), null, "fish_and_chips", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("84aa321a-5235-440b-97fe-77f848a9c9c6"), null, "swedish", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("8a72f4ae-fbfa-4612-a7ae-87f67381c654"), null, "battlefield", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("8c002a3e-4646-4640-9eac-f6efa2448d06"), null, "waffle", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("8e533cdb-02ca-47e5-a4c4-9323b6e98b18"), null, "monastery", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("8edcef82-ee28-43f2-854d-c73659750802"), null, "nature_reserve", new Guid("164d2f2d-7ccd-4907-b81b-8b53604fdf9a") },
                    { new Guid("8fddb782-2e5e-4cc3-a2e0-4d1259962f08"), null, "coffee_shop", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("8ff5aa09-f0e9-42e8-9572-2bb313c513a3"), null, "afghan", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("94ea4a66-5007-4f7d-b2b8-b173fd4f8bc2"), null, "noodle", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("98f66dd8-4ff1-4d72-987d-1500ff66829b"), null, "steak_house", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("9916e690-1cad-4afa-8cd3-a610f63e4033"), null, "french", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("9b995067-cdae-4e90-ba9d-c830def7887d"), null, "ukrainian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("9ddc8f93-ec7f-4101-a496-e65f26a5060e"), null, "castle", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("9e9dc8b7-0d52-465d-920f-33f80f04106a"), null, "cuban", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("a249ffc6-1545-415f-a1ec-34b57d715e1e"), null, "moroccan", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("a2546407-3f21-499c-924a-94c3d1344150"), null, "brazilian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("a298ebbd-e85a-42cb-b7b8-527a73b3a8e4"), null, "shinto", new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32") },
                    { new Guid("a49dc8f7-514b-4dbd-a615-ad4690c7b452"), null, "pizza", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("a4ac6643-9021-4321-a308-f283695233df"), null, "windmill", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("a7079493-c5c3-4ddb-be08-e7f188a7e91f"), null, "tower", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("aa627818-2cd6-49bf-aeeb-256d70278b1c"), null, "salad", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("b0a69a36-dbc9-40bf-8607-f107f8166b23"), null, "tacos", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("b3de7d04-9587-4995-b8bd-182a968d7625"), null, "greek", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("b52a28af-bb3a-47b7-a325-d2be186ad544"), null, "archaeological_site", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("b6b9644a-68be-477a-ab57-cd5d1a7f9b4b"), null, "dune", new Guid("b8838c2a-d183-4243-957b-da6ef2ff8b36") },
                    { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), null, "memorial", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("bc87ad51-9ff1-46ff-b128-4e710fd237e6"), null, "frozen_yogurt", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("bda4b672-6f4d-4a17-b30e-a145e054a3c8"), null, "tapas", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("c0de38c5-1ee9-4d78-89cf-026540474c20"), null, "tacos", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("c35a34d7-fdb5-4a29-9db2-513d714e6f57"), null, "chinese", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("c3ea27ca-0222-4837-8eb5-972d5c11d515"), null, "sushi", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("c858d628-2d96-4e52-8bc5-552949a32487"), null, "mexican", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("c87650af-8992-4709-adff-b110f157f5f9"), null, "place_of_worship", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("ca84f8de-36e8-4335-b03e-eb98a52396f2"), null, "malaysian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("cd91d1cd-f677-4bae-89c0-fbeebe474497"), null, "thai", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("cec38027-25b5-4544-a8fe-705443f8626c"), null, "coffee", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("cfa8ae18-b998-4c7c-9c1f-81cb4fc794d7"), null, "filipino", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("d22e801f-fe44-425e-a43b-e2cadeec1e85"), null, "christianity", new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32") },
                    { new Guid("d686bf0b-b93d-4c08-b1ed-a9a4cb391633"), null, "rock", new Guid("13c6d752-c68d-4282-ae8c-b319765628cf") },
                    { new Guid("d757309f-1fc6-4bef-9683-a13f030708f0"), null, "syrian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("d7e21842-a7a7-4e16-b0cf-04090476807e"), null, "european", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("da2bf7dc-7d81-4419-bb08-811502efcfc6"), null, "asian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("dabae47e-d940-474d-ab0e-658ec0102a2a"), null, "wings", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("ddc2de75-6ff6-4666-8fbf-8d4aca61d233"), null, "pakistani", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("de4b2c55-a133-4cc4-9b14-ee7119b1d6bb"), null, "beef_bowl", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("dfa87bf7-2200-453d-9932-c41dd0bc5c28"), null, "city_hall", new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c") },
                    { new Guid("e4ce66e1-ad65-4791-9d23-d2c20b8086fc"), null, "irish", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("e61975ad-4773-499c-b9a5-76101538160c"), null, "german", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("ea4cf50f-79e7-4f64-a2cb-f289396fdd23"), null, "bubble_tea", new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf") },
                    { new Guid("eee9c0b4-0552-4644-8501-9ce7d2f272ac"), null, "argentinian", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("ef3ca710-cded-4678-8b34-01a9787dc78e"), null, "kebab", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("f0748fbc-0bc2-41c4-acdf-2c292b325745"), null, "hot_spring", new Guid("6ab97aef-9312-405d-a9af-b0d097bdf601") },
                    { new Guid("f0b1e3f2-25b2-451d-8124-2def540ea8a0"), null, "caribbean", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("f407e425-2be8-4f56-9564-1eb63ac79b00"), null, "theatre", new Guid("b75212a6-a059-4553-8403-a89e34daa4a6") },
                    { new Guid("f941eabf-a023-485e-9733-36c4dd4e27ce"), null, "japanese", new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60") },
                    { new Guid("f98b4f22-6b4f-449a-8fdb-73da0eaebb72"), null, "kebab", new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906") },
                    { new Guid("fa0e873b-26d3-4d80-beec-51d9818e40a8"), null, "buddhism", new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32") },
                    { new Guid("fe345ac9-059f-43fc-afac-29b90910f5c8"), null, "sea", new Guid("6ab97aef-9312-405d-a9af-b0d097bdf601") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862") },
                    { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("58c722d1-e949-46da-b96d-53ad1471a267") },
                    { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c") },
                    { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5") },
                    { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d") },
                    { new Guid("6cbe51c8-b6ec-4cb9-bab5-c0c2ace614cc"), new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862") },
                    { new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60"), new Guid("98d6d51c-b267-4f7d-a17b-1207b9fa8be1") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef"), new DateOnly(2024, 12, 21), new Guid("426e0553-799c-43fe-a668-7600ebb7c9d0") },
                    { new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573"), new DateOnly(2024, 11, 20), new Guid("25a4cf25-731b-4f94-af4c-d448ab989db1") },
                    { new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34"), new DateOnly(2024, 11, 21), new Guid("25a4cf25-731b-4f94-af4c-d448ab989db1") },
                    { new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b"), new DateOnly(2024, 12, 20), new Guid("426e0553-799c-43fe-a668-7600ebb7c9d0") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0bf1ad5b-b853-4eda-beb4-a07a12435eb7"), null, "monument", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("10669821-1181-480b-b627-a3453114791f"), null, "temple", new Guid("c87650af-8992-4709-adff-b110f157f5f9") },
                    { new Guid("147fac0e-8859-40bb-babe-dde21f4d03f9"), null, "tank", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("3fa784db-0273-4fad-b275-df81fdeb74d6"), null, "wayside_cross", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("444a5912-9820-4b67-a578-038de7a8bcaa"), null, "mosque", new Guid("c87650af-8992-4709-adff-b110f157f5f9") },
                    { new Guid("5a2ebebd-06ec-4174-93c6-d753558eac39"), null, "locomotive", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("5c6564cf-0b80-45c9-b796-42e38c193cdd"), null, "synagogue", new Guid("c87650af-8992-4709-adff-b110f157f5f9") },
                    { new Guid("5fe4a937-73cc-4e9f-996a-04a22a0c0ad8"), null, "boundary_stone", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("8ddf1b53-3f15-4f99-9a14-c47407923e4e"), null, "chapel", new Guid("c87650af-8992-4709-adff-b110f157f5f9") },
                    { new Guid("a0897c84-1bce-4f0c-a43c-d646179d5831"), null, "railway_car", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("a377d24d-1c2a-4f9a-a6d0-7264baea1cb0"), null, "pillory", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("bc629495-680b-4450-abb5-03d78811deb1"), null, "cathedral", new Guid("c87650af-8992-4709-adff-b110f157f5f9") },
                    { new Guid("d959f4a0-4242-43f8-ab7c-e7cc4da087d4"), null, "church", new Guid("c87650af-8992-4709-adff-b110f157f5f9") },
                    { new Guid("e6c01e49-fdea-4408-88cd-324cfb70f356"), null, "tomb", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("e94b2ad4-5f91-440c-9788-2d3ee6c17f39"), null, "aircraft", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("eb4255cf-5ead-4eb5-b4e7-4995bbfedb79"), null, "ship", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") },
                    { new Guid("eceda60a-e4e3-4220-b3ce-9a44ce7667fb"), null, "shrine", new Guid("c87650af-8992-4709-adff-b110f157f5f9") },
                    { new Guid("fa165082-5df1-4a5c-9cfd-7c712bda4d7c"), null, "milestone", new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("43bf63d3-df23-4571-8ce3-35de53333f36"), new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862") },
                    { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), new Guid("58c722d1-e949-46da-b96d-53ad1471a267") },
                    { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c") },
                    { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5") },
                    { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("03367549-27e6-48b3-b69d-d5f81ca70617"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("f2d5d61f-c8bc-483c-9bda-2a6de1180f29"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b") },
                    { new Guid("1d75b012-508c-47fa-aa2f-c35c248a61ae"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("98d6d51c-b267-4f7d-a17b-1207b9fa8be1"), 30m, new TimeOnly(14, 0, 0), 1, new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34") },
                    { new Guid("23db1f83-c4b5-4b73-bc68-85f3f0cbc91a"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5"), 0m, new TimeOnly(13, 0, 0), 1, new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34") },
                    { new Guid("2a1b7c8c-b5cf-4b77-b19e-a9bf59be9ba4"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("98d6d51c-b267-4f7d-a17b-1207b9fa8be1"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef") },
                    { new Guid("3e76039d-5779-4998-859d-f8395ab987fd"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("58c722d1-e949-46da-b96d-53ad1471a267"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef") },
                    { new Guid("428fae3d-0b4f-4f72-85f2-fa84b6bd279c"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef") },
                    { new Guid("593c297f-002e-4942-be3a-c2f9c415b67f"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b") },
                    { new Guid("59a9002c-0bce-4a16-8124-4d7385094c14"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("5f1514e5-26cd-4cef-b646-52023b748d2d"), 0m, new TimeOnly(16, 30, 0), 1, new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34") },
                    { new Guid("5b812b87-946c-4e1a-8335-32f1609dcce3"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b") },
                    { new Guid("61e07c30-5814-4dfe-abc5-40fa78fc6f75"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("48bed669-b6a2-46ca-9458-4eaf33133df9"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef") },
                    { new Guid("7dc2bf83-8545-4f81-b618-9d91a9d33350"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("93daf3b8-9969-4ea3-a55e-4d9a35bb67d1"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573") },
                    { new Guid("897fea91-b4af-4b9a-af2a-0b22f376c00d"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("50d6aad9-c787-47d0-ae6e-dc26b54ec0e0"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b") },
                    { new Guid("971c9677-9c6b-4b72-b924-ffdd1f872571"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b") },
                    { new Guid("9b8dc0c3-2ac1-47f9-b493-f709cef20fd9"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("cc50dff7-2544-4153-9690-73cccf962283"), 0m, new TimeOnly(13, 30, 0), 4, new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573") },
                    { new Guid("c1d3bc85-1b60-454d-a93f-d3b257059d45"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("58c722d1-e949-46da-b96d-53ad1471a267"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34") },
                    { new Guid("ccad8497-73a8-4acc-82f6-e6f92edb8d77"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862"), 0m, new TimeOnly(10, 0, 0), 1, new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573") },
                    { new Guid("ecc4ffe6-924c-4cea-ac02-1a12dcc95689"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c"), 0m, new TimeOnly(11, 50, 0), 1, new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573") },
                    { new Guid("f00f6c09-c0ff-43e8-99a5-850feeb40255"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d"), 0m, new TimeOnly(11, 0, 0), 1, new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573") }
                });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "ToTripPointId", "TransferTime", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("0efbe14d-3f2f-44db-9b48-69048988f1c6"), new Guid("593c297f-002e-4942-be3a-c2f9c415b67f"), 0, new Guid("971c9677-9c6b-4b72-b924-ffdd1f872571"), new TimeSpan(0, 0, 4, 21, 0), new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b") },
                    { new Guid("0f2eeb1b-9968-417d-8174-0e3a305efb9a"), new Guid("428fae3d-0b4f-4f72-85f2-fa84b6bd279c"), 3, new Guid("2a1b7c8c-b5cf-4b77-b19e-a9bf59be9ba4"), new TimeSpan(0, 0, 8, 18, 0), new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef") },
                    { new Guid("5a789fc8-67e8-4912-bf43-cbd1dc840c8c"), new Guid("ecc4ffe6-924c-4cea-ac02-1a12dcc95689"), 1, new Guid("7dc2bf83-8545-4f81-b618-9d91a9d33350"), new TimeSpan(0, 0, 0, 55, 0), new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573") },
                    { new Guid("65850a86-f448-481d-aaf9-15d7e6510df3"), new Guid("7dc2bf83-8545-4f81-b618-9d91a9d33350"), null, new Guid("9b8dc0c3-2ac1-47f9-b493-f709cef20fd9"), new TimeSpan(0, 0, 20, 0, 0), new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573") },
                    { new Guid("6ad5d965-d31b-4873-8ea2-52f3e5c0f481"), new Guid("23db1f83-c4b5-4b73-bc68-85f3f0cbc91a"), 3, new Guid("1d75b012-508c-47fa-aa2f-c35c248a61ae"), new TimeSpan(0, 0, 8, 18, 0), new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34") },
                    { new Guid("6c5a1d87-17b9-4384-ac91-74d607cd80b2"), new Guid("971c9677-9c6b-4b72-b924-ffdd1f872571"), 1, new Guid("03367549-27e6-48b3-b69d-d5f81ca70617"), new TimeSpan(0, 0, 0, 55, 0), new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b") },
                    { new Guid("6d8defed-fc99-442e-8e72-f16e128ea916"), new Guid("c1d3bc85-1b60-454d-a93f-d3b257059d45"), 2, new Guid("23db1f83-c4b5-4b73-bc68-85f3f0cbc91a"), new TimeSpan(0, 0, 3, 13, 0), new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34") },
                    { new Guid("714604d1-f059-41ad-a31b-ec809da4e63d"), new Guid("03367549-27e6-48b3-b69d-d5f81ca70617"), null, new Guid("897fea91-b4af-4b9a-af2a-0b22f376c00d"), new TimeSpan(0, 0, 20, 0, 0), new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b") },
                    { new Guid("7da94f86-6900-4a66-b5bc-17c07d475698"), new Guid("2a1b7c8c-b5cf-4b77-b19e-a9bf59be9ba4"), 3, new Guid("61e07c30-5814-4dfe-abc5-40fa78fc6f75"), new TimeSpan(0, 0, 13, 30, 0), new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef") },
                    { new Guid("90810e3c-8530-49c5-ae77-0897f1c4e589"), new Guid("f00f6c09-c0ff-43e8-99a5-850feeb40255"), 0, new Guid("ecc4ffe6-924c-4cea-ac02-1a12dcc95689"), new TimeSpan(0, 0, 4, 21, 0), new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573") },
                    { new Guid("a5ebe2e6-71b3-446c-9359-b3939e153223"), new Guid("3e76039d-5779-4998-859d-f8395ab987fd"), 2, new Guid("428fae3d-0b4f-4f72-85f2-fa84b6bd279c"), new TimeSpan(0, 0, 3, 13, 0), new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef") },
                    { new Guid("bc67147f-b878-44bb-b3cc-c781ef0cf442"), new Guid("1d75b012-508c-47fa-aa2f-c35c248a61ae"), 3, new Guid("59a9002c-0bce-4a16-8124-4d7385094c14"), new TimeSpan(0, 0, 13, 30, 0), new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Places_PlaceCategories_SuperCategoryId",
                table: "Places",
                column: "SuperCategoryId",
                principalTable: "PlaceCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_PlaceCategories_SuperCategoryId",
                table: "Places");

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("00d9bdf6-b7b9-4a8a-8a08-6d81ae85af53"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("00e193d2-14c9-407e-b575-2134ad99efe7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0131122d-e874-4df9-9f72-af8fb472283e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0631cc0b-27bd-47a7-aeab-6de40601fa7d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("085ef255-93de-4482-bbe4-72147703110f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("09642cdb-932d-4d9c-b047-b33eb287175b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b783048-a5f5-4db3-b28c-9db8fd6e6444"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0bf1ad5b-b853-4eda-beb4-a07a12435eb7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0dd45102-0316-4fce-aa15-20aa4206da77"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0fc6790e-8d0d-42b9-a7e2-ea6e3f831d6a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("10669821-1181-480b-b627-a3453114791f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("106b19c8-2da4-4bc6-812c-705d8d0eac55"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1249a529-7aa4-464e-bd6c-a19b6a057481"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("133190f4-8ea9-4489-b548-4e3dc8f93464"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("147fac0e-8859-40bb-babe-dde21f4d03f9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("14fcbd7a-b19d-44ac-a672-ec2d1130c227"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("15fdc42c-ddaf-406b-84bb-54f674f9e60d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17785aba-f0e6-4a96-932f-e972674ebacd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17d839a7-75ed-48ae-82a9-55c6fa03fb6e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("183dc2db-019e-4756-94f8-63f0184f6316"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18692bae-11d3-4265-a23f-73ce189d49c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("187fa5c6-5cac-462e-bf6c-2176495f2871"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("191343d4-32be-47e1-8525-2c35d602a42c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("19f31f48-e0d9-49c7-bd31-8c661016f423"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1aca4cec-edfb-4bd5-9333-9aa2609d059c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1db41cf7-4402-4d78-a4aa-b95aafece9a4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1ef54f42-2317-4362-b65b-cdabc62086be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("208f762b-32d7-4287-aed9-f18ecda5cf67"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2133ad9b-58e3-4efd-8a8f-5481d5ed03f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23a5aa9f-8d6b-48a9-bae7-4677b6dcac6f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("25452696-50e4-4659-8ca7-afbc0c4819ae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("26c97874-03ed-4844-9f67-75ec60c79ebb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2763ef8b-78ec-46c0-a59d-52bfc18aa0f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28018c6f-9d72-4047-81bc-3c09e64db6e2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28f1f349-e2fc-4095-8e7e-50a6fa522dc7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("297fbc19-8cd2-4544-8b30-1e0377111180"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a4bd5e8-e02f-4d69-bab3-735706cdbb0d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c1be0f3-2e87-4588-a9bf-221cfc9e6011"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e717989-d7a2-4726-852b-37ba01195fcb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("30ee26b3-1088-4deb-83de-295b78ba29ed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3176ebbf-4cf9-4aea-b672-560d59c8482a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("32de783e-fbe2-4e84-a037-390a2915e9c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3334992c-a9ff-4170-ad64-38d26880974d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3366fb59-5df4-4530-a8fc-8190da2673b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("341ad91f-0ec9-4897-b19b-8985b41fe96f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3438d907-8f3f-48a4-b319-3d415d8a200e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("34553340-3b25-4fd8-bdbb-114d8f822df6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3565da33-b56c-4264-843b-568e6436b4d8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37426ebe-4f3f-4d02-940e-8a88500453f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37592fa1-615f-4704-b83d-cfda2770b86b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("39129d2f-07ae-419c-8974-b7c2a42a7ab0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3933aa5b-3854-47c8-a9e5-88c4bc4dd4b9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("393daf5e-b6c0-4739-bc31-306ecc254042"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ab339fc-e605-4632-9841-d0dd7e551b5c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d7daae2-88c1-43da-9353-af0ad6321efd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3dd87d67-55d4-42ab-9048-30a3d255d221"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e638393-c7db-4d9c-a054-46cebbe91815"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f45d199-0d2d-4467-881f-4ad4bb2c08c0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fa784db-0273-4fad-b275-df81fdeb74d6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fdf1331-2b52-46b7-b3d2-611c1b1ed9dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("42b3196e-adb2-4ec5-ba4d-23829bb1dd87"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("432918c6-9d56-44de-98fb-b330444b9c74"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("43450095-6bc2-4de0-bf13-2a2cd744dc18"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4413face-c6ae-404b-940b-fccb8a1b6915"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("444a5912-9820-4b67-a578-038de7a8bcaa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("46bb7125-e5ca-4980-9da5-df7245e207f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4891ae67-46d6-426c-8e2f-14eb6af84bb3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c087b0e-75a3-40dd-bd7f-e58fb7216257"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cb758f1-3042-4925-95fd-c8637d664279"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4fc8ab65-5138-4f8f-9bba-291ee9a6f550"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("514a5546-1e42-4a6f-a491-a87c6cd41843"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("535189c3-26b2-4290-90ab-b935d2c84290"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("539c2992-3d6a-4a08-9478-63fbe1ba8a69"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("55f0a6b0-a135-48a3-8412-25c94ed9a14a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("55f5ff99-63e7-4fcc-8528-af8ad7ba1590"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5988c0ca-defe-47d9-8433-f132ee59d790"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a2ebebd-06ec-4174-93c6-d753558eac39"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c6564cf-0b80-45c9-b796-42e38c193cdd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5dfb0922-2455-482b-b217-fd262a079c3e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e0403dc-e674-4889-b1df-42c9e00a9d6e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e0cb6e3-84ad-46ba-ac59-b67bd08b0308"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5fe4a937-73cc-4e9f-996a-04a22a0c0ad8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6293ccb0-1af5-4e30-b60c-45eb360ed9f9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("64328d8d-8024-4724-bc13-257acf2cd000"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6461ccde-fd2c-46f5-9d53-1f95cb2db490"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6734ad56-ac96-49f8-a090-ae7a1c8469d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("67e09c91-0d1a-42c9-afa2-20aa4328f754"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6854b66c-62fb-44a6-b68e-1190a38ebcc9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b886de8-8de4-44f1-8186-20601b2b59b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b988a93-d7d6-47aa-87ee-1dd3c4b8dfb3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7117fdac-5f40-44c7-84da-4d06e9c13eff"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("71e4aa08-3734-4b14-9865-b7a12d2005ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("75c488b3-2c29-42b3-a460-4f33e71d0f15"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7830decf-3752-45aa-b042-c994136a2f84"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7990c59b-4c66-40dc-b38d-615216c40110"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ac763c7-e853-4122-a643-f5377cb4987c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ad8f8d7-c5ea-4e03-be9a-e129f3c896e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7af8a4c0-af3d-499a-bdef-fffa1a1c7576"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b5fcba5-cde6-4555-ad78-e4e2ef3cdc64"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b8f3ca4-d179-459b-8204-8fd8a0e3b1e3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bd633c4-51b9-49bc-828e-311f3eb9bf8e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c721bbf-202a-4b6a-8ba0-c2738cef8d66"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ec4c708-ca51-4609-88c3-81257c063b1a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("80d4349c-e81c-4919-a19c-7bb856414518"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83041add-8fd1-4158-bf11-f37df3cca394"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8313fd49-57eb-407f-9ac0-a9459e4384f1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83360ad5-b8b0-4d0b-b676-0d40e2904ef5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83bbc5f3-397e-45d8-99ac-10bb11f26fb5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("84aa321a-5235-440b-97fe-77f848a9c9c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8a72f4ae-fbfa-4612-a7ae-87f67381c654"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c002a3e-4646-4640-9eac-f6efa2448d06"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ddf1b53-3f15-4f99-9a14-c47407923e4e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e533cdb-02ca-47e5-a4c4-9323b6e98b18"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ea5b5e0-a5d7-4a22-9f76-ab544800c5ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8edcef82-ee28-43f2-854d-c73659750802"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8fddb782-2e5e-4cc3-a2e0-4d1259962f08"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ff5aa09-f0e9-42e8-9572-2bb313c513a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("91588fa3-1311-4be1-a89c-8ab4e85e70e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("94ea4a66-5007-4f7d-b2b8-b173fd4f8bc2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("98f66dd8-4ff1-4d72-987d-1500ff66829b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9916e690-1cad-4afa-8cd3-a610f63e4033"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b995067-cdae-4e90-ba9d-c830def7887d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ddc8f93-ec7f-4101-a496-e65f26a5060e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e9dc8b7-0d52-465d-920f-33f80f04106a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0897c84-1bce-4f0c-a43c-d646179d5831"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a249ffc6-1545-415f-a1ec-34b57d715e1e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2546407-3f21-499c-924a-94c3d1344150"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a298ebbd-e85a-42cb-b7b8-527a73b3a8e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a377d24d-1c2a-4f9a-a6d0-7264baea1cb0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a49dc8f7-514b-4dbd-a615-ad4690c7b452"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a4ac6643-9021-4321-a308-f283695233df"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a5cadef9-e1b4-4b1b-9499-edaf12f73c36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7079493-c5c3-4ddb-be08-e7f188a7e91f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa627818-2cd6-49bf-aeeb-256d70278b1c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0a69a36-dbc9-40bf-8607-f107f8166b23"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3de7d04-9587-4995-b8bd-182a968d7625"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b52a28af-bb3a-47b7-a325-d2be186ad544"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6b9644a-68be-477a-ab57-cd5d1a7f9b4b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc629495-680b-4450-abb5-03d78811deb1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc87ad51-9ff1-46ff-b128-4e710fd237e6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bda4b672-6f4d-4a17-b30e-a145e054a3c8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0de38c5-1ee9-4d78-89cf-026540474c20"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c1fc2dd6-f667-4100-b749-9d625ac0cc7c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c35a34d7-fdb5-4a29-9db2-513d714e6f57"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3ea27ca-0222-4837-8eb5-972d5c11d515"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c858d628-2d96-4e52-8bc5-552949a32487"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca84f8de-36e8-4335-b03e-eb98a52396f2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd91d1cd-f677-4bae-89c0-fbeebe474497"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cec38027-25b5-4544-a8fe-705443f8626c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf92afc5-6290-4569-aaaa-040f7113ea4c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cfa8ae18-b998-4c7c-9c1f-81cb4fc794d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d22e801f-fe44-425e-a43b-e2cadeec1e85"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d686bf0b-b93d-4c08-b1ed-a9a4cb391633"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d757309f-1fc6-4bef-9683-a13f030708f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7e21842-a7a7-4e16-b0cf-04090476807e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8c9cdf7-c0bb-4b7f-9b23-1772f38b3761"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d959f4a0-4242-43f8-ab7c-e7cc4da087d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("da2bf7dc-7d81-4419-bb08-811502efcfc6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dabae47e-d940-474d-ab0e-658ec0102a2a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ddc2de75-6ff6-4666-8fbf-8d4aca61d233"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("de4b2c55-a133-4cc4-9b14-ee7119b1d6bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dfa87bf7-2200-453d-9932-c41dd0bc5c28"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e17b4a65-a917-4b62-8097-390f4a34b27f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4ce66e1-ad65-4791-9d23-d2c20b8086fc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e61975ad-4773-499c-b9a5-76101538160c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6c01e49-fdea-4408-88cd-324cfb70f356"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e94b2ad4-5f91-440c-9788-2d3ee6c17f39"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea4cf50f-79e7-4f64-a2cb-f289396fdd23"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb4255cf-5ead-4eb5-b4e7-4995bbfedb79"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eceda60a-e4e3-4220-b3ce-9a44ce7667fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eee9c0b4-0552-4644-8501-9ce7d2f272ac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef3ca710-cded-4678-8b34-01a9787dc78e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0748fbc-0bc2-41c4-acdf-2c292b325745"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0b1e3f2-25b2-451d-8124-2def540ea8a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f407e425-2be8-4f56-9564-1eb63ac79b00"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8bd61fd-497f-41f7-9ca3-70147aa1e688"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8c167b7-c600-48bd-a43f-975fda164f0a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f941eabf-a023-485e-9733-36c4dd4e27ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f98b4f22-6b4f-449a-8fdb-73da0eaebb72"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa0e873b-26d3-4d80-beec-51d9818e40a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa165082-5df1-4a5c-9cfd-7c712bda4d7c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("faa84185-2488-4912-a291-1bebc8e90afd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe345ac9-059f-43fc-afac-29b90910f5c8"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("0de25ef6-f22d-4b65-a972-840ee1a28f74"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("199c807e-d118-4647-a34a-3adbe13cc3d0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3a0a1078-ed2b-4dde-9d04-94edb69e59e5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3a18b709-78a0-4c95-9a2f-248be7eef6b9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("412d7b20-4216-4973-b1f1-2b61bd6c77cc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("46c1eee6-7dac-48f0-91d1-94964b8cd509"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("46ffa52a-8451-4da3-8028-9c2dc037d093"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("48064116-c8c0-4920-90cf-f0c7598e7368"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("65748b72-1473-4eef-b578-74364ac007dc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7b302472-f9a9-4d2c-aac6-0d39fb56bb19"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8d714d69-5dbd-4114-8bb1-6f75d27cb25e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8e08d9bd-0372-468c-8020-15731b7cd475"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("907f6738-1152-4372-aac2-520351afd07e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9527ea95-ffa4-4c40-a527-62f873ecc2ba"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("97d98de1-90d3-474e-90ba-22dd9f6401c4"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a31d30e9-b017-4042-852c-a4274ca8a3a0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("aedca339-7b16-421d-b78e-36c04b808518"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dc14c310-400f-46da-9d7d-df9552e7daaf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e74ce553-36c8-4a6d-82ab-b5dc254608e0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("eb8d40ec-8cca-46fe-8481-bcaed307e420"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ef829a87-549d-44c7-b795-37b61d68762d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ef8af46b-dd21-4324-a48e-3654abe431a0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f67648c8-ae88-46bf-abfe-3ee534bd5611"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("58c722d1-e949-46da-b96d-53ad1471a267") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"), new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("43bf63d3-df23-4571-8ce3-35de53333f36"), new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("58c722d1-e949-46da-b96d-53ad1471a267") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"), new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6cbe51c8-b6ec-4cb9-bab5-c0c2ace614cc"), new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee"), new Guid("98d6d51c-b267-4f7d-a17b-1207b9fa8be1") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), new Guid("58c722d1-e949-46da-b96d-53ad1471a267") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"), new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60"), new Guid("98d6d51c-b267-4f7d-a17b-1207b9fa8be1") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("0efbe14d-3f2f-44db-9b48-69048988f1c6"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("0f2eeb1b-9968-417d-8174-0e3a305efb9a"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("5a789fc8-67e8-4912-bf43-cbd1dc840c8c"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("65850a86-f448-481d-aaf9-15d7e6510df3"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("6ad5d965-d31b-4873-8ea2-52f3e5c0f481"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("6c5a1d87-17b9-4384-ac91-74d607cd80b2"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("6d8defed-fc99-442e-8e72-f16e128ea916"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("714604d1-f059-41ad-a31b-ec809da4e63d"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("7da94f86-6900-4a66-b5bc-17c07d475698"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("90810e3c-8530-49c5-ae77-0897f1c4e589"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("a5ebe2e6-71b3-446c-9359-b3939e153223"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("bc67147f-b878-44bb-b3cc-c781ef0cf442"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("5b812b87-946c-4e1a-8335-32f1609dcce3"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("ccad8497-73a8-4acc-82f6-e6f92edb8d77"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("00b6228d-e67d-440b-848f-5dc3170e583d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13c6d752-c68d-4282-ae8c-b319765628cf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("164d2f2d-7ccd-4907-b81b-8b53604fdf9a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("22c3085d-b5be-4db9-8785-f1ab15e928fd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("43bf63d3-df23-4571-8ce3-35de53333f36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("54a19e56-8ba5-4fa8-81be-41b952a6ff32"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ab97aef-9312-405d-a9af-b0d097bdf601"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6cbe51c8-b6ec-4cb9-bab5-c0c2ace614cc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b75212a6-a059-4553-8403-a89e34daa4a6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8838c2a-d183-4243-957b-da6ef2ff8b36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b9e8d7b0-5228-4d7e-9b40-917463625c19"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c87650af-8992-4709-adff-b110f157f5f9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e56e3a6b-dddf-4735-af6b-d277909faadf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eccb7e0d-d11c-4c25-83cc-1019a6604906"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe66bc9d-d8f6-4574-ae7c-2ba362ecbaf6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe78a698-6029-4df8-a545-9c1c03a0bd60"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("31716622-5c3b-44a4-9278-962a01a8de8b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("46a9c2db-f085-4761-a97f-6f4c7e0d0eea"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("55ec329c-b1f2-4191-a726-ef905f28754f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("56119b40-7708-40cc-a06b-477b005d66b5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ab592b49-ce76-4a9e-8263-e8e2f93f09c6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("be2dc24c-960f-4b01-977e-37f80bba6908"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("deae5af1-d8e7-47c8-90fb-9037abfe3f89"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e08c68aa-27e0-4e94-b308-373fb30bedf8"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e956e6bd-e674-4255-9195-6f848c43c5b3"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fdc15b6d-11c9-431e-b201-023451b34750"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ffff8b7b-4c57-4805-a95f-c5c057b7bdc9"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("3067a13c-3fc6-4f54-b8f9-fdf3708fe862"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("03367549-27e6-48b3-b69d-d5f81ca70617"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("1d75b012-508c-47fa-aa2f-c35c248a61ae"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("23db1f83-c4b5-4b73-bc68-85f3f0cbc91a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("2a1b7c8c-b5cf-4b77-b19e-a9bf59be9ba4"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("3e76039d-5779-4998-859d-f8395ab987fd"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("428fae3d-0b4f-4f72-85f2-fa84b6bd279c"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("593c297f-002e-4942-be3a-c2f9c415b67f"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("59a9002c-0bce-4a16-8124-4d7385094c14"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("61e07c30-5814-4dfe-abc5-40fa78fc6f75"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("7dc2bf83-8545-4f81-b618-9d91a9d33350"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("897fea91-b4af-4b9a-af2a-0b22f376c00d"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("971c9677-9c6b-4b72-b924-ffdd1f872571"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("9b8dc0c3-2ac1-47f9-b493-f709cef20fd9"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("c1d3bc85-1b60-454d-a93f-d3b257059d45"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("ecc4ffe6-924c-4cea-ac02-1a12dcc95689"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("f00f6c09-c0ff-43e8-99a5-850feeb40255"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("291fcc5a-3153-48aa-9e01-abda5f73bd0a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4fec6ef1-7dd2-4df7-ae88-c5cefd803f6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9f430c3d-36b0-4cbe-8bd5-75b719498fee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b41ee60a-507c-4354-9e88-8b50470a05bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef95161f-c9b7-4ea5-a08b-b01459be9036"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0d9c445-701d-42ae-836b-58da2240a9ed"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("48bed669-b6a2-46ca-9458-4eaf33133df9"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("50d6aad9-c787-47d0-ae6e-dc26b54ec0e0"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("58c722d1-e949-46da-b96d-53ad1471a267"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5f1514e5-26cd-4cef-b646-52023b748d2d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("63e7e4d0-0df6-4a9a-90ed-b189ef17ad4c"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("93daf3b8-9969-4ea3-a55e-4d9a35bb67d1"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("98d6d51c-b267-4f7d-a17b-1207b9fa8be1"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("9d5afa3b-a53a-4f75-a7c2-edad974300f5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("cc50dff7-2544-4153-9690-73cccf962283"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("f2d5d61f-c8bc-483c-9bda-2a6de1180f29"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("fc5de17c-301d-4979-877f-3df10a1fe85d"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("140bcd9a-2ba3-4553-a2b3-8cdc902f93ef"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("4ab977ea-6dca-4a7a-a45f-0559f3e4d573"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("57f2e685-8c3f-4dd6-879e-6e7a25a92b34"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("6dedad7d-c0b8-425a-97b0-6ded8f31909b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1545d2bc-c070-4c87-9b46-a2976cf027c2"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("25a4cf25-731b-4f94-af4c-d448ab989db1"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("426e0553-799c-43fe-a668-7600ebb7c9d0"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("68fc918d-615e-411b-8f59-4b2533b1c53b"));

            migrationBuilder.RenameColumn(
                name: "SuperCategoryId",
                table: "Places",
                newName: "PlaceCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Places_SuperCategoryId",
                table: "Places",
                newName: "IX_Places_PlaceCategoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Places_PlaceCategories_PlaceCategoryId",
                table: "Places",
                column: "PlaceCategoryId",
                principalTable: "PlaceCategories",
                principalColumn: "Id");
        }
    }
}
