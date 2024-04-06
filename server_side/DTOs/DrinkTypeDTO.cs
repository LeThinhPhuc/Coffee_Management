using CoffeeShopApi.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApi.DTOs
{
    public class DrinkTypeDTO : BaseEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string Name { get; set; } = "Untitled DrinkType";
    }
}
