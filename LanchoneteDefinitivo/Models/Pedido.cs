using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Valortotal { get; set; }

        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
