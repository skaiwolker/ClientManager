using Domain.Entities;
using Domain.Interfaces.Repository;
using Infra.Context;
using Infra.Repository.Base;

namespace Infra.Repository
{
    public class LogradouroRepository : Repository<Logradouro>, ILogradouroRepository
    {
        public LogradouroRepository(ClientManagerContext context) : base(context)
        {
        }
    }
}
