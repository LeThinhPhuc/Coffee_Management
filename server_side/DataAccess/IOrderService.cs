using CoffeeShopApi.DTO;
using CoffeeShopApi.Models.DomainModels;
using System.Collections.Generic;

namespace CoffeeShopApi.DataAccess
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetOrdersAsync();

        Task<Order> GetOrdersByIdAsync(string id);

        Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId);


        //Task<IEnumerable<Order>> GetOrdersByFullName(string fullName);
    }
}
