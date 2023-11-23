using Generico.Application.Account.Dtos;
using Generico.Application.Account.Services;
using Microsoft.AspNetCore.Mvc;

namespace Generico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost()]
        public async Task<IActionResult> Criar([FromQuery]UsuarioDto usuarioDto)
        {
            var result = await _usuarioService.CreateUsuarioAsync(usuarioDto);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> BuscarTodosUsuarios()
        {
            var result = await _usuarioService.GetAllAsync();
            return Ok(result);
        }

    }
}
