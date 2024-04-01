namespace CoffeeShopApi.Models.DomainModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;
    using Models.Abstract;

    public class VoucherCode : BaseEntity
    {

        [Required]
        public string? Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double? DiscountPercent { get; set; }

        // 2 properties for binding to Shop (1 Shop - n VoucherCode)
        public string ShopId { get; set; }
        
        [JsonIgnore]
        public Shop Shop { get; set; }
    }
}