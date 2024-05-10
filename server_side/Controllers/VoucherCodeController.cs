namespace CoffeeShopApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Interfaces;
    using Models.DTOs;
    using Microsoft.AspNetCore.Authorization;
    using Exceptions;
    using Repositories.Interfaces;

    [ApiController]
    [Route("api/[controller]")]
    public class VoucherCodeController : ControllerBase
    {
        private readonly IVoucherCodeService _voucherCodeService;
        private readonly IUnitOfWork _unitOfWork;

        public VoucherCodeController(IVoucherCodeService voucherCodeService,
            IUnitOfWork unitOfWork
        )
        {
            _voucherCodeService = voucherCodeService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("getall")]
        public async Task<ActionResult> GetAllDrinksAsync()
        {
            var result = await _voucherCodeService.GetAllVoucherCodesAsync();
            return Ok(result);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult> getById(string id)
        {
            var result = await _voucherCodeService.GetVoucherCodeByIdAsync(id);
            return Ok(result);
        }

        // [HttpGet("getdrinksbytype")]
        // public async Task<ActionResult> GetDrinksByTypeName(string typeName)
        // {
        //     var result = await _drinkService.GetDrinksByTypeAsync(typeName);
        //     return Ok(result);
        // }

        // [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult> AddVoucherCodeAsync([FromBody] CreateUpdateVoucherCodeModel model)
        {
            try
            {
                // Check if the model is valid
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _voucherCodeService.AddVoucherCodeAsync(model);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Created" });
                }
                return Ok(new { succeeded = false, message = "Failed to add Voucher Code!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
            #region example input:
            //{
            //    "name": "test"
            //}
            #endregion
            #region example success return:
            //{
            //  "succeeded": true,
            //  "message": "Created"
            //}
            #endregion
        }

        // [Authorize]
        [HttpPut("update")]
        public async Task<IActionResult> UpdateDrink([FromBody]CreateUpdateVoucherCodeModel model)
        {
            try
            {
                // Check if the model is valid
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _voucherCodeService.UpdateVoucherCodeAsync(model);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Updated" });
                }
                return Ok(new { succeeded = false, message = "Failed to update Voucher Code!" });

            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "Voucher Code not found!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        // [Authorize]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteDrink(string id)
        {
            try
            {
                var result = await _voucherCodeService.DeleteVoucherCodeAsync(id);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete Voucher Code!" });
            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "Voucher Code not found!" });
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                //return StatusCode(500, "Server error"); // 500 Internal Server Error with a generic error message
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        // [Authorize]
        [HttpDelete("deleteall")]
        public async Task<IActionResult> DeleteAllDrinks()
        {
            try
            {
                
                var result = await _voucherCodeService.DeleteAllVoucherCodesAsync();
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete All Voucher Codes!" });
            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "No Voucher Code found!" });
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                //return StatusCode(500, "Server error"); // 500 Internal Server Error with a generic error message
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

    }
}