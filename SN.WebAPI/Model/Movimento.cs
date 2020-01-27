using System;

namespace SN.WebAPI.Model
{
    public class Movimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? IdControle { get; set; }
        public Controle Controle { get; set; }
    }
}