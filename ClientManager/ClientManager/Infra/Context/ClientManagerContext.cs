using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class ClientManagerContext : DbContext
    {
        public ClientManagerContext(DbContextOptions options) : base()
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Logradouro> Logradouros { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
