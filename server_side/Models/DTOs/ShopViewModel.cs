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
        public DateTime? SuspensionEndDate { get; set; }
        public double Revenue { get; set; } //  (Tổng doanh thu của cửa hàng)
    }
}