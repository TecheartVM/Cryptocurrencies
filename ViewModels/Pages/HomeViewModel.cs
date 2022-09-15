using CryptocurrenciesWPF.Api;
using CryptocurrenciesWPF.Commands;
using CryptocurrenciesWPF.Models.Coins;
using CryptocurrenciesWPF.Navigation;
using CryptocurrenciesWPF.ViewModels.Coins;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrenciesWPF.ViewModels.Pages
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CoinViewModel> _coins;

        public IEnumerable<CoinViewModel> Coins => _coins;

        public int SelectedItemIndex { get; set; }

        public ICommand RefreshCommand { get; }
        public ICommand NavigateCommand { get; }
        public ICommand ShowCoinInfoCommand { get; }

        public HomeViewModel()
        {
            _coins = new ObservableCollection<CoinViewModel>();

            RefreshCommand = new CustomAsyncCommand(Refresh);
            NavigateCommand = new NavigateCommand(param => (ViewModelBase)param);
            ShowCoinInfoCommand = new CustomAsyncCommand(OnSelectedItemChangedAsync);
        }

        protected async Task OnSelectedItemChangedAsync()
        {
            if(SelectedItemIndex >= 0)
            {
                CoinInfoViewModel? vm = await GetSelectedCoinInfoAsync();
                if(vm != null)
                    NavigateCommand.Execute(vm);
            }
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

        public async Task<CoinInfoViewModel?> GetSelectedCoinInfoAsync()
        {
            try
            {
                CoinViewModel selected = Coins.ToList<CoinViewModel>()[SelectedItemIndex];
                CoinInfoModel data = await ApiRequests.GetCoinAsync(selected.Id);
                return new CoinInfoViewModel(data);
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
