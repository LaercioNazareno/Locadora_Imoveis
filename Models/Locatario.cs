using System.ComponentModel.DataAnnotations;
using locadora.Models;

namespace locadora.Models
{
    public class Locatario: Cliente
    {
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
    }
}