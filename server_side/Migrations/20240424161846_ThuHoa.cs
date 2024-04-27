using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class ThuHoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 10.0, new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(547), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(553), new DateTime(2024, 6, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(556), "Sugar" },
                    { "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 5.0, new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(518), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(526), new DateTime(2024, 5, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(531), "Milk" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31033632-6ef6-4650-9023-f9c672f34894", "334362fa-6527-4c27-bef3-600a8e3d1586", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3623ea48-4ffb-4f99-ae6e-8d79445a4679", 0, "2aeaaf70-e848-4239-9089-b892936ef490", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEC/j9rMgUXlTQnfwHvofFUsEhvdHkf/8bBriJhD/xCT4t4Mrpz17utQiHNxj2N3DsA==", null, false, "b9803f73-6ef6-46e0-82cb-051b96bea191", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "7965599e-3a6b-44f5-a8a7-7c1d9c2e95a1", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(1121), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(1110), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "3623ea48-4ffb-4f99-ae6e-8d79445a4679" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[,]
                {
                    { "3d9b25b4-af22-4fa8-a207-ee282f712310", "456 Elm St", new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Unspecified).AddTicks(9814), new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Unspecified).AddTicks(9819), false, "Tea Shop", "3623ea48-4ffb-4f99-ae6e-8d79445a4679", 0.0, null },
                    { "663d9462-e3b1-463d-818d-87a91560230d", "123 Main St", new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Unspecified).AddTicks(9761), new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Unspecified).AddTicks(9789), false, "Coffee House", "3623ea48-4ffb-4f99-ae6e-8d79445a4679", 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "31033632-6ef6-4650-9023-f9c672f34894", "3623ea48-4ffb-4f99-ae6e-8d79445a4679" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "196dbcd6-2fe3-4593-a4ce-5789bbc39e07", new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Unspecified).AddTicks(9933), "Juice", "663d9462-e3b1-463d-818d-87a91560230d" },
                    { "6a343abb-7721-4ad3-84eb-efdf765a9ec1", new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Local).AddTicks(9866), new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Unspecified).AddTicks(9855), "Coffee", "663d9462-e3b1-463d-818d-87a91560230d" },
                    { "ab6d32b6-3a34-4444-a889-0521530f17b8", new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Unspecified).AddTicks(9906), "Smoothie", "663d9462-e3b1-463d-818d-87a91560230d" },
                    { "bed0174b-bca6-4b4e-94cf-6f4901ac1a1e", new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 4, 24, 23, 18, 43, 575, DateTimeKind.Unspecified).AddTicks(9881), "Tea", "663d9462-e3b1-463d-818d-87a91560230d" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "30851e7b-c848-4b6e-b036-c5e0c1cec599", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(334), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(324), "ab6d32b6-3a34-4444-a889-0521530f17b8", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "3fb444ba-0a88-495c-b241-463eac957042", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(305), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(287), "bed0174b-bca6-4b4e-94cf-6f4901ac1a1e", null, "Green Tea", 22000.0 },
                    { "54aefb4d-c877-4b80-981a-23bb8bccf701", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(400), "196dbcd6-2fe3-4593-a4ce-5789bbc39e07", null, "Apple Juice", 24000.0 },
                    { "633a5c94-03c6-4c5c-b262-cef77180092f", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(240), "6a343abb-7721-4ad3-84eb-efdf765a9ec1", null, "Cappuccino", 28000.0 },
                    { "76791528-9973-42be-a101-57c13dd80b6b", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(222), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(212), "6a343abb-7721-4ad3-84eb-efdf765a9ec1", null, "Latte", 28000.0 },
                    { "9368cd9d-c739-457c-8fcc-143f32ba490b", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(351), "ab6d32b6-3a34-4444-a889-0521530f17b8", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "aa28f4db-6996-41ca-8e6f-b77ea7274af7", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(377), "196dbcd6-2fe3-4593-a4ce-5789bbc39e07", null, "Orange Juice", 24000.0 },
                    { "e7ed390f-cb1d-4b55-9ba6-d59c2c21f96b", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Local).AddTicks(273), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(264), "bed0174b-bca6-4b4e-94cf-6f4901ac1a1e", null, "Earl Grey", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "0b5deaa0-3814-4ba1-a6ee-049c87f3c256", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(974), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(978), "aa28f4db-6996-41ca-8e6f-b77ea7274af7", "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 50 },
                    { "2a3e84d2-47fe-4fa0-8c46-f985e3931a7e", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(871), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(874), "3fb444ba-0a88-495c-b241-463eac957042", "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 50 },
                    { "41da0bc9-be9f-41b9-9bed-7d293dbfeb3a", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(700), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(705), "633a5c94-03c6-4c5c-b262-cef77180092f", "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 50 },
                    { "5635c464-ecd6-48b7-a4ce-5d6768603a3f", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(1014), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(1017), "54aefb4d-c877-4b80-981a-23bb8bccf701", "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 50 },
                    { "81e7dc31-34c2-4ed4-82a1-acfc26c9f861", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(943), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(947), "9368cd9d-c739-457c-8fcc-143f32ba490b", "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 50 },
                    { "916e9fba-4fd3-46ef-b4c7-90e6e6033910", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(887), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(892), "30851e7b-c848-4b6e-b036-c5e0c1cec599", "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 100 },
                    { "932b3846-a761-40e5-84ee-eb7c2966cca9", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(676), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(681), "633a5c94-03c6-4c5c-b262-cef77180092f", "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 100 },
                    { "972a7507-ff08-4d13-a196-5bd32094138e", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(959), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(962), "aa28f4db-6996-41ca-8e6f-b77ea7274af7", "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 100 },
                    { "981a1e74-c86b-4508-9273-d888aad769cc", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(926), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(929), "9368cd9d-c739-457c-8fcc-143f32ba490b", "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 100 },
                    { "a5eba369-6d72-4e1a-9ab0-367ccc242b29", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(996), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(1000), "54aefb4d-c877-4b80-981a-23bb8bccf701", "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 100 },
                    { "b00071e5-d8cd-4a1d-86de-dc27f12060c2", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(726), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(730), "e7ed390f-cb1d-4b55-9ba6-d59c2c21f96b", "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 100 },
                    { "b40f9272-b771-47af-89d6-dcca9c23f919", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(746), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(749), "e7ed390f-cb1d-4b55-9ba6-d59c2c21f96b", "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 50 },
                    { "b7d8060c-b6a1-4c39-8925-c323bfb1f269", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(618), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(624), "76791528-9973-42be-a101-57c13dd80b6b", "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 100 },
                    { "c68e080c-6b9d-4687-b6fc-f24b1a48da98", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(645), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(650), "76791528-9973-42be-a101-57c13dd80b6b", "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 50 },
                    { "d6c31a2b-6078-4780-b27c-64b2fb8c2ea7", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(850), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(855), "3fb444ba-0a88-495c-b241-463eac957042", "fcea6bfc-f3d0-4b49-a956-36d8988d2b74", 100 },
                    { "f0669a9f-5887-4675-9d83-0473aaefb272", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(905), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(908), "30851e7b-c848-4b6e-b036-c5e0c1cec599", "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90", 50 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "b29ff5fb-c554-4a81-82cf-32c8e924cb94", new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(1164), new DateTime(2024, 4, 24, 23, 18, 43, 576, DateTimeKind.Unspecified).AddTicks(1168), "76791528-9973-42be-a101-57c13dd80b6b", null, "7965599e-3a6b-44f5-a8a7-7c1d9c2e95a1", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "0b5deaa0-3814-4ba1-a6ee-049c87f3c256");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "2a3e84d2-47fe-4fa0-8c46-f985e3931a7e");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "41da0bc9-be9f-41b9-9bed-7d293dbfeb3a");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "5635c464-ecd6-48b7-a4ce-5d6768603a3f");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "81e7dc31-34c2-4ed4-82a1-acfc26c9f861");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "916e9fba-4fd3-46ef-b4c7-90e6e6033910");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "932b3846-a761-40e5-84ee-eb7c2966cca9");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "972a7507-ff08-4d13-a196-5bd32094138e");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "981a1e74-c86b-4508-9273-d888aad769cc");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "a5eba369-6d72-4e1a-9ab0-367ccc242b29");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "b00071e5-d8cd-4a1d-86de-dc27f12060c2");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "b40f9272-b771-47af-89d6-dcca9c23f919");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "b7d8060c-b6a1-4c39-8925-c323bfb1f269");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "c68e080c-6b9d-4687-b6fc-f24b1a48da98");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "d6c31a2b-6078-4780-b27c-64b2fb8c2ea7");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "f0669a9f-5887-4675-9d83-0473aaefb272");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "b29ff5fb-c554-4a81-82cf-32c8e924cb94");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "3d9b25b4-af22-4fa8-a207-ee282f712310");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31033632-6ef6-4650-9023-f9c672f34894", "3623ea48-4ffb-4f99-ae6e-8d79445a4679" });

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "30851e7b-c848-4b6e-b036-c5e0c1cec599");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "3fb444ba-0a88-495c-b241-463eac957042");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "54aefb4d-c877-4b80-981a-23bb8bccf701");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "633a5c94-03c6-4c5c-b262-cef77180092f");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "76791528-9973-42be-a101-57c13dd80b6b");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "9368cd9d-c739-457c-8fcc-143f32ba490b");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "aa28f4db-6996-41ca-8e6f-b77ea7274af7");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "e7ed390f-cb1d-4b55-9ba6-d59c2c21f96b");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "0a2c384e-fcf9-40ad-8fd7-c95d71c8cf90");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "fcea6bfc-f3d0-4b49-a956-36d8988d2b74");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "7965599e-3a6b-44f5-a8a7-7c1d9c2e95a1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "31033632-6ef6-4650-9023-f9c672f34894");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "196dbcd6-2fe3-4593-a4ce-5789bbc39e07");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "6a343abb-7721-4ad3-84eb-efdf765a9ec1");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "ab6d32b6-3a34-4444-a889-0521530f17b8");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "bed0174b-bca6-4b4e-94cf-6f4901ac1a1e");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "663d9462-e3b1-463d-818d-87a91560230d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3623ea48-4ffb-4f99-ae6e-8d79445a4679");

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
    }
}
