using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_Collado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public static string message = "";

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            EmailField.Text = message;
            PassField.Text = message;
        }
    }
}