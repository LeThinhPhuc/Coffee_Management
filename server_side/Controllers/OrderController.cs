namespace CoffeeShopApi.Controllers
{
    using DTOs;
    using PostModels;
    using Repositories.Interfaces;
    using Services.Interfaces;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;


    public class OrderController : BaseApiController
    {
        private IOrderRepository repo;
        private readonly IOrderService _orderService;    // add Tứng hay ho's methods for custom LinQ logic
        public OrderController(IOrderRepository repo, IOrderService orderService)
        {
            this.repo = repo;
            _orderService = orderService;
        }

        [Authorize]
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

        [Authorize]
        /// <summary>
        /// Retrive all order with detailed props
        /// </summary>
        /// <returns>Returns a List of OrderItemDTO</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<OrderItemDTO>>> GetAllOrdersDetailedAsync()
        {
            var orders = await _orderService.GetAllOrderDetailedsAsync();
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

        [HttpGet("[action]")]
        public async Task<ActionResult> GetOrderByShopId([FromQuery] string shopId)
        {
            var order = await repo.GetOrdersByShopIdAsync(shopId);

            if(order == null)
            {
                return BadRequest();
            }

            return Ok(order);
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



        /// <summary>
        /// Note: Total and Voucher discount calculated by ClientSide. => phải tự tính nếu dùng Swagger
        /// </summary>
        /// <returns>Returns an OrderDTO</returns>
        [HttpPost("[action]")]
        public async Task<ActionResult> AddOrder([FromBody] OrderModelDTO newOrderDT0)
        {
            var newOrder = await repo.AddNewOrderAsync(newOrderDT0);

            if (newOrder != null)
            {
                return CreatedAtAction(nameof(AddOrder), newOrder);
            }
            return BadRequest(new
            {
                Message = "Có thể không đủ nguyên liệu"
            });;
        }
        #region example input data:
        // {
        //   "userId": "f2aff88c-1d4a-430b-bdc5-cb6358616a4e",
        //   "total": 0,
        //   "orderItems": [
        //     {
        //       "drinkId": "908d84ef-bec5-487b-804d-f19609bf3a2f",
        //       "quantity": 2,
        //       "note": "More milk please"
        //     },
        //     {
        //       "drinkId": "a111e3b6-53ef-451a-943d-cf1174359aa0",
        //       "quantity": 1,
        //       "note": "Less sugar please"
        //     }
        //   ]
        // }
        #endregion

        #region example response data:
        // {
        // "orderDate": "2024-05-09T16:48:57.311556+07:00",
        // "total": 0,
        // "user": {
        //     "id": "f2aff88c-1d4a-430b-bdc5-cb6358616a4e",
        //     "fullName": "Admin"
        // },
        // "orderItems": [
        //     {
        //     "orderId": "7d126800-3303-468a-b412-206f150b1dfc",
        //     "quantity": 2,
        //     "note": "More milk please",
        //     "drink": null
        //     },
        //     {
        //     "orderId": "7d126800-3303-468a-b412-206f150b1dfc",
        //     "quantity": 1,
        //     "note": "Less sugar please",
        //     "drink": null
        //     }
        // ],
        // "id": "7d126800-3303-468a-b412-206f150b1dfc",
        // "dateCreated": "2024-05-09T16:48:57.311508",
        // "dateModified": "2024-05-09T16:48:57.311554"
        // }
        #endregion


        //[HttpDelete("[action]")]
        //public async Task<ActionResult> DeleteItemsOfOrder()
        //{

        //}



    }
}
