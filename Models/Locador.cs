using System.ComponentModel.DataAnnotations;
using locadora.Models;

namespace locadora.Models
{
    public class Locador: Cliente
    {
        [Display(Name = "Valor do Recebimento Mensal")]
        public double ValorRecebimentoMensal { get; set; }
        
    }
}