using locadora.Models;

namespace locadora.Models
{
    public class Imovel: EntidadeBase
    {
        public string Descricao { get; set; }
        public long LocatarioId { get; set; }
        public Locador Locador { get; set; }
        public long Area { get; set; }
        public int QuantidadeComodos { get; set; }
        public double ValorAluguel { get; set; }
        public long Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
    }
}