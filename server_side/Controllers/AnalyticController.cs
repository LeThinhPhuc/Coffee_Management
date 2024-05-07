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


        // GET api/Analytic/GetMonthlyRevenueStatus
        /// <summary>
        /// So sánh doanh thu tháng hiện tại với tháng trước về tăng/giảm (với isIncrease: cho biết so với tháng trước, doanh thu tháng vừa rồi có tăng hay không)
        /// </summary>
        /// <returns>Returns the list of Anonymous Object</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetMonthlyRevenueStatus()
        {
            var result = await _service.GetMonthlyRevenueStatus();
            return Ok(result);
        }

        // GET api/Analytic/GetTotalRevenuePast10Years
        /// <summary>
        /// Lấy tổng doanh thu trong 10 năm qua (toàn bộ hệ thống)
        /// </summary>
        /// <returns>Returns a double value</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> GetTotalRevenuePast10Years()
        {
            var result = await _service.GetTotalRevenuePast10Years();
            return Ok(result);
        }

        // GET api/Analytic/GetTotalRevenuePast10YearsByUserId
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


    }
}