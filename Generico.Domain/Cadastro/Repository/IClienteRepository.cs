using Generico.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Cadastro.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<List<Cliente>> ObterTodosClientesPorCpf(int cpf);
    }
}
