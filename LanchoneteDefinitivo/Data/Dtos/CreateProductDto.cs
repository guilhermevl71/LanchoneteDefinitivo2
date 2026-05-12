using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LanchoneteDefinitivo.Data.Dtos
{
    public class CreateProductDto
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
