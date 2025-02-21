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
    public class Shop:CommonProp
    {
        public int ShopId { get; set; }
        [Required(ErrorMessage ="Enter Shop Name")]
        [Display(Name = "Shop Name")]
        public string ShopName { get; set; }
        public string ShopDescription { get; set; }
        public string ShopImage { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }

        public string ShopCity { get; set; }
        public int CategoryId { get; set; }
     
        public Category Category { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
