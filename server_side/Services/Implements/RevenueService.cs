using CoffeeShopApi.Models.DAL;
using CoffeeShopApi.Models.DomainModels;
using CoffeeShopApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopApi.Services.Implements
{
    public class RevenueService : IRevenueService
    {
        private AppDbContext context;

        public RevenueService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<object>> GetDailyRevenueInRageAsync(DateTime startDate, DateTime endDate)
        {
            var dailyRevenue = await context.Orders
                .Where(o => startDate.Date <= o.DateCreated.Date && o.DateCreated.Date <= endDate.Date)
                .GroupBy(o => o.DateCreated.Date) // Group theo ngày, không cần phải group theo DateTime đầy đủ
                .Select(group => new
                {
                    Date = group.Key,
                    TotalRevenueOnDay = group.Sum(o => o.Total)
                })
                .ToListAsync();

            if(dailyRevenue.Count == 0)
            {
                return null;
            }


            return dailyRevenue;
        }

    }
}
