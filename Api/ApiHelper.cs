using Cryptocurrencies.Exceptions;

namespace Cryptocurrencies.Api
{
    internal static class ApiHelper
    {
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
            using (HttpResponseMessage response = await HttpClient.GetAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<T>();
                }
                else throw new BadApiResponseException(response);
            }
        }
    }
}
