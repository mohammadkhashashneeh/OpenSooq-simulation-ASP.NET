using Microsoft.AspNetCore.Http;
using OpenSooq.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSooq.Models
{
    public class User : CommonProp
    {
        
        public int UserId { get; set; }
        [Required(ErrorMessage = "UserName_Required")]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password_Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Mobile_Required")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Start With 962")]
        public string Mobile { get; set; }


        [Required(ErrorMessage = "Email_Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public string UserImg { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        
    }
}
