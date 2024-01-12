using Generico.Application.Registro;
using Generico.Application.Registro.Dtos;

namespace Generico.Application.Registro.Service
{
    public interface IRegistroBolsaFamiliaService
    {
        Task<IEnumerable<RegistroBolsaFamiliaDto>> GetAllAsync();

        ICollection<RegistroBolsaFamiliaDto> GetByQueryable(RegistroBolsaFamiliaFilter filter);

        Task<IEnumerable<RegistroBolsaFamiliaDto>> GetAllByFilter(RegistroBolsaFamiliaDto filter);


    }
}
