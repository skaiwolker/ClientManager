using Domain.Entities.Base;

namespace Domain.Interfaces.Service.Base
{
    public interface IService<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Add(T obj);
        Task Update(T obj);
        Task Delete(Guid id);
    }
}
