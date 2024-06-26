﻿using CoffeeShopApi.DTOs;
using CoffeeShopApi.Models.DomainModels;
using CoffeeShopApi.PostModels;

namespace CoffeeShopApi.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderDTO>> GetAllOrdersAsync();
        Task<OrderDTO> GetOrderByIdAsync(string id);

        Task<OrderDTO> GetOrdersByUserIdAsync(string userId);

        Task<bool> DeleteOrderAsync(string id);

        Task<IEnumerable<object>> GetOrdersByShopIdAsync(string shopId);

        Task<OrderDTO> AddNewOrderAsync(OrderModelDTO newOrderDTO);

        Task<OrderDTO> UpdateOrderAsync(OrderDTO orderChanges);
    }
}
