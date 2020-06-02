using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KLADobj.ApplicationServices.GetFreeListUseCase
{
    public class FreeCriteria : ICriteria<kladobj>
    {
        public string Free { get; }

        public FreeCriteria (string free)
            => Free = free;

        public Expression<Func<kladobj, bool>> Filter
            => (b => b.Free == Free);
    }
}
