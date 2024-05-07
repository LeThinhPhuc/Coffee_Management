using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopApi.Migrations
{
    public partial class @new : Migration
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
                    { "7a414db0-93e9-4e40-a51c-cd9493dc4830", 10.0, new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6153), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6154), new DateTime(2024, 7, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6156), "", "Sugar" },
                    { "c46c32b0-63ce-42ea-b737-d629fc566b63", 5.0, new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6141), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6143), new DateTime(2024, 6, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6145), "", "Milk" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "b23fa1f9-d1fa-4474-ac59-5eef9b3f7152", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "55ee42d7-b7c7-41ff-8bf7-7448a40466f2", 0, "95c76216-c982-443f-ae3a-8e8798d86d92", "ApplicationUser", null, false, "Admin", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAELmq8439pIZ7eOA3dKHqOrBXqoBmMt5JcrZq+imMhuMUjELKx8iLoH+CvyNFwCBF9Q==", null, false, "0ebbb68e-a0e9-4bd6-8126-492eb6d98f95", false, "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateModified", "Note", "OrderDate", "Total", "UserId" },
                values: new object[] { "551ed154-424a-4cf1-8f2c-006814dcc381", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6344), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6340), null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000.0, "55ee42d7-b7c7-41ff-8bf7-7448a40466f2" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "DateCreated", "DateModified", "IsSuspended", "Name", "OwnerId", "Revenue", "SuspensionEndDate" },
                values: new object[,]
                {
                    { "63393bdf-0c07-4f5c-a60a-65e4a11c4c66", "456 Elm St", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(5981), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(5983), false, "Tea Shop", "55ee42d7-b7c7-41ff-8bf7-7448a40466f2", 0.0, null },
                    { "e2cd7e75-e7cb-40f2-b903-1185dcfe22f7", "123 Main St", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(5956), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(5976), false, "Coffee House", "55ee42d7-b7c7-41ff-8bf7-7448a40466f2", 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "55ee42d7-b7c7-41ff-8bf7-7448a40466f2" });

            migrationBuilder.InsertData(
                table: "DrinkTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ShopId" },
                values: new object[,]
                {
                    { "38fdb72a-43ea-464d-905d-6a598061f603", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(5996), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(5993), "Coffee", "e2cd7e75-e7cb-40f2-b903-1185dcfe22f7" },
                    { "58855cff-6922-4886-a320-9828f6b66208", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6010), "Smoothie", "e2cd7e75-e7cb-40f2-b903-1185dcfe22f7" },
                    { "593294d0-6021-463e-9668-69898ed385da", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6003), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6001), "Tea", "e2cd7e75-e7cb-40f2-b903-1185dcfe22f7" },
                    { "70138d14-6270-43b9-98c7-43e3c61f077b", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6018), "Juice", "e2cd7e75-e7cb-40f2-b903-1185dcfe22f7" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkTypeId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { "0281cbc4-941f-448e-b660-a741414ff429", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6067), "58855cff-6922-4886-a320-9828f6b66208", null, "Strawberry Banana Smoothie", 28000.0 },
                    { "4c894d42-783f-4c44-8b1a-d3be1a6a40a6", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6047), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6045), "38fdb72a-43ea-464d-905d-6a598061f603", null, "Cappuccino", 28000.0 },
                    { "779c8445-1a16-43e2-9a77-f84755b65a02", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6056), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6054), "593294d0-6021-463e-9668-69898ed385da", null, "Earl Grey", 25000.0 },
                    { "7f53f77c-c97f-4a9c-a095-807f8e2aac14", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6074), "58855cff-6922-4886-a320-9828f6b66208", null, "Mango Pineapple Smoothie", 23000.0 },
                    { "8c5ecde6-1877-47cb-a61f-fe868214606f", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6063), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6061), "593294d0-6021-463e-9668-69898ed385da", null, "Green Tea", 22000.0 },
                    { "984b8815-ad88-43e0-904b-29f15bdeb774", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6040), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6037), "38fdb72a-43ea-464d-905d-6a598061f603", null, "Latte", 28000.0 },
                    { "dee11acc-ee30-46e3-93b2-06ec594d6b14", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6089), "70138d14-6270-43b9-98c7-43e3c61f077b", null, "Apple Juice", 24000.0 },
                    { "e591acbf-b311-4a1d-bb17-f577c64a3b89", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6082), "70138d14-6270-43b9-98c7-43e3c61f077b", null, "Orange Juice", 24000.0 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInDrinks",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { "014a627f-a610-4cc3-82da-a9ced1eb680b", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6225), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6227), "8c5ecde6-1877-47cb-a61f-fe868214606f", "7a414db0-93e9-4e40-a51c-cd9493dc4830", 5 },
                    { "0551d1c0-f9d9-4c49-9633-c453ad56c93e", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6252), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6254), "7f53f77c-c97f-4a9c-a095-807f8e2aac14", "7a414db0-93e9-4e40-a51c-cd9493dc4830", 5 },
                    { "164f761b-46d2-4632-a594-65472b1469a2", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6192), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6193), "4c894d42-783f-4c44-8b1a-d3be1a6a40a6", "c46c32b0-63ce-42ea-b737-d629fc566b63", 10 },
                    { "345148bf-3996-4cc8-b248-9ad7b792cbca", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6303), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6304), "dee11acc-ee30-46e3-93b2-06ec594d6b14", "7a414db0-93e9-4e40-a51c-cd9493dc4830", 5 },
                    { "4ac67381-2466-43bb-8bdd-948291ab3f20", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6186), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6187), "984b8815-ad88-43e0-904b-29f15bdeb774", "7a414db0-93e9-4e40-a51c-cd9493dc4830", 5 },
                    { "695fe120-5c5c-469e-b733-1ccbd53dda46", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6198), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6200), "4c894d42-783f-4c44-8b1a-d3be1a6a40a6", "7a414db0-93e9-4e40-a51c-cd9493dc4830", 5 },
                    { "7244acc3-b577-4705-a7e7-801176672f25", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6207), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6208), "779c8445-1a16-43e2-9a77-f84755b65a02", "c46c32b0-63ce-42ea-b737-d629fc566b63", 10 },
                    { "75f5d154-d7ce-4835-b514-0cacab2f7d31", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6274), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6275), "dee11acc-ee30-46e3-93b2-06ec594d6b14", "c46c32b0-63ce-42ea-b737-d629fc566b63", 10 },
                    { "796b4835-5c8c-437d-8750-2f8b1a01c392", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6178), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6180), "984b8815-ad88-43e0-904b-29f15bdeb774", "c46c32b0-63ce-42ea-b737-d629fc566b63", 10 },
                    { "7e288963-cfe6-4b61-8e84-5b132d00f581", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6213), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6214), "779c8445-1a16-43e2-9a77-f84755b65a02", "7a414db0-93e9-4e40-a51c-cd9493dc4830", 5 },
                    { "8658d800-7400-4830-a7f4-a77e62c10f1a", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6233), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6235), "0281cbc4-941f-448e-b660-a741414ff429", "c46c32b0-63ce-42ea-b737-d629fc566b63", 10 },
                    { "8cb3daa9-fce3-4ad2-a0a2-2491a4a6dc4b", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6267), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6269), "e591acbf-b311-4a1d-bb17-f577c64a3b89", "7a414db0-93e9-4e40-a51c-cd9493dc4830", 5 },
                    { "ac6826f2-6bf0-42d3-b14b-4c73ff7c5f8b", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6246), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6247), "7f53f77c-c97f-4a9c-a095-807f8e2aac14", "c46c32b0-63ce-42ea-b737-d629fc566b63", 10 },
                    { "b58ceb8f-5c57-4c7b-ae3d-06432bf47a69", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6219), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6220), "8c5ecde6-1877-47cb-a61f-fe868214606f", "c46c32b0-63ce-42ea-b737-d629fc566b63", 10 },
                    { "bb0869c4-6d2c-4565-a215-146d31ac9ddc", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6261), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6262), "e591acbf-b311-4a1d-bb17-f577c64a3b89", "c46c32b0-63ce-42ea-b737-d629fc566b63", 10 },
                    { "e3a63441-d7c2-4ca7-867e-1fa3013dbf5f", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6239), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6241), "0281cbc4-941f-448e-b660-a741414ff429", "7a414db0-93e9-4e40-a51c-cd9493dc4830", 5 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateModified", "DrinkId", "Note", "OrderId", "Quantity" },
                values: new object[] { "f6d9825f-bee4-4f52-98c2-cf332531d777", new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6360), new DateTime(2024, 5, 6, 21, 36, 48, 589, DateTimeKind.Unspecified).AddTicks(6362), "984b8815-ad88-43e0-904b-29f15bdeb774", null, "551ed154-424a-4cf1-8f2c-006814dcc381", 1 });

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
