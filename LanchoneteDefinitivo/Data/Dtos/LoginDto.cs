using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LanchoneteDefinitivo.Data.Dtos
{
    public class LoginDto
    {
        [Required]
        [StringLength(100)]
        public string? Email { get; set; }

        [Required]
        [StringLength(20)]
        public string? Password { get; set; }
    }
}
