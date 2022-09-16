using CryptocurrenciesWPF.ViewModels.Pages.Home;

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
