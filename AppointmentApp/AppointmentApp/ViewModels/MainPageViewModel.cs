using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppointmentApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _signup;
        public DelegateCommand SignUp =>
            _signup ?? (_signup = new DelegateCommand(ExecuteSignUp));
        private DelegateCommand _Homepage;
        public DelegateCommand HomePage =>
            _Homepage ?? (_Homepage = new DelegateCommand(ExecuteHomePage));

        async void ExecuteHomePage()
        {
            await NavigationService.NavigateAsync("HomePage");
        }

        async void ExecuteSignUp()
        {
            await NavigationService.NavigateAsync("SignUpPage");

        }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            
        }
    }
}
