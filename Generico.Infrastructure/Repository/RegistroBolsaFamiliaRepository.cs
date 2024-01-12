using Generico.Domain.Registro;
using Generico.Infrastructure.Context;
using Generico.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace Generico.Infrastructure.Repository
{
    public class RegistroBolsaFamiliaRepository : Repository<RegistroBolsaFamilia>, IRegistroBolsaFamiliaRepository
    {
        public RegistroBolsaFamiliaRepository(GenericoContext context) : base(context)
        {
        }
        public async Task<IQueryable<RegistroBolsaFamilia>> GetByFilter(RegistroBolsaFamilia filter)
        {
            var query = this.Query.AsQueryable();

            if (filter.NomeFavorecido != null)
            {
                query = this.Query.AsNoTracking()
                   .Where(x => x.NomeFavorecido.Contains(filter.NomeFavorecido));
            }

            if (filter.ValorParcela != null)
            {
                query = this.Query.AsNoTracking()
                    .Where(x => x.ValorParcela.Contains(filter.ValorParcela));
            }

            if (!string.IsNullOrEmpty(filter.UF))
            {
                query = this.Query.AsNoTracking()
                    .Where(x => x.UF.Equals(filter.UF));
            }

            //Operações de Leitura, utilizar o AsNoTracking para garantir performance
            //AsNoTracking armazena na memoria os registros para alteração posterior
          

         

            var result = query.ToList();

            return result.AsQueryable();
        }
    }
}

