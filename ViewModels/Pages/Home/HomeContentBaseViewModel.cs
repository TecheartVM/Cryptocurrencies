using CryptocurrenciesWPF.Api;
using CryptocurrenciesWPF.Commands;
using CryptocurrenciesWPF.Models.Coins;
using CryptocurrenciesWPF.Navigation;
using CryptocurrenciesWPF.ViewModels.Coins;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrenciesWPF.ViewModels.Pages.Home
{
    public class HomeContentBaseViewModel<T> : ViewModelBase where T : CoinSimpleViewModel
    {
        protected readonly ObservableCollection<T> _coins;

        public IEnumerable<T> Coins => _coins;

        public int SelectedItemIndex { get; set; }

        public ICommand ShowCoinInfoCommand { get; }


        public HomeContentBaseViewModel()
        {
            _coins = new ObservableCollection<T>();

            ShowCoinInfoCommand = new CustomAsyncCommand(OnSelectedItemChangedAsync);
        }

        protected async Task OnSelectedItemChangedAsync()
        {
            if (SelectedItemIndex >= 0)
            {
                CoinInfoViewModel? vm = await GetSelectedCoinInfoAsync();
                if (vm != null)
                    NavigationStore.Instance.CurrentViewModel = vm;
            }
        }

        public async Task<CoinInfoViewModel?> GetSelectedCoinInfoAsync()
        {
            try
            {
                T selected = Coins.ToList()[SelectedItemIndex];
                CoinInfoModel data = await ApiRequests.GetCoinAsync(selected.Id);
                return new CoinInfoViewModel(data);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
