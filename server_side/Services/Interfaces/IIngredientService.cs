using CoffeeShopApi.Models.DomainModels;

namespace CoffeeShopApi.Services.Interfaces
{
    public interface IIngredientService
    {
        Task<IEnumerable<Ingredient>> GetAllAsync();
        Task<Ingredient> GetByIdAsync(string id);
        Task<Ingredient> CreateAsync(Ingredient ingredient);
        Task<Ingredient> UpdateAsync(string id, Ingredient ingredient);
        Task DeleteAsync(string id);
    }
}