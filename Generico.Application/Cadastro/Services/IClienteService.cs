﻿

using Generico.Application.Cadastro.Dtos;
using System.Linq.Expressions;

namespace Generico.Application.Cadastro.Services
{
    public interface IClienteService
    {
        Task<ClienteDto> CreateClienteAsync(ClienteDto cliente);
        Task<IEnumerable<ClienteDto>> GetAllClientesAsync();
        Task<ClienteDto> GetClienteByIdAsync(Guid id);
        Task<ClienteDto> DeleteClienteAsync(Guid id);
        Task<ClienteDto> UpdateClienteAsync(ClienteDto cliente);

        

    }
}
