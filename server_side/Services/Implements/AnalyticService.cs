namespace CoffeeShopApi.Services
{
    using Models.DAL;
    using Microsoft.EntityFrameworkCore;
    using Services.Interfaces;
    using CoffeeShopApi.Models.DTOs;

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


        public async Task<object> GetMonthlyRevenueStatus(string userId)
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
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate
                        // filter by userId (assuming eacher user only has 1 Shop)
                        && o.UserId == userId)
                .SumAsync(o => o.Total);

            // Get the date range for the month before the previous month
            var startDatePreviousMonth = startDate.AddMonths(-1);
            var endDatePreviousMonth = endDate.AddMonths(-1);

            // Console.WriteLine("startDatePreviousMonth: " + startDatePreviousMonth.ToString("dddd, dd/MM/yyyy - HH:mm"));
            // Console.WriteLine("endDatePreviousMonth: " + endDatePreviousMonth.ToString("dddd, dd/MM/yyyy - HH:mm"));

            // Calculate the total revenue for the month before the previous month
            var totalRevenueMonthBeforePreviousMonth = await _dbContext.Orders
                .Where(o => o.OrderDate >= startDatePreviousMonth && o.OrderDate <= endDatePreviousMonth
                        // filter by userId (assuming eacher user only has 1 Shop)
                        && o.UserId == userId)
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


        public async Task<List<object>> GetLastMonthRevenueByDrinkType(string userId)
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
                .Where(oi => oi.Order.OrderDate >= startDate && oi.Order.OrderDate <= endDate
                    // filter by userId (assuming eacher user only has 1 Shop)
                    && oi.Order.UserId == userId)
                .GroupBy(oi => oi.Drink.DrinkType.Name)
                .Select(g => new
                {
                    Type = g.Key,
                    Total = g.Sum(oi => oi.Quantity * oi.Drink.Price) / 1000000.0 // Chuyển đổi sang triệu VND
                })
                .ToListAsync();

            return monthlyRevenueByDrinkType.Cast<object>().ToList();
        }


        public async Task<List<object>> GetCurrentMonthRevenueByDrinkType(string userId)
        {
            // Lấy ngày đầu của tháng hiện tại
            var startDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);

            // Lấy ngày cuối của tháng hiện tại
            var endDate = startDate.AddMonths(1).AddDays(-1);

            // Lấy tổng doanh thu trong tháng hiện tại theo tên loại đồ uống
            var monthlyRevenueByDrinkType = await _dbContext.OrderItems
                .Include(oi => oi.Drink)
                    .ThenInclude(d => d.DrinkType)  // join tiếp đến bảng liền kề (OrderItem ko liền kề vs DrinkType)
                .Where(oi => oi.Order.OrderDate >= startDate && oi.Order.OrderDate <= endDate
                    // filter by userId (assuming eacher user only has 1 Shop)
                    && oi.Order.UserId == userId)
                .GroupBy(oi => oi.Drink.DrinkType.Name)
                .Select(g => new
                {
                    Type = g.Key,
                    Total = g.Sum(oi => oi.Quantity * oi.Drink.Price) / 1000000.0 // Chuyển đổi sang triệu VND
                })
                .ToListAsync();

            return monthlyRevenueByDrinkType.Cast<object>().ToList();
        }

        public async Task<object> GetWeeklyRevenueStatus(string userId)
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
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate
                    // filter by userId (assuming eacher user only has 1 Shop)
                    && o.UserId == userId)
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

        public async Task<List<object>> GetDailyRevenueByDrinkTypeInRange(string userId, string drinkType, DateTime startDate, DateTime endDate)
        {
            // Check whether the input date range is valid, if not, throw the error
            if (startDate >= endDate)
            {
                throw new ArgumentException("End date must be greater than start date.");
            }

            // Get daily revenue by drink type and date range
            var dailyRevenueByDrinkType = await _dbContext.OrderItems
                .Include(oi => oi.Drink)
                    .ThenInclude(d => d.DrinkType)
                .Where(oi => oi.Order.OrderDate >= startDate && oi.Order.OrderDate <= endDate &&
                            // Filter by drinkType
                            oi.Drink.DrinkType.Name == drinkType
                            // filter by userId (assuming eacher user only has 1 Shop)
                            && oi.Order.UserId == userId)  
                .GroupBy(oi => oi.Order.OrderDate.Value.Date) // Group by date only
                .Select(g => new
                {
                    Date = g.Key.ToString("yyyy-MM-dd"), // Format date as string
                    Total = g.Sum(oi => oi.Quantity * oi.Drink.Price) / 1000000.0 // Convert to million VND
                })
                // .OrderBy(item => item.Date) // Order by date
                .ToListAsync(); // Ensure that ToListAsync is awaited

            // Prepare the result in the specified format
            var result = new List<object>
            {
                new { nameDrink = drinkType, total = dailyRevenueByDrinkType.Select(item => item.Total).ToList() }
            };

            return result;
        }

        // Tuanhayho fixed (version 1)
        // Bug/issue: not listing all revenue of all remaing dates within range, only returned the revenue of first date.
        /*
        public async Task<List<DrinkDailyRevenueViewModel>> GetDailyDrinkRevenueInRange(string drinkType, string startDate, string endDate)
        {
            // * Debug:
            // var parsedStartDate = DateTime.Parse(startDate);
            // var parsedEndDate = DateTime.Parse(endDate);
            // Console.WriteLine("\nparsedStartDate: " + parsedStartDate + " parsedEndDate: " + parsedEndDate + "\n");

            // var query = await _dbContext.OrderItems
            //     .Include(oi => oi.Drink)
            //     .Include(oi => oi.Order)
            //     .Where(oi => oi.Drink.DrinkType.Name.ToUpper() == drinkType.ToUpper() && oi.Order.OrderDate >= parsedStartDate && oi.Order.OrderDate <= parsedEndDate)
            //     .GroupBy(oi => oi.Drink.Name)
            //     // .Select(g => g.Key)  // => [Latte, Capuchino]
                
            //     .ToListAsync();

            // return query;
            

            // Define the expected format
            string format = "yyyy-MM-dd";

            // Parse the string to DateTime
            DateTime parsedStartDate = DateTime.ParseExact(startDate, format, System.Globalization.CultureInfo.InvariantCulture);
            DateTime parsedEndDate = DateTime.ParseExact(endDate, format, System.Globalization.CultureInfo.InvariantCulture);
            
            

            var query = await _dbContext.OrderItems
                .Include(oi => oi.Drink)
                .Include(oi => oi.Order)
                .Where(oi => oi.Drink.DrinkType.Name.ToUpper() == drinkType.ToUpper()
                            && oi.Order.OrderDate >= parsedStartDate
                            && oi.Order.OrderDate <= parsedEndDate)
                .GroupBy(oi => new { oi.Drink.Name, Date = oi.Order.OrderDate })
                .Select(g => new DrinkDailyRevenueViewModel
                {
                    NameDrink = g.Key.Name,
                    Total = g.OrderBy(oi => oi.Order.OrderDate)
                             .Select(oi => oi.Quantity * oi.Drink.Price / 1000000.0) // Convert to million VND
                             .ToList()
                })
                .ToListAsync();

            // Ensure all drink names are included, even if they have no orders within the date range
            var drinkNames = await _dbContext.Drinks
                .Where(d => d.DrinkType.Name.ToUpper() == drinkType.ToUpper())
                .Select(d => d.Name)
                .Distinct()
                .ToListAsync();

            // Fill in missing drink entries with empty totals
            var result = drinkNames.Select(drinkName => new DrinkDailyRevenueViewModel
            {
                NameDrink = drinkName,
                Total = query.FirstOrDefault(q => q.NameDrink == drinkName)?.Total ?? new List<double?>()
            }).ToList();

            return result;
        }
        */

        // Tuanhayho version 2, attempting to resolve version 1 issue
        //*
        public async Task<List<DrinkDailyRevenueViewModel>> GetDailyDrinkRevenueInRange(string userId, string drinkType, string startDate, string endDate)
        {
            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            // Define the expected format
            string format = "yyyy-MM-dd";

            // Parse the string to DateTime
            DateTime parsedStartDate = DateTime.ParseExact(startDate, format, System.Globalization.CultureInfo.InvariantCulture);

            // Faulty: this cause missing data if endDate is today's date.
            // DateTime parsedEndDate = DateTime.ParseExact(endDate, format, System.Globalization.CultureInfo.InvariantCulture);
            
            // Fix: adjusted parsedEndDate to include the entire end date by adding one day and subtracting one second.
            DateTime parsedEndDate = DateTime.ParseExact(endDate, format, System.Globalization.CultureInfo.InvariantCulture).AddDays(1).AddSeconds(-1);

            // Generate the list of dates within the range
            var dateRange = Enumerable.Range(0, (parsedEndDate.Date - parsedStartDate.Date).Days + 1)
                                    .Select(offset => parsedStartDate.AddDays(offset).Date)
                                    .ToList();

            // foreach (var date in dateRange)
            // {
            //     Console.WriteLine(date);
            // }

            // Query the order items
            var orderItems = await _dbContext.OrderItems
                .Include(oi => oi.Drink)
                .Include(oi => oi.Order)
                .Where(
                        // filter by userId (assuming eacher user only has 1 Shop)
                        oi => oi.Order.UserId == userId
                        && oi.Drink.DrinkType.Name.ToUpper() == drinkType.ToUpper()
                        && oi.Order.OrderDate >= parsedStartDate
                        && oi.Order.OrderDate <= parsedEndDate
                )
                .ToListAsync();

            // debug
            // Console.WriteLine("orderItems: ");
            // foreach (var orderItem in orderItems)
            // {
            //     string jsonString = System.Text.Json.JsonSerializer.Serialize(orderItem, options);
            //     Console.WriteLine(jsonString);
            // }

            // Group the order items by drink name and date
            var groupedOrderItems = orderItems
                // .GroupBy(oi => new { oi.Drink.Name, Date = oi.Order.OrderDate.GetValueOrDefault() })

                // To ensure only the date part is considered during grouping.
                .GroupBy(oi => new { oi.Drink.Name, Date = oi.Order.OrderDate.GetValueOrDefault().Date })
                .Select(g => new
                {
                    DrinkName = g.Key.Name,
                    Date = g.Key.Date,
                    // Total = g.Sum(oi => oi.Quantity * oi.Drink.Price) / 1000000.0 // Convert to million VND
                    Total = g.Sum(oi => oi.Quantity * oi.Drink.Price) // Keep original VND due to Hoà's needs.
                })
                .ToList();

            // debug
            // Console.WriteLine("groupedOrderItem: ");
            // foreach (var groupedOrderItem in groupedOrderItems)
            // {
            //     Console.WriteLine(groupedOrderItem);
            // }

            // Get all drink names for the specified drink type
            var drinkNames = await _dbContext.Drinks
                .Where(d => d.DrinkType.Name.ToUpper() == drinkType.ToUpper())
                .Select(d => d.Name)
                .Distinct()
                .ToListAsync();

            // debug
            // foreach (var drinkName in drinkNames)
            // {
            //     Console.WriteLine(drinkName);
            // }

            var result = drinkNames.Select(drinkName => new DrinkDailyRevenueViewModel
            {
                NameDrink = drinkName,
                Total = dateRange.Select(date =>
                {   
                    // Now g.Date has type DateTime, it's matching with date which also has type DateTime

                    // * Faulty: Wrong comparing leads to missing revenue (all returned 0.0)
                    // double? revenue = groupedOrderItems
                    //     .FirstOrDefault(g => g.DrinkName == drinkName && g.Date == date)?.Total;
                    // return revenue ?? 0.0;

                    // * Fix: Ensure both dates are of the same type for comparison
                    // * Remaining issue: did not combining all total of orders of the same date.
                    // double? revenue = groupedOrderItems
                    //     .FirstOrDefault(g => g.DrinkName == drinkName && g.Date.Date == date.Date)?.Total;

                    double? revenue = groupedOrderItems
                        .Where(g => g.DrinkName == drinkName && g.Date.Date == date.Date)
                        .Sum(g => g.Total); // Combine totals for the same date
                    
                    return revenue ?? 0.0;

                }).ToList()
            }).ToList();


            return result;
        }

        //*/

    }
}
