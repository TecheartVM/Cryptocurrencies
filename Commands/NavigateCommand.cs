using CryptocurrenciesWPF.Navigation;
using CryptocurrenciesWPF.ViewModels;
using System;

namespace CryptocurrenciesWPF.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly Func<object?, ViewModelBase> _createViewModelFunction;

        public NavigateCommand(Func<object?, ViewModelBase> createViewModelFunction)
        {
            _createViewModelFunction = createViewModelFunction;
        }

        public override void Execute(object? parameter)
        {
            ViewModelBase viewModel;
            try
            {
                viewModel = _createViewModelFunction(parameter);
            }
            catch(Exception) { return; }

            if (viewModel != null)
                NavigationStore.Instance.CurrentViewModel = viewModel;
        }
    }
}
