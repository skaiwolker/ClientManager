using Domain.Entities.Base;
using Domain.Interfaces.Repository.Base;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ClientManagerContext _context;

        public Repository(ClientManagerContext context)
        {
            _context = context;
        }

        public async Task Add(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public async Task Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }
            
        public async Task Update(T obj)
        {
            _context.Update(obj);
        }
    }
}
