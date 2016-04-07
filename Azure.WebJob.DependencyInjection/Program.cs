using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace Azure.WebJob.DependencyInjection
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            JobHostConfiguration config = new JobHostConfiguration()
            {
                JobActivator = new UnityJobActivator(UnityConfig.Container)
            };
            config.UseTimers();
            config.Tracing.Tracers.Add(new CustomTraceWriter(System.Diagnostics.TraceLevel.Verbose));
            //if (config.IsDevelopment) //set an environment variable AzureWebJobsEnv with value Development https://github.com/Azure/azure-webjobs-sdk/wiki/Running-Locally
            {
                config.UseDevelopmentSettings();
            }
            var host = new JobHost(config);
            // The following code ensures that the WebJob will be running continuously
            host.RunAndBlock();
        }
    }
}
