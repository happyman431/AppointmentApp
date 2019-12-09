using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentApp.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private DelegateCommand _appointmentCommand;
        public DelegateCommand AppointmentCommand =>
            _appointmentCommand ?? (_appointmentCommand = new DelegateCommand(ExecuteAppointmentCommand));

        private async void ExecuteAppointmentCommand()
        {

            await NavigationService.NavigateAsync("AppointmentPage");

        }

        
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Appointments";
        }
    }
}

        
        

        
    

