using AutoMapper;
using CoffeeShopApi.DataAccess;
using CoffeeShopApi.DTO;
using CoffeeShopApi.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace CoffeeShopApi.Controllers
{
    [ApiController]
    [Route("api/Orders")]
    public class OrderController : ControllerBase
    {
        private IOrderService orderRepo;
        public OrderController(IOrderService orderRepo) 
        {
            this.orderRepo = orderRepo; 
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetOrders()
        {
            var orders = await orderRepo.GetOrdersAsync();
            if (orders.Count() == 0)
            {
                return NotFound("Không tìm thấy order");
            }
            return Ok(orders);
        }



        [HttpGet("[action]")]
        public async Task<ActionResult<Order>> GetOrderById(string id)
        {
            var order = await orderRepo.GetOrdersByIdAsync(id);
            if (order == null)
            {
                return NotFound("Không tìm thấy order");
            }
            return Ok(order);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrdersByUserId(string userId)
        {
            var order = await orderRepo.GetOrdersByUserIdAsync(userId);
            if(order == null)
            {
                return NotFound("Không tìm thấy order");
            }
            return Ok(order);
        }
    }
}
