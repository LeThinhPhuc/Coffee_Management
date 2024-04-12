namespace CoffeeShopApi.Models.DTOs
{
    using System.ComponentModel.DataAnnotations;


    public class LoginModel
    {
        [Required(ErrorMessage = "Không để trống UserNameOrEmailOrPhoneNumber !!")]
        public string UserNameOrEmailOrPhoneNumber { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}