using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Data.Dtos
{
    public class AddCartDto
    {
        [Required]
        [Range(1, 100)]
        public int Quantidade { get; set; }

        [Required]
        public int ProdutoId { get; set; }

        [Required]
        public int PedidoId { get; set; }
    }
}
