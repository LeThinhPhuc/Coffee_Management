namespace CoffeeShopApi.Models.DTOs
{

    public class IngredientViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double? Amount { get; set; }
        public string? FormattedExpiryDate { get; set; }
        public string? FormattedDateCreated { get; set; } 
        public string? FormattedDateModified { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? DateCreated { get; set; }  // for Minh
        public DateTime? DateModified { get; set; } // for Minh
        public string? ImagePath { get; set; }
    }
}