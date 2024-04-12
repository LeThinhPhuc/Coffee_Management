namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DomainModels;
    using Models.DTOs;

    public interface IDrinkService
    {
        Task<List<Drink>> GetAllDrinksSystemAsync();
        Task<List<DrinkViewModel>> GetAllDrinksClientAsync();
        Task<Drink> GetDrinkByIdAsync(string id);
        Task<List<DrinkViewModel>> GetDrinksByTypeAsync(string typeName);
        Task<bool> AddDrinkAsync(CreateUpdateDrinkModel drink);
        Task<bool> UpdateDrinkAsync(CreateUpdateDrinkModel model);
        Task<bool> DeleteDrinkAsync(string id);
        Task<bool> DeleteAllDrinksAsync();
    }
}