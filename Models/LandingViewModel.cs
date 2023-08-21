
using System.ComponentModel.DataAnnotations;

namespace Await_DotNet_PrototypeVersion_2.Models
{
    public class SignInViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class CreateAccountViewModel
    {
        [Required(ErrorMessage = "User name is required!")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }
    }

    public class UpdateAccountViewModel
    {

    }
}
