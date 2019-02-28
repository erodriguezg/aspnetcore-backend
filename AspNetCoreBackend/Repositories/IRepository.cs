using AspNetCoreBackend.Entities;
using System.Collections.Generic;

namespace AspNetCoreBackend.Repositories
{
    public interface IRepository<T, K> where T : IBaseEntity
    {
        T FindById(K id);
        IList<T> FindAll();
        K Insert(T entity);
        void Update(T entity);
        bool Delete(T entity);
    }
}
