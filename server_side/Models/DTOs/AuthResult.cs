namespace CoffeeShopApi.Models.DTOs
{
    public class AuthResult
    {
        public bool Succeeded { get; set; }
        public object[]? Errors { get; set; }
        public string? AccessToken { get; set; }
        public ApplicationUserViewModel? user { get; set; }
        public DateTime? Expiration { get; set; }
        public string? ValidFor { get; set; }
    }
}