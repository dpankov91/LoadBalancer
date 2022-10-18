using LoadBalancerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LoadBalancerApi.Data
{
    public class ApiServiceContext : DbContext
    {
        public ApiServiceContext(DbContextOptions<ApiServiceContext> options)
            : base(options)
        {
        }

        public DbSet<ApiService> ApiServices { get; set; }
    }
}
