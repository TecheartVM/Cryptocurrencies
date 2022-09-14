namespace Cryptocurrencies.Configuration
{
    internal class Configuration
    {
        public static readonly string Localization = "en";

        public static string GetLocalization() { return Localization; }
    }
}
