using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class AddRoleToSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "1af9c4d2-8d07-4b7e-ab7e-a96aeb31e5c4");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "2bcb3846-0006-4a3c-ad36-d85341537e53");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "2d4ebac3-5ca0-4f09-bbf6-73921f6cf66c");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "34a37889-0b43-4081-8027-553f3e43e8d0");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "3a730ccd-c010-4982-9045-ecc774557ef1");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "3b0cbdb8-e4f8-4014-83a6-f1b037629550");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "4be45eff-bbe8-4728-b965-346f71b4e230");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "569fe598-9085-4e5b-8068-f2e55d27b26a");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "5d47669d-da69-4bb5-925b-8dac5d33d8bc");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "7cec59d8-9f34-4758-ba44-609dc527f8ec");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "8275c9b7-3463-4e66-8675-48c1d38ec43d");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "86b3fbef-dacb-4561-9524-db4c0b43de93");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "bb166fd3-dc91-4628-9f2f-c8f145467b70");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "c7b31773-65fa-452e-8bd2-2f7b495f9061");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "d0b8fa9f-84aa-4130-a123-af289407f140");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "f23f2040-6470-47d0-8260-57403f0bf4dd");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "9ac20f7c-e47e-45bc-8032-fa80cd987789");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "9e7d2f99-cd63-4808-a7d4-5a8183778699");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "3764424e-06dc-45cd-bfa9-3c0f1d371d0e");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "6f2274b6-6b2c-4919-9ebb-b382d11fde52");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "7471af51-6ad0-4597-abb9-acf774aef794");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "7f44039c-9b26-4645-9f50-47035c0453b0");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "8e4653b4-f6e2-4ed4-81c3-b24c96766218");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "d549f3fb-9dd9-4d8e-a313-88cd5421ae6e");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "d68052ce-00bb-42b4-aaef-1da972126682");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "dd557a07-9f9f-4b68-9fe8-926eb3acf5e9");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "33d4fe6f-3deb-4032-95d5-240cdb1629a7");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "a867a594-da11-48c5-9590-7a33f801026b");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "6a74379c-57ae-46aa-a271-e0f32041ac76");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "aaa27103-b226-4562-b7d1-4e30a231ce91");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "cc91be65-a41c-4717-b574-bc57e02759f5");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "d92ae67c-94d4-4fb4-b430-20e891754707");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "f7cdbe36-a2f9-43a6-b94d-0e438b1ae861");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46cccf6c-7fd7-4dee-8272-2e2d284b5ddf");

            migrationBuilder.AddColumn<bool>(
                name: "IsSuspended",
                table: "Shops",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspensionEndDate",
                table: "Shops",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[,]
                {
                    { "33cb620e-746c-4212-aff3-5448fc3d2b24", 10.0, new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(220), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(240), new DateTime(2024, 6, 14, 0, 27, 3, 513, DateTimeKind.Local).AddTicks(250), "Sugar" },
                    { "690621f7-0f25-4a35-8bed-8c2a968f197a", 5.0, new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(150), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(180), new DateTime(2024, 5, 14, 0, 27, 3, 513, DateTimeKind.Local).AddTicks(190), "Milk" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ec70352-b83e-463f-890e-a2935450376e", "7e05ad81-9586-48de-a337-610fc25a5589", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f4dfa19f-3243-48fd-b2cd-e187beefd672", 0, "0cf83623-dd01-4dc8-a665-7d9108dfd3d7", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEEyso3P/S4/xM9dVs0jDq9aUkDPBXcki3++HJzpO9DkU6bYJc7dX6Jkb4E1ocN7QZg==", null, false, "d366722b-7ada-4f04-bc06-9155d2f5955c", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "733a0e42-2cfa-4b68-b148-730a6a160b58", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Local).AddTicks(1900), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1880), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "f4dfa19f-3243-48fd-b2cd-e187beefd672" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[,]
                {
                    { "2c2a561e-a060-4475-81a3-7116d8180ebf", "456 Elm St", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9060), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9080), false, "Tea Shop", "f4dfa19f-3243-48fd-b2cd-e187beefd672", 0.0, null },
                    { "fd827bac-0bba-40df-adb9-a26f36c528e5", "123 Main St", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(8960), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9020), false, "Coffee House", "f4dfa19f-3243-48fd-b2cd-e187beefd672", 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3ec70352-b83e-463f-890e-a2935450376e", "f4dfa19f-3243-48fd-b2cd-e187beefd672" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "60fc2806-2c83-41bc-8f92-809a3116ca33", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9430), "Juice", "fd827bac-0bba-40df-adb9-a26f36c528e5" },
                    { "82c34dab-70c0-46e4-a06d-4d3439cbb589", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9160), "Coffee", "fd827bac-0bba-40df-adb9-a26f36c528e5" },
                    { "c1aa00ce-7c64-4981-8dc2-f58f6fe0dd3e", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9370), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9360), "Smoothie", "fd827bac-0bba-40df-adb9-a26f36c528e5" },
                    { "dd91c711-8e1f-4d90-ace8-f696b95d1ed7", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9220), "Tea", "fd827bac-0bba-40df-adb9-a26f36c528e5" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "148be6e8-72c1-43b6-99fc-d0ed91f75d80", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9610), "82c34dab-70c0-46e4-a06d-4d3439cbb589", null, "Cappuccino", 28000.0 },
                    { "2a32adc7-92d8-4e83-bdb0-0ff028de8e3d", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9740), "dd91c711-8e1f-4d90-ace8-f696b95d1ed7", null, "Green Tea", 22000.0 },
                    { "4f927e1f-8fb7-4a61-8c2d-9498227823a9", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Local), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9990), "60fc2806-2c83-41bc-8f92-809a3116ca33", null, "Orange Juice", 24000.0 },
                    { "5868bc92-9f4e-47cc-8fdb-13e3d4a8a0fa", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9870), "c1aa00ce-7c64-4981-8dc2-f58f6fe0dd3e", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "9bdebaef-4ed5-4bb2-8162-61e20d2bfb04", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9930), "c1aa00ce-7c64-4981-8dc2-f58f6fe0dd3e", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "d43534a6-ebdb-4a6d-8808-601075e9233e", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Local).AddTicks(70), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(60), "60fc2806-2c83-41bc-8f92-809a3116ca33", null, "Apple Juice", 24000.0 },
                    { "f4b2244e-cebd-42b7-85c2-bd1539de485a", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9670), "dd91c711-8e1f-4d90-ace8-f696b95d1ed7", null, "Earl Grey", 25000.0 },
                    { "f9655de8-f30c-4910-91ca-1e07c0070700", new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Local).AddTicks(9560), new DateTime(2024, 4, 14, 0, 27, 3, 512, DateTimeKind.Unspecified).AddTicks(9540), "82c34dab-70c0-46e4-a06d-4d3439cbb589", null, "Latte", 28000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "0cd843a3-b6c1-480a-969c-f82842f95a35", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1540), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1560), "4f927e1f-8fb7-4a61-8c2d-9498227823a9", "690621f7-0f25-4a35-8bed-8c2a968f197a", 100 },
                    { "1f78dd55-f575-429f-883d-afdc27f28923", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(700), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1060), "f4b2244e-cebd-42b7-85c2-bd1539de485a", "33cb620e-746c-4212-aff3-5448fc3d2b24", 50 },
                    { "213d09e4-717f-44c4-b591-4c1acafad5fa", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1300), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1320), "5868bc92-9f4e-47cc-8fdb-13e3d4a8a0fa", "33cb620e-746c-4212-aff3-5448fc3d2b24", 50 },
                    { "2c0904e8-bf92-4448-a97b-78e2be53f32b", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1120), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1140), "2a32adc7-92d8-4e83-bdb0-0ff028de8e3d", "690621f7-0f25-4a35-8bed-8c2a968f197a", 100 },
                    { "3b510b2b-e15e-4c93-95e7-70566140bdae", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1720), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1750), "d43534a6-ebdb-4a6d-8808-601075e9233e", "33cb620e-746c-4212-aff3-5448fc3d2b24", 50 },
                    { "51e6b005-2f67-49dd-9952-e6e11b194e0b", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1600), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1620), "4f927e1f-8fb7-4a61-8c2d-9498227823a9", "33cb620e-746c-4212-aff3-5448fc3d2b24", 50 },
                    { "7e3aaefd-73c8-4efb-aa95-1d4bd99ccc00", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1180), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1210), "2a32adc7-92d8-4e83-bdb0-0ff028de8e3d", "33cb620e-746c-4212-aff3-5448fc3d2b24", 50 },
                    { "88ed8e55-0787-4d2a-a9d7-4ed7e48ca276", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1660), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1690), "d43534a6-ebdb-4a6d-8808-601075e9233e", "690621f7-0f25-4a35-8bed-8c2a968f197a", 100 },
                    { "a1175138-2364-4200-a012-cfaedaadb349", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1360), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1380), "9bdebaef-4ed5-4bb2-8162-61e20d2bfb04", "690621f7-0f25-4a35-8bed-8c2a968f197a", 100 },
                    { "b3120ea5-af7c-457e-87e4-6ee839f89395", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(460), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(480), "f9655de8-f30c-4910-91ca-1e07c0070700", "33cb620e-746c-4212-aff3-5448fc3d2b24", 50 },
                    { "c73894c5-3b0f-462b-a883-04e4b25969ed", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(390), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(420), "f9655de8-f30c-4910-91ca-1e07c0070700", "690621f7-0f25-4a35-8bed-8c2a968f197a", 100 },
                    { "c96770b8-d221-4010-b738-179d5def3853", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1420), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1500), "9bdebaef-4ed5-4bb2-8162-61e20d2bfb04", "33cb620e-746c-4212-aff3-5448fc3d2b24", 50 },
                    { "d248c312-3738-4ea7-9769-feeef05998c3", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(640), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(670), "f4b2244e-cebd-42b7-85c2-bd1539de485a", "690621f7-0f25-4a35-8bed-8c2a968f197a", 100 },
                    { "d57e31a0-1dbe-428d-b0fa-4430f9b7bc20", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(580), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(610), "148be6e8-72c1-43b6-99fc-d0ed91f75d80", "33cb620e-746c-4212-aff3-5448fc3d2b24", 50 },
                    { "d6ecb34a-c359-4c40-8fe8-8a73134e9ac7", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1240), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(1260), "5868bc92-9f4e-47cc-8fdb-13e3d4a8a0fa", "690621f7-0f25-4a35-8bed-8c2a968f197a", 100 },
                    { "f1ec82de-2f4b-4f87-97f0-f72e920732d4", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(520), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(550), "148be6e8-72c1-43b6-99fc-d0ed91f75d80", "690621f7-0f25-4a35-8bed-8c2a968f197a", 100 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "4228af53-d20e-4745-9597-f39f1162fd90", new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(2010), new DateTime(2024, 4, 14, 0, 27, 3, 513, DateTimeKind.Unspecified).AddTicks(2040), "f9655de8-f30c-4910-91ca-1e07c0070700", null, "733a0e42-2cfa-4b68-b148-730a6a160b58", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "0cd843a3-b6c1-480a-969c-f82842f95a35");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "1f78dd55-f575-429f-883d-afdc27f28923");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "213d09e4-717f-44c4-b591-4c1acafad5fa");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "2c0904e8-bf92-4448-a97b-78e2be53f32b");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "3b510b2b-e15e-4c93-95e7-70566140bdae");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "51e6b005-2f67-49dd-9952-e6e11b194e0b");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "7e3aaefd-73c8-4efb-aa95-1d4bd99ccc00");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "88ed8e55-0787-4d2a-a9d7-4ed7e48ca276");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "a1175138-2364-4200-a012-cfaedaadb349");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "b3120ea5-af7c-457e-87e4-6ee839f89395");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "c73894c5-3b0f-462b-a883-04e4b25969ed");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "c96770b8-d221-4010-b738-179d5def3853");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "d248c312-3738-4ea7-9769-feeef05998c3");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "d57e31a0-1dbe-428d-b0fa-4430f9b7bc20");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "d6ecb34a-c359-4c40-8fe8-8a73134e9ac7");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "f1ec82de-2f4b-4f87-97f0-f72e920732d4");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "4228af53-d20e-4745-9597-f39f1162fd90");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "2c2a561e-a060-4475-81a3-7116d8180ebf");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ec70352-b83e-463f-890e-a2935450376e", "f4dfa19f-3243-48fd-b2cd-e187beefd672" });

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "148be6e8-72c1-43b6-99fc-d0ed91f75d80");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "2a32adc7-92d8-4e83-bdb0-0ff028de8e3d");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "4f927e1f-8fb7-4a61-8c2d-9498227823a9");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "5868bc92-9f4e-47cc-8fdb-13e3d4a8a0fa");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "9bdebaef-4ed5-4bb2-8162-61e20d2bfb04");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "d43534a6-ebdb-4a6d-8808-601075e9233e");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "f4b2244e-cebd-42b7-85c2-bd1539de485a");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "f9655de8-f30c-4910-91ca-1e07c0070700");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "33cb620e-746c-4212-aff3-5448fc3d2b24");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "690621f7-0f25-4a35-8bed-8c2a968f197a");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "733a0e42-2cfa-4b68-b148-730a6a160b58");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3ec70352-b83e-463f-890e-a2935450376e");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "60fc2806-2c83-41bc-8f92-809a3116ca33");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "82c34dab-70c0-46e4-a06d-4d3439cbb589");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "c1aa00ce-7c64-4981-8dc2-f58f6fe0dd3e");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "dd91c711-8e1f-4d90-ace8-f696b95d1ed7");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "fd827bac-0bba-40df-adb9-a26f36c528e5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f4dfa19f-3243-48fd-b2cd-e187beefd672");

            migrationBuilder.DropColumn(
                name: "IsSuspended",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "SuspensionEndDate",
                table: "Shops");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[] { "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 5.0, new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4440), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4560), new DateTime(2024, 5, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(4570), "Milk" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Name" },
                values: new object[] { "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 10.0, new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4620), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4670), new DateTime(2024, 6, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(4680), "Sugar" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "46cccf6c-7fd7-4dee-8272-2e2d284b5ddf", 0, "93b5bca2-f30b-4fe7-a4c7-e5cfa1a2cc0d", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEELYojE1PFp50tVceJk36b/Y7us8DA6PzIcyrv3DrUggJ5pw4IETY722inC3z7ex/g==", null, false, "c477219d-9ad2-47e4-bc91-5d057fd260c3", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "a867a594-da11-48c5-9590-7a33f801026b", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6920), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "46cccf6c-7fd7-4dee-8272-2e2d284b5ddf" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "Name", "OwnerId", "Revenue" },
                values: new object[] { "9e7d2f99-cd63-4808-a7d4-5a8183778699", "456 Elm St", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(2660), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(2700), "Tea Shop", "46cccf6c-7fd7-4dee-8272-2e2d284b5ddf", 0.0 });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "Name", "OwnerId", "Revenue" },
                values: new object[] { "f7cdbe36-a2f9-43a6-b94d-0e438b1ae861", "123 Main St", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(2490), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(2590), "Coffee House", "46cccf6c-7fd7-4dee-8272-2e2d284b5ddf", 0.0 });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "6a74379c-57ae-46aa-a271-e0f32041ac76", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(3330), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(3320), "Juice", "f7cdbe36-a2f9-43a6-b94d-0e438b1ae861" },
                    { "aaa27103-b226-4562-b7d1-4e30a231ce91", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(3130), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(3110), "Tea", "f7cdbe36-a2f9-43a6-b94d-0e438b1ae861" },
                    { "cc91be65-a41c-4717-b574-bc57e02759f5", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(3210), "Smoothie", "f7cdbe36-a2f9-43a6-b94d-0e438b1ae861" },
                    { "d92ae67c-94d4-4fb4-b430-20e891754707", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(2820), "Coffee", "f7cdbe36-a2f9-43a6-b94d-0e438b1ae861" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "3764424e-06dc-45cd-bfa9-3c0f1d371d0e", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(4110), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4100), "cc91be65-a41c-4717-b574-bc57e02759f5", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "6f2274b6-6b2c-4919-9ebb-b382d11fde52", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(4220), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4200), "6a74379c-57ae-46aa-a271-e0f32041ac76", null, "Orange Juice", 24000.0 },
                    { "7471af51-6ad0-4597-abb9-acf774aef794", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(3580), "d92ae67c-94d4-4fb4-b430-20e891754707", null, "Cappuccino", 28000.0 },
                    { "7f44039c-9b26-4645-9f50-47035c0453b0", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(3490), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(3480), "d92ae67c-94d4-4fb4-b430-20e891754707", null, "Latte", 28000.0 },
                    { "8e4653b4-f6e2-4ed4-81c3-b24c96766218", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(3890), "aaa27103-b226-4562-b7d1-4e30a231ce91", null, "Green Tea", 22000.0 },
                    { "d549f3fb-9dd9-4d8e-a313-88cd5421ae6e", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4300), "6a74379c-57ae-46aa-a271-e0f32041ac76", null, "Apple Juice", 24000.0 },
                    { "d68052ce-00bb-42b4-aaef-1da972126682", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(3720), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(3690), "aaa27103-b226-4562-b7d1-4e30a231ce91", null, "Earl Grey", 25000.0 },
                    { "dd557a07-9f9f-4b68-9fe8-926eb3acf5e9", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Local).AddTicks(4010), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(3990), "cc91be65-a41c-4717-b574-bc57e02759f5", null, "Strawberry Banana Smoothie", 28000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "1af9c4d2-8d07-4b7e-ab7e-a96aeb31e5c4", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5540), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5580), "8e4653b4-f6e2-4ed4-81c3-b24c96766218", "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 100 },
                    { "2bcb3846-0006-4a3c-ad36-d85341537e53", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6520), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6560), "d549f3fb-9dd9-4d8e-a313-88cd5421ae6e", "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 50 },
                    { "2d4ebac3-5ca0-4f09-bbf6-73921f6cf66c", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5080), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5120), "7471af51-6ad0-4597-abb9-acf774aef794", "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 50 },
                    { "34a37889-0b43-4081-8027-553f3e43e8d0", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6120), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6170), "3764424e-06dc-45cd-bfa9-3c0f1d371d0e", "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 50 },
                    { "3a730ccd-c010-4982-9045-ecc774557ef1", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5440), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5480), "d68052ce-00bb-42b4-aaef-1da972126682", "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 50 },
                    { "3b0cbdb8-e4f8-4014-83a6-f1b037629550", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6220), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6260), "6f2274b6-6b2c-4919-9ebb-b382d11fde52", "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 100 },
                    { "4be45eff-bbe8-4728-b965-346f71b4e230", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6420), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6460), "d549f3fb-9dd9-4d8e-a313-88cd5421ae6e", "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 100 },
                    { "569fe598-9085-4e5b-8068-f2e55d27b26a", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6020), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6070), "3764424e-06dc-45cd-bfa9-3c0f1d371d0e", "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 100 },
                    { "5d47669d-da69-4bb5-925b-8dac5d33d8bc", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6320), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(6360), "6f2274b6-6b2c-4919-9ebb-b382d11fde52", "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 50 },
                    { "7cec59d8-9f34-4758-ba44-609dc527f8ec", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5850), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5890), "dd557a07-9f9f-4b68-9fe8-926eb3acf5e9", "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 50 },
                    { "8275c9b7-3463-4e66-8675-48c1d38ec43d", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5330), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5380), "d68052ce-00bb-42b4-aaef-1da972126682", "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 100 },
                    { "86b3fbef-dacb-4561-9524-db4c0b43de93", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4880), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4920), "7f44039c-9b26-4645-9f50-47035c0453b0", "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 50 },
                    { "bb166fd3-dc91-4628-9f2f-c8f145467b70", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5740), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5780), "dd557a07-9f9f-4b68-9fe8-926eb3acf5e9", "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 100 },
                    { "c7b31773-65fa-452e-8bd2-2f7b495f9061", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4770), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4810), "7f44039c-9b26-4645-9f50-47035c0453b0", "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 100 },
                    { "d0b8fa9f-84aa-4130-a123-af289407f140", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5640), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5680), "8e4653b4-f6e2-4ed4-81c3-b24c96766218", "9f29468c-7b23-4131-9c7b-ffd2e1aa2ff2", 50 },
                    { "f23f2040-6470-47d0-8260-57403f0bf4dd", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(4980), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(5030), "7471af51-6ad0-4597-abb9-acf774aef794", "33d4fe6f-3deb-4032-95d5-240cdb1629a7", 100 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "9ac20f7c-e47e-45bc-8032-fa80cd987789", new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(7060), new DateTime(2024, 4, 7, 21, 28, 29, 339, DateTimeKind.Unspecified).AddTicks(7110), "7f44039c-9b26-4645-9f50-47035c0453b0", null, "a867a594-da11-48c5-9590-7a33f801026b", 1 });
        }
    }
}
