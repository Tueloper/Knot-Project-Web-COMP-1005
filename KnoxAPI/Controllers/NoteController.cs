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
            try
            {
                var user = _dbContext.Userss.Find(addNoteData.UserId);

                if (user != null)
                {
                    var noteData = new Note
                    {
                        Id = KnoxLogic.Toolbox.generateId(),
                        Title = addNoteData.Title,
                        Description = addNoteData.Description,
                        UserId = addNoteData.UserId
                    };

                    _dbContext.Notess.Add(noteData);
                    _dbContext.SaveChanges();

                    return Ok(noteData);
                }
                else
                {
                    Response.StatusCode = 404;
                    return BadRequest();
                }
                
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return (IActionResult)ex;
            }

        }


        [HttpGet]
        public IActionResult GetAllNotes()
        {
            var notes = _dbContext.Notess.ToList();

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
                    User = note.User
                });
            }

            return Ok(notesDTO);
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetNoteById(string id)
        {
            var noteObject = _dbContext.Notess.Find(id);

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
                    User = noteObject.User
                };

                return Ok(noteDTO);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult UpdateNote(string id, NoteRequest updateNoteData)
        {
            var existingNote = _dbContext.Notess.Find(id);

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
        public IActionResult DeleteNote(string id)
        {
            var existingNote = _dbContext.Notess.Find(id);

            if (existingNote != null)
            {
                _dbContext.Notess.Remove(existingNote);

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
