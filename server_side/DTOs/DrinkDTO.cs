using CoffeeShopApi.Models.Abstract;
using CoffeeShopApi.Models.DomainModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CoffeeShopApi.DTOs
{
    public class DrinkDTO : BaseEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string? Name { get; set; } = "Untitled Drink";

        public double Price { get; set; }
        [Required]
        public string DrinkTypeId { get; set; }
       
    }
}
