using LoadBalancerApi.Models;

namespace LoadBalancerApi.LoadBalancerStrategy
{
    public interface ILoadBalancerStrategy
    {
        public ApiService NextService(List<ApiService> services);
    }
}
