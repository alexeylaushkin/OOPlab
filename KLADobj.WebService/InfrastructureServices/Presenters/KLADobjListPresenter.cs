using KLADobj.ApplicationServices.GetFreeListUseCase;
using System.Net;
using Newtonsoft.Json;
using KLADobj.ApplicationServices.Ports;

namespace KLADobj.InfrastructureServices.Presenters
{
    public class KLADobjListPresenter : IOutputPort<GetKLADobjListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public KLADobjListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetKLADobjListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.KLADobjs) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
