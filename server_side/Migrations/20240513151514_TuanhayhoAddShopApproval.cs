using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class TuanhayhoAddShopApproval : Migration
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
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
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
                    { "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 5.0, new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8220), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8310), new DateTime(2024, 6, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(8330), "", "Milk" },
                    { "89e9a228-bf56-4489-992c-f8a17bd9fab8", 10.0, new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8370), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8410), new DateTime(2024, 7, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(8410), "", "Sugar" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "16a827cd-e00e-4ebd-8733-ae166efb8ae8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "31ee1d5d-c262-4c09-9b5d-fe09e316d8ee", 0, "48dff044-51b2-47fc-b13e-fed582f4691c", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEBPfl92zP/i/rkWwVRTZAUHrckl7/RiLvKgsvHtCN5DsoTNSpjx03jmDEjAUsyZAXw==", null, false, "ed10e1f7-879e-47da-aebb-9dddb4801920", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "d617983e-1562-47c0-86a1-a75c7554a554", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9870), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "31ee1d5d-c262-4c09-9b5d-fe09e316d8ee" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsApproved", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[,]
                {
                    { "5052eaaf-9635-4345-9281-181a8ed460dc", "456 Elm St", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(6350), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(6400), false, false, "Tea Shop", "31ee1d5d-c262-4c09-9b5d-fe09e316d8ee", 0.0, null },
                    { "90011592-4548-42e0-829a-8d2d43031f85", "123 Main St", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(6220), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(6310), true, false, "Coffee House", "31ee1d5d-c262-4c09-9b5d-fe09e316d8ee", 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "31ee1d5d-c262-4c09-9b5d-fe09e316d8ee" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "06269547-cc6a-4b19-8287-d9cad5198552", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(6830), "Smoothie", "90011592-4548-42e0-829a-8d2d43031f85" },
                    { "6f0185c1-5bbc-4767-98cc-5531a9f77ed0", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(6640), "Coffee", "90011592-4548-42e0-829a-8d2d43031f85" },
                    { "74d06fbe-938a-4c5f-abb5-8f712c05c84d", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(6920), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(6910), "Juice", "90011592-4548-42e0-829a-8d2d43031f85" },
                    { "a4abfcdd-ca97-40bc-841b-d00f194f6d93", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(6730), "Tea", "90011592-4548-42e0-829a-8d2d43031f85" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "0706fcb3-ef4b-4e0d-bd51-c5cdfc4d8551", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(7820), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(7810), "06269547-cc6a-4b19-8287-d9cad5198552", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "0d8af8ac-6eca-4291-b109-9bada864fffb", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8050), "74d06fbe-938a-4c5f-abb5-8f712c05c84d", null, "Apple Juice", 24000.0 },
                    { "1ccb63ae-ad62-4d79-a36a-4b61f079474d", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(7880), "06269547-cc6a-4b19-8287-d9cad5198552", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "31194bc3-10ab-40d1-be22-100969a5f78c", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(7650), "a4abfcdd-ca97-40bc-841b-d00f194f6d93", null, "Earl Grey", 25000.0 },
                    { "35d0d54a-108d-4513-9fa8-ffceb5250bca", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(7040), "6f0185c1-5bbc-4767-98cc-5531a9f77ed0", null, "Latte", 28000.0 },
                    { "73bcbd3f-342f-4a06-9923-fafb7058f5af", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(7720), "a4abfcdd-ca97-40bc-841b-d00f194f6d93", null, "Green Tea", 22000.0 },
                    { "9498e774-532c-48c5-8073-ebaf0f33d8aa", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(7990), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(7980), "74d06fbe-938a-4c5f-abb5-8f712c05c84d", null, "Orange Juice", 24000.0 },
                    { "e5b8a1b3-8642-4e89-ad36-eebf60fcafdb", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(7140), "6f0185c1-5bbc-4767-98cc-5531a9f77ed0", null, "Cappuccino", 28000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "1d521b95-0d0f-4228-a38e-3188312bd0c4", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9570), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9600), "0d8af8ac-6eca-4291-b109-9bada864fffb", "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 10 },
                    { "240c19e8-93c4-4cc2-a467-2eb4d5e13e8b", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9510), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9530), "9498e774-532c-48c5-8073-ebaf0f33d8aa", "89e9a228-bf56-4489-992c-f8a17bd9fab8", 5 },
                    { "2b86a770-6e79-43e0-8b7b-e6c85bf6ae71", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8690), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8780), "e5b8a1b3-8642-4e89-ad36-eebf60fcafdb", "89e9a228-bf56-4489-992c-f8a17bd9fab8", 5 },
                    { "36f28b51-ce88-4576-8830-d0dd8f8b8df1", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8560), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8590), "35d0d54a-108d-4513-9fa8-ffceb5250bca", "89e9a228-bf56-4489-992c-f8a17bd9fab8", 5 },
                    { "454e8ec2-9cd5-45f3-9090-ccc3ba83f3a9", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9300), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9330), "1ccb63ae-ad62-4d79-a36a-4b61f079474d", "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 10 },
                    { "5d4f2595-16d9-4bb0-a96c-1adef29d600b", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9110), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9140), "0706fcb3-ef4b-4e0d-bd51-c5cdfc4d8551", "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 10 },
                    { "6ecf0b42-59c4-4ca6-a079-9558e22da916", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8490), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8520), "35d0d54a-108d-4513-9fa8-ffceb5250bca", "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 10 },
                    { "73675e4a-1827-4231-bc8f-a25b36d080cb", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9040), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9070), "73bcbd3f-342f-4a06-9923-fafb7058f5af", "89e9a228-bf56-4489-992c-f8a17bd9fab8", 5 },
                    { "7628a76e-445e-428b-9c79-dede03eaad21", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8910), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8940), "31194bc3-10ab-40d1-be22-100969a5f78c", "89e9a228-bf56-4489-992c-f8a17bd9fab8", 5 },
                    { "829a7cff-9c6e-4689-afe6-17fe45140d9e", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8840), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8870), "31194bc3-10ab-40d1-be22-100969a5f78c", "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 10 },
                    { "969faeec-9228-49a7-b7e1-ed4bf7a277bc", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9170), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9260), "0706fcb3-ef4b-4e0d-bd51-c5cdfc4d8551", "89e9a228-bf56-4489-992c-f8a17bd9fab8", 5 },
                    { "b47243c8-fdf7-4ca3-8cf9-01d43378e562", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8970), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9000), "73bcbd3f-342f-4a06-9923-fafb7058f5af", "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 10 },
                    { "d37690aa-9657-47e2-ae23-bf1dd95941c8", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9640), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9720), "0d8af8ac-6eca-4291-b109-9bada864fffb", "89e9a228-bf56-4489-992c-f8a17bd9fab8", 5 },
                    { "f61ec0e6-21ee-4398-914d-4803e98e16dd", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8630), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(8650), "e5b8a1b3-8642-4e89-ad36-eebf60fcafdb", "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 10 },
                    { "f94a4d0b-c306-42f6-b910-2bad0dd1a23f", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9440), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9470), "9498e774-532c-48c5-8073-ebaf0f33d8aa", "2db8e3f6-c75f-40c9-96cf-217255b44cd2", 10 },
                    { "fb589fb3-a6c2-435a-bd60-c3ad3e87a30c", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9370), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9390), "1ccb63ae-ad62-4d79-a36a-4b61f079474d", "89e9a228-bf56-4489-992c-f8a17bd9fab8", 5 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "8059e902-dc25-4fdc-ad43-42509a4f9ec7", new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9940), new DateTime(2024, 5, 13, 22, 15, 13, 248, DateTimeKind.Unspecified).AddTicks(9970), "35d0d54a-108d-4513-9fa8-ffceb5250bca", null, "d617983e-1562-47c0-86a1-a75c7554a554", 1 });

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
