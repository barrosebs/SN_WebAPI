using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SN.Domain
{
    public class Controle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Informe o vencimento")]
        public DateTime Vencimento { get; set; }
        public string Descricao { get; set; }
        [Required]
        [Display(Name = "Informe o valor")]
        public decimal Valor { get; set; }
        [Required]
        [Display(Name = "Informe o status")]
        public int Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Movimento> Movimentos { get; set; }
        public List<Atleta> Atletas { get; set; }
    }
}