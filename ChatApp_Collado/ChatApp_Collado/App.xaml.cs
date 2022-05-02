using ChatApp_Collado.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_Collado
{
    public partial class App : Application
    {

        public App()
        {
            DependencyService.Register<CustomAlertMessage, ViewModels.LoginPageViewModel>();
            InitializeComponent();
            Routing.RegisterRoute("//ChatPage", typeof(ChatPage));
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
