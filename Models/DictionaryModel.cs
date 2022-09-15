using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CryptocurrenciesWPF.Models
{
    public class DictionaryModel
    {
        [JsonExtensionData]
        public Dictionary<string, JToken> Dictionary { get; set; }
    }
}
