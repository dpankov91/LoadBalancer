using Microsoft.AspNetCore.Mvc;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoadBalancerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadBalancerController : ControllerBase
    {
        public static int requestCount = 0;

        [HttpGet]
        [Route("GetIsPrime")]
        public Task<bool> GetIsPrime(string number)
        {
            return ExecutingIsPrime(number);
        }

        [HttpGet]
        [Route("GetCountPrimes")]
        public Task<string> GetCountPrimes(string start, string end)
        {
            return ExecutingCountPrimes(start, end);
        }

        public async Task<bool> ExecutingIsPrime(string number)
        {
            requestCount++;

            if (requestCount % 2 != 0)
            {
                RestClient c = new RestClient("http://192.168.160.2/api/primenumbers/GetIsPrime");

                var request = new RestRequest();
                request.AddParameter("number", number);
                var response = c.GetAsync<bool>(request);

                response.Wait();
                return response.Result;
            }
            else
            {
                RestClient c = new RestClient("http://192.168.160.2/api/primenumbers/GetIsPrime");

                var request = new RestRequest();
                request.AddParameter("number", "120");
                var response = c.GetAsync<bool>(request);

                response.Wait();
                return response.Result;
            }
        }

        public async Task<string> ExecutingCountPrimes(string start, string end)
        {
            requestCount++;

            if (requestCount % 2 != 0)
            {
                RestClient c = new RestClient("http://192.168.128.3/api/loadbalancer/GetIsPrime");

                var request = new RestRequest();
                request.AddParameter("number", "120");
                var response = c.GetAsync<string>(request);

                response.Wait();
                return response.Result;
            }
            else
            {
                RestClient c = new RestClient("http://192.168.128.3/api/loadbalancer/GetIsPrime");

                var request = new RestRequest();
                request.AddParameter("number", "120");
                var response = c.GetAsync<string>(request);

                response.Wait();
                return response.Result;
            }
        }
    }
}
