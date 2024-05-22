namespace CoffeeShopApi.Models.DTOs
{
    using Models.DomainModels;


    public class SuspenseResult
    {
        public bool Succeeded { get; set; }
        public object[]? Errors { get; set; }
        public bool IsSuspended { get; set; }
    }
}