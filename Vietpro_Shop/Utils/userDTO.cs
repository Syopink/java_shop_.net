using System;
using System.ComponentModel.DataAnnotations;

namespace Vietpro_Shop.Utils
{
    public class UserDTO
    {
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Họ và tên phải từ 2 đến 50 ký tự")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [MinLength(6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Số điện thoại phải có 10-11 chữ số")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Quê quán không được để trống")]
        public string Address { get; set; }
    }
}
