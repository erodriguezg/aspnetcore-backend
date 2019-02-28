using AspNetCoreBackend.Entities;
using LinqToDB;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreBackend.Repositories
{
    public class RegionRepository : BaseLinqToDBRepository<Region, long>
    {
        public override Region FindById(long id)
        {
            return QueryForObject(db =>
            {
                var query = from r in db.Regiones where r.IdRegion == id select r;
                return query.FirstOrDefault();
            });
        }

        public override IList<Region> FindAll()
        {
            return QueryForList(db =>
            {
                var query = from r in db.Regiones select r;
                return query.ToList();
            });
        }
    }
}
