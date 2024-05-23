using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class lethinhphuc : Migration
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
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    ShopId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        principalColumn: "Id");
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
                    ShopId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        principalColumn: "Id");
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
                    DrinkId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IngredientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IngredientsInDrinks_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
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
                    { "21cae515-4279-4efc-bab5-7e3f18a6acf4", 5.0, new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4056), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4057), new DateTime(2024, 6, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(4059), "", "Milk" },
                    { "23c5b606-17a1-4716-b13a-8c66c63d1932", 10.0, new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4067), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4068), new DateTime(2024, 7, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(4069), "", "Sugar" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "839ee058-7896-4821-ba42-9340d10c1995", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "08c20115-9d1a-4441-91c4-62bdb440a1b0", 0, "1a320ada-595a-4beb-8e91-46e0ee5a5b97", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAELW8xyUQPGVquXfC8EhlieTPCzeLR+U+rsIu/IR13qX0bV5FHpCHW62ZeeEvGYaufg==", null, false, "86e57052-7bd7-4c37-b9dd-7b8df1aa479c", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "69008730-df49-4a99-b8e0-dd1cf5b9b559", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4466), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "08c20115-9d1a-4441-91c4-62bdb440a1b0" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsApproved", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[] { "ea4a38cb-96d3-47bd-a1b2-72b8ae5dc28f", "123 Main St", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3834), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3864), true, false, "Coffee House", "08c20115-9d1a-4441-91c4-62bdb440a1b0", 0.0, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "08c20115-9d1a-4441-91c4-62bdb440a1b0" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "27d8d448-8230-4d80-890f-de44ca4601d7", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3899), "Smoothie", "ea4a38cb-96d3-47bd-a1b2-72b8ae5dc28f" },
                    { "4422078a-7da0-442b-9c85-9a16f97bbbab", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3894), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3891), "Tea", "ea4a38cb-96d3-47bd-a1b2-72b8ae5dc28f" },
                    { "ebdaee8e-2484-4d6f-a285-bee03ec18ea3", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3909), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3906), "Juice", "ea4a38cb-96d3-47bd-a1b2-72b8ae5dc28f" },
                    { "fed3ecb4-6715-4700-b423-7c4f2c418ab1", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3882), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3879), "Coffee", "ea4a38cb-96d3-47bd-a1b2-72b8ae5dc28f" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "3d6fbfb1-7a8d-48d8-b6a7-0b5df835329a", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3931), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3927), "fed3ecb4-6715-4700-b423-7c4f2c418ab1", null, "Latte", 28000.0 },
                    { "3df8bbf3-2e23-4f9f-a02a-98d0d60564b2", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3969), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3965), "4422078a-7da0-442b-9c85-9a16f97bbbab", null, "Green Tea", 22000.0 },
                    { "5533014c-6779-4c73-b6f5-6eeeabeeba2c", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4013), "ebdaee8e-2484-4d6f-a285-bee03ec18ea3", null, "Apple Juice", 24000.0 },
                    { "5e142c15-e5fa-4cc0-9795-793163c8f8ab", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3994), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3990), "27d8d448-8230-4d80-890f-de44ca4601d7", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "5e8e1e33-21c5-400d-87c0-3fcf241d37c8", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3958), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3954), "4422078a-7da0-442b-9c85-9a16f97bbbab", null, "Earl Grey", 25000.0 },
                    { "e30e30f9-b75d-43ab-98d1-565faf2914c2", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3947), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3942), "fed3ecb4-6715-4700-b423-7c4f2c418ab1", null, "Cappuccino", 28000.0 },
                    { "f6f8a9df-b090-484c-a357-9260fc5cba6d", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4001), "ebdaee8e-2484-4d6f-a285-bee03ec18ea3", null, "Orange Juice", 24000.0 },
                    { "f7203135-9efa-43b4-a29d-cb9dd76046d9", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Local).AddTicks(3979), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(3975), "27d8d448-8230-4d80-890f-de44ca4601d7", null, "Strawberry Banana Smoothie", 28000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "0d8704cf-8922-407e-b2d4-10cb2555cc0f", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4238), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4240), "f7203135-9efa-43b4-a29d-cb9dd76046d9", "23c5b606-17a1-4716-b13a-8c66c63d1932", 5 },
                    { "159bdeaa-c527-425e-9e0e-ac5a1addd412", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4290), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4294), "f6f8a9df-b090-484c-a357-9260fc5cba6d", "23c5b606-17a1-4716-b13a-8c66c63d1932", 5 },
                    { "2717ecc0-0880-4570-8945-3e5262a67c4b", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4192), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4195), "5e8e1e33-21c5-400d-87c0-3fcf241d37c8", "23c5b606-17a1-4716-b13a-8c66c63d1932", 5 },
                    { "2f2b5bdb-f6a3-4041-a9a5-654488c48630", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4248), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4251), "5e142c15-e5fa-4cc0-9795-793163c8f8ab", "21cae515-4279-4efc-bab5-7e3f18a6acf4", 10 },
                    { "31208040-db51-42ca-a5ea-224237e16fbd", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4326), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4329), "5533014c-6779-4c73-b6f5-6eeeabeeba2c", "23c5b606-17a1-4716-b13a-8c66c63d1932", 5 },
                    { "5c51fcfb-834a-4574-85e7-d6878aa87e7f", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4202), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4205), "3df8bbf3-2e23-4f9f-a02a-98d0d60564b2", "21cae515-4279-4efc-bab5-7e3f18a6acf4", 10 },
                    { "6069bb32-6b63-484e-8283-b944d7efe851", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4281), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4284), "f6f8a9df-b090-484c-a357-9260fc5cba6d", "21cae515-4279-4efc-bab5-7e3f18a6acf4", 10 },
                    { "638c15ba-1cc4-421d-9231-fe900339ace4", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4271), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4274), "5e142c15-e5fa-4cc0-9795-793163c8f8ab", "23c5b606-17a1-4716-b13a-8c66c63d1932", 5 },
                    { "67fc9e83-34a4-40e6-a9ec-ae8cbe1d6877", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4145), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4148), "3d6fbfb1-7a8d-48d8-b6a7-0b5df835329a", "23c5b606-17a1-4716-b13a-8c66c63d1932", 5 },
                    { "6c508d21-a777-404c-8c04-10a2b74c6f35", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4156), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4159), "e30e30f9-b75d-43ab-98d1-565faf2914c2", "21cae515-4279-4efc-bab5-7e3f18a6acf4", 10 },
                    { "851aefa2-dd55-4d2b-b5b8-9272c9442b23", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4181), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4184), "5e8e1e33-21c5-400d-87c0-3fcf241d37c8", "21cae515-4279-4efc-bab5-7e3f18a6acf4", 10 },
                    { "93a483d4-fe3c-4473-9f5f-7f4dc8d797c5", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4170), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4173), "e30e30f9-b75d-43ab-98d1-565faf2914c2", "23c5b606-17a1-4716-b13a-8c66c63d1932", 5 },
                    { "a03cebf8-f002-485b-a95a-038b3bef7c6a", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4301), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4307), "5533014c-6779-4c73-b6f5-6eeeabeeba2c", "21cae515-4279-4efc-bab5-7e3f18a6acf4", 10 },
                    { "ae0f61ae-d9c0-4fc4-935f-79430c58887d", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4133), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4136), "3d6fbfb1-7a8d-48d8-b6a7-0b5df835329a", "21cae515-4279-4efc-bab5-7e3f18a6acf4", 10 },
                    { "dd9e1099-5ae6-4c87-9082-0f0723afc29e", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4226), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4229), "f7203135-9efa-43b4-a29d-cb9dd76046d9", "21cae515-4279-4efc-bab5-7e3f18a6acf4", 10 },
                    { "facc3c7c-0a90-49f2-adab-f3a3e34ce9ed", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4216), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4219), "3df8bbf3-2e23-4f9f-a02a-98d0d60564b2", "23c5b606-17a1-4716-b13a-8c66c63d1932", 5 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "04fb0c36-f0c9-4c29-8bf5-a40b29cada53", new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4516), new DateTime(2024, 5, 22, 8, 44, 17, 418, DateTimeKind.Unspecified).AddTicks(4518), "3d6fbfb1-7a8d-48d8-b6a7-0b5df835329a", null, "69008730-df49-4a99-b8e0-dd1cf5b9b559", 1 });

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
