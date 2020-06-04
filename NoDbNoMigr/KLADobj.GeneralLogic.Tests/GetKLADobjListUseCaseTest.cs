using KLADobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using KLADobj.ApplicationServices.GetFreeListUseCase;
using System.Linq.Expressions;
using KLADobj.ApplicationServices.Ports;
using KLADobj.DomainObjects.Ports;
using KLADobj.ApplicationServices.Repositories;

namespace KLADobj.WebService.Core.Tests
{
    public class GetKLADobjListUseCaseTest
    {
        private InMemoryKLADobjRepository CreateKLADobjRepository()
        {
            var repo = new InMemoryKLADobjRepository(new List<kladobj> {
                new kladobj { Id = 1, Free = "закрытое", Name = "Домодедовское кладбище"},
                new kladobj { Id = 2, Free = "закрытое", Name = "Жохово кладбище"},
                new kladobj { Id = 3, Free = "открытое", Name = "Захарьинское кладбище"},
                new kladobj { Id = 4, Free = "закрытое", Name = "Зеленоградское (Северное) кладбище"},
            });
            return repo;
        }
        [Fact]
        public void TestGetAllKLADobj()
        {
            var useCase = new GetKLADobjListUseCase(CreateKLADobjRepository());
            var outputPort = new OutputPort();
                        
            Assert.True(useCase.Handle(GetKLADobjListUseCaseRequest.CreateAllKLADobjsRequest(), outputPort).Result);
            Assert.Equal<int>(4, outputPort.KLADobjs.Count());
            Assert.Equal(new long[] { 1, 2, 3, 4 }, outputPort.KLADobjs.Select(mp => mp.Id));
        }

        [Fact]
        public void TestGetAllKLADobjsFromEmptyRepository()
        {
            var useCase = new GetKLADobjListUseCase(new InMemoryKLADobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetKLADobjListUseCaseRequest.CreateAllKLADobjsRequest(), outputPort).Result);
            Assert.Empty(outputPort.KLADobjs);
        }

        [Fact]
        public void TestGetKLADobj()
        {
            var useCase = new GetKLADobjListUseCase(CreateKLADobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetKLADobjListUseCaseRequest.CreateKLADobjRequest(2), outputPort).Result);
            Assert.Single(outputPort.KLADobjs, pn => 2 == pn.Id);
        }

        [Fact]
        public void TestTryGetNotExistingKLADobj()
        {
            var useCase = new GetKLADobjListUseCase(CreateKLADobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetKLADobjListUseCaseRequest.CreateKLADobjRequest(999), outputPort).Result);
            Assert.Empty(outputPort.KLADobjs);
        }
      
    }

    class OutputPort : IOutputPort<GetKLADobjListUseCaseResponse>
    {
        public IEnumerable<kladobj> KLADobjs { get; private set; }

        public void Handle(GetKLADobjListUseCaseResponse response)
        {
            KLADobjs = response.KLADobjs;
        }
    }
}
