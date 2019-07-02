using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        string matchesDisplay = string.Empty;
        public string MatchesDisplay
        {
            get
            {
                return matchesDisplay;
            }
            set
            {
                SetProperty(ref matchesDisplay, value);
            }
        }


        private INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Main Page";
        }
    }
}
