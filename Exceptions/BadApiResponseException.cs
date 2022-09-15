using System;
using System.Net.Http;

namespace CryptocurrenciesWPF.Exceptions
{
    internal class BadApiResponseException : Exception
    {
        public BadApiResponseException(HttpResponseMessage response) : base(response.ReasonPhrase) { }

        public BadApiResponseException(string? reason) : base(reason) { }
    }
}
