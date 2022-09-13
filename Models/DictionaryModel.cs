using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cryptocurrencies.Models
{
    public class DictionaryModel
    {
        [JsonExtensionData]
        public Dictionary<string, JToken> Dictionary { get; set; }
    }
}
