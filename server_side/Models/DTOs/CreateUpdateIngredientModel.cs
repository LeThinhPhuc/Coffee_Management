namespace CoffeeShopApi.Models.DTOs
{
    using System.ComponentModel.DataAnnotations;


    public class CreateUpdateIngredientModel
    {
        [Required]
        public string? Id {get; set;}
        public string Name { get; set; }

        public double Amount { get; set; }

        public DateTime ExpiryDate { get; set; }

        // Nhóm đã thống nhất Server không handle file mà ? Dùng URL Cloudinary bên ClientSide
        // public IFormFile ImageFile { get; set; }
        public string? ImagePath { get; set; }
    }
}