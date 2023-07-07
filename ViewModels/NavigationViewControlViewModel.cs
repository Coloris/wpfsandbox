using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Ui.Common;
using Wpf.Ui.Controls.IconElements;
using Wpf.Ui.Controls.Navigation;

namespace WpfSandBox.ViewModels
{
    public partial class NavigationViewControlViewModel : ObservableObject
    {
        public NavigationViewControlViewModel()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }

        [ObservableProperty]
        private string _titleBarName = "Test App";

        [ObservableProperty]
        private bool _isToogleVisible = false;

        [ObservableProperty]
        private ObservableCollection<object> _navigationItems = new();

        private bool _isInitialized = false;

        private void InitializeViewModel()
        {
            NavigationItems = new ObservableCollection<object>
            {
                new NavigationViewItem()
                {
                    Content = "Home",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 }
                },
                new NavigationViewItem()
                {
                    Content = "Data",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 }
                }
            };

            _isInitialized = true;
        }
    }
}
