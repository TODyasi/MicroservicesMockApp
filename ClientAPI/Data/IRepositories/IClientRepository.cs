using ClientAPI.Data.DTO_s;
using ClientAPI.Models;

namespace ClientAPI.Data.IRepositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<ClientDto>> GetAllAsync();
        Task AddClientAsync(ClientDto client);
        Task UpdateClientAsync(ClientDto client);
        Task DeleteClientAsync(Guid clientId);
        Task<ClientDto> GetClientByIdAsync(Guid clientId);
    }
}
