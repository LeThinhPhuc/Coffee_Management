namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DTOs;

    public interface IAnalyticService
    {
        Task<object> GetMonthlyRevenueStatus();
        Task<double> GetTotalRevenuePast10Years();
        Task<double> GetTotalRevenuePast10YearsByUserId(string userId);
    }
}