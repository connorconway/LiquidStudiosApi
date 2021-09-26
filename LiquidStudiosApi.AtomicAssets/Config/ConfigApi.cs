using System.Net.Http;

namespace LiquidStudiosApi.AtomicAssets.Config
{
    public class ConfigApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal ConfigApi(string baseUrl) => _requestUriBase = baseUrl;
    }
}
