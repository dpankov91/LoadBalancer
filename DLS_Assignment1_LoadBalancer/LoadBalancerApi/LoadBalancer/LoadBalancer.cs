using LoadBalancerApi.Data.Repo;
using LoadBalancerApi.LoadBalancerStrategy;
using LoadBalancerApi.Models;

namespace LoadBalancerApi.LoadBalancer
{
    public class LoadBalancer : ILoadBalancer
    {
        private readonly IRepository<ApiService> _apiServicesRepo;

        public LoadBalancer(IRepository<ApiService> ApiServicesRepo)
        {
            _apiServicesRepo = ApiServicesRepo;
        }
        public List<ApiService> GetAllServices()
        {
            return _apiServicesRepo.GetAll().ToList();
        }

        public ApiService AddService(ApiService service)
        {
            return _apiServicesRepo.Add(service); 
        }

        public void RemoveService(int id)
        {
            _apiServicesRepo.Remove(id);
        }

        public ILoadBalancerStrategy GetActiveStrategy()
        {
            throw new NotImplementedException();
        }

        public void SetActiveStrategy(ILoadBalancerStrategy strategy)
        {
            throw new NotImplementedException();
        }

        public ApiService NextService()
        {
            throw new NotImplementedException();
        }
    }
}
