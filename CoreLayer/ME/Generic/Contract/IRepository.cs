using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Generic.Contract
{
    public interface IRepository<TKey , T> where T : class
    {
        List<T> GetAll();
        T Get(TKey key);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();

    }
}
