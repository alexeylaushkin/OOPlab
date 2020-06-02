using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KLADobj.DomainObjects.Repositories
{
    public abstract class ReadOnlyKLADobjRepositoryDecorator : IReadOnlyKLADobjRepository
    {
        private readonly IReadOnlyKLADobjRepository _kladobjRepository;

        public ReadOnlyKLADobjRepositoryDecorator(IReadOnlyKLADobjRepository kladobjRepository)
        {
            _kladobjRepository = kladobjRepository;
        }

        public virtual async Task<IEnumerable<kladobj>> GetAllKLADobjs()
        {
            return await _kladobjRepository?.GetAllKLADobjs();
        }

        public virtual async Task<kladobj> GetKLADobj(long id)
        {
            return await _kladobjRepository?.GetKLADobj(id);
        }

        public virtual async Task<IEnumerable<kladobj>> QueryKLADobjs(ICriteria<kladobj> criteria)
        {
            return await _kladobjRepository?.QueryKLADobjs(criteria);
        }
    }
}
