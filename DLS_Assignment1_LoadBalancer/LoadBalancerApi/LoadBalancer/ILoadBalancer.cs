using LoadBalancerApi.LoadBalancerStrategy;
using LoadBalancerApi.Models;

namespace LoadBalancerApi.LoadBalancer
{
    public interface ILoadBalancer
    {
        public List<ApiService> GetAllServices();

        public ApiService AddService(ApiService service);

        public void RemoveService(int id);

        public ILoadBalancerStrategy GetActiveStrategy();

        public void SetActiveStrategy(ILoadBalancerStrategy strategy);

        public ApiService NextService();
    }
}
