using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SN.WebAPI.Model
{
    [Table("Atletas")]
    public class Atleta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Informe o nome completo do atleta")]
        public string Nome { get; set; }
        [Required]
        [Display(Name="Informe o apelido do atleta")]
        public string Apelido { get; set; }
        [Required]
        [Display(Name="Data de Nascimento do Atleta")]
        [DisplayFormat(DataFormatString="dd/MM/yyyy")]
        public DateTime? Nascimento { get; set; }
        [Required]
        [Display(Name = "Informe o Telefone do Atleta")]
        [DisplayFormat(DataFormatString="(99) 9 9999-9999")]
        public string Telefone { get; set; }
        [DisplayFormat(DataFormatString="dd/MM/yyyy")]
        public DateTime? DataInscricao { get; set; }
        public int FuncaoAtleta { get; set; }
        public bool Comissao { get; set; }
    }
}