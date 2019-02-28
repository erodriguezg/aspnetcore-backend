using AspNetCoreBackend.Entities;
using LinqToDB;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreBackend.Repositories
{
    public class RegionRepository : BaseLinqToDBRepository<Region, long>
    {
        public override Region Read(long id)
        {
            return QueryForObject(db =>
            {
                var query = from r in db.Regiones where r.IdRegion == id select r;
                return query.FirstOrDefault();
            });
        }

        public IEnumerable<Region> FindAll()
        {
            return QueryForEnumerable(db => {
                var query = from r in db.Regiones select r;
                return query.ToList();
            });
        }

    }
}
