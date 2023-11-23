using Generico.Application.Cadastro.Dtos;
using Generico.Application.Cadastro.Services;
using Microsoft.AspNetCore.Mvc;

namespace Generico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost()]
        public async Task<IActionResult> Criar([FromQuery]ClienteDto clienteDto)
        {
           var result = await _clienteService.CreateClienteAsync(clienteDto);
           return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            //List<ClienteDto> clienteDto = new List<ClienteDto>();
            //clienteDto = await _clienteService.GetAllClientesAsync();
            //return Ok(clienteDto);
           
            var result = await _clienteService.GetAllClientesAsync();
            return Ok(result);

            //return Ok(await _clienteService.GetAllClientesAsync());
      
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var clinte = await _clienteService.GetClienteByIdAsync(id);
            return Ok(clinte);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateById ([FromQuery] ClienteDto clienteDto)
        {

            var cliente = await _clienteService.UpdateClienteAsync(clienteDto);
            
            
            return Ok(cliente);
        }

    }
}
