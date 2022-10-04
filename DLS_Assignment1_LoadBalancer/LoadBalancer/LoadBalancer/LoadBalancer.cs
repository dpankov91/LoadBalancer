using LoadBalancer.LoadBalancerStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer.LoadBalancer
{
    internal class LoadBalancer : ILoadBalancer
    {
        public int AddService(string url)
        {
            // store all service(url string) in db (https://localhost:11001/ & https://localhost:11002/)
            throw new NotImplementedException();
        }

        public int RemoveService(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllServices()
        {
            throw new NotImplementedException();
        }

        public ILoadBalancerStrategy GetActiveStrategy()
        {
            throw new NotImplementedException();
        }

        public string NextService()
        {
            throw new NotImplementedException();
        }

        public void SetActiveStrategy(ILoadBalancerStrategy strategy)
        {
            throw new NotImplementedException();
        }
    }
}
