namespace CoffeeShopApi.Models.DomainModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    using CoffeeShopApi.Models.Abstract;

    public class Ingredient : BaseEntity
    {
        // [Required]
        // [Column(TypeName = "nvarchar(100)")]
        // [MaxLength(100)]
        // public string IngredientId { get; set; } // already derived Id from BaseEntity !!!

        [Required]
        public string? Name{ get; set; } = "Untitled Ingredient";

        public double Amount { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public string? Image { get; set; }

        // 1 property for binding to IngredientInDrink (1 Ingredient - n IngredientInDrink)
        [JsonIgnore]
        public List<IngredientInDrink>? IngredientInDrinks { get; set; }
    }
}