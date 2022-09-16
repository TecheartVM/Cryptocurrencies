using CryptocurrenciesWPF.Models.Markets;
using System;
using System.Windows.Media;

namespace CryptocurrenciesWPF.ViewModels.Coins
{
    public class TickerViewModel : ViewModelBase
    {
        private readonly TickerModel _model;

        public string BaseCoin { get => _model.BaseCoin; }
        public string TargetCoin { get => _model.TargetCoin; }

        public string? MarketName { get => _model.MarketName; }
        public string? MarketId { get => _model.MarketId; }

        public decimal? Price { get => _model.Price; }

        public string? TradeUrl { get => _model.TradeUrl; }

        public string? TrustScore { get => _model.TrustScore; }

        public SolidColorBrush TrustColor
        {
            get
            {
                try
                {
                    SolidColorBrush result;
                    result = new SolidColorBrush((Color)ColorConverter.ConvertFromString(TrustScore));
                    return result ?? new SolidColorBrush(Colors.Black);
                }
                catch(NullReferenceException e)
                {
                    return new SolidColorBrush(Colors.Black);
                }
            }
        }

        public TickerViewModel(TickerModel model)
        {
            _model = model;
        }
    }
}
