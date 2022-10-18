using LoadBalancerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LoadBalancerApi.Data.Repo
{
    public class ServicesRepository : IRepository<ApiService>
    {
        private readonly ApiServiceContext db;

        public ServicesRepository(ApiServiceContext context)
        {
            db = context;
        }

        public ApiService Add(ApiService entity)
        {
            var newService = db.ApiServices.Add(entity).Entity;
            db.SaveChanges();
            return newService;
        }

        public void Edit(ApiService entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public ApiService Get(int id)
        {
            var apiService = db.ApiServices.FirstOrDefault(x => x.Id == id);
            return apiService;
        }

        public IEnumerable<ApiService> GetAll()
        {
            var allServices = db.ApiServices.ToList();
            return allServices;
        }

        public void Remove(int id)
        {
            var apiService = db.ApiServices.FirstOrDefault(p => p.Id == id);
            if (apiService != null)
            {
                db.ApiServices.Remove(apiService);
                db.SaveChanges();
            }
        }
    }
}
