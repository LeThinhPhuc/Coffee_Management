namespace CoffeeShopApi.Services.Implements
{
    using Models.DomainModels;
    using Services.Interfaces;
    using Models.DAL;
    using Microsoft.EntityFrameworkCore;

    public class IngredientService : IIngredientService
    {
        private readonly AppDbContext _context;

        public IngredientService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ingredient>> GetAllAsync()
        {
            return await _context.Ingredients.ToListAsync();
        }

        public async Task<Ingredient> GetByIdAsync(string id)
        {
            return await _context.Ingredients.FindAsync(int.Parse(id));
        }

       public async Task<Ingredient> CreateAsync(Ingredient ingredient, IFormFile imageFile)
       {
            // Save the image file and get the image URL or file path
            string imageUrl = await SaveImageAsync(imageFile);

            // Set the Image property of the ingredient
            ingredient.Image = imageUrl;

            _context.Ingredients.Add(ingredient);
            await _context.SaveChangesAsync();
            return ingredient;
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

        public async Task<Ingredient> UpdateAsync(string id, Ingredient ingredient)
        {
            var existingIngredient = await _context.Ingredients.FindAsync(int.Parse(id));
            if (existingIngredient == null)
            {
                return null;
            }

            existingIngredient.Name = ingredient.Name;
            existingIngredient.Amount = ingredient.Amount;
            existingIngredient.ExpiryDate = ingredient.ExpiryDate;

            await _context.SaveChangesAsync();
            return existingIngredient;
        }

        public async Task DeleteAsync(string id)
        {
            var ingredient = await _context.Ingredients.FindAsync(int.Parse(id));
            if (ingredient != null)
            {
                _context.Ingredients.Remove(ingredient);
                await _context.SaveChangesAsync();
            }
        }
    }
}