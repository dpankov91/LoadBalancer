namespace LoadBalancerApi.Data.DbInitializer
{
    public interface IDbInitializer
    {
        void Initialize(ApiServiceContext context);
    }
}
