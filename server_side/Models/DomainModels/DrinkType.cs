namespace CoffeeShopApi.Models.DomainModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    using CoffeeShopApi.Models.Abstract;

    public class DrinkType : BaseEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string Name { get; set; } = "Untitled DrinkType";


        // 2 properties for binding to Shop (1 Shop - n DrinkType)
        public string ShopId { get; set; }

        [JsonIgnore]
        public Shop? Shop { get; set; }

        // 1 property for binding to Drink (1 DrinkType - n Drink)
        [JsonIgnore]
        public List<Drink> Drinks { get; set; }
    }
}