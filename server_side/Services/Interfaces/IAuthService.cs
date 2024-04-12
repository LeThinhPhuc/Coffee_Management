namespace CoffeeShopApi.Services.Interfaces
{
    using Models.DomainModels;
    using Models.DTOs;

    public interface IAuthService
    {
        //Task<AuthResult> RegisterEFAsync(RegisterModel model, RemoteIpAddress? ip, string? userAgent);
        Task<List<object>> GetAllUsersAsync();        Task<AuthResult> LoginEFAsync(LoginModel model, string? userAgentString);
        // Task<AuthResult> Refresh(RefreshTokenRequest model);
        Task<Microsoft.AspNetCore.Identity.IdentityResult> ChangePasswordAsyncEF(string userId, string oldPassword, string newPassword);
        Task<Microsoft.AspNetCore.Identity.IdentityResult> ChangeUserInfoAsyncEF(string userId, string fullName, string email);
    }
}