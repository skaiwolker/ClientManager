using Domain.Interfaces.Repository;
using Domain.Interfaces.UnitOfWork;
using Infra.Context;
using Infra.Repository;

namespace Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IClienteRepository ClienteRepository { get; private set; }
        public ILogradouroRepository LogradouroRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }

        private readonly ClientManagerContext _context;

        public UnitOfWork(ClientManagerContext context)
        {
            _context ??= context;

            ClienteRepository ??= new ClienteRepository(context);
            LogradouroRepository ??= new LogradouroRepository(context);
            UserRepository ??= new UserRepository(context);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
