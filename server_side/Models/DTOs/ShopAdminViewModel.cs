namespace CoffeeShopApi.Models.DTOs
{
    using System;

    public class ShopAdminViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OwnerId { get; set; }
        public string? OwnerFullName { get; set; }
        public bool IsApproved { get; set; }
        public bool IsSuspended { get; set; }
        public DateTime? SuspensionEndDate { get; set; }
        public double Revenue { get; set; }
        public string? FormattedDateCreated { get; set; }
        public string? FormattedDateModified { get; set; }
        public List<DrinkTypeViewModel>? DrinkTypes { get; set; }
        public List<MinimalVoucherCodeViewModel>? VoucherCodes { get; set; }
    }

    public class DrinkTypeViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class MinimalVoucherCodeViewModel
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public double DiscountPercent { get; set; }
    }
}
