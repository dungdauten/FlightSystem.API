using System.ComponentModel.DataAnnotations;

namespace FlightSystem.API.Models.Identity
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), Required(ErrorMessage = "Vui lòng nhập mật khẩu")]

        public string Password { get; set; }
        [DataType(DataType.Password), Required(ErrorMessage = "Vui lòng nhập lại mật khẩu")]
        public string ConfirmPassword { get; set; }
    }
}
