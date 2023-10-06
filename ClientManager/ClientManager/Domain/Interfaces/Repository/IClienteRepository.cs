using Domain.Entities;
using Domain.Interfaces.Repository.Base;

namespace Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<bool> EmailExists(string email);
    }
}
