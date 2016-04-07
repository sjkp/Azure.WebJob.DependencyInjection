using Microsoft.Azure.WebJobs.Host;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.WebJob.DependencyInjection
{
    /// <summary>
    /// Custom <see cref="TraceWriter"/> demonstrating how JobHost logs/traces can
    /// be intercepted by user code.
    /// </summary>
    public class CustomTraceWriter : TraceWriter
    {
        public CustomTraceWriter(TraceLevel level)
            : base(level)
        {
        }

        public override void Trace(TraceEvent traceEvent)
        {
            // handle trace messages here
        }
    }
}
