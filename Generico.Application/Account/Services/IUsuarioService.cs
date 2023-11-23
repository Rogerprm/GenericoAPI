using Generico.Application.Account.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Application.Account.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> CreateUsuarioAsync(UsuarioDto dto);
        Task<List<UsuarioDto>> GetAllAsync();
        Task<UsuarioDto> GetById(Guid id);
        //Task<UsuarioDto> UpdateUsuarioAsync(Guid id, UsuarioDto dto);
       // Task<UsuarioDto> DeleteUsuarioAsync(Guid id);
    }
}
