using Newtonsoft.Json;

namespace CryptocurrenciesWPF.Models.Coins
{
    public class CoinMarketDataModel
    {
        [JsonProperty("current_price")]
        public DictionaryModel? CurrentPrice { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public float? PriceChange { get; set; }

        [JsonProperty("market_cap")]
        public DictionaryModel? MarketCap { get; set; }
    }
}
