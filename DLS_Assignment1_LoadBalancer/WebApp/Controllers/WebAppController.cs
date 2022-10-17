using Microsoft.AspNetCore.Mvc;
using SharedModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebAppController : ControllerBase
    {
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
