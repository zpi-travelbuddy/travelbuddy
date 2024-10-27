using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("1f619997-bb26-4d70-b8f4-71c85a59ea84"), null, "commercial", null },
                    { new Guid("37ada763-6d71-42b4-b71d-d15ab908ca95"), null, "religion", null },
                    { new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d"), null, "catering", null },
                    { new Guid("50d525b2-7257-423d-bf17-6f23e30ef505"), null, "entertainment", null },
                    { new Guid("5d3ea522-b691-45e8-9ff4-37c73a9ffc53"), null, "tourism", null },
                    { new Guid("94ea9840-42f1-409a-a96a-af1d8e1ea046"), null, "activity", null },
                    { new Guid("a677234a-e831-4b48-af4a-9073ff565420"), null, "natural", null },
                    { new Guid("ae943cb5-3eab-437f-95e9-902946e04f86"), null, "heritage", null },
                    { new Guid("aff892c9-1f4d-4907-adfc-82d9b586eb9b"), null, "leisure", null },
                    { new Guid("e5ac8a92-4dc9-40f9-9e9e-69a1f9132813"), null, "sport", null },
                    { new Guid("f970a859-6456-4a7d-8709-4aa45919324d"), null, "national park", null },
                    { new Guid("255789cc-7865-4147-a94e-3030025917cd"), null, "sand", new Guid("a677234a-e831-4b48-af4a-9073ff565420") },
                    { new Guid("2c028ffc-8ac3-4472-a3c5-433e68711005"), null, "bar", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b"), null, "cafe", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("4c6a2f45-6d27-4fc6-bbb5-3a874d2c7e50"), null, "stadium", new Guid("e5ac8a92-4dc9-40f9-9e9e-69a1f9132813") },
                    { new Guid("5c402109-1864-4cf6-8175-0c21e171d83b"), null, "restaurant", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("73107ab5-d42e-415a-9fa1-0d89b831f8db"), null, "water", new Guid("a677234a-e831-4b48-af4a-9073ff565420") },
                    { new Guid("748f8fbe-5a79-4664-b736-ed3aa80fc765"), null, "biergarten", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("76ddb4f3-d62f-483b-ac92-5b7d041bab33"), null, "ice_cream", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("81e2c8be-8ef6-44d3-94ed-fdc603872f9d"), null, "unesco", new Guid("ae943cb5-3eab-437f-95e9-902946e04f86") },
                    { new Guid("83b82d2b-4a74-4290-a125-48331af23def"), null, "art", new Guid("1f619997-bb26-4d70-b8f4-71c85a59ea84") },
                    { new Guid("85bce41e-3a0f-4932-a7f3-dd955ac9a546"), null, "gift_and_souvenir", new Guid("1f619997-bb26-4d70-b8f4-71c85a59ea84") },
                    { new Guid("862fa57e-d7a5-4d84-ab62-859c6a65a47b"), null, "mountain", new Guid("a677234a-e831-4b48-af4a-9073ff565420") },
                    { new Guid("96a8704a-0691-4f66-a8f7-25a7d329eaa5"), null, "pub", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("be2f2cec-711b-4f70-84a4-d372725137b6"), null, "sights", new Guid("5d3ea522-b691-45e8-9ff4-37c73a9ffc53") },
                    { new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b"), null, "place_of_worship", new Guid("37ada763-6d71-42b4-b71d-d15ab908ca95") },
                    { new Guid("cc4f6b81-4aae-48a2-b840-6246bc4696de"), null, "food_court", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("d45f70c2-b04c-45bc-936e-6d1b444a3bb5"), null, "taproom", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("e0557d16-35da-4daf-99cc-c05b1181f368"), null, "forest", new Guid("a677234a-e831-4b48-af4a-9073ff565420") },
                    { new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8"), null, "fast_food", new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d") },
                    { new Guid("edbe8bd4-f9d3-4351-9842-9fcdae479af2"), null, "park", new Guid("aff892c9-1f4d-4907-adfc-82d9b586eb9b") },
                    { new Guid("f2babf82-10ae-4705-bbe9-dc8fd1352d6f"), null, "attraction", new Guid("5d3ea522-b691-45e8-9ff4-37c73a9ffc53") },
                    { new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be"), null, "culture", new Guid("50d525b2-7257-423d-bf17-6f23e30ef505") },
                    { new Guid("0134c89a-fa97-4fb6-a79d-e838244d82a1"), null, "buddhism", new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b") },
                    { new Guid("01492857-9bf5-4647-88f3-cb328aeab625"), null, "taiwanese", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("01965132-ad88-43d0-bb9e-83978c3cd6ea"), null, "irish", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("04b2797c-98d3-48d5-9e83-27876d6e8082"), null, "mediterranean", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("07204987-e493-4ca8-a2af-c85577e9d803"), null, "theatre", new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be") },
                    { new Guid("0a59baba-4b3f-4477-adcb-3ccce2ca78c0"), null, "fish_and_chips", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("0c87eaf6-41f8-4586-9a45-d5a8d2c86d83"), null, "afghan", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("108a0a5c-3914-4d55-805e-1f7878c21a42"), null, "dune", new Guid("255789cc-7865-4147-a94e-3030025917cd") },
                    { new Guid("10ab0c5e-401e-415b-bec7-5f2c548e805c"), null, "pita", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("154f69c2-543d-4da6-83ab-f3f24417dbaa"), null, "oriental", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("15c9df60-6759-419d-9e7e-4bbc97c9a4ec"), null, "georgian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("176b6f99-0c4d-4a90-8209-30b2d99b2582"), null, "filipino", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("17aedf7c-59ce-4dfc-8b0c-b37e91d4d5ad"), null, "jamaican", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("18b5a408-6b98-4b2c-bc61-f1a0f013d610"), null, "barbecue", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("1bd7ba72-3bbb-4e5a-94c3-a757d9cdad1c"), null, "brazilian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("1d6b7d33-74c4-4c4d-8e9e-2bc6bc0ac89d"), null, "coffee_shop", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("1ee03c7b-88bb-4a5b-9736-b84f987c9eef"), null, "danish", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("1f78c5ce-5931-480c-94c5-282db21c432d"), null, "windmill", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("1fb98de8-9412-4a92-8145-df169fc2d795"), null, "balkan", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("205d252f-9893-4a62-b30e-fd1c951b4dee"), null, "ice_cream", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("21156570-a0c4-409d-a202-46874a5f1323"), null, "soup", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("21ea2fd4-e9b6-4e03-a986-6f10e12a1d3f"), null, "bubble_tea", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("221b438a-a014-4c77-b98c-74a942ef3617"), null, "artwork", new Guid("f2babf82-10ae-4705-bbe9-dc8fd1352d6f") },
                    { new Guid("24e9bbd4-bbe6-4e52-887f-9d06e5aedb80"), null, "kebab", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("29b3ba52-8135-4594-90f9-4ee616c61caa"), null, "coffee", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("2b502ef2-d2b5-4e70-91f8-ed9e01551906"), null, "burger", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("2be81c6d-ecdd-4175-a306-f1b0c4bb0df8"), null, "geyser", new Guid("73107ab5-d42e-415a-9fa1-0d89b831f8db") },
                    { new Guid("2c9ab1fe-3219-49f3-9766-98380d533420"), null, "arts_centre", new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be") },
                    { new Guid("2f57877a-fdb8-4390-8a12-5797063e7d12"), null, "turkish", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("3150195e-0bf3-46f8-93f1-f59730b0b2df"), null, "spanish", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("31beb57e-9b08-452a-b1b6-508e2cfb73da"), null, "wings", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("31c99bbf-cff4-4862-bdf6-58a3b50d442f"), null, "uzbek", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("3333c733-7511-491b-ac9d-0692ab79423f"), null, "rock", new Guid("862fa57e-d7a5-4d84-ab62-859c6a65a47b") },
                    { new Guid("338ebd22-e46b-4551-8c1f-8e5b638b156a"), null, "hinduism", new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b") },
                    { new Guid("34a698de-3153-4517-aeb5-0f191c4d192f"), null, "indonesian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("34ac375e-cb14-4b0c-a199-75ed47b024a2"), null, "curry", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("36dc1fd2-5763-4871-b6cd-7a5571f8da46"), null, "ramen", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("379045df-32a0-40e4-9ac8-fda190d14930"), null, "ramen", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("38b5661a-87f9-4266-9133-fce656daee39"), null, "fish", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("39e8b4b1-b565-4166-9891-32c10848de5d"), null, "german", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("3ada3c14-8d6f-4dc7-b300-b6487818411e"), null, "planetarium", new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be") },
                    { new Guid("3bed7122-7fbc-4b53-9906-625b8612c404"), null, "lighthouse", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("3e67ddee-f322-4b9f-8404-1cba381b7fdb"), null, "swedish", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("3fb58ea6-2c32-45a0-81b7-ff41dd9db02b"), null, "sandwich", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("43e75e3f-cb7d-42dc-b463-44a9f4e51a94"), null, "glacier", new Guid("862fa57e-d7a5-4d84-ab62-859c6a65a47b") },
                    { new Guid("478c1aa1-cca0-4db5-8362-1d9e0a5a4ded"), null, "pizza", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("48c5f7e5-b1f9-417b-92bd-ccc4e08df2b3"), null, "moroccan", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("4f98cc5c-142a-4905-95b3-5c25dfd9b969"), null, "dessert", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("52c1979e-d41c-474f-bf05-840342c68a09"), null, "chinese", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("55c27b64-a302-414a-9639-4e087b38e9ad"), null, "international", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("57191d08-0fc7-4439-ac1c-111bc82aae4a"), null, "western", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("5884be5d-095a-4e05-8c6b-e7a6e12d6e7d"), null, "noodle", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("58c652c0-d9bf-42f0-ae90-fc9385cac9e0"), null, "greek", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("5a4f0d3f-5460-4395-8871-9318497239e0"), null, "friture", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("5ee6c510-5f75-4206-9785-a43cf80f2ced"), null, "steak_house", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("5f03a8b5-6e05-47a1-a3f0-3f5bfcffda24"), null, "bolivian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("613978b5-9deb-42a5-bbf6-52c64a916cdc"), null, "tower", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("627033d7-043f-4b27-af25-96b701161a3e"), null, "malay", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("62db9f90-e62b-48f0-851e-b541ae86cda4"), null, "crepe", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("664fcf23-2f72-4823-ac78-c240a849ef94"), null, "pita", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("66ed3bb3-6013-4fa2-92e0-4c57beece7b3"), null, "city_hall", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("66f73c76-d0bd-4fd5-85f3-0dce8195ac35"), null, "waffle", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("67553f73-0d89-4be1-a8f9-df7d5d4f8aaa"), null, "japanese", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("679d67fa-c576-41a0-9f1e-bb268d2db18a"), null, "museum", new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be") },
                    { new Guid("6808dc1c-ce05-42ce-97e3-759938269868"), null, "ethiopian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("69fabd17-6d6e-45b3-a02f-f7a24a2f70fa"), null, "cave_entrance", new Guid("862fa57e-d7a5-4d84-ab62-859c6a65a47b") },
                    { new Guid("6a6dfa55-441b-4ee4-9ab8-76297bbd94eb"), null, "tacos", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("6c17376f-13de-4b98-9233-5ac52c9e9e79"), null, "castle", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("6d900c44-be6e-490d-846f-5d381d60587a"), null, "multifaith", new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b") },
                    { new Guid("70e30db7-f59e-4359-a50e-27aaafa51bc8"), null, "austrian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("72edb0ca-62f5-4159-be0c-ad61ae455dfa"), null, "peak", new Guid("862fa57e-d7a5-4d84-ab62-859c6a65a47b") },
                    { new Guid("744f3064-67a1-4076-ad52-ed37c3067a14"), null, "dumpling", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("7623b5e1-cdc5-4577-8483-358efbc6a7d0"), null, "tapas", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("76f676ea-b8be-4751-85cf-b81e1c41a8f6"), null, "latin_american", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("7733fc47-720a-4413-81a9-b19f46ebc431"), null, "chicken", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("7757d12d-4668-447c-8d98-0f1ea0dfa661"), null, "aquarium", new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be") },
                    { new Guid("78c5e283-eaff-4b6c-85a1-eb39483e6a88"), null, "asian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("7a4e37e9-8b67-46b7-afeb-eab2d5bac68d"), null, "syrian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("7b0f127a-3ab1-4d58-8f6b-354dc3b9b5be"), null, "fish_and_chips", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("7c0612f1-77e5-48ba-8d0d-8f0a8eb95fb6"), null, "vietnamese", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("7d33c475-ff94-4c2a-bf2b-07bf0aaf9741"), null, "hot_dog", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("7df35c9b-82e1-4c5f-8a86-73f177baeef7"), null, "zoo", new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be") },
                    { new Guid("7f8fac04-41c5-486e-9818-7c2be6b16782"), null, "reef", new Guid("73107ab5-d42e-415a-9fa1-0d89b831f8db") },
                    { new Guid("80fad29c-4822-4edb-a508-d910c4cd8a85"), null, "chili", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("82d91aca-dec4-4845-9ef2-84779edf8372"), null, "belgian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("83bc4435-682e-42f2-ba68-21e8a1cfbac4"), null, "korean", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("8c597641-01cd-40d8-bf35-4907ac96b864"), null, "viewpoint", new Guid("f2babf82-10ae-4705-bbe9-dc8fd1352d6f") },
                    { new Guid("9314bb32-fd00-4c2d-9644-4713707a63bf"), null, "regional", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("98662281-30b2-47e6-85e2-f25abe1380ff"), null, "judaism", new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b") },
                    { new Guid("994bfc7d-861e-48e6-b89a-16112a62d00a"), null, "ukrainian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("9d3a797f-7022-4077-a3dc-1da4bdd1f5ee"), null, "garden", new Guid("edbe8bd4-f9d3-4351-9842-9fcdae479af2") },
                    { new Guid("a09e770d-b9d8-4315-9f16-df4affc47e11"), null, "american", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("a1281b08-f34c-4a8b-9dd6-d1ce3c1aba87"), null, "christianity", new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b") },
                    { new Guid("a3b34375-8a9e-47ed-8c92-a9c5debab5dd"), null, "cuban", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("a637efd9-77c2-40ec-b722-f881c57b5c4e"), null, "peruvian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("a872a7f0-e259-491f-b462-95c46c54b6a5"), null, "hot_spring", new Guid("73107ab5-d42e-415a-9fa1-0d89b831f8db") },
                    { new Guid("a88c9701-5a3d-4ab6-82ef-45c3c4d23f3b"), null, "arab", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("aa171b9d-0bcb-42a7-bdd7-9935ac8dc2c6"), null, "fort", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("aa415c79-43b0-411a-92a8-7251d90aa1ae"), null, "italian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("ac9f2de9-32de-4e0a-bc35-ed07ccb531ae"), null, "clock", new Guid("f2babf82-10ae-4705-bbe9-dc8fd1352d6f") },
                    { new Guid("b0b0f020-0e21-4dea-a14b-9524758468f6"), null, "cliff", new Guid("862fa57e-d7a5-4d84-ab62-859c6a65a47b") },
                    { new Guid("b18c3961-e693-46b1-afd4-abe1165df5fb"), null, "caribbean", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("b1e6d3f1-d30b-4f65-9c7d-e4b2b3ed623a"), null, "pizza", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("b31e9a4c-6847-4855-9912-b62154d07306"), null, "sikhism", new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b") },
                    { new Guid("b6fb41db-c2f6-4aa7-9467-57ee543892bc"), null, "frozen_yogurt", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("b8f8d579-36cb-4239-b49b-e4618e73e9bb"), null, "monastery", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("be1cd74d-e5ad-4217-8746-89a370d35d4d"), null, "gallery", new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be") },
                    { new Guid("be8f4fac-997f-442b-adc6-588bb0f65cec"), null, "african", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("bf51391f-d062-424a-bac7-5f1b363c3aa7"), null, "argentinian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("c0e127fc-6b7c-4a75-a296-d3d02d5d2a26"), null, "islam", new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b") },
                    { new Guid("c4d7a3be-c868-46af-92e7-bd643c793fe6"), null, "croatian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("c6340cfe-4c29-4c61-a1bc-ea8eacf05b28"), null, "city_gate", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("c72fc9ff-b71a-4f21-80a2-32ee7b0195a2"), null, "burger", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("c74c3d4d-e0a7-46ba-846f-eb2fdfe8a5e4"), null, "seafood", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("c9596f17-97fd-4816-be2d-89c93a075469"), null, "bridge", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("ca3815e4-98ce-4f65-91ae-9321b9076d45"), null, "thai", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("cc5839c7-2b35-47ee-97d2-88fa60e47f71"), null, "european", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d0621799-22bf-423a-8e32-859936f1f20b"), null, "salad", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("d0f4b85a-14ab-4096-81ae-2e96eefb5c8d"), null, "indian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d0fb6e2c-7a60-48f8-b3c0-f3f72ead71b0"), null, "mexican", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d1e71b32-ca8a-4a4d-9150-2dad15758c2c"), null, "beef_bowl", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d2625afd-edbe-4584-be00-d484ecc9e152"), null, "czech", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d3c8a192-8e81-4fd0-8562-da777f93cf2a"), null, "battlefield", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("d47e7404-9fe0-4606-bb14-e36f237491be"), null, "tapas", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d51845f8-fdb1-47fc-be80-f6805388394a"), null, "wings", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d528ea66-1d80-43b7-9312-9880dd43b10d"), null, "hungarian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d70f0006-d283-4732-aeba-298b58db0992"), null, "memorial", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("d91f7045-8f95-4529-8544-fb87ec4ec4dc"), null, "fountain", new Guid("f2babf82-10ae-4705-bbe9-dc8fd1352d6f") },
                    { new Guid("d96b47ad-221c-462a-a338-8c59ee51c29a"), null, "malaysian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("d9ce9e1f-8aad-459d-b539-1e1cc3ad2508"), null, "donut", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("dcb15137-9ace-4673-a780-80aaa2df5832"), null, "shinto", new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b") },
                    { new Guid("de135fba-48ca-4573-9da1-d81ff2ff146a"), null, "hawaiian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("deb69bcc-14f5-4589-a84a-e4887d68ed91"), null, "noodle", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("df077e8c-8e27-4fda-9a52-78b6ec6841df"), null, "lebanese", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("dfc8f262-6555-4bc8-b649-16aaf9b9a0a3"), null, "spring", new Guid("73107ab5-d42e-415a-9fa1-0d89b831f8db") },
                    { new Guid("e0b72283-8871-44ed-aa73-a70664449959"), null, "pakistani", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("e27de157-8058-4e70-a46b-3cdc395b0c3d"), null, "portuguese", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("e2c7d00d-4bc6-4554-a4a2-34a9745ebe4f"), null, "kebab", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("e4a33244-6d6e-4f92-a978-f2cba4329053"), null, "sea", new Guid("73107ab5-d42e-415a-9fa1-0d89b831f8db") },
                    { new Guid("e54b5e74-5312-4fd9-adeb-e6c4053155cf"), null, "soup", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("e9301c26-009f-468b-ba35-f6adb5b7abeb"), null, "bavarian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("e94497e5-de3b-42c0-96b0-0425abae537c"), null, "tacos", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8"), null, "place_of_worship", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("edfe77a9-ffc5-4880-9766-4ab86f198145"), null, "nature_reserve", new Guid("edbe8bd4-f9d3-4351-9842-9fcdae479af2") },
                    { new Guid("f1030a81-5078-4de3-9aad-983d6f228800"), null, "archaeological_site", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("f178c605-8b30-4d68-a82b-e025c533249f"), null, "cake", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("f37567d5-f181-4083-b178-1fb7ca5b2e21"), null, "sandwich", new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8") },
                    { new Guid("f502eb06-faa1-43f5-b129-a2a1c1e8fd3c"), null, "russian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("f5439db8-777f-45f1-84c3-d33a8493ebb7"), null, "french", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("f8029ad5-11be-4d4e-bc79-7cb91d92117d"), null, "tex-mex", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("f896c779-002c-46e2-895e-e90ee622b6d7"), null, "tea", new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b") },
                    { new Guid("fad6daad-d50d-4e65-bc04-a53760ba82f9"), null, "persian", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("fc567aa6-ef6a-4068-bbec-8a25dbe5dad0"), null, "sushi", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("fc831e44-4eae-423d-a788-7b6e3701f1dc"), null, "ruines", new Guid("be2f2cec-711b-4f70-84a4-d372725137b6") },
                    { new Guid("fef454cf-30ff-4da8-bc90-8f93b2269859"), null, "nepalese", new Guid("5c402109-1864-4cf6-8175-0c21e171d83b") },
                    { new Guid("0fb5e9bf-a3e6-4bfc-8cee-7c72f42079e5"), null, "shrine", new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8") },
                    { new Guid("2c38fe85-ec09-4fe1-bd3a-c76424853bc9"), null, "cathedral", new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8") },
                    { new Guid("2e517b88-2335-442b-b83c-0be676385844"), null, "railway_car", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("341b1e46-77df-4f42-bb04-224166b7b220"), null, "synagogue", new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8") },
                    { new Guid("44e01ea6-0970-42cf-bd46-8138c5f62914"), null, "chapel", new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8") },
                    { new Guid("59b64cb1-5b96-4bb8-b8c7-9eff08212b16"), null, "ship", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("5eaa7942-6358-432f-97de-86efbf895976"), null, "temple", new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8") },
                    { new Guid("62245ac9-c190-41b1-82a6-77d671ba6cf3"), null, "tomb", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("73a17b85-69cd-4d72-b0eb-6e73bbddf56f"), null, "monument", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("76fd1561-b25e-433d-bf6b-86a974d5e503"), null, "aircraft", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("8064178d-119e-43ba-951f-4f338a1d4eb3"), null, "locomotive", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("845adddb-833e-4557-b2c5-1acac1f1aea7"), null, "boundary_stone", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("90c995cb-5d73-456d-8241-f3995aaff5f8"), null, "pillory", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("a50b5377-a1b0-4690-bb37-88c1104f4c57"), null, "tank", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("cd8f782f-8056-4ec2-88b2-17fe71c4160c"), null, "wayside_cross", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("d1265aa9-654b-4c55-9ead-be4659331b6b"), null, "church", new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8") },
                    { new Guid("e2c85b0a-d6ed-438b-9031-6e21ae6c0e50"), null, "milestone", new Guid("d70f0006-d283-4732-aeba-298b58db0992") },
                    { new Guid("ff22efaf-2d48-4732-88a2-427d8b4dcb2f"), null, "mosque", new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0134c89a-fa97-4fb6-a79d-e838244d82a1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("01492857-9bf5-4647-88f3-cb328aeab625"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("01965132-ad88-43d0-bb9e-83978c3cd6ea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("04b2797c-98d3-48d5-9e83-27876d6e8082"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("07204987-e493-4ca8-a2af-c85577e9d803"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a59baba-4b3f-4477-adcb-3ccce2ca78c0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c87eaf6-41f8-4586-9a45-d5a8d2c86d83"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0fb5e9bf-a3e6-4bfc-8cee-7c72f42079e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("108a0a5c-3914-4d55-805e-1f7878c21a42"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("10ab0c5e-401e-415b-bec7-5f2c548e805c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("154f69c2-543d-4da6-83ab-f3f24417dbaa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("15c9df60-6759-419d-9e7e-4bbc97c9a4ec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("176b6f99-0c4d-4a90-8209-30b2d99b2582"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17aedf7c-59ce-4dfc-8b0c-b37e91d4d5ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18b5a408-6b98-4b2c-bc61-f1a0f013d610"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1bd7ba72-3bbb-4e5a-94c3-a757d9cdad1c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d6b7d33-74c4-4c4d-8e9e-2bc6bc0ac89d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1ee03c7b-88bb-4a5b-9736-b84f987c9eef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f78c5ce-5931-480c-94c5-282db21c432d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fb98de8-9412-4a92-8145-df169fc2d795"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("205d252f-9893-4a62-b30e-fd1c951b4dee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("21156570-a0c4-409d-a202-46874a5f1323"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("21ea2fd4-e9b6-4e03-a986-6f10e12a1d3f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("221b438a-a014-4c77-b98c-74a942ef3617"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("24e9bbd4-bbe6-4e52-887f-9d06e5aedb80"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("29b3ba52-8135-4594-90f9-4ee616c61caa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b502ef2-d2b5-4e70-91f8-ed9e01551906"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2be81c6d-ecdd-4175-a306-f1b0c4bb0df8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c028ffc-8ac3-4472-a3c5-433e68711005"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c38fe85-ec09-4fe1-bd3a-c76424853bc9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c9ab1fe-3219-49f3-9766-98380d533420"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e517b88-2335-442b-b83c-0be676385844"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2f57877a-fdb8-4390-8a12-5797063e7d12"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3150195e-0bf3-46f8-93f1-f59730b0b2df"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31beb57e-9b08-452a-b1b6-508e2cfb73da"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31c99bbf-cff4-4862-bdf6-58a3b50d442f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3333c733-7511-491b-ac9d-0692ab79423f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("338ebd22-e46b-4551-8c1f-8e5b638b156a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("341b1e46-77df-4f42-bb04-224166b7b220"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("34a698de-3153-4517-aeb5-0f191c4d192f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("34ac375e-cb14-4b0c-a199-75ed47b024a2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("36dc1fd2-5763-4871-b6cd-7a5571f8da46"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("379045df-32a0-40e4-9ac8-fda190d14930"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38b5661a-87f9-4266-9133-fce656daee39"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("39e8b4b1-b565-4166-9891-32c10848de5d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ada3c14-8d6f-4dc7-b300-b6487818411e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3bed7122-7fbc-4b53-9906-625b8612c404"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e67ddee-f322-4b9f-8404-1cba381b7fdb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fb58ea6-2c32-45a0-81b7-ff41dd9db02b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("43e75e3f-cb7d-42dc-b463-44a9f4e51a94"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("44e01ea6-0970-42cf-bd46-8138c5f62914"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("478c1aa1-cca0-4db5-8362-1d9e0a5a4ded"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("48c5f7e5-b1f9-417b-92bd-ccc4e08df2b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c6a2f45-6d27-4fc6-bbb5-3a874d2c7e50"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f98cc5c-142a-4905-95b3-5c25dfd9b969"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("52c1979e-d41c-474f-bf05-840342c68a09"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("55c27b64-a302-414a-9639-4e087b38e9ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("57191d08-0fc7-4439-ac1c-111bc82aae4a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5884be5d-095a-4e05-8c6b-e7a6e12d6e7d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58c652c0-d9bf-42f0-ae90-fc9385cac9e0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("59b64cb1-5b96-4bb8-b8c7-9eff08212b16"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a4f0d3f-5460-4395-8871-9318497239e0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5eaa7942-6358-432f-97de-86efbf895976"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5ee6c510-5f75-4206-9785-a43cf80f2ced"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5f03a8b5-6e05-47a1-a3f0-3f5bfcffda24"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("613978b5-9deb-42a5-bbf6-52c64a916cdc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62245ac9-c190-41b1-82a6-77d671ba6cf3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("627033d7-043f-4b27-af25-96b701161a3e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62db9f90-e62b-48f0-851e-b541ae86cda4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("664fcf23-2f72-4823-ac78-c240a849ef94"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("66ed3bb3-6013-4fa2-92e0-4c57beece7b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("66f73c76-d0bd-4fd5-85f3-0dce8195ac35"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("67553f73-0d89-4be1-a8f9-df7d5d4f8aaa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("679d67fa-c576-41a0-9f1e-bb268d2db18a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6808dc1c-ce05-42ce-97e3-759938269868"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69fabd17-6d6e-45b3-a02f-f7a24a2f70fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a6dfa55-441b-4ee4-9ab8-76297bbd94eb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c17376f-13de-4b98-9233-5ac52c9e9e79"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d900c44-be6e-490d-846f-5d381d60587a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("70e30db7-f59e-4359-a50e-27aaafa51bc8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("72edb0ca-62f5-4159-be0c-ad61ae455dfa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73a17b85-69cd-4d72-b0eb-6e73bbddf56f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("744f3064-67a1-4076-ad52-ed37c3067a14"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("748f8fbe-5a79-4664-b736-ed3aa80fc765"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7623b5e1-cdc5-4577-8483-358efbc6a7d0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("76ddb4f3-d62f-483b-ac92-5b7d041bab33"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("76f676ea-b8be-4751-85cf-b81e1c41a8f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("76fd1561-b25e-433d-bf6b-86a974d5e503"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7733fc47-720a-4413-81a9-b19f46ebc431"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7757d12d-4668-447c-8d98-0f1ea0dfa661"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("78c5e283-eaff-4b6c-85a1-eb39483e6a88"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a4e37e9-8b67-46b7-afeb-eab2d5bac68d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b0f127a-3ab1-4d58-8f6b-354dc3b9b5be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c0612f1-77e5-48ba-8d0d-8f0a8eb95fb6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d33c475-ff94-4c2a-bf2b-07bf0aaf9741"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7df35c9b-82e1-4c5f-8a86-73f177baeef7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7f8fac04-41c5-486e-9818-7c2be6b16782"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8064178d-119e-43ba-951f-4f338a1d4eb3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("80fad29c-4822-4edb-a508-d910c4cd8a85"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("81e2c8be-8ef6-44d3-94ed-fdc603872f9d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82d91aca-dec4-4845-9ef2-84779edf8372"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83b82d2b-4a74-4290-a125-48331af23def"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83bc4435-682e-42f2-ba68-21e8a1cfbac4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("845adddb-833e-4557-b2c5-1acac1f1aea7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("85bce41e-3a0f-4932-a7f3-dd955ac9a546"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c597641-01cd-40d8-bf35-4907ac96b864"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("90c995cb-5d73-456d-8241-f3995aaff5f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9314bb32-fd00-4c2d-9644-4713707a63bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("94ea9840-42f1-409a-a96a-af1d8e1ea046"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("96a8704a-0691-4f66-a8f7-25a7d329eaa5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("98662281-30b2-47e6-85e2-f25abe1380ff"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("994bfc7d-861e-48e6-b89a-16112a62d00a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d3a797f-7022-4077-a3dc-1da4bdd1f5ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a09e770d-b9d8-4315-9f16-df4affc47e11"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a1281b08-f34c-4a8b-9dd6-d1ce3c1aba87"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3b34375-8a9e-47ed-8c92-a9c5debab5dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a50b5377-a1b0-4690-bb37-88c1104f4c57"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a637efd9-77c2-40ec-b722-f881c57b5c4e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a872a7f0-e259-491f-b462-95c46c54b6a5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a88c9701-5a3d-4ab6-82ef-45c3c4d23f3b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa171b9d-0bcb-42a7-bdd7-9935ac8dc2c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa415c79-43b0-411a-92a8-7251d90aa1ae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac9f2de9-32de-4e0a-bc35-ed07ccb531ae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0b0f020-0e21-4dea-a14b-9524758468f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b18c3961-e693-46b1-afd4-abe1165df5fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b1e6d3f1-d30b-4f65-9c7d-e4b2b3ed623a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b31e9a4c-6847-4855-9912-b62154d07306"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6fb41db-c2f6-4aa7-9467-57ee543892bc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8f8d579-36cb-4239-b49b-e4618e73e9bb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be1cd74d-e5ad-4217-8746-89a370d35d4d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be8f4fac-997f-442b-adc6-588bb0f65cec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf51391f-d062-424a-bac7-5f1b363c3aa7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0e127fc-6b7c-4a75-a296-d3d02d5d2a26"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c4d7a3be-c868-46af-92e7-bd643c793fe6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6340cfe-4c29-4c61-a1bc-ea8eacf05b28"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c72fc9ff-b71a-4f21-80a2-32ee7b0195a2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c74c3d4d-e0a7-46ba-846f-eb2fdfe8a5e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9596f17-97fd-4816-be2d-89c93a075469"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca3815e4-98ce-4f65-91ae-9321b9076d45"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc4f6b81-4aae-48a2-b840-6246bc4696de"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc5839c7-2b35-47ee-97d2-88fa60e47f71"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd8f782f-8056-4ec2-88b2-17fe71c4160c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0621799-22bf-423a-8e32-859936f1f20b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0f4b85a-14ab-4096-81ae-2e96eefb5c8d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0fb6e2c-7a60-48f8-b3c0-f3f72ead71b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1265aa9-654b-4c55-9ead-be4659331b6b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1e71b32-ca8a-4a4d-9150-2dad15758c2c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2625afd-edbe-4584-be00-d484ecc9e152"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d3c8a192-8e81-4fd0-8562-da777f93cf2a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d45f70c2-b04c-45bc-936e-6d1b444a3bb5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d47e7404-9fe0-4606-bb14-e36f237491be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d51845f8-fdb1-47fc-be80-f6805388394a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d528ea66-1d80-43b7-9312-9880dd43b10d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d91f7045-8f95-4529-8544-fb87ec4ec4dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d96b47ad-221c-462a-a338-8c59ee51c29a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9ce9e1f-8aad-459d-b539-1e1cc3ad2508"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dcb15137-9ace-4673-a780-80aaa2df5832"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("de135fba-48ca-4573-9da1-d81ff2ff146a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("deb69bcc-14f5-4589-a84a-e4887d68ed91"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("df077e8c-8e27-4fda-9a52-78b6ec6841df"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dfc8f262-6555-4bc8-b649-16aaf9b9a0a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0557d16-35da-4daf-99cc-c05b1181f368"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0b72283-8871-44ed-aa73-a70664449959"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e27de157-8058-4e70-a46b-3cdc395b0c3d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2c7d00d-4bc6-4554-a4a2-34a9745ebe4f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2c85b0a-d6ed-438b-9031-6e21ae6c0e50"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4a33244-6d6e-4f92-a978-f2cba4329053"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e54b5e74-5312-4fd9-adeb-e6c4053155cf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9301c26-009f-468b-ba35-f6adb5b7abeb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e94497e5-de3b-42c0-96b0-0425abae537c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("edfe77a9-ffc5-4880-9766-4ab86f198145"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1030a81-5078-4de3-9aad-983d6f228800"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f178c605-8b30-4d68-a82b-e025c533249f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f37567d5-f181-4083-b178-1fb7ca5b2e21"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f502eb06-faa1-43f5-b129-a2a1c1e8fd3c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5439db8-777f-45f1-84c3-d33a8493ebb7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8029ad5-11be-4d4e-bc79-7cb91d92117d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f896c779-002c-46e2-895e-e90ee622b6d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f970a859-6456-4a7d-8709-4aa45919324d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fad6daad-d50d-4e65-bc04-a53760ba82f9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc567aa6-ef6a-4068-bbec-8a25dbe5dad0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc831e44-4eae-423d-a788-7b6e3701f1dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fef454cf-30ff-4da8-bc90-8f93b2269859"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff22efaf-2d48-4732-88a2-427d8b4dcb2f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f619997-bb26-4d70-b8f4-71c85a59ea84"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("255789cc-7865-4147-a94e-3030025917cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41f1d867-abb2-4f11-b8e0-ca553e7fd34b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c402109-1864-4cf6-8175-0c21e171d83b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73107ab5-d42e-415a-9fa1-0d89b831f8db"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("862fa57e-d7a5-4d84-ab62-859c6a65a47b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae943cb5-3eab-437f-95e9-902946e04f86"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c2d026f2-0095-4cb4-b04b-f36b0934c71b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d70f0006-d283-4732-aeba-298b58db0992"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e5ac8a92-4dc9-40f9-9e9e-69a1f9132813"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9a49597-cabe-48fd-94aa-64946a4eb2e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("eac891b8-3cbd-40f8-86e8-59c1299c51c8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("edbe8bd4-f9d3-4351-9842-9fcdae479af2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f2babf82-10ae-4705-bbe9-dc8fd1352d6f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc5e7a94-b28a-4b80-be6e-bb291db2c2be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37ada763-6d71-42b4-b71d-d15ab908ca95"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("44ae9bb2-9b39-4b01-a1d4-171e8ef5310d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("50d525b2-7257-423d-bf17-6f23e30ef505"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a677234a-e831-4b48-af4a-9073ff565420"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aff892c9-1f4d-4907-adfc-82d9b586eb9b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be2f2cec-711b-4f70-84a4-d372725137b6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d3ea522-b691-45e8-9ff4-37c73a9ffc53"));
        }
    }
}
