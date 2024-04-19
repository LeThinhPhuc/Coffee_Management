namespace CoffeeShopApi.Models.DTOs
{
    using System.ComponentModel.DataAnnotations;
    public class CreateUpdateDrinkTypeModel
    {
        // When creating a drinktype, you can omit the Id field, and when updating a drinktype,
        // you can provide the Id along with the other updated fields
        public string Id { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string ShopId { get; set; }
    }
}