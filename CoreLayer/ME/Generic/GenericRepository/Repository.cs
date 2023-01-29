using CoreLayer.Generic.Contract;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace CoreLayer.Generic.GenericRepository
{
    public class Repository<TKey, T> : IRepository<TKey, T> where T : class
    {
        private readonly ChatRoomDbContext _context;

        public Repository(ChatRoomDbContext context)
        {
            _context = context;
        }

        public void Create(T entity) => _context.Add(entity);

        public void Delete(T entity) => _context.Remove(entity);

        public T Get(TKey key) => _context.Set<T>().Find(key);

        public List<T> GetAll() => _context.Set<T>().ToList();

        public void SaveChanges() => _context.SaveChanges();

        public void Update(T entity)
        {
            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                return;
            }
        }
    }
}
