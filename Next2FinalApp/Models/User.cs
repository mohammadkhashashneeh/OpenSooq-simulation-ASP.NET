using Next2FinalApp.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.Models
{
    public class User : CommonProp
    {
        public int UserId { get; set; }


        [Required(ErrorMessage ="Enter UserName")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [Display(Name = "Paessword")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Mobile")]
        [Display(Name = "Mobile")]
        public string Mobile { get; set; }


        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Adress")]
        [Display(Name = "Adress")]
        public string Adress { get; set; }


        [Required(ErrorMessage = "Upload Image")]
        [Display(Name = "UserImage")]
        public string UserImage { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        [Required(ErrorMessage = "Choose Gender")]
        [Display(Name = "Gender")]
        public Genderz Gender { get; set; }
        public enum Genderz
        {
            Male,Female
        }



    }
}
