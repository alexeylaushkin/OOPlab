using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KLADobj.ApplicationServices.GetFreeListUseCase
{
    public class CloseFlagCriteria : ICriteria<kladobj>
    {
        public string CloseFlag { get; }

        public CloseFlagCriteria (string CloseFlag)
            => this.CloseFlag = CloseFlag;

        public Expression<Func<kladobj, bool>> Filter
            => (b => b.CloseFlag == CloseFlag);
    }
}
