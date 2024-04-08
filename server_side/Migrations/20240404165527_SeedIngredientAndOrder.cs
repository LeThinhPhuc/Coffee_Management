using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class SeedIngredientAndOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "22748114-7e8e-4bc8-af73-fc9d61256675");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "406a12c4-79bc-47ce-9b5c-ed115968fe47");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "6fd93a8d-d96f-491b-8c4c-52b3453b781c");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "9ce1aa6f-ba94-40c4-af02-56409f21acec");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "c6767931-f026-4f78-b2dd-2e9834d88bef");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "c777c65f-e6ee-4ccb-a351-ad6fa875b214");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "e1dae903-f3ae-4c1b-bf1e-b381d19948e1");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "fbe7b46c-f8bd-4270-9e2f-2d4e6cc48891");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "6758ecee-57c6-4b45-8f39-5ec92d5e2a7e");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "3466d4cc-f915-4d83-817d-93dee09068a1");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "5e637cea-65b9-4f12-8885-9d6c8ef0bac0");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "b355ecad-c430-4731-8cab-eea9616cf0fe");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "e7032cf8-da66-44a6-a881-c6c18a286094");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "c0711330-37d4-4d18-878f-c63d7b2067c0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a24c0759-1939-4c93-9b64-459ace9ff81b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a24c0759-1939-4c93-9b64-459ace9ff81b", 0, "dccbcb88-215d-4c5b-a5f8-8e39e657f98d", "ApplicationUser", null, false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEBsX7xNOMfs35Ey5mo9z/Bh9u8iPQ1Dou44QpGKImHZ7E4MseBBTvsg70Mtul154Tg==", null, false, "394812cb-4cf2-47b4-9629-b4af2d35eeaa", false, "admin" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "Name", "OwnerId", "Revenue" },
                values: new object[] { "6758ecee-57c6-4b45-8f39-5ec92d5e2a7e", "456 Elm St", new DateTime(2024, 4, 4, 23, 31, 25, 254, DateTimeKind.Unspecified).AddTicks(9220), new DateTime(2024, 4, 4, 23, 31, 25, 254, DateTimeKind.Unspecified).AddTicks(9250), "Tea Shop", "a24c0759-1939-4c93-9b64-459ace9ff81b", 0.0 });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "Name", "OwnerId", "Revenue" },
                values: new object[] { "c0711330-37d4-4d18-878f-c63d7b2067c0", "123 Main St", new DateTime(2024, 4, 4, 23, 31, 25, 254, DateTimeKind.Unspecified).AddTicks(9120), new DateTime(2024, 4, 4, 23, 31, 25, 254, DateTimeKind.Unspecified).AddTicks(9180), "Coffee House", "a24c0759-1939-4c93-9b64-459ace9ff81b", 0.0 });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "3466d4cc-f915-4d83-817d-93dee09068a1", new DateTime(2024, 4, 4, 23, 31, 25, 254, DateTimeKind.Local).AddTicks(9380), new DateTime(2024, 4, 4, 23, 31, 25, 254, DateTimeKind.Unspecified).AddTicks(9370), "Coffee", "c0711330-37d4-4d18-878f-c63d7b2067c0" },
                    { "5e637cea-65b9-4f12-8885-9d6c8ef0bac0", new DateTime(2024, 4, 4, 23, 31, 25, 254, DateTimeKind.Local).AddTicks(9950), new DateTime(2024, 4, 4, 23, 31, 25, 254, DateTimeKind.Unspecified).AddTicks(9920), "Tea", "c0711330-37d4-4d18-878f-c63d7b2067c0" },
                    { "b355ecad-c430-4731-8cab-eea9616cf0fe", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(610), "Juice", "c0711330-37d4-4d18-878f-c63d7b2067c0" },
                    { "e7032cf8-da66-44a6-a881-c6c18a286094", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(250), "Smoothie", "c0711330-37d4-4d18-878f-c63d7b2067c0" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "22748114-7e8e-4bc8-af73-fc9d61256675", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(1760), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(1750), "b355ecad-c430-4731-8cab-eea9616cf0fe", null, "Apple Juice", 24000.0 },
                    { "406a12c4-79bc-47ce-9b5c-ed115968fe47", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(1700), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(1690), "b355ecad-c430-4731-8cab-eea9616cf0fe", null, "Orange Juice", 24000.0 },
                    { "6fd93a8d-d96f-491b-8c4c-52b3453b781c", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(1280), "5e637cea-65b9-4f12-8885-9d6c8ef0bac0", null, "Green Tea", 22000.0 },
                    { "9ce1aa6f-ba94-40c4-af02-56409f21acec", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(1380), "e7032cf8-da66-44a6-a881-c6c18a286094", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "c6767931-f026-4f78-b2dd-2e9834d88bef", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(870), "3466d4cc-f915-4d83-817d-93dee09068a1", null, "Latte", 28000.0 },
                    { "c777c65f-e6ee-4ccb-a351-ad6fa875b214", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(970), "3466d4cc-f915-4d83-817d-93dee09068a1", null, "Cappuccino", 28000.0 },
                    { "e1dae903-f3ae-4c1b-bf1e-b381d19948e1", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(1610), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(1580), "e7032cf8-da66-44a6-a881-c6c18a286094", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "fbe7b46c-f8bd-4270-9e2f-2d4e6cc48891", new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 4, 4, 23, 31, 25, 255, DateTimeKind.Unspecified).AddTicks(1170), "5e637cea-65b9-4f12-8885-9d6c8ef0bac0", null, "Earl Grey", 25000.0 }
                });
        }
    }
}
