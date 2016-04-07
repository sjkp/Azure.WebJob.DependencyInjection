using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.WebJob.DependencyInjection
{
    public class SingletonService : ISingletonService
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

                return "Singleton id " + id.ToString();
            }
        }
    }

    public interface ISingletonService
    {
        string GetId { get; }
    }
}
