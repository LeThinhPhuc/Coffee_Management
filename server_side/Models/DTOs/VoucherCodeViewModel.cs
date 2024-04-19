namespace CoffeeShopApi.Models.DTOs
{
    using System;

    public class VoucherCodeViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }        // Code
        public double? DiscountPercent { get; set; }
        public string? ShopId { get; set; } // maybe retrieve shopname instead
        public bool? IsActive { get; set; }
        public string? FormattedStartDate { get; set; }
        public string? FormattedEndDate { get; set; }
    }
}
