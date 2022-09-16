using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CryptocurrenciesWPF.Views
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();

            Placeholder.GotFocus += RemoveSearchBoxPlaceholder;
            SearchBox.LostFocus += AddSearchBoxPlaceholder;
        }

        private void AddSearchBoxPlaceholder(object sender, EventArgs args)
        {
            if(string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                Placeholder.Visibility = Visibility.Visible;
            }
        }

        private void RemoveSearchBoxPlaceholder(object sender, EventArgs args)
        {
            if(Placeholder.Visibility == Visibility.Visible)
            {
                Placeholder.Visibility = Visibility.Hidden;
                SearchBox.Focus();
            }
        }
    }
}
