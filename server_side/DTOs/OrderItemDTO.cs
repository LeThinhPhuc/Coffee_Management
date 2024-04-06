using CoffeeShopApi.Models.Abstract;
using CoffeeShopApi.Models.DomainModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShopApi.DTOs
{
    public class OrderItemDTO : BaseEntity
    {
        [Required]
        public string OrderId { get; set; }

        [Required]
        public int? Quantity { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string? Note { get; set; }

        public DrinkDTO? Drink { get; set; }

    }
}
