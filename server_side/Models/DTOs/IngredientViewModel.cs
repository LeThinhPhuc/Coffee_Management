namespace CoffeeShopApi.Models.DTOs
{

    public class IngredientViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double? Amount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? ImagePath { get; set; }
    }
}