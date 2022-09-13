namespace Cryptocurrencies
{
    internal class Configuration
    {
        public static readonly string Localization = "en";

        public static string GetLocalization() { return Localization; }
    }
}
