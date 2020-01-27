using System;

namespace SN.Domain
{
    public class Movimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? ControleId { get; set; }
        public Controle Controle { get; set; }
    }
}