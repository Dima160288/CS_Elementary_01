using System;
using System.Collections.Generic;
using Ninject;
using GameStore.Domain.Entities;
using GameStore.Domain.Abstract;
using Moq;

namespace GameStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IGameRepository> mock = new Mock<IGameRepository>();
            mock.Setup(m => m.Games).Returns(new List<Game>
            {
                new Game { Name = "SimCity", Price = 1499 },
                new Game { Name = "TitanFall", Price = 2499},
                new Game { Name = "Darkest Dungeon", Price = 999}
            });
            kernel.Bind<IGameRepository>().ToConstant(mock.Object);
        }
    }
}