using System;
namespace KnoxAPI.Models.DTO.Note
{
	public class NoteRequest
	{
        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? Description { get; set; }

        public int? UserId { get; set; }
    }
}

