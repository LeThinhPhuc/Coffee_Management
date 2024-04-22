using CoffeeShopApi.Models.DomainModels;
using CoffeeShopApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientsController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetAllIngredients()
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
        public async Task<ActionResult<Ingredient>> CreateIngredient(Ingredient ingredient)
        {
            var createdIngredient = await _ingredientService.CreateAsync(ingredient);
            return CreatedAtAction(nameof(GetIngredient), new { id = createdIngredient.Id }, createdIngredient);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Ingredient>> UpdateIngredient(string id, Ingredient ingredient)
        {
            if (id != ingredient.Id.ToString())
            {
                return BadRequest();
            }

            var updatedIngredient = await _ingredientService.UpdateAsync(id, ingredient);
            if (updatedIngredient == null)
            {
                return NotFound();
            }

            return Ok(updatedIngredient);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient(string id)
        {
            await _ingredientService.DeleteAsync(id);
            return NoContent();
        }
    }
}