using System.Net.Http;

namespace LiquidStudiosApi.AtomicAssets.Burns
{
    public class BurnsApi
    { 
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal BurnsApi(string baseUrl) => _requestUriBase = baseUrl;
    }
}
