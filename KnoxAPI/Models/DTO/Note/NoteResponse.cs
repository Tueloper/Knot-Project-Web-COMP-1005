using System;
using KnoxLogic.Models;

namespace KnoxAPI.Models.DTO.Note
{
	public class NoteResponse
	{
        public int? Id { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }

        public int? UserId { get; set; }
    }
}

