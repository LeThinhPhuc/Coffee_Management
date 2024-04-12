namespace CoffeeShopApi.Models.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class CreateUpdateDrinkModel
    {
        // When creating a drink, you can omit the Id field, and when updating a drink,
        // you can provide the Id along with the other updated fields
        public string Id { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        public string? ImagePath { get; set; }

        [Required]
        public string DrinkTypeId { get; set; }
    }

}