using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Cryptocurrencies.Models.Markets
{
    public class TickerModel
    {
        [JsonProperty("base")]
        public string BaseCoin { get; set; }
        [JsonProperty("target")]
        public string TargetCoin { get; set; }

        [JsonProperty("coin_id")]
        public string CoinId { get; set; }
        [JsonProperty("target_coin_id")]
        public string TargetCoinId { get; set; }

        public MarketModel Market { get; set; }

        [JsonProperty("converted_last")]
        private DictionaryModel? _prices { get; set; }
        [JsonIgnore]
        public decimal? Price { get; set; }

        [JsonProperty("trade_url")]
        public string? TradeUrl { get; set; }

        [JsonProperty("trust_score")]
        public string? TrustScore { get; set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Price = (decimal?)(_prices?.Dictionary?["usd"]);
        }

        public override string ToString()
        {
            return $"{Market.Name} | {BaseCoin}->{TargetCoin} | ${Price?.ToString() ?? "--"}";
        }
    }
}
