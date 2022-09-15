using CryptocurrenciesWPF.Navigation;

namespace CryptocurrenciesWPF.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel => NavigationStore.Instance.CurrentViewModel;

        public MainWindowViewModel()
        {
            NavigationStore.Instance.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
