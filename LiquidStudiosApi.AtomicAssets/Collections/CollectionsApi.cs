using System;
using System.Net.Http;
using System.Text;
using LiquidStudiosApi.Core;

namespace LiquidStudiosApi.AtomicAssets.Collections
{
    public class CollectionsApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();
        private string _author;
        private string _match;
        private string _collectionBlacklist;
        private string _collectionWhitelist;
        private string _authorisedAccount;
        private string _ids;
        private string _lowerBound;
        private string _upperBound;
        private int? _before;
        private int? _after;
        private int? _page;
        private int? _limit;
        private SortStrategy? _sortStrategy;
        private string _sort;
        private string _notifyAccount;

        internal CollectionsApi(string baseUrl) => _requestUriBase = baseUrl;

        public CollectionsDto Collections()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionsUri).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionsDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        public CollectionsDto Collection(string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionUri(collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionsDto>();
            throw new ArgumentException($"An exception has occurred.");
        }
 
        public StatsDto CollectionStats(string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionStatsUri(collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<StatsDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        public LogsDto CollectionLogs(string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionLogsUri(collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred.");
        }

        public CollectionsApi WithAuthor(string author)
        {
            _author = author;
            return this;
        }

        public CollectionsApi WithMatch(string match)
        {
            _match = match;
            return this;
        }

        public CollectionsApi WithCollectionBlacklist(string[] collectionBlacklist)
        {
            _collectionBlacklist = string.Join(",", collectionBlacklist);
            return this;
        }

        public CollectionsApi WithCollectionWhitelist(string[] collectionWhitelist)
        {
            _collectionWhitelist = string.Join(",", collectionWhitelist);
            return this;
        }

        public CollectionsApi WithAuthorisedAccount(string authorisedAccount)
        {
            _authorisedAccount = authorisedAccount;
            return this;
        }

        public CollectionsApi WithIds(string[] ids)
        {
            _ids = string.Join(",", ids);
            return this;
        }

        public CollectionsApi WithNotifyAccount(string notifyAccount)
        {
            _notifyAccount = notifyAccount;
            return this;
        }

        public CollectionsApi WithLowerBound(string lowerBound)
        {
            _lowerBound = lowerBound;
            return this;
        }

        public CollectionsApi WithUpperBound(string upperBound)
        {
            _upperBound = upperBound;
            return this;
        }

        public CollectionsApi WithBefore(int before)
        {
            _before = before;
            return this;
        }

        public CollectionsApi WithAfter(int after)
        {
            _after = after;
            return this;
        }

        public CollectionsApi WithPage(int page)
        {
            _page = page;
            return this;
        }

        public CollectionsApi WithLimit(int limit)
        {
            _limit = limit;
            return this;
        }

        public CollectionsApi WithOrder(SortStrategy sorting)
        {
            _sortStrategy = sorting;
            return this;
        }

        public CollectionsApi WithSort(string sort)
        {
            _sort = sort;
            return this;
        }

        public string BuildCollectionsParameters()
        {
            var parameterString = new StringBuilder("?");
            if (!string.IsNullOrEmpty(_author))
            {
                parameterString.Append($"&author={_author}");
            }
            if (!string.IsNullOrEmpty(_match))
            {
                parameterString.Append($"&match={_match}");
            }
            if (!string.IsNullOrEmpty(_authorisedAccount))
            {
                parameterString.Append($"&authorized_account={_authorisedAccount}");
            }
            if (!string.IsNullOrEmpty(_notifyAccount))
            {
                parameterString.Append($"&notify_account={_notifyAccount}");
            }
            if (!string.IsNullOrEmpty(_collectionBlacklist))
            {
                parameterString.Append($"&collection_blacklist={_collectionBlacklist}");
            }
            if (!string.IsNullOrEmpty(_collectionWhitelist))
            {
                parameterString.Append($"&collection_whitelist={_collectionWhitelist}");
            }
            if (!string.IsNullOrEmpty(_ids))
            {
                parameterString.Append($"&ids={_ids}");
            }
            if (!string.IsNullOrEmpty(_lowerBound))
            {
                parameterString.Append($"&lower_bound={_lowerBound}");
            }
            if (!string.IsNullOrEmpty(_upperBound))
            {
                parameterString.Append($"&upper_bound={_upperBound}");
            }
            if (_before.HasValue)
            {
                parameterString.Append($"&before={_before}");
            }
            if (_after.HasValue)
            {
                parameterString.Append($"&after={_after}");
            }
            if (_page.HasValue)
            {
                parameterString.Append($"&page={_page}");
            }
            if (_limit.HasValue)
            {
                parameterString.Append($"&limit={_limit}");
            }
            if (_sortStrategy.HasValue)
            {
                switch (_sortStrategy)
                {
                    case SortStrategy.Ascending:
                        parameterString.Append("&order=asc");
                        break;
                    case SortStrategy.Descending:
                        parameterString.Append("&order=desc");
                        break;
                }
            }
            if (!string.IsNullOrEmpty(_sort))
            {
                parameterString.Append($"&sort={_sort}");
            }

            return parameterString.ToString();
        }

        private Uri CollectionsUri => new Uri($"{_requestUriBase}/collections{BuildCollectionsParameters()}");
        private Uri CollectionUri(string collectionName) => new Uri($"{_requestUriBase}/collections/{collectionName}");
        private Uri CollectionStatsUri(string collectionName) => new Uri($"{_requestUriBase}/collections/{collectionName}/stats");
        private Uri CollectionLogsUri(string collectionName) => new Uri($"{_requestUriBase}/collections/{collectionName}/logs");

        public enum SortStrategy
        {
            Ascending,
            Descending
        }
    }
}