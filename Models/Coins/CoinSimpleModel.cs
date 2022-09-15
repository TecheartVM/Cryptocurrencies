using Newtonsoft.Json;

namespace CryptocurrenciesWPF.Models.Coins
{
    public class CoinSimpleModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\tName: {Name}\tSymbol: {Symbol}";
        }
    }
}
