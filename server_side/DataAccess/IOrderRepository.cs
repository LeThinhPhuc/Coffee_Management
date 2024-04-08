using CoffeeShopApi.DTOs;

namespace CoffeeShopApi.DataAccess
{
    public interface IOrderRepository 
    {
        Task<IEnumerable<OrderDTO>> GetAllOrdersAsync();
    }
}
