using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Models
{
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }

        // FK Pedido
        public int PedidoId {  get; set; }
        public Pedido? Pedido { get; set; }

        // FK Produto
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        //Dados
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

    }
}
