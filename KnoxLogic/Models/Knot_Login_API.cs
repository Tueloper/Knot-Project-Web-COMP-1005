using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnoxLogic.Models
{
    public class Knot_Login_API
    {
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
        
        [Required]
        [StringLength(10, MinimumLength = 8)]
        public string UserPassword { get; set; }
    }
}
