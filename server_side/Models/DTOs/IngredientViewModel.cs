namespace CoffeeShopApi.Models.DTOs
{

    public class IngredientViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double? Amount { get; set; }
        public string? FormattedExpiryDate { get; set; }
        public string? FormattedDateCreated { get; set; }  // for Minh
        public string? FormattedDateModified { get; set; } // for Minh
        public string? ImagePath { get; set; }
    }
}