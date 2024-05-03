namespace CoffeeShopApi.Services.Implements
{
    using Models.DTOs;
    using Exceptions;
    using Repositories.Interfaces;
    using Services.Interfaces;
    using Models.DomainModels;
    using CoffeeShopApi.Models.DAL;
    using Microsoft.EntityFrameworkCore;

    public class ShopService : IShopService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _dbContext;

        public ShopService(AppDbContext dbContext,
            IUnitOfWork unitOfWork
        )
        {
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
            // _memoryCache = memoryCache;
        }

        public List<Shop> GetAllShops()
        {
            return _dbContext.Shops
                .OrderByDescending(d => d.DateModified)
                .ToList();
        }

        public async Task<List<ShopViewModel>> GetAllShopsClientAsync()
        {
            // This approach allow "null propagating operator"
            var shops = await Task.FromResult(_dbContext.Shops.Include(s => s.Owner).AsEnumerable());

            var listShopsViewModel = shops.Select(d => new ShopViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Address = d.Address,
                OwnerId = d.OwnerId,
                IsSuspended = d.IsSuspended,
                FormattedSuspensionEndDate = d.SuspensionEndDate?.ToString("dddd, dd/MM/yyyy - HH:mm"),
                FormattedDateCreated = d.DateCreated.ToString("dddd, dd/MM/yyyy - HH:mm"),
                FormattedDateModified = d.DateModified.ToString("dddd, dd/MM/yyyy - HH:mm"),
                Revenue = d.Revenue,
                OwnerFullName = d.Owner.FullName
            }).ToList();

            // LinQ expression approach
            // ERR: "An expression tree lambda may not contain a null propagating operator."
            // at line   "d.SuspensionEndDate?.ToString("dddd, dd/MM/yyyy - HH:mm")"
            // var shops = await _dbContext.Shops
            //         .Include(s => s.Owner)
            //         .Select(d => new ShopViewModel
            //         {
            //             Id = d.Id,
            //             Name = d.Name,
            //             Address = d.Address,
            //             OwnerId = d.OwnerId,
            //             IsSuspended = d.IsSuspended,
            //             FormattedSuspensionEndDate = d.SuspensionEndDate.HasValue ? d.SuspensionEndDate?.ToString("dddd, dd/MM/yyyy - HH:mm") : null,
            //             FormattedDateCreated = d.DateCreated.ToString("dddd, dd/MM/yyyy - HH:mm"),
            //             FormattedDateModified = d.DateModified.ToString("dddd, dd/MM/yyyy - HH:mm"),
            //             Revenue = d.Revenue,
            //             OwnerFullName = d.Owner.FullName
            //         })
            //         .ToListAsync();
            return listShopsViewModel;
        }

        // public List<Drink> GetDrinksByType(string typeName)
        // {
        //     var drinks = _dbContext.Drinks
        //         .Where(d => d.DrinkType.Name == typeName)
        //         .ToList();
        //     return drinks;
        // }

        // public async Task<List<DrinkViewModel>> GetDrinksByTypeNameAsync(string typeName)
        // {
        //     var drinks = await _dbContext.Drinks
        //     .Include(d => d.DrinkType)
        //     .Where(d => d.DrinkType.Name == typeName)
        //     .Select(d => new DrinkViewModel
        //     {
        //         Id = d.Id,
        //         Name = d.Name,
        //         Price = d.Price,
        //         ImagePath = d.ImagePath,
        //         DrinkTypeId = d.DrinkTypeId,
        //         DrinkTypeName = d.DrinkType.Name,
        //     })
        //     .ToListAsync();

        //     return drinks;
        // }

        // public async Task<List<object>> GetMenuDataAsync()
        // {
        //     var menuData = await _dbContext.Drinks
        //         .Include(d => d.DrinkType)
        //         .Include(d => d.Ingredients)
        //             .ThenInclude(di => di.Ingredient)
        //         .GroupBy(d => d.DrinkType.Name)
        //         .Select(group => new
        //         {
        //             Category = group.Key,
        //             Items = group.Select(d => new
        //             {
        //                 Id = d.Id,
        //                 Image = d.ImagePath,
        //                 Name = d.Name,
        //                 // Price = $"{d.Price}VNĐ",
        //                 Price = d.Price,
        //                 DrinkTypeId = d.DrinkTypeId,
        //                 Ingredients = d.Ingredients
        //                     .Select(di => new
        //                     {
        //                         IngredientName = di.Ingredient.Name,
        //                         Quantity = di.Quantity
        //                     }).ToList()
        //             }).ToList()
        //         })
        //         .ToListAsync();

        //     return menuData.Cast<object>().ToList();
        // }

        public async Task<Shop> GetShopByIdAsync(string id)
        {
            return await _dbContext.Shops.FindAsync(id);
        }

        // public async Task<Drink> AddDrinkAsync(CreateUpdateDrinkModel model)
        // {
        //     var drink = new Drink
        //     {
        //         Name = model.Name,
        //         Price = model.Price,
        //         ImagePath = model.ImagePath,
        //         DrinkTypeId = model.DrinkTypeId
        //     };

        //     // Add the Drink entity to the database
        //     _dbContext.Drinks.Add(drink);
        //     await _dbContext.SaveChangesAsync();

        //     // Add the ingredients to the Drink
        //     if (model.Ingredients != null && model.Ingredients.Any())
        //     {
        //         foreach (var ingredient in model.Ingredients)
        //         {
        //             var ingredientInDrink = new IngredientInDrink
        //             {
        //                 DrinkId = drink.Id,
        //                 IngredientId = ingredient.IngredientId,
        //                 Quantity = ingredient.Quantity
        //             };
        //             _dbContext.IngredientsInDrinks.Add(ingredientInDrink);
        //         }
        //         await _dbContext.SaveChangesAsync();
        //     }

        //     return drink;
        // }

        // public async Task<Drink> UpdateDrinkAsync(CreateUpdateDrinkModel model)
        // {
        //     var drink = await _dbContext.Drinks.FindAsync(model.Id);

        //     if (drink == null)
        //     {
        //         throw new NotFoundException("Drink not found");
        //     }

        //     // Update Drink entity
        //     drink.Name = model.Name;
        //     drink.Price = model.Price;
        //     drink.DrinkTypeId = model.DrinkTypeId;
        //     drink.ImagePath = model.ImagePath;

        //     // Update ingredients
        //     if (model.Ingredients != null && model.Ingredients.Any())
        //     {
        //         // Remove existing ingredients
        //         _dbContext.IngredientsInDrinks.RemoveRange(_dbContext.IngredientsInDrinks.Where(i => i.DrinkId == model.Id));

        //         // Add new ingredients
        //         foreach (var ingredient in model.Ingredients)
        //         {
        //             var ingredientInDrink = new IngredientInDrink
        //             {
        //                 DrinkId = drink.Id,
        //                 IngredientId = ingredient.IngredientId,
        //                 Quantity = ingredient.Quantity
        //             };
        //             _dbContext.IngredientsInDrinks.Add(ingredientInDrink);
        //         }
        //     }

        //     await _dbContext.SaveChangesAsync();

        //     return drink;
        // }


        // public async Task<bool> DeleteDrinkAsync(string id)
        // {
        //     var drink = await _dbContext.Drinks.FindAsync(id);

        //     if (drink == null)
        //     {
        //         throw new NotFoundException("Drink not found");
        //     }

        //     _dbContext.Drinks.Remove(drink);
        //     await _dbContext.SaveChangesAsync();

        //     return true;
        // }

        // public async Task<bool> DeleteAllDrinksAsync()
        // {
        //     var drinks = await Task.FromResult(_dbContext.Drinks.AsEnumerable());

        //     foreach (var drink in drinks)
        //     {
        //         _dbContext.Drinks.Remove(drink);
        //     }

        //     await _dbContext.SaveChangesAsync();

        //     return true;
        // }
    }
}
