using AutoMapper;
using ClientAPI.Data.DTO_s;
using ClientAPI.Data.Repositories;
using ClientAPI.Models;

namespace ClientAPI.services
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository;
        private readonly IMapper _mapper;
        public ClientService(ClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }
        public async Task<ClientDto> GetClientDetails(Guid clientId)
        {
            var client = await _clientRepository.GetClientDetailsAsync(clientId);
            return _mapper.Map<ClientDto>(client);
        }

        public async Task<ClientDto> GetClientByIdAsync(Guid clientId)
        {
            var clientModel = await _clientRepository.GetClientByIdAsync(clientId);

            if (clientModel == null) return null;

            return _mapper.Map<ClientDto>(clientModel);
        }

    }
}
