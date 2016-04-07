using System;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Practices.Unity;

namespace Azure.WebJob.DependencyInjection
{
    public class UnityJobActivator : IJobActivator
    {
        private readonly IUnityContainer contaner;

        public UnityJobActivator(IUnityContainer container)
        {
            this.contaner = container;
        }

        public T CreateInstance<T>()
        {
            return this.contaner.Resolve<T>();
        }
    }
}