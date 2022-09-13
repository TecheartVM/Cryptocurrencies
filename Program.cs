using Cryptocurrencies.Models.Coins;

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

            /*CoinModel coin = ApiRequests.GetCoinAsync("bitcoin").Result;*/

            /*coin.Description.Dictionary.Keys.ToList().ForEach(k => Console.WriteLine(k));
            Console.WriteLine();
            coin.Description.Dictionary.ToList().ForEach(kv => Console.WriteLine(kv.Key + "\t" + kv.Value));*/

            /*foreach (var coin in ApiRequests.GetCoinsByQuerryAsync("btc").Result.Coins)
            {
                Console.WriteLine(coin);
            }*/
        }
    }
}