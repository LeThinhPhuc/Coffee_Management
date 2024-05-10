namespace CoffeeShopApi.Services
{
    using Models.DAL;
    using Microsoft.EntityFrameworkCore;
    using Services.Interfaces;


    public class AnalyticService : IAnalyticService
    {
        private readonly AppDbContext _dbContext;

        public AnalyticService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<object> GetMonthlyRevenueStatus()
        {
            // Get the total revenue for the current month
            var currentDate = DateTime.UtcNow;
            var currentMonth = currentDate.Month;
            var currentYear = currentDate.Year;

            // err: DateTime?' does not contain a definition for 'Month' and no accessible extension method 'Month' accepting a first argument of type 'DateTime?' 
            // var currentMonthRevenue = await _dbContext.Orders
            //     .Where(o => o.OrderDate.Month == currentMonth && o.OrderDate.Year == currentYear)
            //     .SumAsync(o => o.Total);

            // fix:
            var currentMonthRevenue = await _dbContext.Orders
                .Where(o => o.OrderDate.HasValue && o.OrderDate.Value.Month == currentMonth && o.OrderDate.Value.Year == currentYear)
                .SumAsync(o => o.Total);

            // Get the total revenue for the previous month
            var previousMonth = currentMonth == 1 ? 12 : currentMonth - 1;
            var previousYear = currentMonth == 1 ? currentYear - 1 : currentYear;

            var previousMonthRevenue = await _dbContext.Orders
                .Where(o => o.OrderDate.HasValue && o.OrderDate.Value.Month == previousMonth && o.OrderDate.Value.Year == previousYear)
                .SumAsync(o => o.Total);


            // Calculate the percentage increase/decrease
            bool isIncrease = currentMonthRevenue > previousMonthRevenue;
            double percent = Math.Round((currentMonthRevenue - previousMonthRevenue) / (double)previousMonthRevenue * 100);


            // fix exception: System.ArgumentException: .NET number values such as positive and negative infinity cannot be written as valid JSON.
            // Check if percent is within the valid range
            if (double.IsNaN(percent) || double.IsInfinity(percent))
            {
                // If it's not within the valid range, set it to 0
                percent = 0;
            }

            return new
            {
                total = currentMonthRevenue,
                isIncrease,
                percent
            };
        }

        public async Task<double> GetTotalRevenuePast10YearsWholeSystem()
        {
            // Get the date 10 years ago from now
            var startDate = DateTime.UtcNow.AddYears(-10);

            // Get the total revenue for the past 10 years
            var totalRevenue = await _dbContext.Orders
                .Where(o => o.OrderDate.HasValue && o.OrderDate.Value >= startDate)
                .SumAsync(o => o.Total);

            return totalRevenue;
        }

        // public async Task<double> GetTotalRevenuePast10YearsByUserId(string userId)
        // {
        //     // Get the date 10 years ago from now
        //     var startDate = DateTime.UtcNow.AddYears(-10);

        //     // Get the total revenue for the past 10 years with the specified userId
        //     var totalRevenue = await _dbContext.Orders
        //         .Where(o => o.UserId == userId && o.OrderDate.HasValue && o.OrderDate.Value >= startDate)
        //         .SumAsync(o => o.Total);

        //     return totalRevenue;
        // }


        public async Task<object> GetTotalRevenuePast10YearsByUserId(string userId)
        {
            // Get the date 10 years ago from now
            var startDate = DateTime.UtcNow.AddYears(-10);

            // Get the total revenue for the past 10 years with the specified userId
            var totalRevenue = await _dbContext.Orders
                .Where(o => o.UserId == userId && o.OrderDate.HasValue && o.OrderDate.Value >= startDate)
                .SumAsync(o => o.Total);

            // Calculate the total in million VND (triệu VNĐ)
            var totalInMillion = totalRevenue / 1000000.0;

            // Return an object containing both raw and formatted total values
            return new
            {
                Total = totalRevenue,
                TotalInMillion = totalInMillion
            };
        }


        public async Task<List<object>> GetLastMonthRevenueByDrinkType()
        {
            // Lấy ngày đầu của tháng trước
            var startDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.AddMonths(-1).Month, 1);
            // Console.WriteLine("startDate: "+ startDate.ToString("dddd, dd/MM/yyyy - HH:mm"));

            // Lấy ngày cuối của tháng trước
            var endDate = startDate.AddMonths(1).AddDays(-1);
            // Console.WriteLine("endDate: "+ endDate.ToString("dddd, dd/MM/yyyy - HH:mm"));

            // * Terminal ouput:
            // startDate: Monday, 01/04/2024 - 00:00
            // endDate: Tuesday, 30/04/2024 - 00:00

            // Lấy tổng doanh thu trong tháng vừa qua theo tên loại đồ uống
            var monthlyRevenueByDrinkType = await _dbContext.OrderItems
                .Include(oi => oi.Drink)
                .Where(oi => oi.Order.OrderDate >= startDate && oi.Order.OrderDate <= endDate)
                .GroupBy(oi => oi.Drink.Name)
                .Select(g => new
                {
                    Type = g.Key,
                    Total = g.Sum(oi => oi.Quantity * oi.Drink.Price) / 1000000.0 // Chuyển đổi sang triệu VND
                })
                .ToListAsync();

            return monthlyRevenueByDrinkType.Cast<object>().ToList();
        }


        public async Task<List<object>> GetCurrentMonthRevenueByDrinkType()
        {
            // Lấy ngày đầu của tháng hiện tại
            var startDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);

            // Lấy ngày cuối của tháng hiện tại
            var endDate = DateTime.UtcNow;

            // Lấy tổng doanh thu trong tháng hiện tại theo tên loại đồ uống
            var monthlyRevenueByDrinkType = await _dbContext.OrderItems
                .Include(oi => oi.Drink)
                .Where(oi => oi.Order.OrderDate >= startDate && oi.Order.OrderDate <= endDate)
                .GroupBy(oi => oi.Drink.Name)
                .Select(g => new
                {
                    Type = g.Key,
                    Total = g.Sum(oi => oi.Quantity * oi.Drink.Price) / 1000000.0 // Chuyển đổi sang triệu VND
                })
                .ToListAsync();

            return monthlyRevenueByDrinkType.Cast<object>().ToList();
        }

    }
}
