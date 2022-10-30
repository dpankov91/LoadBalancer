using LoadBalancerApi.Data;
using LoadBalancerApi.Data.Repo;
using LoadBalancerApi.LoadBalancerStrategy;
using LoadBalancerApi.Models;

namespace LoadBalancerApi.LoadBalancer
{
    public class LoadBalancer : ILoadBalancer
    {
        private readonly IRepository<ApiService> _apiServicesRepo;
        private readonly ApiServiceContext db;

        public LoadBalancer(IRepository<ApiService> ApiServicesRepo, ApiServiceContext context)
        {
            _apiServicesRepo = ApiServicesRepo;
            db = context;
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
            var allServices = GetAllServices();

            return allServices[0];
        }
            
    }
}
