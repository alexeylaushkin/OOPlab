using KLADobj.ApplicationServices.Ports.Cache;
using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using KLADobj.DomainObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KLADobj.ApplicationServices.Repositories
{
    public class CachedReadOnlyKLADobjRepository : ReadOnlyKLADobjRepositoryDecorator
    {
        private readonly IDomainObjectsCache<kladobj> _kladobjsCache;

        public CachedReadOnlyKLADobjRepository(IReadOnlyKLADobjRepository kladobjRepository, 
                                             IDomainObjectsCache<kladobj> kladobjsCache)
            : base(kladobjRepository)
            => _kladobjsCache = kladobjsCache;

        public async override Task<kladobj> GetKLADobj(long id)
            => _kladobjsCache.GetObject(id) ?? await base.GetKLADobj(id);

        public async override Task<IEnumerable<kladobj>> GetAllKLADobjs()
            => _kladobjsCache.GetObjects() ?? await base.GetAllKLADobjs();

        public async override Task<IEnumerable<kladobj>> QueryKLADobjs(ICriteria<kladobj> criteria)
            => _kladobjsCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryKLADobjs(criteria);

    }
}
