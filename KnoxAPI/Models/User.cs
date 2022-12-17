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
    public class User
    {
        [Required]
        public int? Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
