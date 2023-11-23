using Generico.Domain.Base;

namespace Generico.Domain.Cadastro.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Cliente> ObterClientePorCpf(string cpf);

        Task<List<Cliente>> ObterTodosClientesPorRegra(string produto);
    }
}
