using Cryptocurrencies.Models.Coins;

namespace Cryptocurrencies
{
    internal static class ApiRequests
    {
        public static async Task<CoinsModel> GetTrendingAsync()
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinsModel>("search/trending");
        }

        public static async Task<CoinModel[]> GetTopCoinsAsync(uint count, string priceIn)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinModel[]>(
                $"coins/markets?vs_currency={priceIn}&order=market_cap_desc&per_page={count}&page=1&sparkline=false");
        }
    }
}
