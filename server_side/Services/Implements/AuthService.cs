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
            // large overhead due to loop
            /*
            var usersWithShops = await _context.Users
            .Include(u => u.Shops) // Include the shops associated with each user
            .ToListAsync();

            var result = new List<object>();

            foreach (var user in usersWithShops)
            {
                // Get user roles
                var userRoles = await _userManager.GetRolesAsync(user);

                // Map user and roles to anonymous object
                var userObject = new
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    FullName = user.FullName,
                    Email = user.Email,
                    Roles = userRoles, // Assign roles to the Roles property
                    Shops = user.Shops.Select(shop => new
                    {
                        ShopId = shop.Id,
                        ShopName = shop.Name,
                        ShopAddress = shop.Address,
                        ShopRevenue = shop.Revenue
                    }).ToList()
                };

                result.Add(userObject);
            }

            return result;
            */


            // direct LinQ
            var result = await _context.Users
            .Include(u => u.Shops) // Include the shops associated with each user
            .Select(user => new
            {
                UserId = user.Id,
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                Roles = _context.UserRoles
                            .Where(ur => ur.UserId == user.Id)
                            .Join(_context.Roles,
                                ur => ur.RoleId,
                                role => role.Id,
                                (ur, role) => role.Name)
                            .ToList(),
                Shops = user.Shops.Select(shop => new
                {
                    ShopId = shop.Id,
                    ShopName = shop.Name,
                    ShopAddress = shop.Address,
                    ShopRevenue = shop.Revenue
                }).ToList()
            })
            .ToListAsync();

            // Explicitly cast the result to a list of objects
            return result.ToList<object>();
        }


        // only username, not email & phoneNumber
        // can only login by username
        public async Task<AuthResult> LoginEFAsync(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserNameOrEmailOrPhoneNumber);

            // debug print:
            if (user != null)
            {
                // Console.WriteLine("User found: " + user.ToString());
                var result = await _userManager.CheckPasswordAsync(user, model.Password);
                // Console.WriteLine("Pass compare result: " + result.ToString());
            }
            else
            {
                // Serialize the object to JSON format
                string json = JsonConvert.SerializeObject(model);

                // Print the JSON string
                Console.WriteLine("User not found for the input model: " + json);
            }

            // Check whether his first Shop is approved or not
            var firstShopOfUser = await _context.Shops
                    .Where(s => s.OwnerId == user.Id)
                    .FirstOrDefaultAsync();
            
            if (!firstShopOfUser.IsApproved) {
                // prohibit login access if his Shop not approved
                // these below code will slow down the respond time
                List<object> errors = new List<object>
                {
                    // user's provided password doesnt match any record in DB
                    new
                    {
                        code = "ShopAwaitingApproval",
                        description = "Your bussiness is awaiting for Admin approval. Try again later!"
                    }
                };

                return new AuthResult
                {
                    Errors = errors.ToArray()
                };
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
                    //Errors = new[] { "Incorrect username or password!" }
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

            // Get the Bussiness associated with the user
            var shops = await _context.Shops.Where(s => s.OwnerId == user.Id).ToListAsync();


            // (LocalStorage way, no Cookie): return the user info together with accesstoken
            ApplicationUserViewModel uservm = new ApplicationUserViewModel 
            {
                IdToUpdate = user.Id,
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                //Roles = string.Join(", ", roles.ToList())
                Roles = roles.ToList()
                // DateJoined = user.DateJoined
            };



            // Bind RefreshToken to ApplicationUser:
            // user.RefreshToken = refreshToken;
            // user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);


            // (No Hangfire): Save RefreshToken & RefreshTokenExpiryTime to DB before API respond
            // _context.SaveChanges();


            return new AuthResult
            {
                Succeeded = true,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(accessToken),
                // RefreshToken = refreshToken,
                user = uservm,
                Shops = shops, // Assign the retrieved shop to the Shop property
                Expiration = accesstokenValidTo,
                ValidFor = $"{(int)accessTokenExpiresIn.TotalHours} hours, {(int)accessTokenExpiresIn.TotalMinutes % 60} minutes"
            };

        }

        // Took around 68ms to show success register result
        public async Task<AuthResult> RegisterAsync(RegisterModel model)
        {
            // NOTE: must seperate RegisterModel, LoginModel, UserViewModel
            // cuz [JsonIgnore] will make the system skip damn the password -> password =""  !!!!!

            List<object> errors = new List<object>(14);

            string roleToSet = "Member";  // initial default role

            // direct assign (use tinymapper if you want)
            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName
                // DateJoined is automatically initialized in ApplicationUser class
            };

            try
            {
                // create role if not exist:
                bool isRoleExist = await _roleManager.RoleExistsAsync(roleToSet); // take in roleName(string)
                if (!isRoleExist)
                {
                    var newRole = new IdentityRole(roleToSet);
                    IdentityResult rsNewRole = await _roleManager.CreateAsync(newRole);
                    if (!rsNewRole.Succeeded)
                    {
                        errors.AddRange(rsNewRole.Errors);
                    }
                }

                // Try to create the user
                IdentityResult rsRegister = await _userManager.CreateAsync(applicationUser, model.Password);

                if (rsRegister.Succeeded)
                {
                    // assign role to user:
                    await _userManager.AddToRoleAsync(applicationUser, roleToSet);

                    #region (Background Job Scheduling) Mail Send
                    // BackgroundJob.Enqueue(() => SendConfirmationEmail(applicationUser));
                    #endregion

                    // Create a shop for the user
                    var shop = new Shop
                    {
                        Name = model.BussinessName, // Use the provided business name
                        Address = model.BussinessAdress, // Use the provided business address
                        OwnerId = applicationUser.Id, // Assign the owner ID to the user's ID
                        Revenue = 0
                    };

                    // Save the shop to the database
                    await _context.Shops.AddAsync(shop);
                    await _context.SaveChangesAsync();

                    //_logger.LogInformation($"\nNew user registered (UserName: {applicationUser.UserName})\n");
                }
                else
                {
                    #region old foreach way:
                    //foreach (var err in rsRegister.Errors)
                    //{
                    //    errors.Add(err);
                    //}
                    #endregion
                    // use the AddRange method to add all the errors at once instead of looping through them one by one. This can be more efficient since it reduces the number of method calls and memory allocations
                    errors.AddRange(rsRegister.Errors);
                }



                // if rsRegister failed, still return Ok with the errors
                return new AuthResult
                {
                    Succeeded = rsRegister.Succeeded,
                    Errors = errors.ToArray()
                }; // always status 200 though errors occured , good!! and secure
            }
            catch (Exception ex)
            {
                // only for status 500, internal server err
                //throw ex; // cause a mess
                errors.Add(ex.Message);
                return new AuthResult { Errors = errors.ToArray() };
            }
        }

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

    }
}
