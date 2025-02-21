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
    public class Vendor : CommonProp
    {
        public int VendorId { get; set; }
        [Required(ErrorMessage = "Enter Vendor Name")]
        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }
        public string VendorImage { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }



    }
}
