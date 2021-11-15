using System.Net.Http;

namespace LiquidStudiosApi.AtomicMarket.Pricing
{
    public class PricingApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal PricingApi(string baseUrl) => _requestUriBase = baseUrl;
    }
}