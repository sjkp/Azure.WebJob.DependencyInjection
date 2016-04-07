using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.WebJob.DependencyInjection
{
    public class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            return CreateContainer();
        });

        public static IUnityContainer Container
        {
            get {
                return container.Value;
            }
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<ISingletonService, SingletonService>(new ContainerControlledLifetimeManager()); //Register it as a singleton
            container.RegisterType<IInstanceService, InstanceService>();


            return container;

        }
    }
}
