using Microsoft.AspNetCore.Mvc;
using Generico.Application.Cadastro.Services;
using Generico.Application.Cadastro.Dtos;

namespace Generico.Front.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        public async Task<IActionResult> Index()
        {

            var clientesDto = await _clienteService.GetAllClientesAsync();
            //var clientes = clientesDto.Select(dto => dto.ToCliente()).ToList();            

            return View(clientesDto);
        }

        // Método para exibir o formulário de criação de cliente
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Details(Guid id)
        {
           var clienteDto = await _clienteService.GetClienteByIdAsync(id);
            if (clienteDto == null)
            {
                return NotFound();
            }

            return View(clienteDto);
        }

        // Método para processar a criação de um cliente
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClienteDto clienteDto)
        {
            if (ModelState.IsValid)
            {
                await _clienteService.CreateClienteAsync(clienteDto);
                return RedirectToAction(nameof(Index));
            }

            return View(clienteDto);
        }

        // Método para exibir o formulário de edição de cliente
        public async Task<IActionResult> Edit(Guid id)
        {
            var clienteDto = await _clienteService.GetClienteByIdAsync(id);
            if (clienteDto == null)
            {
                return NotFound();
            }

            return View(clienteDto);
        }

        // Método para processar a edição de um cliente
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ClienteDto clienteDto)
        {
            if (id != clienteDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _clienteService.UpdateClienteAsync(clienteDto);
                return RedirectToAction(nameof(Index));
            }

            return View(clienteDto);
        }

        // Método para exibir a confirmação de exclusão de cliente
        public async Task<IActionResult> Delete(Guid id)
        {
            var clienteDto = await _clienteService.GetClienteByIdAsync(id);
            if (clienteDto == null)
            {
                return NotFound();
            }

            return View(clienteDto);
        }

        // Método para processar a exclusão de um cliente
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _clienteService.DeleteClienteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
