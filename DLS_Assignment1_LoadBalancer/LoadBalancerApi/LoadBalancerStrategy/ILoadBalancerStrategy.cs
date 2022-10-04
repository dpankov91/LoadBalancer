namespace LoadBalancerApi.LoadBalancerStrategy
{
    public interface ILoadBalancerStrategy
    {
        public string NextService(List<string> services);
    }
}
