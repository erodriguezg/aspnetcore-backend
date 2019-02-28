using AspNetCoreBackend.Configs;
using AspNetCoreBackend.Entities;
using LinqToDB;
using System;
using System.Collections.Generic;

namespace AspNetCoreBackend.Repositories
{
    public abstract class BaseLinqToDBRepository<T, K> : IRepository<T, K> where T : IBaseEntity
    {
        private const string CONFIG_NAME = AppLinq2DBSettings.DEFAULT_CONFIGURATION;

        public abstract T Read(K id);

        protected T QueryForObject(Func<LinqToDbDataContext, T> function)
        {
            using (var db = new LinqToDbDataContext(CONFIG_NAME))
            {
                return function.Invoke(db);
            }
        }

        protected IEnumerable<T> QueryForEnumerable(Func<LinqToDbDataContext, IEnumerable<T>> function)
        {
            using (var db = new LinqToDbDataContext(CONFIG_NAME))
            {
                return function.Invoke(db);
            }
        }

        public K Create(T entity)
        {
            using (var db = new LinqToDbDataContext(CONFIG_NAME))
            {

                return (K)db.InsertWithIdentity<T>(entity);
            }
        }

        public bool Delete(T entity)
        {
            using (var db = new LinqToDbDataContext(CONFIG_NAME))
            {
                return db.Delete<T>(entity) > 0;
            }
        }

        public void Update(T entity)
        {
            using (var db = new LinqToDbDataContext(CONFIG_NAME))
            {
                db.Update<T>(entity);
            }
        }
    }
}
