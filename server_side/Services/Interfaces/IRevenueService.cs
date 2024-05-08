namespace CoffeeShopApi.Services.Interfaces
{
    public interface IRevenueService
    {
        Task<IEnumerable<object>> GetDailyRevenueInRangeAsync(DateTime startDate, DateTime endDate);

        Task<IEnumerable<object>> GetMonthlyRevenueByYearAsync(int year);
    }
}
