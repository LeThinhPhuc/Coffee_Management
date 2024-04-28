using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class TuanhayhoFixRole : Migration
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
                    { "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 10.0, new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5870), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5890), new DateTime(2024, 6, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5900), "", "Sugar" },
                    { "55cafebe-f085-4b1a-ab9b-c6f128878995", 5.0, new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5800), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5820), new DateTime(2024, 5, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5830), "", "Milk" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "9597e3c2-469c-4ccc-8e0f-28e34a4a65c6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2aff88c-1d4a-430b-bdc5-cb6358616a4e", 0, "499443ad-dee7-44ce-9fdf-1df83585376a", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEFnNv4aZ6tUmyKW6pR1ophkULzlo3b79QE+v2cm+m8thxyZ7IuOKhPfKlqPWCwdyeQ==", null, false, "852e101c-1547-478f-95b5-675f9c993482", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "39d93e5f-1227-454b-8153-22b412232f95", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(9450), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "f2aff88c-1d4a-430b-bdc5-cb6358616a4e" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[,]
                {
                    { "5563d293-21c4-4118-925c-346da5f58e7c", "456 Elm St", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(4530), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(4560), false, "Tea Shop", "f2aff88c-1d4a-430b-bdc5-cb6358616a4e", 0.0, null },
                    { "5e8bfdd2-bd5d-4cec-9054-931f7715302d", "123 Main St", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(4430), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(4490), false, "Coffee House", "f2aff88c-1d4a-430b-bdc5-cb6358616a4e", 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "f2aff88c-1d4a-430b-bdc5-cb6358616a4e" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "0d47c0fd-780a-48aa-99f2-2353d581de16", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5010), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5000), "Juice", "5e8bfdd2-bd5d-4cec-9054-931f7715302d" },
                    { "2a14dae5-beb6-4dbb-a2ff-6153d00c1dbe", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(4800), "Coffee", "5e8bfdd2-bd5d-4cec-9054-931f7715302d" },
                    { "62849ab7-3235-4ffa-a925-e604c059e268", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(4940), "Smoothie", "5e8bfdd2-bd5d-4cec-9054-931f7715302d" },
                    { "e8e184b6-2bec-4403-af60-2765f1232147", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(4870), "Tea", "5e8bfdd2-bd5d-4cec-9054-931f7715302d" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "1de30657-b449-4692-84e1-98db384d0a85", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5320), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5310), "e8e184b6-2bec-4403-af60-2765f1232147", null, "Earl Grey", 25000.0 },
                    { "201321c2-97e4-4bde-8d6f-1d100758976c", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5560), "0d47c0fd-780a-48aa-99f2-2353d581de16", null, "Orange Juice", 24000.0 },
                    { "2136ad35-e89f-46f7-ab1f-dbedb7e50753", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5370), "e8e184b6-2bec-4403-af60-2765f1232147", null, "Green Tea", 22000.0 },
                    { "249c15b0-74f7-4f61-abe0-cf74cc1fb489", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5620), "0d47c0fd-780a-48aa-99f2-2353d581de16", null, "Apple Juice", 24000.0 },
                    { "908d84ef-bec5-487b-804d-f19609bf3a2f", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5190), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5180), "2a14dae5-beb6-4dbb-a2ff-6153d00c1dbe", null, "Cappuccino", 28000.0 },
                    { "a111e3b6-53ef-451a-943d-cf1174359aa0", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5440), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5430), "62849ab7-3235-4ffa-a925-e604c059e268", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "ab26a783-deb7-4f60-a62c-aa11d5988b65", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5500), "62849ab7-3235-4ffa-a925-e604c059e268", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "fd068936-4f57-43a2-a012-42d580fd9fbf", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Local).AddTicks(5120), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5100), "2a14dae5-beb6-4dbb-a2ff-6153d00c1dbe", null, "Latte", 28000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "00a971f0-c192-40d7-a58b-684e318cf963", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6150), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6230), "908d84ef-bec5-487b-804d-f19609bf3a2f", "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 5 },
                    { "102c408f-22c6-43cc-b7ca-e0f6d096fa16", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6400), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6420), "2136ad35-e89f-46f7-ab1f-dbedb7e50753", "55cafebe-f085-4b1a-ab9b-c6f128878995", 10 },
                    { "315a527e-7b81-42aa-a42a-d76edb1aff3a", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6830), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6860), "201321c2-97e4-4bde-8d6f-1d100758976c", "55cafebe-f085-4b1a-ab9b-c6f128878995", 10 },
                    { "388ae7ce-05b1-4b82-879e-fcab2b0201a0", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6270), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6300), "1de30657-b449-4692-84e1-98db384d0a85", "55cafebe-f085-4b1a-ab9b-c6f128878995", 10 },
                    { "3ffbf627-1750-4f9a-a46e-cfcb9e3c9544", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6460), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6490), "2136ad35-e89f-46f7-ab1f-dbedb7e50753", "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 5 },
                    { "54a8a601-7f14-4951-94c4-b33a3c7a1e97", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6030), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6060), "fd068936-4f57-43a2-a012-42d580fd9fbf", "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 5 },
                    { "570319a9-46b8-4f04-9dba-8a0c20ae0aac", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6770), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6800), "ab26a783-deb7-4f60-a62c-aa11d5988b65", "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 5 },
                    { "69bb416b-e0af-4847-90ae-e63ee3fe9012", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(8830), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(9060), "249c15b0-74f7-4f61-abe0-cf74cc1fb489", "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 5 },
                    { "6b0b4cff-908b-4972-a7c1-d33c22865fe8", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5970), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(5990), "fd068936-4f57-43a2-a012-42d580fd9fbf", "55cafebe-f085-4b1a-ab9b-c6f128878995", 10 },
                    { "835eb2ef-d73b-49bf-be3d-af9ddd25817c", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6710), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6740), "ab26a783-deb7-4f60-a62c-aa11d5988b65", "55cafebe-f085-4b1a-ab9b-c6f128878995", 10 },
                    { "ac867217-2cd1-4342-83f1-ec971b246b2c", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6090), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6120), "908d84ef-bec5-487b-804d-f19609bf3a2f", "55cafebe-f085-4b1a-ab9b-c6f128878995", 10 },
                    { "c29497c3-acbb-419c-ad99-48abadac8998", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6530), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6550), "a111e3b6-53ef-451a-943d-cf1174359aa0", "55cafebe-f085-4b1a-ab9b-c6f128878995", 10 },
                    { "d25b3e11-85cf-4979-932b-7590d2b2ee7f", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6340), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6360), "1de30657-b449-4692-84e1-98db384d0a85", "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 5 },
                    { "d3875873-d7bd-4958-8261-3553b0274622", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6890), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6920), "201321c2-97e4-4bde-8d6f-1d100758976c", "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 5 },
                    { "de503d88-a0b9-4af2-bdc0-57dcbbfe8b74", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6590), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6670), "a111e3b6-53ef-451a-943d-cf1174359aa0", "1f70f06b-4d7e-49c3-89c5-6bb8c6bd4d5d", 5 },
                    { "e6355527-0e74-424b-a892-f56c10bcb191", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6950), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(6980), "249c15b0-74f7-4f61-abe0-cf74cc1fb489", "55cafebe-f085-4b1a-ab9b-c6f128878995", 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "c130bb72-0884-4ddd-ab1c-3e0f8a500bab", new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(9530), new DateTime(2024, 4, 28, 23, 6, 1, 396, DateTimeKind.Unspecified).AddTicks(9570), "fd068936-4f57-43a2-a012-42d580fd9fbf", null, "39d93e5f-1227-454b-8153-22b412232f95", 1 });

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
