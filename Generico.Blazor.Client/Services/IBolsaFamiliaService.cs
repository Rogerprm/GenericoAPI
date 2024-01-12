using Generico.Application.Registro.Dtos;

namespace Generico.Blazor.Client.Services
{
    public interface IBolsaFamiliaService
    {
        Task<IEnumerable<RegistroBolsaFamiliaDto>> GetAllAsync();
    }
}
