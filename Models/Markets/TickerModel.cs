using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace CryptocurrenciesWPF.Models.Markets
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

        [JsonIgnore]
        public string? MarketName { get => Market?.Name; }
        [JsonIgnore]
        public string? MarketId { get => Market?.Identifier; }

        [JsonProperty("converted_last")]
        public DictionaryModel? _prices { get; set; }
        [JsonIgnore]
        public decimal? Price { get; private set; }

        [JsonProperty("trade_url")]
        public string? TradeUrl { get; set; }

        [JsonProperty("trust_score")]
        public string? TrustScore { get; set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            try { Price = (decimal?)_prices?.Dictionary?["usd"]; }
            catch (Exception e) { Price = null; }
            /*Price = (decimal?)(_prices?.Dictionary?["usd"]);*/
        }

        public override string ToString()
        {
            return $"{Market.Name} | {BaseCoin}->{TargetCoin} | ${Price?.ToString() ?? "--"}";
        }
    }
}
