using Cryptocurrencies.Models.Coins;

namespace Cryptocurrencies
{
    internal static class ApiRequests
    {
        public static async Task<CoinModel[]> GetTopCoinsAsync(uint count, string priceIn)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinModel[]>(
                $"coins/markets?vs_currency={priceIn}&order=market_cap_desc&per_page={count}&page=1&sparkline=false");
        }

        public static async Task<CoinModel> GetCoinAsync(string coinId)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinModel>(
                $"coins/{coinId}?tickers=false&market_data=false&community_data=false&developer_data=false");
        }

        public static async Task<CoinModel> GetCoinAsync(string coinId, string localization)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinModel>(
                $"coins/{coinId}?localization={localization}&tickers=false&market_data=false&community_data=false&developer_data=false");
        }

        public static async Task<CoinsModel> SearchCoinsAsync(string querry)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinsModel>($"search?query={querry}");
        }

        public static async Task<MarketModel> GetCoinMarketsAsync(string coinId, uint? page = 0)
        {
            return await ApiHelper.GetObjectFromApiAsync<MarketModel>($"coins/{coinId}/tickers?page={page}");
        }
    }
}
