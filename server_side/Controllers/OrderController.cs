using CoffeeShopApi.DTOs;
using CoffeeShopApi.PostModels;
using CoffeeShopApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Formats.Asn1;

namespace CoffeeShopApi.Controllers
{
    public class OrderController : BaseApiController
    {
        private IOrderRepository repo;
        public OrderController(IOrderRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<OrderItemDTO>>> GetAllOrders()
        {
            var orders = await repo.GetAllOrdersAsync();
            if (orders.Count() == 0)
            {
                return NotFound();
            }

            return Ok(orders);
        }


        [HttpGet("[action]")]
        public async Task<ActionResult<OrderItemDTO>> GetOrderById([FromQuery] string id)
        {
            var orders = await repo.GetOrderByIdAsync(id);
            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<OrderItemDTO>> GetOrdersByUserId([FromQuery] string id)
        {
            var orders = await repo.GetOrdersByUserIdAsync(id);
            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }



        [HttpDelete("[action]")]
        public async Task<ActionResult> DeleteOrder([FromQuery] string id)
        {
            var check = await repo.DeleteOrderAsync(id);
            if (check == true)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost("[action]")]
        public async Task<ActionResult> AddOrder([FromBody] OrderModelDTO newOrderDT0)
        {
            var newOrder = await repo.AddNewOrderAsync(newOrderDT0);

            if (newOrder != null)
            {
                return CreatedAtAction(nameof(AddOrder), newOrder);
            }
            return BadRequest();
        }

        //[HttpDelete("[action]")]
        //public async Task<ActionResult> DeleteItemsOfOrder()
        //{

        //}



    }
}
