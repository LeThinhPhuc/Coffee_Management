using CoffeeShopApi.Models.Abstract;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApi.DTO
{
    public class ApplicationUserDTO : IdentityUser
    {
        [Column(TypeName = "nvarchar(150)")]
        [MaxLength(255)]
        public string? FullName { get; set; }
    }
}
