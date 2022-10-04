namespace PrimeNumberService.Service
{
    public interface IPrimeNumbersService
    {
        bool isPrime(string number);

        string countPrimes(string start, string end);
    }
}
