using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"), new Guid("0f74eef1-4110-4b4a-abec-8ff947098939") });

            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"), new Guid("27b30454-141a-459b-ab00-86517c816b74") });

            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"), new Guid("e31f428f-7167-4a01-b745-acf66e0107b7") });

            migrationBuilder.DeleteData(
                table: "ConditionProfilePlaceCondition",
                keyColumns: new[] { "ConditionProfileId", "PlaceConditionId" },
                keyValues: new object[] { new Guid("1b425c65-ee8f-46d8-b37e-1e514451d927"), new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b") });

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("04bf473c-ffe3-4b99-aea7-67b178d776d0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05c06132-dc0e-4e6d-b5d3-17fa71b69343"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05fcb62f-a3f5-4fa9-92b0-81347312294b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("07b8d9d8-f84d-4461-b64c-a725c9a8a035"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0bd6592a-a84c-437e-b008-43629a3ada10"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0ce596f3-91ab-4cda-8808-701abc0ca0f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cee0c88-a1bf-41a4-a027-5622e21d7a28"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0da5ce4a-f1e6-401f-a8b8-fe25333905fd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f7e26d3-cb7b-4aef-8e9a-31ca73ded383"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0fefd15f-4054-426b-b869-3c108fb13f02"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13b220c9-1f65-462e-a248-8b63a779b60e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("14c9a9ee-8ed5-4972-8b6e-162ce00966fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1698ebc5-6d50-439a-bfb2-640f26e1855a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("175dc111-3b63-4d71-af4b-7e7fa96f6fb0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("177019c2-f76e-4c52-9e25-d9cd6b398a07"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18e53a78-59cb-4f06-a29b-2bc8e345c4b5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fcf5308-f5f8-4f5d-b62d-5b306cd7fa56"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("22aaa9f1-e450-42f2-ae19-022e03fc87b9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("24446240-bf81-4251-a5c7-c2f88e69334d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("273e23f6-a0bf-4a66-9f7c-ece39ba89824"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("27b5e98f-d390-4a21-a24e-8da4faaadb5b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2955b36b-b3a4-4774-b89f-a11b27ad2c9b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("29b27733-4042-4377-bfc9-b5b6339efb78"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a3ccd94-7834-4f67-9875-7fb3e2801bec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a7f718d-698c-4e7b-ad0a-588ac9fad47d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d4b971c-9fc1-4b7a-8af4-7e05158d39e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2f9838e6-2f7b-4f92-b84e-1f860e6918c7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("301dc105-00ee-48fd-8aa8-e4d8f3a0acac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31205953-8c2b-4c51-940c-ddb7d90de0f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31273ab9-738c-48ba-89e0-c8a0304d3e1d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31ff1c14-a2d8-438e-ab16-8b67192fd7e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("33a87d05-74a5-471a-aa20-23a81f529feb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("34dee5ad-7845-4623-8d64-936ed1550c28"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("35337352-c34e-4c93-9635-e73894ee4a48"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("370121a3-2f56-4f5c-8b60-bdebd861bf45"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("398bdb6d-646b-4169-add3-157ca09cf8f4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d36f68f-42bc-413f-86bc-9cb0e3623c37"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fab9123-35f6-424a-ae81-38dd99d31b83"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("402b81d8-f476-480f-8ccc-e837f68f2658"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4153b966-41c4-4036-a6e4-146e4e464264"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41d4f6ec-bfe4-4444-adf5-e9c55c6d3911"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("425b6f31-3c5f-4ec0-9827-bfd7be0ed41e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("448ee1d0-fdc3-4c03-aa49-59b1d3f31a86"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45704cc8-fb67-47c3-8aef-5fdcf3f1d271"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45ce68b4-52ba-4080-803f-df08e7c74c3a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("466965f0-1a37-4433-ad94-81325315972a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("49fc2114-9992-4fc4-9f43-c6d9c743de69"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4ab08a9c-95d7-4567-9b7c-2a2f85c19c32"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4ae2f0d6-d43d-47d1-9a73-c691c14a04b1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4aee4717-1543-44cd-8919-a185cab623c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cbde352-4adf-437e-a4eb-53232963f75c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4da5e13f-a1ab-4c18-9e96-d5b0f09b0d1f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("54406508-e00e-4322-819c-59686dc776c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("54f5a9e1-3f58-4aa0-b3ee-da70c061d3a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("561cdee8-e99d-42c3-8df7-0a9fbc0e977e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("568686ea-f168-46b9-81c8-d9fc8887162a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("59401c6b-2882-4c1c-9456-cfd4432c0fe2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b0d92cb-4af0-4c65-a146-7dd659329d8c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b384f27-a8ce-4baa-8d0e-1f0402198caa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b3bf8fb-8c85-4de6-a234-641cd110ad80"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c30428f-d032-470a-b978-0949000709a6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d34ed16-f5ab-457c-b29c-8b6a9141ad38"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5de45683-7e9c-47de-9cd6-bdc55cd8b05d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6022f0fe-395d-42e9-bfbd-7e098e209e7c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("66e85667-3c76-4518-aa6d-8874df5adc62"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b35db83-1bbd-40e9-8d9a-f5149f5157dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b454a7c-a74d-4c09-b693-f7fc3a0e805d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ed9b673-4e22-4815-a84d-34e4bc256be8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f36d8f6-a11d-4587-9226-475a4467e7e7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73008bc3-9894-4433-98f2-1511f65f0709"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7362ea76-cfa0-45f5-82b5-593b65df6a38"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("74390a57-667f-4241-94bc-6939496cbbe2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a5ed3ce-0417-4b51-8862-a2a191cd2d21"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a72eb6c-42e3-40e0-ae6c-d024466a80eb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b0a7d77-e962-4b97-bda6-8bee0c33835c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d3fb7b0-d13b-49e1-b584-731616fc0d27"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d632859-04c5-4285-88aa-8d9da633c514"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e95be59-7ec1-4c26-84bf-85c2bac56c6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("80db6ad7-b7ba-4e19-acc4-bc309e54ac50"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("84aad29d-c262-4b90-a651-85edbb2a904f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("85ebd42e-52ac-4baf-90d8-fb5f579b2259"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8601e246-1505-40d9-8917-fe8106719e33"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("869cab8e-58e7-4e61-a208-1afd23ecfc30"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("88302c42-5fd2-4413-8352-bb341275baf9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("89153df4-bc82-4d07-a831-6de3939035a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("89f73eee-287a-4ced-aedd-2cfdeb08f311"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b0f0189-9886-447d-b110-7557135c2799"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c508f69-2f68-4238-919a-7186e7f55dcb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f16538d-12bb-4c3d-a82c-fe2eb6fd9ee6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9078e0e1-ba61-4740-82ae-d761b5ed2d24"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9124eb25-7b29-4386-af65-18d7ca2f45a2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("919ae52e-badd-4a83-9260-1a2e23879a59"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9236f957-cfae-492c-850f-0f8c37b021af"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("927e72ca-924d-4d68-84c9-5461e6dc1e05"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("94964584-49ec-4668-8eba-8c8e83840600"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("960ac149-6930-44e3-91cf-7bd177e28f14"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("96219df0-47cf-42c9-ad10-a876901b0e24"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("97d6bb27-bbf1-4d53-beaf-055619cc5221"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a01c4e7-83dc-4239-999a-d815f96423c4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a467345-1a8d-4a88-a19d-def94c498435"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9afb32e5-8eb6-42a7-ad7e-88c75ae449d2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9bf56530-b40a-4008-951e-8adc112eff6e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d8518db-fde9-4c4b-8982-f958b8ce0289"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e341188-68df-4c02-88bf-6591cbad6530"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9f01a8c0-d1ba-4146-a871-0008e36455a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a12c7885-1bec-4408-9f41-6e614806896f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a14ef430-b63c-4795-a928-40bb1edcc6c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2351623-d317-426e-ba3b-ef4b8223d02a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a531a9b8-6ff5-438e-843d-1572bc688c04"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a6411a06-c471-45de-bab2-74796de1a6d0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a786c3c8-4c84-4f86-bad5-d96490f77d54"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab714525-e6d5-4906-82d0-ce884915602d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac8a912e-d362-43a0-97a1-b66913d92dcc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("acc9a503-34de-4f80-8f19-340d48ca31dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad35e64e-c99d-4b58-a8e0-afab3db3beef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ada098e0-02e3-485f-85b1-679052e9c0f9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("adb1cc6b-8cd1-451e-b363-5ab816c0867d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aee5c40f-72a6-401f-b2f6-476766982a1b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0124868-643d-422c-8bb2-eb497854de58"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b032c911-ad8e-4c87-a530-578436527493"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b1f9e0b7-d62f-491f-a5bd-c246fca4a076"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2374e7b-65d0-45b6-8760-e2ba40c43d3e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b812a63e-493c-4647-b072-8e81df71491e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8ed279f-ac1d-4a95-89b4-6a51aedb8be9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba3f119e-d43e-44ee-b2ba-00e5e1b18cf4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd3783ec-2bba-41e7-883b-25b90ecf71b8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd3b59c8-805d-4d64-8358-6571af8454ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bdcc931a-1c69-4f6f-b278-dcaa1cf33095"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be6b29cd-1b09-4f2d-a5e3-9d3fcfb17c7e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf8a178a-51b3-48e8-ad25-96cb714ceb66"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c145a13d-5503-4e51-b262-1f2656cdf9d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c279873e-e705-4eb9-b21e-57c2caaecd6b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c34606da-c23d-45d2-8975-e274ad2ffabe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3655fc1-8d7f-4fbd-a401-d96a887726f3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c7d12b42-3cb8-4ce5-a49d-8226df7bc477"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9398e38-ee48-4217-a709-f39458dd3f36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cb016a92-3aab-4c82-bcf5-73b4d97f49e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cbf72716-f6f0-49f0-b0ea-92a5734eb469"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd13199e-7d2f-47c2-9b21-79198469f0b1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce97791c-d342-48db-98b8-892051bd4689"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ced525d7-f045-4870-a271-a86119fa65b8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2ad28c1-c67a-4608-aabb-20db01f4412d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d48a3541-649a-4855-a123-232d59a1f4aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d526a682-0bd0-40e3-bcf4-a2d63724620d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d5e887d4-fab2-4f55-9ab4-af70803ee101"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8bbd665-6369-478e-ac90-454a021fea56"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9677499-2759-4e32-941c-dbc63809940d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d98c5384-e2cb-41ee-b8a7-650bc047b165"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("daafbcc9-2f8c-43f0-b20f-120bf23f0145"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dafc0864-596e-4677-81e7-415ba3d6c411"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("def2be31-f989-4300-a3f5-101395a1cd23"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e316333c-378e-4d70-a889-77a6f61af82b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3d3552f-42d2-47b2-b83b-e10c8c4f26ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e535434f-0c99-448b-803b-958a910161fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e58a21b3-6439-4ab5-8fee-11fcd562655d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6170119-7962-4e79-b266-5411a0c07642"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6ba8aad-fbfa-45fa-af1a-ffea205697f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e726ada7-aee8-4065-89e4-1da3a194e048"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e96fbecc-baa5-45f9-955b-86eaaedacbfa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea1d08dd-9d8e-4ee4-b395-a2662d8d68e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea3484f9-a372-4ddf-bee8-3309cced232b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb26cdc5-694f-48af-845f-dc190c129cbb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed7742fa-5440-4214-b81d-24d8f576487f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee835d25-626a-4703-8396-e1fc4d2eac44"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef3045e6-7f60-4f3b-b60b-139cbc0a2b92"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0cade80-cd26-423e-b425-f4fc9722cef4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f7ab41b6-0ed2-44a2-962d-afae9547fa38"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f7f57892-48c6-4718-8a64-74e5697b5153"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f82bd341-f895-48d2-a392-86ca5af3894e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa032d8c-e9c6-442e-bec4-f4525cdfbbae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa2bbdc4-3637-42d3-9948-dc9b18a2ccbb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb423028-1e31-465f-8413-d24fe13296f1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb5d5288-9266-4018-b7b2-15423ea4dbb8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb9a6da5-17b2-45e7-82dc-07b7c96daf96"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc97d501-8dd4-453f-b839-f6521397d929"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe0216b0-c025-4be1-af13-81699ffbc2b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe2856f1-a528-416d-9d02-d74d0ab7cdfc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("052cfb94-2fad-404a-8899-5395f82c82c9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("10b73c51-6e68-4c23-8f47-ccca2e9c329d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("48c5d761-a7c7-452f-844a-5b019c2911b1"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6eb7c79f-efcd-4315-a363-47ad1e51aaf1"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7317f08a-783f-421c-94f8-77b9a7f25134"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("73412bf4-6d67-49a7-85c2-6348b56fe3ab"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("77b84d7e-738b-4f73-8b6d-213a2fcf38de"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7e868179-cf43-45e4-99ca-e184b8bfcd57"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8cf878aa-c0c2-4e76-8096-8b366b6d3668"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9edca647-f39c-4de0-b414-2882020c11e9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("afae5768-472b-49ca-be13-c1965ff86efe"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("bcabf666-4264-4e6f-ac21-a92952533dd5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("bd6a6106-c6a0-420a-9d26-f821c1d5401a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d4d8f27a-68ac-45a5-9c8e-b35b406365ee"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d4ffa7c0-ce42-4bc3-a9bd-d7710eeb3dbf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fc8d0ab9-7e5f-4096-9f40-42a6599200a3"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fddd1caf-cbaf-4ff1-a193-884d379b3da1"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ffab9981-19e5-4430-b31f-8855e6f619f7"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0388426a-2ccb-48cb-9514-33879d1c3076"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("05276e93-6021-4ad9-a8da-532781ecd32d"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0c90c8b5-20bf-4001-9589-de410136e4f6"), new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0f74eef1-4110-4b4a-abec-8ff947098939"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1b6301d2-9251-48bf-8646-d4bf24acc4e8"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("98adcdcf-8359-4974-a02d-4192f628c107") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4748a6e0-c990-403b-b7ae-2e694a27a9ca"), new Guid("5760d083-919c-430a-9a26-59728233d777") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5"), new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657"), new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("78da8bcc-1884-48a9-9f9c-e1b623527dac"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("98adcdcf-8359-4974-a02d-4192f628c107") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("a0c8369f-f0b7-4fd6-b32e-901f476006a0"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("adba8806-f6f6-4272-989c-150a6d7302f8"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b183e34c-7599-4373-8637-6fb5a42c7c10"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("cd3d674b-5392-4e40-b0a0-d1df96b79a8c"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e31f428f-7167-4a01-b745-acf66e0107b7"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e31f428f-7167-4a01-b745-acf66e0107b7"), new Guid("5760d083-919c-430a-9a26-59728233d777") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e31f428f-7167-4a01-b745-acf66e0107b7"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f3e1bd5e-adf6-47b0-8fa0-9606d3cdce79"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f3e1bd5e-adf6-47b0-8fa0-9606d3cdce79"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("98adcdcf-8359-4974-a02d-4192f628c107") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("5760d083-919c-430a-9a26-59728233d777") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c979e365-7f55-42ab-af48-0446fb979b0f"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c979e365-7f55-42ab-af48-0446fb979b0f"), new Guid("5760d083-919c-430a-9a26-59728233d777") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c979e365-7f55-42ab-af48-0446fb979b0f"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("efb33e83-9578-4468-9daf-7132d56aae28"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("efb33e83-9578-4468-9daf-7132d56aae28"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("efb33e83-9578-4468-9daf-7132d56aae28"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("15abdd55-97ec-4df1-b972-ab7263a90a19"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("1c19279b-65e3-44bc-b3e2-201675531eed"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("5267719f-5c1f-4d14-a78f-ec553ec51b0f"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("58dafadd-efdb-4395-b769-c66ae537c278"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("7e7f056e-7f0c-4ab7-b9de-df4f4e3a0564"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("9720dcf8-29de-4dd6-869f-1f58e4ec8795"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("99af0ef9-0e2e-4f2e-9168-9d0a6c156def"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("a81a0b59-591b-491e-b734-df0e0c550d13"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("e57efd04-7513-4474-acc3-4b6ebf1273a0"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("f5c8b403-5621-4257-9d4d-e91ff8815f96"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("fdafa700-ba63-4124-a33b-abbe85c725a8"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("ff818b58-8af1-4392-8f02-b8fe789864e2"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("33b394a8-1f6e-4eaa-a7c3-30047e2ff1bd"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("001a1eda-6eb9-4121-b0fe-768855e1c18a"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("0f59c637-323a-49f3-b9d1-c6024d8892ca"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("115dc103-a980-4368-a28d-d810040c68be"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("19252019-9bde-44c2-932d-3c01734e1429"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("28224c43-982e-4342-b8dc-47605cea9752"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("37e7c0b4-fe9f-4029-95d4-fc7fbcecfb0d"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("37fb4a14-52bd-41f7-8999-c00045e23301"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("3e5597a6-af4f-47c7-985b-b1322695bb29"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("429790bb-04ce-4254-abd5-f5e92df9892f"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("4366cd4d-85eb-4c3c-8298-77491799d9d3"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("4e1bf8fc-218d-4e2a-bb9e-4c8e9eef9f34"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("6f0948cb-e98a-4c73-b90a-5a38676d5955"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("7656aa34-35e8-4e5f-9ab9-ac81df1f8753"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("9dda2efb-a51a-4f1c-be6d-6ed3449b950f"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("a534b557-b701-4558-ab3f-39c82d260aee"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("a8b04369-824e-42bc-b07c-642f6e34de5d"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("af5d5f2e-3dd0-4ab8-a26d-e7eed84220b0"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("bbc7fb38-66ec-47d3-b1b5-241356651cba"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("d95e9386-0305-45b6-9dfe-476ce02ebb6a"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("eca62450-86e3-4bfa-b513-0857b7cae90e"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("f541f23a-7b2a-47f9-9389-c8f80e4ee29d"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("fa90bf0e-1ce1-4b9d-a021-0310e77e4ba1"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("17629758-7b19-45e0-ad3f-7704f73e1c65"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("cdc3704f-5aab-4048-a5a9-7006b664ce24"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0388426a-2ccb-48cb-9514-33879d1c3076"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c90c8b5-20bf-4001-9589-de410136e4f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b6301d2-9251-48bf-8646-d4bf24acc4e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("206bf6d8-af1f-4502-8d3a-ce9a365be63f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("293f18bf-cd8e-4ddb-8bac-8e5f0cbd5433"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4748a6e0-c990-403b-b7ae-2e694a27a9ca"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5be71326-55f0-425a-9ed5-4c4914ea8127"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("90be597f-c6e5-4c6b-99b2-79eac52e0156"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0c8369f-f0b7-4fd6-b32e-901f476006a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac27e10c-1e8f-4046-bfb0-b936589a1a5e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b183e34c-7599-4373-8637-6fb5a42c7c10"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd3d674b-5392-4e40-b0a0-d1df96b79a8c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f3e1bd5e-adf6-47b0-8fa0-9606d3cdce79"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("092b017b-6f0b-4874-b010-800b68fd6e81"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("15ff4c45-37a7-4289-a98d-19f859042b26"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("369ff98a-9183-42df-b62c-8ab140ab25c6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5114e882-e864-4d41-9a93-e84bbb05e7d5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("65285dd2-2c7a-4ce5-8fb2-e9478572c9a5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7be31568-2a9a-4a05-ad11-2083940795dc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("bd22d9d2-4220-4bdf-9313-45743ee54630"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c979e365-7f55-42ab-af48-0446fb979b0f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d5203bb8-6c82-4017-a03a-58227d5bd42e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("efb33e83-9578-4468-9daf-7132d56aae28"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("28f5fd03-da9d-4c53-97bf-a40805391098"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5760d083-919c-430a-9a26-59728233d777"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("b362daaa-9821-4360-8758-c715ab7b01b5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("27651590-f8e7-4b16-b6c8-8a1eb7e294a1"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("39023f49-bca4-4fb1-b9cc-11c1a528e004"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("3b633608-bcf9-4e1b-9f1f-7f403f8dd6a7"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("3dd2e7b1-9f68-44db-a9bd-a6cd7cee050d"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("4f7a064e-929b-49f9-afad-97d9158e3dcb"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("54f231bd-aa27-4cf6-a372-a3bb5f8b920c"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("5c0ebae2-b02d-4686-a34f-80b91e35d825"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("5e5ef092-f6ea-4128-84a1-f385334a4f8a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("787f1cc7-fd0c-4d60-9434-a2fb5fab2d5a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("8fd20382-6fb3-4241-86e5-7ec309a9221c"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("98e914b6-1fd1-42ed-81c8-0b719ef5df51"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("99dc1794-a3b1-4338-a471-34765377d51f"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("9ed9016d-e621-4953-a1f2-5347b29a6552"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("a19d578c-6e7a-4e0a-8f04-5f5cb4be3150"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("ec4ce504-f553-4e61-abec-45c8890d7c48"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("f554bcd4-e115-4242-b883-b578000bc129"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("127aa433-a232-402b-b74f-47b568dd68ca"));

            migrationBuilder.DeleteData(
                table: "CategoryProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"));

            migrationBuilder.DeleteData(
                table: "ConditionProfiles",
                keyColumn: "Id",
                keyValue: new Guid("1b425c65-ee8f-46d8-b37e-1e514451d927"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05276e93-6021-4ad9-a8da-532781ecd32d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f74eef1-4110-4b4a-abec-8ff947098939"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e31f428f-7167-4a01-b745-acf66e0107b7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1c477f6e-e788-48f3-87fd-14ba1c961c16"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("72405b60-b0d2-4e6c-9a70-ffc10f344e01"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("319d3a58-6a5f-4d90-a76b-1d8ea0c5b721"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("48ab2470-71c9-4959-95d8-b824edc58512"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("58418c2f-1ee2-4164-8b8b-1f768323c8e5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("6e337722-b020-407d-b666-7a2aa9631ffc"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("98adcdcf-8359-4974-a02d-4192f628c107"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("be6fd349-e7cf-40bd-a9a2-ce7cb6e21527"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("e30bc546-3e22-42a4-b974-ef70f54ac812"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("e3310633-abf3-4f85-95d3-ae8ca5bc683d"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("78da8bcc-1884-48a9-9f9c-e1b623527dac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("adba8806-f6f6-4272-989c-150a6d7302f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("34e0c30c-6eb1-4260-bc5b-15924f61281e"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("ee13fbd0-885e-469e-8277-9b1be1dff5b7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("27b30454-141a-459b-ab00-86517c816b74"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("ab644f74-ab99-4a17-bb4a-a3d9d712fb93"));

            migrationBuilder.InsertData(
                table: "CategoryProfiles",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), "Podstawowy", "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "ConditionProfiles",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"), "Podstawowy", "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), null, "entertainment", null },
                    { new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402"), null, "leisure", null },
                    { new Guid("300a9809-d88a-47ef-b14e-8a9a6db5dc6b"), null, "commercial", null },
                    { new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3"), null, "natural", null },
                    { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), null, "heritage", null },
                    { new Guid("69282965-78a1-4163-a28a-7c330b688c34"), null, "other", null },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), null, "tourism", null },
                    { new Guid("824a9051-cb95-46d5-8995-5420a6af3fae"), null, "activity", null },
                    { new Guid("af8af887-2e25-4edf-86ca-c54430573908"), null, "sport", null },
                    { new Guid("c0e1751b-701d-45d3-a8d7-a3cf86dd4149"), null, "national_park", null },
                    { new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868"), null, "religion", null },
                    { new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe"), null, "catering", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("054c1e5d-2f56-4fb2-8617-310e9ff3855b"), null, "access_limited", null },
                    { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), null, "fee", null },
                    { new Guid("1ce23c66-1b40-4f22-b02f-6609aa59d24d"), "Name property defined for the place", "named", null },
                    { new Guid("2651ead4-0c97-4141-b622-39fb1b8cce8e"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("30788876-73cf-4fed-98b4-dc4e83bcb2b5"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("3837d52a-adb1-4c86-ab1c-3ad79dd19c86"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("4b449869-57d0-4fe4-9f2b-676402d89967"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("5865a59f-ff2c-40b4-ad5a-e4eee77b2f7e"), null, "access", null },
                    { new Guid("61dffa8a-3270-486a-b628-2392a41b27c5"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), null, "wheelchair", null },
                    { new Guid("77cc2cc5-7c56-4690-8689-f3ef38d0614b"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("822a74ae-7e39-4bb8-8cd2-39fc729e59ad"), null, "no_dogs", null },
                    { new Guid("937b2203-3282-4abf-b885-8ce74231d594"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("b0011601-c240-4508-8cec-e6a35bf0e863"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("de1385b2-ffee-4562-b818-759a4ecf6250"), null, "internet_access", null },
                    { new Guid("edad88d7-3158-4ad5-9cc8-f01304b5ed06"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("f1e67864-3da2-4172-b4dd-7d57bc0083d6"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("fde4d999-7fb1-4862-aaca-9bfe5581c296"), null, "dogs", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("076737d2-16b9-489c-b157-39f97aba1af2"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("07989400-6725-4976-a1ec-77ca23b74255"), "Wrocław", "Poland", "9", 51.11288660m, 17.02688220m, "Muzeum Archeologiczne", "We-Sa 11:00-17:00; Su 10:00-18:00", "ProviderPlace", "5133d879c0e106314059f2ec6d11738e4940f00103f901710a264c000000009203154d757a65756d2041726368656f6c6f6769637a6e65", "Lower Silesian Voivodeship", "Antoniego Cieszyńskiego" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("09afec0e-1382-4578-8ffd-000971cbbc19"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("1c6cc576-778a-4808-954c-c046472c7036"), "Wrocław", "Poland", null, 51.10957585m, 17.03206577m, "Ratusz", "We-Sa 10:00-17:00; Su 10:00-18:00", "ProviderPlace", "51b849627635083140596870d894068e4940f00102f90138ce3f330000000092030652617475737a", "Lower Silesian Voivodeship", "Rynek Ratusz" },
                    { new Guid("1e70f971-a497-42c8-a563-23a68447418e"), "Wrocław", "Poland", "1", 51.10688750m, 17.07731849m, "Hala Stulecia", "Su-Th 09:00-18:00; Fr-Sa 09:00-19:00", "ProviderPlace", "5159f5f324cb1331405964c6547dae8d4940f00102f90136e6691c0000000092030d48616c61205374756c65636961", "Lower Silesian Voivodeship", "Wystawowa" },
                    { new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" },
                    { new Guid("32a817b9-6d03-4311-807b-d3d993feaca5"), "Wrocław", "Poland", null, 51.10897760m, 17.03266890m, "Wrocław", null, "ProviderPlace", "51dfc081e697fa30405906310a6025904940f00101f901bce3060000000000c0020992030857726f63c5826177", "Lower Silesian Voivodeship", null },
                    { new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97"), "Wrocław", "Poland", null, 51.10432090m, 17.03133350m, "Bolesław Chrobry", "24/7", "ProviderPlace", "51eac4e5780508314059b43e21635a8d4940f00103f901ace8111000000000920311426f6c6573c5826177204368726f627279", "Lower Silesian Voivodeship", null },
                    { new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778"), "Wrocław", "Poland", null, 51.10248345m, 17.08599881m, "Kościół Najświętszej Maryi Panny Matki Pocieszenia", null, "ProviderPlace", "51324592040416314059a36a7b2d1e8d4940f00102f9010d300706000000009203374b6fc59b6369c3b3c582204e616ac59b7769c49974737a656a204d617279692050616e6e79204d61746b6920506f636965737a656e6961", "Lower Silesian Voivodeship", "Edwarda Wittiga" },
                    { new Guid("53758522-0a17-4211-baa2-165cf08b0d2e"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" },
                    { new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d"), null, null, null, null, null, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", null, null },
                    { new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("977c8178-9039-47ff-ad5b-98373b292abc"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4"), "Wrocław", "Poland", null, 51.10864425m, 17.07875630m, "Wrocławska Fontanna", "May-Oct: 00:00-24:00; Nov-Apr: Off", "ProviderPlace", "51299d5f5f291431405946ac040ee88d4940f00102f901e25aa7020000000092031457726f63c5826177736b6120466f6e74616e6e61", "Lower Silesian Voivodeship", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("9a0ddf04-1fc7-40a0-99d2-a52ea24c3edb"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null },
                    { new Guid("aea1d075-f00d-4966-bb07-09cc2f5ddd4a"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"), "Wrocław", "Poland", null, 51.10994465m, 17.07986499m, "Ogród Japoński", "Apr-Oct: Mo-Su,PH 09:00-19:00", "ProviderPlace", "51d8ce250872143140598b6890aa128e4940f00102f9014c34de0f000000009203104f6772c3b364204a61706fc584736b69", "Lower Silesian Voivodeship", "aleja Dąbska" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("be0b4d83-d85d-4ab5-bec0-d0c912a71e18"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), "Wrocław", "Poland", "1-5", 51.10425535m, 17.07484842m, "ZOO Wrocław", "Mar: Mo-Su 09:00-16:00; Apr-Sep: Mo-Fr 09:00-17:00; Apr-Sep: Sa,Su,PH 09:00-18:00; Oct: Mo-Su 09:00-16:00; Nov-Feb: Mo-Su 09:00-15:00", "ProviderPlace", "513a952f4429133140591ab1413d588d4940f00102f901012324020000000092030c5a4f4f2057726f63c5826177", "Lower Silesian Voivodeship", "Zygmunta Wróblewskiego" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("c8eb6289-5dc7-495d-873a-66cea43164a5"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null },
                    { new Guid("da044dbf-0f05-493d-a498-27156beeca18"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null },
                    { new Guid("f282d667-d800-4009-9e50-8e8f3cf67113"), "Wrocław", "Poland", "35", 51.10744710m, 17.02887780m, "Muzeum Historyczne i Muzeum Sztuki Medalierskiej", "We-Sa 11:00-17:00; Su 10:00-18:00", "ProviderPlace", "51979416896407314059ca9f98d3c08d4940f00103f9010992932b020000009203304d757a65756d20486973746f7279637a6e652069204d757a65756d20537a74756b69204d6564616c696572736b69656a", "Lower Silesian Voivodeship", "Kazimierza Wielkiego" }
                });

            migrationBuilder.InsertData(
                table: "CategoryProfilePlaceCategory",
                columns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                values: new object[,]
                {
                    { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3") }
                });

            migrationBuilder.InsertData(
                table: "ConditionProfilePlaceCondition",
                columns: new[] { "ConditionProfileId", "PlaceConditionId" },
                values: new object[] { new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"), new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f") });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("08cc3914-f217-47b0-9a60-848f002837c3"), null, "ice_cream", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("0b13c9c2-d128-44f8-9186-f6a9de63318e"), null, "forest", new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("0ba72609-b79f-44e4-8380-26c041a93053"), null, "pub", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("117503b7-014f-4c85-950e-68140b86a670"), null, "gift_and_souvenir", new Guid("300a9809-d88a-47ef-b14e-8a9a6db5dc6b") },
                    { new Guid("195c2f29-6a95-4da5-8637-f05892583cb0"), null, "mountain", new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("1d2725bd-c96a-4a10-917c-0dc8af9e4768"), null, "aquarium", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1"), null, "restaurant", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f"), null, "culture", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), null, "attraction", new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), null, "sights", new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3") },
                    { new Guid("68b0c129-7b2a-49d0-9aeb-c6f7d7daf73a"), null, "sand", new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("69f51b64-8e50-4f68-ae19-f8bbbc33aef0"), null, "taproom", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("74ed3423-a4c4-4b63-a1d0-2acc15c2689b"), null, "biergarten", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("81cd1d0a-8eb4-42e0-9920-2c90a0ceefdb"), null, "unesco", new Guid("65156b12-b55d-4e2e-8344-41f149eb4925") },
                    { new Guid("a14d0b28-a448-414d-acfc-7037c12906c6"), null, "bar", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("a2fa84cc-b2e9-40da-9ecd-110717b4433b"), null, "stadium", new Guid("af8af887-2e25-4edf-86ca-c54430573908") },
                    { new Guid("af0d7109-d550-4537-8b51-affb642297b2"), null, "cafe", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a"), null, "fast_food", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("bbda8310-c9a6-4a0e-a44b-93aad421895e"), null, "planetarium", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2"), null, "place_of_worship", new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868") },
                    { new Guid("da2a75c1-f704-470b-a7e3-e2e83a5715d9"), null, "food_court", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), null, "museum", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("e80583c1-fb35-492f-828a-45441253fc43"), null, "water", new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf"), null, "park", new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402") },
                    { new Guid("e99d71b0-5e47-4b97-85d2-88b29e7ad9f4"), null, "art", new Guid("300a9809-d88a-47ef-b14e-8a9a6db5dc6b") },
                    { new Guid("f5975d83-d5c0-457f-9e79-987e572f50bd"), null, "zoo", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("2252e854-7c22-41d8-85ca-859d2a716b54"), null, "only", new Guid("4b449869-57d0-4fe4-9f2b-676402d89967") },
                    { new Guid("41db4974-d535-4d5c-8733-09ddea0c34cb"), null, "only", new Guid("30788876-73cf-4fed-98b4-dc4e83bcb2b5") },
                    { new Guid("4b8f3174-fc4e-4896-8b7d-3783319e027b"), null, "not_specified", new Guid("5865a59f-ff2c-40b4-ad5a-e4eee77b2f7e") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), "Places that are available for public", "yes", new Guid("5865a59f-ff2c-40b4-ad5a-e4eee77b2f7e") },
                    { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), null, "limited", new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f") },
                    { new Guid("65c4d2b2-e6a7-4c66-8249-94d8f7463539"), null, "not_specified", new Guid("77cc2cc5-7c56-4690-8689-f3ef38d0614b") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), null, "yes", new Guid("fde4d999-7fb1-4862-aaca-9bfe5581c296") },
                    { new Guid("8bb82328-5dbf-414e-bcdc-c22aeefca54c"), null, "only", new Guid("b0011601-c240-4508-8cec-e6a35bf0e863") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), null, "yes", new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f") },
                    { new Guid("c1db5cb5-25ef-4286-bc20-b602eeb18b6b"), null, "for_customers", new Guid("de1385b2-ffee-4562-b818-759a4ecf6250") },
                    { new Guid("c73a511c-fca8-40f0-b39b-021d0440cafb"), null, "only", new Guid("937b2203-3282-4abf-b885-8ce74231d594") },
                    { new Guid("d3ad5bdd-0ec0-47f1-9530-341f255cb427"), null, "only", new Guid("2651ead4-0c97-4141-b622-39fb1b8cce8e") },
                    { new Guid("d3f9041e-420f-4ee1-a267-837b8baeb63f"), null, "no", new Guid("77cc2cc5-7c56-4690-8689-f3ef38d0614b") },
                    { new Guid("d5629a3f-e5ac-4687-967e-ad3ad69787df"), null, "customers", new Guid("054c1e5d-2f56-4fb2-8617-310e9ff3855b") },
                    { new Guid("d88cdd99-2402-4ba4-a1f4-b05f9a75d1b5"), null, "free", new Guid("de1385b2-ffee-4562-b818-759a4ecf6250") },
                    { new Guid("ed1ab986-6da8-4a11-a229-107baf578281"), null, "leashed", new Guid("fde4d999-7fb1-4862-aaca-9bfe5581c296") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") },
                    { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") },
                    { new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe"), new Guid("977c8178-9039-47ff-ad5b-98373b292abc") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCondition",
                columns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") }
                });

            migrationBuilder.InsertData(
                table: "TripPointReviews",
                columns: new[] { "Id", "ActualCostPerPerson", "ActualTimeSpent", "CurrencyCode", "ExchangeRate", "PlaceId", "Rating", "TripPointId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00a97dea-1347-44a7-acf2-16e8956d43d2"), 25m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("1c6cc576-778a-4808-954c-c046472c7036"), 4m, null, "0ef31cb3-e48e-4799-a460-391da39ccb47" },
                    { new Guid("193b8039-c7a4-48de-a3a3-a0d2351a3654"), 20m, new TimeSpan(0, 0, 50, 0, 0), "PLN", 1m, new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"), 5m, null, "25dfbbfe-9aba-4d77-8457-ad753d71318b" },
                    { new Guid("2054631d-b31c-4038-ba13-0e2f231a29c4"), 10m, new TimeSpan(0, 0, 20, 0, 0), "PLN", 1m, new Guid("07989400-6725-4976-a1ec-77ca23b74255"), 3.5m, null, "328793f4-2f3d-4a53-9403-926667fc61f2" },
                    { new Guid("28a809c3-2991-476b-965b-541c9cd80c27"), 20m, new TimeSpan(0, 0, 30, 0, 0), "PLN", 1m, new Guid("1e70f971-a497-42c8-a563-23a68447418e"), 5m, null, "77b3590e-1f18-4260-87a5-e005e3bb0da3" },
                    { new Guid("2bef4837-2fe9-4937-bb96-e13007a35a74"), 100m, new TimeSpan(0, 1, 45, 0, 0), "PLN", 1m, new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), 4.5m, null, "49889cd9-ee66-49df-bffb-48144249ef5d" },
                    { new Guid("30babcf1-0e4c-4e80-a0a8-e9bf3c3fd211"), 14m, new TimeSpan(0, 1, 10, 0, 0), "PLN", 1m, new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"), 5m, null, "3aa3cd1a-deb5-4568-be3b-7997378cd923" },
                    { new Guid("30f9b4a8-3829-46fa-980e-9860e3aa6022"), 5m, new TimeSpan(0, 0, 8, 0, 0), "PLN", 1m, new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778"), 4m, null, "d2d8eef9-47a8-489e-bc9a-20f3d3de812e" },
                    { new Guid("3a50037a-02ba-4ad1-8a48-66e499e6c729"), 75m, new TimeSpan(0, 2, 0, 0, 0), "PLN", 1m, new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), 5m, null, "90ded25c-90c8-4947-8864-b77a9acf51b9" },
                    { new Guid("40cb2e38-bb8d-46f2-98b6-4f1c74dcdb48"), 0m, new TimeSpan(0, 0, 7, 0, 0), "PLN", 1m, new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97"), 5m, null, "808cd363-8a33-45b9-82ba-eebe021c26e0" },
                    { new Guid("49090605-1fa0-45d9-9a11-472bd5482619"), 0m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778"), 3.5m, null, "a65b8292-e780-48d8-973b-d45057ffa389" },
                    { new Guid("80f18f18-b4b5-4b91-919e-c77ea3b117a9"), 80m, new TimeSpan(0, 1, 30, 0, 0), "PLN", 1m, new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), 4m, null, "40eb2d40-86c8-4358-977a-07a04fc0a9f0" },
                    { new Guid("9978502b-a95d-4a61-af6e-122b0a1f7aff"), 15m, new TimeSpan(0, 0, 35, 0, 0), "PLN", 1m, new Guid("07989400-6725-4976-a1ec-77ca23b74255"), 4m, null, "04b65761-5489-4dd9-a534-1493ec8204b4" },
                    { new Guid("afe43f25-0e27-442f-a357-35279fdad74c"), 17m, new TimeSpan(0, 0, 25, 0, 0), "PLN", 1m, new Guid("1e70f971-a497-42c8-a563-23a68447418e"), 5m, null, "93d98a2a-bf84-4649-9dc6-5cce8c9d71a7" },
                    { new Guid("b94c6142-70d9-4dff-96cc-6da6f6c2c5a5"), 0m, new TimeSpan(0, 0, 5, 0, 0), "PLN", 1m, new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97"), 5m, null, "8f483cbb-e6a6-450d-92af-d353203ff9d1" },
                    { new Guid("c5e43721-9435-4bc7-9ca6-ab0bd1d194c8"), 0m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4"), 4m, null, "638bd700-6b24-4f21-95d9-d1f94d57a95d" },
                    { new Guid("c7ca1758-6264-40b6-9b61-58f0cf86ebc2"), 14m, new TimeSpan(0, 1, 20, 0, 0), "PLN", 1m, new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"), 5m, null, "aef4af29-be4f-4d6d-bd22-50cd00019fdb" },
                    { new Guid("c8997bd5-e449-4d01-96e0-758eae15aa28"), 85m, new TimeSpan(0, 1, 37, 0, 0), "PLN", 1m, new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), 5m, null, "7b87c90b-5f6d-411d-86c2-f25a7a33bbb1" },
                    { new Guid("d069a5c7-3f6c-48dd-8a7f-fb7538a157ba"), 0m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("1e70f971-a497-42c8-a563-23a68447418e"), 4.5m, null, "3c8a78b9-4c27-4b09-b9e0-657a64e3f4af" },
                    { new Guid("d723542b-2c5a-4a60-9dcf-0fbdac053fa6"), 30m, new TimeSpan(0, 0, 20, 0, 0), "PLN", 1m, new Guid("1c6cc576-778a-4808-954c-c046472c7036"), 3m, null, "884de7d6-cad5-4992-81bf-548f37018396" },
                    { new Guid("f4559608-4d94-4790-bd6f-281a38a91461"), 0m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4"), 4.5m, null, "c55f773f-6b4f-4827-ad99-999576c8eeda" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("44609932-1913-412e-9682-ee17fab551a1"), 200m, new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"), "PLN", new Guid("32a817b9-6d03-4311-807b-d3d993feaca5"), new DateOnly(2025, 12, 6), 1m, "Wycieczka do Wrocławia", 1, new DateOnly(2025, 12, 6), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("9ea3d559-e80c-455c-a7dc-ca654cc58ce7"), 100m, null, null, "PLN", new Guid("da044dbf-0f05-493d-a498-27156beeca18"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("bc3e7c63-e650-4f61-88ba-c3ae17a438a9"), 100m, null, null, "PLN", new Guid("da044dbf-0f05-493d-a498-27156beeca18"), new DateOnly(2024, 11, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 11, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0126b355-6f1d-4d65-baa4-df9f725656d7"), null, "gallery", new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f") },
                    { new Guid("0168dfdd-b23f-474f-9bcf-a435ddba8cb9"), null, "wings", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("01c5086c-1e1d-4804-9b0b-ae9b18ad8807"), null, "caribbean", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("01ce27ed-3189-42ef-816c-e64b963f2fa0"), null, "taiwanese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("046b33d9-8b9c-4ef1-8e76-02232bceb9d5"), null, "battlefield", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("055e9136-7904-4b2f-9f2c-e9fc0b65a094"), null, "curry", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("065c53eb-a19f-46cd-b0fb-7e165b17b64d"), null, "hawaiian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("07fd6909-b4e5-4fb1-b307-d7fe7141e8a5"), null, "croatian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("08cf52df-3bf6-499b-96b5-54f4d8d8e2f0"), null, "archaeological_site", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("0b7733ca-e3a2-4aa5-a8e0-0f18d86d0f0c"), null, "christianity", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("0c2b9ca9-59b7-4502-a6d8-ca12d88946d4"), null, "cave_entrance", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("0c37c56a-7eab-41d5-97cb-393558c6654d"), null, "fort", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("0cf3fa9d-cf26-4cb2-a77c-5c250ca16d7a"), null, "uzbek", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("0f4534ff-4f24-4f7d-8474-6f686a4b77e4"), null, "artwork", new Guid("511b1c02-92a9-4157-8760-35b25407b752") },
                    { new Guid("1056f1f8-8cf2-4523-8553-28e631d52fec"), null, "bridge", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("116c209a-c3e2-4f55-bc8a-39b2f70ebc03"), null, "salad", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("11f382c1-9019-43ca-a323-40ffcb4846f0"), null, "donut", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("12ad7960-6fd4-47b6-8b40-d4d3e0130a5f"), null, "kebab", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("13bfd3dc-abb6-4f9e-9df1-622be15faa64"), null, "reef", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("15af10de-7037-409e-9970-94f0a77377cb"), null, "african", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("16cad34c-5dce-4710-819a-530da999b184"), null, "fish_and_chips", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("17c05f8b-ce87-40bb-bf5c-d254a67c8558"), null, "arab", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("17f85471-d607-4fdb-ae84-5076dc9f32bd"), null, "tacos", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("18e97a14-3ca6-430a-adee-395a9bb0a157"), null, "western", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("1a55c164-2126-4bfc-99a7-32905023c89e"), null, "geyser", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("1b995dc2-5f5f-4d95-baec-c36b638bc2a0"), null, "crepe", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("20edc26f-539b-430c-a5f8-e74a4c152655"), null, "european", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("25451861-2605-43b8-a19e-8335ca4e013f"), null, "belgian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("26a70dbb-9fe6-4c31-88aa-9c9175a64c36"), null, "lighthouse", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("28184ebf-d6b3-4c24-a0a4-cceafb897086"), null, "ramen", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("28d9bfb8-cc35-4529-9335-f215d4c9199f"), null, "czech", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("2edb7842-63c3-47b2-a134-2e36078c45ad"), null, "beef_bowl", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("321ab057-22a7-47fc-ac72-8464c2c8d96b"), null, "islam", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("36f50eca-a3cc-4f23-a4f4-b457f6e2f705"), null, "ethiopian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("38590d77-ae64-447f-82ad-4e497c23afc3"), null, "multifaith", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("38aaae4c-c1f9-43fd-b695-908ace5fc2bd"), null, "city_gate", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("38ab4808-e9b4-475b-8f4f-efb5b307ceea"), null, "moroccan", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("3c422a5d-31be-4803-a24f-c4beea2638ba"), null, "nature_reserve", new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf") },
                    { new Guid("3d984a1c-2297-4bc9-96c8-aedcca0939ac"), null, "thai", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("419eced0-4518-4220-90f3-6863accf4f9e"), null, "georgian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("41ae3a96-7efd-4789-846d-28527d28977e"), null, "tapas", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4363b2af-5f65-42ca-931a-4a5050d7491c"), null, "burger", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("46cd0446-ab4a-40c5-9318-b7232adeda52"), null, "chinese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4a280d10-e352-4d8b-9bc5-43feb1b4fe72"), null, "soup", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("4a77bc45-b094-4ad0-b6c4-41c15b44b600"), null, "friture", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4acf6e56-4121-4371-a799-6a910119cfd1"), null, "indian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4b2c8d4f-1c96-44e6-950c-e2cdb2a2f71f"), null, "french", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4cf4196d-43d4-443b-a3e9-c9005d2d80a8"), null, "balkan", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4df95354-121a-4f30-9947-271c60f6de30"), null, "spring", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("4e565498-7b82-4a9f-aad8-2c1e0bc8d9b4"), null, "monastery", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("55367cdc-ed3f-4a79-bcff-a990ac590ddd"), null, "frozen_yogurt", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("56225a55-c6dd-47c8-a6bf-01e74e200cf2"), null, "noodle", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("5bc4a1ed-c117-454c-856c-ea26dab74428"), null, "turkish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5c1c5e8f-6d5f-4ca2-bd1c-087ea29cf38d"), null, "danish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5c80b244-7229-47a5-86ad-da2f2da61963"), null, "asian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5cbcc5d1-d7c1-4b94-8516-ba7d0df77e95"), null, "argentinian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5e2029dd-e171-484c-87e1-02ca1c13d2fa"), null, "italian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5fea80b5-0d90-4eb2-b830-b9ca8fe6d4ab"), null, "indonesian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("616842da-f458-4b93-bbd4-a024bb018a30"), null, "coffee", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("62b78d55-5d36-4eb7-a9ad-8d10e53fd765"), null, "tex-mex", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("62bf80f5-f610-4489-b62e-99422475a86c"), null, "hot_dog", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("63de6e24-42c9-48e3-b14e-1e95b6f60f49"), null, "ramen", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("664eed32-ce6f-4325-b65e-ed037cfb5fe2"), null, "coffee_shop", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("67117fa3-d333-40c5-9257-e36853ec8f18"), null, "buddhism", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("676c4e49-cf10-4544-845f-ae7179961166"), null, "cake", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("6779f792-ac5d-48d0-87b6-430f8ae52193"), null, "brazilian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("691f025a-ea50-4c1f-801e-5822622248f8"), null, "windmill", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("6b5d23f5-6b6a-4e19-8763-ebcca7bd04f8"), null, "cuban", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("6d07bbbd-9e1a-4534-a65b-b2da9404988c"), null, "steak_house", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("6e4e3ffc-3cb6-425e-9017-73464e85dcb2"), null, "malay", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("6f69cea0-38c1-4b94-af21-b5b6d2e38096"), null, "afghan", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("6fa0f10e-64c1-47c1-98e6-c06b8d75c45c"), null, "chicken", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("702a29fb-72fb-498c-8e0e-3ec05bf5381a"), null, "noodle", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("71aa1f04-b071-439b-bd64-9463eb02ca6c"), null, "korean", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("72dd952e-756c-4db0-a522-f38a3c7844d9"), null, "soup", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("73bcf016-32bc-48cb-bb8a-061b3c07384b"), null, "garden", new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf") },
                    { new Guid("73cac96d-76ad-4228-9d6e-456b898fc47e"), null, "dumpling", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("772cf39f-b185-48f4-8809-b1854e429a6c"), null, "regional", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("777f4839-4e56-46ad-b4dd-87516a61e9e2"), null, "nepalese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("7aa1a097-be64-484b-a280-b64e87c6c22d"), null, "theatre", new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f") },
                    { new Guid("7ba18aba-c3fb-4f85-aefb-1ad064bc8322"), null, "seafood", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("7bae482d-d487-4f6d-b1a6-af6a8b6eb1be"), null, "portuguese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("7cd67dbd-211f-45af-842c-517fb143d427"), null, "rock", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("7e57978a-2a11-4416-aa2e-2fecc617bacf"), null, "sikhism", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("7e9e5b63-d9c6-4a36-bfcb-7a7247f4477f"), null, "international", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("82e4b38b-ac1c-478a-9cbd-bb99a216088a"), null, "vietnamese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("83883b63-d6e9-4f31-b9ac-1616e99e0060"), null, "castle", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("83d6c6be-0525-4dba-a607-927ed8f52d47"), null, "tea", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("85e46b8c-a538-4eb6-b1af-b68fa4c777c7"), null, "glacier", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("860501f2-bbaf-4eaf-b567-45230f5a854b"), null, "tacos", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("89d19266-7810-46ba-bcae-fd029692046e"), null, "fountain", new Guid("511b1c02-92a9-4157-8760-35b25407b752") },
                    { new Guid("8ab7915a-765b-452b-88ac-759e3e4dbd40"), null, "swedish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("8b77d44e-2e2d-4d86-8a27-f6cb5311c53c"), null, "pizza", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("8df7ecc4-0f73-49d0-a042-3a9a6473998b"), null, "lebanese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("8f04736b-88dd-4f29-8fdf-969061551261"), null, "sandwich", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("920d9df6-eeb1-45b7-93c3-6f551e96f781"), null, "pita", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("95212037-5b17-44db-b428-faac48a381c9"), null, "austrian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("9863d8b1-d870-427a-ae43-53f8e4f8d25e"), null, "mediterranean", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("99ff2070-d0d5-45d4-b1ab-5844ed17fbf1"), null, "city_hall", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("9a31b172-a604-4385-9f4b-0456f78fce45"), null, "chili", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("9b0ae92e-f413-4307-8469-4ae39763a68d"), null, "cliff", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("9b5a3108-da70-49f8-8583-d658ab9f480e"), null, "syrian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("9b78a07d-6bdd-48e1-8cba-bb2d86388973"), null, "ruines", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("9c8295ec-3c6f-4f0c-a90e-04a7246f6b2a"), null, "arts_centre", new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f") },
                    { new Guid("9e08208a-62a5-48d2-831e-0a648b21ba51"), null, "sandwich", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("9fed8c4a-a02d-49e5-a0bf-7cebd7689221"), null, "fish_and_chips", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("a27e3c60-a9b7-4063-b9fa-cbd891d89861"), null, "ice_cream", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("a2d83129-d2c3-4a30-a73e-ae1495776a56"), null, "pizza", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("a3048f41-31c5-4f9f-9ebe-113ea6a92251"), null, "barbecue", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("a65bf379-0463-4cfb-8ee4-3a416fce3227"), null, "clock", new Guid("511b1c02-92a9-4157-8760-35b25407b752") },
                    { new Guid("a8ab258d-2ed1-4549-8252-f5d095e8a25f"), null, "kebab", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("ac954a86-9eb7-4ad1-92e5-f721838a6e4a"), null, "dessert", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("ad1354ce-cf5f-409b-8e11-8e559e862546"), null, "jamaican", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("ae2b912a-1d1d-4965-9c77-8791a402532a"), null, "peruvian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("b3756827-83aa-4861-a456-2325966c1893"), null, "hungarian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("b420764f-a6d8-4400-8228-fe33ce4a2b6c"), null, "oriental", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("b9cd7bb4-7760-4c57-bbf6-5b7f33dfee2d"), null, "shinto", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), null, "memorial", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("bd9f78a2-7d71-43ca-ab8d-2c58f3cdc051"), null, "latin_american", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("bf39d4b4-76be-4344-aba5-403bfad4fe83"), null, "waffle", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("bf4b9bb2-a715-47a6-9411-a1a64fded83a"), null, "viewpoint", new Guid("511b1c02-92a9-4157-8760-35b25407b752") },
                    { new Guid("c25db3ee-36fc-4753-8118-adf025dc545e"), null, "ukrainian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("c35b7c22-2e96-4960-970a-7a1c95072b50"), null, "bolivian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("c45b3112-885e-4536-bec5-26c55eb85589"), null, "bavarian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("cef013f5-8cf0-4812-8b8b-dd89f1a5b26a"), null, "sea", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("d3ffbaa8-175e-44b5-9660-50263497edcc"), null, "burger", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("d4194cd1-2b90-4336-93d7-47a2117845ce"), null, "dune", new Guid("68b0c129-7b2a-49d0-9aeb-c6f7d7daf73a") },
                    { new Guid("d8866c2a-8e3f-4674-9a45-e7c4ffe5e821"), null, "wings", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("d9b805f8-82a3-4cc3-b09e-743c75da6b53"), null, "sushi", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("e047a8ae-b475-49f6-a1d3-0f3744fc1cba"), null, "hinduism", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("e0b5dac3-3109-4e6c-8e99-a286343f95c7"), null, "peak", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("e2fa4130-1244-4a2b-99af-0a4a55353a3b"), null, "pita", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("e3bcd580-f240-4114-9665-d3d8c6ceb391"), null, "greek", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("e76af9b6-2612-42ac-9b12-fbb40278db22"), null, "irish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("e7a4045a-44e7-4502-87b9-da4111f116dd"), null, "russian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("ecb4aa2e-f6b0-48ee-8f01-62c2a35b7a25"), null, "malaysian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("edae1a3a-7fb1-4786-9400-09fde31d49c4"), null, "persian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("ee3371ed-5ac0-47ab-8e0f-9f8104d0ee9a"), null, "hot_spring", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("efeb3f4d-2c29-4251-a4c8-a5c7aa0a28f0"), null, "tower", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("f204e07d-57c6-42cf-bf0e-8c3cb459f6d0"), null, "german", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("f4f2d192-f326-47d8-85f5-b1fc47016f3e"), null, "japanese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("f621a46b-5df6-4179-9303-3ced690aa344"), null, "judaism", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441"), null, "place_of_worship", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("f8d4b314-3bdc-46f1-9ac7-09b68a9daa2d"), null, "pakistani", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("f94992cd-8c9c-4da3-bbd0-aef3d12049ee"), null, "fish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("f9f46c35-c17f-48e2-a3b8-ecff8172daf5"), null, "tapas", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("fa7fff4a-41e7-4049-a4ce-760a9bfa7e45"), null, "mexican", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("fb6d1113-680d-41ba-a449-f09ac7c8e94f"), null, "american", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("fbaf9948-24e0-4685-b313-60d1e57740f5"), null, "bubble_tea", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("fd80e5df-397b-4b09-ae23-4f3af5306403"), null, "spanish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("fd869253-419d-4195-bed8-2e90c0eff5b8"), null, "filipino", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1"), new Guid("977c8178-9039-47ff-ad5b-98373b292abc") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") },
                    { new Guid("81cd1d0a-8eb4-42e0-9920-2c90a0ceefdb"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("e80583c1-fb35-492f-828a-45441253fc43"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("f5975d83-d5c0-457f-9e79-987e572f50bd"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCondition",
                columns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd"), new DateOnly(2024, 12, 21), new Guid("9ea3d559-e80c-455c-a7dc-ca654cc58ce7") },
                    { new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93"), new DateOnly(2024, 12, 20), new Guid("9ea3d559-e80c-455c-a7dc-ca654cc58ce7") },
                    { new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3"), new DateOnly(2024, 11, 20), new Guid("bc3e7c63-e650-4f61-88ba-c3ae17a438a9") },
                    { new Guid("9cc42d97-9d65-43ee-8ec8-df1ebf2aab6a"), new DateOnly(2025, 12, 6), new Guid("44609932-1913-412e-9682-ee17fab551a1") },
                    { new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa"), new DateOnly(2024, 11, 21), new Guid("bc3e7c63-e650-4f61-88ba-c3ae17a438a9") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("02ef024c-503c-4ac2-8b9e-f4622e38c7f6"), null, "temple", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("1c44a946-013f-4153-ae11-10d144010b53"), null, "pillory", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("1dcaa3a5-fa93-4fef-af39-3a8ae634efd0"), null, "ship", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("20f717e2-d40b-48d5-8cd7-8723779955c1"), null, "railway_car", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("3dbad5e2-f915-4a4d-98b0-b688edc3ec20"), null, "cathedral", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("4025efcf-7415-48c4-bb5c-f6225fc3e12d"), null, "locomotive", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("4a1a601c-b676-4426-8484-55eed89b78f0"), null, "boundary_stone", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("505f6152-a2ae-4f9e-a26f-0b4194fcea9a"), null, "church", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("50ec1d4e-8ce7-41ae-af51-b0a803ab3a36"), null, "tank", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("51ad71a3-f27c-42fa-82dc-7c35a4acb920"), null, "tomb", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("851873d1-0a04-4b5a-8f37-2f7ee2b42577"), null, "synagogue", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("8cfde417-44e2-443a-af48-ac4384693d29"), null, "milestone", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("a9ef90cd-d224-4016-a884-38f3241b47e1"), null, "wayside_cross", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("b1c2b6ee-4236-4f66-bb97-cafe9f9d7bac"), null, "shrine", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("b3c350f0-fe62-44b4-a956-228b24141d8f"), null, "monument", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("c3d6b494-e243-4d05-823c-a6e72a0e3928"), null, "chapel", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("d27ae70c-9ee5-4e1b-9bfc-6f8b48d2a595"), null, "aircraft", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("e740971c-54c7-474e-97ef-042891bbe916"), null, "mosque", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("0b7733ca-e3a2-4aa5-a8e0-0f18d86d0f0c"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("73bcf016-32bc-48cb-bb8a-061b3c07384b"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("89d19266-7810-46ba-bcae-fd029692046e"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("9b78a07d-6bdd-48e1-8cba-bb2d86388973"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") },
                    { new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("021389c6-d6d4-4b8a-a275-3d1d04292e97"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("be0b4d83-d85d-4ab5-bec0-d0c912a71e18"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("1b70c4cf-4bf6-4508-8011-75370c0f786a"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d"), 0m, new TimeOnly(10, 0, 0), 1, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("1c6861f9-7a1e-428d-a5b1-eb85d4838790"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("25dc4853-cf52-437a-9b99-f8b0cce72d72"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("53758522-0a17-4211-baa2-165cf08b0d2e"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("3468e2f0-f165-4cf4-a66a-58de98a44272"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("c8eb6289-5dc7-495d-873a-66cea43164a5"), 5m, new TimeOnly(16, 30, 0), 3, new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"), new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("977c8178-9039-47ff-ad5b-98373b292abc"), 30m, new TimeOnly(14, 0, 0), 3, new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("4da954c1-f554-4de5-bb03-7aac1a334fb6"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c"), 0m, new TimeOnly(11, 0, 0), 1, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("53aaf231-b2d0-40ef-a78b-a82543a5bc11"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("9a0ddf04-1fc7-40a0-99d2-a52ea24c3edb"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("54f8d7e9-c511-4830-8879-da9839da12ad"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("568ec6c8-0084-4f45-a5fd-0070cee6c48e"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("5f7a1df6-373c-4a4b-80bc-f288180def03"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("09afec0e-1382-4578-8ffd-000971cbbc19"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("783f44f9-d17d-4a30-83c4-587474792929"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("9d634ad2-089f-4031-bed6-257958eb5d5d"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2"), 0m, new TimeOnly(13, 0, 0), 1, new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("c3aa8e7d-4848-4d72-8de7-92ff3072bd28"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed"), 0m, new TimeOnly(11, 50, 0), 1, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("c58946d3-354a-4834-a602-f98b36abfe3b"), new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("977c8178-9039-47ff-ad5b-98373b292abc"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("e379fa4d-3419-45de-85d3-bfcb6ca62145"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("53758522-0a17-4211-baa2-165cf08b0d2e"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("e8d519bb-e0e4-4ece-bfe9-c0bc148183e5"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("076737d2-16b9-489c-b157-39f97aba1af2"), 0m, new TimeOnly(13, 30, 0), 2, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("fca502ae-d0ea-450f-849b-b653bf577bf8"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("aea1d075-f00d-4966-bb07-09cc2f5ddd4a"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[] { new Guid("505f6152-a2ae-4f9e-a26f-0b4194fcea9a"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "ToTripPointId", "TransferTime", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("09cb0b5d-3b36-4f28-bc20-26a1d9561205"), new Guid("c3aa8e7d-4848-4d72-8de7-92ff3072bd28"), 1, new Guid("5f7a1df6-373c-4a4b-80bc-f288180def03"), new TimeSpan(0, 0, 0, 55, 0), new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("33471b65-36ef-4e45-b65e-0b82cc328232"), new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"), 3, new Guid("3468e2f0-f165-4cf4-a66a-58de98a44272"), new TimeSpan(0, 0, 13, 30, 0), new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("416d95a7-d16b-41c7-a918-a56bd96ba51c"), new Guid("e379fa4d-3419-45de-85d3-bfcb6ca62145"), 2, new Guid("9d634ad2-089f-4031-bed6-257958eb5d5d"), new TimeSpan(0, 0, 3, 13, 0), new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("679ee69f-3983-4352-a317-29ff898de647"), new Guid("fca502ae-d0ea-450f-849b-b653bf577bf8"), null, new Guid("021389c6-d6d4-4b8a-a275-3d1d04292e97"), new TimeSpan(0, 0, 20, 0, 0), new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("b6c0088e-83eb-4ec3-bd2c-e94cd1175662"), new Guid("5f7a1df6-373c-4a4b-80bc-f288180def03"), null, new Guid("e8d519bb-e0e4-4ece-bfe9-c0bc148183e5"), new TimeSpan(0, 0, 20, 0, 0), new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("b8829d9f-b889-4c3b-86bd-82cd9d53d9c2"), new Guid("568ec6c8-0084-4f45-a5fd-0070cee6c48e"), 0, new Guid("1c6861f9-7a1e-428d-a5b1-eb85d4838790"), new TimeSpan(0, 0, 4, 21, 0), new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("c57269bb-fd4e-4ea7-93f1-b8cf99d0d419"), new Guid("4da954c1-f554-4de5-bb03-7aac1a334fb6"), 0, new Guid("c3aa8e7d-4848-4d72-8de7-92ff3072bd28"), new TimeSpan(0, 0, 4, 21, 0), new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("c72e1fde-4425-40ca-a465-892650635787"), new Guid("9d634ad2-089f-4031-bed6-257958eb5d5d"), 3, new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"), new TimeSpan(0, 0, 8, 18, 0), new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("de2538d8-bb9b-4e71-96f8-d624510527c5"), new Guid("c58946d3-354a-4834-a602-f98b36abfe3b"), 3, new Guid("53aaf231-b2d0-40ef-a78b-a82543a5bc11"), new TimeSpan(0, 0, 13, 30, 0), new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("e8d7055f-08bc-42d7-b6e2-bc3768f6cc2f"), new Guid("1c6861f9-7a1e-428d-a5b1-eb85d4838790"), 1, new Guid("fca502ae-d0ea-450f-849b-b653bf577bf8"), new TimeSpan(0, 0, 0, 55, 0), new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("f07bfe27-358f-4189-a251-9f9f6113499e"), new Guid("25dc4853-cf52-437a-9b99-f8b0cce72d72"), 2, new Guid("54f8d7e9-c511-4830-8879-da9839da12ad"), new TimeSpan(0, 0, 3, 13, 0), new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("f26cac79-8bbf-4867-a60c-1c72fea085bc"), new Guid("54f8d7e9-c511-4830-8879-da9839da12ad"), 3, new Guid("c58946d3-354a-4834-a602-f98b36abfe3b"), new TimeSpan(0, 0, 8, 18, 0), new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") }
                });

            migrationBuilder.InsertData(
                table: "TripPointReviews",
                columns: new[] { "Id", "ActualCostPerPerson", "ActualTimeSpent", "CurrencyCode", "ExchangeRate", "PlaceId", "Rating", "TripPointId", "UserId" },
                values: new object[,]
                {
                    { new Guid("400db1c9-1a82-4447-b610-a53b83b34bcb"), 10m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("c8eb6289-5dc7-495d-873a-66cea43164a5"), 4.5m, new Guid("3468e2f0-f165-4cf4-a66a-58de98a44272"), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("6180b39d-9a99-4546-81fe-c393efbb30eb"), 40m, new TimeSpan(0, 1, 0, 0, 0), "PLN", 1m, new Guid("977c8178-9039-47ff-ad5b-98373b292abc"), 5m, new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") });

            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") });

            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3") });

            migrationBuilder.DeleteData(
                table: "ConditionProfilePlaceCondition",
                keyColumns: new[] { "ConditionProfileId", "PlaceConditionId" },
                keyValues: new object[] { new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"), new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f") });

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0126b355-6f1d-4d65-baa4-df9f725656d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0168dfdd-b23f-474f-9bcf-a435ddba8cb9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("01c5086c-1e1d-4804-9b0b-ae9b18ad8807"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("01ce27ed-3189-42ef-816c-e64b963f2fa0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("02ef024c-503c-4ac2-8b9e-f4622e38c7f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("046b33d9-8b9c-4ef1-8e76-02232bceb9d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("055e9136-7904-4b2f-9f2c-e9fc0b65a094"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("065c53eb-a19f-46cd-b0fb-7e165b17b64d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("07fd6909-b4e5-4fb1-b307-d7fe7141e8a5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08cc3914-f217-47b0-9a60-848f002837c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08cf52df-3bf6-499b-96b5-54f4d8d8e2f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b13c9c2-d128-44f8-9186-f6a9de63318e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0ba72609-b79f-44e4-8380-26c041a93053"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c2b9ca9-59b7-4502-a6d8-ca12d88946d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c37c56a-7eab-41d5-97cb-393558c6654d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cf3fa9d-cf26-4cb2-a77c-5c250ca16d7a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f4534ff-4f24-4f7d-8474-6f686a4b77e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1056f1f8-8cf2-4523-8553-28e631d52fec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("116c209a-c3e2-4f55-bc8a-39b2f70ebc03"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("117503b7-014f-4c85-950e-68140b86a670"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("11f382c1-9019-43ca-a323-40ffcb4846f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12ad7960-6fd4-47b6-8b40-d4d3e0130a5f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13bfd3dc-abb6-4f9e-9df1-622be15faa64"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("15af10de-7037-409e-9970-94f0a77377cb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("16cad34c-5dce-4710-819a-530da999b184"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17c05f8b-ce87-40bb-bf5c-d254a67c8558"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17f85471-d607-4fdb-ae84-5076dc9f32bd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18e97a14-3ca6-430a-adee-395a9bb0a157"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a55c164-2126-4bfc-99a7-32905023c89e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b995dc2-5f5f-4d95-baec-c36b638bc2a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c44a946-013f-4153-ae11-10d144010b53"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d2725bd-c96a-4a10-917c-0dc8af9e4768"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1dcaa3a5-fa93-4fef-af39-3a8ae634efd0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20edc26f-539b-430c-a5f8-e74a4c152655"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20f717e2-d40b-48d5-8cd7-8723779955c1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("25451861-2605-43b8-a19e-8335ca4e013f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("26a70dbb-9fe6-4c31-88aa-9c9175a64c36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28184ebf-d6b3-4c24-a0a4-cceafb897086"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28d9bfb8-cc35-4529-9335-f215d4c9199f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2edb7842-63c3-47b2-a134-2e36078c45ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("321ab057-22a7-47fc-ac72-8464c2c8d96b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("36f50eca-a3cc-4f23-a4f4-b457f6e2f705"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38590d77-ae64-447f-82ad-4e497c23afc3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38aaae4c-c1f9-43fd-b695-908ace5fc2bd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38ab4808-e9b4-475b-8f4f-efb5b307ceea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c422a5d-31be-4803-a24f-c4beea2638ba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d984a1c-2297-4bc9-96c8-aedcca0939ac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3dbad5e2-f915-4a4d-98b0-b688edc3ec20"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4025efcf-7415-48c4-bb5c-f6225fc3e12d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("419eced0-4518-4220-90f3-6863accf4f9e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41ae3a96-7efd-4789-846d-28527d28977e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4363b2af-5f65-42ca-931a-4a5050d7491c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("46cd0446-ab4a-40c5-9318-b7232adeda52"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a1a601c-b676-4426-8484-55eed89b78f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a280d10-e352-4d8b-9bc5-43feb1b4fe72"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a77bc45-b094-4ad0-b6c4-41c15b44b600"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4acf6e56-4121-4371-a799-6a910119cfd1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b2c8d4f-1c96-44e6-950c-e2cdb2a2f71f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cf4196d-43d4-443b-a3e9-c9005d2d80a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4df95354-121a-4f30-9947-271c60f6de30"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4e565498-7b82-4a9f-aad8-2c1e0bc8d9b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("50ec1d4e-8ce7-41ae-af51-b0a803ab3a36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51ad71a3-f27c-42fa-82dc-7c35a4acb920"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("55367cdc-ed3f-4a79-bcff-a990ac590ddd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("56225a55-c6dd-47c8-a6bf-01e74e200cf2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5bc4a1ed-c117-454c-856c-ea26dab74428"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c1c5e8f-6d5f-4ca2-bd1c-087ea29cf38d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c80b244-7229-47a5-86ad-da2f2da61963"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5cbcc5d1-d7c1-4b94-8516-ba7d0df77e95"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e2029dd-e171-484c-87e1-02ca1c13d2fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5fea80b5-0d90-4eb2-b830-b9ca8fe6d4ab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("616842da-f458-4b93-bbd4-a024bb018a30"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62b78d55-5d36-4eb7-a9ad-8d10e53fd765"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62bf80f5-f610-4489-b62e-99422475a86c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("63de6e24-42c9-48e3-b14e-1e95b6f60f49"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("664eed32-ce6f-4325-b65e-ed037cfb5fe2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("67117fa3-d333-40c5-9257-e36853ec8f18"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("676c4e49-cf10-4544-845f-ae7179961166"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6779f792-ac5d-48d0-87b6-430f8ae52193"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("691f025a-ea50-4c1f-801e-5822622248f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69282965-78a1-4163-a28a-7c330b688c34"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69f51b64-8e50-4f68-ae19-f8bbbc33aef0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b5d23f5-6b6a-4e19-8763-ebcca7bd04f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d07bbbd-9e1a-4534-a65b-b2da9404988c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e4e3ffc-3cb6-425e-9017-73464e85dcb2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f69cea0-38c1-4b94-af21-b5b6d2e38096"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fa0f10e-64c1-47c1-98e6-c06b8d75c45c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("702a29fb-72fb-498c-8e0e-3ec05bf5381a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("71aa1f04-b071-439b-bd64-9463eb02ca6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("72dd952e-756c-4db0-a522-f38a3c7844d9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73cac96d-76ad-4228-9d6e-456b898fc47e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("74ed3423-a4c4-4b63-a1d0-2acc15c2689b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("772cf39f-b185-48f4-8809-b1854e429a6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("777f4839-4e56-46ad-b4dd-87516a61e9e2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7aa1a097-be64-484b-a280-b64e87c6c22d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ba18aba-c3fb-4f85-aefb-1ad064bc8322"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bae482d-d487-4f6d-b1a6-af6a8b6eb1be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7cd67dbd-211f-45af-842c-517fb143d427"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e57978a-2a11-4416-aa2e-2fecc617bacf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e9e5b63-d9c6-4a36-bfcb-7a7247f4477f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("824a9051-cb95-46d5-8995-5420a6af3fae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82e4b38b-ac1c-478a-9cbd-bb99a216088a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83883b63-d6e9-4f31-b9ac-1616e99e0060"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83d6c6be-0525-4dba-a607-927ed8f52d47"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("851873d1-0a04-4b5a-8f37-2f7ee2b42577"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("85e46b8c-a538-4eb6-b1af-b68fa4c777c7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("860501f2-bbaf-4eaf-b567-45230f5a854b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ab7915a-765b-452b-88ac-759e3e4dbd40"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b77d44e-2e2d-4d86-8a27-f6cb5311c53c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8cfde417-44e2-443a-af48-ac4384693d29"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8df7ecc4-0f73-49d0-a042-3a9a6473998b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f04736b-88dd-4f29-8fdf-969061551261"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("920d9df6-eeb1-45b7-93c3-6f551e96f781"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("95212037-5b17-44db-b428-faac48a381c9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9863d8b1-d870-427a-ae43-53f8e4f8d25e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("99ff2070-d0d5-45d4-b1ab-5844ed17fbf1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a31b172-a604-4385-9f4b-0456f78fce45"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b0ae92e-f413-4307-8469-4ae39763a68d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b5a3108-da70-49f8-8583-d658ab9f480e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c8295ec-3c6f-4f0c-a90e-04a7246f6b2a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e08208a-62a5-48d2-831e-0a648b21ba51"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9fed8c4a-a02d-49e5-a0bf-7cebd7689221"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a14d0b28-a448-414d-acfc-7037c12906c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a27e3c60-a9b7-4063-b9fa-cbd891d89861"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2d83129-d2c3-4a30-a73e-ae1495776a56"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2fa84cc-b2e9-40da-9ecd-110717b4433b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3048f41-31c5-4f9f-9ebe-113ea6a92251"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a65bf379-0463-4cfb-8ee4-3a416fce3227"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8ab258d-2ed1-4549-8252-f5d095e8a25f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9ef90cd-d224-4016-a884-38f3241b47e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac954a86-9eb7-4ad1-92e5-f721838a6e4a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad1354ce-cf5f-409b-8e11-8e559e862546"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae2b912a-1d1d-4965-9c77-8791a402532a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b1c2b6ee-4236-4f66-bb97-cafe9f9d7bac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3756827-83aa-4861-a456-2325966c1893"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3c350f0-fe62-44b4-a956-228b24141d8f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b420764f-a6d8-4400-8228-fe33ce4a2b6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b9cd7bb4-7760-4c57-bbf6-5b7f33dfee2d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bbda8310-c9a6-4a0e-a44b-93aad421895e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd9f78a2-7d71-43ca-ab8d-2c58f3cdc051"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf39d4b4-76be-4344-aba5-403bfad4fe83"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf4b9bb2-a715-47a6-9411-a1a64fded83a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0e1751b-701d-45d3-a8d7-a3cf86dd4149"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c25db3ee-36fc-4753-8118-adf025dc545e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c35b7c22-2e96-4960-970a-7a1c95072b50"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3d6b494-e243-4d05-823c-a6e72a0e3928"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c45b3112-885e-4536-bec5-26c55eb85589"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cef013f5-8cf0-4812-8b8b-dd89f1a5b26a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d27ae70c-9ee5-4e1b-9bfc-6f8b48d2a595"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d3ffbaa8-175e-44b5-9660-50263497edcc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d4194cd1-2b90-4336-93d7-47a2117845ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8866c2a-8e3f-4674-9a45-e7c4ffe5e821"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9b805f8-82a3-4cc3-b09e-743c75da6b53"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("da2a75c1-f704-470b-a7e3-e2e83a5715d9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e047a8ae-b475-49f6-a1d3-0f3744fc1cba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0b5dac3-3109-4e6c-8e99-a286343f95c7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2fa4130-1244-4a2b-99af-0a4a55353a3b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3bcd580-f240-4114-9665-d3d8c6ceb391"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e740971c-54c7-474e-97ef-042891bbe916"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e76af9b6-2612-42ac-9b12-fbb40278db22"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7a4045a-44e7-4502-87b9-da4111f116dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e99d71b0-5e47-4b97-85d2-88b29e7ad9f4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ecb4aa2e-f6b0-48ee-8f01-62c2a35b7a25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("edae1a3a-7fb1-4786-9400-09fde31d49c4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee3371ed-5ac0-47ab-8e0f-9f8104d0ee9a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("efeb3f4d-2c29-4251-a4c8-a5c7aa0a28f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f204e07d-57c6-42cf-bf0e-8c3cb459f6d0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4f2d192-f326-47d8-85f5-b1fc47016f3e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f621a46b-5df6-4179-9303-3ced690aa344"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8d4b314-3bdc-46f1-9ac7-09b68a9daa2d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f94992cd-8c9c-4da3-bbd0-aef3d12049ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9f46c35-c17f-48e2-a3b8-ecff8172daf5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa7fff4a-41e7-4049-a4ce-760a9bfa7e45"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb6d1113-680d-41ba-a449-f09ac7c8e94f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fbaf9948-24e0-4685-b313-60d1e57740f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd80e5df-397b-4b09-ae23-4f3af5306403"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd869253-419d-4195-bed8-2e90c0eff5b8"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1ce23c66-1b40-4f22-b02f-6609aa59d24d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2252e854-7c22-41d8-85ca-859d2a716b54"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3837d52a-adb1-4c86-ab1c-3ad79dd19c86"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("41db4974-d535-4d5c-8733-09ddea0c34cb"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4b8f3174-fc4e-4896-8b7d-3783319e027b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("61dffa8a-3270-486a-b628-2392a41b27c5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("65c4d2b2-e6a7-4c66-8249-94d8f7463539"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("822a74ae-7e39-4bb8-8cd2-39fc729e59ad"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8bb82328-5dbf-414e-bcdc-c22aeefca54c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c1db5cb5-25ef-4286-bc20-b602eeb18b6b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c73a511c-fca8-40f0-b39b-021d0440cafb"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d3ad5bdd-0ec0-47f1-9530-341f255cb427"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d3f9041e-420f-4ee1-a267-837b8baeb63f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d5629a3f-e5ac-4687-967e-ad3ad69787df"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d88cdd99-2402-4ba4-a1f4-b05f9a75d1b5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ed1ab986-6da8-4a11-a229-107baf578281"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("edad88d7-3158-4ad5-9cc8-f01304b5ed06"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f1e67864-3da2-4172-b4dd-7d57bc0083d6"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0b7733ca-e3a2-4aa5-a8e0-0f18d86d0f0c"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1"), new Guid("977c8178-9039-47ff-ad5b-98373b292abc") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("505f6152-a2ae-4f9e-a26f-0b4194fcea9a"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("73bcf016-32bc-48cb-bb8a-061b3c07384b"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("81cd1d0a-8eb4-42e0-9920-2c90a0ceefdb"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("89d19266-7810-46ba-bcae-fd029692046e"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("9b78a07d-6bdd-48e1-8cba-bb2d86388973"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe"), new Guid("977c8178-9039-47ff-ad5b-98373b292abc") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e80583c1-fb35-492f-828a-45441253fc43"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f5975d83-d5c0-457f-9e79-987e572f50bd"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("09cb0b5d-3b36-4f28-bc20-26a1d9561205"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("33471b65-36ef-4e45-b65e-0b82cc328232"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("416d95a7-d16b-41c7-a918-a56bd96ba51c"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("679ee69f-3983-4352-a317-29ff898de647"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("b6c0088e-83eb-4ec3-bd2c-e94cd1175662"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("b8829d9f-b889-4c3b-86bd-82cd9d53d9c2"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("c57269bb-fd4e-4ea7-93f1-b8cf99d0d419"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("c72e1fde-4425-40ca-a465-892650635787"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("de2538d8-bb9b-4e71-96f8-d624510527c5"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("e8d7055f-08bc-42d7-b6e2-bc3768f6cc2f"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("f07bfe27-358f-4189-a251-9f9f6113499e"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("f26cac79-8bbf-4867-a60c-1c72fea085bc"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("9cc42d97-9d65-43ee-8ec8-df1ebf2aab6a"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("00a97dea-1347-44a7-acf2-16e8956d43d2"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("193b8039-c7a4-48de-a3a3-a0d2351a3654"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("2054631d-b31c-4038-ba13-0e2f231a29c4"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("28a809c3-2991-476b-965b-541c9cd80c27"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("2bef4837-2fe9-4937-bb96-e13007a35a74"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("30babcf1-0e4c-4e80-a0a8-e9bf3c3fd211"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("30f9b4a8-3829-46fa-980e-9860e3aa6022"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("3a50037a-02ba-4ad1-8a48-66e499e6c729"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("400db1c9-1a82-4447-b610-a53b83b34bcb"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("40cb2e38-bb8d-46f2-98b6-4f1c74dcdb48"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("49090605-1fa0-45d9-9a11-472bd5482619"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("6180b39d-9a99-4546-81fe-c393efbb30eb"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("80f18f18-b4b5-4b91-919e-c77ea3b117a9"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("9978502b-a95d-4a61-af6e-122b0a1f7aff"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("afe43f25-0e27-442f-a357-35279fdad74c"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("b94c6142-70d9-4dff-96cc-6da6f6c2c5a5"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("c5e43721-9435-4bc7-9ca6-ab0bd1d194c8"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("c7ca1758-6264-40b6-9b61-58f0cf86ebc2"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("c8997bd5-e449-4d01-96e0-758eae15aa28"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("d069a5c7-3f6c-48dd-8a7f-fb7538a157ba"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("d723542b-2c5a-4a60-9dcf-0fbdac053fa6"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("f4559608-4d94-4790-bd6f-281a38a91461"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("1b70c4cf-4bf6-4508-8011-75370c0f786a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("783f44f9-d17d-4a30-83c4-587474792929"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b7733ca-e3a2-4aa5-a8e0-0f18d86d0f0c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("195c2f29-6a95-4da5-8637-f05892583cb0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("300a9809-d88a-47ef-b14e-8a9a6db5dc6b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("505f6152-a2ae-4f9e-a26f-0b4194fcea9a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("68b0c129-7b2a-49d0-9aeb-c6f7d7daf73a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73bcf016-32bc-48cb-bb8a-061b3c07384b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("81cd1d0a-8eb4-42e0-9920-2c90a0ceefdb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("89d19266-7810-46ba-bcae-fd029692046e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b78a07d-6bdd-48e1-8cba-bb2d86388973"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("af0d7109-d550-4537-8b51-affb642297b2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("af8af887-2e25-4edf-86ca-c54430573908"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e80583c1-fb35-492f-828a-45441253fc43"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5975d83-d5c0-457f-9e79-987e572f50bd"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("054c1e5d-2f56-4fb2-8617-310e9ff3855b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2651ead4-0c97-4141-b622-39fb1b8cce8e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("30788876-73cf-4fed-98b4-dc4e83bcb2b5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4b449869-57d0-4fe4-9f2b-676402d89967"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("64738042-1334-4889-b98f-09e6e4f257db"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("77cc2cc5-7c56-4690-8689-f3ef38d0614b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7875ec0e-799f-4abf-b519-70656bc18167"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("937b2203-3282-4abf-b885-8ce74231d594"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b0011601-c240-4508-8cec-e6a35bf0e863"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("de1385b2-ffee-4562-b818-759a4ecf6250"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("07989400-6725-4976-a1ec-77ca23b74255"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("1c6cc576-778a-4808-954c-c046472c7036"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("1e70f971-a497-42c8-a563-23a68447418e"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("f282d667-d800-4009-9e50-8e8f3cf67113"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("021389c6-d6d4-4b8a-a275-3d1d04292e97"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("1c6861f9-7a1e-428d-a5b1-eb85d4838790"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("25dc4853-cf52-437a-9b99-f8b0cce72d72"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("3468e2f0-f165-4cf4-a66a-58de98a44272"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("4da954c1-f554-4de5-bb03-7aac1a334fb6"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("53aaf231-b2d0-40ef-a78b-a82543a5bc11"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("54f8d7e9-c511-4830-8879-da9839da12ad"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("568ec6c8-0084-4f45-a5fd-0070cee6c48e"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("5f7a1df6-373c-4a4b-80bc-f288180def03"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("9d634ad2-089f-4031-bed6-257958eb5d5d"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("c3aa8e7d-4848-4d72-8de7-92ff3072bd28"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("c58946d3-354a-4834-a602-f98b36abfe3b"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("e379fa4d-3419-45de-85d3-bfcb6ca62145"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("e8d519bb-e0e4-4ece-bfe9-c0bc148183e5"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("fca502ae-d0ea-450f-849b-b653bf577bf8"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("44609932-1913-412e-9682-ee17fab551a1"));

            migrationBuilder.DeleteData(
                table: "CategoryProfiles",
                keyColumn: "Id",
                keyValue: new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"));

            migrationBuilder.DeleteData(
                table: "ConditionProfiles",
                keyColumn: "Id",
                keyValue: new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("511b1c02-92a9-4157-8760-35b25407b752"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5865a59f-ff2c-40b4-ad5a-e4eee77b2f7e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fde4d999-7fb1-4862-aaca-9bfe5581c296"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("076737d2-16b9-489c-b157-39f97aba1af2"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("09afec0e-1382-4578-8ffd-000971cbbc19"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("32a817b9-6d03-4311-807b-d3d993feaca5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("53758522-0a17-4211-baa2-165cf08b0d2e"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("977c8178-9039-47ff-ad5b-98373b292abc"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("9a0ddf04-1fc7-40a0-99d2-a52ea24c3edb"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("aea1d075-f00d-4966-bb07-09cc2f5ddd4a"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("be0b4d83-d85d-4ab5-bec0-d0c912a71e18"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c8eb6289-5dc7-495d-873a-66cea43164a5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("9ea3d559-e80c-455c-a7dc-ca654cc58ce7"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("bc3e7c63-e650-4f61-88ba-c3ae17a438a9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("da044dbf-0f05-493d-a498-27156beeca18"));

            migrationBuilder.InsertData(
                table: "CategoryProfiles",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"), "Podstawowy", "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "ConditionProfiles",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { new Guid("1b425c65-ee8f-46d8-b37e-1e514451d927"), "Podstawowy", "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0ce596f3-91ab-4cda-8808-701abc0ca0f8"), null, "national park", null },
                    { new Guid("0f74eef1-4110-4b4a-abec-8ff947098939"), null, "natural", null },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), null, "tourism", null },
                    { new Guid("293f18bf-cd8e-4ddb-8bac-8e5f0cbd5433"), null, "commercial", null },
                    { new Guid("5be71326-55f0-425a-9ed5-4c4914ea8127"), null, "sport", null },
                    { new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5"), null, "catering", null },
                    { new Guid("78da8bcc-1884-48a9-9f9c-e1b623527dac"), null, "religion", null },
                    { new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf"), null, "heritage", null },
                    { new Guid("adba8806-f6f6-4272-989c-150a6d7302f8"), null, "leisure", null },
                    { new Guid("bf8a178a-51b3-48e8-ad25-96cb714ceb66"), null, "activity", null },
                    { new Guid("e31f428f-7167-4a01-b745-acf66e0107b7"), null, "entertainment", null },
                    { new Guid("f0cade80-cd26-423e-b425-f4fc9722cef4"), null, "other", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("092b017b-6f0b-4874-b010-800b68fd6e81"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("15ff4c45-37a7-4289-a98d-19f859042b26"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("1c477f6e-e788-48f3-87fd-14ba1c961c16"), null, "dogs", null },
                    { new Guid("369ff98a-9183-42df-b62c-8ab140ab25c6"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), null, "wheelchair", null },
                    { new Guid("5114e882-e864-4d41-9a93-e84bbb05e7d5"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("65285dd2-2c7a-4ce5-8fb2-e9478572c9a5"), null, "access_limited", null },
                    { new Guid("72405b60-b0d2-4e6c-9a70-ffc10f344e01"), null, "access", null },
                    { new Guid("73412bf4-6d67-49a7-85c2-6348b56fe3ab"), null, "no-dogs", null },
                    { new Guid("77b84d7e-738b-4f73-8b6d-213a2fcf38de"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("7be31568-2a9a-4a05-ad11-2083940795dc"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("7e868179-cf43-45e4-99ca-e184b8bfcd57"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("8cf878aa-c0c2-4e76-8096-8b366b6d3668"), "Name property defined for the place", "named", null },
                    { new Guid("bd22d9d2-4220-4bdf-9313-45743ee54630"), null, "internet_access", null },
                    { new Guid("d4d8f27a-68ac-45a5-9c8e-b35b406365ee"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("d4ffa7c0-ce42-4bc3-a9bd-d7710eeb3dbf"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("d5203bb8-6c82-4017-a03a-58227d5bd42e"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("efb33e83-9578-4468-9daf-7132d56aae28"), null, "fee", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f"), "Wrocław", "Poland", null, 51.10864425m, 17.07875630m, "Wrocławska Fontanna", "May-Oct: 00:00-24:00; Nov-Apr: Off", "ProviderPlace", "51299d5f5f291431405946ac040ee88d4940f00102f901e25aa7020000000092031457726f63c5826177736b6120466f6e74616e6e61", "Lower Silesian Voivodeship", null },
                    { new Guid("28f5fd03-da9d-4c53-97bf-a40805391098"), "Wrocław", "Poland", "35", 51.10744710m, 17.02887780m, "Muzeum Historyczne i Muzeum Sztuki Medalierskiej", "We-Sa 11:00-17:00; Su 10:00-18:00", "ProviderPlace", "51979416896407314059ca9f98d3c08d4940f00103f9010992932b020000009203304d757a65756d20486973746f7279637a6e652069204d757a65756d20537a74756b69204d6564616c696572736b69656a", "Lower Silesian Voivodeship", "Kazimierza Wielkiego" },
                    { new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null },
                    { new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da"), "Wrocław", "Poland", null, 51.10248345m, 17.08599881m, "Kościół Najświętszej Maryi Panny Matki Pocieszenia", null, "ProviderPlace", "51324592040416314059a36a7b2d1e8d4940f00102f9010d300706000000009203374b6fc59b6369c3b3c582204e616ac59b7769c49974737a656a204d617279692050616e6e79204d61746b6920506f636965737a656e6961", "Lower Silesian Voivodeship", "Edwarda Wittiga" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("319d3a58-6a5f-4d90-a76b-1d8ea0c5b721"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("48ab2470-71c9-4959-95d8-b824edc58512"), "Wrocław", "Poland", null, 51.10897760m, 17.03266890m, "Wrocław", null, "ProviderPlace", "51dfc081e697fa30405906310a6025904940f00101f901bce3060000000000c0020992030857726f63c5826177", "Lower Silesian Voivodeship", null },
                    { new Guid("5760d083-919c-430a-9a26-59728233d777"), "Wrocław", "Poland", "1-5", 51.10425535m, 17.07484842m, "ZOO Wrocław", "Mar: Mo-Su 09:00-16:00; Apr-Sep: Mo-Fr 09:00-17:00; Apr-Sep: Sa,Su,PH 09:00-18:00; Oct: Mo-Su 09:00-16:00; Nov-Feb: Mo-Su 09:00-15:00", "ProviderPlace", "513a952f4429133140591ab1413d588d4940f00102f901012324020000000092030c5a4f4f2057726f63c5826177", "Lower Silesian Voivodeship", "Zygmunta Wróblewskiego" },
                    { new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("58418c2f-1ee2-4164-8b8b-1f768323c8e5"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738"), "Wrocław", "Poland", null, 51.10957585m, 17.03206577m, "Ratusz", "We-Sa 10:00-17:00; Su 10:00-18:00", "ProviderPlace", "51b849627635083140596870d894068e4940f00102f90138ce3f330000000092030652617475737a", "Lower Silesian Voivodeship", "Rynek Ratusz" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("6e337722-b020-407d-b666-7a2aa9631ffc"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" },
                    { new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c"), "Wrocław", "Poland", null, 51.10994465m, 17.07986499m, "Ogród Japoński", "Apr-Oct: Mo-Su,PH 09:00-19:00", "ProviderPlace", "51d8ce250872143140598b6890aa128e4940f00102f9014c34de0f000000009203104f6772c3b364204a61706fc584736b69", "Lower Silesian Voivodeship", "aleja Dąbska" },
                    { new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86"), "Wrocław", "Poland", "9", 51.11288660m, 17.02688220m, "Muzeum Archeologiczne", "We-Sa 11:00-17:00; Su 10:00-18:00", "ProviderPlace", "5133d879c0e106314059f2ec6d11738e4940f00103f901710a264c000000009203154d757a65756d2041726368656f6c6f6769637a6e65", "Lower Silesian Voivodeship", "Antoniego Cieszyńskiego" },
                    { new Guid("98adcdcf-8359-4974-a02d-4192f628c107"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("ab644f74-ab99-4a17-bb4a-a3d9d712fb93"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null },
                    { new Guid("b362daaa-9821-4360-8758-c715ab7b01b5"), "Wrocław", "Poland", "1", 51.10688750m, 17.07731849m, "Hala Stulecia", "Su-Th 09:00-18:00; Fr-Sa 09:00-19:00", "ProviderPlace", "5159f5f324cb1331405964c6547dae8d4940f00102f90136e6691c0000000092030d48616c61205374756c65636961", "Lower Silesian Voivodeship", "Wystawowa" },
                    { new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("be6fd349-e7cf-40bd-a9a2-ce7cb6e21527"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864"), "Wrocław", "Poland", null, 51.10432090m, 17.03133350m, "Bolesław Chrobry", "24/7", "ProviderPlace", "51eac4e5780508314059b43e21635a8d4940f00103f901ace8111000000000920311426f6c6573c5826177204368726f627279", "Lower Silesian Voivodeship", null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("e30bc546-3e22-42a4-b974-ef70f54ac812"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null },
                    { new Guid("e3310633-abf3-4f85-95d3-ae8ca5bc683d"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632"), null, null, null, null, null, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", null, null });

            migrationBuilder.InsertData(
                table: "CategoryProfilePlaceCategory",
                columns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                values: new object[,]
                {
                    { new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"), new Guid("0f74eef1-4110-4b4a-abec-8ff947098939") },
                    { new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"), new Guid("27b30454-141a-459b-ab00-86517c816b74") },
                    { new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"), new Guid("e31f428f-7167-4a01-b745-acf66e0107b7") }
                });

            migrationBuilder.InsertData(
                table: "ConditionProfilePlaceCondition",
                columns: new[] { "ConditionProfileId", "PlaceConditionId" },
                values: new object[] { new Guid("1b425c65-ee8f-46d8-b37e-1e514451d927"), new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b") });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("05276e93-6021-4ad9-a8da-532781ecd32d"), null, "park", new Guid("adba8806-f6f6-4272-989c-150a6d7302f8") },
                    { new Guid("0f7e26d3-cb7b-4aef-8e9a-31ca73ded383"), null, "forest", new Guid("0f74eef1-4110-4b4a-abec-8ff947098939") },
                    { new Guid("14c9a9ee-8ed5-4972-8b6e-162ce00966fb"), null, "bar", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("1698ebc5-6d50-439a-bfb2-640f26e1855a"), null, "food_court", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("175dc111-3b63-4d71-af4b-7e7fa96f6fb0"), null, "ice_cream", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("206bf6d8-af1f-4502-8d3a-ce9a365be63f"), null, "mountain", new Guid("0f74eef1-4110-4b4a-abec-8ff947098939") },
                    { new Guid("2a7f718d-698c-4e7b-ad0a-588ac9fad47d"), null, "aquarium", new Guid("e31f428f-7167-4a01-b745-acf66e0107b7") },
                    { new Guid("4748a6e0-c990-403b-b7ae-2e694a27a9ca"), null, "zoo", new Guid("e31f428f-7167-4a01-b745-acf66e0107b7") },
                    { new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984"), null, "cafe", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), null, "attraction", new Guid("27b30454-141a-459b-ab00-86517c816b74") },
                    { new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281"), null, "water", new Guid("0f74eef1-4110-4b4a-abec-8ff947098939") },
                    { new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7"), null, "fast_food", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657"), null, "restaurant", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("7b0a7d77-e962-4b97-bda6-8bee0c33835c"), null, "biergarten", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("7e95be59-7ec1-4c26-84bf-85c2bac56c6c"), null, "art", new Guid("293f18bf-cd8e-4ddb-8bac-8e5f0cbd5433") },
                    { new Guid("90be597f-c6e5-4c6b-99b2-79eac52e0156"), null, "culture", new Guid("e31f428f-7167-4a01-b745-acf66e0107b7") },
                    { new Guid("a14ef430-b63c-4795-a928-40bb1edcc6c2"), null, "stadium", new Guid("5be71326-55f0-425a-9ed5-4c4914ea8127") },
                    { new Guid("ac27e10c-1e8f-4046-bfb0-b936589a1a5e"), null, "sand", new Guid("0f74eef1-4110-4b4a-abec-8ff947098939") },
                    { new Guid("b183e34c-7599-4373-8637-6fb5a42c7c10"), null, "unesco", new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf") },
                    { new Guid("b1f9e0b7-d62f-491f-a5bd-c246fca4a076"), null, "planetarium", new Guid("e31f428f-7167-4a01-b745-acf66e0107b7") },
                    { new Guid("b812a63e-493c-4647-b072-8e81df71491e"), null, "taproom", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8"), null, "place_of_worship", new Guid("78da8bcc-1884-48a9-9f9c-e1b623527dac") },
                    { new Guid("d98c5384-e2cb-41ee-b8a7-650bc047b165"), null, "pub", new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5") },
                    { new Guid("eb26cdc5-694f-48af-845f-dc190c129cbb"), null, "gift_and_souvenir", new Guid("293f18bf-cd8e-4ddb-8bac-8e5f0cbd5433") },
                    { new Guid("f3e1bd5e-adf6-47b0-8fa0-9606d3cdce79"), null, "museum", new Guid("e31f428f-7167-4a01-b745-acf66e0107b7") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), null, "sights", new Guid("27b30454-141a-459b-ab00-86517c816b74") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("052cfb94-2fad-404a-8899-5395f82c82c9"), null, "customers", new Guid("65285dd2-2c7a-4ce5-8fb2-e9478572c9a5") },
                    { new Guid("10b73c51-6e68-4c23-8f47-ccca2e9c329d"), null, "not_specified", new Guid("d5203bb8-6c82-4017-a03a-58227d5bd42e") },
                    { new Guid("48c5d761-a7c7-452f-844a-5b019c2911b1"), null, "only", new Guid("15ff4c45-37a7-4289-a98d-19f859042b26") },
                    { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), "Places that are available for public", "yes", new Guid("72405b60-b0d2-4e6c-9a70-ffc10f344e01") },
                    { new Guid("6eb7c79f-efcd-4315-a363-47ad1e51aaf1"), null, "no", new Guid("d5203bb8-6c82-4017-a03a-58227d5bd42e") },
                    { new Guid("7317f08a-783f-421c-94f8-77b9a7f25134"), null, "not_specified", new Guid("72405b60-b0d2-4e6c-9a70-ffc10f344e01") },
                    { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), null, "yes", new Guid("1c477f6e-e788-48f3-87fd-14ba1c961c16") },
                    { new Guid("9edca647-f39c-4de0-b414-2882020c11e9"), null, "only", new Guid("369ff98a-9183-42df-b62c-8ab140ab25c6") },
                    { new Guid("afae5768-472b-49ca-be13-c1965ff86efe"), null, "leashed", new Guid("1c477f6e-e788-48f3-87fd-14ba1c961c16") },
                    { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), null, "yes", new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b") },
                    { new Guid("bcabf666-4264-4e6f-ac21-a92952533dd5"), null, "free", new Guid("bd22d9d2-4220-4bdf-9313-45743ee54630") },
                    { new Guid("bd6a6106-c6a0-420a-9d26-f821c1d5401a"), null, "only", new Guid("5114e882-e864-4d41-9a93-e84bbb05e7d5") },
                    { new Guid("c979e365-7f55-42ab-af48-0446fb979b0f"), null, "limited", new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b") },
                    { new Guid("fc8d0ab9-7e5f-4096-9f40-42a6599200a3"), null, "only", new Guid("7be31568-2a9a-4a05-ad11-2083940795dc") },
                    { new Guid("fddd1caf-cbaf-4ff1-a193-884d379b3da1"), null, "for_customers", new Guid("bd22d9d2-4220-4bdf-9313-45743ee54630") },
                    { new Guid("ffab9981-19e5-4430-b31f-8855e6f619f7"), null, "only", new Guid("092b017b-6f0b-4874-b010-800b68fd6e81") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("0f74eef1-4110-4b4a-abec-8ff947098939"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("98adcdcf-8359-4974-a02d-4192f628c107") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") },
                    { new Guid("27b30454-141a-459b-ab00-86517c816b74"), new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632") },
                    { new Guid("69ae2f67-bda5-4b1a-b850-3484657fa3c5"), new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4") },
                    { new Guid("78da8bcc-1884-48a9-9f9c-e1b623527dac"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") },
                    { new Guid("8faf853c-b5e9-454b-8e26-02d415acf7bf"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("adba8806-f6f6-4272-989c-150a6d7302f8"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") },
                    { new Guid("e31f428f-7167-4a01-b745-acf66e0107b7"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") },
                    { new Guid("e31f428f-7167-4a01-b745-acf66e0107b7"), new Guid("5760d083-919c-430a-9a26-59728233d777") },
                    { new Guid("e31f428f-7167-4a01-b745-acf66e0107b7"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCondition",
                columns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("5760d083-919c-430a-9a26-59728233d777") },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("4250f4ed-ed1b-4d3a-9873-d7e23a54712b"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") },
                    { new Guid("efb33e83-9578-4468-9daf-7132d56aae28"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") },
                    { new Guid("efb33e83-9578-4468-9daf-7132d56aae28"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") },
                    { new Guid("efb33e83-9578-4468-9daf-7132d56aae28"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") }
                });

            migrationBuilder.InsertData(
                table: "TripPointReviews",
                columns: new[] { "Id", "ActualCostPerPerson", "ActualTimeSpent", "CurrencyCode", "ExchangeRate", "PlaceId", "Rating", "TripPointId", "UserId" },
                values: new object[,]
                {
                    { new Guid("001a1eda-6eb9-4121-b0fe-768855e1c18a"), 0m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f"), 4.5m, null, "2e3c264f-d6e5-43a9-9476-8139b37f889b" },
                    { new Guid("0f59c637-323a-49f3-b9d1-c6024d8892ca"), 0m, new TimeSpan(0, 0, 7, 0, 0), "PLN", 1m, new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864"), 5m, null, "c61cfd10-943b-4b3e-9084-e81368f207f2" },
                    { new Guid("115dc103-a980-4368-a28d-d810040c68be"), 85m, new TimeSpan(0, 1, 37, 0, 0), "PLN", 1m, new Guid("5760d083-919c-430a-9a26-59728233d777"), 5m, null, "290d7f0b-410b-48be-8598-54ebf0d7959f" },
                    { new Guid("28224c43-982e-4342-b8dc-47605cea9752"), 10m, new TimeSpan(0, 0, 20, 0, 0), "PLN", 1m, new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86"), 3.5m, null, "be2795a9-4060-4b82-9481-55bc4776b096" },
                    { new Guid("37e7c0b4-fe9f-4029-95d4-fc7fbcecfb0d"), 25m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738"), 4m, null, "82ae23cf-2f79-4eda-b03f-98ef7651dd90" },
                    { new Guid("37fb4a14-52bd-41f7-8999-c00045e23301"), 75m, new TimeSpan(0, 2, 0, 0, 0), "PLN", 1m, new Guid("5760d083-919c-430a-9a26-59728233d777"), 5m, null, "e1fb29c3-7644-43ad-aad6-171233dfa4f5" },
                    { new Guid("3e5597a6-af4f-47c7-985b-b1322695bb29"), 0m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da"), 3.5m, null, "8750eab2-27f2-4e65-a3da-b84d29af4f4b" },
                    { new Guid("429790bb-04ce-4254-abd5-f5e92df9892f"), 15m, new TimeSpan(0, 0, 35, 0, 0), "PLN", 1m, new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86"), 4m, null, "2eb2fdbe-3c85-425b-9ca6-7389ec261abe" },
                    { new Guid("4366cd4d-85eb-4c3c-8298-77491799d9d3"), 17m, new TimeSpan(0, 0, 25, 0, 0), "PLN", 1m, new Guid("b362daaa-9821-4360-8758-c715ab7b01b5"), 5m, null, "32657edf-7857-416d-abeb-b83f700aa9a0" },
                    { new Guid("4e1bf8fc-218d-4e2a-bb9e-4c8e9eef9f34"), 14m, new TimeSpan(0, 1, 20, 0, 0), "PLN", 1m, new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c"), 5m, null, "d8cae0a0-9e16-4335-a817-1cf63e34470a" },
                    { new Guid("6f0948cb-e98a-4c73-b90a-5a38676d5955"), 80m, new TimeSpan(0, 1, 30, 0, 0), "PLN", 1m, new Guid("5760d083-919c-430a-9a26-59728233d777"), 4m, null, "c1464acb-3e09-464f-ab78-4f33111f270b" },
                    { new Guid("7656aa34-35e8-4e5f-9ab9-ac81df1f8753"), 30m, new TimeSpan(0, 0, 20, 0, 0), "PLN", 1m, new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738"), 3m, null, "5369289e-e694-4595-ac1a-05256abeb7c2" },
                    { new Guid("9dda2efb-a51a-4f1c-be6d-6ed3449b950f"), 20m, new TimeSpan(0, 0, 50, 0, 0), "PLN", 1m, new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c"), 5m, null, "c16d796c-2f46-45f1-b0d0-8cb8998a8c0e" },
                    { new Guid("a534b557-b701-4558-ab3f-39c82d260aee"), 20m, new TimeSpan(0, 0, 30, 0, 0), "PLN", 1m, new Guid("b362daaa-9821-4360-8758-c715ab7b01b5"), 5m, null, "f05d28a2-d4ee-4199-aff9-2da905def522" },
                    { new Guid("a8b04369-824e-42bc-b07c-642f6e34de5d"), 0m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f"), 4m, null, "5351567e-08ea-492f-95ce-8d338d0cbe1a" },
                    { new Guid("af5d5f2e-3dd0-4ab8-a26d-e7eed84220b0"), 5m, new TimeSpan(0, 0, 8, 0, 0), "PLN", 1m, new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da"), 4m, null, "0bf7f535-5e06-41b9-a22a-d31aa2c645fc" },
                    { new Guid("bbc7fb38-66ec-47d3-b1b5-241356651cba"), 14m, new TimeSpan(0, 1, 10, 0, 0), "PLN", 1m, new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c"), 5m, null, "bda051af-b709-45eb-a37e-aaa31e80ef0f" },
                    { new Guid("d95e9386-0305-45b6-9dfe-476ce02ebb6a"), 0m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("b362daaa-9821-4360-8758-c715ab7b01b5"), 4.5m, null, "c8ed7e92-4e35-41fc-9f65-bea9bb91b8d4" },
                    { new Guid("eca62450-86e3-4bfa-b513-0857b7cae90e"), 0m, new TimeSpan(0, 0, 5, 0, 0), "PLN", 1m, new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864"), 5m, null, "3dca700d-042d-419a-8afa-a6c16bbdeddb" },
                    { new Guid("f541f23a-7b2a-47f9-9389-c8f80e4ee29d"), 100m, new TimeSpan(0, 1, 45, 0, 0), "PLN", 1m, new Guid("5760d083-919c-430a-9a26-59728233d777"), 4.5m, null, "d9b7593c-569f-4b91-a456-235ded7c0486" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("127aa433-a232-402b-b74f-47b568dd68ca"), 200m, new Guid("2661ba10-2c77-411a-a4a7-7d28e852b584"), new Guid("1b425c65-ee8f-46d8-b37e-1e514451d927"), "PLN", new Guid("48ab2470-71c9-4959-95d8-b824edc58512"), new DateOnly(2025, 12, 6), 1m, "Wycieczka do Wrocławia", 1, new DateOnly(2025, 12, 6), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("34e0c30c-6eb1-4260-bc5b-15924f61281e"), 100m, null, null, "PLN", new Guid("ab644f74-ab99-4a17-bb4a-a3d9d712fb93"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("ee13fbd0-885e-469e-8277-9b1be1dff5b7"), 100m, null, null, "PLN", new Guid("ab644f74-ab99-4a17-bb4a-a3d9d712fb93"), new DateOnly(2024, 11, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 11, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0388426a-2ccb-48cb-9514-33879d1c3076"), null, "christianity", new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8") },
                    { new Guid("04bf473c-ffe3-4b99-aea7-67b178d776d0"), null, "oriental", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("05c06132-dc0e-4e6d-b5d3-17fa71b69343"), null, "irish", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("05fcb62f-a3f5-4fa9-92b0-81347312294b"), null, "arab", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("07b8d9d8-f84d-4461-b64c-a725c9a8a035"), null, "cuban", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("0bd6592a-a84c-437e-b008-43629a3ada10"), null, "austrian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("0c90c8b5-20bf-4001-9589-de410136e4f6"), null, "ruines", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("0cee0c88-a1bf-41a4-a027-5622e21d7a28"), null, "vietnamese", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("0da5ce4a-f1e6-401f-a8b8-fe25333905fd"), null, "city_gate", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("0fefd15f-4054-426b-b869-3c108fb13f02"), null, "dessert", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("13b220c9-1f65-462e-a248-8b63a779b60e"), null, "danish", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("177019c2-f76e-4c52-9e25-d9cd6b398a07"), null, "tapas", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("18e53a78-59cb-4f06-a29b-2bc8e345c4b5"), null, "shinto", new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8") },
                    { new Guid("1b6301d2-9251-48bf-8646-d4bf24acc4e8"), null, "fountain", new Guid("4c846ffb-2eca-494b-8829-6923f1268e73") },
                    { new Guid("22aaa9f1-e450-42f2-ae19-022e03fc87b9"), null, "castle", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("273e23f6-a0bf-4a66-9f7c-ece39ba89824"), null, "crepe", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("27b5e98f-d390-4a21-a24e-8da4faaadb5b"), null, "pizza", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("2955b36b-b3a4-4774-b89f-a11b27ad2c9b"), null, "japanese", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("29b27733-4042-4377-bfc9-b5b6339efb78"), null, "tex-mex", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("2a3ccd94-7834-4f67-9875-7fb3e2801bec"), null, "sea", new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281") },
                    { new Guid("2f9838e6-2f7b-4f92-b84e-1f860e6918c7"), null, "hot_dog", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("301dc105-00ee-48fd-8aa8-e4d8f3a0acac"), null, "chinese", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("31205953-8c2b-4c51-940c-ddb7d90de0f5"), null, "fish", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("31273ab9-738c-48ba-89e0-c8a0304d3e1d"), null, "archaeological_site", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("31ff1c14-a2d8-438e-ab16-8b67192fd7e5"), null, "noodle", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("33a87d05-74a5-471a-aa20-23a81f529feb"), null, "pita", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("34dee5ad-7845-4623-8d64-936ed1550c28"), null, "cake", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("35337352-c34e-4c93-9635-e73894ee4a48"), null, "spanish", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("370121a3-2f56-4f5c-8b60-bdebd861bf45"), null, "regional", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("398bdb6d-646b-4169-add3-157ca09cf8f4"), null, "belgian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("3d36f68f-42bc-413f-86bc-9cb0e3623c37"), null, "sikhism", new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8") },
                    { new Guid("3fab9123-35f6-424a-ae81-38dd99d31b83"), null, "steak_house", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("402b81d8-f476-480f-8ccc-e837f68f2658"), null, "barbecue", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("4153b966-41c4-4036-a6e4-146e4e464264"), null, "brazilian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("448ee1d0-fdc3-4c03-aa49-59b1d3f31a86"), null, "bavarian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("45704cc8-fb67-47c3-8aef-5fdcf3f1d271"), null, "fish_and_chips", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("45ce68b4-52ba-4080-803f-df08e7c74c3a"), null, "battlefield", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("466965f0-1a37-4433-ad94-81325315972a"), null, "theatre", new Guid("90be597f-c6e5-4c6b-99b2-79eac52e0156") },
                    { new Guid("49fc2114-9992-4fc4-9f43-c6d9c743de69"), null, "windmill", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("4ab08a9c-95d7-4567-9b7c-2a2f85c19c32"), null, "pizza", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("4ae2f0d6-d43d-47d1-9a73-c691c14a04b1"), null, "moroccan", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("4aee4717-1543-44cd-8919-a185cab623c6"), null, "noodle", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("4cbde352-4adf-437e-a4eb-53232963f75c"), null, "coffee_shop", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("4da5e13f-a1ab-4c18-9e96-d5b0f09b0d1f"), null, "frozen_yogurt", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("54406508-e00e-4322-819c-59686dc776c6"), null, "argentinian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("54f5a9e1-3f58-4aa0-b3ee-da70c061d3a8"), null, "coffee", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("561cdee8-e99d-42c3-8df7-0a9fbc0e977e"), null, "seafood", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("568686ea-f168-46b9-81c8-d9fc8887162a"), null, "rock", new Guid("206bf6d8-af1f-4502-8d3a-ce9a365be63f") },
                    { new Guid("59401c6b-2882-4c1c-9456-cfd4432c0fe2"), null, "cave_entrance", new Guid("206bf6d8-af1f-4502-8d3a-ce9a365be63f") },
                    { new Guid("5b0d92cb-4af0-4c65-a146-7dd659329d8c"), null, "nepalese", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("5b3bf8fb-8c85-4de6-a234-641cd110ad80"), null, "peruvian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("5c30428f-d032-470a-b978-0949000709a6"), null, "indian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("5d34ed16-f5ab-457c-b29c-8b6a9141ad38"), null, "hungarian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("6022f0fe-395d-42e9-bfbd-7e098e209e7c"), null, "fish_and_chips", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("66e85667-3c76-4518-aa6d-8874df5adc62"), null, "portuguese", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("6b35db83-1bbd-40e9-8d9a-f5149f5157dc"), null, "bolivian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("6b454a7c-a74d-4c09-b693-f7fc3a0e805d"), null, "soup", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("6ed9b673-4e22-4815-a84d-34e4bc256be8"), null, "spring", new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281") },
                    { new Guid("6f36d8f6-a11d-4587-9226-475a4467e7e7"), null, "czech", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("73008bc3-9894-4433-98f2-1511f65f0709"), null, "pita", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("7362ea76-cfa0-45f5-82b5-593b65df6a38"), null, "burger", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("74390a57-667f-4241-94bc-6939496cbbe2"), null, "ramen", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0"), null, "place_of_worship", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), null, "memorial", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("7a72eb6c-42e3-40e0-ae6c-d024466a80eb"), null, "croatian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("7d3fb7b0-d13b-49e1-b584-731616fc0d27"), null, "dumpling", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("7d632859-04c5-4285-88aa-8d9da633c514"), null, "peak", new Guid("206bf6d8-af1f-4502-8d3a-ce9a365be63f") },
                    { new Guid("80db6ad7-b7ba-4e19-acc4-bc309e54ac50"), null, "dune", new Guid("ac27e10c-1e8f-4046-bfb0-b936589a1a5e") },
                    { new Guid("84aad29d-c262-4b90-a651-85edbb2a904f"), null, "nature_reserve", new Guid("05276e93-6021-4ad9-a8da-532781ecd32d") },
                    { new Guid("85ebd42e-52ac-4baf-90d8-fb5f579b2259"), null, "french", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("8601e246-1505-40d9-8917-fe8106719e33"), null, "swedish", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("869cab8e-58e7-4e61-a208-1afd23ecfc30"), null, "tea", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("88302c42-5fd2-4413-8352-bb341275baf9"), null, "soup", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("89153df4-bc82-4d07-a831-6de3939035a3"), null, "beef_bowl", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("8b0f0189-9886-447d-b110-7557135c2799"), null, "filipino", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("8c508f69-2f68-4238-919a-7186e7f55dcb"), null, "korean", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("8f16538d-12bb-4c3d-a82c-fe2eb6fd9ee6"), null, "caribbean", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("9078e0e1-ba61-4740-82ae-d761b5ed2d24"), null, "judaism", new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8") },
                    { new Guid("9124eb25-7b29-4386-af65-18d7ca2f45a2"), null, "lebanese", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("919ae52e-badd-4a83-9260-1a2e23879a59"), null, "reef", new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281") },
                    { new Guid("9236f957-cfae-492c-850f-0f8c37b021af"), null, "syrian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("927e72ca-924d-4d68-84c9-5461e6dc1e05"), null, "tacos", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("94964584-49ec-4668-8eba-8c8e83840600"), null, "tapas", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("960ac149-6930-44e3-91cf-7bd177e28f14"), null, "clock", new Guid("4c846ffb-2eca-494b-8829-6923f1268e73") },
                    { new Guid("96219df0-47cf-42c9-ad10-a876901b0e24"), null, "waffle", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("97d6bb27-bbf1-4d53-beaf-055619cc5221"), null, "salad", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("9a01c4e7-83dc-4239-999a-d815f96423c4"), null, "glacier", new Guid("206bf6d8-af1f-4502-8d3a-ce9a365be63f") },
                    { new Guid("9a467345-1a8d-4a88-a19d-def94c498435"), null, "ethiopian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("9afb32e5-8eb6-42a7-ad7e-88c75ae449d2"), null, "viewpoint", new Guid("4c846ffb-2eca-494b-8829-6923f1268e73") },
                    { new Guid("9bf56530-b40a-4008-951e-8adc112eff6e"), null, "bubble_tea", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("9d8518db-fde9-4c4b-8982-f958b8ce0289"), null, "mexican", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("9e341188-68df-4c02-88bf-6591cbad6530"), null, "chili", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("9f01a8c0-d1ba-4146-a871-0008e36455a8"), null, "ice_cream", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("a0c8369f-f0b7-4fd6-b32e-901f476006a0"), null, "garden", new Guid("05276e93-6021-4ad9-a8da-532781ecd32d") },
                    { new Guid("a12c7885-1bec-4408-9f41-6e614806896f"), null, "wings", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("a2351623-d317-426e-ba3b-ef4b8223d02a"), null, "mediterranean", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("a531a9b8-6ff5-438e-843d-1572bc688c04"), null, "donut", new Guid("4b499ad9-d739-4cf5-b5e8-629adff46984") },
                    { new Guid("a6411a06-c471-45de-bab2-74796de1a6d0"), null, "artwork", new Guid("4c846ffb-2eca-494b-8829-6923f1268e73") },
                    { new Guid("a786c3c8-4c84-4f86-bad5-d96490f77d54"), null, "international", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("ac8a912e-d362-43a0-97a1-b66913d92dcc"), null, "tacos", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("acc9a503-34de-4f80-8f19-340d48ca31dc"), null, "cliff", new Guid("206bf6d8-af1f-4502-8d3a-ce9a365be63f") },
                    { new Guid("ad35e64e-c99d-4b58-a8e0-afab3db3beef"), null, "pakistani", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("ada098e0-02e3-485f-85b1-679052e9c0f9"), null, "italian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("adb1cc6b-8cd1-451e-b363-5ab816c0867d"), null, "hinduism", new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8") },
                    { new Guid("aee5c40f-72a6-401f-b2f6-476766982a1b"), null, "burger", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("b0124868-643d-422c-8bb2-eb497854de58"), null, "balkan", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("b032c911-ad8e-4c87-a530-578436527493"), null, "german", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("b2374e7b-65d0-45b6-8760-e2ba40c43d3e"), null, "chicken", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("b8ed279f-ac1d-4a95-89b4-6a51aedb8be9"), null, "fort", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("ba3f119e-d43e-44ee-b2ba-00e5e1b18cf4"), null, "asian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("bd3783ec-2bba-41e7-883b-25b90ecf71b8"), null, "european", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("bd3b59c8-805d-4d64-8358-6571af8454ea"), null, "islam", new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8") },
                    { new Guid("bdcc931a-1c69-4f6f-b278-dcaa1cf33095"), null, "sandwich", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("be6b29cd-1b09-4f2d-a5e3-9d3fcfb17c7e"), null, "bridge", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("c145a13d-5503-4e51-b262-1f2656cdf9d7"), null, "buddhism", new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8") },
                    { new Guid("c279873e-e705-4eb9-b21e-57c2caaecd6b"), null, "turkish", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("c34606da-c23d-45d2-8975-e274ad2ffabe"), null, "hot_spring", new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281") },
                    { new Guid("c3655fc1-8d7f-4fbd-a401-d96a887726f3"), null, "persian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("c7d12b42-3cb8-4ce5-a49d-8226df7bc477"), null, "city_hall", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("cb016a92-3aab-4c82-bcf5-73b4d97f49e5"), null, "curry", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("cbf72716-f6f0-49f0-b0ea-92a5734eb469"), null, "geyser", new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281") },
                    { new Guid("cd13199e-7d2f-47c2-9b21-79198469f0b1"), null, "multifaith", new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8") },
                    { new Guid("ce97791c-d342-48db-98b8-892051bd4689"), null, "jamaican", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("ced525d7-f045-4870-a271-a86119fa65b8"), null, "tower", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("d2ad28c1-c67a-4608-aabb-20db01f4412d"), null, "hawaiian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("d48a3541-649a-4855-a123-232d59a1f4aa"), null, "kebab", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("d526a682-0bd0-40e3-bcf4-a2d63724620d"), null, "malay", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("d9677499-2759-4e32-941c-dbc63809940d"), null, "kebab", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("daafbcc9-2f8c-43f0-b20f-120bf23f0145"), null, "latin_american", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("dafc0864-596e-4677-81e7-415ba3d6c411"), null, "ukrainian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("def2be31-f989-4300-a3f5-101395a1cd23"), null, "western", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("e316333c-378e-4d70-a889-77a6f61af82b"), null, "afghan", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("e3d3552f-42d2-47b2-b83b-e10c8c4f26ad"), null, "american", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("e535434f-0c99-448b-803b-958a910161fb"), null, "malaysian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("e58a21b3-6439-4ab5-8fee-11fcd562655d"), null, "taiwanese", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("e6ba8aad-fbfa-45fa-af1a-ffea205697f5"), null, "georgian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("e96fbecc-baa5-45f9-955b-86eaaedacbfa"), null, "ramen", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("ea1d08dd-9d8e-4ee4-b395-a2662d8d68e5"), null, "monastery", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("ea3484f9-a372-4ddf-bee8-3309cced232b"), null, "sandwich", new Guid("7841542a-d711-4bab-a1f7-3a06f0bd3ad7") },
                    { new Guid("ed7742fa-5440-4214-b81d-24d8f576487f"), null, "arts_centre", new Guid("90be597f-c6e5-4c6b-99b2-79eac52e0156") },
                    { new Guid("ef3045e6-7f60-4f3b-b60b-139cbc0a2b92"), null, "african", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("f7ab41b6-0ed2-44a2-962d-afae9547fa38"), null, "wings", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("f7f57892-48c6-4718-8a64-74e5697b5153"), null, "sushi", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("f82bd341-f895-48d2-a392-86ca5af3894e"), null, "gallery", new Guid("90be597f-c6e5-4c6b-99b2-79eac52e0156") },
                    { new Guid("fa032d8c-e9c6-442e-bec4-f4525cdfbbae"), null, "greek", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("fa2bbdc4-3637-42d3-9948-dc9b18a2ccbb"), null, "indonesian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("fb423028-1e31-465f-8413-d24fe13296f1"), null, "russian", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("fb5d5288-9266-4018-b7b2-15423ea4dbb8"), null, "thai", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("fc97d501-8dd4-453f-b839-f6521397d929"), null, "lighthouse", new Guid("f4887859-e543-4300-8540-1bea9d3b5b95") },
                    { new Guid("fe0216b0-c025-4be1-af13-81699ffbc2b4"), null, "uzbek", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") },
                    { new Guid("fe2856f1-a528-416d-9d02-d74d0ab7cdfc"), null, "friture", new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("05276e93-6021-4ad9-a8da-532781ecd32d"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") },
                    { new Guid("4748a6e0-c990-403b-b7ae-2e694a27a9ca"), new Guid("5760d083-919c-430a-9a26-59728233d777") },
                    { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") },
                    { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("4c846ffb-2eca-494b-8829-6923f1268e73"), new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632") },
                    { new Guid("5a1ffc98-b5e8-4205-8b9e-32e535dde281"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("785e5b79-64d3-4b39-b1ee-1982a3f22657"), new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4") },
                    { new Guid("b183e34c-7599-4373-8637-6fb5a42c7c10"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("c2434b5e-16fa-46f1-9ac8-35243447d2b8"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("f3e1bd5e-adf6-47b0-8fa0-9606d3cdce79"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") },
                    { new Guid("f3e1bd5e-adf6-47b0-8fa0-9606d3cdce79"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("98adcdcf-8359-4974-a02d-4192f628c107") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") },
                    { new Guid("f4887859-e543-4300-8540-1bea9d3b5b95"), new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCondition",
                columns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") },
                    { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") },
                    { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") },
                    { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("6e93375a-5eff-46c5-9896-72fa2cc8ea30"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") },
                    { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") },
                    { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") },
                    { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") },
                    { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("8adf1adb-e9cb-4778-ba8c-27af377fb7e7"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") },
                    { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("28f5fd03-da9d-4c53-97bf-a40805391098") },
                    { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("5f7c8e9b-d3a4-435c-91c2-138421628738") },
                    { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("9702844c-344b-421b-bfcc-e0b8f66daa86") },
                    { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("b362daaa-9821-4360-8758-c715ab7b01b5") },
                    { new Guid("b26fe358-8091-45ba-a5da-b6806cc7101a"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") },
                    { new Guid("c979e365-7f55-42ab-af48-0446fb979b0f"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("c979e365-7f55-42ab-af48-0446fb979b0f"), new Guid("5760d083-919c-430a-9a26-59728233d777") },
                    { new Guid("c979e365-7f55-42ab-af48-0446fb979b0f"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("33b394a8-1f6e-4eaa-a7c3-30047e2ff1bd"), new DateOnly(2025, 12, 6), new Guid("127aa433-a232-402b-b74f-47b568dd68ca") },
                    { new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1"), new DateOnly(2024, 12, 21), new Guid("34e0c30c-6eb1-4260-bc5b-15924f61281e") },
                    { new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6"), new DateOnly(2024, 11, 20), new Guid("ee13fbd0-885e-469e-8277-9b1be1dff5b7") },
                    { new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4"), new DateOnly(2024, 11, 21), new Guid("ee13fbd0-885e-469e-8277-9b1be1dff5b7") },
                    { new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661"), new DateOnly(2024, 12, 20), new Guid("34e0c30c-6eb1-4260-bc5b-15924f61281e") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("1fcf5308-f5f8-4f5d-b62d-5b306cd7fa56"), null, "pillory", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("24446240-bf81-4251-a5c7-c2f88e69334d"), null, "chapel", new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0") },
                    { new Guid("2d4b971c-9fc1-4b7a-8af4-7e05158d39e5"), null, "synagogue", new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0") },
                    { new Guid("41d4f6ec-bfe4-4444-adf5-e9c55c6d3911"), null, "tomb", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("425b6f31-3c5f-4ec0-9827-bfd7be0ed41e"), null, "mosque", new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0") },
                    { new Guid("5b384f27-a8ce-4baa-8d0e-1f0402198caa"), null, "wayside_cross", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("5de45683-7e9c-47de-9cd6-bdc55cd8b05d"), null, "monument", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("7a5ed3ce-0417-4b51-8862-a2a191cd2d21"), null, "ship", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("89f73eee-287a-4ced-aedd-2cfdeb08f311"), null, "temple", new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0") },
                    { new Guid("ab714525-e6d5-4906-82d0-ce884915602d"), null, "shrine", new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0") },
                    { new Guid("c9398e38-ee48-4217-a709-f39458dd3f36"), null, "boundary_stone", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("cd3d674b-5392-4e40-b0a0-d1df96b79a8c"), null, "church", new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0") },
                    { new Guid("d5e887d4-fab2-4f55-9ab4-af70803ee101"), null, "railway_car", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("d8bbd665-6369-478e-ac90-454a021fea56"), null, "aircraft", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("e6170119-7962-4e79-b266-5411a0c07642"), null, "cathedral", new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0") },
                    { new Guid("e726ada7-aee8-4065-89e4-1da3a194e048"), null, "locomotive", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("ee835d25-626a-4703-8396-e1fc4d2eac44"), null, "tank", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") },
                    { new Guid("fb9a6da5-17b2-45e7-82dc-07b7c96daf96"), null, "milestone", new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("0388426a-2ccb-48cb-9514-33879d1c3076"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("0c90c8b5-20bf-4001-9589-de410136e4f6"), new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632") },
                    { new Guid("1b6301d2-9251-48bf-8646-d4bf24acc4e8"), new Guid("15221ca1-7753-4a24-89b0-34e15e3c258f") },
                    { new Guid("7665ed93-0859-4a59-8307-f79a383a6cf0"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") },
                    { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9") },
                    { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd") },
                    { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("98adcdcf-8359-4974-a02d-4192f628c107") },
                    { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4") },
                    { new Guid("792fc7ae-b4af-42dc-a9b9-f5b41a6dedfc"), new Guid("c9351478-37ab-4612-aa8e-55e3a7aa6864") },
                    { new Guid("a0c8369f-f0b7-4fd6-b32e-901f476006a0"), new Guid("8e91960d-a66a-4fe1-b958-ba5e2d1bf63c") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("17629758-7b19-45e0-ad3f-7704f73e1c65"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661") },
                    { new Guid("27651590-f8e7-4b16-b6c8-8a1eb7e294a1"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("6e337722-b020-407d-b666-7a2aa9631ffc"), 20m, new TimeOnly(12, 30, 0), 1, new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6") },
                    { new Guid("39023f49-bca4-4fb1-b9cc-11c1a528e004"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("98adcdcf-8359-4974-a02d-4192f628c107"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661") },
                    { new Guid("3b633608-bcf9-4e1b-9f1f-7f403f8dd6a7"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9"), 0m, new TimeOnly(13, 0, 0), 1, new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4") },
                    { new Guid("3dd2e7b1-9f68-44db-a9bd-a6cd7cee050d"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("be6fd349-e7cf-40bd-a9a2-ce7cb6e21527"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1") },
                    { new Guid("4f7a064e-929b-49f9-afad-97d9158e3dcb"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4"), 0m, new TimeOnly(11, 50, 0), 1, new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6") },
                    { new Guid("54f231bd-aa27-4cf6-a372-a3bb5f8b920c"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("e30bc546-3e22-42a4-b974-ef70f54ac812"), 10m, new TimeOnly(13, 30, 0), 2, new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6") },
                    { new Guid("5c0ebae2-b02d-4686-a34f-80b91e35d825"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("bd4303ca-fc05-4ab1-8a47-1dc993db98e4"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661") },
                    { new Guid("5e5ef092-f6ea-4128-84a1-f385334a4f8a"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1") },
                    { new Guid("787f1cc7-fd0c-4d60-9434-a2fb5fab2d5a"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("98adcdcf-8359-4974-a02d-4192f628c107"), 0m, new TimeOnly(11, 0, 0), 1, new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6") },
                    { new Guid("8fd20382-6fb3-4241-86e5-7ec309a9221c"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("319d3a58-6a5f-4d90-a76b-1d8ea0c5b721"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661") },
                    { new Guid("98e914b6-1fd1-42ed-81c8-0b719ef5df51"), new TimeOnly(0, 0, 0), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4"), 30m, new TimeOnly(14, 0, 0), 3, new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4") },
                    { new Guid("99dc1794-a3b1-4338-a471-34765377d51f"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("e3310633-abf3-4f85-95d3-ae8ca5bc683d"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661") },
                    { new Guid("9ed9016d-e621-4953-a1f2-5347b29a6552"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1") },
                    { new Guid("a19d578c-6e7a-4e0a-8f04-5f5cb4be3150"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("58418c2f-1ee2-4164-8b8b-1f768323c8e5"), 5m, new TimeOnly(16, 30, 0), 3, new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4") },
                    { new Guid("cdc3704f-5aab-4048-a5a9-7006b664ce24"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("faddd4e0-1694-4c1d-bffe-200ab62d4632"), 0m, new TimeOnly(10, 0, 0), 1, new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6") },
                    { new Guid("ec4ce504-f553-4e61-abec-45c8890d7c48"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("8153979e-e8c7-46a6-bddd-6ac92aa4c0fd"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4") },
                    { new Guid("f554bcd4-e115-4242-b883-b578000bc129"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("2bc27a54-bd03-4757-ab23-ba7681ac1ea9"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[] { new Guid("cd3d674b-5392-4e40-b0a0-d1df96b79a8c"), new Guid("2ca8eecb-7882-46f9-ab89-149cc13957da") });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "ToTripPointId", "TransferTime", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("15abdd55-97ec-4df1-b972-ab7263a90a19"), new Guid("5c0ebae2-b02d-4686-a34f-80b91e35d825"), 1, new Guid("8fd20382-6fb3-4241-86e5-7ec309a9221c"), new TimeSpan(0, 0, 0, 55, 0), new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661") },
                    { new Guid("1c19279b-65e3-44bc-b3e2-201675531eed"), new Guid("ec4ce504-f553-4e61-abec-45c8890d7c48"), 2, new Guid("3b633608-bcf9-4e1b-9f1f-7f403f8dd6a7"), new TimeSpan(0, 0, 3, 13, 0), new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4") },
                    { new Guid("5267719f-5c1f-4d14-a78f-ec553ec51b0f"), new Guid("787f1cc7-fd0c-4d60-9434-a2fb5fab2d5a"), 0, new Guid("4f7a064e-929b-49f9-afad-97d9158e3dcb"), new TimeSpan(0, 0, 4, 21, 0), new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6") },
                    { new Guid("58dafadd-efdb-4395-b769-c66ae537c278"), new Guid("f554bcd4-e115-4242-b883-b578000bc129"), 3, new Guid("5e5ef092-f6ea-4128-84a1-f385334a4f8a"), new TimeSpan(0, 0, 8, 18, 0), new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1") },
                    { new Guid("7e7f056e-7f0c-4ab7-b9de-df4f4e3a0564"), new Guid("98e914b6-1fd1-42ed-81c8-0b719ef5df51"), 3, new Guid("a19d578c-6e7a-4e0a-8f04-5f5cb4be3150"), new TimeSpan(0, 0, 13, 30, 0), new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4") },
                    { new Guid("9720dcf8-29de-4dd6-869f-1f58e4ec8795"), new Guid("3b633608-bcf9-4e1b-9f1f-7f403f8dd6a7"), 3, new Guid("98e914b6-1fd1-42ed-81c8-0b719ef5df51"), new TimeSpan(0, 0, 8, 18, 0), new Guid("90bcfe25-4d3f-407c-bf7c-032725ed49e4") },
                    { new Guid("99af0ef9-0e2e-4f2e-9168-9d0a6c156def"), new Guid("5e5ef092-f6ea-4128-84a1-f385334a4f8a"), 3, new Guid("3dd2e7b1-9f68-44db-a9bd-a6cd7cee050d"), new TimeSpan(0, 0, 13, 30, 0), new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1") },
                    { new Guid("a81a0b59-591b-491e-b734-df0e0c550d13"), new Guid("8fd20382-6fb3-4241-86e5-7ec309a9221c"), null, new Guid("99dc1794-a3b1-4338-a471-34765377d51f"), new TimeSpan(0, 0, 20, 0, 0), new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661") },
                    { new Guid("e57efd04-7513-4474-acc3-4b6ebf1273a0"), new Guid("9ed9016d-e621-4953-a1f2-5347b29a6552"), 2, new Guid("f554bcd4-e115-4242-b883-b578000bc129"), new TimeSpan(0, 0, 3, 13, 0), new Guid("43a88a45-4e6c-41b9-ab07-9393d459c6d1") },
                    { new Guid("f5c8b403-5621-4257-9d4d-e91ff8815f96"), new Guid("39023f49-bca4-4fb1-b9cc-11c1a528e004"), 0, new Guid("5c0ebae2-b02d-4686-a34f-80b91e35d825"), new TimeSpan(0, 0, 4, 21, 0), new Guid("b0bce230-11d7-4cd5-a80b-93072bf6f661") },
                    { new Guid("fdafa700-ba63-4124-a33b-abbe85c725a8"), new Guid("27651590-f8e7-4b16-b6c8-8a1eb7e294a1"), null, new Guid("54f231bd-aa27-4cf6-a372-a3bb5f8b920c"), new TimeSpan(0, 0, 20, 0, 0), new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6") },
                    { new Guid("ff818b58-8af1-4392-8f02-b8fe789864e2"), new Guid("4f7a064e-929b-49f9-afad-97d9158e3dcb"), 1, new Guid("27651590-f8e7-4b16-b6c8-8a1eb7e294a1"), new TimeSpan(0, 0, 0, 55, 0), new Guid("72a95f74-d2a3-4456-b425-67f9f36067c6") }
                });

            migrationBuilder.InsertData(
                table: "TripPointReviews",
                columns: new[] { "Id", "ActualCostPerPerson", "ActualTimeSpent", "CurrencyCode", "ExchangeRate", "PlaceId", "Rating", "TripPointId", "UserId" },
                values: new object[,]
                {
                    { new Guid("19252019-9bde-44c2-932d-3c01734e1429"), 10m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("58418c2f-1ee2-4164-8b8b-1f768323c8e5"), 4.5m, new Guid("a19d578c-6e7a-4e0a-8f04-5f5cb4be3150"), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("fa90bf0e-1ce1-4b9d-a021-0310e77e4ba1"), 40m, new TimeSpan(0, 1, 0, 0, 0), "PLN", 1m, new Guid("576f9e5e-08cc-47c2-a4b9-68f9302adfa4"), 5m, new Guid("98e914b6-1fd1-42ed-81c8-0b719ef5df51"), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });
        }
    }
}
