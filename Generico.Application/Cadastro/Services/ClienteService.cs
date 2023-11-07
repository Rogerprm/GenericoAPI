using AutoMapper;
using Generico.Application.Cadastro.Dtos;
using Generico.Domain.Cadastro.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Application.Cadastro.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public Task<ClienteDto> CreateClienteAsync(ClienteDto cliente)
        {
            throw new NotImplementedException();
        }

        //public async Task<List<ClienteDto>> GetAllClientesAsync()
        //{
        //    var listaClientes = await _clienteRepository.GetAll();
            
        //    var clientesDtos = new List<ClienteDto>();

        //    foreach(var cliente in listaClientes) 
        //    {
        //        var clienteDto = new ClienteDto
        //        {
        //            Cpf= cliente.Cpf,
        //            DataNascimento= cliente.DataNascimento,
        //            Email= cliente.Email,
        //            Idade= cliente.Idade,
        //            Nome = cliente.Nome 
        //        };

        //        clientesDtos.Add(clienteDto);
        //    }

        //    return clientesDtos;
        //}

        public async Task<List<ClienteDto>> GetAllClientesAsync()
        {
            var clientes = await _clienteRepository.GetAll();
            
            var retorno = _mapper.Map<List<ClienteDto>>(clientes);
            
            return retorno.ToList();
        }
    }
}
