namespace CoffeeShopApi.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.IdentityModel.Tokens;
    using Models.DTOs;
    using Services.Interfaces;
    using System.Security.Claims;

    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IAuthTokenService _authTokenService;

        public AuthController(IAuthService authService, IAuthTokenService authTokenService)
        {
            _authService = authService;
            _authTokenService = authTokenService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AuthResult>> RegisterAsync([FromBody] RegisterModel model)
        {
            // get necessary values to pass to services (ControllerBase's monopoly):


            // calling scoped services:
            // var ipAddressObject = await _ipService.GetRemoteIpAddress();
            var authResult = await _authService.RegisterAsync(model);
            if (!authResult.Succeeded)
            {
                return BadRequest(authResult);
            }

            return Ok(authResult);
        }

        // [Authorize]
        [HttpGet("all-users")]
        public async Task<ActionResult> getAllUsers()
        {
            var result = await _authService.GetAllUsersAsync();
            return Ok(result);
        }

        [HttpPost("loginef")]
        public async Task<ActionResult<AuthResult>> LoginAsyncEF([FromBody] LoginModel model)
        {
            // get necessary values to pass to services (ControllerBase's monopoly):
            string? userAgentString = Request.Headers.UserAgent;

            // calling scoped services:
            //var ipAddressObject = await _ipService.GetRemoteIpAddress();
            var authResult = await _authService.LoginEFAsync(model);
            if (!authResult.Succeeded)
            {
                return BadRequest(authResult);
            }

            return Ok(authResult);
        }


        [Authorize]
        [HttpPost("changepassword")]
        public async Task<Object> ChangePasswordAsync([FromBody] ChangePasswordModel model)
        {
            try
            {
                List<object> errors = new List<object>(14);

                string userId = "";
                Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
                if (userIdClaim != null && userIdClaim.Value != null)
                {
                    userId = userIdClaim.Value;
                }

                if (string.IsNullOrEmpty(userId))
                {
                    errors.Add(new { code = "NotFound", description = "User not found!" });
                    return new { succeeded = false, message = "Failed to change password!", errors = errors };
                }

                var result = await _authService.ChangePasswordAsyncEF(userId, model.OldPassword, model.NewPassword);


                if (result.Succeeded)
                {
                    // might use AuthResult for this as well
                    return new { succeeded = true, message = "Password changed successfully!" };
                }
                errors.AddRange(result.Errors);

                return new { succeeded = false, message = "Failed to change password!", errors = errors };
            }
            catch
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpPost("changeuserinfo")]
        public async Task<IActionResult> ChangeUserInfoAsync([FromBody] ChangeUserInfoModel model)
        {
            try
            {
                List<object> errors = new List<object>(14);

                string userId = "";
                Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
                if (userIdClaim != null && userIdClaim.Value != null)
                {
                    userId = userIdClaim.Value;
                }

                if (string.IsNullOrEmpty(userId))
                {
                    errors.Add(new { code = "NotFound", description = "User not found!" });
                    return BadRequest(new { succeeded = false, message = "Failed to change user information!", errors = errors });
                }

                var result = await _authService.ChangeUserInfoAsyncEF(userId, model.FullName, model.Email);

                if (result.Succeeded)
                {
                    // return success response
                    return Ok(new { succeeded = true, message = "User information changed successfully!" });
                }

                errors.AddRange(result.Errors);

                return BadRequest(new { succeeded = false, message = "Failed to change user information!", errors = errors });
            }
            catch
            {
                return BadRequest();
            }
        }



    }

    public class ChangeUserInfoModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
