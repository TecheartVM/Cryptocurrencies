using Newtonsoft.Json;

namespace Cryptocurrencies.Models.Coins
{
    public class CoinInfoModel
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }

        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }

        public DictionaryModel? Localization { get; set; }
        public DictionaryModel? Description { get; set; }

        public ImageModel? Image { get; set; }

        [JsonProperty("genesis_date")]
        public string GenesisDate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\tName: {Name}\tSymbol: {Symbol}";
        }
    }
}
