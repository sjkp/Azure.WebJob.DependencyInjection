using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.WebJob.DependencyInjection
{
    public class InstanceService : IInstanceService
    {
        private Guid id;
        public string GetId
        {
            get
            {
                if (id == Guid.Empty)
                {
                    id = Guid.NewGuid();
                }

                return "Instance id " + id.ToString();
            }
        }
    }

    public interface IInstanceService
    {
        string GetId { get; }
    }
}
