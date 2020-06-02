using KLADobj.DomainObjects;
using KLADobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KLADobj.ApplicationServices.GetFreeListUseCase
{
    public class GetKLADobjListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<kladobj> KLADobjs { get; }

        public GetKLADobjListUseCaseResponse(IEnumerable<kladobj> kladobjs) => KLADobjs = kladobjs;
    }
}
