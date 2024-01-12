using Generico.Application.Registro;
using Generico.Application.Registro.Dtos;
using Generico.Application.Registro.Service;
using Microsoft.AspNetCore.Mvc;

namespace Generico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BolsaFamiliaController : ControllerBase
    {
        private readonly IRegistroBolsaFamiliaService _regitroBolsaFamiliaService;

        public BolsaFamiliaController(IRegistroBolsaFamiliaService regitroBolsaFamiliaService)
        {
            _regitroBolsaFamiliaService = regitroBolsaFamiliaService;
        }


        [HttpGet("Biblioteca")]
        public async Task<IActionResult> BuscarTodos([FromQuery] RegistroBolsaFamiliaFilter filter)
        {
            var result = _regitroBolsaFamiliaService.GetByQueryable(filter);
            return Ok(result);

        }

        [HttpGet("filtroManual")]
        public async Task<IActionResult> BuscaPorFiltro([FromQuery] RegistroBolsaFamiliaDto registroBolsaFamiliaDto)
        {
            var consulta = await _regitroBolsaFamiliaService.GetAllByFilter(registroBolsaFamiliaDto);
            return Ok(consulta);
        }
    } 
}
