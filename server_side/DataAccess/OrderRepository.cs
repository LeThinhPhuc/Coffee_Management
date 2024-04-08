using CoffeeShopApi.DTOs;
using CoffeeShopApi.Models.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CoffeeShopApi.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        private AppDbContext context;

        public OrderRepository(AppDbContext context)
        {
            this.context = context;
        }


        public async Task<IEnumerable<OrderDTO>> GetAllOrdersAsync()
        {
            var orders = await this.context.Orders.Select(o => new OrderDTO
            {
                OrderDate = o.OrderDate,
                Total = o.Total,
                User = new ApplicationUserDTO
                {
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

    }
}
