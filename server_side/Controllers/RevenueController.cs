using CoffeeShopApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        public async Task<ActionResult> GetDailyRevenueInRange([FromQuery]string startDate, string endDate)
        {
            // Define the expected format
            string format = "yyyy-MM-dd";

            // Parse the string to DateTime
            DateTime parsedStartDate = DateTime.ParseExact(startDate, format, System.Globalization.CultureInfo.InvariantCulture);
            DateTime parsedEndDate = DateTime.ParseExact(endDate, format, System.Globalization.CultureInfo.InvariantCulture);
            
            if(parsedStartDate.Date > parsedEndDate.Date)
            {
                return BadRequest(new
                {
                    Message = "Ngày kết thúc không thể trước ngày bắt đầu"
                }) ;
            }

            string userId = "";

            // get the User claims first
            var userClaims = base.User?.Claims;

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
            }

            if(userId == "")
            {
                return BadRequest(new
                {
                    Message = "Không tìm thấy userId"
                });
            }

            var revenue = await revenueService.GetDailyRevenueInRangeAsync(parsedStartDate, parsedEndDate,userId);
            
            if(revenue == null || revenue.Count() == 0)
            {
                return NoContent();
            }

            return Ok(revenue);
        }



        [HttpGet("[action]")]
        public async Task<ActionResult> GetMonthlyRevenueByYear([FromQuery]int year)
        {

            string userId = "";
            // get the User claims first
            var userClaims = base.User?.Claims;

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
            }


            if (userId == "")
            {
                return BadRequest(new
                {
                    Message = "Không tìm thấy userId"
                });
            }

            var monthlyRevenue = await revenueService.GetMonthlyRevenueByYearAsync(year, userId);

            if (monthlyRevenue == null && monthlyRevenue.Count() == 0)
            {
                return NoContent();
            }

            return Ok(monthlyRevenue);
        }
    }
}
