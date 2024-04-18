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
    public class DrinkTypeController : ControllerBase
    {
        private readonly IDrinkTypeService _drinkTypeService;
        private readonly IUnitOfWork _unitOfWork;
        public DrinkTypeController(IDrinkTypeService drinkTypeService,
            IUnitOfWork unitOfWork
        )
        {
            _drinkTypeService = drinkTypeService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("getall")]
        public async Task<ActionResult> getall()
        {
            var result = await _drinkTypeService.GetAllDrinkTypesAsync();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<ActionResult> getById(string id)
        {
            var result = await _drinkTypeService.GetDrinkTypeByIdAsync(id);
            return Ok(result);
        }

        // Tạm thời ko rào vì FE Auth chưa hoàn thiện!
        // [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult> AddDrinkTypeAsync([FromBody] CreateUpdateDrinkTypeModel model)
        {
            try
            {
                var result = await _drinkTypeService.AddDrinkTypeAsync(model);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Created" });
                }
                return Ok(new { succeeded = false, message = "Failed to add DrinkType!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        // [Authorize]
        [HttpPut("update")]
        public async Task<ActionResult> UpdateDrinkTypeAsync([FromBody] CreateUpdateDrinkTypeModel model)
        {
            try
            {
                // Check if the model is valid
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _drinkTypeService.UpdateDrinkTypeAsync(model);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Updated" });
                }
                return Ok(new { succeeded = false, message = "Failed to update DrinkType!" });
            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "DrinkType not found!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        // NOTE: deleting a drinktype will also delete all its drinks !
        // [Authorize]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteDrink(string id)
        {
            try
            {
                var result = await _drinkTypeService.DeleteDrinkTypeAsync(id);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete DrinkType!" });
            }
            catch (NotFoundException ex)
            {
                return Ok(new { succeeded = false, message = "DrinkType not found!" });
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        [Authorize]
        [HttpDelete("deleteall")]
        public async Task<IActionResult> DeleteAllDrinks()
        {
            try
            {
                var result = await _drinkTypeService.DeleteAllDrinkTypesAsync();
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete All DrinkTypes!" });
            }
            catch (NotFoundException ex)
            {
                return Ok(new { succeeded = false, message = "No DrinkType found!" });
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }
    }
}