namespace CoffeeShopApi.Models.DAL
{
    using Models.DomainModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // must have this line first, else you will end up getting the error (The entity type 'IdentityUserLogin<string>' requires a primary key to be defined. If you intended to use a keyless entity type, call 'HasNoKey' in 'OnModelCreating')
            base.OnModelCreating(modelBuilder);

            // Configure relationships and other constraints
            modelBuilder.Entity<Drink>()
                .HasOne(d => d.DrinkType)
                .WithMany(dt => dt.Drinks)
                .HasForeignKey(d => d.DrinkTypeId);

            modelBuilder.Entity<DrinkType>()
                .HasOne(dt => dt.Shop)
                .WithMany(s => s.DrinkTypes)
                .HasForeignKey(dt => dt.ShopId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Drink)
                .WithMany()
                .HasForeignKey(oi => oi.DrinkId);

            modelBuilder.Entity<Shop>()
                .HasOne(s => s.Owner)
                .WithMany()
                .HasForeignKey(s => s.OwnerId);

            modelBuilder.Entity<VoucherCode>()
                .HasOne(vc => vc.Shop)
                .WithMany(s => s.VoucherCodes)
                .HasForeignKey(vc => vc.ShopId);


            /* To resolve error: Introducing FOREIGN KEY constraint 'FK_Orders_Users_UserId' on table 'Orders' may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
                Could not create constraint or index. See previous errors.
            */
            // Configure the relationship between Orders and Users with cascade delete behavior
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict); // You can specify DeleteBehavior.Restrict or DeleteBehavior.SetNull



            /* To resolve error: Introducing FOREIGN KEY constraint 'FK_Shops_Users_OwnerId' on table 'Shops' may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
Could not create constraint or index. See previous errors.
            */
            // Configure the relationship between Shops and Users with cascade delete behavior
            modelBuilder.Entity<Shop>()
                .HasOne(s => s.Owner)
                .WithMany(u => u.Shops)
                .HasForeignKey(s => s.OwnerId)
                .OnDelete(DeleteBehavior.Restrict); // You can specify DeleteBehavior.Restrict or DeleteBehavior.SetNull


            #region remove "AspNet" postfix:
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6)); 
                }
            }
            #endregion


            #region seeding data
            /*  IMPORTANT NOTES: When seeding data into a database with foreign key 
            *   constraints, it's important to ensure that tables containing the
            *   referenced entities (primary keys) are seeded first before the tables
            *   containing the referencing entities (foreign keys). This ensures that
            *   the referenced entities exist in the database before they are
            *   referenced by other entities. Otherwise, you may encounter foreign key constraint violations.
            */
            
            // Seed users
            var adminUserId = Guid.NewGuid().ToString();
            var password = "admin";
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            var hashedPassword = passwordHasher.HashPassword(null, password);
            // without NormalizedUserName field, Identity's UserManager won't be abble to find that user
            var adminUser = new ApplicationUser { Id = adminUserId, UserName = "admin", NormalizedUserName = "ADMIN", FullName = "Admin", PasswordHash = hashedPassword };

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            // Removed due to errors affecting other models
            // Seed the "Admin" role
            // Achtung: the AspNetRole's Name column is required to be unique !!!
            // var adminRoleId = Guid.NewGuid().ToString();
            var adminRoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210";
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN".ToUpper()
            });

            // Assign the "Admin" role to the admin user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = adminUserId,
                RoleId = adminRoleId
            });

            // Seed Shops
            var shopId1 = Guid.NewGuid().ToString();
            // var shopId2 = Guid.NewGuid().ToString();

            modelBuilder.Entity<Shop>().HasData(
                new Shop { Id = shopId1, Name = "Coffee House", IsApproved = true, OwnerId = adminUserId, Address = "123 Main St", Revenue = 0 }
                // new Shop { Id = shopId2, Name = "Tea Shop", IsApproved = true, OwnerId = adminUserId, Address = "456 Elm St", Revenue = 0 }
            );

            // Seed DrinkTypes
            var drinkTypes = new[]
            {
                new DrinkType { Id = Guid.NewGuid().ToString(), Name = "Coffee", ShopId = shopId1, DateCreated = DateTime.Now },
                new DrinkType { Id = Guid.NewGuid().ToString(), Name = "Tea", ShopId = shopId1, DateCreated = DateTime.Now },
                new DrinkType { Id = Guid.NewGuid().ToString(), Name = "Smoothie", ShopId = shopId1, DateCreated = DateTime.Now },
                new DrinkType { Id = Guid.NewGuid().ToString(), Name = "Juice", ShopId = shopId1, DateCreated = DateTime.Now }
            };

            modelBuilder.Entity<DrinkType>().HasData(drinkTypes);

            var drinks = new[]
            {
                new Drink { Id=Guid.NewGuid().ToString(),Name = "Latte", Price = 28000, DrinkTypeId = drinkTypes[0].Id, DateCreated=DateTime.Now },
                new Drink { Id=Guid.NewGuid().ToString(),Name = "Cappuccino", Price = 28000, DrinkTypeId = drinkTypes[0].Id, DateCreated=DateTime.Now },
                new Drink { Id=Guid.NewGuid().ToString(),Name = "Earl Grey", Price = 25000, DrinkTypeId = drinkTypes[1].Id, DateCreated=DateTime.Now },
                new Drink { Id=Guid.NewGuid().ToString(),Name = "Green Tea", Price = 22000, DrinkTypeId = drinkTypes[1].Id, DateCreated=DateTime.Now },
                new Drink { Id=Guid.NewGuid().ToString(),Name = "Strawberry Banana Smoothie", Price = 28000, DrinkTypeId = drinkTypes[2].Id, DateCreated=DateTime.Now },
                new Drink { Id=Guid.NewGuid().ToString(),Name = "Mango Pineapple Smoothie", Price = 23000, DrinkTypeId = drinkTypes[2].Id, DateCreated=DateTime.Now },
                new Drink { Id=Guid.NewGuid().ToString(),Name = "Orange Juice", Price = 24000, DrinkTypeId = drinkTypes[3].Id, DateCreated=DateTime.Now },
                new Drink { Id=Guid.NewGuid().ToString(),Name = "Apple Juice", Price = 24000, DrinkTypeId = drinkTypes[3].Id, DateCreated=DateTime.Now }
            };
            modelBuilder.Entity<Drink>().HasData(drinks);


            // Seed Ingredients
            var ingredient1Id = Guid.NewGuid().ToString();
            var ingredient2Id = Guid.NewGuid().ToString();

            var ingredients = new[]
            {
                new Ingredient { Id = ingredient1Id, Name = "Milk", Amount = 5, ExpiryDate = DateTime.Now.AddMonths(1), Image = "" },
                new Ingredient { Id = ingredient2Id, Name = "Sugar", Amount = 10, ExpiryDate = DateTime.Now.AddMonths(2), Image = "" }
            };
            modelBuilder.Entity<Ingredient>().HasData(ingredients);


            // Seed IngredientsInDrinks
            var ingredientsInDrinks = new[]
            {
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[0].Id, IngredientId = ingredient1Id, Quantity = 10 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[0].Id, IngredientId = ingredient2Id, Quantity = 5 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[1].Id, IngredientId = ingredient1Id, Quantity = 10 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[1].Id, IngredientId = ingredient2Id, Quantity = 5 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[2].Id, IngredientId = ingredient1Id, Quantity = 10 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[2].Id, IngredientId = ingredient2Id, Quantity = 5 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[3].Id, IngredientId = ingredient1Id, Quantity = 10 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[3].Id, IngredientId = ingredient2Id, Quantity = 5 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[4].Id, IngredientId = ingredient1Id, Quantity = 10 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[4].Id, IngredientId = ingredient2Id, Quantity = 5 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[5].Id, IngredientId = ingredient1Id, Quantity = 10 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[5].Id, IngredientId = ingredient2Id, Quantity = 5 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[6].Id, IngredientId = ingredient1Id, Quantity = 10 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[6].Id, IngredientId = ingredient2Id, Quantity = 5 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[7].Id, IngredientId = ingredient1Id, Quantity = 10 },
                new IngredientInDrink { Id = Guid.NewGuid().ToString(), DrinkId = drinks[7].Id, IngredientId = ingredient2Id, Quantity = 5 }
            };

            modelBuilder.Entity<IngredientInDrink>().HasData(ingredientsInDrinks);

            // Seed Orders (err: The seed entity for entity type 'Order' cannot be added because it has the navigation 'User' set. To seed relationships,  add the entity seed to 'Order' and specify the foreign key values {'UserId'}. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the involved property values.  ;   The seed entity for entity type 'Order' cannot be added because it has the navigation 'OrderItems' set. To seed relationships,  add the entity seed to 'OrderItem' and specify the foreign key values {'OrderId'}. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the involved property values.)
            // var orderId = Guid.NewGuid().ToString();
            // var orderItemId = Guid.NewGuid().ToString();
            // var orders = new[]
            // {
            //     new Order
            //     { 
            //         Id = orderId,
            //         UserId = adminUserId, 
            //         OrderDate = new DateTime(2023, 5, 4),
            //         DateCreated = DateTime.Now,
            //         Total = 28000, 
            //         User = adminUser, 
            //         OrderItems = new List<OrderItem>
            //         {
            //             new OrderItem { Id = orderItemId, DrinkId = drinks[0].Id, Quantity = 1, OrderId = orderId }
            //         },
            //     }, 
            // };

            // modelBuilder.Entity<Order>().HasData(orders);

            // Seed Orders (fixed)
            var orderId = Guid.NewGuid().ToString();
            modelBuilder.Entity<Order>().HasData(
                new Order
                { 
                    Id = orderId,
                    UserId = adminUser.Id,  // Reference to the previously seeded user
                    OrderDate = new DateTime(2023, 5, 4),
                    DateCreated = DateTime.Now,
                    Total = 28000
                }
            );

            // Seed OrderItems
            var orderItemId = Guid.NewGuid().ToString();
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { Id = orderItemId, OrderId = orderId, DrinkId = drinks[0].Id, Quantity = 1 }
            );

            
            #endregion

        }

        // Users , it can be ApplicationUser in your project!
        public DbSet<ApplicationUser> Users { get; set; } // "ApplicationUsers" will be the name of SQL table
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<DrinkType> DrinkTypes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientInDrink> IngredientsInDrinks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<VoucherCode> VoucherCodes { get; set; }

    }
}