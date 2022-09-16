using CryptocurrenciesWPF.Api;
using CryptocurrenciesWPF.Commands;
using CryptocurrenciesWPF.Models.Markets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrenciesWPF.ViewModels.Coins
{
    public class CoinTickersViewModel : ViewModelBase
    {
        private readonly string _coinId;

        protected readonly ObservableCollection<TickerViewModel> _tickers;

        public IEnumerable<TickerViewModel> Tickers => _tickers;

        private int _selectedItemIndex = -1;
        public int SelectedItemIndex
        {
            get => _selectedItemIndex;
            set
            {
                _selectedItemIndex = value;
                OnPropertyChanged(nameof(SelectedItemIndex));
            }
        }

        public ICommand FollowHyperlinkCommand { get; }
        public ICommand PreviousPageCommand { get; }
        public ICommand NextPageCommand { get; }
        public ICommand RefreshPageCommand { get; }

        private int _page;
        public int Page
        {
            get => _page;
            private set
            {
                _page = value;
                OnPropertyChanged(nameof(Page));
                OnPropertyChanged(nameof(HasPreviousPage));
            }
        }        

        public bool HasPreviousPage { get => Page > 0; }
        public bool HasNextPage { get => _tickers != null && _tickers.Count > 0; }

        public CoinTickersViewModel(string coinId, int page)
        {
            _coinId = coinId;
            Page = page;

            _tickers = new ObservableCollection<TickerViewModel>();
            _tickers.CollectionChanged += (s, a) => OnPropertyChanged(nameof(HasNextPage));

            FollowHyperlinkCommand = new CustomAsyncCommand(OnSelectedItemChangedAsync);
            PreviousPageCommand = new CustomAsyncCommand(PreviousPageAsync);
            NextPageCommand = new CustomAsyncCommand(NextPageAsync);
            RefreshPageCommand = new CustomAsyncCommand(LoadContentAsync);
        }

        private async Task PreviousPageAsync()
        {
            Page = Math.Max(Page--, 0);
            await LoadContentAsync();
        }

        private async Task NextPageAsync()
        {
            Page++;
            await LoadContentAsync();
        }

        protected async Task LoadContentAsync()
        {
            _tickers.Clear();

            CoinTickersModel data = await ApiRequests.GetCoinMarketsAsync(_coinId, (uint)Page);
            if (data == null || data.Tickers == null) return;

            try
            {
                data.Tickers.ToList().ForEach(model => _tickers.Add(new TickerViewModel(model)));
            }
            catch (Exception e) { }
        }

        protected async Task OnSelectedItemChangedAsync()
        {
            if (SelectedItemIndex >= 0)
            {
                try
                {
                    string? url = _tickers?.ToList()?[SelectedItemIndex]?.TradeUrl;
                    if (url == null) return;

                    OpenUrl(url);
                }
                catch(Exception e) { }
            }
            SelectedItemIndex = -1;
        }

        protected void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
