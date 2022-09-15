using CryptocurrenciesWPF.Models.Coins;

namespace CryptocurrenciesWPF.ViewModels.Coins
{
    public class CoinViewModel : CoinSimpleViewModel
    {
        private readonly CoinModel _model;

        public decimal Price
        {
            get => _model.Price;
            set { _model.Price = value; OnPropertyChanged(nameof(Price)); }
        }

        public decimal MarketCap
        {
            get => _model.MarketCap;
            set { _model.MarketCap = value; OnPropertyChanged(nameof(MarketCap)); }
        }

        public CoinViewModel(CoinModel model) : base(model)
        {
            _model = model;
        }
    }
}
