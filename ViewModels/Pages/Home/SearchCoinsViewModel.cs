using CryptocurrenciesWPF.Api;
using CryptocurrenciesWPF.Commands;
using CryptocurrenciesWPF.Models.Coins;
using CryptocurrenciesWPF.ViewModels.Coins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrenciesWPF.ViewModels.Pages.Home
{
    public class SearchCoinsViewModel : HomeContentBaseViewModel<CoinSimpleViewModel>
    {
        public ICommand LoadSearchDataCommand { get; }
        public ICommand GoHomeCommand { get; }

        private readonly string _searchRequest;

        public string SearchRequest
        {
            get => _searchRequest;
        }

        public SearchCoinsViewModel(string searchRequest) : base()
        {
            _searchRequest = searchRequest;

            LoadSearchDataCommand = new CustomAsyncCommand(DoSearchAsync);
            GoHomeCommand = new GoHomeCommand();
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
            catch (Exception e) { }
        }
    }
}
