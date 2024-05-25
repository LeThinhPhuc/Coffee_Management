namespace CoffeeShopApi.Services.Interfaces
{
    public interface IRevenueService
    {
        Task<IEnumerable<object>> GetDailyRevenueInRangeAsync(DateTime startDate, DateTime endDate,string userId);

        Task<IEnumerable<object>> GetMonthlyRevenueByYearAsync(int year,string userId);
    }
}
