using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer.LoadBalancerStrategy
{
    internal class LoadBalancerStrategy : ILoadBalancerStrategy
    {
        public string NextService(List<string> services)
        {
            throw new NotImplementedException();
        }
    }
}
