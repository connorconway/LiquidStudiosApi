using LiquidStudiosApi.AtomicAssets.Assets;
using Newtonsoft.Json;

namespace LiquidStudiosApi.AtomicAssets.Transfers
{
    public class TransfersDto
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public DataDto[] Data { get; set; }

        public class DataDto
        {
            [JsonProperty("contract")]
            public string Contract { get; set; }

            [JsonProperty("transfer_id")]
            public string TransferId { get; set; }

            [JsonProperty("sender_name")]
            public string SenderName { get; set; }

            [JsonProperty("recipient_name")]
            public string RecipientName { get; set; }

            [JsonProperty("memo")]
            public string Memo { get; set; }

            [JsonProperty("assets")]
            public AssetsDto[] Assets { get; set; }

            [JsonProperty("created_at_block")]
            public float CreatedAtBlock { get; set; }

            [JsonProperty("created_at_time")]
            public float CreatedAtTime { get; set; }
        }
    }
}
