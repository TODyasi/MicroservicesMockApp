using ClientAPI.Data.DTO_s;
using ClientAPI.Data.IRepositories;
using ClientAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientAPI.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ClientDbContext _context;

        public ClientRepository(ClientDbContext context)
        {
            _context = context;
        }

        public async Task AddClientAsync(ClientDto client)
        {
            // Adds the client entity to the database context
            //wait _context.Clients.AddAsync(client);

            // Saves the changes to the database asynchronously
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Guid clientId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClientAsync(Guid clientId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ClientDto> GetClientByIdAsync(Guid clientId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClientAsync(ClientDto client)
        {
            throw new NotImplementedException();
        }
    }
}
