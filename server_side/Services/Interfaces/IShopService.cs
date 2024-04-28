namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DomainModels;
    using Models.DTOs;

    public interface IShopService
    {
        Task<List<ShopViewModel>> GetAllShopsClientAsync();
        Task<Shop> GetShopByIdAsync(string id);
        // Task<List<DrinkViewModel>> GetShopsByNameAsync(string name);
        // Task<Drink> AddShopAsync(CreateUpdateShopModel model);
        // Task<Drink> UpdateShopAsync(CreateUpdateShopModel model);
        // Task<bool> DeleteShopAsync(string id);
        // Task<bool> DeleteAllShopsAsync();
    }
}