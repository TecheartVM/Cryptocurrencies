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

namespace CryptocurrenciesWPF.ViewModels.Pages.Internal
{
    public class SearchCoinsViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CoinSimpleViewModel> _coins;

        public IEnumerable<CoinSimpleViewModel> Coins => _coins;

        public int SelectedItemIndex { get; set; }

        public ICommand LoadSearchDataCommand { get; }
        public ICommand GoHomeCommand { get; }
        public ICommand ShowCoinInfoCommand { get; }

        private readonly string _searchRequest;

        public string SearchRequest
        {
            get => _searchRequest;
        }

        public SearchCoinsViewModel(string searchRequest)
        {
            _searchRequest = searchRequest;

            _coins = new ObservableCollection<CoinSimpleViewModel>();

            LoadSearchDataCommand = new CustomAsyncCommand(DoSearchAsync);
            GoHomeCommand = new GoHomeCommand();
            ShowCoinInfoCommand = new CustomAsyncCommand(OnSelectedItemChangedAsync);
        }

        public async Task DoSearchAsync()
        {
            try
            {
                CoinsModel data = await ApiRequests.SearchCoinsAsync(_searchRequest);
                List<CoinSimpleModel>? coins = data?.Coins?.ToList();

                if (coins == null || coins.Count == 0) return;

                foreach (CoinSimpleModel coin in coins)
                    if (coin.MarketCapRank != null)
                        _coins.Add(new CoinSimpleViewModel(coin));
            }
            catch(Exception e) { }
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
                CoinSimpleViewModel selected = Coins.ToList()[SelectedItemIndex];
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
