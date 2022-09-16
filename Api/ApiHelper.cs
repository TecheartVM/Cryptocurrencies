using CryptocurrenciesWPF.Exceptions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptocurrenciesWPF.Api
{
    internal static class ApiHelper
    {
        private static DateTime _lastRequestTime = DateTime.MinValue;

        public static HttpClient HttpClient { get; } = new HttpClient();

        public static void SetupClient(string apiBaseAddress)
        {
            HttpClient.BaseAddress = new Uri(apiBaseAddress);
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliaction/json"));
        }

        public static async Task<T> GetObjectFromApiAsync<T>(string request)
        {
            //delay is for avoiding api 'Too many requests' error response
            await MakeDelay(3.0D);

            using (HttpResponseMessage response = await HttpClient.GetAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<T>();
                }
                else
                {
                    throw new BadApiResponseException(response);
                }
            }
        }

        private static async Task MakeDelay(double seconds)
        {
            TimeSpan timeSinceLastReq = DateTime.Now - _lastRequestTime;
            if (timeSinceLastReq.TotalSeconds < seconds)
                await Task.Delay(TimeSpan.FromSeconds(seconds) - timeSinceLastReq);
            _lastRequestTime = DateTime.Now;
        }
    }
}
