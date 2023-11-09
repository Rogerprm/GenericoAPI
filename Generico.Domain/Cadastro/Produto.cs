using Generico.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Cadastro
{
    public class Produto : Entity<Guid>
    {        
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }

        public Guid ClientId { get; set; }
        public Cliente Cliente { get; set; }

        //EF
        protected Produto()
        {

        }

        // Método para exibir informações do produto
        public void ExibirInformacoes()
        {
           
        }
    }
}
