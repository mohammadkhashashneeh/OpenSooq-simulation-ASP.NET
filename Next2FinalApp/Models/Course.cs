using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Next2FinalApp.SharedProp;
using System.Threading.Tasks;

namespace Next2FinalApp.Models
{
    public class Course :CommonProp
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Enter CourseName")]
        [Display(Name = "CourseName")]
        [DataType(DataType.MultilineText)]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Enter CourseDesc")]
        [Display(Name = "CourseDesc")]
        public string CourseDesc { get; set; }
        

        [Required(ErrorMessage = "Enter courseimg")]
        [Display(Name = "course img")]
        public string courseimg { get; set; }


        [Required(ErrorMessage = "Enter StartDate")]
        [Display(Name = "StartDate")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Enter StartTime")]
        [Display(Name = "StartTime")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "Enter Duration")]
        [Display(Name = "Duration")]
        public string Duration { get; set; }

        [Required(ErrorMessage = "Enter Hours")]
        [Display(Name = "Hours")]
        public int Hours { get; set; }

        [Required(ErrorMessage = "Enter Venu")]
        [Display(Name = "Venu")]
        public string Venu { get; set; }

        [Required(ErrorMessage = "Enter BtnTxt")]
        [Display(Name = "BtnTxt")]
        public string BtnTxt { get; set; }

        [Required(ErrorMessage = "Enter Price")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Enter PriceAfterDiscount")]
        [Display(Name = "PriceAfterDiscount")]
        public decimal PriceAfterDiscount { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public enum Venus
        {
            Online,Offline,Recorded
        }
    }
}
