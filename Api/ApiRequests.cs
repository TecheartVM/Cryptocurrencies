using Cryptocurrencies.Exceptions;
using Cryptocurrencies.Models;
using Cryptocurrencies.Models.Coins;
using Cryptocurrencies.Models.Markets;

namespace Cryptocurrencies.Api
{
    internal static class ApiRequests
    {
        public static async Task<CoinSimpleModel[]> GetTopCoinsAsync(uint count, string priceIn)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinSimpleModel[]>(
                $"coins/markets?vs_currency={priceIn}&order=market_cap_desc&per_page={count}&page=1&sparkline=false");
        }

        public static async Task<CoinInfoModel> GetCoinAsync(string coinId)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinInfoModel>(
                $"coins/{coinId}?tickers=false&market_data=false&community_data=false&developer_data=false");
        }

        public static async Task<CoinInfoModel> GetCoinAsync(string coinId, string localization)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinInfoModel>(
                $"coins/{coinId}?localization={localization}&tickers=false&market_data=false&community_data=false&developer_data=false");
        }

        public static async Task<CoinTickersModel> GetCoinMarketsAsync(string coinId, uint? page = 0)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinTickersModel>(
                $"coins/{coinId}/tickers?page={page}");
        }

        public static async Task<CoinsModel> SearchCoinsAsync(string querry)
        {
            return await ApiHelper.GetObjectFromApiAsync<CoinsModel>(
                $"search?query={querry}");
        }

        public static async Task<DictionaryModel> EvaluateCoinsAsync(string evaluateIn, params string[] coins)
        {
            string coinsStr = string.Join("%2C", coins);
            return await ApiHelper.GetObjectFromApiAsync<DictionaryModel>(
                $"simple/price?ids={coinsStr}&vs_currencies={evaluateIn}");
        }

        public static async Task<decimal> ConvertCoinAsync(string fromId, string toId, string compareInCurrency = "usd")
        {
            DictionaryModel model = await EvaluateCoinsAsync(compareInCurrency, fromId, toId);

            try
            {
                decimal fromPrice = model.Dictionary[fromId].Value<decimal>(compareInCurrency);
                if (fromPrice <= 0)
                    throw new BadApiResponseException($"No correct data received about currency: {fromId}");

                decimal toPrice = model.Dictionary[toId].Value<decimal>(compareInCurrency);
                if (toPrice <= 0)
                    throw new BadApiResponseException($"No correct data received about currency: {toId}");

                return fromPrice / toPrice;
            }
            catch (KeyNotFoundException e)
            {
                throw new BadApiResponseException(e.Message);
            }
        }
    }
}
