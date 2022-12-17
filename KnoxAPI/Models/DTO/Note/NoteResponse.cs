using System;
using KnoxLogic.Models;

namespace KnoxAPI.Models.DTO.Note
{
	public class NoteResponse
	{
        public string? Id { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }

        public string? UserId { get; set; }

        public User? User { get; set; }
    }
}

