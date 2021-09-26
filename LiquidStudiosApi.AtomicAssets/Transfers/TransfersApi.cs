using System;
using System.Net.Http;
using LiquidStudiosApi.Core;

namespace LiquidStudiosApi.AtomicAssets.Transfers
{
    public class TransfersApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal TransfersApi(string baseUrl) => _requestUriBase = baseUrl;

        public TransfersDto Transfers()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TransfersUri).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TransfersDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        private Uri TransfersUri => new Uri($"{_requestUriBase}/transfers");
    }
}