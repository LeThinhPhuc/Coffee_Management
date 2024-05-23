namespace CoffeeShopApi.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Exceptions;
    using Services.Interfaces;
    using Repositories.Interfaces;

    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IUnitOfWork _unitOfWork;
        public AdminController(IAdminService adminService,
            IUnitOfWork unitOfWork
        )
        {
            _adminService = adminService;
            _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// [Admin] Retrieve lists of Shop as an Admin
        /// </summary>
        /// <returns>Returns the list of ShopViewModel</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> ShopsListAdmin()
        {
            var result = await _adminService.GetAllShops();
            return Ok(result);
        }

        /// <summary>
        /// [Admin] Approve a shop
        /// </summary>
        /// <returns>Returns the success/failure result</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> ApproveShop(string shopId)
        {

            try
            {
                var result = await _adminService.ApproveShopAsync(shopId);
                if (result != false)
                {
                    return Ok(new { succeeded = true, message = "Successfully approved shop!" });
                }
                return Ok(new { succeeded = false, message = "Failed to approve shop!" });
            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "Shop not found by provided id!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        /// <summary>
        /// [Admin] Suspense/unsuspense a shop
        /// </summary>
        /// <returns>Returns the success/failure + suspension status result</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> SuspenseShop(string shopId)
        {
            try
            {
                var result = await _adminService.SuspenseShopAsync(shopId);
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }
    }
}