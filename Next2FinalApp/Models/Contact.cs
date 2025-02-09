using Next2FinalApp.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.Models
{
    public class Contact : CommonProp
    {
        public int ContactId { get; set; }


        [Required(ErrorMessage = "Enter Title")]
        [Display(Name = "Title")]
        public string ContactTitle { get; set; }


        [Required(ErrorMessage = "Select Location")]
        [Display(Name = "Map")]
        public string ContactSMap { get; set; }


        [Required(ErrorMessage = "Enter Description")]
        [Display(Name = "Description")]
        public string ContactDescription { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public decimal ContactPhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string ContactEmail { get; set; }



        [Required]
        [Display(Name = "Adress")]
        public string ContactAdress { get; set; }
        public string ContactUserTitle { get; set; }
        public string ContactUserDescription { get; set; }

        public string ContactUserName { get; set; }
        public string ContactUserEmail { get; set; }
        public string ContactUserSubject { get; set; }
        public string ContactMessage { get; set; }


    }
}
