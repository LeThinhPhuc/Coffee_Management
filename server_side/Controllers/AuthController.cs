namespace CoffeeShopApi.Controllers
{
    using Models.DomainModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Models.DTOs;
    using Services.Interfaces;
    using System.Security.Claims;
    using CoffeeShopApi.Models.DAL;

    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IAuthTokenService _authTokenService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        // private readonly AppDbContext _dbContext;   // to fix Admin role assigning setup

        public AuthController(IAuthService authService,
            IAuthTokenService authTokenService,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager
            // AppDbContext dbContext
        )
        {
            _authService = authService;
            _authTokenService = authTokenService;
            _userManager = userManager;
            _roleManager = roleManager;
            // _dbContext = dbContext;
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

        [HttpPost("AssignRoleForAdmin")]
        //POST : /api/Auth/AssignRoleForAdmin
        public async Task<object> AssignRoleForAdmin()
        {
            // Check if server password is correct
            // if (model.Password != "mysecretPassword@123")   // better use Azure Key Vault for security
            // {
            //     return BadRequest("Incorrect password");
            // }

            List<object> errors = new List<object>();

            #region creating default roles
            List<IdentityRole> rolesToCreate = new List<IdentityRole>
            {
                new IdentityRole("Member"),
                new IdentityRole("Admin"),
                new IdentityRole("App Owner")
            };

            var rsNewRole = new IdentityResult();

            foreach (var newRole in rolesToCreate)
            {
                rsNewRole = await _roleManager.CreateAsync(newRole);
                if (!rsNewRole.Succeeded)
                {
                    foreach (var err in rsNewRole.Errors)
                    {
                        errors.Add(err);
                    }
                }
            }
            #endregion

            // Create default user account
            // var adminUser = new ApplicationUser
            // {
            //     UserName = "admin",
            //     FullName = "Admin Ông Bầu",
            //     Email = model.Email,
            //     EmailConfirmed = true,  // 1 in SQL database
            // };
            // IdentityResult rsdefaultUser = await _userManager.CreateAsync(adminUser, "1234ongbau");

            var adminUser = await _userManager.FindByNameAsync("admin");
            var userId = adminUser.Id;

            // Assign roles to admin user
            if (adminUser != null)
            {
                await _userManager.AddToRoleAsync(adminUser, "Admin");
                await _userManager.AddToRoleAsync(adminUser, "Member");
                await _userManager.AddToRoleAsync(adminUser, "App Owner");

                return Ok(new
                {
                    succeeded = true,
                    message = "Assigning roles to Admin user completed successfully!",
                    errors = errors.ToArray()
                });
            }
            else
            {
                // use the AddRange method to add all the errors at once instead of looping through them one by one. This can be more efficient since it reduces the number of method calls and memory allocations
                errors.Add(new {
                    code = "admin not found",
                    description =  "ApplicationUser with username admin not found"
                });
            }

            return Ok(new
            {
                succeeded = false,
                message = "Assigning roles to admin user failed!",
                errors = errors.ToArray()
            });
            #region example success with-errors response object:
            //{
            //    "succeeded": true,
            //    "message": "All neccessary roles successfully created!",
            //    "errors": [
            //        {
            //            "code": "DuplicateRoleName",
            //            "description": "Role name 'Member' is already taken."
            //        },
            //        {
            //            "code": "DuplicateRoleName",
            //            "description": "Role name 'Admin' is already taken."
            //        }
            //    ]
            //}
            #endregion
            #region example failed with errors:
            //{
            //    "succeeded": false,
            //    "message": "Server setup failed!",
            //    "errors": [
            //        {
            //            "code": "DuplicateRoleName",
            //            "description": "Role name 'Member' is already taken."
            //        },
            //        {
            //            "code": "DuplicateRoleName",
            //            "description": "Role name 'Admin' is already taken."
            //        },
            //        {
            //            "code": "DuplicateRoleName",
            //            "description": "Role name 'App Owner' is already taken."
            //        },
            //        {
            //            "code": "InvalidEmail",
            //            "description": "Email 'string' is invalid."
            //        }
            //    ]
            //}
            #endregion
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
                // Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User
                
                // Fix warning: "Converting null literal or possible null value to non-nullable type.CS8600"
                Claim? userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID");

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
                // Claim userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID"); // ControllerBase.User

                // Fix warning: "Converting null literal or possible null value to non-nullable type.CS8600"
                Claim? userIdClaim = User?.Claims.FirstOrDefault(c => c.Type == "UserID");

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
