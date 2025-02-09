using Next2FinalApp.SharedProp;
using System.ComponentModel.DataAnnotations;

namespace Next2FinalApp.Models
{
    public class Instructor : CommonProp
    {
        public int InstructorId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string InstructorName { get; set; }

        [Required]
        [Display]
        public string InstructorImg { get; set; }

        [Required]
        [Display]
        public string Position { get; set; }

        public string FB { get; set; }
        public string TW { get; set; }
    }
}
