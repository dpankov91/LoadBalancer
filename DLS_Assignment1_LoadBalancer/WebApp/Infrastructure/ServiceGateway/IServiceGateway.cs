using SharedModels;

namespace WebApp.Infrastructure.ServiceGateway
{
    public interface IServiceGateway<T>
    {
        //string CountPrimes(PrimeNumbersDTO primeNumbersDTO);

        //bool GetIsPrimes(PrimeNumbersDTO primeNumbersDTO);
        T Post(PrimeNumbersDTO primeNumbersDTO);

        T Get(string? path);
    }
}
