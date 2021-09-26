using System.Net.Http;

namespace LiquidStudiosApi.AtomicAssets.Accounts
{
    public class AccountsApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal AccountsApi(string baseUrl) => _requestUriBase = baseUrl;
    }
}
