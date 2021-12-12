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
        public IQueryable<UserForListDto> GetAllUsers()
        {
            var model = _userService.GetAllUsersForList();
            return model;
        }


        // GET api/<UserControler>/5
        [HttpGet("{id}")]
        public UserDetailsDto GetUserDetails(int userId)
        {
            var userModel = _userService.GetUserDetails(userId);

            return userModel;
        }

        // POST api/<UserControler>
        [HttpPost]
        public IActionResult AddUser(NewUserDto model)
        {
            var id = _userService.AddUser(model);
            return RedirectToAction("Index");
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
