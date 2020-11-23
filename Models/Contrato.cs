using System;
using locadora.Models;

namespace locadora.Models
{
    public class Contrato: EntidadeBase
    {
        public long LocatarioId { get; set; } 
        public Locatario Locatario { get; set; }  
        public long ImovelId { get; set; }
        public Imovel Imovel { get; set; }
        public DateTime DataEncerramento { get; set; } 
        public DateTime DataContratacao { get; set; } 
    }
}