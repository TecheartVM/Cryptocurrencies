using CryptocurrenciesWPF.ViewModels.Pages;

namespace CryptocurrenciesWPF.Commands
{
    public class GoHomeCommand : NavigateCommand
    {
        public GoHomeCommand()
            : base(param => new HomeViewModel())
        {
        }
    }
}
