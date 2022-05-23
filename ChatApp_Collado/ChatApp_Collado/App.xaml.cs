using ChatApp_Collado.Models;
using ChatApp_Collado.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_Collado
{
    public partial class App : Application
    {
        public static User user = new User()
        {
            Id = 101,
            Username = "Neil Collado",
            Email = "neilcollado@gmail.com",
            Contacts = new ObservableCollection<User>
            {
                new User { Id = 202, Username = "John Doe",  Email = "JohnDoe@gmail.com" },
            }
        };

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
