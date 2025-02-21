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
    public class Category:CommonProp
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Enter Category Name")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }

        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }


    }
}
