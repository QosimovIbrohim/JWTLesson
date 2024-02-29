using JWT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTLesson.Application.Services.UserServices
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<string> DeleteUser(int id);
        Task<string> UpdateUser(int id, User user);
        Task<string> Create(User user);
    }
}
