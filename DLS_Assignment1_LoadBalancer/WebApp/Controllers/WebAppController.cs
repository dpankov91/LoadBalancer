using Microsoft.AspNetCore.Mvc;
using RestSharp;
using SharedModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebAppController : ControllerBase
    {
        [HttpGet]
        [Route("GetIsPrime")]
        public async Task<bool> GetIsPrime(string number)
        {
            RestClient c = new RestClient("http://192.168.160.4/api/loadbalancer/GetIsPrime");

            var request = new RestRequest();
            request.AddParameter("number", number);
            var response = c.GetAsync<bool>(request);

            response.Wait();
            return response.Result;
        }

        [HttpGet]
        [Route("GetCountPrimes")]
        public async Task<string> GetCountPrimes(string start, string end)
        {
            RestClient c = new RestClient("https://localhost:44304/api/loadbalancer/GetCountPrimes");

            var request = new RestRequest();
            request.AddParameter("start", start);
            request.AddParameter("end", end);
            var response = await c.ExecuteAsync<string>(request);

            return response.Data;
        }
    }
}
