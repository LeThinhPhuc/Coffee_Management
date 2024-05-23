namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DTOs;

    public interface IAdminService
    {
        Task<List<ShopAdminViewModel>> GetAllShops();
        Task<bool> ApproveShopAsync(string shopId);
        Task<SuspenseResult> SuspenseShopAsync(string shopId);
        
    }
}