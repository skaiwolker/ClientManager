using Domain.Entities.Base;

namespace Domain.Interfaces.Repository.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Add(T obj);
        Task Update(T obj);
        Task Delete(T obj);
    }
}
