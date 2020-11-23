namespace locadora.Models
{
    public class Cliente: EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public long Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
    }
}