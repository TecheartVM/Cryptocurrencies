namespace Cryptocurrencies.Models.Markets
{
    public class MarketModel
    {
        public string Name { get; set; }
        public string Identifier { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Identifier})";
        }
    }
}
