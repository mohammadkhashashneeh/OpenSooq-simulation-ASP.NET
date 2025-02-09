using Next2FinalApp.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.Models
{
    public class Menu : CommonProp
    {
        public int MenuId { get; set; }


        [Required(ErrorMessage = "Enter Title")]
        [Display(Name = "Title")] 
        public string MenuTitle { get; set; }


        [Required(ErrorMessage = "Enter Sub Title")]
        [Display (Name = "Sub Title")] 
        public string MenuSubTitle { get; set; } 


        [Required(ErrorMessage = "Enter Url like http")] 
        [Display (Name = "Url")]
        [DataType (DataType.Url)]
        public string Menuurl { get; set; }
} }
