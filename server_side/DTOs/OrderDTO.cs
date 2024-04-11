using CoffeeShopApi.Models.Abstract;
using CoffeeShopApi.Models.DomainModels;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CoffeeShopApi.DTOs
{
    public class OrderDTO : BaseEntity
    {

        [Required]
        public DateTime? OrderDate { get; set; }

        public double Total { get; set; }

        public ApplicationUserDTO? User { get; set; }  // the staff who create(confirm) the order

        public List<OrderItemDTO>? OrderItems { get; set; }
    }
}
