using System.ComponentModel.DataAnnotations;

namespace UserApp.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "ReEnter.")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Password does not match.")]
        [Display(Name = "New Password.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "ConfirmNewPassword is require.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password.")]
        public string ConfirmNewPassword { get; set; }
    }
}
