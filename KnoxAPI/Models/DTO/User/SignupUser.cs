using System;
using System.ComponentModel.DataAnnotations;

namespace KnoxAPI.Models.DTO
{
	public class SignupUser
	{
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}

