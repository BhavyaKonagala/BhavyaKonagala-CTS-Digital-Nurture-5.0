using JwtMicroservice.Models;
using JwtMicroservice.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtMicroservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "admin123")
            {
                var token = _jwtService.GenerateToken(model.Username);

                return Ok(new
                {
                    Message = "Login Successful",
                    Token = token
                });
            }

            return Unauthorized("Invalid Username or Password");
        }

        [Authorize]
        [HttpGet("secure")]
        public IActionResult SecureEndpoint()
        {
            return Ok(new
            {
                Message = "Welcome! This is a protected endpoint.",
                User = User.Identity?.Name
            });
        }
    }
}