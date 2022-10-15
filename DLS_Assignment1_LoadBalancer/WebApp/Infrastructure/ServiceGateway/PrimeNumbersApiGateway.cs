using RestSharp;
using SharedModels;

namespace WebApp.Infrastructure.ServiceGateway
{
    public class PrimeNumbersApiGateway : IServiceGateway<ResponseDTO>
    {
        string primeNumbersServiceBaseUrl;

        public ResponseDTO Get(string? path)
        {
            throw new NotImplementedException();
        }
    }
}
