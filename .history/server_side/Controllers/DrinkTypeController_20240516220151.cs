namespace CoffeeShopApi.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Exceptions;
    using Models.DTOs;
    using Services.Interfaces;
    using Repositories.Interfaces;
    using System.Security.Claims;
    using System.Text.Json;
    using System.Text.Json.Serialization;

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


        /// <summary>
        /// Retrieve list of DrinkType (filtered by Bearer JWT -> ownerId)
        /// </summary>
        /// <returns>Returns the list of DrinkType</returns>
        [HttpGet("[action]")]
        public async Task<ActionResult> getall()
        {
            #region retrieve User claim principles from Bearer JWT
            string userId = "";

            // get the User claims first
            var userClaims = User?.Claims;
            // JsonSerializerOptions options = new JsonSerializerOptions
            // {
            //     ReferenceHandler = ReferenceHandler.Preserve,   // avoid object cycle
            //     WriteIndented = true,
            //     // Optionally, you can set other options like PropertyNamingPolicy, etc.
            // };

            // print the pretty Json:
            // string userClaimsJson = JsonSerializer.Serialize(userClaims, options);
            // Console.WriteLine("userClaims:" + userClaimsJson);

            // get User's Id from claims
            Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
            if (userIdClaim != null && userIdClaim.Value != null)
            {
                userId = userIdClaim.Value;
                Console.WriteLine("userId:" + userId);

                var result = await _drinkTypeService.GetAllDrinkTypesByShopOwnerIdAsync(userId);
                return Ok(result);
            }

            // if (string.IsNullOrEmpty(userId))
            // {
            //     Console.WriteLine("user id is null or empty!!");
            //     return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header."});
            // }

            // get user's UserName:
            // Claim userNameClaim = User?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name); // ControllerBase.User
            // if (userIdClaim != null && userIdClaim.Value != null)
            // {
            //     userId = userIdClaim.Value;
            //     Console.WriteLine("userName:" + userId);
            // }

            // if (string.IsNullOrEmpty(userId))
            // {
            //     Console.WriteLine("userName is null or empty!!");
            // }
            #endregion


            // var result = await _drinkTypeService.GetAllDrinkTypesAsync();
            Console.WriteLine("user id is null or empty!!");
            return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header."}); 
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

        [Authorize]
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
        [Authorize]
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
            catch (NotFoundException)
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
            catch (NotFoundException)
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