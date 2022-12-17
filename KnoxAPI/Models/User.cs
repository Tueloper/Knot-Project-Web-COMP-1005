using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using KnoxAPI.Models;

namespace KnoxLogic.Models
{
    public class User : IdentityUser
    {
        [Key]
        [Required]
        public int? Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string? Password { get; set; }

        public ICollection<Note>? Notes { get; set; }
    }
}
