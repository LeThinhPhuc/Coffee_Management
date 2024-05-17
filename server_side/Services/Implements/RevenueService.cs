using CoffeeShopApi.Models.DAL;
using CoffeeShopApi.Models.DomainModels;
using CoffeeShopApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CoffeeShopApi.Services.Implements
{
    public class RevenueService : IRevenueService
    {
        private AppDbContext context;

        public RevenueService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<object>> GetDailyRevenueInRangeAsync(DateTime startDate, DateTime endDate)
        {

            var dailyRevenue = await context.Orders
                .Where(o => startDate.Date <= o.OrderDate.Value.Date && o.OrderDate.Value.Date <= endDate.Date)
                .GroupBy(o => o.OrderDate.Value.Date)
                .Select(group => new
                {
                    Date = group.Key,
                    revenue = group.Sum(o => o.Total) / 1000000.0
                })
                .ToListAsync();

            if (dailyRevenue.Count == 0)
            {
                return null;
            }

            return dailyRevenue;
        }


        public async Task<IEnumerable<object>> GetMonthlyRevenueByYearAsync(int year)
        {
            var monthlyRevenueByYear = await context.Orders
                .Where(o => o.OrderDate.Value.Year == year)
                .GroupBy(o => new { o.OrderDate.Value.Year, o.OrderDate.Value.Month })
                .Select(group => new
                {
                    Year = group.Key.Year,
                    Month = group.Key.Month,
                    Revenue = group.Sum(o => o.Total) / 1000000.0
                })
                .ToListAsync();
            
            if (monthlyRevenueByYear == null  && monthlyRevenueByYear.Count == 0)
            {
                return null;
            }

            return monthlyRevenueByYear;
        }


    }
}
