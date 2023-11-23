using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Generico.Application.Cadastro.Dtos;
using Generico.Domain.Cadastro;
using Generico.Domain.Cadastro.Repository;
using System;
using System.Collections.Generic;
using System.Dynamic;
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

        public async Task<ClienteDto> CreateClienteAsync(ClienteDto clienteDto)
        {
            if (await _clienteRepository.AnyAsync(x => x.Cpf == clienteDto.Cpf))
                throw new Exception("Já existe este cliente cadastrado");
           
            var cliente = _mapper.Map<Cliente>(clienteDto);

            await _clienteRepository.Save(cliente);

            return _mapper.Map<ClienteDto>(cliente);   

        }

        public Task<ClienteDto> DeleteClienteAsync(Guid id)
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

        public async Task<ClienteDto> GetClienteByIdAsync(Guid id)
        {
            var cliente = await _clienteRepository.GetById(id);
            var retorno = _mapper.Map<ClienteDto>(cliente);

            return retorno;
        }
         
        public async Task<ClienteDto> UpdateClienteAsync(ClienteDto dto)
        {
            if (await _clienteRepository.AnyAsync(x=>x.Id == dto.Id))
            {
                var cliente = _mapper.Map<Cliente>(dto);
                await _clienteRepository.Update(cliente);
                return _mapper.Map<ClienteDto>(cliente);
            }
            else
            {
                throw new NotImplementedException("Cliente não encontrado");
            }
            //cliente.Atualiza(dto.Idade, dto.Cpf, dto.Email, dto.DataNascimento, dto.Nome);
            

           

           
           
            
          
        }
    }
}
