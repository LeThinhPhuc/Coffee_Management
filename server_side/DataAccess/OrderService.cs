using AutoMapper;
using CoffeeShopApi.DTO;
using CoffeeShopApi.DTOs;
using CoffeeShopApi.Models.DAL;
using CoffeeShopApi.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace CoffeeShopApi.DataAccess
{
    public class OrderService : IOrderService
    {
        private AppDbContext context;
        private readonly IMapper mapper;

        public OrderService(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<OrderDTO>> GetOrdersAsync()
        {
            var orders = context.Users.ToList();
            var mapOders = mapper.Map<IEnumerable<OrderDTO>>(orders);
            //var orders = await context.Orders.Include(o => o.User).Select(o => new OrderDTO
            //{
            //    Id = o.Id,
            //    UserId = o.UserId,
            //    DateCreated = o.DateCreated,
            //    DateModified = o.DateModified,
            //    User = new ApplicationUserDTO
            //    {
            //        Id = o.User.Id,
            //        FullName = o.User.FullName,
            //        UserName = o.User.UserName
            //    },
            //    OrderDate = o.OrderDate,
            //    Total = o.Total,
            //    OrderItems = o.OrderItems.Select(otherItem => new OrderItemDTO
            //    {
            //        OrderId = otherItem.Id,
            //        Quantity = otherItem.Quantity,
            //        Note = otherItem.Note,
            //        Drink = new DrinkDTO
            //        {
            //            Name = otherItem.Drink.Name,
            //            Price = otherItem.Drink.Price,
            //            DrinkType = new DrinkTypeDTO
            //            {
            //                Id = otherItem.Drink.DrinkType.Id,
            //                Name = otherItem.Drink.DrinkType.Name
            //            }
            //        }
            //    }).ToList()

            //}).ToListAsync(); 

            return mapOders;
        }


        public async Task<Order> GetOrdersByIdAsync(string id)
        {
            var order = await context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            return order;
        }


        public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId)
        {
            return await context.Orders.Where(o => o.UserId == userId).ToListAsync();
        }

        //public Task<IEnumerable<Order>> GetOrdersByFullName(string fullName)
        //{

        //}

    }
}
