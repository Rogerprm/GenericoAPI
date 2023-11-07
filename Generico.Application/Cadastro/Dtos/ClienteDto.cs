using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Application.Cadastro.Dtos
{
    public class ClienteDto
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Cpf { get; set; }
    }
}
