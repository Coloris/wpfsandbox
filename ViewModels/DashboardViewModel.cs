using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSandBox.ViewModels
{
    public class DashboardViewModel : ObservableObject
    {
        public DashboardViewModel()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }

        private bool _isInitialized = false;

        public NavigationViewControlViewModel? NavigationViewControlViewModel { get; set; }

        private void InitializeViewModel()
        {
            NavigationViewControlViewModel = new NavigationViewControlViewModel();

            _isInitialized = true;
        }
     }
}