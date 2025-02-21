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
    public class ProductShop : CommonProp
    {
        public int ProductShopId { get; set; }
        [Required
            (ErrorMessage ="Enter Product Name")]
        public string ProductName { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string ProductDesc { get; set; } 

        
        public string ProductImg { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }


        [Required]
        public decimal Price { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        
    }
   

}
