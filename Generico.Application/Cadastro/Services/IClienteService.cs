

using Generico.Application.Cadastro.Dtos;
using System.Linq.Expressions;

namespace Generico.Application.Cadastro.Services
{
    public interface IClienteService
    {
        Task<ClienteDto> CreateClienteAsync(ClienteDto cliente);
        Task<List<ClienteDto>> GetAllClientesAsync();
        Task<ClienteDto> GetClienteByIdAsync(Guid id);
        Task<ClienteDto> DeleteClienteAsync(Guid id);
        Task<ClienteDto> UpdateClienteAsync(Guid id, ClienteDto cliente);

    }
}
