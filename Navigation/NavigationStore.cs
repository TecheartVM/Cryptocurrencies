using CryptocurrenciesWPF.ViewModels;
using System;

namespace CryptocurrenciesWPF.Navigation
{
    public class NavigationStore
    {
        public static readonly NavigationStore Instance = new NavigationStore();

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                PreviousViewModel = _currentViewModel;
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public ViewModelBase PreviousViewModel { get; set; }

        protected void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action? CurrentViewModelChanged;

        private NavigationStore() { }
    }
}
