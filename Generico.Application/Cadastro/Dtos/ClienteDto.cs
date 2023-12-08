using Generico.Domain.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Application.Cadastro.Dtos
{
    public class ClienteDto
    {
        public Guid Id{ get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public virtual IEnumerable<Produto>? Produtos { get; set; }

    }
}
