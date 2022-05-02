using ChatApp_Collado.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Text.RegularExpressions;
using ChatApp_Collado.Models;

namespace ChatApp_Collado.ViewModels
{
    class LoginPageViewModel : BindableObject, CustomAlertMessage
    {
        public LoginPageViewModel()
        {
            ToggleShowHide = new Command(ShowHide);
            ToggleSignInValidate = new Command(SignInValidate);
            ToggleRedirectToCreateAccount = new Command(RedirectToCreateAccount);
            ToggleForgotPassword = new Command(ForgotPassword);
        }

        public ICommand ToggleShowHide { get; }
        public ICommand ToggleSignInValidate { get; }
        public ICommand ToggleRedirectToCreateAccount { get; }
        public ICommand ToggleForgotPassword { get; }

        public static string Message = "Show";
        private static string Email = "";
        private static string Pass = "";
        public bool isHide = true;
        readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public string EmailEntry { get => Email; set { Email = value; OnPropertyChanged(); } }
        public string PassEntry { get => Pass; set { Pass= value; OnPropertyChanged(); } }

        public async void SignInValidate()
        {
            if(!HasError())
            {
                if(ValidateEmail())
                    await Shell.Current.GoToAsync("//ChatPage", false);
                else
                    await ShowAsync("Error", "Email not verified. Sent another verification email.");
            }
            else
                await ShowAsync("Error", "Missing fields");
        }

        private bool HasError()
        {
            return string.IsNullOrWhiteSpace(EmailEntry) || string.IsNullOrWhiteSpace(PassEntry);
        }

        private bool ValidateEmail()
        {
            return EmailRegex.IsMatch(EmailEntry);
        }

        /* Toggle Show/Hide Code */

        public bool HidePassword
        {
            get => isHide;
            set
            {
                if (value != isHide)
                {
                    isHide = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ShowHidePass
        {
            get => Message;
            set
            {
                if (value == Message)
                    return;
                Message = value;
                OnPropertyChanged();
            }
        }

        public void ShowHide()
        {
            ShowHidePass = HidePassword ? "Hide" : "Show";
            HidePassword = !HidePassword;
        }

  
    
        public async Task ShowAsync(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "OK");
        }

        public async void RedirectToCreateAccount()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CreateAccountPage());
        }

        public async void ForgotPassword()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
        }

    }
}
