using System;
using System.ComponentModel.DataAnnotations;

namespace KnoxAPI.Models.DTO
{
	public class UserResponse
	{
        public int? Id { get; set; }

        public string? Name { get; set; }
   
        public string? Email { get; set; }
    }
}

