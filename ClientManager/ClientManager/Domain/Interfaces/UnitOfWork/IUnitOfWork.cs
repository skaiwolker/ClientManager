using Domain.Interfaces.Repository;

namespace Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClienteRepository ClienteRepository { get; }
        ILogradouroRepository LogradouroRepository { get; }
        IUserRepository UserRepository { get; }
        Task Save();
    }
}
