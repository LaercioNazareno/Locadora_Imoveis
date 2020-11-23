using System.ComponentModel.DataAnnotations;
using System;
using locadora.Models;

namespace locadora.Models
{
    public class Contrato: EntidadeBase
    {
        public long LocatarioId { get; set; } 
        public Locatario Locatario { get; set; }
        [Display(Name = "Imóvel")]
        public long ImovelId { get; set; }
        public Imovel Imovel { get; set; }
        [Display(Name = "Data de Encerramento")]
        public DateTime DataEncerramento { get; set; }
        [Display(Name = "Data de Contratação")]
        public DateTime DataContratacao { get; set; } 
    }
}