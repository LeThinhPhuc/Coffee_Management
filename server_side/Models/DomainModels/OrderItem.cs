namespace CoffeeShopApi.Models.DomainModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    using CoffeeShopApi.Models.Abstract;

    public class OrderItem : BaseEntity
    {
        [Required]
        public string OrderId { get; set; }

        [Required]
        public string? DrinkId { get; set; }

        [Required]
        public int? Quantity { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string? Note { get; set; }

        [JsonIgnore]
        public Order? Order { get; set; }

        [JsonIgnore]
        public Drink? Drink { get; set; }
    }
}