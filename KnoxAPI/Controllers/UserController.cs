using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KnoxAPI.Models.DTO;
using KnoxLogic;
using KnoxAPI.Data;
using KnoxLogic.Models;

namespace KnoxAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly AppDbContext _dbContext;

        public UserController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult SignUp(SignupUser userSignupData)
        {

                var user = new User
                {
                    Id = KnoxLogic.Toolbox.generateId(),
                    Name = userSignupData.Name,
                    Email = userSignupData.Email,
                    Password = userSignupData.Password
                };

                _dbContext.Userss.Add(user);
                _dbContext.SaveChanges();

                return Ok(user);

        }


        [HttpPost]
        public IActionResult Login(LoginUser userLoginData)
        {
            var user = _dbContext.Userss.Find(userLoginData.Email);

            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Profile(string id)
        {
            var userObject = _dbContext.Userss.Find(id);

            if (userObject != null)
            {
                var userDTO = new UserResponse
                {
                    Id = userObject.Id,
                    Email = userObject.Email,
                    Name = userObject.Name
                };

                return Ok(userDTO);
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
