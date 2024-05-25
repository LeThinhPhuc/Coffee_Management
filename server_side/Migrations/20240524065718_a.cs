using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "1f5f38d8-1680-4332-bf78-883e3b426ab5");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "28d951ba-a537-482f-a2fc-23b0b3678db5");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "35b45f79-1f35-455d-93a8-8b15519358f6");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "39417d80-5ff0-4410-b9d5-385a645441a8");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "527cabc2-e55c-4ec1-acf2-f548c62683eb");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "67bd08de-fb17-4c3b-98a9-256338a6730e");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "6ad71501-c34b-49ef-88ff-5be139c3af60");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "7b863f04-8d43-41fa-9798-b39e6edeeb29");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "803bd7f5-82fc-4326-9023-f10746669b16");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "a5bf043a-2877-488e-954f-df2376dae50d");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "a97ca28e-e799-42c0-8cd7-946899953ec3");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "ba76c90f-b984-4c19-aa0f-27bbe5be58b8");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "c0685c05-7a37-4420-b411-21b556214b74");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "e687c65f-5d51-4020-ba91-eeedc9b433f1");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "efde9a9e-f3f2-48ea-bd90-0f780cf6e4b6");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "f3cf9313-5c4c-4de8-9d22-f748dfb86a94");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "8dcaa3f9-a45f-49f9-a518-8fb5e7bbbfae");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "2984a77e-6407-4001-ae09-3e3dab5688c1" });

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "723b63e7-a54e-4d2a-a745-fbadb2f3ee20");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "7a283038-c765-4466-9bd6-abf09e98ca2a");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "91175f63-fba5-4dfb-8a1b-c1cf8e998497");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "cd270217-2581-4a36-8d32-758d93fecb8d");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "d6d7ded9-ab0f-4f13-b8a6-68d9eb21fe76");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "e953f68d-260b-4d17-a20a-99433cfd09e5");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "f4ca04da-cc5f-4273-a3ab-658f6f5c15fd");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "f5cad867-a483-435e-87cb-4438ea5ee11e");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "1db1b124-0267-45cf-a78e-b36b09d64a83");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "f47e0e15-06b4-4047-8f99-eb7c0b111d7b");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "63f58b54-5732-4227-aca4-55b280d4c387");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "40ba98c6-5709-401b-8516-479d6770b50e");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "5ff31551-27d5-4427-9b19-f5f4e5e7cd16");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "9de738ce-e713-4d7f-88a5-20413edb0031");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "b8654d09-decf-488d-8905-b370ab19645c");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "4c22c10a-9561-4449-a0e5-e3c9ac6197f4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2984a77e-6407-4001-ae09-3e3dab5688c1");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Image", "Name" },
                values: new object[,]
                {
                    { "60d11f02-4aa0-4059-a362-2646dc5121d7", 10.0, new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(561), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(563), new DateTime(2024, 7, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(564), "", "Sugar" },
                    { "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 5.0, new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(551), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(552), new DateTime(2024, 6, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(554), "", "Milk" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "fc5629bf-561b-4ec2-af6a-c61044846980");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8bd29ab4-ee89-40b0-b03e-1d4fb204822d", 0, "745cbc38-5ddf-46ae-924f-5219349ffa3e", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEOD5BZyViUu9EbrrOjYucMRQymbw83sjqFElWzITJ1BmQ+X7JSyB5TSCugwxyWbdZQ==", null, false, "4b41efd5-976e-4487-9fa9-822e70cdd8b6", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "7e374c8a-290e-4908-9f0f-9a781e28f407", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(758), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(754), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "8bd29ab4-ee89-40b0-b03e-1d4fb204822d" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsApproved", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[] { "0aa74225-2ecb-4228-acac-639514e79942", "123 Main St", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(360), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(383), true, false, "Coffee House", "8bd29ab4-ee89-40b0-b03e-1d4fb204822d", 0.0, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8bd29ab4-ee89-40b0-b03e-1d4fb204822d" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "19c5ceee-2b51-4558-b1cd-0a8da5b4974c", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(422), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(420), "Juice", "0aa74225-2ecb-4228-acac-639514e79942" },
                    { "26643d20-a570-4445-a740-30dbd63db95c", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(413), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(410), "Smoothie", "0aa74225-2ecb-4228-acac-639514e79942" },
                    { "943e89dd-4536-4eb1-bfd6-64c2673c3b44", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(406), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(403), "Tea", "0aa74225-2ecb-4228-acac-639514e79942" },
                    { "b5666e76-3aeb-4233-8bd0-57d8c94a1f98", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(396), "Coffee", "0aa74225-2ecb-4228-acac-639514e79942" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "0d5a41c5-3b9e-4a02-910b-f557047bbbfd", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(516), "19c5ceee-2b51-4558-b1cd-0a8da5b4974c", null, "Orange Juice", 24000.0 },
                    { "1708608c-3f55-4ac1-bfee-da15e0df3e6f", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(505), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(502), "26643d20-a570-4445-a740-30dbd63db95c", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "58d70492-d9dd-4f16-89f0-11e233bbada6", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(509), "26643d20-a570-4445-a740-30dbd63db95c", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "5ebfa2e2-f36e-446b-891e-a9b096209709", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(525), "19c5ceee-2b51-4558-b1cd-0a8da5b4974c", null, "Apple Juice", 24000.0 },
                    { "6642448b-5b38-4118-876d-abf11ffaad4f", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(439), "b5666e76-3aeb-4233-8bd0-57d8c94a1f98", null, "Latte", 28000.0 },
                    { "6bcf7a66-7c11-4d74-878a-4822ee48653c", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(486), "943e89dd-4536-4eb1-bfd6-64c2673c3b44", null, "Earl Grey", 25000.0 },
                    { "78d3d15c-bcfe-4dc6-ad01-fee604f707f1", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(498), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(495), "943e89dd-4536-4eb1-bfd6-64c2673c3b44", null, "Green Tea", 22000.0 },
                    { "b1f51f4f-e9d5-4229-a424-a9e6f4a1dbbc", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(447), "b5666e76-3aeb-4233-8bd0-57d8c94a1f98", null, "Cappuccino", 28000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "1a192b6b-cc0a-43c5-9f13-f34f740b1be7", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(594), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(595), "6642448b-5b38-4118-876d-abf11ffaad4f", "60d11f02-4aa0-4059-a362-2646dc5121d7", 5 },
                    { "2ac0b68c-d4ac-4386-902d-6bc892332f43", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(641), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(670), "1708608c-3f55-4ac1-bfee-da15e0df3e6f", "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 10 },
                    { "374e2a6d-280b-4d3c-84a3-a20bdf6b024b", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(698), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(699), "0d5a41c5-3b9e-4a02-910b-f557047bbbfd", "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 10 },
                    { "4760813c-aecd-4c66-96d8-06545f5b61c8", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(628), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(630), "78d3d15c-bcfe-4dc6-ad01-fee604f707f1", "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 10 },
                    { "484175fc-cbb4-4f6e-b8dc-5fca9243a6ca", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(634), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(636), "78d3d15c-bcfe-4dc6-ad01-fee604f707f1", "60d11f02-4aa0-4059-a362-2646dc5121d7", 5 },
                    { "4d7f5400-58a9-46ce-97b4-02d6008359c4", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(691), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(693), "58d70492-d9dd-4f16-89f0-11e233bbada6", "60d11f02-4aa0-4059-a362-2646dc5121d7", 5 },
                    { "4e2a49ec-3801-4ece-862c-adf12af289d6", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(614), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(615), "6bcf7a66-7c11-4d74-878a-4822ee48653c", "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 10 },
                    { "5335f977-d603-435a-9aa0-8b5e753ae116", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(712), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(714), "5ebfa2e2-f36e-446b-891e-a9b096209709", "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 10 },
                    { "55587ed8-4287-4629-89e7-5586af1ab721", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(685), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(687), "58d70492-d9dd-4f16-89f0-11e233bbada6", "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 10 },
                    { "65bdefba-c566-4ff7-8448-7f4ecb426e0d", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(584), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(586), "6642448b-5b38-4118-876d-abf11ffaad4f", "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 10 },
                    { "7b3c70db-d0c2-4bff-a21d-b2994aabacd3", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(719), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(720), "5ebfa2e2-f36e-446b-891e-a9b096209709", "60d11f02-4aa0-4059-a362-2646dc5121d7", 5 },
                    { "a7e14299-d73b-4554-8259-929d56c6f113", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(622), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(623), "6bcf7a66-7c11-4d74-878a-4822ee48653c", "60d11f02-4aa0-4059-a362-2646dc5121d7", 5 },
                    { "a9440b2f-ac77-4585-8087-5d73a55ea9b5", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(607), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(608), "b1f51f4f-e9d5-4229-a424-a9e6f4a1dbbc", "60d11f02-4aa0-4059-a362-2646dc5121d7", 5 },
                    { "bd5c336d-6725-4cd2-b10c-5aae5275b8d9", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(706), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(707), "0d5a41c5-3b9e-4a02-910b-f557047bbbfd", "60d11f02-4aa0-4059-a362-2646dc5121d7", 5 },
                    { "dfa2339a-4ff0-44f2-82b6-96872267ad61", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(678), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(680), "1708608c-3f55-4ac1-bfee-da15e0df3e6f", "60d11f02-4aa0-4059-a362-2646dc5121d7", 5 },
                    { "e5d7ba7a-9554-4f49-8c38-7b15dc828b98", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(600), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(602), "b1f51f4f-e9d5-4229-a424-a9e6f4a1dbbc", "daa36d1f-b6fa-4630-b37a-3301ca7bffd7", 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "7c73aff1-9a45-45e1-9582-409892b3faf9", new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(776), new DateTime(2024, 5, 24, 13, 57, 17, 968, DateTimeKind.Unspecified).AddTicks(778), "6642448b-5b38-4118-876d-abf11ffaad4f", null, "7e374c8a-290e-4908-9f0f-9a781e28f407", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "1a192b6b-cc0a-43c5-9f13-f34f740b1be7");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "2ac0b68c-d4ac-4386-902d-6bc892332f43");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "374e2a6d-280b-4d3c-84a3-a20bdf6b024b");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "4760813c-aecd-4c66-96d8-06545f5b61c8");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "484175fc-cbb4-4f6e-b8dc-5fca9243a6ca");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "4d7f5400-58a9-46ce-97b4-02d6008359c4");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "4e2a49ec-3801-4ece-862c-adf12af289d6");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "5335f977-d603-435a-9aa0-8b5e753ae116");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "55587ed8-4287-4629-89e7-5586af1ab721");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "65bdefba-c566-4ff7-8448-7f4ecb426e0d");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "7b3c70db-d0c2-4bff-a21d-b2994aabacd3");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "a7e14299-d73b-4554-8259-929d56c6f113");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "a9440b2f-ac77-4585-8087-5d73a55ea9b5");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "bd5c336d-6725-4cd2-b10c-5aae5275b8d9");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "dfa2339a-4ff0-44f2-82b6-96872267ad61");

            migrationBuilder.DeleteData(
                table: "IngredientsInDrinks",
                keyColumn: "Id",
                keyValue: "e5d7ba7a-9554-4f49-8c38-7b15dc828b98");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: "7c73aff1-9a45-45e1-9582-409892b3faf9");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8bd29ab4-ee89-40b0-b03e-1d4fb204822d" });

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "0d5a41c5-3b9e-4a02-910b-f557047bbbfd");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "1708608c-3f55-4ac1-bfee-da15e0df3e6f");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "58d70492-d9dd-4f16-89f0-11e233bbada6");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "5ebfa2e2-f36e-446b-891e-a9b096209709");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "6642448b-5b38-4118-876d-abf11ffaad4f");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "6bcf7a66-7c11-4d74-878a-4822ee48653c");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "78d3d15c-bcfe-4dc6-ad01-fee604f707f1");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: "b1f51f4f-e9d5-4229-a424-a9e6f4a1dbbc");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "60d11f02-4aa0-4059-a362-2646dc5121d7");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: "daa36d1f-b6fa-4630-b37a-3301ca7bffd7");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: "7e374c8a-290e-4908-9f0f-9a781e28f407");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "19c5ceee-2b51-4558-b1cd-0a8da5b4974c");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "26643d20-a570-4445-a740-30dbd63db95c");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "943e89dd-4536-4eb1-bfd6-64c2673c3b44");

            migrationBuilder.DeleteData(
                table: "DrinkTypes",
                keyColumn: "Id",
                keyValue: "b5666e76-3aeb-4233-8bd0-57d8c94a1f98");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "0aa74225-2ecb-4228-acac-639514e79942");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8bd29ab4-ee89-40b0-b03e-1d4fb204822d");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Image", "Name" },
                values: new object[,]
                {
                    { "1db1b124-0267-45cf-a78e-b36b09d64a83", 10.0, new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1757), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1759), new DateTime(2024, 7, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1760), "", "Sugar" },
                    { "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 5.0, new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1744), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1746), new DateTime(2024, 6, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1747), "", "Milk" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "6365a643-25dd-4a4c-ad1e-452f3d832eb8");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2984a77e-6407-4001-ae09-3e3dab5688c1", 0, "640600af-1a2e-4ecb-bac6-1b18deddb99e", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEBXG5ih5CNy9slIj1aEuYn4+mxC6VqqBuI0LmSqxfoOfns4ergXY0eMyxsskTGQenw==", null, false, "a55d7bb5-d3c2-4ab3-9df3-3acff0add478", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "63f58b54-5732-4227-aca4-55b280d4c387", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(2020), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(2013), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "2984a77e-6407-4001-ae09-3e3dab5688c1" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsApproved", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[] { "4c22c10a-9561-4449-a0e5-e3c9ac6197f4", "123 Main St", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1482), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1502), true, false, "Coffee House", "2984a77e-6407-4001-ae09-3e3dab5688c1", 0.0, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "2984a77e-6407-4001-ae09-3e3dab5688c1" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "40ba98c6-5709-401b-8516-479d6770b50e", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1540), "Smoothie", "4c22c10a-9561-4449-a0e5-e3c9ac6197f4" },
                    { "5ff31551-27d5-4427-9b19-f5f4e5e7cd16", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1534), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1531), "Tea", "4c22c10a-9561-4449-a0e5-e3c9ac6197f4" },
                    { "9de738ce-e713-4d7f-88a5-20413edb0031", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1523), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1519), "Coffee", "4c22c10a-9561-4449-a0e5-e3c9ac6197f4" },
                    { "b8654d09-decf-488d-8905-b370ab19645c", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1606), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1601), "Juice", "4c22c10a-9561-4449-a0e5-e3c9ac6197f4" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "723b63e7-a54e-4d2a-a745-fbadb2f3ee20", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1675), "40ba98c6-5709-401b-8516-479d6770b50e", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "7a283038-c765-4466-9bd6-abf09e98ca2a", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1697), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1693), "b8654d09-decf-488d-8905-b370ab19645c", null, "Orange Juice", 24000.0 },
                    { "91175f63-fba5-4dfb-8a1b-c1cf8e998497", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1639), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1633), "9de738ce-e713-4d7f-88a5-20413edb0031", null, "Latte", 28000.0 },
                    { "cd270217-2581-4a36-8d32-758d93fecb8d", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1657), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1653), "5ff31551-27d5-4427-9b19-f5f4e5e7cd16", null, "Earl Grey", 25000.0 },
                    { "d6d7ded9-ab0f-4f13-b8a6-68d9eb21fe76", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1687), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1684), "40ba98c6-5709-401b-8516-479d6770b50e", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "e953f68d-260b-4d17-a20a-99433cfd09e5", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1648), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1644), "9de738ce-e713-4d7f-88a5-20413edb0031", null, "Cappuccino", 28000.0 },
                    { "f4ca04da-cc5f-4273-a3ab-658f6f5c15fd", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1666), "5ff31551-27d5-4427-9b19-f5f4e5e7cd16", null, "Green Tea", 22000.0 },
                    { "f5cad867-a483-435e-87cb-4438ea5ee11e", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Local).AddTicks(1709), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1706), "b8654d09-decf-488d-8905-b370ab19645c", null, "Apple Juice", 24000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "1f5f38d8-1680-4332-bf78-883e3b426ab5", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1828), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1830), "cd270217-2581-4a36-8d32-758d93fecb8d", "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 10 },
                    { "28d951ba-a537-482f-a2fc-23b0b3678db5", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1809), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1811), "e953f68d-260b-4d17-a20a-99433cfd09e5", "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 10 },
                    { "35b45f79-1f35-455d-93a8-8b15519358f6", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1928), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1930), "d6d7ded9-ab0f-4f13-b8a6-68d9eb21fe76", "1db1b124-0267-45cf-a78e-b36b09d64a83", 5 },
                    { "39417d80-5ff0-4410-b9d5-385a645441a8", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1965), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1967), "f5cad867-a483-435e-87cb-4438ea5ee11e", "1db1b124-0267-45cf-a78e-b36b09d64a83", 5 },
                    { "527cabc2-e55c-4ec1-acf2-f548c62683eb", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1891), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1893), "f4ca04da-cc5f-4273-a3ab-658f6f5c15fd", "1db1b124-0267-45cf-a78e-b36b09d64a83", 5 },
                    { "67bd08de-fb17-4c3b-98a9-256338a6730e", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1911), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1913), "723b63e7-a54e-4d2a-a745-fbadb2f3ee20", "1db1b124-0267-45cf-a78e-b36b09d64a83", 5 },
                    { "6ad71501-c34b-49ef-88ff-5be139c3af60", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1787), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1790), "91175f63-fba5-4dfb-8a1b-c1cf8e998497", "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 10 },
                    { "7b863f04-8d43-41fa-9798-b39e6edeeb29", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1919), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1921), "d6d7ded9-ab0f-4f13-b8a6-68d9eb21fe76", "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 10 },
                    { "803bd7f5-82fc-4326-9023-f10746669b16", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1900), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1901), "723b63e7-a54e-4d2a-a745-fbadb2f3ee20", "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 10 },
                    { "a5bf043a-2877-488e-954f-df2376dae50d", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1800), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1802), "91175f63-fba5-4dfb-8a1b-c1cf8e998497", "1db1b124-0267-45cf-a78e-b36b09d64a83", 5 },
                    { "a97ca28e-e799-42c0-8cd7-946899953ec3", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1882), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1884), "f4ca04da-cc5f-4273-a3ab-658f6f5c15fd", "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 10 },
                    { "ba76c90f-b984-4c19-aa0f-27bbe5be58b8", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1947), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1949), "7a283038-c765-4466-9bd6-abf09e98ca2a", "1db1b124-0267-45cf-a78e-b36b09d64a83", 5 },
                    { "c0685c05-7a37-4420-b411-21b556214b74", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1872), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1875), "cd270217-2581-4a36-8d32-758d93fecb8d", "1db1b124-0267-45cf-a78e-b36b09d64a83", 5 },
                    { "e687c65f-5d51-4020-ba91-eeedc9b433f1", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1956), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1958), "f5cad867-a483-435e-87cb-4438ea5ee11e", "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 10 },
                    { "efde9a9e-f3f2-48ea-bd90-0f780cf6e4b6", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1818), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1820), "e953f68d-260b-4d17-a20a-99433cfd09e5", "1db1b124-0267-45cf-a78e-b36b09d64a83", 5 },
                    { "f3cf9313-5c4c-4de8-9d22-f748dfb86a94", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1936), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(1938), "7a283038-c765-4466-9bd6-abf09e98ca2a", "f47e0e15-06b4-4047-8f99-eb7c0b111d7b", 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "8dcaa3f9-a45f-49f9-a518-8fb5e7bbbfae", new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(2046), new DateTime(2024, 5, 21, 14, 17, 0, 770, DateTimeKind.Unspecified).AddTicks(2048), "91175f63-fba5-4dfb-8a1b-c1cf8e998497", null, "63f58b54-5732-4227-aca4-55b280d4c387", 1 });
        }
    }
}
