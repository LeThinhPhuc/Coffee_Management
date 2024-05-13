namespace CoffeeShopApi.Services.Implements
{
    using Models.DTOs;
    using Exceptions;
    using Repositories.Interfaces;
    using Services.Interfaces;
    using Models.DomainModels;
    using Models.DAL;
    using Microsoft.EntityFrameworkCore;

    public class ShopService : IShopService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _dbContext;

        public ShopService(AppDbContext dbContext,
            IUnitOfWork unitOfWork
        )
        {
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
            // _memoryCache = memoryCache;
        }

        public List<Shop> GetAllShops()
        {
            return _dbContext.Shops
                .OrderByDescending(d => d.DateModified)
                .ToList();
        }

        public async Task<List<ShopViewModel>> GetAllShopsClientAsync()
        {
            // This approach allows "null propagating operator"
            var shops = await Task.FromResult(_dbContext.Shops.Include(s => s.Owner).AsEnumerable());

            var listShopsViewModel = shops.Select(d => new ShopViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Address = d.Address,
                OwnerId = d.OwnerId,
                IsSuspended = d.IsSuspended,
                FormattedSuspensionEndDate = d.SuspensionEndDate?.ToString("dddd, dd/MM/yyyy - HH:mm"),
                FormattedDateCreated = d.DateCreated.ToString("dddd, dd/MM/yyyy - HH:mm"),
                FormattedDateModified = d.DateModified.ToString("dddd, dd/MM/yyyy - HH:mm"),
                Revenue = d.Revenue,
                OwnerFullName = d.Owner.FullName
            }).ToList();

            // LinQ expression approach
            // ERR: "An expression tree lambda may not contain a null propagating operator."
            // at line   "d.SuspensionEndDate?.ToString("dddd, dd/MM/yyyy - HH:mm")"
            // var shops = await _dbContext.Shops
            //         .Include(s => s.Owner)
            //         .Select(d => new ShopViewModel
            //         {
            //             Id = d.Id,
            //             Name = d.Name,
            //             Address = d.Address,
            //             OwnerId = d.OwnerId,
            //             IsSuspended = d.IsSuspended,
            //             FormattedSuspensionEndDate = d.SuspensionEndDate.HasValue ? d.SuspensionEndDate?.ToString("dddd, dd/MM/yyyy - HH:mm") : null,
            //             FormattedDateCreated = d.DateCreated.ToString("dddd, dd/MM/yyyy - HH:mm"),
            //             FormattedDateModified = d.DateModified.ToString("dddd, dd/MM/yyyy - HH:mm"),
            //             Revenue = d.Revenue,
            //             OwnerFullName = d.Owner.FullName
            //         })
            //         .ToListAsync();
            return listShopsViewModel;
        }

        
        public async Task<Shop> GetShopByIdAsync(string id)
        {
            return await _dbContext.Shops.FindAsync(id);
        }

        
    }
}
