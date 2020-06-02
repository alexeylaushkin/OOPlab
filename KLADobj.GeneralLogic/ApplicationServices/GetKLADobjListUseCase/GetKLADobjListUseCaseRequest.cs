using KLADobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KLADobj.ApplicationServices.GetFreeListUseCase
{
    public class GetKLADobjListUseCaseRequest : IUseCaseRequest<GetKLADobjListUseCaseResponse>
    {
        public string Free { get; private set; }
        public long? KLADobjId { get; private set; }

        private GetKLADobjListUseCaseRequest()
        { }

        public static GetKLADobjListUseCaseRequest CreateAllKLADobjsRequest()
        {
            return new GetKLADobjListUseCaseRequest();
        }

        public static GetKLADobjListUseCaseRequest CreateKLADobjRequest(long kladobjId)
        {
            return new GetKLADobjListUseCaseRequest() { KLADobjId = kladobjId };
        }
        public static GetKLADobjListUseCaseRequest CreateKLADobjsRequest(string free)
        {
            return new GetKLADobjListUseCaseRequest() { Free = free };
        }
    }
}
