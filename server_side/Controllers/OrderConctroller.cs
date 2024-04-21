namespace CoffeeShopApi.Controllers
{
    using Models.DTOs;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Interfaces;
    using System.Security.Claims;
    using CoffeeShopApi.Models.DAL;
    using Microsoft.EntityFrameworkCore;
    using CoffeeShopApi.Models.DomainModels;

    [ApiController]
    [Route("api/[Controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly AppDbContext _dbContext;

        public OrderController(IOrderService orderService, AppDbContext dbContext)
        {
            _orderService = orderService;
            _dbContext = dbContext;
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

            // This rarely happens since we already have the Authorize attribute above
            if (string.IsNullOrEmpty(userId))
            {
                // Actually never reaches this if the method has [Authorize] attribute
                return Unauthorized("Please login to create order, staff.");
            }

            try
            {
                // Create the order
                var order = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    Note = createOrderModel.Note
                };

                // Add order items
                if (createOrderModel.Drinks != null && createOrderModel.Drinks.Any())
                {
                    order.OrderItems = createOrderModel.Drinks.Select(drink => new OrderItem
                    {
                        DrinkId = drink.DrinkId,
                        Quantity = drink.Quantity,
                        OrderId = order.Id
                    }).ToList();
                }

                // Calculate the total
                order.Total = CalculateTotal(order);

                // Update ingredient amounts
                foreach (var drink in createOrderModel.Drinks)
                {
                    var ingredientsInDrink = await _dbContext.Set<IngredientInDrink>()
                        .Where(iid => iid.DrinkId == drink.DrinkId)
                        .Include(iid => iid.Ingredient)
                        .ToListAsync();

                    foreach (var ingredientInDrink in ingredientsInDrink)
                    {
                        var ingredient = ingredientInDrink.Ingredient;
                        if (ingredient != null)
                        {
                            ingredient.Amount -= ingredientInDrink.Quantity * (double)drink.Quantity;
                            _dbContext.Entry(ingredient).State = EntityState.Modified;
                        }
                    }
                }

                // Save the order
                _dbContext.Orders.Add(order);
                await _dbContext.SaveChangesAsync();

                // return Ok(result);
                return Ok(new { succeeded = true, order = order, message = "Order/Bill created!" });
            }
            catch (Exception ex)
            {
                // await _unitOfWork.RollbackAsync();  // cancel the transaction
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }
        private double CalculateTotal(Order order)
        {
            double total = 0;

            if (order.OrderItems != null)
            {
                foreach (var orderItem in order.OrderItems)
                {
                    if (orderItem.Drink != null)
                    {
                        double price = orderItem.Drink.Price;
                        int quantity = orderItem.Quantity ?? 0;
                        total += price * quantity;
                    }
                }
            }

            return total;
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