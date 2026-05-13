using System.ComponentModel.DataAnnotations;

namespace LanchoneteDefinitivo.Data.Dtos
{
    public class RegisterDto
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(100)]
        public string? Email { get; set; }

        [Required]
        [StringLength(20)]
        public string? Password { get; set; }
    }
}
