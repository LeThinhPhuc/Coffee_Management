using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class UpdateUserNormalizedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
