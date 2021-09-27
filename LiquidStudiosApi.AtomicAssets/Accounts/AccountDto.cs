﻿using LiquidStudiosApi.AtomicAssets.Collections;
using Newtonsoft.Json;

namespace LiquidStudiosApi.AtomicAssets.Accounts
{
    public class AccountDto
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public DataDto[] Data { get; set; }

        public class DataDto
        {
            [JsonProperty("collections")]
            public CollectionsDto[] Collections { get; set; }

            [JsonProperty("templates")]
            public TemplatesDto[] Templates{ get; set; }

            [JsonProperty("assets")]
            public string Assets { get; set; }

            public class CollectionsDto
            {
                [JsonProperty("collection")]
                public CollectionDto[] Collections { get; set; }

                [JsonProperty("assets")]
                public string Assets { get; set; }
            }

            public class TemplatesDto
            {
                [JsonProperty("template_id")]
                public string TemplateId { get; set; }

                [JsonProperty("assets")]
                public string Assets { get; set; }
            }
        }
    }
}
