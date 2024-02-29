using JWT.Domain.Entities;
using JWT.Domain.Enums;
using JWTLesson.Application.Services.UserServices;
using JWTLesson.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTLesson.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _usersService;

        public UsersController(IUserService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [FilterAttributeAuth(Permission.GetAllUsers)]
        public Task<List<User>> GetAllUsers()
        {
            var res = _usersService.GetAllUsers();
            return res;
        }
        [HttpGet]
        [FilterAttributeAuth(Permission.GetUsersById)]
        public Task<User> GetUsersById(int id)
        {
            Task<User>? res = _usersService.GetUserById(id);
            return res;
        }
        [HttpPost]
        [FilterAttributeAuth(Permission.CreateUser)]
        public Task<string> CreateUser(User user)
        {
            Task<string> res = _usersService.Create(user);
            return res;
        }
        [HttpPut]
        [FilterAttributeAuth(Permission.UpdateUser)]
        public Task<string> UpdateUser(int id, User user)
        {
            var res = _usersService.UpdateUser(id, user);
            return res;
        }
        [HttpDelete]
        [FilterAttributeAuth(Permission.DeleteUser)]
        public Task<string> DeleteUser(int id)
        {
            Task<string> res = _usersService.DeleteUser(id);
            return res;
        }
    }
}
