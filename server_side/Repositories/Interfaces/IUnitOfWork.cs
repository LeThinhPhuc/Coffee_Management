namespace CoffeeShopApi.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // IDrinkRepository Drinks { get; }
        // IDrinkTypeRepository DrinkTypes { get; }
        // IOrderRepository Orders { get; }
        // IOrderItemRepository OrderItems { get; }
        Task<Object> SaveEntitiesAsync();
        void Rollback();
        Task<bool> RollbackAsync(); // with status as return
    }
}