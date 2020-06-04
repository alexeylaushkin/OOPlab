using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KLADobj.ApplicationServices.Repositories
{
    public class InMemoryKLADobjRepository : IReadOnlyKLADobjRepository,
                                           IKLADobjRepository 
    {
        private readonly List<kladobj> _kladobjs = new List<kladobj>();

        public InMemoryKLADobjRepository(IEnumerable<kladobj> kladobjs = null)
        {
            if (kladobjs != null)
            {
                _kladobjs.AddRange(kladobjs);
            }
        }

        public Task AddKLADobj(kladobj kladobj)
        {
            _kladobjs.Add(kladobj);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<kladobj>> GetAllKLADobjs()
        {
            return Task.FromResult(_kladobjs.AsEnumerable());
        }

        public Task<kladobj> GetKLADobj(long id)
        {
            return Task.FromResult(_kladobjs.Where(pn => pn.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<kladobj>> QueryKLADobjs(ICriteria<kladobj> criteria)
        {
            return Task.FromResult(_kladobjs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveKLADobj(kladobj kladobj)
        {
            _kladobjs.Remove(kladobj);
            return Task.CompletedTask;
        }

        public Task UpdateKLADobj(kladobj kladobj)
        {
            var foundKLADobj = GetKLADobj(kladobj.Id).Result;
            if (foundKLADobj == null)
            {
                AddKLADobj(kladobj);
            }
            else
            {
                if (foundKLADobj != kladobj)
                {
                    _kladobjs.Remove(foundKLADobj);
                    _kladobjs.Add(kladobj);
                }
            }
            return Task.CompletedTask;
        }
    }
}
