namespace CoffeeShopApi.Controllers
{
    using Models.DomainModels;
    using Models.DTOs;
    using Repositories.Interfaces;
    using Services.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using CoffeeShopApi.Exceptions;

    [ApiController]
    [Route("api/[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
        private readonly IUnitOfWork _unitOfWork;
        public IngredientsController(IIngredientService ingredientService,
            IUnitOfWork unitOfWork
        )
        {
            _ingredientService = ingredientService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllIngredients()
        {
            var ingredients = await _ingredientService.GetAllAsync();
            return Ok(ingredients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetIngredient(string id)
        {
            var ingredient = await _ingredientService.GetByIdAsync(id);
            if (ingredient == null)
            {
                return NotFound();
            }
            return Ok(ingredient);
        }

        [HttpPost]
        public async Task<ActionResult<Ingredient>> CreateIngredient([FromBody] CreateUpdateIngredientModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _ingredientService.CreateAsync(model);
                if (result != null)
                {
                    return Ok(result);
                }
                return Ok(new { succeeded = false, message = "Failed to add Ingredient!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }           
        }

        // [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateIngredient([FromBody] CreateUpdateIngredientModel model)
        {
            try
            {
                // Check if the model is valid
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _ingredientService.UpdateAsync(model);
                if (result != null)
                {
                    return Ok(new { succeeded = true, message = "Updated" });
                    // return Ok(result)    // depends on client_side's requirement
                }
                return Ok(new { succeeded = false, message = "Failed to update Ingredient!" });
            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "Ingredient not found!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient(string id)
        {
            // await _ingredientService.DeleteAsync(id);
            // return NoContent();  // lacking info for FrontEnd team !

            // more proper handling
            try
            {
                var result = await _ingredientService.DeleteAsync(id);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete Ingredient!" });
            }
            catch (NotFoundException ex)
            {
                return Ok(new { succeeded = false, message = "Ingredient not found!" });
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