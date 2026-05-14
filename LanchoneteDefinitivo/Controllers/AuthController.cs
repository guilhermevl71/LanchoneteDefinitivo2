using LanchoneteDefinitivo.Data;
using LanchoneteDefinitivo.Data.Dtos;
using LanchoneteDefinitivo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

        [HttpPost("register")]
        public IActionResult Register(RegisterDto registerDto)
        {
            bool emailverifc = _context.Usuarios.Any(user => user.Email == registerDto.Email);

            if (emailverifc)
            {
                return BadRequest();
            }

            Usuario user = new Usuario();
            user.Email = registerDto.Email;
            user.Name = registerDto.Name;
            user.Password = registerDto.Password;
            user.Role = registerDto.Role;


            _context.Usuarios.Add(user);
            _context.SaveChanges();
            return Ok("Usuario criado.");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            // Procura um usuário com o email e senha informados
            var user = _context.Usuarios.FirstOrDefault(user =>user.Email == loginDto.Email && user.Password == loginDto.Password);

            // Se não encontrar usuário, retorna erro de autenticação
            if (user == null)
            {
                return Unauthorized("Email ou senha inválidos");
            }

            // Informações que irão dentro do token
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email!),
                new Claim(ClaimTypes.Role, user.Role!)
            };

            // Chave secreta usada para assinar o token
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("CHAVE_SECRETA_PARA_PROJETO_CIMATEC123")
            );

            // Algoritmo de criptografia do token
            var creds = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256
            );

            // Criação do token JWT
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            // Converte token para string
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            // Retorna token
            return Ok(new
            {
                token = tokenString
            });
        }
    }
}
