using AutoMapper;
using CoffeeShopApi.DTOs;
using CoffeeShopApi.Models.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CoffeeShopApi.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        private AppDbContext context;
        private readonly IMapper mapper;

        public OrderRepository(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<OrderDTO>> GetAllOrdersAsync()
        {
            var orders = await this.context.Orders.Select(o => new OrderDTO
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                Total = o.Total,
                User = new ApplicationUserDTO
                {
                    Id = o.User.Id,
                    FullName = o.User.FullName
                },
                OrderItems = o.OrderItems.Select(orderItem => new OrderItemDTO
                {
                    Quantity = orderItem.Quantity,
                    Note = orderItem.Note,
                    Drink = new DrinkDTO
                    {
                        Name = orderItem.Drink.Name,
                        Price = orderItem.Drink.Price
                    }
                }).ToList()
            }).ToListAsync();

            return orders;
        }


        public async Task<IEnumerable<OrderDTO>> GetOrderByIdAsync(string id)
        {
            var orders = context.Orders.Where(o => o.Id == id).ToListAsync(); 
            
            var orderToReturn = this.mapper.Map<IEnumerable<OrderDTO>>(orders);

            return orderToReturn;
        }

    }
}
