using CryptocurrenciesWPF.Api;
using CryptocurrenciesWPF.Navigation;
using CryptocurrenciesWPF.ViewModels;
using CryptocurrenciesWPF.ViewModels.Pages.Home;
using System.Windows;

namespace CryptocurrenciesWPF
{
    public partial class App : Application
    {
        public App()
        {

        }

        protected async override void OnStartup(StartupEventArgs e)
        {
            ApiHelper.SetupClient("https://api.coingecko.com/api/v3/");

            NavigationStore.Instance.CurrentViewModel = new HomeViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
