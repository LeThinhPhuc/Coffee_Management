using CoffeeShopApi.Models.DAL;
using CoffeeShopApi.Models.DomainModels;
using CoffeeShopApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
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
        //public async Task<IEnumerable<object>> GetDailyRevenueInRangeAsync(DateTime startDate, DateTime endDate)
        //{

        //    var dailyRevenue = await context.Orders
        //        .Where(o => startDate.Date <= o.OrderDate.Value.Date && o.OrderDate.Value.Date <= endDate.Date)
        //        .GroupBy(o => o.OrderDate.Value.Date)
        //        .Select(group => new
        //        {
        //            Date = group.Key,
        //            revenue = group.Sum(o => o.Total) / 1000000.0
        //        })
        //        .ToListAsync();

        //    if (dailyRevenue.Count == 0)
        //    {
        //        return null;
        //    }

        //    return dailyRevenue;
        //}
        public async Task<IEnumerable<object>> GetDailyRevenueInRangeAsync(DateTime startDate, DateTime endDate)
        {
            // Generate all dates within the range
            var allDates = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                     .Select(offset => startDate.AddDays(offset).Date)
                                     .ToList();

            // Fetch the daily revenue from the database
            var dailyRevenue = await context.Orders
                .Where(o => startDate.Date <= o.OrderDate.Value.Date && o.OrderDate.Value.Date <= endDate.Date)
                .GroupBy(o => o.OrderDate.Value.Date)
                .Select(group => new
                {
                    Date = group.Key,
                    Revenue = group.Sum(o => o.Total) / 1000000.0
                })
                .ToListAsync();

            // Join the generated dates with the daily revenue data
            var result = allDates
                .GroupJoin(
                    dailyRevenue,
                    date => date,
                    revenue => revenue.Date,
                    (date, revenueGroup) => new
                    {
                        Date = date,
                        Revenue = revenueGroup.FirstOrDefault()?.Revenue ?? 0.0
                    })
                .ToList();

            return result;
        }



        //public async Task<IEnumerable<object>> GetMonthlyRevenueByYearAsync(int year)
        //{
        //    var monthlyRevenueByYear = await context.Orders
        //        .Where(o => o.OrderDate.Value.Year == year)
        //        .GroupBy(o => new { o.OrderDate.Value.Year, o.OrderDate.Value.Month })
        //        .Select(group => new
        //        {
        //            Year = group.Key.Year,
        //            Month = group.Key.Month,
        //            Revenue = group.Sum(o => o.Total) / 1000000.0
        //        })
        //        .ToListAsync();

        //    if (monthlyRevenueByYear == null  && monthlyRevenueByYear.Count == 0)
        //    {
        //        return null;
        //    }

        //    return monthlyRevenueByYear;
        //}

        public async Task<IEnumerable<object>> GetMonthlyRevenueByYearAsync(int year)
        {
            // Generate all months for the specified year
            var allMonths = Enumerable.Range(1, 12).Select(month => new { Year = year, Month = month }).ToList();

            // Fetch the monthly revenue from the database
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

            // Join the generated months with the monthly revenue data
            var result = allMonths
                .GroupJoin(
                    monthlyRevenueByYear,
                    month => new { month.Year, month.Month },
                    revenue => new { revenue.Year, revenue.Month },
                    (month, revenueGroup) => new
                    {
                        Year = month.Year,
                        Month = month.Month,
                        Revenue = revenueGroup.FirstOrDefault()?.Revenue ?? 0.0
                    })
                .ToList();


            return result;
        }



    }
}
