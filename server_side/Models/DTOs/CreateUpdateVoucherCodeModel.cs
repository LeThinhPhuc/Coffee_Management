namespace CoffeeShopApi.Models.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class CreateUpdateVoucherCodeModel
    {
        // When creating a vouchercode, you can omit the Id field, and when updating a vouchercode,
        // you can provide the Id along with the other updated fields
        public string Id { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double? DiscountPercent { get; set; }

        public string ShopId { get; set; }

        // [Required]
        // public string DrinkTypeId { get; set; }
    }

}