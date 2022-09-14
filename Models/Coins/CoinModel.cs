﻿using Newtonsoft.Json;

namespace Cryptocurrencies.Models.Coins
{
    public class CoinModel
    {
        public string Id { get; set; }
        [JsonProperty("coin_id")]
        public int? CoinId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        [JsonProperty("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        [JsonProperty("price_btc")]
        public decimal? PriceBtc { get; set; }

        public DictionaryModel? Localization { get; set; }
        public DictionaryModel? Description { get; set; }

        public ImageModel? Image { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\tCoin id: {CoinId}\tName: {Name}\tSymbol: {Symbol}";
        }
    }
}
