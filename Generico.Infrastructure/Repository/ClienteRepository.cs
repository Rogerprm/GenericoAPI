using Generico.Domain.Cadastro;
using Generico.Domain.Cadastro.Repository;
using Generico.Infrastructure.Context;
using Generico.Infrastructure.Database;

namespace Generico.Infrastructure.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(GenericoContext context) : base(context)
        {
        }

        public Task<List<Cliente>> ObterTodosClientesPorCpf(int cpf)
        {
            throw new NotImplementedException();
        }
    }
}
