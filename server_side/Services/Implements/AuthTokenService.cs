namespace CoffeeShopApi.Services.Implements
{
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using Services.Interfaces;
    using System.Security.Cryptography;
    using Models.DomainModels;

    public class AuthTokenService : IAuthTokenService
    {
        private readonly IConfiguration _configuration; // .NET 6+ way of getting env variable

        public AuthTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<JwtSecurityToken?> GenerateAccessTokenAsync(ApplicationUser user, IEnumerable<string> roles, bool rememberMe)
        {
            var authClaims = new List<Claim>
            {
                new Claim("UserID", user.Id.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                // new Claim(ClaimTypes.Email, user.Email),
                // new Claim(ClaimTypes.DateOfBirth, ""),
            };
            authClaims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var authSecretSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["ApplicationSettings:JWT_Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["ApplicationSettings:JWT_Issuer"],
                audience: _configuration["ApplicationSettings:Jwt_Audience"],

                // if rememberMe = true => set to expires in a year, else expires in 1 hour
                expires: rememberMe ? DateTime.UtcNow.AddYears(1) : DateTime.UtcNow.AddHours(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSecretSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
            //return new JwtSecurityTokenHandler().WriteToken(token);
        }


        // asynchronous wrap
        public async Task<string> GenerateRefreshTokenAsync()
        {
            var refreshToken = await Task.FromResult(GenerateRefreshToken());
            return refreshToken;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }


        // asynchronous wrapping
        public async Task<ClaimsPrincipal> GetPrincipalFromExpiredTokenAsync(string token)
        {
            return await Task.FromResult(GetPrincipalFromExpiredToken(token));
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = GetValidationParameters();

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;

            try
            {
                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
                var jwtSecurityToken = securityToken as JwtSecurityToken;
                if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                    throw new SecurityTokenException("Invalid token");

                return principal;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception caught] GetPrincipalFromExpiredToken failed: ", ex);
                throw new SecurityTokenException("Invalid signature");
            }
        }

        private TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters
            {
                RequireExpirationTime = true,
                ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["ApplicationSettings:JWT_Secret"])),
                ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
            };
        }

    }
}
