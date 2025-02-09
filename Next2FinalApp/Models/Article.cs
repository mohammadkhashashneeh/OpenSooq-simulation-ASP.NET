using Next2FinalApp.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.Models
{
    public class Article : CommonProp
    {
        public int ArticleId { get; set; }

        [Required]
        public string ArticleTitle { get; set; }

        [Required]
        public string ArticleImg { get; set; }

        [Required]
        public string ArticleDescription { get; set; }

        public string UserId{ get; set; }
        public User User { get; set; }

    }
}
