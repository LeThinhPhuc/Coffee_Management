namespace CoffeeShopApi.Models.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class CreateUpdatOrderModel
    {
        public string? Id { get; set; }
        [Required]
        public List<DrinkOrderModel>? Drinks { get; set; }
        public string? Note { get; set; }
    }

    public class DrinkOrderModel
    {
        [Required]
        public string? DrinkId { get; set; }
        // [Required]
        // public double Price { get; set; }  // Lazy: thuận tiện, đỡ phải truy vấn get Price by Id
        [Required]
        public int Quantity { get; set; }
    }
}