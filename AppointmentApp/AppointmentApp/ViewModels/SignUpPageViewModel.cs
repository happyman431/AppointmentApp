﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentApp.ViewModels
{
    public class SignUpPageViewModel : ViewModelBase
    {
        public SignUpPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
        }
}
