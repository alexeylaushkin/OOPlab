using KLADobj.ApplicationServices.Ports.Cache;
using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KLADobj.InfrastructureServices.Repositories
{
    public class NetworkKLADobjRepository : NetworkRepositoryBase, IReadOnlyKLADobjRepository
    {
        private readonly IDomainObjectsCache<kladobj> _kladobjCache;

        public NetworkKLADobjRepository(string host, ushort port, bool useTls, IDomainObjectsCache<kladobj> kladobjCache)
            : base(host, port, useTls)
            => _kladobjCache = kladobjCache;

        public async Task<kladobj> GetKLADobj(long id)
            => CacheAndReturn(await ExecuteHttpRequest<kladobj>($"kladobjs/{id}"));

        public async Task<IEnumerable<kladobj>> GetAllKLADobjs()
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<kladobj>>($"kladobjs"), allObjects: true);

        public async Task<IEnumerable<kladobj>> QueryKLADobjs(ICriteria<kladobj> criteria)
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<kladobj>>($"kladobjs"), allObjects: true)
               .Where(criteria.Filter.Compile());


        private IEnumerable<kladobj> CacheAndReturn(IEnumerable<kladobj> kladobjs, bool allObjects = false)
        {
            if (allObjects)
            {
                _kladobjCache.ClearCache();
            }
            _kladobjCache.UpdateObjects(kladobjs, DateTime.Now.AddDays(1), allObjects);
            return kladobjs;
        }

        private kladobj CacheAndReturn(kladobj kladobj)
        {
            _kladobjCache.UpdateObject(kladobj, DateTime.Now.AddDays(1));
            return kladobj;
        }
    }
}
