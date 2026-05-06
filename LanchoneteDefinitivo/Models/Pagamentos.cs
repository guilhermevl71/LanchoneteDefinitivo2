using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Models
{
    public class Pagamentos
    {
        [Key]
        public int Id { get; set; }

        public bool Status { get; set; }
    }
}
