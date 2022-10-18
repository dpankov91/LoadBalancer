using LoadBalancerApi.Models;

namespace LoadBalancerApi.Data.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        public void Initialize(ApiServiceContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Look for any Services
            if (context.ApiServices.Any())
            {
                return;   // DB has been seeded
            }

            List<ApiService> apiServices = new List<ApiService>
            {
                new ApiService {  Name = "WebAppService",
                                Url = ""},

                new ApiService {  Name = "LoadBalancerService",
                                Url = ""},

                new ApiService {  Name = "PrimeNumberService",
                                Url = ""}
            };

            context.ApiServices.AddRange(apiServices);
            context.SaveChanges();
        }
    }
}
