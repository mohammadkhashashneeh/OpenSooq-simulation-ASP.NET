using Next2FinalApp.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.Models
{
  
        public class Category : CommonProp
        {
            public int CategoryId { get; set; }
            [Required(ErrorMessage = "Enter Category Name")]
            [Display(Name = "Category Name")]
            public string CategoryName { get; set; }
        }
    
}
