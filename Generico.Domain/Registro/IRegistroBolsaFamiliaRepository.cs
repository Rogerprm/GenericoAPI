using Generico.Domain.Base;


namespace Generico.Domain.Registro
{
    public interface IRegistroBolsaFamiliaRepository : IRepository<RegistroBolsaFamilia>
    {
        Task<IQueryable<RegistroBolsaFamilia>> GetByFilter(RegistroBolsaFamilia filter);
    }
}
