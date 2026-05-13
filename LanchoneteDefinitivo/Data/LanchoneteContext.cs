using LanchoneteDefinitivo.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchoneteDefinitivo.Data
{
    public class LanchoneteContext : DbContext
    {
        public LanchoneteContext(DbContextOptions<LanchoneteContext> opts) : base(opts) { }

        //public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<Pagamentos> Pagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
