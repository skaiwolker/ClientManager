using Domain.Entities;
using Domain.Interfaces.Service;
using Domain.Interfaces.UnitOfWork;
using Domain.Services.Base;

namespace Domain.Services
{
    public class LogradouroService : Service<Logradouro>, ILogradouroService
    {
        public LogradouroService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.LogradouroRepository)
        {
        }
    }
}
