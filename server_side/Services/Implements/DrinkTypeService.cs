namespace CoffeeShopApi.Services.Implements
{
    using Models.DomainModels;
    using Models.DTOs;
    using Services.Interfaces;
    using Models.DAL;
    using Microsoft.EntityFrameworkCore;
    using Exceptions;

    public class DrinkTypeService : IDrinkTypeService
    {
        // public string getAllDrinkTypeCacheKey = "ListDrinkTypes";
        private readonly AppDbContext _dbContext;

        public DrinkTypeService(AppDbContext dbContext
            //IMemoryCache memoryCache
        )
        {
            _dbContext = dbContext;
            // _memoryCache = memoryCache;
        }


        public async Task<List<DrinkType>> GetAllDrinkTypesAsync()
        {
            // if (!_memoryCache.TryGetValue(getAllDrinkTypeCacheKey, out List<DrinkType>? listDrinksType))
            // {
            //     // Cache miss, fetch the data
            //     listDrinksType = _unitOfWork.DrinkTypes.GetAll()
            //         .OrderByDescending(d => d.DateModified)
            //         .ToList();

            //     // cache life time
            //     var cacheExpiryOptions = new MemoryCacheEntryOptions
            //     {
            //         AbsoluteExpiration = DateTime.Now.AddHours(6), // will force expire after 4h
            //         Priority = CacheItemPriority.High,
            //     };
            //     _memoryCache.Set(getAllDrinkTypeCacheKey, listDrinksType, cacheExpiryOptions);
            // }

            
            var listDrinksType = _dbContext.DrinkTypes.AsEnumerable()
                    .OrderByDescending(d => d.DateModified)
                    .ToList();

            return listDrinksType;
        }

        public async Task<List<DrinkType>> GetAllDrinkTypesByShopOwnerIdAsync(string ownerId)
        {
            var listDrinksType = await _dbContext.DrinkTypes
                .Include(d => d.Shop)
                .Where(d => d.Shop.OwnerId == ownerId)
                .OrderByDescending(d => d.DateModified)
                .ToListAsync();

            return listDrinksType;
        }


        public async Task<DrinkType> GetDrinkTypeByIdAsync(string id)
        {
            return await _dbContext.DrinkTypes.FindAsync(id);
        }

        public async Task<bool> AddDrinkTypeAsync(CreateUpdateDrinkTypeModel model)
        {
            var drinkType = new DrinkType
            {
                Name = model.Name,
                ShopId = model.ShopId // Assuming we have ShopId in CreateUpdateDrinkTypeModel
            };

            _dbContext.DrinkTypes.Add(drinkType);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateDrinkTypeAsync(CreateUpdateDrinkTypeModel model)
        {
            var drinkType = await _dbContext.DrinkTypes.FindAsync(model.Id);

            if (drinkType == null)
            {
                throw new NotFoundException("DrinkType not found");
            }

            drinkType.Name = model.Name;

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteDrinkTypeAsync(string id)
        {
            var drinkType = await _dbContext.DrinkTypes.FindAsync(id);

            if (drinkType == null)
            {
                throw new NotFoundException("Drinktype not found");
            }

            _dbContext.DrinkTypes.Remove(drinkType);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAllDrinkTypesAsync()
        {
            var drinkTypes = await _dbContext.DrinkTypes.ToListAsync();

            _dbContext.DrinkTypes.RemoveRange(drinkTypes);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}