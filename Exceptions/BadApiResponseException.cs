using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptocurrencies.Exceptions
{
    internal class BadApiResponseException : Exception
    {
        public BadApiResponseException(HttpResponseMessage response) : base(response.ReasonPhrase) { }

        public BadApiResponseException(string? reason) : base(reason) { }
    }
}
