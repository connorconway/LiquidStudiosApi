using System.Text;

namespace LiquidStudiosApi.AtomicAssets.Transfers
{
    //TODO use the correct parameters
    public class TransfersUriParameterBuilder
    {
        private string _owner;
        private string _collectionName;
        private string _schemaName;
        private int? _templateId;
        private string _match;
        private string _collectionBlacklist;
        private string _collectionWhitelist;
        private bool? _onlyDuplicateTemplates;
        private string _authorisedAccount;
        private bool? _hideOffers;
        private string _ids;
        private string _lowerBound;
        private string _upperBound;
        private int? _before;
        private int? _after;
        private int? _page;
        private int? _limit;
        private SortStrategy? _sortStrategy;
        private string _sort;

        public TransfersUriParameterBuilder WithOwner(string owner)
        {
            _owner = owner;
            return this;
        }

        public TransfersUriParameterBuilder WithCollectionName(string collectionName)
        {
            _collectionName = collectionName;
            return this;
        }

        public TransfersUriParameterBuilder WithSchemaName(string schemaName)
        {
            _schemaName = schemaName;
            return this;
        }

        public TransfersUriParameterBuilder WithTemplateId(int templateId)
        {
            _templateId = templateId;
            return this;
        }

        public TransfersUriParameterBuilder WithMatch(string match)
        {
            _match = match;
            return this;
        }

        public TransfersUriParameterBuilder WithCollectionBlacklist(string[] collectionBlacklist)
        {
            _collectionBlacklist = string.Join(",", collectionBlacklist);
            return this;
        }

        public TransfersUriParameterBuilder WithCollectionWhitelist(string[] collectionWhitelist)
        {
            _collectionWhitelist = string.Join(",", collectionWhitelist);
            return this;
        }

        public TransfersUriParameterBuilder WithOnlyDuplicateTemplate(bool onlyDuplicateTemplates)
        {
            _onlyDuplicateTemplates = onlyDuplicateTemplates;
            return this;
        }

        public TransfersUriParameterBuilder WithAuthorisedAccount(string authorisedAccount)
        {
            _authorisedAccount = authorisedAccount;
            return this;
        }

        public TransfersUriParameterBuilder WithHideOffers(bool hideOffers)
        {
            _hideOffers = hideOffers;
            return this;
        }

        public TransfersUriParameterBuilder WithIds(string[] ids)
        {
            _ids = string.Join(",", ids);
            return this;
        }

        public TransfersUriParameterBuilder WithLowerBound(string lowerBound)
        {
            _lowerBound = lowerBound;
            return this;
        }

        public TransfersUriParameterBuilder WithUpperBound(string upperBound)
        {
            _upperBound = upperBound;
            return this;
        }

        public TransfersUriParameterBuilder WithBefore(int before)
        {
            _before = before;
            return this;
        }

        public TransfersUriParameterBuilder WithAfter(int after)
        {
            _after = after;
            return this;
        }

        public TransfersUriParameterBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        public TransfersUriParameterBuilder WithLimit(int limit)
        {
            _limit = limit;
            return this;
        }

        public TransfersUriParameterBuilder WithOrder(SortStrategy sorting)
        {
            _sortStrategy = sorting;
            return this;
        }

        public TransfersUriParameterBuilder WithSort(string sort)
        {
            _sort = sort;
            return this;
        }

        public string Build()
        {
            var parameterString = new StringBuilder("?");
            if (!string.IsNullOrEmpty(_owner))
            {
                parameterString.Append($"&owner={_owner}");
            }
            if (!string.IsNullOrEmpty(_collectionName))
            {
                parameterString.Append($"&collection_name={_collectionName}");
            }
            if (_templateId.HasValue)
            {
                parameterString.Append($"&template_id={_templateId}");
            }
            if (!string.IsNullOrEmpty(_match))
            {
                parameterString.Append($"&match={_match}");
            }
            if (!string.IsNullOrEmpty(_collectionBlacklist))
            {
                parameterString.Append($"&collection_blacklist={_collectionBlacklist}");
            }
            if (!string.IsNullOrEmpty(_collectionWhitelist))
            {
                parameterString.Append($"&collection_whitelist={_collectionWhitelist}");
            }
            if (_onlyDuplicateTemplates.HasValue)
            {
                parameterString.Append($"&only_duplicate_templates={_onlyDuplicateTemplates}");
            }
            if (!string.IsNullOrEmpty(_authorisedAccount))
            {
                parameterString.Append($"&authorized_account={_authorisedAccount}");
            }
            if (_hideOffers.HasValue)
            {
                parameterString.Append($"&hide_offers={_hideOffers}");
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
            if (!string.IsNullOrEmpty(_schemaName))
            {
                parameterString.Append($"&schema_name={_schemaName}");
            }

            return parameterString.ToString();
        }
    }
}
