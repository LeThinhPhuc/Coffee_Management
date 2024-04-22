namespace CoffeeShopApi.Models.DTOs
{
    public class RegisterModel
    {
        // If you don't allow people to change their usernames then
        // some people are just going to create new accounts.
        // I don't see any security risk in this, and many apps including SO allow you
        // to change your name. If you change the name, keep the userid (primary key)
        // the same so all of the data links up properly.
        public string UserName { get; set; } = "Default";
        public string Email { get; set; } = "default@default.com";

        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = "Default";
        public string BussinessName { get; set; } // Add property for Shop name
        public string? BussinessAdress { get; set; } // Add property for Shop address
    }
}
