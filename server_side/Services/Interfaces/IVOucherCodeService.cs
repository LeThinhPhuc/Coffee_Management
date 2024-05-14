namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DomainModels;
    using Models.DTOs;

    public interface IVoucherCodeService {
        Task<List<VoucherCodeViewModel>> GetAllVoucherCodesAsync();
        Task<List<VoucherCodeViewModel>> GetAllVoucherCodesByShopOwnerIdAsync(string ownerId);
        Task<VoucherCodeViewModel> GetVoucherCodeByIdAsync(string id);
        Task<bool> AddVoucherCodeAsync(CreateUpdateVoucherCodeModel model);
        Task<bool> UpdateVoucherCodeAsync(CreateUpdateVoucherCodeModel model);
        Task<bool> DeleteVoucherCodeAsync(string id);
        Task<bool> DeleteAllVoucherCodesAsync();
    }
}