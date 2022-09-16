using CryptocurrenciesWPF.Models.Coins;

namespace CryptocurrenciesWPF.ViewModels.Coins
{
    public class CoinSimpleViewModel : ViewModelBase
    {
        private readonly CoinSimpleModel _model;

        public string Id
        {
            get => _model.Id;
            set { _model.Id = value; OnPropertyChanged(nameof(Id)); }
        }

        public string Name
        {
            get => _model.Name;
            set { _model.Name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Symbol
        {
            get => _model.Symbol;
            set { _model.Symbol = value; OnPropertyChanged(nameof(Symbol)); }
        }

        public int? MarketCapRank
        {
            get => _model.MarketCapRank;
            set { _model.MarketCapRank = value; OnPropertyChanged(nameof(MarketCapRank)); }
        }


        public CoinSimpleViewModel(CoinSimpleModel model)
        {
            _model = model;
        }
    }
}
