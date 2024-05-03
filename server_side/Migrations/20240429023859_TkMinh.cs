using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class TkMinh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsSuspended = table.Column<bool>(type: "bit", nullable: false),
                    SuspensionEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Revenue = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shops_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrinkTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrinkTypes_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoucherCodes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPercent = table.Column<double>(type: "float", nullable: true),
                    ShopId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoucherCodes_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrinkTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drinks_DrinkTypes_DrinkTypeId",
                        column: x => x.DrinkTypeId,
                        principalTable: "DrinkTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientsInDrinks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DrinkId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IngredientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientsInDrinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientsInDrinks_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientsInDrinks_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DrinkId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ExpiryDate", "Image", "Name" },
                values: new object[,]
                {
                    { "6975e741-37ba-4222-909d-7dab7f82e088", 5.0, new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(192), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(194), new DateTime(2024, 5, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(196), "", "Milk" },
                    { "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 10.0, new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(218), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(220), new DateTime(2024, 6, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(222), "", "Sugar" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "113165ab-1c91-4e70-8d98-8a468ce10623", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ef964b0c-1b97-4e08-9513-b06e7827488a", 0, "bdf92479-65f4-4879-a6e1-dde4e2e5c845", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEO8oulJ6EZKdOjcNa9Fcq9lcfsuhv6SrHKyfnNBjSaigiPhHru7M+wTUh4Dbyz/TDQ==", null, false, "b35d32fe-90e2-4a69-add8-8005f19518a0", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "edc80560-0e89-4778-9067-700c6c9f5cb1", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(684), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "ef964b0c-1b97-4e08-9513-b06e7827488a" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[,]
                {
                    { "4fa75925-a8ee-4609-baa3-607486c6ba9b", "456 Elm St", new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Unspecified).AddTicks(9943), new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Unspecified).AddTicks(9946), false, "Tea Shop", "ef964b0c-1b97-4e08-9513-b06e7827488a", 0.0, null },
                    { "e38c802f-3e35-4aa6-bd64-a4124aab7adb", "123 Main St", new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Unspecified).AddTicks(9749), new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Unspecified).AddTicks(9932), false, "Coffee House", "ef964b0c-1b97-4e08-9513-b06e7827488a", 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "ef964b0c-1b97-4e08-9513-b06e7827488a" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "0554971e-8551-4513-882c-a1d0358c95d2", new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Local).AddTicks(9997), new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Unspecified).AddTicks(9992), "Smoothie", "e38c802f-3e35-4aa6-bd64-a4124aab7adb" },
                    { "40593b35-0e4b-484c-a244-ab9ec8f3a417", new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Local).AddTicks(9968), new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Unspecified).AddTicks(9963), "Coffee", "e38c802f-3e35-4aa6-bd64-a4124aab7adb" },
                    { "966e64a9-e0ed-4cf7-9eeb-614c1f57c796", new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 4, 29, 9, 38, 59, 337, DateTimeKind.Unspecified).AddTicks(9976), "Tea", "e38c802f-3e35-4aa6-bd64-a4124aab7adb" },
                    { "ad526dde-4339-4d9a-a314-7391dc03705e", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(9), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(4), "Juice", "e38c802f-3e35-4aa6-bd64-a4124aab7adb" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "2e1021a8-b534-4467-a259-49acea096002", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(56), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(50), "40593b35-0e4b-484c-a244-ab9ec8f3a417", null, "Latte", 28000.0 },
                    { "2fc68e1d-cffa-4d8e-9675-9c7de5ac445d", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(140), "ad526dde-4339-4d9a-a314-7391dc03705e", null, "Apple Juice", 24000.0 },
                    { "58fc73d5-7056-4ba2-b53e-698d771e2b18", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(78), "966e64a9-e0ed-4cf7-9eeb-614c1f57c796", null, "Earl Grey", 25000.0 },
                    { "7454cec2-e905-4201-b3a1-49f304956060", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(90), "966e64a9-e0ed-4cf7-9eeb-614c1f57c796", null, "Green Tea", 22000.0 },
                    { "b45c2f32-40ee-4972-b724-226003d361ca", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(105), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(101), "0554971e-8551-4513-882c-a1d0358c95d2", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "d98ce735-ec08-4f1d-9317-ba3e507e9536", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(128), "ad526dde-4339-4d9a-a314-7391dc03705e", null, "Orange Juice", 24000.0 },
                    { "e366f1e6-3804-474e-a503-c68109185484", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(63), "40593b35-0e4b-484c-a244-ab9ec8f3a417", null, "Cappuccino", 28000.0 },
                    { "fb7de551-86f9-4465-932f-d7e49875e5f7", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Local).AddTicks(121), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(113), "0554971e-8551-4513-882c-a1d0358c95d2", null, "Mango Pineapple Smoothie", 23000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "2c36b8aa-76a8-4af1-85c8-915841b1cfb4", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(495), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(497), "58fc73d5-7056-4ba2-b53e-698d771e2b18", "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 5 },
                    { "52d09a6e-5631-4828-bd7c-93a00c4a0e42", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(553), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(555), "fb7de551-86f9-4465-932f-d7e49875e5f7", "6975e741-37ba-4222-909d-7dab7f82e088", 10 },
                    { "54e46fc9-1e59-44d2-8f41-e919db121578", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(578), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(580), "d98ce735-ec08-4f1d-9317-ba3e507e9536", "6975e741-37ba-4222-909d-7dab7f82e088", 10 },
                    { "6722792f-500e-41f8-8b14-aed8c7e9ed9b", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(529), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(532), "b45c2f32-40ee-4972-b724-226003d361ca", "6975e741-37ba-4222-909d-7dab7f82e088", 10 },
                    { "80685ebc-e3da-4d0c-94d5-9d802f6b3e53", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(564), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(566), "fb7de551-86f9-4465-932f-d7e49875e5f7", "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 5 },
                    { "89747f92-a767-428f-bf8b-fe529b5fe9fb", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(588), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(590), "d98ce735-ec08-4f1d-9317-ba3e507e9536", "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 5 },
                    { "971e7273-5296-43c4-a0a9-9b0b879b9826", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(506), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(508), "7454cec2-e905-4201-b3a1-49f304956060", "6975e741-37ba-4222-909d-7dab7f82e088", 10 },
                    { "9a658b07-36eb-4576-8bfe-dde007cd5879", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(259), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(435), "2e1021a8-b534-4467-a259-49acea096002", "6975e741-37ba-4222-909d-7dab7f82e088", 10 },
                    { "a9c007f2-8aba-482e-8f8e-0457db52e34c", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(483), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(486), "58fc73d5-7056-4ba2-b53e-698d771e2b18", "6975e741-37ba-4222-909d-7dab7f82e088", 10 },
                    { "ab4b464d-5b9d-4aaa-84dd-8a1f3d3604ec", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(459), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(461), "e366f1e6-3804-474e-a503-c68109185484", "6975e741-37ba-4222-909d-7dab7f82e088", 10 },
                    { "b84e1afe-fc35-4da3-9e33-7a03a3deea24", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(447), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(449), "2e1021a8-b534-4467-a259-49acea096002", "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 5 },
                    { "cbba0cbd-09e7-49a5-9241-e9f45119312c", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(615), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(617), "2fc68e1d-cffa-4d8e-9675-9c7de5ac445d", "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 5 },
                    { "d157f39c-dc94-4a66-9ed8-fa6dbcaea65e", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(516), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(518), "7454cec2-e905-4201-b3a1-49f304956060", "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 5 },
                    { "d2dcb15d-8d93-441d-afb5-e67ea6c95da2", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(541), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(543), "b45c2f32-40ee-4972-b724-226003d361ca", "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 5 },
                    { "d44c6e0c-eeeb-4c81-8a98-5842ed8ac21b", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(604), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(606), "2fc68e1d-cffa-4d8e-9675-9c7de5ac445d", "6975e741-37ba-4222-909d-7dab7f82e088", 10 },
                    { "d967d34b-044a-4562-953b-394db82cf77d", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(470), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(472), "e366f1e6-3804-474e-a503-c68109185484", "edbf880d-c597-46e2-9f66-a8d2bbcb6e28", 5 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "9c8731ea-289d-41fc-9127-8653745f53e0", new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(783), new DateTime(2024, 4, 29, 9, 38, 59, 338, DateTimeKind.Unspecified).AddTicks(786), "2e1021a8-b534-4467-a259-49acea096002", null, "edc80560-0e89-4778-9067-700c6c9f5cb1", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_DrinkTypeId",
                table: "Drinks",
                column: "DrinkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkTypes_ShopId",
                table: "DrinkTypes",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsInDrinks_DrinkId",
                table: "IngredientsInDrinks",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsInDrinks_IngredientId",
                table: "IngredientsInDrinks",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DrinkId",
                table: "OrderItems",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_OwnerId",
                table: "Shops",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherCodes_ShopId",
                table: "VoucherCodes",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientsInDrinks");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "VoucherCodes");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "DrinkTypes");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
