using Domain.Entities;
using Domain.Interfaces.Repository;
using Infra.Context;
using Infra.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly ClientManagerContext _context;
        public ClienteRepository(ClientManagerContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> EmailExists(string email)
        {
            return await _context.Clientes.FirstOrDefaultAsync(x => x.Email == email) != null;
        }
    }
    }
}
