namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DTOs;

    public interface IAnalyticService
    {
        Task<object> GetMonthlyRevenueStatus(string userId);
        Task<double> GetTotalRevenuePast10YearsWholeSystem();
        Task<object> GetTotalRevenuePast10YearsByUserId(string userId);
        Task<List<object>> GetLastMonthRevenueByDrinkType(string userId);
        Task<List<object>> GetCurrentMonthRevenueByDrinkType(string userId);
        Task<object> GetWeeklyRevenueStatus(string userId);
        Task<List<object>> GetDailyRevenueByDrinkTypeInRange(string userId, string drinkType,DateTime startDate, DateTime endDate);
        Task<List<DrinkDailyRevenueViewModel>> GetDailyDrinkRevenueInRange(string userId, string drinkType, string startDate, string endDate);
    }
}