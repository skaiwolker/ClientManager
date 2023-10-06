using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Interfaces.UnitOfWork;
using Domain.Services.Base;

namespace Domain.Services
{
    public class ClienteService : Service<Cliente>, IClienteService
    {
        private readonly IClienteRepository _repository;
        public ClienteService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ClienteRepository)
        {
            _repository = unitOfWork.ClienteRepository;
        }

        public override async Task Add(Cliente obj)
        {
            if (await _repository.EmailExists(obj.Email))
                throw new ArgumentException(nameof(obj.Email));  

            await base.Add(obj);
        }

        public override async Task Update(Cliente obj)
        {
            if (await _repository.EmailExists(obj.Email))
                throw new ArgumentException(nameof(obj.Email));

            await base.Update(obj);
        }
    }
}
