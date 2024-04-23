using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApi.PostModels
{
    public class OrderItemModelDTO
    {

        [Required]
        public string DrinkId { get; set; }

        [Required]
        public int? Quantity { get; set; }

        public string? Note { get; set; }
    }
}
