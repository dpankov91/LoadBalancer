using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoadBalancerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadBalancerController : ControllerBase
    {
        // GET: api/<LoadBalancerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoadBalancerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoadBalancerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoadBalancerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoadBalancerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
