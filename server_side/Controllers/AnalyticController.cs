namespace CoffeeShopApi.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Exceptions;
    using Models.DTOs;
    using Services.Interfaces;
    using Repositories.Interfaces;


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
            var result = await _service.GetMonthlyRevenueStatus();
            return Ok(result);
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
            var result = await _service.GetTotalRevenuePast10YearsByUserId(ownerId);
            return Ok(result);
        }

        /// <summary>
        /// Lấy tổng doanh thu trong tháng vừa qua theo tên loại đồ uống. (trả mảng rỗng nếu không có data)
        /// </summary>
        /// <returns>Returns a List of object.</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetLastMonthRevenueByDrinkType()
        {
            var result = await _service.GetLastMonthRevenueByDrinkType();
            return Ok(result);
        }


        /// <summary>
        /// Lấy tổng doanh thu trong tháng hiện tại theo tên loại đồ uống. (trả mảng rỗng nếu không có data)
        /// </summary>
        /// <returns>Returns a List of object.</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetCurrentMonthRevenueByDrinkType()
        {
            var result = await _service.GetCurrentMonthRevenueByDrinkType();
            return Ok(result);
        }
        [HttpGet("[action]")]
        public async Task<ActionResult> GetWeeklyRevenueStatus()
        {
            var result = await _service.GetWeeklyRevenueStatus();
            return Ok(result);
        }
        [HttpGet("[action]")]
        public async Task<ActionResult> GetDailyRevenueByDrinkTypeInRange(string drinkType, DateTime startDate, DateTime endDate)
        {
            var result = await _service.GetDailyRevenueByDrinkTypeInRange(drinkType,startDate, endDate);
            return Ok(result);
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
                if(string.IsNullOrEmpty(drinkType) || string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate)) {
                    return BadRequest("Please provide enough drinkType, startDate & endDate !!");
                }
                var drinkRevenues = await _service.GetDailyDrinkRevenueInRange(drinkType, startDate, endDate);
                return Ok(drinkRevenues);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex caught: " + ex);
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}