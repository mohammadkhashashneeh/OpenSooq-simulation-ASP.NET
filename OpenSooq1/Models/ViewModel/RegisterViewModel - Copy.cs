using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSooq.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "UserName_Required")]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string UserName{ get; set; }
        [Required(ErrorMessage = "Email_Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password_Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm_Password_Required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password doesn't Match")]
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Mobile_Required")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        public string UserImg { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }

    }
}
