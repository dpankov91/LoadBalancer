using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberService1
{
    public interface IPrimeNumbersServicecs
    {
        bool isPrime(string number);

        string countPrimes(string start, string end);
    }
}
