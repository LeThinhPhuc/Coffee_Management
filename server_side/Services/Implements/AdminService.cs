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


            // Our database initial failure: Order should have ShopId relationship,
            // or User should only own 1 Shop.!

            // This did not calculate the total Revenue of each Shop record
            /*
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
                Revenue = s.Revenue,        // not calculated (= 0)
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
            */


            // Map the Shop entities to ShopAdminViewModel
            var shopViewModels = new List<ShopAdminViewModel>();

            foreach (var shop in shops)
            {
                // Calculate the revenue for the shop
                var totalRevenue = await _dbContext.Orders
                    // .Where(o => o.ShopId == shop.Id)
                    .Where(o => o.UserId == shop.OwnerId)
                    .SumAsync(o => o.Total);

                // Create ShopAdminViewModel and add it to the list
                var shopViewModel = new ShopAdminViewModel
                {
                    Id = shop.Id,
                    Name = shop.Name,
                    Address = shop.Address,
                    OwnerId = shop.OwnerId,
                    OwnerFullName = shop.Owner?.FullName,
                    IsApproved = shop.IsApproved,
                    IsSuspended = shop.IsSuspended,
                    SuspensionEndDate = shop.SuspensionEndDate,
                    FormattedDateCreated = shop.DateCreated.ToString("dddd, dd/MM/yyyy - HH:mm"),
                    FormattedDateModified = shop.DateModified.ToString("dddd, dd/MM/yyyy - HH:mm"),
                    Revenue = totalRevenue / 1000000.0, // Convert to million VND
                    DrinkTypes = shop.DrinkTypes?.Select(dt => new DrinkTypeViewModel
                    {
                        Id = dt.Id,
                        Name = dt.Name,
                    }).ToList(),
                    VoucherCodes = shop.VoucherCodes?.Select(vc => new MinimalVoucherCodeViewModel
                    {
                        Id = vc.Id,
                        Code = vc.Name,
                        DiscountPercent = (double)vc.DiscountPercent
                    }).ToList()
                };

                shopViewModels.Add(shopViewModel);
            }

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

        public async Task<SuspenseResult> SuspenseShopAsync(string shopId)
        {
            try
            {
                // Retrieve the shop from the database
                var shop = await _dbContext.Shops.FirstOrDefaultAsync(s => s.Id == shopId);

                if (shop != null)
                {
                    // Update the IsSuspended property
                    shop.IsSuspended = !shop.IsSuspended;

                    // suspense for 7 days (just logic, not deeply implement mechanism yet! )
                    shop.SuspensionEndDate = DateTime.Now.AddDays(7);

                    // Save the changes to the database
                    await _dbContext.SaveChangesAsync();

                    return new SuspenseResult
                    {
                        Succeeded = true,
                        IsSuspended = shop.IsSuspended
                    };
                }
                else
                {
                    
                    List<object> errors = new List<object>
                    {
                        // user's provided password doesnt match any record in DB
                        new
                        {
                            code = "ShopNotFound",
                            description = "No Shop found by provided Id. Please double check!"
                        }
                    };

                    return new SuspenseResult 
                    {
                        Succeeded = false,
                        Errors = errors.ToArray()
                    };
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error approving shop: {ex.Message}");

                List<object> errors = new List<object>
                {
                    // user's provided password doesnt match any record in DB
                    new
                    {
                        code = "ExceptionCaught",
                        message = ex.Message
                    }
                };

                return new SuspenseResult 
                {
                    Succeeded = false,
                    Errors = errors.ToArray()
                };
                
            }
        }
    }
}
