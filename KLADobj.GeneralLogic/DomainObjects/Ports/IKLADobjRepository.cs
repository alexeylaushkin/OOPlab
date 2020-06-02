using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace KLADobj.DomainObjects.Ports
{
    public interface IReadOnlyKLADobjRepository
    {
        Task<kladobj> GetKLADobj(long id);

        Task<IEnumerable<kladobj>> GetAllKLADobjs();

        Task<IEnumerable<kladobj>> QueryKLADobjs(ICriteria<kladobj> criteria);

    }

    public interface IKLADobjRepository
    {
        Task AddKLADobj(kladobj kladobj);

        Task RemoveKLADobj(kladobj kladobj);

        Task UpdateKLADobj(kladobj kladobj);
    }
}
