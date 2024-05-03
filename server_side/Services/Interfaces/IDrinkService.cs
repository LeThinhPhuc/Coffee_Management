namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DomainModels;
    using Models.DTOs;

    public interface IDrinkService
    {
        Task<List<Drink>> GetAllDrinksSystemAsync();
        Task<List<DrinkViewModel>> GetAllDrinksClientAsync();
        Task<Drink> GetDrinkByIdAsync(string id);
        Task<List<DrinkViewModel>> GetDrinksByTypeNameAsync(string typeName);
        Task<List<object>> GetMenuDataAsync();
        Task<Drink> AddDrinkAsync(CreateUpdateDrinkModel model);
        Task<Drink> UpdateDrinkAsync(CreateUpdateDrinkModel model);
        Task<bool> DeleteDrinkAsync(string id);
        Task<bool> DeleteAllDrinksAsync();
    }
}