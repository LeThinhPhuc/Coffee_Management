namespace CoffeeShopApi.Services.Implements
{
    using Models.DTOs;
    using Exceptions;
    using Repositories.Interfaces;
    using Services.Interfaces;
    using Models.DAL;
    using Microsoft.EntityFrameworkCore;

    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _dbContext;

        public AdminService(AppDbContext dbContext,
            IUnitOfWork unitOfWork
        )
        {
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
            // _memoryCache = memoryCache;
        }

        public async Task<List<ShopAdminViewModel>> GetAllShops()
        {
            var shops = await _dbContext.Shops
                .Include(s => s.Owner) // Include the Owner navigation property
                .Include(s => s.DrinkTypes) // Include the DrinkTypes navigation property
                .Include(s => s.VoucherCodes) // Include the VoucherCodes navigation property
                .ToListAsync();

            // Map the Shop entities to ShopAdminViewModel
            var shopViewModels = shops.Select(s => new ShopAdminViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                OwnerId = s.OwnerId,
                OwnerFullName = s.Owner?.FullName, // Map Owner's FullName
                IsApproved = s.IsApproved,
                IsSuspended = s.IsSuspended,
                SuspensionEndDate = s.SuspensionEndDate,
                Revenue = s.Revenue,
                DrinkTypes = s.DrinkTypes?.Select(dt => new DrinkTypeViewModel
                {
                    Id = dt.Id,
                    Name = dt.Name,
                }).ToList(),
                VoucherCodes = s.VoucherCodes?.Select(vc => new MinimalVoucherCodeViewModel
                {
                    Id = vc.Id,
                    Code = vc.Name,
                    DiscountPercent = (double)vc.DiscountPercent    // explicit cast for nullable
                }).ToList()
            }).ToList();

            return shopViewModels;
        }

        public async Task<bool> ApproveShopAsync(string shopId)
        {
            try
            {
                // Retrieve the shop from the database
                var shop = await _dbContext.Shops.FirstOrDefaultAsync(s => s.Id == shopId);

                if (shop != null)
                {
                    // Update the IsApproved property
                    shop.IsApproved = true;

                    // Save the changes to the database
                    await _dbContext.SaveChangesAsync();

                    return true; // Shop successfully approved
                }
                else
                {
                    return false; // Shop not found
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error approving shop: {ex.Message}");
                return false; // Error occurred while approving shop
            }

        }
    }
}
