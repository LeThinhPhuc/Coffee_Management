using CoffeeShopApi.DTOs;
using CoffeeShopApi.Models.Abstract;
using CoffeeShopApi.Models.DomainModels;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApi.DTO
{
    public class OrderDTO : BaseEntity
    {
        [Required]
        public string? UserId { get; set; }

        [Required]
        public DateTime? OrderDate { get; set; }

        public double Total { get; set; }

        public ApplicationUserDTO? User { get; set; }

        public List<OrderItemDTO>? OrderItems { get; set; }
    }
}
