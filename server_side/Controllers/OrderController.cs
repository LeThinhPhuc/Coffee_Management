using CoffeeShopApi.DataAccess;
using CoffeeShopApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace CoffeeShopApi.Controllers
{
    public class OrderController : BaseApiController
    {
        private  IOrderRepository repo;
        public OrderController(IOrderRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<OrderItemDTO>>> GetAllOrders()
        {
            var orders = await repo.GetAllOrdersAsync();
            if(orders.Count() == 0)
            {
                return NotFound();
            }

            return Ok(orders);
        }
    }
}
