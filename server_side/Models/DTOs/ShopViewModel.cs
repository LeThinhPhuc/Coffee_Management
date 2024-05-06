namespace CoffeeShopApi.Models.DTOs
{
    public class ShopViewModel
    {
        public string? Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OwnerId { get; set; }
        public string OwnerFullName {get; set; }
        // For suspension
        public bool IsSuspended { get; set; }
        public string? FormattedSuspensionEndDate { get; set; }
        public string? FormattedDateCreated { get; set; }
        public string? FormattedDateModified { get; set; }
        public double Revenue { get; set; } //  (Tổng doanh thu của cửa hàng)
    }
}