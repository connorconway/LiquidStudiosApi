using System.Net.Http;

namespace LiquidStudiosApi.AtomicMarket.Stats
{
    public class StatsApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal StatsApi(string baseUrl) => _requestUriBase = baseUrl;
    }
}