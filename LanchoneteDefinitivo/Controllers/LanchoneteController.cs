using LanchoneteDefinitivo.Data;
using Microsoft.AspNetCore.Mvc;

namespace LanchoneteDefinitivo.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class LanchoneteController : ControllerBase
    {
        private LanchoneteContext _context;
        public LanchoneteController(LanchoneteContext context)
        {
            _context = context;
        }

        [HttpGet]
        public void GerarCardapio()
        {
             return 
        }
    }
}
