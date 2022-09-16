using CryptocurrenciesWPF.Api;
using CryptocurrenciesWPF.Commands;
using CryptocurrenciesWPF.Models.Coins;
using CryptocurrenciesWPF.ViewModels.Coins;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrenciesWPF.ViewModels.Pages.Home
{
    public class TopCoinsViewModel : HomeContentBaseViewModel<CoinViewModel>
    {
        public ICommand RefreshCommand { get; }

        public TopCoinsViewModel() : base()
        {
            RefreshCommand = new CustomAsyncCommand(Refresh);
        }

        public async Task Refresh()
        {
            await LoadTopCoins();
        }

        public async Task LoadTopCoins()
        {
            try
            {
                CoinModel[] models = await ApiRequests.GetTopCoinsAsync(10);

                _coins.Clear();

                foreach (CoinModel coin in models)
                    _coins.Add(new CoinViewModel(coin));
            }
            catch (Exception e) { }
        }
    }
}
