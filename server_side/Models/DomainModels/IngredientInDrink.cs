namespace CoffeeShopApi.Models.DomainModels
{
    using System.Text.Json.Serialization;
    using CoffeeShopApi.Models.Abstract;

    public class IngredientInDrink : BaseEntity
    {
        public string DrinkId { get; set; }

        [JsonIgnore]
        public Drink? Drink { get; set; }

        public string IngredientId { get; set; }

        [JsonIgnore]
        public Ingredient? Ingredient { get; set; }

        public int Quantity { get; set; }
    }
}