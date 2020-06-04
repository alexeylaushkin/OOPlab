using KLADobj.ApplicationServices.Ports.Gateways.Database;
using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KLADobj.ApplicationServices.Repositories
{
    public class DbKLADobjRepository : IReadOnlyKLADobjRepository,
                                     IKLADobjRepository
    {
        private readonly IKLADobjDatabaseGateway _databaseGateway;

        public DbKLADobjRepository(IKLADobjDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<kladobj> GetKLADobj(long id)
            => await _databaseGateway.GetKLADobj(id);

        public async Task<IEnumerable<kladobj>> GetAllKLADobjs()
            => await _databaseGateway.GetAllKLADobjs();

        public async Task<IEnumerable<kladobj>> QueryKLADobjs(ICriteria<kladobj> criteria)
            => await _databaseGateway.QueryKLADobjs(criteria.Filter);

        public async Task AddKLADobj(kladobj kladobj)
            => await _databaseGateway.AddKLADobj(kladobj);

        public async Task RemoveKLADobj(kladobj kladobj)
            => await _databaseGateway.RemoveKLADobj(kladobj);

        public async Task UpdateKLADobj(kladobj kladobj)
            => await _databaseGateway.UpdateKLADobj(kladobj);
    }
}
