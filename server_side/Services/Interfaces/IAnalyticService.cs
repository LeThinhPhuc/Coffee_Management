namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DTOs;

    public interface IAnalyticService
    {
        Task<object> GetMonthlyRevenueStatus();
        Task<double> GetTotalRevenuePast10YearsWholeSystem();
        Task<object> GetTotalRevenuePast10YearsByUserId(string userId);
        Task<List<object>> GetLastMonthRevenueByDrinkType();
        Task<List<object>> GetCurrentMonthRevenueByDrinkType();
        Task<object> GetWeeklyRevenueStatus();
    }
}