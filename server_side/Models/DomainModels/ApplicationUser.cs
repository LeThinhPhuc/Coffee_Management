
namespace CoffeeShopApi.Models.DomainModels
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ApplicationUser : IdentityUser
    {
        // additional properties will go here

        // https://www.entityframeworktutorial.net/efcore/one-to-many-conventions-entity-framework-core.aspx

        [Column(TypeName ="nvarchar(150)")]
        [MaxLength(255)]
        public string? FullName { get; set; }

        // 1 owner might own one or many shops.
         public List<Shop>? Shops { get; set; }

        // 1 owner can only own 1 shop. (1-1 relationship)
        //public virtual Shop Shop { get; set; }

        public IList<Order>? Orders { get; set; }   // track orders/bills this guy created in his shop

    }
}