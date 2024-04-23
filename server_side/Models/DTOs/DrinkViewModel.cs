namespace CoffeeShopApi.Models.DTOs
{
    public class DrinkViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public string? ImagePath { get; set; }
        public string? DrinkTypeId { get; set; }
        public string? DrinkTypeName { get; set; }
        public int? Quantity { get; set; }
    }
}