namespace CoffeeShopApi.Services.Implements
{
    using Models.DomainModels;
    using Models.DTOs;
    using Models.DAL;
    using Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Exceptions;
    using Microsoft.EntityFrameworkCore;

    public class VoucherCodeService : IVoucherCodeService
    {
        private readonly AppDbContext _dbContext;

        public VoucherCodeService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<VoucherCodeViewModel>> GetAllVoucherCodesAsync()
        {
            var voucherCodes = await Task.FromResult(_dbContext.VoucherCodes
                .OrderByDescending(vc => vc.DateCreated)
                .Select(vc => new VoucherCodeViewModel
                {
                    Id = vc.Id,
                    Name = vc.Name,
                    DiscountPercent = vc.DiscountPercent,
                    ShopId = vc.ShopId,
                    IsActive = vc.EndDate >= DateTime.Now,
                    StartDate = vc.StartDate,
                    EndDate = vc.EndDate,
                    FormattedStartDate = vc.StartDate.ToString("dddd, dd/MM/yyyy - HH:mm"),
                    FormattedEndDate = vc.EndDate.ToString("dddd, dd/MM/yyyy - HH:mm"),
                    DateCreated = vc.DateCreated,
                    DateModified = vc.DateModified,
                })
                .ToList());

            return voucherCodes;
        }

        public async Task<List<VoucherCodeViewModel>> GetAllVoucherCodesByShopOwnerIdAsync(string ownerId)
        {
            var voucherCodes = await Task.FromResult(_dbContext.VoucherCodes
                .Include(vc => vc.Shop)
                    .ThenInclude(s => s.Owner)
                .Where(vc => vc.Shop.OwnerId == ownerId)    // filter by Shop -> Owner's Id
                .OrderByDescending(vc => vc.DateCreated)
                .Select(vc => new VoucherCodeViewModel
                {
                    Id = vc.Id,
                    Name = vc.Name,
                    DiscountPercent = vc.DiscountPercent,
                    ShopId = vc.ShopId,
                    IsActive = vc.EndDate >= DateTime.Now,
                    StartDate = vc.StartDate,
                    EndDate = vc.EndDate,
                    FormattedStartDate = vc.StartDate.ToString("dddd, dd/MM/yyyy - HH:mm"),
                    FormattedEndDate = vc.EndDate.ToString("dddd, dd/MM/yyyy - HH:mm"),
                    DateCreated = vc.DateCreated,
                    DateModified = vc.DateModified,
                })
                .ToList());

            return voucherCodes;
        }

        public async Task<VoucherCodeViewModel> GetVoucherCodeByIdAsync(string id)
        {
            var voucherCode = await _dbContext.VoucherCodes.FindAsync(id);

            if (voucherCode == null)
            {
                throw new NotFoundException("Voucher code not found");
            }

            var voucherCodeViewModel = new VoucherCodeViewModel
            {
                Id = voucherCode.Id,
                Name = voucherCode.Name,
                DiscountPercent = voucherCode.DiscountPercent,
                ShopId = voucherCode.ShopId,
                IsActive = voucherCode.EndDate >= DateTime.Now,
                FormattedStartDate = voucherCode.EndDate.ToString("HH:mm dddd, dd/MM/yyyy"),
                FormattedEndDate = voucherCode.EndDate.ToString("HH:mm dddd, dd/MM/yyyy")
            };

            return voucherCodeViewModel;
        }

        public async Task<bool> AddVoucherCodeAsync(CreateUpdateVoucherCodeModel model)
        {
            var voucherCode = new VoucherCode
            {
                Name = model.Name,
                DiscountPercent = model.DiscountPercent,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                ShopId = model.ShopId
            };

            _dbContext.VoucherCodes.Add(voucherCode);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateVoucherCodeAsync(CreateUpdateVoucherCodeModel model)
        {
            var voucherCode = await _dbContext.VoucherCodes.FindAsync(model.Id);

            if (voucherCode == null)
            {
                throw new NotFoundException("Voucher code not found");
            }

            voucherCode.Name = model.Name;
            voucherCode.DiscountPercent = model.DiscountPercent;
            voucherCode.StartDate = model.StartDate;
            voucherCode.EndDate = model.EndDate;
            voucherCode.ShopId = model.ShopId;

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteVoucherCodeAsync(string id)
        {
            var voucherCode = await _dbContext.VoucherCodes.FindAsync(id);

            if (voucherCode == null)
            {
                throw new NotFoundException("Voucher code not found");
            }

            _dbContext.VoucherCodes.Remove(voucherCode);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAllVoucherCodesAsync()
        {
            var voucherCodes = await Task.FromResult(_dbContext.VoucherCodes.AsEnumerable());

            _dbContext.VoucherCodes.RemoveRange(voucherCodes);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
