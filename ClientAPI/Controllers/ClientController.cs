using ClientAPI.Models;
using ClientAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace ClientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly ClientService _clientService;

        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientModel>> GetClient(Guid id)
        {
            var client = await _clientService.GetClientDetails(id);
            if (client == null)
                return NotFound();

            return Ok(client);
        }
    }
}
