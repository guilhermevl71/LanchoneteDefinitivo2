using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Endereco { get; set; }

        public int Telefone { get; set; }
    }
}
