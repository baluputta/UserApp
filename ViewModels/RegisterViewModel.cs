using System.ComponentModel.DataAnnotations;

namespace UserApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "ReEnter.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword is require.")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
