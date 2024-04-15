namespace CoffeeShopApi.Repositories.Implements
{
    using Models.DAL;
    using Microsoft.EntityFrameworkCore;
    using Repositories.Interfaces;


    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private bool _disposed = false;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            // Drinks = new DrinkRepository(_context);
            // DrinkTypes = new DrinkTypeRepository(_context);
            // Orders = new OrderRepository(_context);
            // OrderItems = new OrderItemRepository(_context);
        }

        // public IDrinkRepository Drinks { get; }

        // public IDrinkTypeRepository DrinkTypes { get; }

        // public IOrderRepository Orders { get; }

        // public IOrderItemRepository OrderItems { get; }

        // public IFeedbackRepository Feedback { get; }


        // Commit all changes to database:
        public async Task<Object> SaveEntitiesAsync()
        {
            try
            {
                int rowsAffected = await _context.SaveChangesAsync(); // returns the number of rows (entities) affected by the database operation
                if (rowsAffected > 0)
                {
                    // Success: Rows were affected in the database
                    return new
                    {
                        success = true,
                        rowsAffected = rowsAffected
                    };
                }
                else
                {
                    // Failure: No rows were affected in the database
                    return new
                    {
                        success = false,
                        rowsAffected = rowsAffected
                    };
                }
            }
            catch (Exception ex)
            {
                // Exception occurred while saving changes
                // Handle the exception appropriately
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }


        public void Rollback()
        {
            // Rollback anything, if necessary
            //return Task.CompletedTask;

            try
            {
                // Get all modified or added entities in the current transaction
                var modifiedEntities = _context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added)
                    .ToList();

                // Reset the state of each entity to its original values
                foreach (var entity in modifiedEntities)
                {
                    entity.State = EntityState.Unchanged;
                }

                // Discard any entities that were marked for deletion
                var deletedEntities = _context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Deleted)
                    .ToList();

                foreach (var entity in deletedEntities)
                {
                    entity.State = EntityState.Unchanged;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        //  handle exceptions internally and return a success or failure status,
        //  we can change the return type to Task<bool> or Task<Object>
        //  as we did in the SaveEntitiesAsync method above
        public async Task<bool> RollbackAsync()
        {
            try
            {
                // Get all modified or added entities in the current transaction
                var modifiedEntities = _context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added)
                    .ToList();

                // Reset the state of each entity to its original values
                foreach (var entity in modifiedEntities)
                {
                    entity.State = EntityState.Unchanged;
                }

                // Discard any entities that were marked for deletion
                var deletedEntities = _context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Deleted)
                    .ToList();

                foreach (var entity in deletedEntities)
                {
                    entity.State = EntityState.Unchanged;
                }

                // Save the changes to the database
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}