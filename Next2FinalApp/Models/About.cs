using Next2FinalApp.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.Models
{
    public class About : CommonProp
    {
        public int AboutId { get; set; }


        [Required(ErrorMessage = "Enter Title")]
        [Display(Name = "Title")] 
        public string AboutTitle { get; set; }


        [Required(ErrorMessage = "Select Image")]
        [Display (Name = "Image")] 
        public string AboutSImg { get; set; } 


        [Required(ErrorMessage = "Enter Description")] 
        [Display (Name = "Description")]
        public string AboutDescription { get; set; }

    }
}
