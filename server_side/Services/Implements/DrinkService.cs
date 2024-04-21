namespace CoffeeShopApi.Services.Implements
{
    using Models.DTOs;
    using Exceptions;
    using Repositories.Interfaces;
    using Services.Interfaces;
    using Models.DomainModels;
    using CoffeeShopApi.Models.DAL;
    using Microsoft.EntityFrameworkCore;

    public class DrinkService : IDrinkService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _dbContext;

        public DrinkService(AppDbContext dbContext,
            IUnitOfWork unitOfWork
        )
        {
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
            // _memoryCache = memoryCache;
        }

        public List<Drink> GetAllDrinks()
        {
            return _dbContext.Drinks
                .OrderByDescending(d => d.DateModified)
                .ToList();
        }

        public async Task<List<Drink>> GetAllDrinksSystemAsync()
        {
            return await Task.FromResult(GetAllDrinks());
        }

        public async Task<List<DrinkViewModel>> GetAllDrinksClientAsync()
        {

            var drinks = await Task.FromResult(_dbContext.Drinks.AsEnumerable());

            var listDrinksViewModel = drinks.Select(d => new DrinkViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Price = d.Price,
                ImagePath = d.ImagePath,
                DrinkTypeId = d.DrinkTypeId,
                DrinkTypeName = d.DrinkType?.Name
            }).ToList();


            return listDrinksViewModel;
        }

        public List<Drink> GetDrinksByType(string typeName)
        {
            var drinks = _dbContext.Drinks
                .Where(d => d.DrinkType.Name == typeName)
                .ToList();
            return drinks;
        }

        public async Task<List<DrinkViewModel>> GetDrinksByTypeNameAsync(string typeName)
        {
            var drinks = await _dbContext.Drinks
            .Include(d => d.DrinkType)
            .Where(d => d.DrinkType.Name == typeName)
            .Select(d => new DrinkViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Price = d.Price,
                ImagePath = d.ImagePath,
                DrinkTypeId = d.DrinkTypeId,
                DrinkTypeName = d.DrinkType.Name,
            })
            .ToListAsync();

            return drinks;
        }

        public async Task<List<object>> GetMenuDataAsync()
        {
            var menuData = await _dbContext.Drinks
                .Include(d => d.DrinkType)
                .Include(d => d.Ingredients)
                    .ThenInclude(di => di.Ingredient)
                .GroupBy(d => d.DrinkType.Name)
                .Select(group => new
                {
                    Category = group.Key,
                    Items = group.Select(d => new
                    {
                        Id = d.Id,
                        Image = d.ImagePath,
                        Name = d.Name,
                        // Price = $"{d.Price}VNĐ",
                        Price = d.Price,
                        DrinkTypeId = d.DrinkTypeId,
                        Ingredients = d.Ingredients
                            .Select(di => new
                            {
                                IngredientName = di.Ingredient.Name,
                                Quantity = di.Quantity
                            }).ToList()
                    }).ToList()
                })
                .ToListAsync();

            return menuData.Cast<object>().ToList();
        }

        public async Task<Drink> GetDrinkByIdAsync(string id)
        {
            return await _dbContext.Drinks.FindAsync(id);
        }

        public async Task<bool> AddDrinkAsync(CreateUpdateDrinkModel model)
        {
            var drink = new Drink
            {
                Name = model.Name,
                Price = model.Price,
                ImagePath = model.ImagePath,
                DrinkTypeId = model.DrinkTypeId
            };

            _dbContext.Drinks.Add(drink);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateDrinkAsync(CreateUpdateDrinkModel model)
        {
            var drink = await _dbContext.Drinks.FindAsync(model.Id);

            if (drink == null)
            {
                throw new NotFoundException("Drink not found");
            }

            // Actung ! must update enough required fields
            drink.Name = model.Name;
            drink.Price = model.Price;
            drink.DrinkTypeId = model.DrinkTypeId;
            drink.ImagePath = model.ImagePath;

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteDrinkAsync(string id)
        {
            var drink = await _dbContext.Drinks.FindAsync(id);

            if (drink == null)
            {
                throw new NotFoundException("Drink not found");
            }

            _dbContext.Drinks.Remove(drink);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAllDrinksAsync()
        {
            var drinks = await Task.FromResult(_dbContext.Drinks.AsEnumerable());

            foreach (var drink in drinks)
            {
                _dbContext.Drinks.Remove(drink);
            }

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}