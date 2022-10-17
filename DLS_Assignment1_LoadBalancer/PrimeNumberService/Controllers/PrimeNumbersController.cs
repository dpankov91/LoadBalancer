using Microsoft.AspNetCore.Mvc;
using PrimeNumberService.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrimeNumberService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeNumbersController : ControllerBase
    {
        private readonly IPrimeNumbersService _primeNumbersService;

        public PrimeNumbersController(IPrimeNumbersService primeNumbersService)
        {
            _primeNumbersService = primeNumbersService;
        }

        [HttpGet]
        [Route("GetIsPrime")]
        public bool GetIsPrime(string number)
        {
            return _primeNumbersService.isPrime(number);
        }

        [HttpGet]
        [Route("GetCountPrimes")]
        public string GetCountPrimes(string start, string end)
        {
            return _primeNumbersService.countPrimes(start, end);
        }
    }
}
