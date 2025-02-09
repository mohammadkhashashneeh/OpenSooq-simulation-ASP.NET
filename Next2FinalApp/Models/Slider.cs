using Next2FinalApp.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.Models
{
    public class Slider : CommonProp
    {
        public int SliderId { get; set; }

        [Required(ErrorMessage = "Enter Title")] 
        [Display(Name = "Title")]
        public string SliderTitle { get; set; }

        [Required(ErrorMessage = "Enter Sub Title")]
        [Display(Name = "Sub Title")] 
        public string SliderSubTitle { get; set; }

        [Range(1, 100, ErrorMessage = "between 1 to 100")] 
        public int OfferPerc { get; set; }
        [Required(ErrorMessage = "Enter Price")] 
        [Display(Name = "Price")]
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public string BtnTxt { get; set; }
        public string Btnurl { get; set; }
        public string Sliderdesc { get; set; }
        public string SliderImg { get; set; }
    }
}
