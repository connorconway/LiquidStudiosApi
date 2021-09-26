using System;
using System.Net.Http;
using LiquidStudiosApi.Core;

namespace LiquidStudiosApi.AtomicAssets.Templates
{
    public class TemplatesApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal TemplatesApi(string baseUrl) => _requestUriBase = baseUrl;

        public TemplatesDto Templates()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplatesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TemplatesDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        public TemplatesDto Templates(TemplatesUriParameterBuilder templatesUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplatesUri(templatesUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TemplatesDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        public TemplatesDto Template(string collectionName, string templateId)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplateUri(collectionName, templateId)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TemplatesDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        public StatsDto TemplateStats(string collectionName, string templateId)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplateStatsUri(collectionName, templateId)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<StatsDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        public LogsDto TemplateLogs(string collectionName, string templateId)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplateLogsUri(collectionName, templateId)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        public LogsDto TemplateLogs(string collectionName, string templateId, TemplatesUriParameterBuilder templatesUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplateLogsUri(collectionName, templateId, templatesUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        private Uri TemplatesUri() => new Uri($"{_requestUriBase}/schemas");
        private Uri TemplatesUri(TemplatesUriParameterBuilder templatessUriParameterBuilder) => new Uri($"{_requestUriBase}/schemas{templatessUriParameterBuilder.Build()}");
        private Uri TemplateUri(string collectionName, string templateId) => new Uri($"{_requestUriBase}/schemas/{collectionName}/{templateId}");
        private Uri TemplateStatsUri(string collectionName, string templateId) => new Uri($"{_requestUriBase}/schemas/{collectionName}/{templateId}/stats");
        private Uri TemplateLogsUri(string collectionName, string templateId) => new Uri($"{_requestUriBase}/schemas/{collectionName}/{templateId}/logs");
        private Uri TemplateLogsUri(string collectionName, string templateId, TemplatesUriParameterBuilder templatesUriParameterBuilder) => new Uri($"{_requestUriBase}/schemas/{collectionName}/{templateId}/logs{templatesUriParameterBuilder.Build()}");
    }
}