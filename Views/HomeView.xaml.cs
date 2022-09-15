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
        public const string SearchBoxPlaceholder = "Search for coins";

        private bool _placeholderAdded = false;
        private Brush _searchboxDefaultForeground;

        public HomeView()
        {
            InitializeComponent();

            SearchBox.GotFocus += RemoveSearchBoxPlaceholder;
            SearchBox.LostFocus += AddSearchBoxPlaceholder;

            AddSearchBoxPlaceholder();
        }

        private void AddSearchBoxPlaceholder()
        {
            SearchBox.Text = SearchBoxPlaceholder;
            _searchboxDefaultForeground = SearchBox.Foreground;
            SearchBox.Foreground = Brushes.Gray;
            _placeholderAdded = true;
        }

        private void AddSearchBoxPlaceholder(object sender, EventArgs args)
        {
            if(string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                AddSearchBoxPlaceholder();
            }
        }

        private void RemoveSearchBoxPlaceholder(object sender, EventArgs args)
        {
            if(_placeholderAdded && SearchBox.Text == SearchBoxPlaceholder)
            {
                SearchBox.Text = "";
                SearchBox.Foreground = _searchboxDefaultForeground ?? Brushes.Black;
                _placeholderAdded = false;
            }
        }
    }
}
