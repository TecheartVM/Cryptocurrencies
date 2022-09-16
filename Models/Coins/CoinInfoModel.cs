using Newtonsoft.Json;
using System;

namespace CryptocurrenciesWPF.Models.Coins
{
    public class CoinInfoModel : CoinSimpleModel
    {
        public DictionaryModel? Localization { get; set; }
        public DictionaryModel? Description { get; set; }

        public ImageModel? Image { get; set; }

        [JsonProperty("market_data")]
        public CoinMarketDataModel? MarketData { get; set; }

        [JsonProperty("genesis_date")]
        public string? GenesisDate { get; set; }

        [JsonIgnore]
        public decimal? Price
        {
            get
            {
                try { return (decimal?)MarketData?.CurrentPrice?.Dictionary["usd"]; }
                catch(Exception e) { return null; }
            }
        }

        [JsonIgnore]
        public decimal? MarketCap
        {
            get
            {
                try { return (decimal?)MarketData?.MarketCap?.Dictionary["usd"]; }
                catch (Exception e) { return null; }
            }
        }

        [JsonIgnore]
        public decimal? Volume
        {
            get
            {
                try { return (decimal?)MarketData?.Volume?.Dictionary["usd"]; }
                catch (Exception e) { return null; }
            }
        }

        [JsonIgnore]
        public float? PriceChangePercentage => MarketData?.PriceChange;

        public override string ToString()
        {
            return $"Id: {Id}\tName: {Name}\tSymbol: {Symbol}";
        }
    }
}
