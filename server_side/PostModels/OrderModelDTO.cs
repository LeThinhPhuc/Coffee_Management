using CoffeeShopApi.DTOs;
using CoffeeShopApi.Models.DomainModels;

namespace CoffeeShopApi.PostModels
{
    public class OrderModelDTO
    {
        //id của order (tự động tạo)
        //public string id { get; set; }

        //id của người tạo order (từ client gửi xuống)
        public string UserId { get; set; }

        public double Total {  get; set; }  


        //các item trong order đó
        public List<OrderItemModelDTO> OrderItems { get; set; }

    }
}
