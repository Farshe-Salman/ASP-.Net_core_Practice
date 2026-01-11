using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIApp.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        AuthService service;

        public AuthController(AuthService service)
        {
            this.service = service;
        }

        [HttpPost("signup")]
        public IActionResult Signup(RegisterDTO dto)
        {
            var res = service.Register(dto);
            return res ? Ok("User Created") : BadRequest("User Not Created");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {
            var token = service.Login(dto);
            if (token == null) return Unauthorized();
            return Ok("Log in Successfully: Heres your login Token: "+token);
        }
    }
}

