using Newtonsoft.Json;

namespace LiquidStudiosApi.AtomicAssets.Burns
{
    public class BurnsDto
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public DataDto[] Data { get; set; }

        public class DataDto
        {
            [JsonProperty("account")]
            public string Account{ get; set; }

            [JsonProperty("assets")]
            public string Assets { get; set; }
        }
    }
}