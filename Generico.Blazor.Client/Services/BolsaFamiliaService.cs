using Generico.Application.Registro.Dtos;
using System.Net.Http.Json;

namespace Generico.Blazor.Client.Services
{
    public class BolsaFamiliaService : IBolsaFamiliaService
    {
        public Task<IEnumerable<RegistroBolsaFamiliaDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
