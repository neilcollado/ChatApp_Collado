using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Text.RegularExpressions;

namespace ChatApp_Collado.ViewModels
{
    class ForgotPasswordPageViewModel : BindableObject, CustomAlertMessage
    {
       public ForgotPasswordPageViewModel()
        {
            ToggleResetLink = new Command(ResetLink);
        }

        public ICommand ToggleResetLink { get; }

        private static string Email = "";
        Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public string EmailEntry { get => Email; set { Email = value; OnPropertyChanged(); } }

        public async void ResetLink()
        {
            if(!HasError())
            {
                if (ValidateEmail())
                {
                    await ShowAsync("Success", "Email has been sent to your email address");
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                else
                    await ShowAsync("Success", "Email Invalid.");
            }
                
            else
                await ShowAsync("Error", "Missing Field");
        }

        public bool HasError()
        {
            return string.IsNullOrWhiteSpace(EmailEntry) ? true : false;
        }

        private bool ValidateEmail()
        {
            return EmailRegex.IsMatch(EmailEntry);
        }

        public async Task ShowAsync(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "OK");
        }

    }
}
