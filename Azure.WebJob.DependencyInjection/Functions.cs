using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using System.Diagnostics;

namespace Azure.WebJob.DependencyInjection
{
    public class Functions
    {
        private readonly IInstanceService instance;
        private readonly ISingletonService singleton;

        public Functions(ISingletonService singleton, IInstanceService instance)
        {
            this.singleton = singleton;
            this.instance = instance;
        }

        public void TimerJob([TimerTrigger("*/5 * * * * *", RunOnStartup = true)] TimerInfo timer, TextWriter log)
        {
            log.WriteLine(instance.GetId);
            log.WriteLine(singleton.GetId);
            log.WriteLine(timer);
        }
    }
}
