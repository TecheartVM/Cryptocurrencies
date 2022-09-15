using CryptocurrenciesWPF.Commands;
using CryptocurrenciesWPF.Models.Coins;
using CryptocurrenciesWPF.ViewModels.Coins;
using System;
using System.Windows.Input;
using System.Windows.Media;

namespace CryptocurrenciesWPF.ViewModels.Pages
{
    public class CoinInfoViewModel : CoinSimpleViewModel
    {
        private readonly CoinInfoModel _model;

        public decimal? MarketCap
        {
            get => _model.MarketCap;
        }

        public string? Localization
        {
            get => (string?)_model.Localization?.Dictionary?[Configuration.Configuration.GetLocalization()];
        }

        public string? Description
        {
            get => (string?)_model.Description?.Dictionary?[Configuration.Configuration.GetLocalization()];
        }

        public DateTime? GenesisDate
        {
            get
            {
                try
                {
                    return DateTime.ParseExact(
                    _model.GenesisDate,
                    "yyyy-MM-dd",
                    System.Globalization.CultureInfo.InvariantCulture
                    );
                }
                catch (Exception e) { return null; }
            }
        }

        public decimal? Price { get => _model.Price; }

        public float? PriceChange { get => _model.PriceChangePercentage; }

        public SolidColorBrush PriceChangeColor
        {
            get
            {
                if (PriceChange == null || PriceChange == 0)
                    return new SolidColorBrush(Colors.LightGray);
                return PriceChange > 0 ?
                    new SolidColorBrush(Colors.Green) :
                    new SolidColorBrush(Colors.Red);
            }
        }

        public ICommand GoHomeCommand { get; }

        public CoinInfoViewModel(CoinInfoModel model) : base(model)
        {
            _model = model;
            GoHomeCommand = new GoHomeCommand();
        }
    }
}
