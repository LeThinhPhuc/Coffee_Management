﻿using CoffeeShopApi.Models.DomainModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CoffeeShopApi.Models.Abstract;

namespace CoffeeShopApi.DTOs
{
    public class OrderItemDTO : BaseEntity
    {
        
        [Required]
        public int? Quantity { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string? Note { get; set; }

        public DrinkDTO? Drink { get; set; }
    }
}
