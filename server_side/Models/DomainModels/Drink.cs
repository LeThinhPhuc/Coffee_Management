namespace CoffeeShopApi.Models.DomainModels
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using Models.Abstract;
    using System.Text.Json.Serialization;

    public class Drink : BaseEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string? Name { get; set; } = "Untitled Drink";

        public double Price { get; set; }

        public string? ImagePath { get; set; }

        [Required]
        public string DrinkTypeId { get; set; }

        [JsonIgnore]
        public DrinkType? DrinkType { get; set; }


        // 1 property for binding to IngredientInDrink (1 Drink - n IngredientInDrink)
        [JsonIgnore]
        public List<IngredientInDrink>? Ingredients { get; set; }
    }
}