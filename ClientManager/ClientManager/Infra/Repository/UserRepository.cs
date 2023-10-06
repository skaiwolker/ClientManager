using Domain.Entities;
using Domain.Interfaces.Repository;
using Infra.Context;
using Infra.Repository.Base;

namespace Infra.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ClientManagerContext context) : base(context)
        {
        }
    }
}
