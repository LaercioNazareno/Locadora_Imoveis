using locadora.Models;
using System;
using System.Linq;

namespace locadora.Data
{
    public class DbInitializer
    {
        public static void Initialize(LocadoraContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Locador.Any())
            {
                return;   // DB has been seeded
            }

            var v_listaClientes = new Locador[]
            {
                new Locador{Nome="Laura",Cpf="12345678901",Cep=33115260,Estado="MG",Cidade="Belo Horizonte",Bairro="Lurdes",Rua="Alameda",ValorRecebimentoMensal=100.0}
            };
            foreach (Locador s in v_listaClientes)
            {
                context.Locador.Add(s);
            }
            context.SaveChanges();
        }
    }
}