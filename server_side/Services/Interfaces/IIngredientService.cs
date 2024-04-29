using CoffeeShopApi.Models.DomainModels;
using CoffeeShopApi.Models.DTOs;

namespace CoffeeShopApi.Services.Interfaces
{
    public interface IIngredientService
    {
        Task<List<IngredientViewModel>> GetAllAsync();
        Task<IngredientViewModel> GetByIdAsync(string id);
        Task<Ingredient> CreateAsync(CreateUpdateIngredientModel model);
        Task<Ingredient> UpdateAsync(CreateUpdateIngredientModel model);
        Task<bool> DeleteAsync(string id);
    }
}