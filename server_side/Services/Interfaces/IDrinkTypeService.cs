namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DomainModels;
    using Models.DTOs;

    public interface IDrinkTypeService
    {
        Task<List<DrinkType>> GetAllDrinkTypesAsync();
        Task<List<DrinkType>> GetAllDrinkTypesByShopOwnerIdAsync(string ownerId);
        Task<DrinkType> GetDrinkTypeByIdAsync(string id);
        Task<bool> AddDrinkTypeAsync(CreateUpdateDrinkTypeModel model);
        Task<bool> UpdateDrinkTypeAsync(CreateUpdateDrinkTypeModel model);
        Task<bool> DeleteDrinkTypeAsync(string id);
        Task<bool> DeleteAllDrinkTypesAsync();
    }
}