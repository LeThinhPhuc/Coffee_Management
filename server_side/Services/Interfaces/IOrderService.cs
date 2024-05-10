namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DomainModels;
    using Models;
    using Models.DTOs;

    public interface IOrderService
    {
        Task<List<object>> GetAllOrderDetailedsAsync();
        // Task<Order> GetOrderByIdAsync(string id);
        Task<Object> GetDetailedOrderById(string id);
        Task<Order> CreateOrder(CreateUpdatOrderModel createOrderModel, string userId);
        // //Task<bool> UpdateOrderAsync(CreateUpdatOrderModel order);
        // Task<bool> DeleteOrderAsync(string id);
        // Task<bool> DeleteAllOrdersAsync();
    }
}