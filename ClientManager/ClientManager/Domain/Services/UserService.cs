using Domain.Entities;
using Domain.Interfaces.Service;
using Domain.Interfaces.UnitOfWork;
using Domain.Services.Base;

namespace Domain.Services
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.UserRepository)
        {            
        }
    }
}
