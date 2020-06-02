using System.Threading.Tasks;
using System.Collections.Generic;
using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using KLADobj.ApplicationServices.Ports;

namespace KLADobj.ApplicationServices.GetFreeListUseCase
{
    public class GetKLADobjListUseCase : IGetKLADobjListUseCase
    {
        private readonly IReadOnlyKLADobjRepository _readOnlyKLADobjRepository;

        public GetKLADobjListUseCase(IReadOnlyKLADobjRepository readOnlyKLADobjRepository) 
            => _readOnlyKLADobjRepository = readOnlyKLADobjRepository;
        
        public async Task<bool> Handle(GetKLADobjListUseCaseRequest request, IOutputPort<GetKLADobjListUseCaseResponse> outputPort)
        {
            IEnumerable<kladobj> kladobjs = null;
            if (request.KLADobjId != null)
            {
                var kladobj = await _readOnlyKLADobjRepository.GetKLADobj(request.KLADobjId.Value);
                kladobjs = (kladobj != null) ? new List<kladobj>() { kladobj } : new List<kladobj>();
                
            }
            else if (request.Free != null)
            {
                kladobjs = await _readOnlyKLADobjRepository.QueryKLADobjs(new FreeCriteria(request.Free));
            }
            else
            {
                kladobjs = await _readOnlyKLADobjRepository.GetAllKLADobjs();
            }
            outputPort.Handle(new GetKLADobjListUseCaseResponse(kladobjs));
            return true;
        }
    }
}
