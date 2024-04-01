namespace CoffeeShopApi.Models.DomainModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;
    using CoffeeShopApi.Models.Abstract;

    public class Order : BaseEntity
    {
        [Required]
        public string? UserId { get; set; } // the staff who create(confirm) the order

        [Required]
        public DateTime? OrderDate { get; set; }

        public double Total { get; set; }

        [JsonIgnore]
        public ApplicationUser? User { get; set; }  // the staff who create(confirm) the order

        [JsonIgnore]
        public List<OrderItem>? OrderItems { get; set; }
        
    }
}