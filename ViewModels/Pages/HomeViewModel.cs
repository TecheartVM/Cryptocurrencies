using CryptocurrenciesWPF.Commands;
using CryptocurrenciesWPF.ViewModels.Pages.Internal;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrenciesWPF.ViewModels.Pages
{
    public class HomeViewModel : ViewModelBase
    {
        private string _searchRequest;
        public string SearchRequest
        {
            get => _searchRequest;
            set
            {
                _searchRequest = value;
                OnPropertyChanged(nameof(SearchRequest));
            }
        }

        private ViewModelBase _content;
        public ViewModelBase ContentViewModel
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(ContentViewModel));
            }
        }

        public ICommand SearchCommand { get; }

        public HomeViewModel()
        {
            ContentViewModel = new TopCoinsViewModel();

            SearchCommand = new CustomAsyncCommand(DoSearchAsync);
        }

        protected async Task DoSearchAsync()
        {
            if (string.IsNullOrWhiteSpace(SearchRequest)) return;

            ContentViewModel = new SearchCoinsViewModel(SearchRequest);
            await ((SearchCoinsViewModel)ContentViewModel).DoSearchAsync();
        }
    }
}
