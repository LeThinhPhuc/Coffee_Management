namespace CoffeeShopApi.Models.DAL
{
    using System.Runtime.Intrinsics.X86;
    using CoffeeShopApi.Models.DomainModels;
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