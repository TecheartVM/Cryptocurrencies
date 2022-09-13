﻿namespace Cryptocurrencies.Models.Coins
{
    public class CoinModel
    {
        public string Id { get; set; }
        public int? Coin_id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Market_cap_rank { get; set; }
        public decimal? Price_btc { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\tCoin id: {Coin_id}\tName: {Name}\tSymbol: {Symbol}\tMarket cap rank: {Market_cap_rank}\tPrice(BTC): {Price_btc}";
        }
    }
}
