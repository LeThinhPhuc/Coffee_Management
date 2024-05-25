namespace CoffeeShopApi.Services.Implements
{
    using Models.DomainModels;
    using Services.Interfaces;
    using Models.DAL;
    using Microsoft.EntityFrameworkCore;
    using Models.DTOs;
    using Exceptions;
    using System.Security.Principal;

    public class IngredientService : IIngredientService
    {
        private readonly AppDbContext _context;

        public IngredientService(AppDbContext context)
        {
            _context = context;
        }

        // sai lầm cần rút kinh nghiệm: Phải bind relationship Ingredient -> Shop or User
        public async Task<List<IngredientViewModel>> GetAllByUserIdAsync(string userId)
        {
            // var ingredients = await Task.FromResult(_context.Ingredients
            //         // No relationship with Shop or Owner, damn!!!, 5-tables query !
            //         .Include(i => i.IngredientInDrinks)
            //             .ThenInclude(iid => iid.Drink)
            //                 .ThenInclude(d => d.DrinkType)
            //                     .ThenInclude(dt => dt.Shop)
            //                         .ThenInclude(s => s.Owner)
            //         .Where(i => i....)
            //         .AsEnumerable());

            var ingredients = await _context.Ingredients
                // Include IngredientInDrinks relationship
                .Include(i => i.IngredientInDrinks)
                    // Include Drink relationship
                    .ThenInclude(iid => iid.Drink)
                        // Include DrinkType relationship
                        .ThenInclude(d => d.DrinkType)
                            // Include Shop relationship
                            .ThenInclude(dt => dt.Shop)
                                // Include Owner relationship
                                .ThenInclude(s => s.Owner)
                // Convert to IEnumerable for further filtering
                // .AsEnumerable()
                // .ToListAsync()
                // Filter by userId
                .Where(i => i.IngredientInDrinks.Any(iid => iid.Drink.DrinkType.Shop.Owner.Id == userId))
                .ToListAsync();

            // string southEastAsiaZoneId = "SE Asia Standard Time";

            // TimeZoneInfo seAZone = TimeZoneInfo.FindSystemTimeZoneById(southEastAsiaZoneId);

            var listIngredientsViewModel = ingredients.Select(d => new IngredientViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Amount = d.Amount,
                ImagePath = d.Image,
                DateCreated = d.DateCreated,
                DateModified = d.DateModified,
                ExpiryDate = d.ExpiryDate,
                FormattedDateCreated = d.DateCreated.ToString("dddd, dd/MM/yyyy - HH:mm"),
                FormattedDateModified = d.DateModified.ToString("dddd, dd/MM/yyyy - HH:mm"),
                FormattedExpiryDate = d.ExpiryDate?.ToString("dddd, dd/MM/yyyy - HH:mm"),
            }).ToList();

            return listIngredientsViewModel;
        }

        public async Task<IngredientViewModel> GetByIdAsync(string id)
        {
            var ingredient = await _context.Ingredients.FindAsync(id);

            var mappedIngredientVm = new IngredientViewModel
            {
                Id = ingredient.Id,
                Name = ingredient.Name,
                Amount = ingredient.Amount,
                ImagePath = ingredient.Image,
                DateCreated = ingredient.DateCreated,
                DateModified = ingredient.DateModified,
                ExpiryDate = ingredient.ExpiryDate,
                FormattedDateCreated = ingredient.DateCreated.ToString("dddd, dd/MM/yyyy - HH:mm"),
                FormattedDateModified = ingredient.DateModified.ToString("dddd, dd/MM/yyyy - HH:mm"),
                FormattedExpiryDate = ingredient.ExpiryDate?.ToString("dddd, dd/MM/yyyy - HH:mm"),
            };

            return mappedIngredientVm;
        }

       public async Task<Ingredient> CreateAsync(CreateUpdateIngredientModel model)
       {
            // Nhóm đã thống nhất không handle upload & save file ảnh trên server !!!
            // // Save the image file and get the image URL or file path
            // string imageUrl = await SaveImageAsync(imageFile);

            // // Set the Image property of the ingredient
            // ingredient.Image = imageUrl;

            // _context.Ingredients.Add(ingredient);
            // await _context.SaveChangesAsync();
            // return ingredient;

            var ingre = new Ingredient
            {
                Name = model.Name,
                Amount = model.Amount,
                ExpiryDate = model.ExpiryDate,
                Image = model.ImagePath
            };

            _context.Ingredients.Add(ingre);
            await _context.SaveChangesAsync();

            return ingre;
        }

        private async Task<string> SaveImageAsync(IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                return null;
            }

            var folderPath = Path.Combine("Resources", "Images");
            var folderDirectory = Directory.CreateDirectory(folderPath);
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
            var filePath = Path.Combine(folderDirectory.FullName, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }

            return fileName;
        }

        public async Task<Ingredient> UpdateAsync(CreateUpdateIngredientModel model)
        {
            var existingIngredient = await _context.Ingredients.FindAsync(model.Id);

            if (existingIngredient == null)
            {
                throw new NotFoundException("Ingredient not found by provided Id!");
            }

            existingIngredient.Name = model.Name;
            existingIngredient.Amount = model.Amount;
            existingIngredient.DateModified = DateTime.Now;
            existingIngredient.ExpiryDate = model.ExpiryDate;
            existingIngredient.Image = model.ImagePath;

            await _context.SaveChangesAsync();

            return existingIngredient;
        }

        // Minh won't be able to delete due to FK conflict with IngredientsInDrinks
        //*
        public async Task<bool> DeleteAsync(string id)
        {
            // var ingreToDelete = await _context.Ingredients.FindAsync(id);

            // if (ingreToDelete == null)
            // {
            //     throw new NotFoundException("Ingredient not found by provided Id!");
            // }

            // _context.Ingredients.Remove(ingreToDelete);
            // await _context.SaveChangesAsync();

            // return true;
            var ingredient = await _context.Ingredients
                .Include(d => d.IngredientInDrinks)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (ingredient == null)
            {
                throw new NotFoundException("Ingredient not found!");
            }

            if (ingredient.IngredientInDrinks.Any())
            {
                throw new IngredientInUseException("Ingredient in use with Drinks, cannot delete!");
            }

            // Now Remove the ingredient itself
            _context.Ingredients.Remove(ingredient);

            await _context.SaveChangesAsync();

            return true;
        }
        //*/

        // Minh doesn't want this, so backed it up
        /*
        public async Task<bool> DeleteAsync(string id)
        {
            var ingredient = await _context.Ingredients
                .Include(d => d.IngredientInDrinks)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (ingredient == null)
            {
                throw new NotFoundException("Ingredient not found!");
            }

            // First Remove all child many-to-many relationships
            _context.IngredientsInDrinks.RemoveRange(ingredient.IngredientInDrinks);

            // Now Remove the ingredient itself
            _context.Ingredients.Remove(ingredient);

            await _context.SaveChangesAsync();

            return true;
        }
        */
    }
}