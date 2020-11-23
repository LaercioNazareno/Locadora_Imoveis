using System;
using locadora.Models;

namespace locadora.Models
{
    public class Cobranca: EntidadeBase
    {
        public DateTime DataEmissao { get; set; }
        public long LocatarioId { get; set; }
        public Locatario Cliente { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorJuros { get; set; }
        public double ValorCobranca { get; set; }
    }
}