using System.ComponentModel.DataAnnotations;

namespace SmartExpenseTracker.API.DTOs
{
    public class RegisterDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
