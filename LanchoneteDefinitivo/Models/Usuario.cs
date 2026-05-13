using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Models
{
    public class Usuario
    {
        [Key]
        public int Id  { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(6)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Role { get; set; }
    }
}
