namespace CoffeeShopApi.Models.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class DrinkDailyRevenueViewModel
    {
        public string NameDrink { get; set; }
        public List<double> Total { get; set; }
    }
}