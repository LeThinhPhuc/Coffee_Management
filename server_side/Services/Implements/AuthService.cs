namespace CoffeeShopApi.Services.Implements
{
    using Models.DomainModels;
    using Microsoft.AspNetCore.Identity;
    using Models.DAL;
    using Models.DTOs;
    using Services.Interfaces;
    using System.IdentityModel.Tokens.Jwt;
    using Newtonsoft.Json;
    using Microsoft.EntityFrameworkCore;

    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAuthTokenService _authTokenService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _context; // for saving user logins history
                                                //private readonly IOldPasswordService _oldPasswordService;
                                                //private readonly IHubContext<ChatServiceHub> _chatHubContext;   //realtime message
                                                //private readonly IOnlineUserService _onlineUserService;     // online user storage
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;
        // private readonly string _connectionString;
        private readonly string _defaultPassword;

        public AuthService(//UserManager<ApplicationUser> userManager,
                           UserManager<ApplicationUser> userManager,
                           IAuthTokenService authTokenService,
                           RoleManager<IdentityRole> roleManager,
                           AppDbContext context,

                           //IOldPasswordService oldPasswordService,
                           //IOnlineUserService onlineUserService,
                           IServiceProvider serviceProvider,
                           IConfiguration configuration)
        {
            //_userManager = userManager;
            _userManager = userManager;
            _authTokenService = authTokenService;
            _roleManager = roleManager;
            _context = context;
            _serviceProvider = serviceProvider;
            _configuration = configuration;
            // _connectionString = _configuration.GetConnectionString("MSSQLConnection"); // specify to match your appsettings.json
            _defaultPassword = "Abc@123";
        }


        public async Task<List<object>> GetAllUsersAsync()
        {
            var usersWithShops = await _context.Users
                .Include(u => u.Shops) // Include the shops associated with each user
                .ToListAsync();

            var result = usersWithShops.Select(user => new
            {
                UserId = user.Id,
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                Shops = user.Shops.Select(shop => new
                {
                    ShopId = shop.Id,
                    ShopName = shop.Name,
                    ShopAddress = shop.Address,
                    ShopRevenue = shop.Revenue
                }).ToList()
            }).ToList<object>(); // Explicitly cast the result to a list of objects

            return result;
        }



        // only username, not email & phoneNumber
        // can only login by username
        public async Task<AuthResult> LoginEFAsync(LoginModel model, string? userAgentString)
        {
            var user = await _userManager.FindByNameAsync(model.UserNameOrEmailOrPhoneNumber);

            //debug:
            if (user != null)
            {
                Console.WriteLine("User found: " + user.ToString());
                var result = await _userManager.CheckPasswordAsync(user, model.Password);
                Console.WriteLine("Pass result: " + result.ToString());
            }
            else
            {
                // Serialize the object to JSON format
                string json = JsonConvert.SerializeObject(model);

                // Print the JSON string
                Console.WriteLine("User not found for the input model: " + json);
            }

            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
            {
                // reaching down here means "Login failed " !!
                // these below code will slow down the respond time
                List<object> errors = new List<object>
                {
                    // user's provided password doesnt match any record in DB
                    new
                    {
                        code = "InvalidCredentials",
                        description = "Incorrect username or password!"
                    }
                };

                return new AuthResult
                {
                    Errors = errors.ToArray()
                    //Errors = new[] { "Incorrect email or password!" }
                };
            }


            // reaching down here means "Success Login" !!

            var roles = await _userManager.GetRolesAsync(user);   // UserManager sucks
                                                                  //var roles = await GetUserRolesAsyncADO(user.Id);        // ADO.NET

            // calling the TokenService
            var accessToken = await _authTokenService.GenerateAccessTokenAsync(user, roles, model.RememberMe);
            var refreshToken = await _authTokenService.GenerateRefreshTokenAsync();

            // get token expiry to return to client:
            // Set the ValidTo for the access token based on "Remember Me" option
            var accesstokenValidTo = accessToken.ValidTo;

            // Set the expiration time for the access token based on "Remember Me" option
            var accesstokenExpiration = accessToken.ValidTo;
            var accessTokenExpiresIn = accesstokenExpiration - DateTime.UtcNow;


            // (LocalStorage way, no Cookie): return the user info together with accesstoken
            ApplicationUserViewModel uservm = new ApplicationUserViewModel
            {
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                //Roles = string.Join(", ", roles.ToList())
                Roles = roles.ToList()
            };



            // Bind RefreshToken to ApplicationUser:
            // user.RefreshToken = refreshToken;
            // user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);


            // (No Hangfire): Save RefreshToken & RefreshTokenExpiryTime to DB before API respond
            _context.SaveChanges();



            return new AuthResult
            {
                Succeeded = true,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(accessToken),
                // RefreshToken = refreshToken,
                user = uservm,
                Expiration = accesstokenValidTo,
                ValidFor = $"{(int)accessTokenExpiresIn.TotalHours} hours, {(int)accessTokenExpiresIn.TotalMinutes % 60} minutes"
            };

        }

        /*
        public async Task<AuthResult> Refresh(RefreshTokenRequest model)
        {
            // call tokenservice to extract principal
            var principal = await _authTokenService.GetPrincipalFromExpiredTokenAsync(model.AccessToken);
            var claims = principal.Claims; //this is mapped to the Name claim by default
            var username = principal.Identity.Name; //this is mapped to the Name claim by default

            var user = _context.Users.SingleOrDefault(u => u.UserName == username);

            // user's RefreshToken in database must equals to request RequestToken
            if (user == null || user.RefreshToken != model.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                return new AuthResult
                {
                    Succeeded = false,
                    AccessToken = null,
                    RefreshToken = null,
                    user = null,
                    Expiration = null,
                    ValidFor = null
                };

            // Reaching down here means refreshToken is match & still valid

            var roles = await _userManager.GetRolesAsync(user);


            // call services to get new tokens
            var newAccessToken = await _authTokenService.GenerateAccessTokenAsync(user, roles, false);
            var newRefreshToken = await _authTokenService.GenerateRefreshTokenAsync();

            var accesstokenExpiration = DateTime.UtcNow.AddHours(1);
            var accesstokenValidTo = newAccessToken.ValidTo;
            var accessTokenExpiresIn = accesstokenExpiration - DateTime.UtcNow;

            // re-assign user's RefreshToken in db
            user.RefreshToken = newRefreshToken;
            _context.SaveChanges();

            ApplicationUserViewModel uservm = new ApplicationUserViewModel
            {
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                //Roles = string.Join(", ", roles.ToList())
                Roles = roles.ToList()
            };


            return new AuthResult
            {
                Succeeded = true,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(newAccessToken),
                RefreshToken = newRefreshToken,
                user = uservm,
                Expiration = accesstokenValidTo,
                ValidFor = $"{(int)accessTokenExpiresIn.TotalHours} hours, {(int)accessTokenExpiresIn.TotalMinutes % 60} minutes"
            };
        }
        */

        public async Task<IdentityResult> ChangePasswordAsyncEF(string userId, string oldPassword, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            var currentHashedPassword = user.PasswordHash;

            // Note: Password must be '1234@Abc', one Alphabet,.... (usermanager's problem)
            var result = await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);

            if (!result.Succeeded)
            {
                return result;
            }

            return IdentityResult.Success;
        }
        public async Task<IdentityResult> ChangeUserInfoAsyncEF(string userId, string fullName, string email)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            // Thay đổi thông tin Full Name
            user.FullName = fullName;

            // Thay đổi thông tin Email
            user.Email = email;

            // Lưu thay đổi vào cơ sở dữ liệu
            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                return result;
            }

            return IdentityResult.Success;
        }

        public Task<AuthResult> LoginAsync(LoginModel model, string? userAgent)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
