using AspNetCoreBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreBackend.Repositories
{
    public class ProvinciaRepository : BaseLinqToDBRepository<Provincia, long>
    {
        public override Provincia FindById(long id)
        {
            throw new NotImplementedException();
        }

        public override IList<Provincia> FindAll()
        {
            throw new NotImplementedException();
        }

        public IList<Provincia> FindByRegion(long idRegion)
        {
            return QueryForList(db =>
            {
                var query = from p in db.Provincias
                            where p.IdRegion == idRegion
                            select p;
                return query.ToList();
            });
        }
    }
}
