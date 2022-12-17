using System;
using KnoxLogic.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KnoxAPI.Models
{
	public class Note
	{
        [Key]
        public int? Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }

        public int? UserId { get; set; }
    }
}

