using JWTLesson.Application.Services.AuthService;
using Microsoft.AspNetCore.Mvc;

namespace JWTLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IAuthservice _authService;

        public IdentityController(IAuthservice authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            var result = _authService.GenerateToken(login, password);
            return Ok(result.Result);
        }
    }
}
