namespace CoffeeShopApi.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Exceptions;
    using Models.DTOs;
    using Services.Interfaces;
    using Repositories.Interfaces;
    using System.Security.Claims;

    [Authorize] // 25-05-2024 đến lúc này rồi auth rào lại hết
    [ApiController]
    [Route("api/[controller]")]
    public class AnalyticController : ControllerBase
    {
        private readonly IAnalyticService _service;
        // private readonly IUnitOfWork _unitOfWork;
        public AnalyticController(IAnalyticService service,
            IUnitOfWork unitOfWork
        )
        {
            _service = service;
            // _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// So sánh doanh thu tháng hiện tại với tháng trước về tăng/giảm (với isIncrease: cho biết so với tháng trước, doanh thu tháng vừa rồi có tăng hay không, không so sánh được thì trả về -1 nếu 1 trong 2 tháng không có doanh thu)
        /// </summary>
        /// <returns>Returns the list of Anonymous Object</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetMonthlyRevenueStatus()
        {
            #region retrieve User claim principles from Bearer JWT
            string userId = "";

            // get the User claims first
            var userClaims = User?.Claims;

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
                Console.WriteLine("userId:" + userId);

                var result = await _service.GetMonthlyRevenueStatus(userId);
                return Ok(result);
            }
            #endregion

            // Reaching down here means 401 Unauthenticated (Can use [Authorize])
            Console.WriteLine("user id is null or empty!!");
            return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header." });
        }

        /// <summary>
        /// Lấy tổng doanh thu trong 10 năm qua (toàn bộ hệ thống)
        /// </summary>
        /// <returns>Returns a double value</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetTotalRevenuePast10YearsEntireSystem()
        {
            var result = await _service.GetTotalRevenuePast10YearsWholeSystem();
            return Ok(result);
        }

        /// <summary>
        /// Lấy tổng doanh thu trong 10 năm qua (lọc theo Id chủ Shop)
        /// </summary>
        /// <returns>Returns a double value</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetTotalRevenuePast10YearsByUserId(string ownerId)
        {
            #region retrieve User claim principles from Bearer JWT
            string userId = "";

            // get the User claims first
            var userClaims = User?.Claims;

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
                // Console.WriteLine("userId:" + userId);

                 var result = await _service.GetTotalRevenuePast10YearsByUserId(ownerId);
                return Ok(result);
            }
            #endregion

            // Reaching down here means 401 Unauthenticated (Can use [Authorize])
            Console.WriteLine("user id is null or empty!!");
            return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header." });
        }

        /// <summary>
        /// Lấy tổng doanh thu trong tháng vừa qua theo tên loại đồ uống. (trả mảng rỗng nếu không có data)
        /// </summary>
        /// <returns>Returns a List of object.</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetLastMonthRevenueByDrinkType()
        {
            #region retrieve User claim principles from Bearer JWT
            string userId = "";

            // get the User claims first
            var userClaims = User?.Claims;

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
                // Console.WriteLine("userId:" + userId);

                var result = await _service.GetLastMonthRevenueByDrinkType(userId);
                return Ok(result);
            }
            #endregion

            // Reaching down here means 401 Unauthenticated (Can use [Authorize])
            Console.WriteLine("user id is null or empty!!");
            return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header." });
        }


        /// <summary>
        /// Lấy tổng doanh thu trong tháng hiện tại theo tên loại đồ uống. (trả mảng rỗng nếu không có data)
        /// </summary>
        /// <returns>Returns a List of object.</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetCurrentMonthRevenueByDrinkType()
        {
            #region retrieve User claim principles from Bearer JWT
            string userId = "";

            // get the User claims first
            var userClaims = User?.Claims;

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
                // Console.WriteLine("userId:" + userId);

                var result = await _service.GetCurrentMonthRevenueByDrinkType(userId);
                return Ok(result);
            }
            #endregion

            // Reaching down here means 401 Unauthenticated (Can use [Authorize])
            Console.WriteLine("user id is null or empty!!");
            return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header." });
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> GetWeeklyRevenueStatus()
        {
            #region retrieve User claim principles from Bearer JWT
            string userId = "";

            // get the User claims first
            var userClaims = User?.Claims;

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
                // Console.WriteLine("userId:" + userId);

                var result = await _service.GetWeeklyRevenueStatus(userId);
                return Ok(result);
            }
            #endregion

            // Reaching down here means 401 Unauthenticated (Can use [Authorize])
            Console.WriteLine("user id is null or empty!!");
            return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header." });
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> GetDailyRevenueByDrinkTypeInRange(string drinkType, DateTime startDate, DateTime endDate)
        {
            #region retrieve User claim principles from Bearer JWT
            string userId = "";

            // get the User claims first
            var userClaims = User?.Claims;

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
                // Console.WriteLine("userId:" + userId);

                var result = await _service.GetDailyRevenueByDrinkTypeInRange(userId, drinkType, startDate, endDate);
                return Ok(result);
            }
            #endregion

            // Reaching down here means 401 Unauthenticated (Can use [Authorize])
            Console.WriteLine("user id is null or empty!!");
            return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header." });
        }



        /// <summary>
        /// (TuanhayhoFix) Lấy tổng doanh thu trong ngày của drink đó từ ngày startDate đến endDate. (trả mảng rỗng nếu không có data)
        /// </summary>
        /// <returns>Returns a List of DrinkDailyRevenueViewModel.</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetDailyDrinkRevenueInRange(string drinkType, string startDate, string endDate)
        {
            try
            {
                #region retrieve User claim principles from Bearer JWT
                string userId = "";

                // get the User claims first
                var userClaims = User?.Claims;

                // get User's Id from claims
                Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
                if (userIdClaim != null && userIdClaim.Value != null)
                {
                    userId = userIdClaim.Value;
                    // Console.WriteLine("userId:" + userId);

                    if (string.IsNullOrEmpty(drinkType) || string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate))
                    {
                        return BadRequest("Please provide enough drinkType, startDate & endDate !!");
                    }
                    var drinkRevenues = await _service.GetDailyDrinkRevenueInRange(userId, drinkType, startDate, endDate);
                    return Ok(drinkRevenues);
                }
                #endregion

                // Reaching down here means 401 Unauthenticated (Can use [Authorize])
                Console.WriteLine("user id is null or empty!!");
                return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header." });
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex caught: " + ex);
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}