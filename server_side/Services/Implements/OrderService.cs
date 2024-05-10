namespace CoffeeShopApi.Services.Implements
{
    using Services.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models.DomainModels;
    using Models.DAL;
    using Models.DTOs;

    public class OrderService : IOrderService
    {

        private readonly AppDbContext _dbContext;

        public OrderService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<object>> GetAllOrderDetailedsAsync()
        {
            // return await Task.FromResult(_dbContext.Orders.AsEnumerable().ToList());

            
            // retrieve all related data from DB
            var query = _dbContext.Orders
                // .Where(o => o.Id == orderId) // for single record retrieval
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Drink)
                .Include(o => o.User)

                // create customized return object (Anonymous obj)
                .Select(o => new
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    CreatedBy = o.User.FullName,
                    Drinks = o.OrderItems.Select(oi => new
                    {
                        OrderId = oi.OrderId,
                        Id = oi.Id,
                        DrinkId = oi.Drink.Id,
                        DrinkName = oi.Drink.Name,
                        Price = oi.Drink.Price,
                        Quantity = oi.Quantity,
                    }).ToList(),
                    Total = o.OrderItems.Sum(oi => oi.Quantity * oi.Drink.Price)
                });

            var detailedOrders = await query.ToListAsync();
            return detailedOrders.Cast<object>().ToList();;
        }

        public async Task<object> GetDetailedOrderById(string orderId)
        {
            // retrieve all related data from DB
            var query = _dbContext.Orders
                .Where(o => o.Id == orderId)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Drink)
                .Include(o => o.User)

                // create customized return object (Anonymous obj)
                .Select(o => new
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    CreatedBy = o.User.FullName,
                    Drinks = o.OrderItems.Select(oi => new
                    {
                        OrderId = oi.OrderId,
                        Id = oi.Id,
                        DrinkId = oi.Drink.Id,
                        DrinkName = oi.Drink.Name,
                        Quantity = oi.Quantity,
                    }).ToList(),
                    Total = o.OrderItems.Sum(oi => oi.Quantity * oi.Drink.Price)
                });

            var detailedOrder = await query.SingleOrDefaultAsync();
            return detailedOrder;
        }

        //*
        public async Task<Order> CreateOrder(CreateUpdatOrderModel createOrderModel, string userId)
        {
            // Create a new order
            Order order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now,
                Total = CalculateTotal(createOrderModel.Drinks),
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

            // Save the order
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }

        /*
        public async Task<bool> DeleteOrderAsync(string id)
        {
            var order = await _unitOfWork.Orders.GetByIdAsync(id);

            if (order == null)
            {
                throw new NotFoundException("Order not found");
            }

            // delete the Order
            _unitOfWork.Orders.Delete(order);

            // Retrieve the order items associated with the order
            var orderItems = _unitOfWork.OrderItems
                .GetAll()
                .Where(oi => oi.OrderId == order.Id)
                .ToList();

            // Delete the related order items
            foreach (var orderItem in orderItems)
            {
                _unitOfWork.OrderItems.Delete(orderItem);
            }

            await _unitOfWork.SaveEntitiesAsync();

            return true;
        }
        public async Task<bool> DeleteAllOrdersAsync()
        {
            var orders = await GetAllOrdersAsync();

            foreach (var order in orders)
            {
                _unitOfWork.Orders.Delete(order);
            }

            await _unitOfWork.SaveEntitiesAsync();

            return true;
        }
        */

        private double CalculateTotal(List<DrinkOrderModel> drinkOrders)
        {
            double total = 0;


            // TODO: find price by id
            foreach (var drinkOrder in drinkOrders)
            {
                // double price = drinkOrder.Price;
                double price = 28000;
                int quantity = drinkOrder.Quantity;
                total += price * quantity;
            }

            return total;
        }
        
    }
}