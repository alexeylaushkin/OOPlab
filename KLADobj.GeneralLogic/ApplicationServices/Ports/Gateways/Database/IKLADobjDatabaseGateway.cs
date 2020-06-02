using KLADobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KLADobj.ApplicationServices.Ports.Gateways.Database
{
    public interface IKLADobjDatabaseGateway
    {
        Task AddKLADobj(kladobj kladobj);

        Task RemoveKLADobj(kladobj kladobj);

        Task UpdateKLADobj(kladobj kladobj);

        Task<kladobj> GetKLADobj(long id);

        Task<IEnumerable<kladobj>> GetAllKLADobjs();

        Task<IEnumerable<kladobj>> QueryKLADobjs(Expression<Func<kladobj, bool>> filter);

    }
}
