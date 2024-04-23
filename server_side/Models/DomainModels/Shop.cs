namespace CoffeeShopApi.Models.DomainModels
{
    using System.ComponentModel.DataAnnotations;
    using Models.Abstract;
    using System.Text.Json.Serialization;

    public class Shop : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }


        // 2 properties for binding to ApplicationUser (1 ApplicationUser - n Shop):
        //      1. Foreign key for ApplicationUser (Owner)
        public string OwnerId { get; set; }

        //      2. Navigation property for ApplicationUser (Owner)
        [JsonIgnore]
        public virtual ApplicationUser? Owner { get; set; }

        // For suspension
        public bool IsSuspended { get; set; } = false;
        public DateTime? SuspensionEndDate { get; set; }

        // Navigation property for DrinkTypes
        [JsonIgnore]
        public virtual List<DrinkType>? DrinkTypes { get; set; }

        // Navigation property for VoucherCodes
        [JsonIgnore]
        public virtual List<VoucherCode>? VoucherCodes { get; set; }

        public double Revenue { get; set; } //  (Tổng doanh thu của cửa hàng)
    }
}