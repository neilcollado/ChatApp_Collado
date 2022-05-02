using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_Collado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private static string message = "";

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            UsernameField.Text = message;
            EmailField.Text = message;
            PassField.Text = message;
            CPassField.Text = message;
        }
    }
}