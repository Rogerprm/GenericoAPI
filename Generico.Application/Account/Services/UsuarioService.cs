using AutoMapper;
using Generico.Application.Account.Dtos;
using Generico.Domain.Account;
using Generico.Domain.Account.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Application.Account.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<UsuarioDto> CreateUsuarioAsync(UsuarioDto dto)
        {
            if (await _usuarioRepository.AnyAsync(x => x.Email.Valor == dto.Email) )
            {
                throw new Exception("Usuario ja cadastrado");
            }

            var usuario = _mapper.Map<Usuario>(dto);
            await _usuarioRepository.Save(usuario);
            return _mapper.Map<UsuarioDto>(usuario);
        }

        public async Task<List<UsuarioDto>> GetAllAsync()
        {
           var usuarios = await _usuarioRepository.GetAll();

           var result = _mapper.Map<List<UsuarioDto>>(usuarios);

           return result.ToList();    
        }

        public Task<UsuarioDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
