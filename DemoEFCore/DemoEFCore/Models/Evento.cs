using System;
using System.ComponentModel.DataAnnotations;

namespace DemoEFCore.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatorio")]
        [Display(Name = "Nome Completo")]
        [MaxLength(100, ErrorMessage = "O valor máximo é 100")]
        [MinLength(2, ErrorMessage = "O valor mínimo é 2")]
        public string Nome { get; set; }


        [Range(10, 1000)]
        [Required(ErrorMessage = "Preencha o Valor")]
        public decimal Valor { get; set; }

        public bool Gratuito { get; set; }
        [Required(ErrorMessage = "A descricao é obrigatoria")]
        [MaxLength(100, ErrorMessage = "O valor maximo é 100")]
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}
