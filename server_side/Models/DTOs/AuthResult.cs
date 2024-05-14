namespace CoffeeShopApi.Models.DTOs
{
    using Models.DomainModels;


    public class AuthResult
    {
        public bool Succeeded { get; set; }
        public object[]? Errors { get; set; }
        public string? AccessToken { get; set; }
        public ApplicationUserViewModel? user { get; set; }
        public IList<Shop>? Shops { get; set; } // Add property for Bussiness class
        public DateTime? Expiration { get; set; }
        public string? ValidFor { get; set; }
    }
}