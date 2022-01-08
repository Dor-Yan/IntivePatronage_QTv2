using Microsoft.AspNetCore.Mvc;
using QT.Application.DTO;
using QT.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QT.Domain.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        // GET: api/<UserControler>
        [HttpGet]
        public ActionResult< ListUserForListDto> GetAllUsers()
        {
            var model = _userService.GetAllUsersForList();
            return model;
        }


        // GET api/<UserControler>/5
        [HttpGet("userDetails/{userId}")]
        public ActionResult< UserDetailsDto> GetUserDetails([FromRoute] int userId)
        {
            var userModel = _userService.GetUserDetails(userId);

            if (userModel == null)
            {
                return NotFound();
            }
            return userModel;
        }

        [HttpPost]
        [Route("addUser")]
        public IActionResult AddUser(NewUserDto model)
        {
            var id = _userService.AddUser(model);
            return NoContent();
        }

        [HttpGet]
        [Route("userId")]
        public UserDetailsDto EditUser(int id)
        {
            var reader = _userService.GetUserForEdit(id);
            return (UserDetailsDto)reader;
        }

        [HttpPost("{userId}")]
        public IActionResult EditUser(NewUserDto model)
        {
            _userService.UpdateUser(model);
            return NoContent();
        }

        

        // PUT api/<UserControler>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserControler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
