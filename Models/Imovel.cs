using System.ComponentModel.DataAnnotations;
using locadora.Models;

namespace locadora.Models
{
    public class Imovel: EntidadeBase
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "CPF do Locatário")]
        public long LocatarioId { get; set; }
        public Locador Locador { get; set; }
        [Display(Name = "Área")]
        public long Area { get; set; }
        [Display(Name = "Quantidade de Comodos")]
        public int QuantidadeComodos { get; set; }
        [Display(Name = "Valor do Aluguel")]
        public double ValorAluguel { get; set; }
        public long Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
    }
}