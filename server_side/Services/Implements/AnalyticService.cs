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

        /* 
        // Wrong
        public async Task<object> GetMonthlyRevenueStatus()
        {
            // Get the total revenue for the current month
            var currentDate = DateTime.UtcNow;
            var currentMonth = currentDate.Month;
            var currentYear = currentDate.Year;

            Console.WriteLine("currentDate: "+ currentDate.ToString("dddd, dd/MM/yyyy - HH:mm"));
            Console.WriteLine("currentMonth: "+ currentMonth.ToString());
            

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

            Console.WriteLine("previousMonth: "+ previousMonth.ToString());
            Console.WriteLine("previousYear: "+ previousYear.ToString());

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
        */


        public async Task<object> GetMonthlyRevenueStatus()
        {
            // Get the date range for the before previous month (if now is May, takes April)
            var startDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.AddMonths(-1).Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            // Console.WriteLine("startDate: " + startDate.ToString("dddd, dd/MM/yyyy - HH:mm"));
            // Console.WriteLine("endDate: " + endDate.ToString("dddd, dd/MM/yyyy - HH:mm"));

            // * terminal output:
            // startDate: Friday, 01/03/2024 - 00:00
            // endDate: Sunday, 31/03/2024 - 00:00


            // Calculate the total revenue for the previous month
            var totalRevenuePreviousMonth = await _dbContext.Orders
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .SumAsync(o => o.Total);

            // Get the date range for the month before the previous month
            var startDatePreviousMonth = startDate.AddMonths(-1);
            var endDatePreviousMonth = endDate.AddMonths(-1);

            // Console.WriteLine("startDatePreviousMonth: " + startDatePreviousMonth.ToString("dddd, dd/MM/yyyy - HH:mm"));
            // Console.WriteLine("endDatePreviousMonth: " + endDatePreviousMonth.ToString("dddd, dd/MM/yyyy - HH:mm"));

            // Calculate the total revenue for the month before the previous month
            var totalRevenueMonthBeforePreviousMonth = await _dbContext.Orders
                .Where(o => o.OrderDate >= startDatePreviousMonth && o.OrderDate <= endDatePreviousMonth)
                .SumAsync(o => o.Total);

            // Calculate whether the revenue increased compared to the previous month
            var isIncrease = totalRevenuePreviousMonth > totalRevenueMonthBeforePreviousMonth;

            // Calculate the percentage change
            double percent = 0;
            if (totalRevenueMonthBeforePreviousMonth != 0)
            {
                percent = Math.Round((totalRevenuePreviousMonth - totalRevenueMonthBeforePreviousMonth) / totalRevenueMonthBeforePreviousMonth * 100, 2);
            }
            else
            {
                // Set a default value indicating that the percentage change couldn't be calculated
                percent = -1; // or any other suitable value
            }

            // Create the result object
            var result = new
            {
                total = totalRevenuePreviousMonth / 1000000.0, // Convert to million VND
                isIncrease,
                percent
            };

            return result;
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
                    .ThenInclude(d => d.DrinkType)  // join tiếp đến bảng liền kề (OrderItem ko liền kề vs DrinkType)
                .Where(oi => oi.Order.OrderDate >= startDate && oi.Order.OrderDate <= endDate)
                .GroupBy(oi => oi.Drink.DrinkType.Name)
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
                    .ThenInclude(d => d.DrinkType)  // join tiếp đến bảng liền kề (OrderItem ko liền kề vs DrinkType)
                .Where(oi => oi.Order.OrderDate >= startDate && oi.Order.OrderDate <= endDate)
                .GroupBy(oi => oi.Drink.DrinkType.Name)
                .Select(g => new
                {
                    Type = g.Key,
                    Total = g.Sum(oi => oi.Quantity * oi.Drink.Price) / 1000000.0 // Chuyển đổi sang triệu VND
                })
                .ToListAsync();

            return monthlyRevenueByDrinkType.Cast<object>().ToList();
        }
        public async Task<object> GetWeeklyRevenueStatus()
        {
            // Get the start and end dates for the current week
            var currentDate = DateTime.UtcNow.Date;
            var startDate = currentDate.AddDays(-(int)currentDate.DayOfWeek); // Start of the week (Sunday)
            var endDate = startDate.AddDays(6); // End of the week (Saturday)

            // If today is not the end of the week, consider the previous week for comparison
            if (currentDate < endDate)
            {
                startDate = startDate.AddDays(-7);
                endDate = endDate.AddDays(-7);
            }

            var totalRevenuePreviousMonth = await _dbContext.Orders
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .SumAsync(o => o.Total);

            // Get the date range for the month before the previous month
            var startDatePreviousMonth = startDate.AddMonths(-1);
            var endDatePreviousMonth = endDate.AddMonths(-1);

            // Calculate the total revenue for the month before the previous month
            var totalRevenueMonthBeforePreviousMonth = await _dbContext.Orders
                .Where(o => o.OrderDate >= startDatePreviousMonth && o.OrderDate <= endDatePreviousMonth)
                .SumAsync(o => o.Total);

            // Calculate whether the revenue increased compared to the previous month
            var isIncrease = totalRevenuePreviousMonth > totalRevenueMonthBeforePreviousMonth;

            // Calculate the percentage change
            double percent = 0;
            if (totalRevenueMonthBeforePreviousMonth != 0)
            {
                percent = Math.Round((totalRevenuePreviousMonth - totalRevenueMonthBeforePreviousMonth) / totalRevenueMonthBeforePreviousMonth * 100, 2);
            }
            else
            {
                // Set a default value indicating that the percentage change couldn't be calculated
                percent = -1; // or any other suitable value
            }

            // Create the result object
            var result = new
            {
                total = totalRevenuePreviousMonth / 1000000.0, // Convert to million VND
                isIncrease,
                percent
            };

            return result;
        }
       
    }
}
