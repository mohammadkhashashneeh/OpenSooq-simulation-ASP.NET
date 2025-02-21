using OpenSooq.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSooq.Models
{
    public class Menu : CommonProp
    {
        public int MenuId{ get; set; }
        [Required(ErrorMessage = "Enter Title")]
        [Display(Name ="Title")]
        public string MenuTitle{ get; set; }
        [Required]
        [Display(Name = "Menu Controller")]
        public string MenuController { get; set; }
        [Required]
        [Display(Name = "Menu Action")]
        public string MenuAction { get; set; }
    }
}
