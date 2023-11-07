using Generico.Application.Cadastro.Dtos;
using Generico.Domain.Cadastro;

namespace Generico.Application.Profile
{
    public class GenericoProfile : AutoMapper.Profile
    {
        public GenericoProfile() 
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();
        }
    }
}
