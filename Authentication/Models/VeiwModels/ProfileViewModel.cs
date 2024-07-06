using System.ComponentModel.DataAnnotations;

namespace Authentication.Models.VeiwModels
{
    public class ProfileViewModel
    {

        public string Name { get; set; }

       
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string CurrentPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; }
    }

}
