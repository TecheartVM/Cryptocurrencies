using Newtonsoft.Json;

namespace CryptocurrenciesWPF.Models.Coins
{
    public class CoinModel : CoinSimpleModel
    {
        [JsonProperty("current_price")]
        public decimal Price { get; set; }
        [JsonProperty("market_cap")]
        public decimal MarketCap { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | Symbol: {Symbol} | Price: {Price} | Mkt Cap: {MarketCap} | Rank: {MarketCapRank}";
        }
    }
}
