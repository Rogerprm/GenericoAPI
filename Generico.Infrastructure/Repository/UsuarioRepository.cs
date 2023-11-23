using Generico.Domain.Account;
using Generico.Domain.Account.Repository;
using Generico.Infrastructure.Context;
using Generico.Infrastructure.Database;

namespace Generico.Infrastructure.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(GenericoContext context) : base(context)
        {
        }
    }
}
