using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CoffeeShopApi.DTOs
{
    public class ApplicationUserDTO : IdentityUser
    {
        [Column(TypeName = "nvarchar(150)")]
        [MaxLength(255)]
        public string? FullName { get; set; }
    }
}
