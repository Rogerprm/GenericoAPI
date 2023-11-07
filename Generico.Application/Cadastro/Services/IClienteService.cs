

using Generico.Application.Cadastro.Dtos;
using System.Linq.Expressions;

namespace Generico.Application.Cadastro.Services
{
    public interface IClienteService
    {
        Task<ClienteDto> CreateClienteAsync(ClienteDto cliente);
        Task<List<ClienteDto>> GetAllClientesAsync();

    }
}
