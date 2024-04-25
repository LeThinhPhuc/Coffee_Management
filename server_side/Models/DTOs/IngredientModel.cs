using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApi.Models.DTOs
{
    public class IngredientCreateDto
    {
        [Required]
        public string Name { get; set; }

        public double Amount { get; set; }

        public DateTime ExpiryDate { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}