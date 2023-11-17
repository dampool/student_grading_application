using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stud_rec.Models
{
    
    
        public class ExternalLoginConfirmationViewModel
        {
            [Required]
            [Display(Name = "Email")]
            public string EmailId { get; set; }
        }
        public class ManageUserViewModel
        {
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Current password")]
            public string OldPassword { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }
        public class LoginViewModel
        {
            [Required]
            [Display(Name = "Matric Number")]
            public string MatricNumber { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }
        public class RegisterViewModel
        {
            //public int RegisterViewModelId { get; set; }

            [Required(ErrorMessage = "Please Enter your first name", AllowEmptyStrings = false)]
            [DisplayName("First Name")]
            [RegularExpression(@"^[a-zA-Z'.\s]{1,40}$", ErrorMessage = "Special Characters not allowed")]
            [StringLength(50, MinimumLength = 4, ErrorMessage = "Not Less than 4 characters")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Please Enter Last name", AllowEmptyStrings = false)]
            [DisplayName("Last Name")]
            [RegularExpression(@"^[a-zA-Z'.\s]{1,40}$", ErrorMessage = "Special Characters not allowed")]
            [StringLength(50, MinimumLength = 4, ErrorMessage = "Not Less than 4 characters")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Please enter your matric number", AllowEmptyStrings = false)]
            [DisplayName("Matric Number")]
            [StringLength(50, MinimumLength = 4, ErrorMessage = "Not less than 2 characters")]
            public string MatricNumber { get; set; }

            [Required(ErrorMessage = "Please Enter a valid email", AllowEmptyStrings = false)]
            [DisplayName(" Email")]
            [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email Format is wrong")]
            [StringLength(50, MinimumLength = 4)]
            [EmailAddress]
            public string EmailId { get; set; }

            [Required(ErrorMessage = "please enter your department", AllowEmptyStrings = false)]
            [DisplayName("Department")]
            [StringLength(50, MinimumLength = 4, ErrorMessage = "Not less than 4 characters")]
            public string Department { get; set; }

            [Required(ErrorMessage = "Please enter your level", AllowEmptyStrings = false)]
            [DisplayName("Level")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Not less than 3 characters")]
            public string Level { get; set; }

            [Required(ErrorMessage = "Please enter password", AllowEmptyStrings = false)]
            [DisplayName("Password")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required(ErrorMessage = "Please Enter this field", AllowEmptyStrings = false)]
            [DisplayName("Confirm Password")]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "Password did not match")]
            public string ConfirmPassword { get; set; }
        }

    }
