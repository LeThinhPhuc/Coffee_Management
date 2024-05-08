using CoffeeShopApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApi.Controllers
{
    public class RevenueController : BaseApiController
    {
        private IRevenueService revenueService;

        public RevenueController(IRevenueService revenueService)
        {
            this.revenueService = revenueService;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> GetDailyRevenueInRange([FromQuery]DateTime startDate,DateTime endDate)
        {

            if(startDate.Date > endDate.Date)
            {
                return BadRequest(new
                {
                    Message = "Ngày kết thúc không thể trước ngày bắt đầu"
                }) ;
            }

            var revenue = await revenueService.GetDailyRevenueInRangeAsync(startDate, endDate);
            
            if(revenue == null || revenue.Count() == 0)
            {
                return NoContent();
            }

            return Ok(revenue);
        }



        [HttpGet("[action]")]
        public async Task<ActionResult> GetMonthlyRevenueByYear([FromQuery]int year)
        {
            var monthlyRevenue = await revenueService.GetMonthlyRevenueByYearAsync(year);

            if (monthlyRevenue == null && monthlyRevenue.Count() == 0)
            {
                return NoContent();
            }

            return Ok(monthlyRevenue);
        }
    }
}
