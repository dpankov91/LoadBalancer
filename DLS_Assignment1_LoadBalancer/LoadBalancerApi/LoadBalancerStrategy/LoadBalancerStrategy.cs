using LoadBalancerApi.Models;

namespace LoadBalancerApi.LoadBalancerStrategy
{
    public class LoadBalancerStrategy : ILoadBalancerStrategy
    {
        public ApiService NextService(List<ApiService> services)
        {
            throw new NotImplementedException();
        }
    }
}
