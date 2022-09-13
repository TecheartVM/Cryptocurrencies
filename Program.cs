namespace Cryptocurrencies
{
    internal class Program
    {
        static string ApiBaseAddress = "https://api.coingecko.com/api/v3/";

        static void Main(string[] args)
        {
            ApiHelper.SetupClient(ApiBaseAddress);

            Console.WriteLine("App started\n");

            foreach (var coin in ApiRequests.GetTopCoinsAsync(10, "usd").Result)
            {
                Console.WriteLine(coin);
            }
        }
    }
}