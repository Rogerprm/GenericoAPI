using Generico.Domain.Cadastro;
using Generico.Domain.Cadastro.Repository;
using Generico.Infrastructure.Context;
using Generico.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Generico.Infrastructure.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(GenericoContext context) : base(context)
        {
        }

        public async Task<Cliente> ObterClientePorCpf(string cpf)
        {

           var cliente = await Query.Where(x => x.Cpf == cpf).FirstOrDefaultAsync();
           
           return cliente;
        }

        public async Task<List<Cliente>> ObterTodosClientesPorRegra(string produto)
        {
            //var clientes = await Query
            //    .Where(c=>c.Produtos.Any(p=>p.Nome == produto))
            //    .ToListAsync();

            var sql = $"SELECT * FROM Cliente c WHERE EXISTS (SELECT 1 FROM Produto p WHERE p.ClientId = c.Id AND p.Nome = '{produto}')";

            var clientes = await Query.FromSqlRaw(sql).ToListAsync();

            return clientes;
        }
    }
}
