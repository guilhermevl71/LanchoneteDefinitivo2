using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Data.Dtos
{
    public class UpdateProductDto
    {
        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string? Tipo { get; set; }

        [Required]
        [Range(0, 1000)]
        public decimal Preco { get; set; }
    }
}
