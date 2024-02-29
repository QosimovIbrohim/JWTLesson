using JWT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTLesson.Application.Services.AuthService
{
    public interface IAuthservice
    {
        public Task<string> GenerateToken(User user);
    }
}
