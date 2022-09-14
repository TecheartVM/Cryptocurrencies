using Cryptocurrencies.Api;
using Cryptocurrencies.Models;
using Cryptocurrencies.Models.Coins;
using Cryptocurrencies.Models.Markets;
using Newtonsoft.Json.Linq;

namespace Cryptocurrencies
{
    internal class Program
    {
        static string ApiBaseAddress = "https://api.coingecko.com/api/v3/";

        static void Main(string[] args)
        {
            ApiHelper.SetupClient(ApiBaseAddress);

            Console.WriteLine("App started\n");

            /*foreach (var coin in ApiRequests.GetTopCoinsAsync(10, "usd").Result)
            {
                Console.WriteLine(coin);
            }*/

            /*CoinInfoModel coin = ApiRequests.GetCoinAsync("bitcoin").Result;
            Console.WriteLine(coin);
            coin.Description.Dictionary.Keys.ToList().ForEach(k => Console.WriteLine(k));
            Console.WriteLine();
            coin.Description.Dictionary.ToList().ForEach(kv => Console.WriteLine(kv.Key + "\t" + kv.Value));*/

            /*foreach (var coin in ApiRequests.SearchCoinsAsync("btc").Result.Coins)
            {
                Console.WriteLine(coin);
            }*/

            /*Console.WriteLine($"1 AAVE = {ApiRequests.ConvertCoinAsync("aave", "bitcoin").Result} BTC");
            Console.WriteLine($"1 BTC = {ApiRequests.ConvertCoinAsync("bitcoin", "aave").Result} AAVE");*/

            /*CoinTickersModel model = ApiRequests.GetCoinMarketsAsync("ethereum").Result;
            Console.WriteLine(model.CoinName);
            for (int i = 0; i < 10; i++) Console.WriteLine(model.Tickers[i]);*/
        }
    }
}