using LanchoneteDefinitivo.Data;
using LanchoneteDefinitivo.Data.Dtos;
using LanchoneteDefinitivo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanchoneteDefinitivo.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class AuthController : ControllerBase
    {
        private LanchoneteContext _context;

        public AuthController(LanchoneteContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Register(RegisterDto registerDto)
        {

            bool emailverifc = _context.Usuarios.Select(u => u.Email).Any(registerDto.Email);
            Usuario user = new Usuario();
            user.Email = registerDto.Email;
            user.Name = registerDto.Name;
            user.Password = registerDto.Password;
            user.Role = "cliente";

            if (user == null)
            {
                return BadRequest();
            }

            _context.Usuarios.Add(user);
            _context.SaveChanges();
            return Created();
        }
    }
}
