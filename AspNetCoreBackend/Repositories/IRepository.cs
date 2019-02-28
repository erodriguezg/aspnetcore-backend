using AspNetCoreBackend.Entities;

namespace AspNetCoreBackend.Repositories
{
    public interface IRepository<T, K> where T : IBaseEntity 
    {
        K Create(T entity);
        T Read(K id);
        void Update(T entity);
        bool Delete(T entity);
    }
}
