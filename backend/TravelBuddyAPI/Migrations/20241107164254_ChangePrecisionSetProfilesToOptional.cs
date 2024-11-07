using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangePrecisionSetProfilesToOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_CategoryProfiles_CategoryProfileId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_ConditionProfiles_ConditionProfileId",
                table: "Trips");

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("018a09e5-6ba9-4b29-ba79-0803feba0f5e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("07ef91d0-0be4-4022-9b50-659c025ebf97"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("087a9136-4eaf-4329-a201-e8edb64454ed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08b2e0b1-876e-42fc-9973-d2fcba83af91"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08da4354-d8f2-4d0a-8542-df0ef60d6c16"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08df1de9-f93b-4735-a670-7bdae53bbbb7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b409f98-f45b-4896-b504-d395f817f4ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c70d085-68a6-4400-af68-513248057d34"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0dc1f79d-dbee-412d-9061-565d0d12f8f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e1d2beb-44b6-4d5b-a49a-251fb6629c54"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e908597-4145-4eae-a6a3-9ac2a1a275fd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0ea0ce41-e53d-4176-9a5b-195848ec4629"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12d05c93-85fb-4163-a25a-b8c4e6489d79"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("14b1925d-205d-4b8d-bc38-1340ef12944a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1662de7d-6867-421b-99c0-ceb5d070d275"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("177a53c0-48f5-46e7-97e2-bc429ea12dc0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17e5dfc8-1b9a-4829-b21a-7edfcdd2f0b1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("193bab09-2ee6-4e96-a63f-e03dbda130c0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c9684a1-ef58-4995-97e1-d8b17ec491ae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c9abf07-3218-456d-8560-17d21b416c71"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f2c4a85-4633-464e-bd07-74e2f0347fb2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fd1a6f5-fd5e-4e8a-8b3a-4d8113e4194e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("208e0fb8-56e5-419a-90bf-fbe3b0cf0ddd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20a7a04c-bd1f-4622-b866-f0aec410b3a1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23571e0f-9900-4154-b2e0-69e9b3c59491"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23cc62ca-0582-4b17-9a24-ef1effa88bbd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2558d8d3-ac4e-4b32-b179-60c9c57ad559"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2579afa4-b0de-4501-92a1-9585190a07fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("25f98c91-0a99-47d9-89d7-6e3230104c82"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("29740d75-4e89-4008-9cbc-4b31a804a0ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a522f64-1334-409b-a101-6976cb9692c4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b3f24ba-44e5-4fbf-b1ec-602facbef939"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c14a939-2a0f-4c71-86e1-4685a855fdd0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c2b577d-0f94-4785-8a1e-17b72a1e1642"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("301676d6-0e43-4894-8799-a70763bbecef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("361d3ea2-805c-4a96-be73-87006d596667"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37e98797-61ba-4db9-b74f-dbe695f781a1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38ed95d8-8e32-4dce-9bb0-29091ed4643b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3902dd20-e199-40fe-91ae-4be76c938f8f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3948a637-9df0-435f-bc8b-48e2d8e85754"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3be856d1-38fe-4d5d-bea4-ff4fa32e0fc2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d83b5a7-96c1-4ffb-958f-dbe9b5701442"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e272a9d-4ec8-457b-8d2a-dc387f94a16b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f65c286-0e0a-40b3-8c77-5375d1f51e4f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fc9ab0a-f620-47e8-b314-991b9d5fe11d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4291f2e3-d14c-44af-b666-ca5e97684c91"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("46ae060a-678a-4a07-a5e7-612cfefcdd30"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("48e07f55-2fe1-4f99-9cf3-84236d0c4616"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4bd0d9a4-fc68-44a1-a9a8-3155414ee55b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4bea744d-afb8-419a-81f3-974cfdd33d46"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c174a16-f85d-45a1-a198-fd63dbd7868a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c676268-2671-4a4f-8ab8-baf80382601d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4eee0e53-3353-41c2-b40b-1af1f745f2b9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f91b06d-70a0-403c-9ef2-42a1bff16233"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4fb09d8d-372b-42a2-98f1-1e3a346e6aac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("503e96f3-1777-4c20-a16a-4a1750696067"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("50d3b57a-427a-49ab-82c4-2762e01797a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("50f79b1b-7e20-4630-ac03-c40ab6bc339f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5150e63c-2588-4e04-bcc0-57f42e786a68"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("52e9d582-2fa2-4b77-8c71-d7ada63f69ef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("539e04ac-ca27-4783-b750-547dcb37adb5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("579d50c6-a335-4fd3-a369-3e548e754358"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58be8552-90a7-42b2-b7c7-855f0d836d9e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d33ad4b-3245-494d-b2c8-4ca5cd2e84da"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("60543c78-43cf-45d1-be9e-aa61858f1758"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("60986c4a-0a2d-47a4-bc40-651bacf94348"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("60b9468b-4e7a-4b88-80eb-7e69ec5215b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6204a866-9a02-4156-bc46-64abf6b43554"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("625ad2c7-94cb-40ee-9070-6c7b4e413872"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6334f933-463f-4b48-be54-0b8be954aff3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6586d29a-0f8c-4525-b182-3e0a197a8da2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6623a55f-b780-4e5e-92b3-f55e4dd6337b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("681d288e-6e55-47dc-a812-fb6338ff899b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d2b8f9d-799f-4eaa-b448-8864fab16bd4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f207dfe-26f6-48a9-8f83-2c722755f41a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fdd7a4c-c350-4ec4-862f-6a95853c3f65"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("71afbc68-9675-4789-9d27-57a2bbcc5818"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("72b505cc-c4b1-4788-9c24-22b5e936a3db"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("72dc254b-470c-4505-a062-99c5aece5cdf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73e1a74d-62d0-408d-bd1a-77441416cb94"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7434be14-b9c4-4e30-a242-e1b60dbb7466"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7577bc27-1c26-45c5-bf01-8372223f324b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("76ff4ef9-dd4b-4b27-89a1-16a0c3de0d6a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("785ddc09-994e-47f4-ba3e-212ae46cb08c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("78a3fa5f-e2e9-434b-ad50-7592b8b9e152"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("798c8af7-f8df-4bc0-893a-606c897c759d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bf26778-ff1d-49db-a47f-786ec3690b3a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bf69a7a-8e6c-41a9-8b6a-a40809862a4c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d80207e-c275-4f91-a3b5-bc7da0f740d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ef25206-7b3b-487f-84ec-8023d989f92a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("80abc24f-4051-4880-ba7c-2038d25ab812"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8265e83d-12f1-4edc-ad12-383532c86e9d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83cc8def-126e-4c30-8c6b-975f2e643aad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8548c01e-173e-4f13-87dd-2a1a43b5b3e3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("85ad6bce-9577-42a1-8789-7789d461526a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8765381f-1b6c-452c-bd09-9cd933a014d2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b78cd59-31ff-488f-9d8e-71b19e35e9e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e5737cb-ab50-4717-99e4-ae893983d902"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f73ffec-308c-4dc9-8da3-7230528c3531"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f877ca8-41a0-4d3f-8193-d78aba252c17"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("90b93164-d4d0-464e-95b9-b1da03fb27d2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("91b81e55-3fb3-4198-a4df-ddf99b7dacf1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9296dfec-14d8-4925-845f-b4279c84a48c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("932c6579-c760-4951-9973-f59d3aa5271b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("93f9b2da-a3ff-4f74-ad76-503d5447917d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("95e7879a-1d52-4650-b48e-a02f3616ff87"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("968db041-c011-4761-b4a4-8c132f8aebac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("982b55ff-24af-4d6f-9823-8932dc648f93"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("99b85dd9-a34a-4c2f-89cd-5c0678900876"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a42dcc2-4d3a-440a-96f7-1f126fa99dfb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c58d9d9-cfc5-4e81-aa76-4249e6555ce2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d439fd0-b48a-487a-888d-53e12d326a3a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d82498c-b9ca-4a81-8f7c-a9ae22fd3491"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ee9ab66-024a-415c-ad5a-294df5c34a8d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a358d970-e58a-4b66-8f59-f5e6ea40f71a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3d10c94-0193-455d-8032-f4a6a507ac2d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a41ff4a7-f012-40ae-99ed-c70e2806640a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a88992a4-34a5-446c-b77b-805fae0a50ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a99f4b1b-7169-4345-a611-530dc8da0b13"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("abd074bc-4ef7-422f-9114-af8f03c58c4a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad40ad35-dd85-4dbf-b2e1-fc30dbe41282"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae277749-2d77-4523-8fa3-414d978ff0f4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae3fb6db-f746-4667-a704-2ff817df5f56"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("afd55c4a-1bb3-453c-9ce7-80eb765f5512"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("afdc2bae-c40e-4e83-8903-aebcc2522e0f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b036fad2-03f0-418e-a213-da54e394a522"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b046df55-dbde-40b3-a31d-ce5d6afbe72b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b1d35d04-7fc4-43a9-b86d-74dc87fc2248"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b368b9aa-0e2e-419c-88ea-dca21621ebe1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b42aa0e0-4ad5-4f5e-8dbe-5a12df3a8c61"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b65bf9d7-42c4-4f72-8b46-f17b8a3a2d98"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b72957bd-1626-45b2-b2ed-ec02022d7348"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b77b85a7-db40-46b5-88f4-9e698833694e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b7f6c03c-7c79-4a33-b5d2-f2806c3d4a63"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b9512e9e-d2ef-471a-80aa-816249be1410"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba28eccf-18a0-4ba5-8674-565cbb9284b7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bdce18ea-6f9b-4f24-b3db-6a3b164c15f4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c18b85ce-a76e-46cd-93e6-e9e6435a2cb9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3d03dd8-00fa-41ba-a2ab-859f536a8cd9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3d8dfab-48ed-4ada-90c1-5bb0b50ce103"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3fe6515-41a2-4ee3-980c-f1abf2f33449"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c451e700-6117-459e-8f4d-f3419285e64f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c57af3bc-b38b-4bb4-b068-6d8fc9822ce3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c5a25aa8-0d48-4379-95f0-4f1416ce80c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca5d4118-77d2-4b04-b2bf-e95f226d0932"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd5375bd-7ebe-45e0-b0f2-a4e86c563cdf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ceb2ed33-5d6d-47eb-a0ff-f3ac354f1ccd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf897367-02da-4cd4-86b2-6443d18d3a0a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf8ef81b-aae5-424c-b151-213d183742e7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cfd63502-8d39-4573-a253-0efbf248d41a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0b332a2-e578-459a-9d9b-068bb10f25a4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2807e61-a019-4f59-a263-eb6c0402d535"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d306464a-15be-4d7b-9ad8-9dbde0a24e2e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d4214fc5-3d2a-41e3-8052-7401a53281d2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d5dc398b-552f-4156-8f53-e8d506f5a8c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d70a9852-72af-4a52-9e0a-08918d05ef4a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d757b0b9-9a76-4ae7-a97d-f988f35c6436"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d83d0f3a-a155-495f-9d04-a249a35dc314"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dbb3ceab-f5ea-4bf7-bce2-40fdc58e710e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc9d3ee2-4ccf-46ec-898d-891e3b8e4026"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ded194cb-4a71-477c-be15-f534a05dcf3a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0a31581-07a2-47c9-8332-708d747911ef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0ab1cf1-ac85-4bc7-a18d-1ede0e91f6e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0bdf8bf-af6c-42c9-af22-e445a63c35c0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e40a600f-8673-4dc5-96e8-7d818e5a897e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e57e56a0-df97-4b24-9ea9-00eab1ca13b6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e719bfbc-f310-429f-a811-b81fbd032101"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e8ca3b7c-1904-43b9-9a06-aafed1d2ac4d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea6dacb9-8e97-4807-a531-d78285f7c56f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee12dab6-5704-463a-9213-e319b18c4b98"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f087ada7-2be2-41c1-b219-485d750a43f9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0e7b2fe-45ad-4503-9ad0-1528bf974dc6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0ff4e4e-2afa-4338-95eb-71c4addcbadd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f155b796-e947-4b69-b4c7-00ba5ed7db46"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f2ed258f-daf6-4e16-af2e-0fb64a9b542f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f41919b8-1e82-4e26-be97-6d63f81a6c09"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f641e2cf-fca2-497f-b532-8f1fd100a84e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6692cee-bfdc-4bd0-bfe5-d34be8303ac3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f7c245db-a7f7-4471-bd3c-4363fb486879"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8d1d0c3-58ca-49db-b528-3fcb6390f1d6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9861c30-462f-40ab-8d34-53544ac2bcbb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9fd46c8-1f1e-469b-8ab1-7fb841948109"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd912528-a116-4021-b9a1-39ce66bafbec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe008a13-117d-4be0-ac76-c4647b2e3ff6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("02b1eeb2-c742-4493-a0b8-e62a5ff5f475"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("09c23e83-6de9-42d4-bd5f-50abe8bf832f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("12b1e798-4357-4b04-a86f-f4f95c073c93"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("16c04489-8103-4cfa-b3c2-bcc7cd6bf7f0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("22450057-4a1e-4b08-906c-9858f144c38b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("224a554a-1dbf-463a-9953-825bc76077aa"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("23b73b33-f632-4a80-9b6e-b0b199161145"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("46140631-f915-4d34-a645-e3eb0105dd20"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("56335b38-65e0-4b8f-b411-d84b564a2901"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("70459bb8-d643-4f4a-b880-f70f50e667b8"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("769a45a0-e704-4200-aace-976c46858a85"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("843b8d83-902e-4340-aab8-4996dac8e4d7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("91043061-8f99-4b48-b0e6-801c16cb906d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("95ccf064-02d7-4be9-8815-bd12706fbea7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9ab8e070-c021-4e2d-a142-3db2b883e785"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a5a77c54-183c-4294-9180-94efb4be3e9c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("abaa0e18-d926-4e80-9afe-aedb9e234c01"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b797d732-0c95-44e7-a782-29b98cd7b015"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("bc8f1b64-3107-41cf-88eb-926e0eb27747"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c70eaa6a-b2d5-4666-81a5-5ff777a4d08a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dc0252ec-4386-4b83-8e50-18a94c9efdb9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e86ef87e-8a0a-4927-8da7-4b4f340720b5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f6ba1742-a983-40b8-a83a-11c9f09e0476"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("04d4b36b-3775-4d55-8785-9884c89328a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("45807a74-d366-456c-b377-cefeb6862e00"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62a48e04-d094-457c-ab11-75827c54cf6f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9db8be88-aa06-4ee0-a2ec-fe255d2790bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7ac3b22-9484-4d7d-b2d2-cad3312ea9d9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae05c208-09c8-4432-b137-394210902ce6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cae7cfab-89c4-496a-8939-da49a3020638"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("de5d8d99-cd21-42aa-973b-ab5a5efe521c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed1b1cba-6cbf-47fa-8930-d33889a6bf67"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1b66934-5539-4430-8fb8-41cd4c247808"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa35eaed-bf12-4e13-a2c4-c15106bd1d0a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb72906b-5164-4a37-86b3-b0e3cdda6737"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("01ffca24-2564-4c68-8319-bdda5e47c0ef"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1823743a-0843-41d4-ae98-57a1c8baa51c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("320b286d-767a-4fb3-b8df-275bd0fa6d23"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3a32ffe2-5101-4e25-abc4-d25064f616be"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3f3ec582-660c-4d34-ad0a-885e60c285db"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4955790a-36b1-4913-9a80-1c978cb8c6fa"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("752aa33f-e155-4f4f-917b-34bdf35923d6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("792e20ab-68b6-4d50-be5c-754ad81714ca"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8b8c5359-d182-42dd-b78c-1c7a417310b9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a5f959bc-74a8-4466-bc65-cfb473ba8775"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f8808f01-73a1-4272-8940-75d5bf397ece"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5259b681-3f24-4486-8d03-736ed1590e40"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8dd6431b-e715-4a9b-b376-52b6f98016b8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9f3a4b1b-68bf-4b11-af8b-d10a4de3c354"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e657d813-86fa-481b-a3bb-b0aae9a5f249"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1dc8bc4-4238-4eb4-abb3-67a2bfe0b9e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed45d6e9-e8f6-4fbe-95cf-6a3c7622f1f7"));

            migrationBuilder.RenameColumn(
                name: "OpenningHours",
                table: "Places",
                newName: "State");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "Trips",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConditionProfileId",
                table: "Trips",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryProfileId",
                table: "Trips",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<decimal>(
                name: "Budget",
                table: "Trips",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PredictedCost",
                table: "TripPoints",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "OpeningTime",
                table: "TripPoints",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "TripPoints",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "ClosingTime",
                table: "TripPoints",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "TripPointReviews",
                type: "decimal(2,1)",
                precision: 2,
                scale: 1,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "TripPointReviews",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualCost",
                table: "TripPointReviews",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Places",
                type: "decimal(18,8)",
                precision: 18,
                scale: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Places",
                type: "decimal(18,8)",
                precision: 18,
                scale: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "OpeningHours",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("57e0189d-d34f-4567-acb3-8241256edf2e"), null, "entertainment", null },
                    { new Guid("7f09604a-d8e6-4b92-8776-f291a200b4f6"), null, "heritage", null },
                    { new Guid("8ae939e5-5b08-46ae-bd8f-a4505c240bc1"), null, "natural", null },
                    { new Guid("9a9df710-4e94-4468-a563-29390e2863ca"), null, "sport", null },
                    { new Guid("a34b6fd8-d96e-4023-bbae-20c9159a7ed9"), null, "commercial", null },
                    { new Guid("b3df5236-548d-40e0-b808-fa5034f9c801"), null, "religion", null },
                    { new Guid("bc731725-7367-4489-bbe9-e5332b8e435c"), null, "leisure", null },
                    { new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd"), null, "catering", null },
                    { new Guid("e57ea627-d5f6-437e-9c51-4692cd28a3fb"), null, "activity", null },
                    { new Guid("ec3a3a0d-dbc6-4c8f-8109-cd5390510872"), null, "national park", null },
                    { new Guid("f1555acf-73b5-46a9-9b48-e88d2b4873bc"), null, "tourism", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("1b16a934-5c58-43ec-b7f4-e428c6470aae"), null, "fee", null },
                    { new Guid("24b84cc1-4ab0-4812-bc78-9e298284b1ce"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("379c243d-6ba0-490d-9b29-bd5ff48b59dc"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("5240d496-3ed0-41e5-ab61-bee0a6417913"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("534f8f6a-f464-4afb-acfa-16d434f2fc58"), null, "dogs", null },
                    { new Guid("5777c98b-9523-4e22-8c07-5a5da0670490"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("7d336772-6373-4cb7-9168-04f1a4b2ccd6"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("896fda87-b673-490b-af30-ea01a4e6f3a4"), null, "internet_access", null },
                    { new Guid("a37a0de3-b5c6-43b9-892e-3cb5dfc2da84"), null, "access_limited", null },
                    { new Guid("b290c3ce-09d4-4017-b3c5-7d9f9d67416e"), null, "no-dogs", null },
                    { new Guid("bdd0e2ad-d383-4f54-a6f1-08a4d7dea32e"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("bec4d8c7-64fa-4d8d-9fc5-870c80e2992d"), "Name property defined for the place", "named", null },
                    { new Guid("c8d140b4-e65f-40e9-86b3-a133078c0659"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("c9f273be-b47b-4f3e-9b1b-ba0542ca3c82"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("d3e01f75-e3de-45b2-8915-7bb242e9ed3c"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("e0249000-adc3-4478-a84c-05ed32ba41c6"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("ec173ad8-b781-4ab3-a75e-a379e605cf84"), null, "access", null },
                    { new Guid("f178f4ec-5625-4015-be1d-887107e2b59c"), null, "wheelchair", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0467ee52-28e4-4040-8cb8-546079c1f33e"), null, "food_court", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("05969b81-413d-43c5-a83a-07f7ebd9d982"), null, "planetarium", new Guid("57e0189d-d34f-4567-acb3-8241256edf2e") },
                    { new Guid("05b0369d-ada3-4c8a-afeb-2f1f4c958d01"), null, "zoo", new Guid("57e0189d-d34f-4567-acb3-8241256edf2e") },
                    { new Guid("06daa607-a132-428c-9999-25d959ea7455"), null, "art", new Guid("a34b6fd8-d96e-4023-bbae-20c9159a7ed9") },
                    { new Guid("0a14deed-bd39-45b2-81e1-6e5f2433dfef"), null, "gift_and_souvenir", new Guid("a34b6fd8-d96e-4023-bbae-20c9159a7ed9") },
                    { new Guid("0de06a81-171e-4155-ac53-1a03a9a8b6c5"), null, "park", new Guid("bc731725-7367-4489-bbe9-e5332b8e435c") },
                    { new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3"), null, "fast_food", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1"), null, "restaurant", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("370c4141-f69b-442d-b241-b310e160b52b"), null, "pub", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("3b83ab7f-ec41-4171-a13a-04dd64a580f3"), null, "sand", new Guid("8ae939e5-5b08-46ae-bd8f-a4505c240bc1") },
                    { new Guid("3ce47e1f-9b87-46f2-a6cb-b8e47c05ec8f"), null, "culture", new Guid("57e0189d-d34f-4567-acb3-8241256edf2e") },
                    { new Guid("43f13145-8b6c-42ae-8392-69b8b71f5e39"), null, "ice_cream", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("58a44544-7d9a-40e8-9193-422211af25fb"), null, "attraction", new Guid("f1555acf-73b5-46a9-9b48-e88d2b4873bc") },
                    { new Guid("5ad048e0-d065-49fa-ba39-8dd6ca255cac"), null, "taproom", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908"), null, "place_of_worship", new Guid("b3df5236-548d-40e0-b808-fa5034f9c801") },
                    { new Guid("67501f57-c9b7-4f76-aa2c-90afee0b477f"), null, "biergarten", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("705a7c87-1851-4db3-a1d9-893629f633fa"), null, "mountain", new Guid("8ae939e5-5b08-46ae-bd8f-a4505c240bc1") },
                    { new Guid("7c1b3163-0882-4906-9f29-b25c5e95be5d"), null, "bar", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("7f4d9e43-3297-4fc5-b710-5b300bb7cede"), null, "forest", new Guid("8ae939e5-5b08-46ae-bd8f-a4505c240bc1") },
                    { new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34"), null, "cafe", new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd") },
                    { new Guid("9b34500f-f877-42de-a0fe-0e3722c35117"), null, "sights", new Guid("f1555acf-73b5-46a9-9b48-e88d2b4873bc") },
                    { new Guid("a44373bb-a84a-445c-b0f2-79183dda089d"), null, "water", new Guid("8ae939e5-5b08-46ae-bd8f-a4505c240bc1") },
                    { new Guid("a71ba830-1232-4bd1-9827-5097721c318f"), null, "unesco", new Guid("7f09604a-d8e6-4b92-8776-f291a200b4f6") },
                    { new Guid("a7fa9dd6-ed42-46ef-af94-3d7d7a26a6b0"), null, "aquarium", new Guid("57e0189d-d34f-4567-acb3-8241256edf2e") },
                    { new Guid("bfc936d4-1985-4db0-994f-475b3f38cbe6"), null, "museum", new Guid("57e0189d-d34f-4567-acb3-8241256edf2e") },
                    { new Guid("e01f2f14-1036-4519-b8d4-0fe7f78a9481"), null, "stadium", new Guid("9a9df710-4e94-4468-a563-29390e2863ca") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("192ffe56-c449-4a63-bbf5-43ee97b1d31b"), null, "yes", new Guid("534f8f6a-f464-4afb-acfa-16d434f2fc58") },
                    { new Guid("1dc9e872-e0bf-4c90-b05e-f66953426d2a"), null, "leashed", new Guid("534f8f6a-f464-4afb-acfa-16d434f2fc58") },
                    { new Guid("2783f6c2-5471-4dfd-b50b-5f2d876ae645"), null, "yes", new Guid("f178f4ec-5625-4015-be1d-887107e2b59c") },
                    { new Guid("8205e02f-41d5-42ce-8409-3e21cda1a4c2"), null, "free", new Guid("896fda87-b673-490b-af30-ea01a4e6f3a4") },
                    { new Guid("85224a5e-5bb6-449e-9132-1943ea7fe43f"), null, "limited", new Guid("f178f4ec-5625-4015-be1d-887107e2b59c") },
                    { new Guid("91b23d43-09be-42df-8c5e-c32a93b5347a"), null, "only", new Guid("bdd0e2ad-d383-4f54-a6f1-08a4d7dea32e") },
                    { new Guid("96661011-8574-4f45-94f5-f8cd8db06a8f"), null, "no", new Guid("379c243d-6ba0-490d-9b29-bd5ff48b59dc") },
                    { new Guid("9e979cba-5788-45d5-bf78-25d29f3333bc"), null, "only", new Guid("5240d496-3ed0-41e5-ab61-bee0a6417913") },
                    { new Guid("a300ae22-19ce-4642-b514-92f3bac1af1b"), null, "only", new Guid("c8d140b4-e65f-40e9-86b3-a133078c0659") },
                    { new Guid("a6ba940d-6ee8-4f01-9709-c6aeae9b4b5b"), null, "not_specified", new Guid("ec173ad8-b781-4ab3-a75e-a379e605cf84") },
                    { new Guid("b0cce8c6-96f4-403f-b30e-f49276cd5e23"), null, "for_customers", new Guid("896fda87-b673-490b-af30-ea01a4e6f3a4") },
                    { new Guid("b4bf2fbc-4247-4649-9f2a-07c31e92d872"), null, "only", new Guid("7d336772-6373-4cb7-9168-04f1a4b2ccd6") },
                    { new Guid("c0c22b29-6ab3-43bc-a377-1bb330b3cddf"), null, "not_specified", new Guid("379c243d-6ba0-490d-9b29-bd5ff48b59dc") },
                    { new Guid("cabeebe7-b836-4979-8023-0b755374a8a5"), null, "only", new Guid("24b84cc1-4ab0-4812-bc78-9e298284b1ce") },
                    { new Guid("ce532aab-4e4c-4b4a-9ebf-089835c5c0b4"), "Places that are available for public", "yes", new Guid("ec173ad8-b781-4ab3-a75e-a379e605cf84") },
                    { new Guid("d600fd2f-b6fc-4727-8c0d-4e157b994042"), null, "customers", new Guid("a37a0de3-b5c6-43b9-892e-3cb5dfc2da84") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("005fe19c-5244-474a-9806-96c6f4ab397e"), null, "argentinian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("014462c9-4528-44b8-88ac-639ca1eaea9c"), null, "cliff", new Guid("705a7c87-1851-4db3-a1d9-893629f633fa") },
                    { new Guid("034caad1-2388-4665-a9f4-49691cae2ad4"), null, "czech", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("03c781c2-1651-484f-86fc-f7a6c0674cd5"), null, "filipino", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("067df7a7-0db1-4b92-9105-a968163cf3ed"), null, "tacos", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("06b1806e-7736-421b-a278-908689bee902"), null, "pita", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("0aee728d-ea56-4003-a377-d2ce0d5cc1e5"), null, "city_hall", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("0bcb0ca9-821e-4423-9a79-313e30431685"), null, "bolivian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("0c66ebbe-4638-43f7-99df-c3e0dd2e67ea"), null, "georgian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("0e32b255-35af-4bfc-9621-d51856bba8fa"), null, "shinto", new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908") },
                    { new Guid("106e5044-5bcd-4e8d-9f9f-f6c9c9631eb1"), null, "brazilian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("10b9c99c-c50e-4364-b4c4-b84ddcfbd2e9"), null, "thai", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("11b40327-8f1d-4c8a-b858-581196dfa8f5"), null, "malaysian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("13649bc1-fa76-439f-af98-c67ce837f94f"), null, "friture", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("136acccd-1d72-4f75-82a6-0cee7cd2b97b"), null, "pita", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("13b55779-f75f-4837-8811-e1fd37ac5c2d"), null, "spring", new Guid("a44373bb-a84a-445c-b0f2-79183dda089d") },
                    { new Guid("141fabe4-7a4f-4166-931b-22d3063cf8c3"), null, "arts_centre", new Guid("3ce47e1f-9b87-46f2-a6cb-b8e47c05ec8f") },
                    { new Guid("15093a0b-7d0c-4f17-b4ff-381244eccade"), null, "pakistani", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("178e0d4f-6392-4239-9c13-c4fcdd4f0942"), null, "ethiopian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("17d903f7-dda4-4fb8-ade8-29830a940eab"), null, "sea", new Guid("a44373bb-a84a-445c-b0f2-79183dda089d") },
                    { new Guid("187ac250-46c8-4726-943d-528b9f28de78"), null, "regional", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("1917128f-c738-40e1-a266-f14bf344d056"), null, "hot_dog", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("1b2509cf-51eb-4a35-8754-8b6c51534689"), null, "theatre", new Guid("3ce47e1f-9b87-46f2-a6cb-b8e47c05ec8f") },
                    { new Guid("1c01aab9-a68e-4207-bfb9-baa9457545c9"), null, "clock", new Guid("58a44544-7d9a-40e8-9193-422211af25fb") },
                    { new Guid("1c835c6d-1d6b-4533-9b69-6fa2b868e6ad"), null, "sandwich", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("1d93602d-b92c-44d8-8915-f7667bf8b9bf"), null, "sikhism", new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908") },
                    { new Guid("1ebf4b8f-e987-4457-9f65-d7ed09f8a12b"), null, "noodle", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("1fd9b279-1c4a-4966-b456-fdf28eda5815"), null, "ramen", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("20d33b25-d14f-46e8-abc1-76fc77dd6d8a"), null, "peruvian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("222fdd74-54c6-4a54-97c6-94face036eb3"), null, "balkan", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("263c5bef-f93e-497c-aae1-5d33a63ca74a"), null, "garden", new Guid("0de06a81-171e-4155-ac53-1a03a9a8b6c5") },
                    { new Guid("2867fc24-2ebd-4102-b999-e4c9d68c8297"), null, "belgian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("32495d28-c406-4058-8670-0bcf25b2d26c"), null, "chinese", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("344ce4ee-702f-401a-ae0c-700a6abd5943"), null, "croatian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("3504faa9-ab33-4a0b-a816-6a3019ed4a0f"), null, "sandwich", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("370b23dd-9e99-44c7-845f-9d4db08b10a3"), null, "frozen_yogurt", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("3b9d70f9-16ab-4ebe-b37f-91867e88f120"), null, "caribbean", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("3caef20f-05fc-41ba-86d5-210e18a407e8"), null, "gallery", new Guid("3ce47e1f-9b87-46f2-a6cb-b8e47c05ec8f") },
                    { new Guid("3ebafe7e-c9d3-41b2-936d-469249376c05"), null, "dessert", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("41f35c29-c3bf-4869-8316-98873976b364"), null, "tapas", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("43cbe97f-bcb5-4fe9-8795-fce5b4edd8c5"), null, "tower", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("440fe3c2-4450-4c77-8d22-6b92f9eef558"), null, "rock", new Guid("705a7c87-1851-4db3-a1d9-893629f633fa") },
                    { new Guid("454b4711-8136-4ca7-85ae-b4c4b1bcb1fc"), null, "moroccan", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("47f80fea-b051-4b2e-a4ee-76692077521d"), null, "greek", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("4873be12-80d4-4fee-9963-0d1abc7c0eae"), null, "dumpling", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("4985dc88-80eb-4b32-953d-8a3d50a16832"), null, "wings", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("4a2840b3-d222-4ed4-a696-4cc7f0e90150"), null, "battlefield", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("4f55e729-1a62-4fa2-ae88-b8ef6cb93069"), null, "coffee", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("51e2004e-a8d5-49c0-b2b3-048b3cb8b303"), null, "burger", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("54522a3b-f40a-4c13-a4f7-7fab383929d0"), null, "indian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("54797ed8-d0e8-4677-94c8-7550bb2263a6"), null, "european", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("54ead43a-6729-453e-943d-4d6592b8abcf"), null, "pizza", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("5545a921-4427-4082-813f-01e486af1713"), null, "windmill", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("581a4047-04d2-4dab-b738-02ce4fcf4993"), null, "christianity", new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908") },
                    { new Guid("59153f43-ed71-4e92-a224-2efc8e31370e"), null, "kebab", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("5a0af4e4-5353-4269-9308-b03505170ffe"), null, "buddhism", new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908") },
                    { new Guid("5a18000a-2721-4345-86b2-3ac72c395cb5"), null, "hot_spring", new Guid("a44373bb-a84a-445c-b0f2-79183dda089d") },
                    { new Guid("5a8447b6-664f-4f0b-9d77-23c2648a3739"), null, "austrian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32"), null, "place_of_worship", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("60373b44-94bc-4fa9-be7f-62088941fde3"), null, "latin_american", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("6250cc0e-0cdc-475d-8df1-ae50ff8ec2f1"), null, "dune", new Guid("3b83ab7f-ec41-4171-a13a-04dd64a580f3") },
                    { new Guid("63018ae7-7159-4b24-8134-fe6eaad89fb1"), null, "nature_reserve", new Guid("0de06a81-171e-4155-ac53-1a03a9a8b6c5") },
                    { new Guid("632bd619-6f4d-44dc-a911-75fafe51cba7"), null, "fish", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("65d4cb1e-f3b4-4d6a-bffc-bcaef81f35b4"), null, "city_gate", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("662c7a20-ed06-4d7c-a8a9-d0a84260a406"), null, "kebab", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("665c7330-769d-430f-80a0-61b491dd51d1"), null, "donut", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("6b42ab0c-e010-4bf7-a4b2-842605f986a3"), null, "cave_entrance", new Guid("705a7c87-1851-4db3-a1d9-893629f633fa") },
                    { new Guid("6f3def45-3e2f-4e5b-8543-9552c1373aaf"), null, "wings", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("6fd5a5bb-d6b5-4fc6-ab2b-16c6a07f03d2"), null, "hawaiian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("71aea8d7-5785-411c-af05-5c13bc29320f"), null, "international", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("72094f06-b65e-435b-b9de-7930f5e4882b"), null, "russian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("7233e23b-6524-42d1-8deb-9a918470c544"), null, "oriental", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("73bd7660-617a-4434-b887-9a94cac462b1"), null, "cake", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("7818ec97-5368-4085-a023-24e8fdd64b64"), null, "hinduism", new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908") },
                    { new Guid("78891299-d0eb-48ec-8179-971652bede1e"), null, "fish_and_chips", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("7930d107-98b8-4f33-9714-da5b4df76123"), null, "steak_house", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("79443788-0a62-4572-8344-c6ecd7f02c3b"), null, "indonesian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("7c26ec27-266d-4f73-a77a-5cd6e4af9fab"), null, "uzbek", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("7decc880-3fa9-4ee4-be3c-9a982be4fe13"), null, "multifaith", new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908") },
                    { new Guid("899337b7-4297-47a4-b0dc-c6533eee826d"), null, "tea", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("8d5c1e90-a09e-4f83-acc1-27b5aa56e9fa"), null, "syrian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("901f7afb-7a88-442b-8e40-c33bd7542f70"), null, "french", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("912e831a-a762-4caa-b9e6-153cc1697a82"), null, "tex-mex", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("922ac5c1-be1f-488b-83c4-9c10199ec1d0"), null, "archaeological_site", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("925c6f71-bf90-4c90-bb10-860da88e277d"), null, "castle", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("9297b507-e6e5-4447-99b3-8692fb483a45"), null, "swedish", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("93ac4a58-5dc9-4344-b223-21f4a28b24ae"), null, "malay", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("94fb0988-cc75-44fb-8d0b-183e87027e91"), null, "african", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("960746e0-9dd3-4275-aa8d-5f5b11f0d4b2"), null, "fountain", new Guid("58a44544-7d9a-40e8-9193-422211af25fb") },
                    { new Guid("974e6f27-99a5-44d0-b492-9a30bd39b136"), null, "bubble_tea", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("98a43258-1267-47c9-b2d5-ab8902e4695e"), null, "monastery", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("9aec4f2e-76bf-42cb-8b11-4f26271ae584"), null, "coffee_shop", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("9c1e55c5-8b1b-4e5f-82c0-59ebc3e16054"), null, "mexican", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("a17b6eb1-1864-4818-b73a-036c9b98b724"), null, "ukrainian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("a18e7cb3-b25c-44a1-8f47-35023ce37248"), null, "spanish", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("a2efe75c-f1b3-4113-a6f5-47bfa30af9dc"), null, "sushi", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("a75cba8b-ad19-497b-9ec0-0b8f8a0eb004"), null, "soup", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("a981c7e4-4fca-4669-b17a-88104112f867"), null, "salad", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("aa015593-821e-45e4-b9b9-00b2c0842252"), null, "tapas", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("ac058a1e-2dc0-4555-b520-fbeeb41ba5d1"), null, "lighthouse", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("ad2292f5-061a-4aea-a049-ecfbc1c42e25"), null, "tacos", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("ad935338-be92-4ecc-a0ec-972e474bbd03"), null, "western", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536"), null, "memorial", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("ae62b254-e07a-4747-b9ab-2b53f5aa62cd"), null, "german", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("b279f1e7-097f-43e9-a3ff-ad218ab95836"), null, "italian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("b4e40e0f-f0b5-4761-bbd2-48b37edb1865"), null, "chili", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("b5a0fa06-28dc-4968-9127-75d9fafcaa7c"), null, "irish", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("b5abebdd-498c-418a-87f1-0fc89f3c3d46"), null, "asian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("b66d8777-b317-43aa-afe0-ba71497352b3"), null, "fish_and_chips", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("bb9e90e8-8421-4000-abcf-e060af4f682f"), null, "burger", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("bc135ec0-f4cf-4155-bdc2-47321be411e4"), null, "vietnamese", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("bd323604-402e-48b5-b49d-8310cf889de9"), null, "pizza", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("bf75bdea-bccd-4b7f-8087-ef408ec14886"), null, "fort", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("c21e03c6-4b43-417d-b5be-38fc912af96e"), null, "geyser", new Guid("a44373bb-a84a-445c-b0f2-79183dda089d") },
                    { new Guid("c32c545a-d334-4900-894c-d1a6263494e6"), null, "noodle", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("c4e32fe6-1fa3-4877-aa76-811ab1dcf10e"), null, "artwork", new Guid("58a44544-7d9a-40e8-9193-422211af25fb") },
                    { new Guid("c517b227-67c5-4474-91a0-027a0e7b36d0"), null, "bavarian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("c5395948-758b-4f38-abed-9ee8114643b3"), null, "beef_bowl", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("c65fefaa-212b-4e79-b744-76bfd2aeaf1e"), null, "korean", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("c79afb13-c091-4c87-a48f-2f760645ff79"), null, "islam", new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908") },
                    { new Guid("c8fe7f71-9c0f-4473-92cb-907d2c0374dd"), null, "glacier", new Guid("705a7c87-1851-4db3-a1d9-893629f633fa") },
                    { new Guid("c912fb90-e77a-48f8-9558-4ba85fbe5a5a"), null, "turkish", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("c9c70b43-8b7f-4473-8dcb-298268ea6d67"), null, "seafood", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("ce15bfce-bdfa-453b-a204-c3d6819816b0"), null, "jamaican", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("d31609bc-d0f3-45b5-89ee-d64c7cda10fd"), null, "danish", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("d76ecb5e-3611-4974-ab66-a2089f2bc0a8"), null, "barbecue", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("d8166420-0d3c-4d1e-822f-c7b2621ccff4"), null, "nepalese", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("d8d2f973-2faa-4448-aad7-5ef28d8fd082"), null, "hungarian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("d91065f6-9de2-438f-acd2-8d182dadadd5"), null, "bridge", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("dcbdcab5-00e5-4f52-9d8b-20f26a4df826"), null, "cuban", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("df1ca42a-0c5c-4397-99cc-25e21dea8521"), null, "curry", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("df815f39-79c1-4a4e-a2ab-f6c4b4f933fa"), null, "persian", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("e085ce01-038c-4018-aec6-103f5c6b905c"), null, "japanese", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("e2469474-b45d-4228-ae42-a88eb594303a"), null, "viewpoint", new Guid("58a44544-7d9a-40e8-9193-422211af25fb") },
                    { new Guid("e484f99b-c7ad-47a1-9557-f0cdbfa10e17"), null, "mediterranean", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("e62abfaf-8df5-47e5-a894-6fa4054723ab"), null, "ice_cream", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("e7179810-684f-4733-baa0-d28f8ca158e0"), null, "waffle", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("e8b3c565-eaf5-4bc3-b9b4-b9b11f2a7268"), null, "afghan", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("e9e0e7cc-915e-4373-826d-fa586471db25"), null, "lebanese", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("ef620cf6-ec7e-4737-857d-4d3a74f168fc"), null, "american", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("ef654fd6-3377-4e23-a036-2c390dbaf178"), null, "reef", new Guid("a44373bb-a84a-445c-b0f2-79183dda089d") },
                    { new Guid("f0178e9b-2366-4cb9-91ab-f5795f5f36cd"), null, "arab", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("f0b39f95-84dc-4974-88cd-e5900b0cd1e3"), null, "crepe", new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34") },
                    { new Guid("f0fefaac-ac3f-4d16-9b97-e3d165380c4a"), null, "chicken", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("f364ea67-57fa-4e7c-b662-4943a0755041"), null, "ramen", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("f5d24ded-db7f-493f-8842-7f349718cdab"), null, "peak", new Guid("705a7c87-1851-4db3-a1d9-893629f633fa") },
                    { new Guid("f74cdf9d-6018-4103-a23c-e736c76e8d5c"), null, "taiwanese", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("f82bbc9f-6faa-4437-8fae-dd63d35d16f7"), null, "soup", new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3") },
                    { new Guid("f83c7787-8dad-4c6a-a7fb-5ffe469b1620"), null, "judaism", new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908") },
                    { new Guid("f8d72a8d-9496-42a2-962a-266a370e7dfd"), null, "portuguese", new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1") },
                    { new Guid("fe6a78e4-6730-4834-9cbf-f79f919e22aa"), null, "ruines", new Guid("9b34500f-f877-42de-a0fe-0e3722c35117") },
                    { new Guid("144210cc-da22-47c5-abb6-537b1eae3868"), null, "church", new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32") },
                    { new Guid("18476643-a1e6-415a-9925-bd5737f19a48"), null, "temple", new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32") },
                    { new Guid("1bc1416e-0a07-4b45-bcaa-e6869dee4db8"), null, "pillory", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("2713f751-06c0-41b7-b30d-f1a93052b272"), null, "shrine", new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32") },
                    { new Guid("40ed182c-6ae5-4ce8-a2c7-a5f06cd1e42b"), null, "chapel", new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32") },
                    { new Guid("44236346-2c25-48b8-b028-bfa1e1d289d3"), null, "aircraft", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("47a80f94-04cd-48bf-b8ac-b887ff85ecbf"), null, "locomotive", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("6a575725-17c8-4883-b099-6f9a1a3cbc0a"), null, "monument", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("7808efee-4686-4dae-902c-07d290c9a294"), null, "ship", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("808dde61-f861-4239-9ea7-a6c8a398f902"), null, "synagogue", new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32") },
                    { new Guid("82ba194d-8f7c-4f0a-a794-895523bf1a1a"), null, "cathedral", new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32") },
                    { new Guid("8851f007-e10c-4cdb-bc4d-471f52fd6974"), null, "tank", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("a3a045ba-b489-4d7b-8063-c7962360b9c4"), null, "boundary_stone", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("b8b6078d-dda3-4e46-b747-6feb11bed3bf"), null, "mosque", new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32") },
                    { new Guid("d1176bb2-9add-42ce-9443-04ff4c673878"), null, "railway_car", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("de4cd6ca-da99-45c6-83fc-2cc3a456e53d"), null, "tomb", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("e1b317cb-9c70-43d2-8721-6810c4eefee7"), null, "milestone", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") },
                    { new Guid("e2f0d783-b1de-45d9-83e4-a8310279909b"), null, "wayside_cross", new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_CategoryProfiles_CategoryProfileId",
                table: "Trips",
                column: "CategoryProfileId",
                principalTable: "CategoryProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_ConditionProfiles_ConditionProfileId",
                table: "Trips",
                column: "ConditionProfileId",
                principalTable: "ConditionProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_CategoryProfiles_CategoryProfileId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_ConditionProfiles_ConditionProfileId",
                table: "Trips");

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("005fe19c-5244-474a-9806-96c6f4ab397e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("014462c9-4528-44b8-88ac-639ca1eaea9c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("034caad1-2388-4665-a9f4-49691cae2ad4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("03c781c2-1651-484f-86fc-f7a6c0674cd5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0467ee52-28e4-4040-8cb8-546079c1f33e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05969b81-413d-43c5-a83a-07f7ebd9d982"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("05b0369d-ada3-4c8a-afeb-2f1f4c958d01"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("067df7a7-0db1-4b92-9105-a968163cf3ed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("06b1806e-7736-421b-a278-908689bee902"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("06daa607-a132-428c-9999-25d959ea7455"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a14deed-bd39-45b2-81e1-6e5f2433dfef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0aee728d-ea56-4003-a377-d2ce0d5cc1e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0bcb0ca9-821e-4423-9a79-313e30431685"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c66ebbe-4638-43f7-99df-c3e0dd2e67ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e32b255-35af-4bfc-9621-d51856bba8fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("106e5044-5bcd-4e8d-9f9f-f6c9c9631eb1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("10b9c99c-c50e-4364-b4c4-b84ddcfbd2e9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("11b40327-8f1d-4c8a-b858-581196dfa8f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13649bc1-fa76-439f-af98-c67ce837f94f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("136acccd-1d72-4f75-82a6-0cee7cd2b97b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13b55779-f75f-4837-8811-e1fd37ac5c2d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("141fabe4-7a4f-4166-931b-22d3063cf8c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("144210cc-da22-47c5-abb6-537b1eae3868"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("15093a0b-7d0c-4f17-b4ff-381244eccade"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("178e0d4f-6392-4239-9c13-c4fcdd4f0942"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17d903f7-dda4-4fb8-ade8-29830a940eab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18476643-a1e6-415a-9925-bd5737f19a48"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("187ac250-46c8-4726-943d-528b9f28de78"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1917128f-c738-40e1-a266-f14bf344d056"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b2509cf-51eb-4a35-8754-8b6c51534689"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1bc1416e-0a07-4b45-bcaa-e6869dee4db8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c01aab9-a68e-4207-bfb9-baa9457545c9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c835c6d-1d6b-4533-9b69-6fa2b868e6ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d93602d-b92c-44d8-8915-f7667bf8b9bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1ebf4b8f-e987-4457-9f65-d7ed09f8a12b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fd9b279-1c4a-4966-b456-fdf28eda5815"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20d33b25-d14f-46e8-abc1-76fc77dd6d8a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("222fdd74-54c6-4a54-97c6-94face036eb3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("263c5bef-f93e-497c-aae1-5d33a63ca74a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2713f751-06c0-41b7-b30d-f1a93052b272"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2867fc24-2ebd-4102-b999-e4c9d68c8297"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("32495d28-c406-4058-8670-0bcf25b2d26c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("344ce4ee-702f-401a-ae0c-700a6abd5943"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3504faa9-ab33-4a0b-a816-6a3019ed4a0f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("370b23dd-9e99-44c7-845f-9d4db08b10a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("370c4141-f69b-442d-b241-b310e160b52b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b9d70f9-16ab-4ebe-b37f-91867e88f120"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3caef20f-05fc-41ba-86d5-210e18a407e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ebafe7e-c9d3-41b2-936d-469249376c05"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("40ed182c-6ae5-4ce8-a2c7-a5f06cd1e42b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41f35c29-c3bf-4869-8316-98873976b364"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("43cbe97f-bcb5-4fe9-8795-fce5b4edd8c5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("43f13145-8b6c-42ae-8392-69b8b71f5e39"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("440fe3c2-4450-4c77-8d22-6b92f9eef558"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("44236346-2c25-48b8-b028-bfa1e1d289d3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("454b4711-8136-4ca7-85ae-b4c4b1bcb1fc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("47a80f94-04cd-48bf-b8ac-b887ff85ecbf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("47f80fea-b051-4b2e-a4ee-76692077521d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4873be12-80d4-4fee-9963-0d1abc7c0eae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4985dc88-80eb-4b32-953d-8a3d50a16832"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a2840b3-d222-4ed4-a696-4cc7f0e90150"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f55e729-1a62-4fa2-ae88-b8ef6cb93069"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51e2004e-a8d5-49c0-b2b3-048b3cb8b303"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("54522a3b-f40a-4c13-a4f7-7fab383929d0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("54797ed8-d0e8-4677-94c8-7550bb2263a6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("54ead43a-6729-453e-943d-4d6592b8abcf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5545a921-4427-4082-813f-01e486af1713"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("581a4047-04d2-4dab-b738-02ce4fcf4993"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("59153f43-ed71-4e92-a224-2efc8e31370e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a0af4e4-5353-4269-9308-b03505170ffe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a18000a-2721-4345-86b2-3ac72c395cb5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a8447b6-664f-4f0b-9d77-23c2648a3739"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5ad048e0-d065-49fa-ba39-8dd6ca255cac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("60373b44-94bc-4fa9-be7f-62088941fde3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6250cc0e-0cdc-475d-8df1-ae50ff8ec2f1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("63018ae7-7159-4b24-8134-fe6eaad89fb1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("632bd619-6f4d-44dc-a911-75fafe51cba7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("65d4cb1e-f3b4-4d6a-bffc-bcaef81f35b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("662c7a20-ed06-4d7c-a8a9-d0a84260a406"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("665c7330-769d-430f-80a0-61b491dd51d1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("67501f57-c9b7-4f76-aa2c-90afee0b477f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a575725-17c8-4883-b099-6f9a1a3cbc0a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b42ab0c-e010-4bf7-a4b2-842605f986a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f3def45-3e2f-4e5b-8543-9552c1373aaf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fd5a5bb-d6b5-4fc6-ab2b-16c6a07f03d2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("71aea8d7-5785-411c-af05-5c13bc29320f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("72094f06-b65e-435b-b9de-7930f5e4882b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7233e23b-6524-42d1-8deb-9a918470c544"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73bd7660-617a-4434-b887-9a94cac462b1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7808efee-4686-4dae-902c-07d290c9a294"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7818ec97-5368-4085-a023-24e8fdd64b64"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("78891299-d0eb-48ec-8179-971652bede1e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7930d107-98b8-4f33-9714-da5b4df76123"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("79443788-0a62-4572-8344-c6ecd7f02c3b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c1b3163-0882-4906-9f29-b25c5e95be5d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c26ec27-266d-4f73-a77a-5cd6e4af9fab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7decc880-3fa9-4ee4-be3c-9a982be4fe13"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7f4d9e43-3297-4fc5-b710-5b300bb7cede"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("808dde61-f861-4239-9ea7-a6c8a398f902"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82ba194d-8f7c-4f0a-a794-895523bf1a1a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8851f007-e10c-4cdb-bc4d-471f52fd6974"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("899337b7-4297-47a4-b0dc-c6533eee826d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d5c1e90-a09e-4f83-acc1-27b5aa56e9fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("901f7afb-7a88-442b-8e40-c33bd7542f70"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("912e831a-a762-4caa-b9e6-153cc1697a82"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("922ac5c1-be1f-488b-83c4-9c10199ec1d0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("925c6f71-bf90-4c90-bb10-860da88e277d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9297b507-e6e5-4447-99b3-8692fb483a45"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("93ac4a58-5dc9-4344-b223-21f4a28b24ae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("94fb0988-cc75-44fb-8d0b-183e87027e91"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("960746e0-9dd3-4275-aa8d-5f5b11f0d4b2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("974e6f27-99a5-44d0-b492-9a30bd39b136"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("98a43258-1267-47c9-b2d5-ab8902e4695e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9aec4f2e-76bf-42cb-8b11-4f26271ae584"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c1e55c5-8b1b-4e5f-82c0-59ebc3e16054"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a17b6eb1-1864-4818-b73a-036c9b98b724"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a18e7cb3-b25c-44a1-8f47-35023ce37248"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2efe75c-f1b3-4113-a6f5-47bfa30af9dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3a045ba-b489-4d7b-8063-c7962360b9c4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a71ba830-1232-4bd1-9827-5097721c318f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a75cba8b-ad19-497b-9ec0-0b8f8a0eb004"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7fa9dd6-ed42-46ef-af94-3d7d7a26a6b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a981c7e4-4fca-4669-b17a-88104112f867"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa015593-821e-45e4-b9b9-00b2c0842252"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac058a1e-2dc0-4555-b520-fbeeb41ba5d1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad2292f5-061a-4aea-a049-ecfbc1c42e25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad935338-be92-4ecc-a0ec-972e474bbd03"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae62b254-e07a-4747-b9ab-2b53f5aa62cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b279f1e7-097f-43e9-a3ff-ad218ab95836"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b4e40e0f-f0b5-4761-bbd2-48b37edb1865"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b5a0fa06-28dc-4968-9127-75d9fafcaa7c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b5abebdd-498c-418a-87f1-0fc89f3c3d46"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b66d8777-b317-43aa-afe0-ba71497352b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8b6078d-dda3-4e46-b747-6feb11bed3bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb9e90e8-8421-4000-abcf-e060af4f682f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc135ec0-f4cf-4155-bdc2-47321be411e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd323604-402e-48b5-b49d-8310cf889de9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf75bdea-bccd-4b7f-8087-ef408ec14886"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bfc936d4-1985-4db0-994f-475b3f38cbe6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c21e03c6-4b43-417d-b5be-38fc912af96e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c32c545a-d334-4900-894c-d1a6263494e6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c4e32fe6-1fa3-4877-aa76-811ab1dcf10e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c517b227-67c5-4474-91a0-027a0e7b36d0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c5395948-758b-4f38-abed-9ee8114643b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c65fefaa-212b-4e79-b744-76bfd2aeaf1e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c79afb13-c091-4c87-a48f-2f760645ff79"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c8fe7f71-9c0f-4473-92cb-907d2c0374dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c912fb90-e77a-48f8-9558-4ba85fbe5a5a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9c70b43-8b7f-4473-8dcb-298268ea6d67"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce15bfce-bdfa-453b-a204-c3d6819816b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1176bb2-9add-42ce-9443-04ff4c673878"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d31609bc-d0f3-45b5-89ee-d64c7cda10fd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d76ecb5e-3611-4974-ab66-a2089f2bc0a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8166420-0d3c-4d1e-822f-c7b2621ccff4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8d2f973-2faa-4448-aad7-5ef28d8fd082"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d91065f6-9de2-438f-acd2-8d182dadadd5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dcbdcab5-00e5-4f52-9d8b-20f26a4df826"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("de4cd6ca-da99-45c6-83fc-2cc3a456e53d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("df1ca42a-0c5c-4397-99cc-25e21dea8521"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("df815f39-79c1-4a4e-a2ab-f6c4b4f933fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e01f2f14-1036-4519-b8d4-0fe7f78a9481"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e085ce01-038c-4018-aec6-103f5c6b905c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1b317cb-9c70-43d2-8721-6810c4eefee7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2469474-b45d-4228-ae42-a88eb594303a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2f0d783-b1de-45d9-83e4-a8310279909b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e484f99b-c7ad-47a1-9557-f0cdbfa10e17"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e57ea627-d5f6-437e-9c51-4692cd28a3fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e62abfaf-8df5-47e5-a894-6fa4054723ab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7179810-684f-4733-baa0-d28f8ca158e0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e8b3c565-eaf5-4bc3-b9b4-b9b11f2a7268"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9e0e7cc-915e-4373-826d-fa586471db25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec3a3a0d-dbc6-4c8f-8109-cd5390510872"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef620cf6-ec7e-4737-857d-4d3a74f168fc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef654fd6-3377-4e23-a036-2c390dbaf178"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0178e9b-2366-4cb9-91ab-f5795f5f36cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0b39f95-84dc-4974-88cd-e5900b0cd1e3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0fefaac-ac3f-4d16-9b97-e3d165380c4a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f364ea67-57fa-4e7c-b662-4943a0755041"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5d24ded-db7f-493f-8842-7f349718cdab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f74cdf9d-6018-4103-a23c-e736c76e8d5c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f82bbc9f-6faa-4437-8fae-dd63d35d16f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f83c7787-8dad-4c6a-a7fb-5ffe469b1620"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8d72a8d-9496-42a2-962a-266a370e7dfd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe6a78e4-6730-4834-9cbf-f79f919e22aa"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("192ffe56-c449-4a63-bbf5-43ee97b1d31b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1b16a934-5c58-43ec-b7f4-e428c6470aae"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1dc9e872-e0bf-4c90-b05e-f66953426d2a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2783f6c2-5471-4dfd-b50b-5f2d876ae645"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5777c98b-9523-4e22-8c07-5a5da0670490"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8205e02f-41d5-42ce-8409-3e21cda1a4c2"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("85224a5e-5bb6-449e-9132-1943ea7fe43f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("91b23d43-09be-42df-8c5e-c32a93b5347a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("96661011-8574-4f45-94f5-f8cd8db06a8f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9e979cba-5788-45d5-bf78-25d29f3333bc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a300ae22-19ce-4642-b514-92f3bac1af1b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a6ba940d-6ee8-4f01-9709-c6aeae9b4b5b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b0cce8c6-96f4-403f-b30e-f49276cd5e23"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b290c3ce-09d4-4017-b3c5-7d9f9d67416e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b4bf2fbc-4247-4649-9f2a-07c31e92d872"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("bec4d8c7-64fa-4d8d-9fc5-870c80e2992d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c0c22b29-6ab3-43bc-a377-1bb330b3cddf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c9f273be-b47b-4f3e-9b1b-ba0542ca3c82"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("cabeebe7-b836-4979-8023-0b755374a8a5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ce532aab-4e4c-4b4a-9ebf-089835c5c0b4"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d3e01f75-e3de-45b2-8915-7bb242e9ed3c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d600fd2f-b6fc-4727-8c0d-4e157b994042"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e0249000-adc3-4478-a84c-05ed32ba41c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0de06a81-171e-4155-ac53-1a03a9a8b6c5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("10e55b57-03d0-46e1-8a98-95f53b05a9d3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("23d7a5b9-e831-428a-b190-a6efa7fbd1f1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b83ab7f-ec41-4171-a13a-04dd64a580f3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ce47e1f-9b87-46f2-a6cb-b8e47c05ec8f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58a44544-7d9a-40e8-9193-422211af25fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5bed9583-09d7-4d9b-93bc-cea2b8b21f32"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("651bfcca-f749-46a1-a5a9-e4da9617d908"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("705a7c87-1851-4db3-a1d9-893629f633fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7f09604a-d8e6-4b92-8776-f291a200b4f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a31db8f-1f5a-4254-9475-ed9172384f34"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a9df710-4e94-4468-a563-29390e2863ca"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a34b6fd8-d96e-4023-bbae-20c9159a7ed9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a44373bb-a84a-445c-b0f2-79183dda089d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("adc5d3d7-8a5b-41d5-9f79-b69adef68536"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("24b84cc1-4ab0-4812-bc78-9e298284b1ce"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("379c243d-6ba0-490d-9b29-bd5ff48b59dc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5240d496-3ed0-41e5-ab61-bee0a6417913"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("534f8f6a-f464-4afb-acfa-16d434f2fc58"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7d336772-6373-4cb7-9168-04f1a4b2ccd6"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("896fda87-b673-490b-af30-ea01a4e6f3a4"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a37a0de3-b5c6-43b9-892e-3cb5dfc2da84"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("bdd0e2ad-d383-4f54-a6f1-08a4d7dea32e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c8d140b4-e65f-40e9-86b3-a133078c0659"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ec173ad8-b781-4ab3-a75e-a379e605cf84"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f178f4ec-5625-4015-be1d-887107e2b59c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("57e0189d-d34f-4567-acb3-8241256edf2e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ae939e5-5b08-46ae-bd8f-a4505c240bc1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b34500f-f877-42de-a0fe-0e3722c35117"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3df5236-548d-40e0-b808-fa5034f9c801"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc731725-7367-4489-bbe9-e5332b8e435c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c7e2ac70-2dcb-47c2-89e0-5e6a5b0953dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1555acf-73b5-46a9-9b48-e88d2b4873bc"));

            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "Places");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Places",
                newName: "OpenningHours");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "Trips",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<Guid>(
                name: "ConditionProfileId",
                table: "Trips",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryProfileId",
                table: "Trips",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Budget",
                table: "Trips",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "PredictedCost",
                table: "TripPoints",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "OpeningTime",
                table: "TripPoints",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0),
                oldClrType: typeof(TimeOnly),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "TripPoints",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "ClosingTime",
                table: "TripPoints",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0),
                oldClrType: typeof(TimeOnly),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "TripPointReviews",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldPrecision: 2,
                oldScale: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "TripPointReviews",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualCost",
                table: "TripPointReviews",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Places",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,8)",
                oldPrecision: 18,
                oldScale: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Places",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,8)",
                oldPrecision: 18,
                oldScale: 8);

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("5259b681-3f24-4486-8d03-736ed1590e40"), null, "catering", null },
                    { new Guid("8dd6431b-e715-4a9b-b376-52b6f98016b8"), null, "entertainment", null },
                    { new Guid("9d82498c-b9ca-4a81-8f7c-a9ae22fd3491"), null, "activity", null },
                    { new Guid("9db8be88-aa06-4ee0-a2ec-fe255d2790bf"), null, "heritage", null },
                    { new Guid("9f3a4b1b-68bf-4b11-af8b-d10a4de3c354"), null, "leisure", null },
                    { new Guid("e40a600f-8673-4dc5-96e8-7d818e5a897e"), null, "national park", null },
                    { new Guid("e657d813-86fa-481b-a3bb-b0aae9a5f249"), null, "religion", null },
                    { new Guid("ed1b1cba-6cbf-47fa-8930-d33889a6bf67"), null, "commercial", null },
                    { new Guid("ed45d6e9-e8f6-4fbe-95cf-6a3c7622f1f7"), null, "tourism", null },
                    { new Guid("f1dc8bc4-4238-4eb4-abb3-67a2bfe0b9e1"), null, "natural", null },
                    { new Guid("fb72906b-5164-4a37-86b3-b0e3cdda6737"), null, "sport", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("01ffca24-2564-4c68-8319-bdda5e47c0ef"), null, "wheelchair", null },
                    { new Guid("16c04489-8103-4cfa-b3c2-bcc7cd6bf7f0"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("1823743a-0843-41d4-ae98-57a1c8baa51c"), null, "dogs", null },
                    { new Guid("320b286d-767a-4fb3-b8df-275bd0fa6d23"), null, "access", null },
                    { new Guid("3a32ffe2-5101-4e25-abc4-d25064f616be"), null, "access_limited", null },
                    { new Guid("3f3ec582-660c-4d34-ad0a-885e60c285db"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("4955790a-36b1-4913-9a80-1c978cb8c6fa"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("752aa33f-e155-4f4f-917b-34bdf35923d6"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("792e20ab-68b6-4d50-be5c-754ad81714ca"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("843b8d83-902e-4340-aab8-4996dac8e4d7"), "Name property defined for the place", "named", null },
                    { new Guid("8b8c5359-d182-42dd-b78c-1c7a417310b9"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("95ccf064-02d7-4be9-8815-bd12706fbea7"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("9ab8e070-c021-4e2d-a142-3db2b883e785"), null, "no-dogs", null },
                    { new Guid("a5f959bc-74a8-4466-bc65-cfb473ba8775"), null, "internet_access", null },
                    { new Guid("abaa0e18-d926-4e80-9afe-aedb9e234c01"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("c70eaa6a-b2d5-4666-81a5-5ff777a4d08a"), null, "fee", null },
                    { new Guid("dc0252ec-4386-4b83-8e50-18a94c9efdb9"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("f8808f01-73a1-4272-8940-75d5bf397ece"), "Places where you can buy or eat vegetarian food", "vegetarian", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("04d4b36b-3775-4d55-8785-9884c89328a3"), null, "park", new Guid("9f3a4b1b-68bf-4b11-af8b-d10a4de3c354") },
                    { new Guid("20a7a04c-bd1f-4622-b866-f0aec410b3a1"), null, "zoo", new Guid("8dd6431b-e715-4a9b-b376-52b6f98016b8") },
                    { new Guid("25f98c91-0a99-47d9-89d7-6e3230104c82"), null, "aquarium", new Guid("8dd6431b-e715-4a9b-b376-52b6f98016b8") },
                    { new Guid("37e98797-61ba-4db9-b74f-dbe695f781a1"), null, "taproom", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("4291f2e3-d14c-44af-b666-ca5e97684c91"), null, "bar", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("45807a74-d366-456c-b377-cefeb6862e00"), null, "place_of_worship", new Guid("e657d813-86fa-481b-a3bb-b0aae9a5f249") },
                    { new Guid("5150e63c-2588-4e04-bcc0-57f42e786a68"), null, "biergarten", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("5d33ad4b-3245-494d-b2c8-4ca5cd2e84da"), null, "gift_and_souvenir", new Guid("ed1b1cba-6cbf-47fa-8930-d33889a6bf67") },
                    { new Guid("62a48e04-d094-457c-ab11-75827c54cf6f"), null, "attraction", new Guid("ed45d6e9-e8f6-4fbe-95cf-6a3c7622f1f7") },
                    { new Guid("6f207dfe-26f6-48a9-8f83-2c722755f41a"), null, "unesco", new Guid("9db8be88-aa06-4ee0-a2ec-fe255d2790bf") },
                    { new Guid("85ad6bce-9577-42a1-8789-7789d461526a"), null, "museum", new Guid("8dd6431b-e715-4a9b-b376-52b6f98016b8") },
                    { new Guid("968db041-c011-4761-b4a4-8c132f8aebac"), null, "food_court", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c"), null, "sights", new Guid("ed45d6e9-e8f6-4fbe-95cf-6a3c7622f1f7") },
                    { new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23"), null, "cafe", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("a7ac3b22-9484-4d7d-b2d2-cad3312ea9d9"), null, "water", new Guid("f1dc8bc4-4238-4eb4-abb3-67a2bfe0b9e1") },
                    { new Guid("a88992a4-34a5-446c-b77b-805fae0a50ea"), null, "art", new Guid("ed1b1cba-6cbf-47fa-8930-d33889a6bf67") },
                    { new Guid("cae7cfab-89c4-496a-8939-da49a3020638"), null, "restaurant", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("d4214fc5-3d2a-41e3-8052-7401a53281d2"), null, "ice_cream", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("d70a9852-72af-4a52-9e0a-08918d05ef4a"), null, "stadium", new Guid("fb72906b-5164-4a37-86b3-b0e3cdda6737") },
                    { new Guid("de5d8d99-cd21-42aa-973b-ab5a5efe521c"), null, "mountain", new Guid("f1dc8bc4-4238-4eb4-abb3-67a2bfe0b9e1") },
                    { new Guid("ded194cb-4a71-477c-be15-f534a05dcf3a"), null, "forest", new Guid("f1dc8bc4-4238-4eb4-abb3-67a2bfe0b9e1") },
                    { new Guid("e0a31581-07a2-47c9-8332-708d747911ef"), null, "planetarium", new Guid("8dd6431b-e715-4a9b-b376-52b6f98016b8") },
                    { new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6"), null, "fast_food", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("f1b66934-5539-4430-8fb8-41cd4c247808"), null, "sand", new Guid("f1dc8bc4-4238-4eb4-abb3-67a2bfe0b9e1") },
                    { new Guid("f8d1d0c3-58ca-49db-b528-3fcb6390f1d6"), null, "pub", new Guid("5259b681-3f24-4486-8d03-736ed1590e40") },
                    { new Guid("fa35eaed-bf12-4e13-a2c4-c15106bd1d0a"), null, "culture", new Guid("8dd6431b-e715-4a9b-b376-52b6f98016b8") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("02b1eeb2-c742-4493-a0b8-e62a5ff5f475"), null, "only", new Guid("f8808f01-73a1-4272-8940-75d5bf397ece") },
                    { new Guid("09c23e83-6de9-42d4-bd5f-50abe8bf832f"), null, "only", new Guid("3f3ec582-660c-4d34-ad0a-885e60c285db") },
                    { new Guid("12b1e798-4357-4b04-a86f-f4f95c073c93"), null, "yes", new Guid("1823743a-0843-41d4-ae98-57a1c8baa51c") },
                    { new Guid("22450057-4a1e-4b08-906c-9858f144c38b"), null, "for_customers", new Guid("a5f959bc-74a8-4466-bc65-cfb473ba8775") },
                    { new Guid("224a554a-1dbf-463a-9953-825bc76077aa"), null, "leashed", new Guid("1823743a-0843-41d4-ae98-57a1c8baa51c") },
                    { new Guid("23b73b33-f632-4a80-9b6e-b0b199161145"), null, "yes", new Guid("01ffca24-2564-4c68-8319-bdda5e47c0ef") },
                    { new Guid("46140631-f915-4d34-a645-e3eb0105dd20"), null, "not_specified", new Guid("320b286d-767a-4fb3-b8df-275bd0fa6d23") },
                    { new Guid("56335b38-65e0-4b8f-b411-d84b564a2901"), null, "customers", new Guid("3a32ffe2-5101-4e25-abc4-d25064f616be") },
                    { new Guid("70459bb8-d643-4f4a-b880-f70f50e667b8"), null, "only", new Guid("8b8c5359-d182-42dd-b78c-1c7a417310b9") },
                    { new Guid("769a45a0-e704-4200-aace-976c46858a85"), "Places that are available for public", "yes", new Guid("320b286d-767a-4fb3-b8df-275bd0fa6d23") },
                    { new Guid("91043061-8f99-4b48-b0e6-801c16cb906d"), null, "only", new Guid("792e20ab-68b6-4d50-be5c-754ad81714ca") },
                    { new Guid("a5a77c54-183c-4294-9180-94efb4be3e9c"), null, "not_specified", new Guid("752aa33f-e155-4f4f-917b-34bdf35923d6") },
                    { new Guid("b797d732-0c95-44e7-a782-29b98cd7b015"), null, "limited", new Guid("01ffca24-2564-4c68-8319-bdda5e47c0ef") },
                    { new Guid("bc8f1b64-3107-41cf-88eb-926e0eb27747"), null, "no", new Guid("752aa33f-e155-4f4f-917b-34bdf35923d6") },
                    { new Guid("e86ef87e-8a0a-4927-8da7-4b4f340720b5"), null, "only", new Guid("4955790a-36b1-4913-9a80-1c978cb8c6fa") },
                    { new Guid("f6ba1742-a983-40b8-a83a-11c9f09e0476"), null, "free", new Guid("a5f959bc-74a8-4466-bc65-cfb473ba8775") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("018a09e5-6ba9-4b29-ba79-0803feba0f5e"), null, "fountain", new Guid("62a48e04-d094-457c-ab11-75827c54cf6f") },
                    { new Guid("07ef91d0-0be4-4022-9b50-659c025ebf97"), null, "bubble_tea", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("087a9136-4eaf-4329-a201-e8edb64454ed"), null, "chicken", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("08b2e0b1-876e-42fc-9973-d2fcba83af91"), null, "ukrainian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("08da4354-d8f2-4d0a-8542-df0ef60d6c16"), null, "reef", new Guid("a7ac3b22-9484-4d7d-b2d2-cad3312ea9d9") },
                    { new Guid("08df1de9-f93b-4735-a670-7bdae53bbbb7"), null, "irish", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("0b409f98-f45b-4896-b504-d395f817f4ea"), null, "garden", new Guid("04d4b36b-3775-4d55-8785-9884c89328a3") },
                    { new Guid("0c70d085-68a6-4400-af68-513248057d34"), null, "tea", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("0dc1f79d-dbee-412d-9061-565d0d12f8f6"), null, "hot_spring", new Guid("a7ac3b22-9484-4d7d-b2d2-cad3312ea9d9") },
                    { new Guid("0e1d2beb-44b6-4d5b-a49a-251fb6629c54"), null, "portuguese", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("0e908597-4145-4eae-a6a3-9ac2a1a275fd"), null, "pakistani", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("0ea0ce41-e53d-4176-9a5b-195848ec4629"), null, "ruines", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("12d05c93-85fb-4163-a25a-b8c4e6489d79"), null, "donut", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("14b1925d-205d-4b8d-bc38-1340ef12944a"), null, "cliff", new Guid("de5d8d99-cd21-42aa-973b-ab5a5efe521c") },
                    { new Guid("1662de7d-6867-421b-99c0-ceb5d070d275"), null, "austrian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("177a53c0-48f5-46e7-97e2-bc429ea12dc0"), null, "waffle", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("17e5dfc8-1b9a-4829-b21a-7edfcdd2f0b1"), null, "malaysian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("193bab09-2ee6-4e96-a63f-e03dbda130c0"), null, "greek", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("1c9684a1-ef58-4995-97e1-d8b17ec491ae"), null, "taiwanese", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("1c9abf07-3218-456d-8560-17d21b416c71"), null, "european", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("1f2c4a85-4633-464e-bd07-74e2f0347fb2"), null, "regional", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("1fd1a6f5-fd5e-4e8a-8b3a-4d8113e4194e"), null, "thai", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("208e0fb8-56e5-419a-90bf-fbe3b0cf0ddd"), null, "nepalese", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("23571e0f-9900-4154-b2e0-69e9b3c59491"), null, "danish", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("23cc62ca-0582-4b17-9a24-ef1effa88bbd"), null, "noodle", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("2558d8d3-ac4e-4b32-b179-60c9c57ad559"), null, "burger", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("2579afa4-b0de-4501-92a1-9585190a07fb"), null, "beef_bowl", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("29740d75-4e89-4008-9cbc-4b31a804a0ea"), null, "sikhism", new Guid("45807a74-d366-456c-b377-cefeb6862e00") },
                    { new Guid("2b3f24ba-44e5-4fbf-b1ec-602facbef939"), null, "turkish", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("2c14a939-2a0f-4c71-86e1-4685a855fdd0"), null, "frozen_yogurt", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("2c2b577d-0f94-4785-8a1e-17b72a1e1642"), null, "coffee_shop", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("301676d6-0e43-4894-8799-a70763bbecef"), null, "dessert", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("361d3ea2-805c-4a96-be73-87006d596667"), null, "lebanese", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("38ed95d8-8e32-4dce-9bb0-29091ed4643b"), null, "crepe", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("3902dd20-e199-40fe-91ae-4be76c938f8f"), null, "geyser", new Guid("a7ac3b22-9484-4d7d-b2d2-cad3312ea9d9") },
                    { new Guid("3948a637-9df0-435f-bc8b-48e2d8e85754"), null, "tex-mex", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("3be856d1-38fe-4d5d-bea4-ff4fa32e0fc2"), null, "ramen", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("3d83b5a7-96c1-4ffb-958f-dbe9b5701442"), null, "tower", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("3e272a9d-4ec8-457b-8d2a-dc387f94a16b"), null, "monastery", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("3f65c286-0e0a-40b3-8c77-5375d1f51e4f"), null, "pita", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("46ae060a-678a-4a07-a5e7-612cfefcdd30"), null, "jamaican", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("4bd0d9a4-fc68-44a1-a9a8-3155414ee55b"), null, "pita", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("4bea744d-afb8-419a-81f3-974cfdd33d46"), null, "croatian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("4c174a16-f85d-45a1-a198-fd63dbd7868a"), null, "asian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("4c676268-2671-4a4f-8ab8-baf80382601d"), null, "fish_and_chips", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("4eee0e53-3353-41c2-b40b-1af1f745f2b9"), null, "syrian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("4f91b06d-70a0-403c-9ef2-42a1bff16233"), null, "buddhism", new Guid("45807a74-d366-456c-b377-cefeb6862e00") },
                    { new Guid("4fb09d8d-372b-42a2-98f1-1e3a346e6aac"), null, "castle", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("503e96f3-1777-4c20-a16a-4a1750696067"), null, "viewpoint", new Guid("62a48e04-d094-457c-ab11-75827c54cf6f") },
                    { new Guid("50d3b57a-427a-49ab-82c4-2762e01797a8"), null, "peak", new Guid("de5d8d99-cd21-42aa-973b-ab5a5efe521c") },
                    { new Guid("50f79b1b-7e20-4630-ac03-c40ab6bc339f"), null, "nature_reserve", new Guid("04d4b36b-3775-4d55-8785-9884c89328a3") },
                    { new Guid("52e9d582-2fa2-4b77-8c71-d7ada63f69ef"), null, "tapas", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("539e04ac-ca27-4783-b750-547dcb37adb5"), null, "brazilian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("579d50c6-a335-4fd3-a369-3e548e754358"), null, "city_hall", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("58be8552-90a7-42b2-b7c7-855f0d836d9e"), null, "american", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("60543c78-43cf-45d1-be9e-aa61858f1758"), null, "kebab", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("60986c4a-0a2d-47a4-bc40-651bacf94348"), null, "russian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("60b9468b-4e7a-4b88-80eb-7e69ec5215b0"), null, "soup", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("6204a866-9a02-4156-bc46-64abf6b43554"), null, "chili", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("625ad2c7-94cb-40ee-9070-6c7b4e413872"), null, "ethiopian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("6334f933-463f-4b48-be54-0b8be954aff3"), null, "ramen", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("6586d29a-0f8c-4525-b182-3e0a197a8da2"), null, "sea", new Guid("a7ac3b22-9484-4d7d-b2d2-cad3312ea9d9") },
                    { new Guid("6623a55f-b780-4e5e-92b3-f55e4dd6337b"), null, "theatre", new Guid("fa35eaed-bf12-4e13-a2c4-c15106bd1d0a") },
                    { new Guid("681d288e-6e55-47dc-a812-fb6338ff899b"), null, "ice_cream", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("71afbc68-9675-4789-9d27-57a2bbcc5818"), null, "seafood", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("72b505cc-c4b1-4788-9c24-22b5e936a3db"), null, "french", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("72dc254b-470c-4505-a062-99c5aece5cdf"), null, "korean", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("73e1a74d-62d0-408d-bd1a-77441416cb94"), null, "mexican", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("7434be14-b9c4-4e30-a242-e1b60dbb7466"), null, "vietnamese", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("7577bc27-1c26-45c5-bf01-8372223f324b"), null, "gallery", new Guid("fa35eaed-bf12-4e13-a2c4-c15106bd1d0a") },
                    { new Guid("785ddc09-994e-47f4-ba3e-212ae46cb08c"), null, "malay", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("78a3fa5f-e2e9-434b-ad50-7592b8b9e152"), null, "shinto", new Guid("45807a74-d366-456c-b377-cefeb6862e00") },
                    { new Guid("798c8af7-f8df-4bc0-893a-606c897c759d"), null, "coffee", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("7bf26778-ff1d-49db-a47f-786ec3690b3a"), null, "lighthouse", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("7bf69a7a-8e6c-41a9-8b6a-a40809862a4c"), null, "cuban", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("7d80207e-c275-4f91-a3b5-bc7da0f740d5"), null, "chinese", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("7ef25206-7b3b-487f-84ec-8023d989f92a"), null, "fish_and_chips", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("80abc24f-4051-4880-ba7c-2038d25ab812"), null, "afghan", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("8265e83d-12f1-4edc-ad12-383532c86e9d"), null, "indonesian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("8548c01e-173e-4f13-87dd-2a1a43b5b3e3"), null, "city_gate", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("8765381f-1b6c-452c-bd09-9cd933a014d2"), null, "oriental", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("8b78cd59-31ff-488f-9d8e-71b19e35e9e1"), null, "mediterranean", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("8e5737cb-ab50-4717-99e4-ae893983d902"), null, "steak_house", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("8f877ca8-41a0-4d3f-8193-d78aba252c17"), null, "peruvian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("90b93164-d4d0-464e-95b9-b1da03fb27d2"), null, "dumpling", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("91b81e55-3fb3-4198-a4df-ddf99b7dacf1"), null, "curry", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("9296dfec-14d8-4925-845f-b4279c84a48c"), null, "hawaiian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("932c6579-c760-4951-9973-f59d3aa5271b"), null, "archaeological_site", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("93f9b2da-a3ff-4f74-ad76-503d5447917d"), null, "western", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("95e7879a-1d52-4650-b48e-a02f3616ff87"), null, "clock", new Guid("62a48e04-d094-457c-ab11-75827c54cf6f") },
                    { new Guid("982b55ff-24af-4d6f-9823-8932dc648f93"), null, "salad", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("99b85dd9-a34a-4c2f-89cd-5c0678900876"), null, "argentinian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("9a42dcc2-4d3a-440a-96f7-1f126fa99dfb"), null, "windmill", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("9c58d9d9-cfc5-4e81-aa76-4249e6555ce2"), null, "persian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("9d439fd0-b48a-487a-888d-53e12d326a3a"), null, "tacos", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("9ee9ab66-024a-415c-ad5a-294df5c34a8d"), null, "kebab", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("a358d970-e58a-4b66-8f59-f5e6ea40f71a"), null, "cave_entrance", new Guid("de5d8d99-cd21-42aa-973b-ab5a5efe521c") },
                    { new Guid("a3d10c94-0193-455d-8032-f4a6a507ac2d"), null, "sandwich", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("a99f4b1b-7169-4345-a611-530dc8da0b13"), null, "hinduism", new Guid("45807a74-d366-456c-b377-cefeb6862e00") },
                    { new Guid("abd074bc-4ef7-422f-9114-af8f03c58c4a"), null, "judaism", new Guid("45807a74-d366-456c-b377-cefeb6862e00") },
                    { new Guid("ad40ad35-dd85-4dbf-b2e1-fc30dbe41282"), null, "battlefield", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("ae05c208-09c8-4432-b137-394210902ce6"), null, "place_of_worship", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("ae277749-2d77-4523-8fa3-414d978ff0f4"), null, "glacier", new Guid("de5d8d99-cd21-42aa-973b-ab5a5efe521c") },
                    { new Guid("afd55c4a-1bb3-453c-9ce7-80eb765f5512"), null, "czech", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("afdc2bae-c40e-4e83-8903-aebcc2522e0f"), null, "friture", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("b036fad2-03f0-418e-a213-da54e394a522"), null, "moroccan", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("b046df55-dbde-40b3-a31d-ce5d6afbe72b"), null, "bolivian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("b1d35d04-7fc4-43a9-b86d-74dc87fc2248"), null, "uzbek", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("b368b9aa-0e2e-419c-88ea-dca21621ebe1"), null, "african", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("b42aa0e0-4ad5-4f5e-8dbe-5a12df3a8c61"), null, "bridge", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("b65bf9d7-42c4-4f72-8b46-f17b8a3a2d98"), null, "indian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("b77b85a7-db40-46b5-88f4-9e698833694e"), null, "burger", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("b7f6c03c-7c79-4a33-b5d2-f2806c3d4a63"), null, "spanish", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("b9512e9e-d2ef-471a-80aa-816249be1410"), null, "tapas", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("bdce18ea-6f9b-4f24-b3db-6a3b164c15f4"), null, "barbecue", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("c18b85ce-a76e-46cd-93e6-e9e6435a2cb9"), null, "spring", new Guid("a7ac3b22-9484-4d7d-b2d2-cad3312ea9d9") },
                    { new Guid("c3d03dd8-00fa-41ba-a2ab-859f536a8cd9"), null, "tacos", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("c3d8dfab-48ed-4ada-90c1-5bb0b50ce103"), null, "japanese", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("c3fe6515-41a2-4ee3-980c-f1abf2f33449"), null, "noodle", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("c451e700-6117-459e-8f4d-f3419285e64f"), null, "balkan", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("c57af3bc-b38b-4bb4-b068-6d8fc9822ce3"), null, "caribbean", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("c5a25aa8-0d48-4379-95f0-4f1416ce80c2"), null, "arab", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("ca5d4118-77d2-4b04-b2bf-e95f226d0932"), null, "filipino", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("cd5375bd-7ebe-45e0-b0f2-a4e86c563cdf"), null, "fort", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("ceb2ed33-5d6d-47eb-a0ff-f3ac354f1ccd"), null, "sushi", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("cf897367-02da-4cd4-86b2-6443d18d3a0a"), null, "hungarian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("cf8ef81b-aae5-424c-b151-213d183742e7"), null, "bavarian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("cfd63502-8d39-4573-a253-0efbf248d41a"), null, "pizza", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("d0b332a2-e578-459a-9d9b-068bb10f25a4"), null, "wings", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("d2807e61-a019-4f59-a263-eb6c0402d535"), null, "rock", new Guid("de5d8d99-cd21-42aa-973b-ab5a5efe521c") },
                    { new Guid("d306464a-15be-4d7b-9ad8-9dbde0a24e2e"), null, "fish", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("d5dc398b-552f-4156-8f53-e8d506f5a8c3"), null, "german", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("d757b0b9-9a76-4ae7-a97d-f988f35c6436"), null, "italian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("e0ab1cf1-ac85-4bc7-a18d-1ede0e91f6e4"), null, "swedish", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("e57e56a0-df97-4b24-9ea9-00eab1ca13b6"), null, "hot_dog", new Guid("edac3b6b-7e56-47a2-a68b-f911c0ab73f6") },
                    { new Guid("e719bfbc-f310-429f-a811-b81fbd032101"), null, "latin_american", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("ea6dacb9-8e97-4807-a531-d78285f7c56f"), null, "christianity", new Guid("45807a74-d366-456c-b377-cefeb6862e00") },
                    { new Guid("ee12dab6-5704-463a-9213-e319b18c4b98"), null, "belgian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("f087ada7-2be2-41c1-b219-485d750a43f9"), null, "sandwich", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("f0e7b2fe-45ad-4503-9ad0-1528bf974dc6"), null, "georgian", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("f0ff4e4e-2afa-4338-95eb-71c4addcbadd"), null, "arts_centre", new Guid("fa35eaed-bf12-4e13-a2c4-c15106bd1d0a") },
                    { new Guid("f2ed258f-daf6-4e16-af2e-0fb64a9b542f"), null, "multifaith", new Guid("45807a74-d366-456c-b377-cefeb6862e00") },
                    { new Guid("f41919b8-1e82-4e26-be97-6d63f81a6c09"), null, "artwork", new Guid("62a48e04-d094-457c-ab11-75827c54cf6f") },
                    { new Guid("f641e2cf-fca2-497f-b532-8f1fd100a84e"), null, "cake", new Guid("a70fca93-ecf4-458b-b0f2-c21a3abced23") },
                    { new Guid("f6692cee-bfdc-4bd0-bfe5-d34be8303ac3"), null, "dune", new Guid("f1b66934-5539-4430-8fb8-41cd4c247808") },
                    { new Guid("f7c245db-a7f7-4471-bd3c-4363fb486879"), null, "international", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("f9861c30-462f-40ab-8d34-53544ac2bcbb"), null, "soup", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f"), null, "memorial", new Guid("98a06960-d7f9-45c7-b1f9-b6f98fe13e3c") },
                    { new Guid("f9fd46c8-1f1e-469b-8ab1-7fb841948109"), null, "wings", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("fd912528-a116-4021-b9a1-39ce66bafbec"), null, "pizza", new Guid("cae7cfab-89c4-496a-8939-da49a3020638") },
                    { new Guid("fe008a13-117d-4be0-ac76-c4647b2e3ff6"), null, "islam", new Guid("45807a74-d366-456c-b377-cefeb6862e00") },
                    { new Guid("2a522f64-1334-409b-a101-6976cb9692c4"), null, "boundary_stone", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("3fc9ab0a-f620-47e8-b314-991b9d5fe11d"), null, "church", new Guid("ae05c208-09c8-4432-b137-394210902ce6") },
                    { new Guid("48e07f55-2fe1-4f99-9cf3-84236d0c4616"), null, "locomotive", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("6d2b8f9d-799f-4eaa-b448-8864fab16bd4"), null, "temple", new Guid("ae05c208-09c8-4432-b137-394210902ce6") },
                    { new Guid("6fdd7a4c-c350-4ec4-862f-6a95853c3f65"), null, "aircraft", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("76ff4ef9-dd4b-4b27-89a1-16a0c3de0d6a"), null, "monument", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("83cc8def-126e-4c30-8c6b-975f2e643aad"), null, "tank", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("8f73ffec-308c-4dc9-8da3-7230528c3531"), null, "mosque", new Guid("ae05c208-09c8-4432-b137-394210902ce6") },
                    { new Guid("a41ff4a7-f012-40ae-99ed-c70e2806640a"), null, "shrine", new Guid("ae05c208-09c8-4432-b137-394210902ce6") },
                    { new Guid("ae3fb6db-f746-4667-a704-2ff817df5f56"), null, "cathedral", new Guid("ae05c208-09c8-4432-b137-394210902ce6") },
                    { new Guid("b72957bd-1626-45b2-b2ed-ec02022d7348"), null, "pillory", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("ba28eccf-18a0-4ba5-8674-565cbb9284b7"), null, "chapel", new Guid("ae05c208-09c8-4432-b137-394210902ce6") },
                    { new Guid("d83d0f3a-a155-495f-9d04-a249a35dc314"), null, "synagogue", new Guid("ae05c208-09c8-4432-b137-394210902ce6") },
                    { new Guid("dbb3ceab-f5ea-4bf7-bce2-40fdc58e710e"), null, "milestone", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("dc9d3ee2-4ccf-46ec-898d-891e3b8e4026"), null, "tomb", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("e0bdf8bf-af6c-42c9-af22-e445a63c35c0"), null, "railway_car", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("e8ca3b7c-1904-43b9-9a06-aafed1d2ac4d"), null, "ship", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") },
                    { new Guid("f155b796-e947-4b69-b4c7-00ba5ed7db46"), null, "wayside_cross", new Guid("f9dfd197-fb2b-4896-96bf-0039edd8451f") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_CategoryProfiles_CategoryProfileId",
                table: "Trips",
                column: "CategoryProfileId",
                principalTable: "CategoryProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_ConditionProfiles_ConditionProfileId",
                table: "Trips",
                column: "ConditionProfileId",
                principalTable: "ConditionProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
