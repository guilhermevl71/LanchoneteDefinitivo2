using LanchoneteDefinitivo.Data;
using LanchoneteDefinitivo.Models;
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

        [HttpPost]
        public void AdicionarProduto(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Produto> GerarCardapio()
        {
            return _context.Produtos.ToList();
        }
    }
}
