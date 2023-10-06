using Domain.Entities.Base;
using Domain.Interfaces.Repository.Base;
using Domain.Interfaces.Service.Base;
using Domain.Interfaces.UnitOfWork;

namespace Domain.Services.Base
{
    public class Service<T> : IService<T> where T : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repository;

        public Service(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual async Task Add(T obj)
        {
            var entityObj = await _repository.GetById(obj.Id);

            if (entityObj != null)
                throw new ArgumentNullException(nameof(obj));

            await _repository.Add(obj);
            await _unitOfWork.Save();
        }

        public async Task Delete(Guid id)
        {
            var entityObj = await _repository.GetById(id);

            if (entityObj == null)
                throw new ArgumentNullException(nameof(entityObj));

            await _repository.Delete(entityObj);
            await _unitOfWork.Save();
        }

        public async Task<List<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public virtual async Task Update(T obj)
        {
            var entityObj = await _repository.GetById(obj.Id);

            if (entityObj == null)
                throw new ArgumentNullException(nameof(obj));

            await _repository.Update(entityObj);
            await _unitOfWork.Save();
        }
    }
}
