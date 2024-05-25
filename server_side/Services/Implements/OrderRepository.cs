using AutoMapper;
using CoffeeShopApi.DTOs;
using CoffeeShopApi.Models.DAL;
using CoffeeShopApi.Models.DomainModels;
using CoffeeShopApi.PostModels;
using CoffeeShopApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.Extensions.Options;

namespace CoffeeShopApi.Repositories.Implements
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
            var s = context.Orders.Include(o => o.User)
                .Include(o => o.OrderItems).ToList();

            var orders = await context.Orders.Select(o => new OrderDTO
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
                    OrderId = orderItem.Id,
                    Quantity = orderItem.Quantity,
                    Note = orderItem.Note,
                    Drink = new DrinkDTO
                    {
                        DrinkId = orderItem.Drink.Id,
                        Name = orderItem.Drink.Name,
                        Price = orderItem.Drink.Price
                    }
                }).ToList()
            }).ToListAsync();

            return orders;
        }


        public async Task<OrderDTO> GetOrderByIdAsync(string id)
        {
            var orders = await context.Orders.Include(o => o.User)
                .Include(o => o.OrderItems)
                .ThenInclude(o => o.Drink)
                .FirstOrDefaultAsync(o => o.Id == id);

            var orderToReturn = mapper.Map<OrderDTO>(orders);

            return orderToReturn;
        }

        public async Task<OrderDTO> GetOrdersByUserIdAsync(string userId)
        {
            var orders = await context.Orders.Include(o => o.User)
                .Include(o => o.OrderItems)
                .ThenInclude(o => o.Drink)
                .FirstOrDefaultAsync(o => o.UserId == userId);

            var orderToReturn = mapper.Map<OrderDTO>(orders);

            return orderToReturn;
        }


        public async Task<bool> DeleteOrderAsync(string id)
        {
            var order = await context.Orders.FirstOrDefaultAsync(o => o.Id == id);

            context.Remove(order);

            await context.SaveChangesAsync();
            if (order != null)
            {
                return true;
            }
            return false;
        }

        public async Task<OrderDTO> AddNewOrderAsync(OrderModelDTO newOrderDT0)
        {
            var check = await context.Users
                .FirstOrDefaultAsync(u => u.Id == newOrderDT0.UserId);
            if(check == null)
            {
                return null;
            }

            string newOrderId = Guid.NewGuid().ToString();//tự động tạo 1 mã order mới 
            Order newOrder = new Order
            {
                Id = newOrderId,
                UserId = newOrderDT0.UserId,
                OrderDate = DateTime.Now,
                Total = newOrderDT0.Total,
                OrderItems = newOrderDT0.OrderItems.Select(o => new OrderItem
                {
                    OrderId = newOrderId,
                    DrinkId = o.DrinkId,
                    Quantity = o.Quantity,
                    Note = o.Note
                }).ToList(),
            };

            context.Orders.Add(newOrder);

            int result = await context.SaveChangesAsync();

            if (result > 0)
            {
                return mapper.Map<OrderDTO>(newOrder);
            }

            return null;
        }


        public async Task<OrderDTO> UpdateOrderAsync(OrderDTO orderChanges)
        {
            return new OrderDTO { Id = orderChanges.Id };
        }

        public async Task<IEnumerable<object>> GetOrdersByShopIdAsync(string shopId)
        {
            var shop = await context
                .Shops
                .Include(s => s.Owner)
                .ThenInclude( o => o.Orders)
                .ThenInclude(o => o.OrderItems)
                .ThenInclude( oi => oi.Drink)
                .FirstOrDefaultAsync(s => s.Id == shopId);

            if(shop == null)
            {
                return null;
            }

            var ordersOfShop = shop.Owner.Orders.Select(o =>new 
            {
                OrderId = o.Id,
                Total = o.Total,
                Items = o.OrderItems.Select(oi => new
                {
                    ItemId = oi.Id,
                    Quanity = oi.Quantity,
                    Note = oi.Note,
                    Drink = new
                    {
                        DrinkId = oi.Drink.Id,
                        Name = oi.Drink.Name,   
                        Price = oi.Drink.Price
                    }
                })
            });


            return ordersOfShop;


    }
    }
}
