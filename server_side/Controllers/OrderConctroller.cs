namespace CoffeeShopApi.Controllers
{
    using Models.DTOs;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Interfaces;
    using System.Security.Claims;

    [ApiController]
    [Route("api/[Controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllOrdersAsync()
        {
            var orders = await _orderService.GetAllOrdersAsync();
            if (orders == null)
                return NotFound();

            return Ok(orders);
        }

        [Authorize]
        [HttpPost("createorder")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateUpdatOrderModel createOrderModel)
        {
            // Get the UserId from the current user's claims (JWT)
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            // This rarely happen since we already had Authorize attribute above!
            if (string.IsNullOrEmpty(userId))
            {
                // actually never reach this if the method has [Authorize] attribute
                return Unauthorized("Please login to create order, staff."); 
            }

            return Ok(new {succeeded = true, message = "created order" });

            // try
            // {
            //     // Create the order
            //     var result = await _orderService.CreateOrder(createOrderModel, userId);

            //     return Ok(result);
            // }
            // catch (Exception ex)
            // {
            //     // await _unitOfWork.RollbackAsync();  // cancel the transaction
            //     return Ok(new { succeeded = false, message = ex.Message });
            // }
            #region example input:
            //{
            //    "drinks": [
            //    {
            //        "drinkId": "e5874547-419b-4d61-b3a8-ca87281a6166",
            //        "price": 28000,
            //        "quantity": 1
            //    }
            //    ]
            //}


            // eg2:

            //            {
            //                "drinks": [
            //                  {
            //                    "drinkId": "1b85c24c-d571-4e3f-8335-ae0217dd80ef",
            //      "price": 28000,
            //      "quantity": 2
            //                  }
            //  ]
            //}

            // return obj:

            //            {
            //                "userId": "a4439771-4c5b-4146-8544-692f9ac524e9",
            //  "orderDate": "2023-05-17T10:05:55.943393+07:00",
            //  "total": 56000,
            //  "feedbacked": false,
            //  "id": "8458a572-73a8-4817-8a12-8bab1c1a6455",
            //  "dateCreated": "0001-01-01T00:00:00",
            //  "dateModified": "0001-01-01T00:00:00",
            //  "isActive": false
            //}
            #endregion
        }

        /*
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetOrderById(string id)
        {
            Order order = await _orderService.GetOrderByIdAsync(id);
            if (order == null)
                return NotFound();

            return Ok(order);
        }
        */

        [HttpGet("getdetailedbyid/{id}")]
        public async Task<IActionResult> GetDetailedOrderById(string id)
        {
            var detailedOrder = await _orderService.GetDetailedOrderById(id);
            if (detailedOrder == null)
            {
                return NotFound("Order not found");
            }

            return Ok(detailedOrder);
        }

        /*
        // Order can't be updated once created (bussiness logic)

        [Authorize]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteOrder(string id)
        {
            try
            {
                var result = await _orderService.DeleteOrderAsync(id);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete Order!" });
            }
            catch (NotFoundException ex)
            {
                return Ok(new { succeeded = false, message = "Order not found!" });
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        [Authorize]
        [HttpDelete("deleteall")]
        public async Task<IActionResult> DeleteAllOrders()
        {
            try
            {

                var result = await _orderService.DeleteAllOrdersAsync();
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete All Orders!" });
            }
            catch (NotFoundException ex)
            {
                return Ok(new { succeeded = false, message = "No Order found!" });
            }
            catch (Exception ex)
            {
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }
        */
    }
    
}