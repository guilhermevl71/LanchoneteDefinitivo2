using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Tipo { get; set; }

        [Required]
        [Range(0, 1000)]
        public decimal Preco { get; set; }
    }
}
