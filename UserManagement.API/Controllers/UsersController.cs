using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Business.Abstract;
using UserManagement.Entities;

namespace UserManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users =await _userService.GetUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user =await _userService.GetUser(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task Create([FromBody]User user)
        {
            await _userService.CreateUser(user);
        }
        [HttpPut]
        public async Task Update([FromBody]User user)
        {
            await _userService.UpdateUser(user);
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await _userService.DeleteUser(id);
        }




        
    }
}
