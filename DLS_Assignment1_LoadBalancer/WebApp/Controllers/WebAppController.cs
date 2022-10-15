using Microsoft.AspNetCore.Mvc;
using RestSharp;
using SharedModels;
using WebApp.Infrastructure.ServiceGateway;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebAppController : ControllerBase
    {
        IServiceGateway<PrimeNumbersDTO> primeNumbersApiGateway;

        public WebAppController(IServiceGateway<PrimeNumbersDTO> customerGateway)
        {
            primeNumbersApiGateway = customerGateway;
        }

        [HttpGet]
        [Route("GetIsPrime")]
        public async Task<bool> GetIsPrime(string number)
        {
            string startTime = DateTime.Now.ToString("HH:mm:ss tt");
            RestClient c = new RestClient();
            c.BaseUrl = new Uri("https://localhost:44304/Load_Balancer/GetIsPrime");
            var request = new RestRequest(Method.GET);
            request.AddParameter("number", number);
            var response = await c.ExecuteAsync<bool>(request);

            Console.WriteLine("Inserted number: " + number + "\tReturned value: " + response.Data
                + "\tStarted at: " + startTime + "\tEnded at: " + DateTime.Now.ToString("HH:mm:ss tt"));

            return response.Data;
        }

        [HttpGet]
        [Route("GetCountPrimes")]
        public async Task<string> GetCountPrimes(string start, string end)
        {
            string startTime = DateTime.Now.ToString("HH:mm:ss tt");
            RestClient c = new RestClient();
            c.BaseUrl = new Uri("https://localhost:44304/Load_Balancer/GetCountPrimes");
            var request = new RestRequest(Method.GET);
            request.AddParameter("start", start);
            request.AddParameter("end", end);
            var response = await c.ExecuteAsync<string>(request);

            var result = primeNumbersApiGateway.Get("GetCountPrimes");

            Console.WriteLine("Count primes from " + start + " \tto " + end + "\tResult: " + response.Data + "\tStarted at: " + startTime + "\tEnded at: " + DateTime.Now.ToString("HH:mm:ss tt"));
            return response.Data;
        }

        // GET: api/<WebAppController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WebAppController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WebAppController>
        [HttpPost]
        public void Post([FromBody] PrimeNumbersDTO primeNumbersDTO)
        {
            if(primeNumbersDTO.Number == null)
            {
                var result = primeNumbersApiGateway.countPrimes(primeNumbersDTO);
            }
        }

        // PUT api/<WebAppController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebAppController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
