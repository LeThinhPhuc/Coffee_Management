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

        public async Task<Ingredient> CreateAsync(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            await _context.SaveChangesAsync();
            return ingredient;
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