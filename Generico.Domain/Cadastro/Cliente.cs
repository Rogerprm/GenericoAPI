using Generico.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Cadastro
{
    public class Cliente : Entity<Guid>
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();

    }
}
