using AutoMapper;
using CoffeeShopApi.DTOs;
using CoffeeShopApi.Models.DomainModels;

namespace CoffeeShopApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Order,OrderDTO>();    
            CreateMap<Drink,DrinkDTO>();
            CreateMap<ApplicationUser,ApplicationUserDTO>();
            CreateMap<OrderItem,OrderItemDTO>();
        }
    }
}
