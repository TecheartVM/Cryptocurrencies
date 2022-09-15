using Newtonsoft.Json;

namespace CryptocurrenciesWPF.Models.Markets
{
    public class CoinTickersModel
    {
        [JsonProperty("name")]
        public string CoinName { get; set; }

        public TickerModel[]? Tickers { get; set; }
    }
}
