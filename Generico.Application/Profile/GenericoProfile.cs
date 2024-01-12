using Generico.Application.Cadastro.Dtos;
using Generico.Application.Registro.Dtos;
using Generico.Domain.Cadastro;
using Generico.Domain.Registro;

namespace Generico.Application.Profile
{
    public class GenericoProfile : AutoMapper.Profile
    {
        public GenericoProfile() 
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();

            CreateMap<RegistroBolsaFamilia , RegistroBolsaFamiliaDto>().ReverseMap();
        }
    }
}
