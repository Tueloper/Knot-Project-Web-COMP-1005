using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnoxAPI.Data;
using KnoxAPI.Models;
using KnoxAPI.Models.DTO;
using KnoxAPI.Models.DTO.Note;
//using KnoxAPI.Models.DTO.User;
using KnoxLogic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnoxAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public NoteController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult AddNote(NoteRequest addNoteData)
        {
  
                var user = _dbContext.Users.Find(addNoteData.UserId);

                if (user != null)
                {
                    var noteData = new Note
                    {
                        Id = KnoxLogic.Toolbox.generateId(),
                        Title = addNoteData.Title,
                        Content = addNoteData.Content,
                        Description = addNoteData.Description,
                        UserId = addNoteData.UserId
                    };

                    _dbContext.Notes.Add(noteData);
                    _dbContext.SaveChanges();

                    return Ok(noteData);
                }
                else
                {
                    Response.StatusCode = 404;
                    return BadRequest();
                }
                


        }


        [HttpGet]
        public IActionResult GetAllNotes()
        {
            var notes = _dbContext.Notes.ToList();

            var notesDTO = new List<NoteResponse>();

            foreach (var note in notes)
            {
                notesDTO.Add(new NoteResponse
                {
                    Id = note.Id,
                    Title = note.Title,
                    Description = note.Description,
                    Content = note.Content,
                    DateCreated = note.DateCreated,
                    LastModified = note.LastModified,
                    UserId = note.UserId,
                });
            }

            return Ok(notesDTO);
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetNoteById(int id)
        {
            var noteObject = _dbContext.Notes.Find(id);

            if (noteObject != null)
            {
                var noteDTO = new NoteResponse
                { 
                    Id = noteObject.Id,
                    Title = noteObject.Title,
                    Description = noteObject.Description,
                    Content = noteObject.Content,
                    DateCreated = noteObject.DateCreated,
                    LastModified = noteObject.LastModified,
                    UserId = noteObject.UserId,
                };

                return Ok(noteDTO);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateNote(int id, NoteRequest updateNoteData)
        {
            var existingNote = _dbContext.Notes.Find(id);

            if (existingNote != null)
            {
                existingNote.Title = updateNoteData.Title;
                existingNote.Description = updateNoteData.Description;
                existingNote.Content = updateNoteData.Content;

                _dbContext.SaveChanges();
                
                return Ok(existingNote);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult DeleteNote(int id)
        {
            var existingNote = _dbContext.Notes.Find(id);

            if (existingNote != null)
            {
                _dbContext.Notes.Remove(existingNote);

                _dbContext.SaveChanges();

                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
