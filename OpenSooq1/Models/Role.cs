using OpenSooq.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSooq.Models
{
    public class Role : CommonProp
    {
        public int RoleId { get; set; }
        [Required(ErrorMessage ="Enter Role Name")]
        public string RoleName { get; set; }
    }
}
