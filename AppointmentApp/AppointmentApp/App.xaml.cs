using Prism;
using Prism.Ioc;
using AppointmentApp.ViewModels;
using AppointmentApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppointmentApp.Services;
using System.IO;
using Xamarin.Essentials;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppointmentApp
{
    public partial class App
    {
        

        public static DocRepository ItemsRepo { get; private set; }
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();


            ItemsRepo = new DocRepository(Path.Combine(FileSystem.AppDataDirectory,"Hospital.db"));

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SignUpPage, SignUpPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<AppointmentPage, AppointmentPageViewModel>();
        }
    }
}
