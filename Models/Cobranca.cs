using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using locadora.Models;

namespace locadora.Models
{
    public class Cobranca: EntidadeBase
    {
        [Display(Name = "Data de Emissão")]
        public DateTime DataEmissao { get; set; }
        [Display(Name = "CPF Locatario")]
        public long LocatarioId { get; set; }
        public Locatario Cliente { get; set; }
        [Display(Name = "Data de Vencimento")]
        public DateTime DataVencimento { get; set; }
        [Display(Name = "Área")]
        public double ValorJuros { get; set; }
        [Display(Name = "Valor da Cobrança")]
        public double ValorCobranca { get; set; }
    }
}