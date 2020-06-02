using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KLADobj.DomainObjects;
using KLADobj.ApplicationServices.GetFreeListUseCase;
using KLADobj.InfrastructureServices.Presenters;

namespace KLADobj.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KLADobjsController : ControllerBase
    {
        private readonly ILogger<KLADobjsController> _logger;
        private readonly IGetKLADobjListUseCase _getKLADobjListUseCase;

        public KLADobjsController(ILogger<KLADobjsController> logger,
                                IGetKLADobjListUseCase getKLADobjListUseCase)
        {
            _logger = logger;
            _getKLADobjListUseCase = getKLADobjListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllKLADobjs()
        {
            var presenter = new KLADobjListPresenter();
            await _getKLADobjListUseCase.Handle(GetKLADobjListUseCaseRequest.CreateAllKLADobjsRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{kladobjId}")]
        public async Task<ActionResult> GetKLADobj(long kladobjId)
        {
            var presenter = new KLADobjListPresenter();
            await _getKLADobjListUseCase.Handle(GetKLADobjListUseCaseRequest.CreateKLADobjRequest(kladobjId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("free/{free}")]
        public async Task<ActionResult> GetFreeKLADobjs(string free)
        {
            var presenter = new KLADobjListPresenter();
            await _getKLADobjListUseCase.Handle(GetKLADobjListUseCaseRequest.CreateKLADobjsRequest(free), presenter);
            return presenter.ContentResult;
        }
    }
}
