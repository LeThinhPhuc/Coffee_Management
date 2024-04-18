using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class EditOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "0dcf428c-4659-4e9b-b6ee-925521fd718b");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "16fd48bd-3fec-4776-ad14-9bec2097baf5");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "1776c6b4-619d-4e4a-b2ab-20abf5d67b67");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "41be01e1-e686-4ff8-b3c8-ef114bc1cfd9");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "4f855160-1f77-4cc5-8dfa-cc5da5ab4ab6");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "505bb2bf-3827-4575-9e36-a598f8348a39");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "64f938c4-b39c-4f70-8782-58cc98a0b698");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "697e6b3b-43a5-4833-bc98-01933ace3af6");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "702ea9fa-1ef3-4d7d-8583-3de4033f7e93");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "7e15ad5c-e791-47e5-95fb-39ea50b33f0a");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "89436eac-b4c7-49e4-b2e2-909896bb83d6");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "b0a21988-e0e9-4250-a92c-c28e2014481e");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "bf4d130e-6d96-45c1-a0fd-5a47cc8b5ac5");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "c92ef9e6-e7c5-4ca4-b1f6-9dd1f01c258b");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "d3a700f3-9491-43c9-a877-788810f7e121");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "f70f42cb-6eec-40ff-bfa5-aaf1c01aba8a");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "7bafb072-ccb9-47bf-be5f-e1bd9948b509");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "c0a1d224-0126-4f64-9235-684ac70d12c9");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "00e4f34a-f704-4a29-9ba9-7d5964b3199a");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "53280b04-0a65-457d-82e1-e20a35a43778");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "74fbcb1b-91bc-400e-99a4-b47e1b67cf00");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "80190a5b-5b99-43ae-8e59-9c0ec1927ebc");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "80477527-812f-4464-8100-e4ea46da0141");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "a42d4c77-29c9-429d-9734-a55159023769");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "cd1f5f60-22d4-4e85-891c-88a5e2f400eb");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "e156734c-76a1-4cce-b400-95e6f243bbda");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "af775785-e084-4600-99b4-6f6db460f760");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "268ce34b-48d6-4e09-a954-4e9322e413f1");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "3d456eec-ea33-4b01-88bf-90d8a74873a7");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "4be8424e-7de7-458b-ae36-c45aa7d40286");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "8aff5769-18dc-4487-9ff9-ca88a3d2d18c");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "b6a00992-f80f-44b9-9c2c-cc9fdb0f4041");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "42f2678a-004f-4f85-b00b-bc4223ca4041");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2fcc7b1d-8708-4d7f-9189-a4ce6cb53360");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[] { "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 10.0, new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(730), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(890), new DateTime(2024, 6, 5, 21, 15, 6, 891, DateTimeKind.Local).AddTicks(900), "Sugar" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[] { "d67f9ef5-34fa-4e87-b864-06653eb8039a", 5.0, new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(500), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(640), new DateTime(2024, 5, 5, 21, 15, 6, 891, DateTimeKind.Local).AddTicks(660), "Milk" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c0e66293-56a7-4d21-95c1-07f2e7f741a6", 0, "1f4f0a06-822f-4907-bff8-de82bfda67e2", "ApplicationUser", null, false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEFuUa6ZpYUIf8hyAymBWzjqkSXhbHRK4NPtsiUF8OcfpABcUxtMB6jnaiUZkklk4pw==", null, false, "972fe791-43dd-4bd4-9ebf-d8c88c25ae38", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "43c1b9b0-c089-4bfe-aeb9-fa0edcfcf174", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Local).AddTicks(3640), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(3610), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "c0e66293-56a7-4d21-95c1-07f2e7f741a6" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "Name", "OwnerId", "Revenue" },
                values: new object[] { "25466e12-2545-43b8-98da-13659f3b0fe7", "123 Main St", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(8080), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(8200), "Coffee House", "c0e66293-56a7-4d21-95c1-07f2e7f741a6", 0.0 });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "Name", "OwnerId", "Revenue" },
                values: new object[] { "4f5b368a-7d53-42a4-a1d8-1b0a4486ad17", "456 Elm St", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(8270), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(8350), "Tea Shop", "c0e66293-56a7-4d21-95c1-07f2e7f741a6", 0.0 });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "1341d162-42b3-43c0-84af-f349bdb94ccb", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(9080), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(9070), "Juice", "25466e12-2545-43b8-98da-13659f3b0fe7" },
                    { "35e315eb-570d-43f8-a074-08cd8d0a65c1", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(8970), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(8940), "Smoothie", "25466e12-2545-43b8-98da-13659f3b0fe7" },
                    { "bce5f450-0b36-4130-a8cb-a87a308da83d", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(8530), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(8510), "Coffee", "25466e12-2545-43b8-98da-13659f3b0fe7" },
                    { "f95ca8a8-936e-4e8b-9804-4fd77409120c", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(8650), "Tea", "25466e12-2545-43b8-98da-13659f3b0fe7" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "5b045f68-17ca-42f7-8d83-99fa58aac7d2", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(9540), "f95ca8a8-936e-4e8b-9804-4fd77409120c", null, "Earl Grey", 25000.0 },
                    { "6663b8ca-f03a-4100-9726-3fc701d5d065", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(280), "1341d162-42b3-43c0-84af-f349bdb94ccb", null, "Apple Juice", 24000.0 },
                    { "6ae866bc-fee7-4f36-9e27-e94f708a5ffe", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(9430), "bce5f450-0b36-4130-a8cb-a87a308da83d", null, "Cappuccino", 28000.0 },
                    { "7ef11968-0a2d-4810-b8d4-4328272ed6ba", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(9910), "35e315eb-570d-43f8-a074-08cd8d0a65c1", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "8380d357-19b1-415c-ab7d-ba9970b42c55", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(40), "35e315eb-570d-43f8-a074-08cd8d0a65c1", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "ba11474b-7948-49c9-b1ee-1ee3865dd013", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(9290), "bce5f450-0b36-4130-a8cb-a87a308da83d", null, "Latte", 28000.0 },
                    { "dcd82f43-75e7-464f-8443-097940555441", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(140), "1341d162-42b3-43c0-84af-f349bdb94ccb", null, "Orange Juice", 24000.0 },
                    { "ed958a4b-9677-4b14-8cc8-7a3574824e07", new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 4, 5, 21, 15, 6, 890, DateTimeKind.Unspecified).AddTicks(9680), "f95ca8a8-936e-4e8b-9804-4fd77409120c", null, "Green Tea", 22000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "083795e4-254f-4a9c-b65a-22a712a4ec19", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2920), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2970), "dcd82f43-75e7-464f-8443-097940555441", "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 50 },
                    { "09feb1d1-ab73-4291-8a90-5f23a1e7fa3c", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1200), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1250), "ba11474b-7948-49c9-b1ee-1ee3865dd013", "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 50 },
                    { "1a3140a8-a984-4893-9875-351abd63cdee", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2800), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2850), "dcd82f43-75e7-464f-8443-097940555441", "d67f9ef5-34fa-4e87-b864-06653eb8039a", 100 },
                    { "3103dd7e-e46a-4580-9044-5cbaa5e2ce0a", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2470), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2520), "8380d357-19b1-415c-ab7d-ba9970b42c55", "d67f9ef5-34fa-4e87-b864-06653eb8039a", 100 },
                    { "322491a6-6f08-4630-afee-9b25af47ae8d", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1980), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2030), "ed958a4b-9677-4b14-8cc8-7a3574824e07", "d67f9ef5-34fa-4e87-b864-06653eb8039a", 100 },
                    { "3a4e322c-7403-4f89-9d4f-368ee989f36e", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1070), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1120), "ba11474b-7948-49c9-b1ee-1ee3865dd013", "d67f9ef5-34fa-4e87-b864-06653eb8039a", 100 },
                    { "59b66662-8445-4f3b-922a-cd5e177c5c3c", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1830), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1900), "5b045f68-17ca-42f7-8d83-99fa58aac7d2", "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 50 },
                    { "766fb8ab-b818-4f87-a2c4-f9f94d320e4c", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2230), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2280), "7ef11968-0a2d-4810-b8d4-4328272ed6ba", "d67f9ef5-34fa-4e87-b864-06653eb8039a", 100 },
                    { "9a7a5030-1175-4ec2-928a-0eb199e5ffc4", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1450), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1500), "6ae866bc-fee7-4f36-9e27-e94f708a5ffe", "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 50 },
                    { "9c827b33-4b3f-4a18-b45d-9037269291b4", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2670), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2730), "8380d357-19b1-415c-ab7d-ba9970b42c55", "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 50 },
                    { "9f2cb589-8b89-43a0-95ed-89405b9786a5", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1580), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1630), "5b045f68-17ca-42f7-8d83-99fa58aac7d2", "d67f9ef5-34fa-4e87-b864-06653eb8039a", 100 },
                    { "a88848cd-ab2d-4b8a-93b2-dcf9a4665b52", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(3040), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(3090), "6663b8ca-f03a-4100-9726-3fc701d5d065", "d67f9ef5-34fa-4e87-b864-06653eb8039a", 100 },
                    { "de23bbcf-a25b-4bf2-892e-9d91399819af", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2360), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2410), "7ef11968-0a2d-4810-b8d4-4328272ed6ba", "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 50 },
                    { "e3e1b2bb-edc8-46ed-9262-3c21e4bf283e", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1320), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(1370), "6ae866bc-fee7-4f36-9e27-e94f708a5ffe", "d67f9ef5-34fa-4e87-b864-06653eb8039a", 100 },
                    { "ea4ed92e-f61b-42b9-907d-08292a648601", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(3150), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(3200), "6663b8ca-f03a-4100-9726-3fc701d5d065", "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 50 },
                    { "f7b4e3d8-2168-4afc-a983-67e27544f654", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2100), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(2160), "ed958a4b-9677-4b14-8cc8-7a3574824e07", "9ec835d7-8dc5-4e81-a6dc-a38e57b96129", 50 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "1f8ee569-977c-40b6-aba9-db454bf32eed", new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(3780), new DateTime(2024, 4, 5, 21, 15, 6, 891, DateTimeKind.Unspecified).AddTicks(3830), "ba11474b-7948-49c9-b1ee-1ee3865dd013", null, "43c1b9b0-c089-4bfe-aeb9-fa0edcfcf174", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "083795e4-254f-4a9c-b65a-22a712a4ec19");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "09feb1d1-ab73-4291-8a90-5f23a1e7fa3c");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "1a3140a8-a984-4893-9875-351abd63cdee");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "3103dd7e-e46a-4580-9044-5cbaa5e2ce0a");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "322491a6-6f08-4630-afee-9b25af47ae8d");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "3a4e322c-7403-4f89-9d4f-368ee989f36e");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "59b66662-8445-4f3b-922a-cd5e177c5c3c");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "766fb8ab-b818-4f87-a2c4-f9f94d320e4c");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "9a7a5030-1175-4ec2-928a-0eb199e5ffc4");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "9c827b33-4b3f-4a18-b45d-9037269291b4");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "9f2cb589-8b89-43a0-95ed-89405b9786a5");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "a88848cd-ab2d-4b8a-93b2-dcf9a4665b52");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "de23bbcf-a25b-4bf2-892e-9d91399819af");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "e3e1b2bb-edc8-46ed-9262-3c21e4bf283e");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "ea4ed92e-f61b-42b9-907d-08292a648601");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "f7b4e3d8-2168-4afc-a983-67e27544f654");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "1f8ee569-977c-40b6-aba9-db454bf32eed");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "4f5b368a-7d53-42a4-a1d8-1b0a4486ad17");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "5b045f68-17ca-42f7-8d83-99fa58aac7d2");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "6663b8ca-f03a-4100-9726-3fc701d5d065");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "6ae866bc-fee7-4f36-9e27-e94f708a5ffe");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "7ef11968-0a2d-4810-b8d4-4328272ed6ba");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "8380d357-19b1-415c-ab7d-ba9970b42c55");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "ba11474b-7948-49c9-b1ee-1ee3865dd013");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "dcd82f43-75e7-464f-8443-097940555441");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "ed958a4b-9677-4b14-8cc8-7a3574824e07");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "9ec835d7-8dc5-4e81-a6dc-a38e57b96129");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "d67f9ef5-34fa-4e87-b864-06653eb8039a");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "43c1b9b0-c089-4bfe-aeb9-fa0edcfcf174");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "1341d162-42b3-43c0-84af-f349bdb94ccb");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "35e315eb-570d-43f8-a074-08cd8d0a65c1");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "bce5f450-0b36-4130-a8cb-a87a308da83d");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "f95ca8a8-936e-4e8b-9804-4fd77409120c");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "25466e12-2545-43b8-98da-13659f3b0fe7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c0e66293-56a7-4d21-95c1-07f2e7f741a6");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[] { "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 5.0, new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2300), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2340), new DateTime(2024, 5, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(2350), "Milk" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[] { "af775785-e084-4600-99b4-6f6db460f760", 10.0, new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2400), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2440), new DateTime(2024, 6, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(2450), "Sugar" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2fcc7b1d-8708-4d7f-9189-a4ce6cb53360", 0, "1ee91795-478c-44eb-b6fb-00dc9cb88dbf", "ApplicationUser", null, false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEEkJcUlbE3c5nXk2z0+dvCrEqgONMNE0KdeDBWHnrPq9MZt2C1HrCOYHvLl44S340g==", null, false, "46a80db9-5975-40ef-9f61-8ade85b8a481", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "OrderDate", "Total", "UserId" },
                values: new object[] { "268ce34b-48d6-4e09-a954-4e9322e413f1", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5710), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "2fcc7b1d-8708-4d7f-9189-a4ce6cb53360" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "Name", "OwnerId", "Revenue" },
                values: new object[] { "42f2678a-004f-4f85-b00b-bc4223ca4041", "123 Main St", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1080), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1140), "Coffee House", "2fcc7b1d-8708-4d7f-9189-a4ce6cb53360", 0.0 });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "Name", "OwnerId", "Revenue" },
                values: new object[] { "c0a1d224-0126-4f64-9235-684ac70d12c9", "456 Elm St", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1190), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1210), "Tea Shop", "2fcc7b1d-8708-4d7f-9189-a4ce6cb53360", 0.0 });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "3d456eec-ea33-4b01-88bf-90d8a74873a7", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1300), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1290), "Coffee", "42f2678a-004f-4f85-b00b-bc4223ca4041" },
                    { "4be8424e-7de7-458b-ae36-c45aa7d40286", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1410), "Smoothie", "42f2678a-004f-4f85-b00b-bc4223ca4041" },
                    { "8aff5769-18dc-4487-9ff9-ca88a3d2d18c", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1560), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1470), "Juice", "42f2678a-004f-4f85-b00b-bc4223ca4041" },
                    { "b6a00992-f80f-44b9-9c2c-cc9fdb0f4041", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1350), "Tea", "42f2678a-004f-4f85-b00b-bc4223ca4041" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "00e4f34a-f704-4a29-9ba9-7d5964b3199a", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1680), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1670), "3d456eec-ea33-4b01-88bf-90d8a74873a7", null, "Latte", 28000.0 },
                    { "53280b04-0a65-457d-82e1-e20a35a43778", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1880), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1870), "b6a00992-f80f-44b9-9c2c-cc9fdb0f4041", null, "Green Tea", 22000.0 },
                    { "74fbcb1b-91bc-400e-99a4-b47e1b67cf00", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2190), "8aff5769-18dc-4487-9ff9-ca88a3d2d18c", null, "Apple Juice", 24000.0 },
                    { "80190a5b-5b99-43ae-8e59-9c0ec1927ebc", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1930), "4be8424e-7de7-458b-ae36-c45aa7d40286", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "80477527-812f-4464-8100-e4ea46da0141", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(2070), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2060), "4be8424e-7de7-458b-ae36-c45aa7d40286", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "a42d4c77-29c9-429d-9734-a55159023769", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1800), "b6a00992-f80f-44b9-9c2c-cc9fdb0f4041", null, "Earl Grey", 25000.0 },
                    { "cd1f5f60-22d4-4e85-891c-88a5e2f400eb", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(1750), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(1730), "3d456eec-ea33-4b01-88bf-90d8a74873a7", null, "Cappuccino", 28000.0 },
                    { "e156734c-76a1-4cce-b400-95e6f243bbda", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2120), "8aff5769-18dc-4487-9ff9-ca88a3d2d18c", null, "Orange Juice", 24000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "0dcf428c-4659-4e9b-b6ee-925521fd718b", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5450), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5470), "74fbcb1b-91bc-400e-99a4-b47e1b67cf00", "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 100 },
                    { "16fd48bd-3fec-4776-ad14-9bec2097baf5", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5000), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5030), "80190a5b-5b99-43ae-8e59-9c0ec1927ebc", "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 100 },
                    { "1776c6b4-619d-4e4a-b2ab-20abf5d67b67", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(4070), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(4160), "a42d4c77-29c9-429d-9734-a55159023769", "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 100 },
                    { "41be01e1-e686-4ff8-b3c8-ef114bc1cfd9", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5070), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5100), "80190a5b-5b99-43ae-8e59-9c0ec1927ebc", "af775785-e084-4600-99b4-6f6db460f760", 50 },
                    { "4f855160-1f77-4cc5-8dfa-cc5da5ab4ab6", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5190), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5220), "80477527-812f-4464-8100-e4ea46da0141", "af775785-e084-4600-99b4-6f6db460f760", 50 },
                    { "505bb2bf-3827-4575-9e36-a598f8348a39", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(4940), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(4960), "53280b04-0a65-457d-82e1-e20a35a43778", "af775785-e084-4600-99b4-6f6db460f760", 50 },
                    { "64f938c4-b39c-4f70-8782-58cc98a0b698", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(3340), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(3530), "cd1f5f60-22d4-4e85-891c-88a5e2f400eb", "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 100 },
                    { "697e6b3b-43a5-4833-bc98-01933ace3af6", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5510), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5530), "74fbcb1b-91bc-400e-99a4-b47e1b67cf00", "af775785-e084-4600-99b4-6f6db460f760", 50 },
                    { "702ea9fa-1ef3-4d7d-8583-3de4033f7e93", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5390), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5410), "e156734c-76a1-4cce-b400-95e6f243bbda", "af775785-e084-4600-99b4-6f6db460f760", 50 },
                    { "7e15ad5c-e791-47e5-95fb-39ea50b33f0a", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(3700), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(3890), "cd1f5f60-22d4-4e85-891c-88a5e2f400eb", "af775785-e084-4600-99b4-6f6db460f760", 50 },
                    { "89436eac-b4c7-49e4-b2e2-909896bb83d6", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(3010), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(3170), "00e4f34a-f704-4a29-9ba9-7d5964b3199a", "af775785-e084-4600-99b4-6f6db460f760", 50 },
                    { "b0a21988-e0e9-4250-a92c-c28e2014481e", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5250), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5340), "e156734c-76a1-4cce-b400-95e6f243bbda", "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 100 },
                    { "bf4d130e-6d96-45c1-a0fd-5a47cc8b5ac5", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(4320), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(4790), "53280b04-0a65-457d-82e1-e20a35a43778", "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 100 },
                    { "c92ef9e6-e7c5-4ca4-b1f6-9dd1f01c258b", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(4230), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(4270), "a42d4c77-29c9-429d-9734-a55159023769", "af775785-e084-4600-99b4-6f6db460f760", 50 },
                    { "d3a700f3-9491-43c9-a877-788810f7e121", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5130), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5160), "80477527-812f-4464-8100-e4ea46da0141", "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 100 },
                    { "f70f42cb-6eec-40ff-bfa5-aaf1c01aba8a", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2610), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(2700), "00e4f34a-f704-4a29-9ba9-7d5964b3199a", "50a6f2a0-54e8-4ff3-a952-a99cda0c8e29", 100 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "7bafb072-ccb9-47bf-be5f-e1bd9948b509", new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5790), new DateTime(2024, 4, 4, 23, 55, 26, 628, DateTimeKind.Unspecified).AddTicks(5820), "00e4f34a-f704-4a29-9ba9-7d5964b3199a", null, "268ce34b-48d6-4e09-a954-4e9322e413f1", 1 });
        }
    }
}
