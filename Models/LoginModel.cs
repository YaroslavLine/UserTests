using System.ComponentModel.DataAnnotations;

namespace UserTests.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter Email")]
        [UIHint("email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter password")]
        [UIHint("password")]
        public string Password { get; set; }
    }
}