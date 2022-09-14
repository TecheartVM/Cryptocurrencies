using Newtonsoft.Json;

namespace Cryptocurrencies.Models.Markets
{
    public class CoinTickersModel
    {
        [JsonProperty("name")]
        public string CoinName { get; set; }

        public TickerModel[]? Tickers { get; set; }
    }
}
