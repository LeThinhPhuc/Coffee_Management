namespace CoffeeShopApi.Services.Interfaces
{
    public interface IRevenueService
    {
        Task<IEnumerable<object>> GetDailyRevenueInRageAsync(DateTime startDate, DateTime endDate);
    }
}
