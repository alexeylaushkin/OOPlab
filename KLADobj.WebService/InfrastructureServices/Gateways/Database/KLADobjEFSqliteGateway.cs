using KLADobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using KLADobj.ApplicationServices.Ports.Gateways.Database;

namespace KLADobj.InfrastructureServices.Gateways.Database
{
    public class KLADobjEFSqliteGateway : IKLADobjDatabaseGateway
    {
        private readonly KLADobjContext _kladobjContext;

        public KLADobjEFSqliteGateway(KLADobjContext KLADobjContext)
            => _kladobjContext = KLADobjContext;

        public async Task<kladobj> GetKLADobj(long id)
           => await _kladobjContext.KLADobjs.Where(b => b.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<kladobj>> GetAllKLADobjs()
            => await _kladobjContext.KLADobjs.ToListAsync();
          
        public async Task<IEnumerable<kladobj>> QueryKLADobjs(Expression<Func<kladobj, bool>> filter)
            => await _kladobjContext.KLADobjs.Where(filter).ToListAsync();

        public async Task AddKLADobj(kladobj kladobj)
        {
            _kladobjContext.KLADobjs.Add(kladobj);
            await _kladobjContext.SaveChangesAsync();
        }

        public async Task UpdateKLADobj(kladobj kladobj)
        {
            _kladobjContext.Entry(kladobj).State = EntityState.Modified;
            await _kladobjContext.SaveChangesAsync();
        }

        public async Task RemoveKLADobj(kladobj kladobj)
        {
            _kladobjContext.KLADobjs.Remove(kladobj);
            await _kladobjContext.SaveChangesAsync();
        }

    }
}
