namespace CoffeeShopApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Interfaces;
    using Models.DTOs;
    using Microsoft.AspNetCore.Authorization;
    using Exceptions;
    using Repositories.Interfaces;
    using System.Security.Claims;

    [ApiController]
    [Route("api/[controller]")]
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkService _drinkService;
        private readonly IUnitOfWork _unitOfWork;

        public DrinkController(IDrinkService drinkService,
            IUnitOfWork unitOfWork
        )
        {
            _drinkService = drinkService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("getall")]
        public async Task<ActionResult> GetAllDrinksAsync()
        {
            var result = await _drinkService.GetAllDrinksClientAsync();
            return Ok(result);
        }

        [HttpGet("getallbysystem")]
        public async Task<ActionResult> GetAllDrinksBySystemAsync()
        {
            var result = await _drinkService.GetAllDrinksSystemAsync();
            return Ok(result);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult> getById(string id)
        {
            var result = await _drinkService.GetDrinkByIdAsync(id);
            return Ok(result);
        }

        [HttpGet("getdrinksbytypename")]
        public async Task<ActionResult> GetDrinksByTypeName(string typeName)
        {
            var result = await _drinkService.GetDrinksByTypeNameAsync(typeName);
            return Ok(result);
        }

        [Authorize]
        /// <summary>
        /// Retrieve list of Drink (filtered by Bearer JWT -> ownerId)
        /// </summary>
        /// <returns>Returns the list of Drink</returns>
        [HttpGet("getallgrouped")]
        public async Task<ActionResult> GetAllDrinksGrouped()
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

                var result = await _drinkService.GetMenuDataByShopOwnerIdAsync(userId);
                return Ok(result);
            }
            #endregion

            // var result = await _drinkService.GetMenuDataAsync();
            Console.WriteLine("user id is null or empty!!");
            return Ok(new { succeeded = false, message = "Please login and send Bearer token through Authorization header."}); 
        }

        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult> AddDrinksAsync([FromBody] CreateUpdateDrinkModel model)
        {
            try
            {
                // Check if the model is valid
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _drinkService.AddDrinkAsync(model);
                if (result != null)
                {
                    return Ok(result);
                }
                return Ok(new { succeeded = false, message = "Failed to add drink!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
            #region example input data:
            // {
            //     "id": "",
            //     "name": "Test thêm Drink",
            //     "price": 0,
            //     "imagePath": "ko co anh",
            //     "drinkTypeId": "dd91c711-8e1f-4d90-ace8-f696b95d1ed7",
            //     "ingredients": [
            //         {
            //         "ingredientId": "33cb620e-746c-4212-aff3-5448fc3d2b24",
            //         "quantity": 1
            //         },
            //         {
            //         "ingredientId": "690621f7-0f25-4a35-8bed-8c2a968f197a",
            //         "quantity": 3
            //         }
            //     ]
            // }
            #endregion
        }

        [Authorize]
        [HttpPut("update")]
        public async Task<IActionResult> UpdateDrink([FromBody]CreateUpdateDrinkModel model)
        {
            try
            {
                // Check if the model is valid
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _drinkService.UpdateDrinkAsync(model);
                if (result != null)
                {
                    return Ok(result);
                }
                return Ok(new { succeeded = false, message = "Failed to update drink!" });

            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "Drink not found!" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        [Authorize]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteDrink(string id)
        {
            try
            {
                var result = await _drinkService.DeleteDrinkAsync(id);
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete Drink!" });
            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "Drink not found!" });
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                //return StatusCode(500, "Server error"); // 500 Internal Server Error with a generic error message
                return Ok(new { succeeded = false, message = ex.Message });
            }
        }

        [Authorize]
        [HttpDelete("deleteall")]
        public async Task<IActionResult> DeleteAllDrinks()
        {
            try
            {
                
                var result = await _drinkService.DeleteAllDrinksAsync();
                if (result)
                {
                    return Ok(new { succeeded = true, message = "Deleted" });
                }
                return Ok(new { succeeded = false, message = "Failed to delete All Drinks!" });
            }
            catch (NotFoundException)
            {
                return Ok(new { succeeded = false, message = "No Drink found!" });
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
