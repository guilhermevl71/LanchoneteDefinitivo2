using LanchoneteDefinitivo.Data;
using LanchoneteDefinitivo.Data.Dtos;
using LanchoneteDefinitivo.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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

        [HttpPost("produto")]
        public IActionResult AdicionarProduto(CreateProductDto prodructcreated)
        {
            if (prodructcreated == null)
            {
                return BadRequest();
            }

            Produto p = new Produto
            {
                Nome = prodructcreated.Nome,
                Tipo = prodructcreated.Tipo,
                Preco = prodructcreated.Preco,
            };
            _context.Produtos.Add(p);
            _context.SaveChanges();
            return Created();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarProduto(int id)
        {
            Produto? p = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (p == null)
            {
                return BadRequest("Produto não encontrado.");
            }
            _context.Produtos.Remove(p);
            _context.SaveChanges();
            return Ok("Produto Removido!");
        }

        [HttpGet]
        public IActionResult GerarCardapio()
        {
            var cardapio = _context.Produtos.GroupBy(p => p.Tipo!).ToDictionary(grupo => grupo.Key, grupo => grupo.ToList());

            return Ok(cardapio);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, UpdateProductDto produtodto)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null) {
                return NotFound("Produto não encontrado");
            }

            produto.Nome = produtodto.Nome;
            produto.Tipo = produtodto.Tipo;
            produto.Preco = produtodto.Preco;
            _context.SaveChanges();
            return Ok(produto);
        }

        [HttpPost("carrinho")]
        public IActionResult AdicionarAoCarrinho(AddCartDto cartdto)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == cartdto.ProdutoId);

            if (produto == null)
            {
                return NotFound("Produto não encontrado");
            }

            var itemPedido = new ItemPedido
            {
                ProdutoId = cartdto.ProdutoId, // tem que tirar
                PedidoId = cartdto.PedidoId,
                Quantidade = cartdto.Quantidade,
                PrecoUnitario = produto.Preco
            };

            _context.ItemPedidos.Add(itemPedido);
            _context.SaveChanges();
            return Ok(itemPedido);

        }
    }

}
