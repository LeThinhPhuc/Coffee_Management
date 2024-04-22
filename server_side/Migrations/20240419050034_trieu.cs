using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class trieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "1d0308f3-1e54-4bda-8e21-2694a16962c9");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "26fce52c-c05a-4ae0-8303-395f286c97b3");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "2a4f2833-39d2-4fcc-894b-980a8237f2ca");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "2b9a6e88-1059-48d6-91c5-f39145dd5f35");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "50485ff5-c72f-42a6-82b3-be2093970f2d");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "5ed76ae3-6b5b-408d-8662-e7e4c3067a15");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "73a7f4f0-f628-4223-b8b8-89c6cb5a6249");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "7a9d7083-18c8-47b3-ac0c-a5c382b3ccb4");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "ba09261e-9772-4755-80e6-ee05159901ba");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "be7a6cf3-1609-437a-9bdc-043a7da84953");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "c00979c0-279f-4c95-8df6-28bb85cd0514");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "c39c44f5-6b77-4ff5-a1f7-07791e2c7670");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "cf487165-6675-458a-b0db-5fbfb95df583");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "dd4e95a4-85c2-4d2e-966d-9224a2a6b5fd");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "e7e72e99-b950-490b-8d3e-e195995394ac");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "ed507844-9909-4c7f-a0ac-76a6cda0bc23");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "6cd5ebf4-94f2-4601-9575-4b238ac610e8");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "011f010c-7347-4f39-8653-948cf14d2f13");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "383efba3-7919-4b57-8c03-03bfe0cf79c3", "802c8aa9-63ce-4bfb-816b-80c3df13fb8d" });

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "0a3b143e-9075-4de2-947b-9d1567e20368");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "0b5863ad-7ef3-4ef1-9497-67339b4776ce");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "4cfffce0-cbfa-41f4-aace-569946ef38e7");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "5c74fe60-21b6-4317-b6eb-88b62cf5539f");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "66f542bd-7ba8-4f1b-b6ef-550d154f65d5");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "68fa4245-ba16-49de-bc36-1e351491d933");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "83fc24f7-c15c-44ed-92a0-1e46139ca2d7");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "f947bf4e-44d1-4401-b392-f7f692e2da95");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "8b1098a7-1346-4769-b3f1-6f882fa4dff1");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "e6c40b6b-ed9d-473a-8243-d5d19d4c977d");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "f4fce4e4-6aab-4eb2-bb0a-7783e943dc45");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "383efba3-7919-4b57-8c03-03bfe0cf79c3");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "0977a9e1-90a5-41d8-a307-534611762f6e");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "192e2624-2e3c-4f44-8794-2dee6934030a");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "64ee8438-1041-438c-8e02-bf1ae7f26c9b");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "d353bab7-1d31-4e69-a4cd-0472e342b521");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "8204c75f-26db-41f5-863e-80dd4de2d61a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "802c8aa9-63ce-4bfb-816b-80c3df13fb8d");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[,]
                {
                    { "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 10.0, new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2615), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2617), new DateTime(2024, 6, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2619), "Sugar" },
                    { "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 5.0, new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2576), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2578), new DateTime(2024, 5, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2580), "Milk" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13286075-5c0f-40ca-8882-02e253c27910", "725f08f6-9e53-4866-9c74-fad2fa50c33a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "48163789-5220-48f0-85b9-7ebbb3daa63e", 0, "aaa4750e-4189-4929-9160-471a76204b98", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEP9o1VYs+ImRMnZXBGRUffeWyJkKZ747UDkN8huXlScCcwJyO0YO8cd9iSkR1qDnrw==", null, false, "a015a8b7-40be-482c-9532-327851dab6f0", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "a27b9c43-e672-46a3-8a46-042ae32e1e03", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2859), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2852), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "48163789-5220-48f0-85b9-7ebbb3daa63e" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[,]
                {
                    { "36b0c5ec-1c24-456c-9ccd-c58e0468ad21", "456 Elm St", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2399), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2401), false, "Tea Shop", "48163789-5220-48f0-85b9-7ebbb3daa63e", 0.0, null },
                    { "8f7a87cc-53f3-4334-b0a1-cf841dff094a", "123 Main St", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2365), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2392), false, "Coffee House", "48163789-5220-48f0-85b9-7ebbb3daa63e", 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "13286075-5c0f-40ca-8882-02e253c27910", "48163789-5220-48f0-85b9-7ebbb3daa63e" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "3162cc3f-d641-427c-bd7c-3cf55043dbec", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2423), "Tea", "8f7a87cc-53f3-4334-b0a1-cf841dff094a" },
                    { "cbd96455-2068-4461-b3e4-b6443ade7dfb", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2439), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2435), "Smoothie", "8f7a87cc-53f3-4334-b0a1-cf841dff094a" },
                    { "cd9d7987-072c-47b4-b37a-6cf6659d3d1a", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2417), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2413), "Coffee", "8f7a87cc-53f3-4334-b0a1-cf841dff094a" },
                    { "f8770135-cc60-4a9f-83d5-2e04b992d99a", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2448), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2444), "Juice", "8f7a87cc-53f3-4334-b0a1-cf841dff094a" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "04c4231b-9a6e-4811-b806-46dac56c5d41", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2536), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2532), "f8770135-cc60-4a9f-83d5-2e04b992d99a", null, "Orange Juice", 24000.0 },
                    { "0b84dc72-eb80-4586-9257-861d2564ae79", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2496), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2493), "3162cc3f-d641-427c-bd7c-3cf55043dbec", null, "Earl Grey", 25000.0 },
                    { "776cb952-fe4c-4644-89f0-f34bd9b918f2", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2481), "cd9d7987-072c-47b4-b37a-6cf6659d3d1a", null, "Cappuccino", 28000.0 },
                    { "89659306-0fab-4a69-8e70-518bd214f6a6", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2521), "cbd96455-2068-4461-b3e4-b6443ade7dfb", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "ca5288e5-2df5-437c-a858-b8ba15931f7e", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2515), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2512), "cbd96455-2068-4461-b3e4-b6443ade7dfb", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "dbb39949-9079-45fa-a80b-32c7e4f7dfe6", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2471), "cd9d7987-072c-47b4-b37a-6cf6659d3d1a", null, "Latte", 28000.0 },
                    { "e95bcb91-aa09-4bf8-9f5a-ce56761e8308", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2502), "3162cc3f-d641-427c-bd7c-3cf55043dbec", null, "Green Tea", 22000.0 },
                    { "f1cbd738-1eb0-4feb-8229-8fcc43b3d78d", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Local).AddTicks(2545), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2541), "f8770135-cc60-4a9f-83d5-2e04b992d99a", null, "Apple Juice", 24000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "2252ef29-4fe8-44f2-8e99-431e2ca3e926", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2642), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2644), "dbb39949-9079-45fa-a80b-32c7e4f7dfe6", "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 100 },
                    { "46a4a71e-656a-488c-a07c-33aac4338957", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2651), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2653), "dbb39949-9079-45fa-a80b-32c7e4f7dfe6", "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 50 },
                    { "4efa5eeb-99ff-4680-87c9-f2acb3833cf7", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2738), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2739), "89659306-0fab-4a69-8e70-518bd214f6a6", "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 100 },
                    { "604809da-0d34-4ffd-bf60-275cd84d7938", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2783), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2785), "f1cbd738-1eb0-4feb-8229-8fcc43b3d78d", "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 50 },
                    { "74a0846e-c586-4119-a59d-996c5a71574e", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2700), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2702), "e95bcb91-aa09-4bf8-9f5a-ce56761e8308", "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 100 },
                    { "75846658-e6b8-491f-ad7e-da3b230294cf", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2661), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2662), "776cb952-fe4c-4644-89f0-f34bd9b918f2", "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 100 },
                    { "8cf1237d-e2f9-4296-a163-30d2e3d75bbf", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2682), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2683), "0b84dc72-eb80-4586-9257-861d2564ae79", "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 100 },
                    { "97ec37b0-489c-4d7c-9ab2-713042c7583d", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2729), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2731), "ca5288e5-2df5-437c-a858-b8ba15931f7e", "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 50 },
                    { "a25e7a3d-9695-4d6f-a7a7-bf37794dbe26", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2690), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2692), "0b84dc72-eb80-4586-9257-861d2564ae79", "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 50 },
                    { "ae635651-070c-4b8c-ab0f-dd77d5e15127", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2746), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2748), "89659306-0fab-4a69-8e70-518bd214f6a6", "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 50 },
                    { "b40cac38-7ec1-4b18-9198-35cf84376a67", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2757), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2759), "04c4231b-9a6e-4811-b806-46dac56c5d41", "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 100 },
                    { "d87d27a3-47fd-417b-a8fe-6c754d8ee15f", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2720), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2722), "ca5288e5-2df5-437c-a858-b8ba15931f7e", "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 100 },
                    { "daeeb32d-90bc-48db-aa73-ef371bb28cfd", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2670), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2671), "776cb952-fe4c-4644-89f0-f34bd9b918f2", "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 50 },
                    { "dd5c149a-b872-4a29-9ff8-cc12d68d0360", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2766), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2767), "04c4231b-9a6e-4811-b806-46dac56c5d41", "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 50 },
                    { "e2132200-5f51-4e70-9e3e-2222095a8afe", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2709), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2711), "e95bcb91-aa09-4bf8-9f5a-ce56761e8308", "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9", 50 },
                    { "f518bb0c-1d3c-4e04-b3fe-25e42d511966", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2774), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2776), "f1cbd738-1eb0-4feb-8229-8fcc43b3d78d", "6444d68e-fb3f-403a-bcb6-99479b6e6bca", 100 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "047fc7cb-fa36-4b03-babe-60e68a8164d1", new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2878), new DateTime(2024, 4, 19, 12, 0, 32, 962, DateTimeKind.Unspecified).AddTicks(2880), "dbb39949-9079-45fa-a80b-32c7e4f7dfe6", null, "a27b9c43-e672-46a3-8a46-042ae32e1e03", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "2252ef29-4fe8-44f2-8e99-431e2ca3e926");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "46a4a71e-656a-488c-a07c-33aac4338957");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "4efa5eeb-99ff-4680-87c9-f2acb3833cf7");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "604809da-0d34-4ffd-bf60-275cd84d7938");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "74a0846e-c586-4119-a59d-996c5a71574e");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "75846658-e6b8-491f-ad7e-da3b230294cf");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "8cf1237d-e2f9-4296-a163-30d2e3d75bbf");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "97ec37b0-489c-4d7c-9ab2-713042c7583d");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "a25e7a3d-9695-4d6f-a7a7-bf37794dbe26");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "ae635651-070c-4b8c-ab0f-dd77d5e15127");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "b40cac38-7ec1-4b18-9198-35cf84376a67");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "d87d27a3-47fd-417b-a8fe-6c754d8ee15f");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "daeeb32d-90bc-48db-aa73-ef371bb28cfd");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "dd5c149a-b872-4a29-9ff8-cc12d68d0360");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "e2132200-5f51-4e70-9e3e-2222095a8afe");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "f518bb0c-1d3c-4e04-b3fe-25e42d511966");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "047fc7cb-fa36-4b03-babe-60e68a8164d1");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "36b0c5ec-1c24-456c-9ccd-c58e0468ad21");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13286075-5c0f-40ca-8882-02e253c27910", "48163789-5220-48f0-85b9-7ebbb3daa63e" });

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "04c4231b-9a6e-4811-b806-46dac56c5d41");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "0b84dc72-eb80-4586-9257-861d2564ae79");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "776cb952-fe4c-4644-89f0-f34bd9b918f2");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "89659306-0fab-4a69-8e70-518bd214f6a6");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "ca5288e5-2df5-437c-a858-b8ba15931f7e");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "dbb39949-9079-45fa-a80b-32c7e4f7dfe6");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "e95bcb91-aa09-4bf8-9f5a-ce56761e8308");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "f1cbd738-1eb0-4feb-8229-8fcc43b3d78d");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "5fb6e5e1-1182-42f7-843d-bc8dc5f3dff9");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "6444d68e-fb3f-403a-bcb6-99479b6e6bca");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "a27b9c43-e672-46a3-8a46-042ae32e1e03");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "13286075-5c0f-40ca-8882-02e253c27910");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "3162cc3f-d641-427c-bd7c-3cf55043dbec");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "cbd96455-2068-4461-b3e4-b6443ade7dfb");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "cd9d7987-072c-47b4-b37a-6cf6659d3d1a");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "f8770135-cc60-4a9f-83d5-2e04b992d99a");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "8f7a87cc-53f3-4334-b0a1-cf841dff094a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48163789-5220-48f0-85b9-7ebbb3daa63e");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[,]
                {
                    { "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 5.0, new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6633), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6635), new DateTime(2024, 5, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6636), "Milk" },
                    { "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 10.0, new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6641), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6642), new DateTime(2024, 6, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6643), "Sugar" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "383efba3-7919-4b57-8c03-03bfe0cf79c3", "84cc31c0-c72c-429e-851c-b1f0dc79c6ad", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "802c8aa9-63ce-4bfb-816b-80c3df13fb8d", 0, "63d10159-1ff5-4f27-986b-fa57e13b4f20", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEJTB58CBhhJawRaEkwnYF15MMFPr+UMllAuh4c47g/FdMxPnCeuVnXdZovBZmPqWhg==", null, false, "0b133575-b304-486f-9247-8efef6762f2c", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "f4fce4e4-6aab-4eb2-bb0a-7783e943dc45", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6835), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "802c8aa9-63ce-4bfb-816b-80c3df13fb8d" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[,]
                {
                    { "011f010c-7347-4f39-8653-948cf14d2f13", "456 Elm St", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6412), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6414), false, "Tea Shop", "802c8aa9-63ce-4bfb-816b-80c3df13fb8d", 0.0, null },
                    { "8204c75f-26db-41f5-863e-80dd4de2d61a", "123 Main St", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6383), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6407), false, "Coffee House", "802c8aa9-63ce-4bfb-816b-80c3df13fb8d", 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "383efba3-7919-4b57-8c03-03bfe0cf79c3", "802c8aa9-63ce-4bfb-816b-80c3df13fb8d" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "0977a9e1-90a5-41d8-a307-534611762f6e", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6454), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6451), "Juice", "8204c75f-26db-41f5-863e-80dd4de2d61a" },
                    { "192e2624-2e3c-4f44-8794-2dee6934030a", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6436), "Tea", "8204c75f-26db-41f5-863e-80dd4de2d61a" },
                    { "64ee8438-1041-438c-8e02-bf1ae7f26c9b", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6446), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6443), "Smoothie", "8204c75f-26db-41f5-863e-80dd4de2d61a" },
                    { "d353bab7-1d31-4e69-a4cd-0472e342b521", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6428), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6425), "Coffee", "8204c75f-26db-41f5-863e-80dd4de2d61a" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "0a3b143e-9075-4de2-947b-9d1567e20368", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6485), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6482), "d353bab7-1d31-4e69-a4cd-0472e342b521", null, "Cappuccino", 28000.0 },
                    { "0b5863ad-7ef3-4ef1-9497-67339b4776ce", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6473), "d353bab7-1d31-4e69-a4cd-0472e342b521", null, "Latte", 28000.0 },
                    { "4cfffce0-cbfa-41f4-aace-569946ef38e7", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6492), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6489), "192e2624-2e3c-4f44-8794-2dee6934030a", null, "Earl Grey", 25000.0 },
                    { "5c74fe60-21b6-4317-b6eb-88b62cf5539f", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6496), "192e2624-2e3c-4f44-8794-2dee6934030a", null, "Green Tea", 22000.0 },
                    { "66f542bd-7ba8-4f1b-b6ef-550d154f65d5", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6505), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6502), "64ee8438-1041-438c-8e02-bf1ae7f26c9b", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "68fa4245-ba16-49de-bc36-1e351491d933", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6575), "0977a9e1-90a5-41d8-a307-534611762f6e", null, "Apple Juice", 24000.0 },
                    { "83fc24f7-c15c-44ed-92a0-1e46139ca2d7", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6562), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6558), "64ee8438-1041-438c-8e02-bf1ae7f26c9b", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "f947bf4e-44d1-4401-b392-f7f692e2da95", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6568), "0977a9e1-90a5-41d8-a307-534611762f6e", null, "Orange Juice", 24000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "1d0308f3-1e54-4bda-8e21-2694a16962c9", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6723), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6724), "66f542bd-7ba8-4f1b-b6ef-550d154f65d5", "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 50 },
                    { "26fce52c-c05a-4ae0-8303-395f286c97b3", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6787), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6789), "68fa4245-ba16-49de-bc36-1e351491d933", "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 100 },
                    { "2a4f2833-39d2-4fcc-894b-980a8237f2ca", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6710), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6712), "5c74fe60-21b6-4317-b6eb-88b62cf5539f", "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 50 },
                    { "2b9a6e88-1059-48d6-91c5-f39145dd5f35", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6703), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6704), "5c74fe60-21b6-4317-b6eb-88b62cf5539f", "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 100 },
                    { "50485ff5-c72f-42a6-82b3-be2093970f2d", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6696), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6698), "4cfffce0-cbfa-41f4-aace-569946ef38e7", "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 50 },
                    { "5ed76ae3-6b5b-408d-8662-e7e4c3067a15", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6676), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6677), "0a3b143e-9075-4de2-947b-9d1567e20368", "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 100 },
                    { "73a7f4f0-f628-4223-b8b8-89c6cb5a6249", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6795), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6796), "68fa4245-ba16-49de-bc36-1e351491d933", "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 50 },
                    { "7a9d7083-18c8-47b3-ac0c-a5c382b3ccb4", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6684), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6685), "0a3b143e-9075-4de2-947b-9d1567e20368", "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 50 },
                    { "ba09261e-9772-4755-80e6-ee05159901ba", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6662), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6664), "0b5863ad-7ef3-4ef1-9497-67339b4776ce", "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 100 },
                    { "be7a6cf3-1609-437a-9bdc-043a7da84953", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6737), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6738), "83fc24f7-c15c-44ed-92a0-1e46139ca2d7", "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 50 },
                    { "c00979c0-279f-4c95-8df6-28bb85cd0514", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6716), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6718), "66f542bd-7ba8-4f1b-b6ef-550d154f65d5", "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 100 },
                    { "c39c44f5-6b77-4ff5-a1f7-07791e2c7670", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6781), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6783), "f947bf4e-44d1-4401-b392-f7f692e2da95", "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 50 },
                    { "cf487165-6675-458a-b0db-5fbfb95df583", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6729), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6730), "83fc24f7-c15c-44ed-92a0-1e46139ca2d7", "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 100 },
                    { "dd4e95a4-85c2-4d2e-966d-9224a2a6b5fd", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6669), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6671), "0b5863ad-7ef3-4ef1-9497-67339b4776ce", "e6c40b6b-ed9d-473a-8243-d5d19d4c977d", 50 },
                    { "e7e72e99-b950-490b-8d3e-e195995394ac", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6743), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6744), "f947bf4e-44d1-4401-b392-f7f692e2da95", "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 100 },
                    { "ed507844-9909-4c7f-a0ac-76a6cda0bc23", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6690), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6691), "4cfffce0-cbfa-41f4-aace-569946ef38e7", "8b1098a7-1346-4769-b3f1-6f882fa4dff1", 100 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "6cd5ebf4-94f2-4601-9575-4b238ac610e8", new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6860), new DateTime(2024, 4, 15, 23, 11, 58, 184, DateTimeKind.Unspecified).AddTicks(6862), "0b5863ad-7ef3-4ef1-9497-67339b4776ce", null, "f4fce4e4-6aab-4eb2-bb0a-7783e943dc45", 1 });
        }
    }
}
